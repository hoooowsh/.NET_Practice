using CyauthPrac.ViewModels;
using Firebase.Auth;
using MVVMEssentials.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CyauthPrac.Commands
{
    internal class RegisterCommand : AsyncCommandBase
    {
        private readonly RegisterViewModel _registerViewModel;
        private readonly FirebaseAuthProvider _firebaseAuthProvider;

        public RegisterCommand(RegisterViewModel registerViewModel, FirebaseAuthProvider firebaseAuthProvider)
        {
            _registerViewModel = registerViewModel;
            _firebaseAuthProvider = firebaseAuthProvider;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            string password = _registerViewModel.Password;
            string confirmPassword = _registerViewModel.ConfirmPassword;
            string email = _registerViewModel.Email;
            string username = _registerViewModel.Username;
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password much match!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                await _firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password, username);
                MessageBox.Show("Successfully registered!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed, please try again!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
