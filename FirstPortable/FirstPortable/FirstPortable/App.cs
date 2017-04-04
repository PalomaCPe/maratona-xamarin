using FirstPortable.Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirstPortable
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "FirstPortable",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            #if __IOS__
                                Text = "Welcome to iOS Xamarin Forms!"              
                            #elif __ANDROID__
                                Text = "Welcome to Android Xamarin Forms!"              
                            #elif WINDOWS_UWP
                                Text = "Welcome to Windows UWP Xamarin Forms!"              
                            #elif WINDOWS_APP
                                Text = "Welcome to Windows Xamarin Forms!"              
                            #elif WINDOWS_PHONE_APP
                                Text = "Welcome to Windows Phone Xamarin Forms!"     
                            #else
                                Text = "Welcome",
                            #endif
                            TextColor = Color.Aqua
                        }
                    }
                }
            };

            MainPage = new GreetingsPage();//new NavigationPage(content);
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
