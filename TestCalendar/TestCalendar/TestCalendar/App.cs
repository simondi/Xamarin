﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestCalendar
{
    public class App : Application
    {
        //public App()
        //{
        //    // The root page of your application
        //    var content = new ContentPage
        //    {
        //        Title = "TestCalendar",
        //        Content = new StackLayout
        //        {
        //            VerticalOptions = LayoutOptions.Center,
        //            Children = {
        //                new Label {
        //                    HorizontalTextAlignment = TextAlignment.Center,
        //                    Text = "Welcome to Xamarin Forms!"
        //                }
        //            }
        //        }
        //    };

        //    MainPage = new NavigationPage(content);
        //}

        public App()
        {
            MainPage = new HelloWorld();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
