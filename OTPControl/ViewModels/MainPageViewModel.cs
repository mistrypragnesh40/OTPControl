using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OTPControl.ViewModels
{
    public class MainPageViewModel :BaseViewModel
    {
        private string _selectedOTP;
        public string SelectedOTP
        {
            get => _selectedOTP;
            set => SetProperty(ref _selectedOTP, value);

        }

        private string _selectedOTP1;
        public string SelectedOTP1
        {
            get => _selectedOTP1;
            set => SetProperty(ref _selectedOTP1, value);

        }


        public MainPageViewModel()
        {

        }


        public ICommand GetOtpCommand => new Command<string>((param) =>
         {
             SelectedOTP = param;
         });

        public ICommand GetOtpCommand1 => new Command<string>((param) =>
        {
            SelectedOTP1 = param;
        });
    }
}
