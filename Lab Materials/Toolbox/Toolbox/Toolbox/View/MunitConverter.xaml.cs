using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Toolbox.View
{
    public partial class MunitConverter : ContentPage
    {
        public MunitConverter()
        {
            InitializeComponent();

            startPicker.SelectedIndex = 0;
            endPicker.SelectedIndex = 4;
        }
    }
}
