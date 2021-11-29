using OTPControl.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OTPControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomOtpControl : Grid
    {
        public static ObservableCollection<OtpEntryModel> EntryList { get; set; } = new ObservableCollection<OtpEntryModel>();

        public CustomOtpControl()
        {
            InitializeComponent();
            this.txtEditor.Focus();
        }

        public static readonly BindableProperty SelectedOtpProperty = BindableProperty.Create(
        propertyName: nameof(SelectedOtp),
        returnType: typeof(string),
        defaultValue: "",
        declaringType: typeof(CustomOtpControl),
        defaultBindingMode: BindingMode.TwoWay);

        public string SelectedOtp
        {
            get => (string)base.GetValue(SelectedOtpProperty);
            private set => base.SetValue(SelectedOtpProperty, value);
        }




        public static readonly BindableProperty FillBorderColorProperty = BindableProperty.Create(
         propertyName: nameof(FillBorderColor),
         returnType: typeof(Color),
         defaultValue: Color.LightBlue,
         declaringType: typeof(CustomOtpControl),
         defaultBindingMode: BindingMode.TwoWay);
        public Color FillBorderColor
        {
            get => (Color)base.GetValue(FillBorderColorProperty);
            set => base.SetValue(FillBorderColorProperty, value);
        }

        public static readonly BindableProperty EmptyBorderColorProperty = BindableProperty.Create(
        propertyName: nameof(EmptyBorderColor),
        returnType: typeof(Color),
        defaultValue: Color.Gray,
        declaringType: typeof(CustomOtpControl),
        defaultBindingMode: BindingMode.TwoWay);
        public Color EmptyBorderColor
        {
            get => (Color)base.GetValue(EmptyBorderColorProperty);
            set => base.SetValue(EmptyBorderColorProperty, value);
        }



        public static readonly BindableProperty OtpLengthProperty = BindableProperty.Create(
         propertyName: nameof(OtpLength),
         returnType: typeof(int),
         declaringType: typeof(CustomOtpControl),
         defaultBindingMode: BindingMode.TwoWay,
         propertyChanged: OtpLengthPropertyChanged);

        private static void OtpLengthPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomOtpControl)bindable;

            if (newValue != null)
            {
                for (int i = 0; i < (int)newValue; i++)
                {
                    EntryList.Add(new OtpEntryModel { Color = control.EmptyBorderColor, Text = "" });
                }

                control.txtEditor.MaxLength = (int)newValue;
            }
        }
        public int OtpLength
        {
            get => (int)base.GetValue(OtpLengthProperty);
            set => base.SetValue(OtpLengthProperty, value);
        }

        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry editor = sender as Entry;
            var context = (CustomOtpControl)this.BindingContext;
            if (editor.Text.Length > OtpLength)
            {
                editor.Text = editor.Text.Substring(0, OtpLength);
                return;
            }

            if (editor.Text.Length >= OtpLength)
            {
                editor.Unfocus();
            }

            for (int i = 0; i < OtpLength; i++)
            {
                try
                {
                    if (editor.Text.Length > i)
                    {
                        EntryList[i] = new OtpEntryModel { Text = editor.Text.Substring(i, 1), Color = context.FillBorderColor };
                    }
                    else
                    {
                        EntryList[i] = new OtpEntryModel { Text = "", Color = context.EmptyBorderColor };
                    }
                }
                catch (Exception ex)
                {
                    break;
                }

            }

            SelectedOtp = "";
            foreach (var entry in EntryList)
            {
                SelectedOtp += entry.Text;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_For_Focus(object sender, EventArgs e)
        {
            this.txtEditor.Focus();
        }
    }
}