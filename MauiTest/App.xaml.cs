namespace MauiTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            #region
            //1. Content Page Demo
            //var navPage = new NavigationPage(new ContentPageDemo());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            #endregion   
            #region
            //2. Flyout Demo Page
            //MainPage = new NavigationPage(new FlyoutPageDemo());
            #endregion       
            #region
            //3. TabbedPageDemo
            #endregion

            var navPage = new NavigationPage(new TabbedPageDemo());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            MainPage = navPage;
        }
    }
}