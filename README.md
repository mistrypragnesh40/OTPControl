# OTP Entry Control For Xamarin Forms

Otp Entry Control - is cross platform plugin for Xamairn Forms which allows you to enter specified length otp.

![image](https://user-images.githubusercontent.com/47309472/143923671-6f592dd3-a764-44d3-bd21-58392a2f88d1.png)

<h2> How To Use </h2> 

Available on Nuget : https://www.nuget.org/packages/OTPEntryControl/1.0.4  
Install this Plugin in your Xamarin Form Project.

Youtube : https://youtu.be/pdA45xF2G_U

## Implementation Example
namespace :  xmlns:otpcontrol="clr-namespace:OTPControl;assembly=OTPControl"

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" xmlns:otpcontrol="clr-namespace:OTPControl;assembly=OTPControl"
             x:Class="App1.MainPage">

    <StackLayout>
        <Frame BackgroundColor="#2196F3" Padding="24" CornerRadius="0">
            <Label Text="Welcome to Xamarin.Forms!" HorizontalTextAlignment="Center" TextColor="White" FontSize="36"/>
        </Frame>
        <Label Text="Start developing now" FontSize="Title" Padding="30,10,30,10"/>
       
        <otpcontrol:CustomOtpControl FillBorderColor="Orange" EmptyBorderColor="Gray"   OtpLength="4" HorizontalOptions="Center"  />
    </StackLayout>

</ContentPage>


## Property
1. OtpLength : You can set the number like 4 digit or 6 digit.
2. FillBorderColor : Entered Otp Tint Color.
3. EmptyBorderColor: Default Border Color.
4. SelectedOtp : This Property will return Entered Otp in Text Format.
5. HorizontalSpacing: This Property used for setting horizontal space.
6. VerticalSpacing : This property used for setting vertical space


## How To Get OTP Text on Button Click (ViewModel)
```
<otpcontrol:CustomOtpControl x:Name="otpControlName"  OtpLength="5" FillBorderColor="Orange"   HorizontalOptions="Center"  />  
<Button Text="Get Otp"  Command="{Binding GetOtpCommand}" CommandParameter="{Binding Source={x:Reference otpControlName},Path=SelectedOtp}" />
```

