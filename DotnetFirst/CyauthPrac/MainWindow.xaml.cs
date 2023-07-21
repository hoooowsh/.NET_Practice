using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Auth;

namespace CyauthPrac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // init .NET app
            InitializeComponent();

            // init firebase project settings
            //FirebaseApp.Create(new AppOptions()
            //{
            //    Credential = GoogleCredential.FromFile("../../../PrivateKey.json"),
            //});
        }

        private void Signin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //String email = UsernameTextBox.Text;
                //String password = PasswordTextBox.Password;
                //var user = await FirebaseConfig.SignUpUser(email, password);

            }
            catch (Exception ex)
            {

            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            string signUpUrl = "https://sheng-web.firebaseapp.com/";
            // Open the sign-up page in the user's default browser
            try
            {
                // Open the sign-up page in the user's default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = signUpUrl,
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle specific exception when the default browser is not found or executable file is not found
                MessageBox.Show($"Error occurred while opening the web page, default browser is not found: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (System.InvalidOperationException ex)
            {
                // Handle specific exception when starting the process is not possible
                MessageBox.Show($"Error occurred while opening the web page, failed to start the process: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                // Handle any other general exception
                MessageBox.Show($"Error occurred while opening the web page, other exceptions: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

