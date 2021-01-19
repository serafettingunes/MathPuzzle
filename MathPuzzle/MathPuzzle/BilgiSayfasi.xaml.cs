using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MathPuzzle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BilgiSayfasi : ContentPage
    {
        public BilgiSayfasi()
        {
            InitializeComponent();
        }

        private void btnileri_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ResimBilgi());
        }
    }
}