using MeasurementConverter.ViewModel;
using Xamarin.Forms;

namespace MeasurementConverter.View
{
    public partial class MunitConverter : ContentPage
    {
        public MunitConverter()
        {
            InitializeComponent();

            BindingContext = new MunitConverterViewModel();
        }
    }
}
