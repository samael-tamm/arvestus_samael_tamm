using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace arvestus_samael_tamm
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int loginattempts = 3;
        private void login_Click(object sender, RoutedEventArgs e)
        {
            string username = "user";
            string password = "SecretPassword";

            if (loginattempts>0)
            {
                if(usernamebox.Text==username && passwordbox.Password==password)
                {
                    logininfobox.Text = "Logged on!";
                    this.Frame.Navigate(typeof(Content));
                    
                }
                else
                {
                    loginattempts--;
                    logininfobox.Text = "Login failed. Remaining attempts: " + loginattempts;
                }

            }
            
            if(loginattempts<=0)
            {
                login.IsEnabled = false;
                usernamebox.IsEnabled = false;
                passwordbox.IsEnabled = false;
                logininfobox.Text = "No more login attempts";
            }
        }
    }
}
