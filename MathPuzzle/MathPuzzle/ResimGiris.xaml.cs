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
    public partial class ResimGiris : ContentPage
    {
        public ResimGiris()
        {
            InitializeComponent();
            timer(3);
        }
        public void timer(double time)
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                time -= 1;
                if (time == 0)
                {
                    Navigation.PushModalAsync(new mathPuzzleGiris());
                    return false;
                }
                else
                {
                    return true;
                }

            }

            );
        }
    }
}