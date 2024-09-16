using Microsoft.Maui.Controls;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        private static readonly Random _random = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollButtonClicked(object sender, EventArgs e)
        {
            int maxValue = 6;

            if (RbK4.IsChecked)
                maxValue = 4;
            else if (RbK10.IsChecked)
                maxValue = 10;
            else if (RbK12.IsChecked)
                maxValue = 12;

            int result = _random.Next(1, maxValue + 1);
            ResultLabel.Text = $"Wynik: {result}";
        }
    }
}
namespace MauiApp2
{
}
