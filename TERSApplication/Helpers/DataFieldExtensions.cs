﻿namespace TERSApplication
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;

    /// <summary>
    ///     Provides extension methods for performing operations on a <see cref="DataField"/>.
    /// </summary>
    public static class DataFieldExtensions
    {
        /// <summary>
        ///     Replaces a <see cref="DataField" />'s <see cref="TextBox" /> control with another control,
        ///     taking care of automatically updating the bindings.
        /// </summary>
        /// <param name="newControl">The new control you're going to set as <see cref="DataField.Content" /></param>
        /// <param name="dataBindingProperty">The control's property that will be used for data binding</param>        
        public static void ReplaceTextBox(this DataField field, FrameworkElement newControl, DependencyProperty dataBindingProperty)
        {
            field.ReplaceTextBox(newControl, dataBindingProperty, binding => { });
        }

        /// <summary>
        ///     Replaces a <see cref="DataField" />'s <see cref="TextBox" /> control with another control,
        ///     taking care of automatically updating the bindings and overriding the existing converter
        ///     with another one
        /// </summary>
        /// <param name="newControl">The new control you're going to set as <see cref="DataField.Content" /></param>
        /// <param name="dataBindingProperty">The control's property that will be used for data binding</param>        
        /// <param name="bindingSetupFunction">
        ///     A function you can use to change parameters on the newly generated binding before
        ///     it is applied to <paramref name="newControl"/>
        /// </param>
        public static void ReplaceTextBox(this DataField field, FrameworkElement newControl, DependencyProperty dataBindingProperty, Action<Binding> bindingSetupFunction)
        {
            // Construct new binding by copying existing one, and sending it to bindingSetupFunction
            // for any changes the caller wants to perform
            Binding newBinding = field.Content.GetBindingExpression(TextBox.TextProperty).ParentBinding.CreateCopy();
            bindingSetupFunction(newBinding);

            // Replace field
            newControl.SetBinding(dataBindingProperty, newBinding);
            field.Content = newControl;
        }
    }
}
