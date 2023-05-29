using MauiTest.BindingDemo;
using MauiTest.MVVM.Views;

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
            //2. Flyout PageDemo
            //MainPage = new NavigationPage(new FlyoutPageDemo());
            #endregion
            #region
            //3. TabbedPageDemo
            #endregion
            #region  TabbedPage
            //var navPage = new NavigationPage(new TabbedPageDemo());
            #endregion
            #region  PresentationControlsDemo

            //var navPage = new NavigationPage(new PresentationControlsDemo());
            #endregion
            #region  CommandControlsDemo
            //var navPage = new NavigationPage(new CommandControlsDemo());
            #endregion
            #region  Input Controls Demo
            //var navPage = new NavigationPage(new InputControlsDemo());
            #endregion
            #region  Text Controls Demo
            //var navPage = new NavigationPage(new TextControlsDemo());
            #endregion
            #region  Activity Controls Demo
            //var navPage = new NavigationPage(new ActivityControlsDemo());
            #endregion
            #region  Collection Controls Demo
            //var navPage = new NavigationPage(new CollectionControlsDemo());
            #endregion
            #region  Binding Controls Demo
            //var navPage = new NavigationPage(new BindingDemoTest());
            #endregion
            #region  SliderPage  Demo
            //var navPage = new NavigationPage(new SliderPage());
            #endregion
            #region  PersonView Demo
            //var navPage = new NavigationPage(new PersonView());
            #endregion
            #region  PersonView Demo
            //var navPage = new NavigationPage(new PeopleView());
            #endregion
            #region  PersonView Demo
            //var navPage = new NavigationPage(new CommandsView());
            #endregion
            //#region  PersonView Demo
            //var navPage = new NavigationPage(new DemoAutoPropertyChangedView());
            //#endregion
            #region  PersonView Demo
            var navPage = new NavigationPage(new StyleDemoView());
            #endregion

            MainPage = navPage;
        }
    }
}