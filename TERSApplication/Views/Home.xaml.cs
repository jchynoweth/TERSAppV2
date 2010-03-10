namespace TERSApplication
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using TERSApplication.Resources;

    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.HomePageTitle;
        }

        /// <summary>
        ///     Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void eventReadOnlyDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void eventReadOnlyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void  btnSelectevent_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        
    }
}