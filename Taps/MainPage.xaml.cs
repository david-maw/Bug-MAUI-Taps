using System.Diagnostics;

namespace Taps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnTap(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
        {
            Debug.WriteLine(">>> OnTap Called");
        }
        private void OnDoubleTap(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
        {
            Debug.WriteLine(">>> OnDoubleTap Called");
        }
    }
}