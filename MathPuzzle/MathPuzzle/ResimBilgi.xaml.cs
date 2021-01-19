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
    public partial class ResimBilgi : ContentPage
    {
        public ResimBilgi()
        {
            InitializeComponent();
        }

        private void btnGeri_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new BilgiSayfasi());
        }
    }
}