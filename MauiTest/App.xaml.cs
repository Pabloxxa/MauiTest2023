﻿namespace MauiTest
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

             var navPage = new NavigationPage(new PresentationControlsDemo());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            MainPage = navPage;
        }
    }
}