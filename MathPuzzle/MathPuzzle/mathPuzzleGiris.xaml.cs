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
    public partial class mathPuzzleGiris : ContentPage
    {
        public mathPuzzleGiris()
        {
            InitializeComponent();
        }

        private void btnOyna_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Anasayfa());
        }

        private void btnBilgi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BilgiSayfasi());
        }

        private void btnAyarlar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}