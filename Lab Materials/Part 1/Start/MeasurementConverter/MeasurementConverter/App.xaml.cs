using Xamarin.Forms;

namespace MeasurementConverter
{
    public partial class App : ContentPage
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MunitConverter();
        }
    }
}
