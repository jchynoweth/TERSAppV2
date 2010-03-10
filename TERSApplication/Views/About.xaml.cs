namespace TERSApplication
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using TERSApplication.Resources;

    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.AboutPageTitle;
        }

        /// <summary>
        ///     Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}