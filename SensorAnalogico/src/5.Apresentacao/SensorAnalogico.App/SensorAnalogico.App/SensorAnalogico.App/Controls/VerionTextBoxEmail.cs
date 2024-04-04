using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;
using System.Text.RegularExpressions;

namespace SensorAnalogico.App.Controls
{
    public class VerionTextBoxEmail : TextBox
    {
        public static readonly StyledProperty<bool> IsEmailValidProperty =
            AvaloniaProperty.Register<VerionTextBoxEmail, bool>(nameof(IsEmailValid), true, true);

        public bool IsEmailValid
        {
            get => GetValue(IsEmailValidProperty);
            private set => SetValue(IsEmailValidProperty, value);
        }

        public VerionTextBoxEmail()
        {
            this.GetObservable(TextProperty).Subscribe(text =>
            {
                IsEmailValid = IsValidEmail(text!);
                Foreground = IsEmailValid ? Brushes.Black : Brushes.Red;
            });
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Implementação simples de validação de e-mail
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
