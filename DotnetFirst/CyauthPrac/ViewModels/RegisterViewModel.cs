﻿using CyauthPrac.Commands;
using Firebase.Auth;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyauthPrac.ViewModels
{
    internal class RegisterViewModel: ViewModelBase
    {
		private string? _email;
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				OnPropertyChanged(nameof(Email));
			}
		}

		private string? _username;
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
			}
		}

		private string? _password;
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		private string? _confirmPassword;
		public string ConfirmPassword
		{
			get
			{
				return _confirmPassword;
			}
			set
			{
				_confirmPassword = value;
				OnPropertyChanged(nameof(ConfirmPassword));
			}
		}

		public ICommand SubmitCommand { get; }

        public ICommand? NavigateLoginCommand { get; }

		public RegisterViewModel(FirebaseAuthProvider firebaseAuthProvider)
		{
			SubmitCommand = new RegisterCommand(this, firebaseAuthProvider);
		}
    }
}
