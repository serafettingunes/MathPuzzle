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
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
            SadeceOkunabilir();
            islemler();
            islemler2();
            islemler3();
            islemler4();
            islemler5();
            islemler6();
            islemler7();
            islemler8();
            islemler9();
            islemler10();
           
        }

        public void SadeceOkunabilir()
        {
            entry12.IsReadOnly = true;
            entry14.IsReadOnly = true;

            entry21.IsReadOnly = true;
            entry23.IsReadOnly = true;
            entry25.IsReadOnly = true;

            entry32.IsReadOnly = true;
            entry34.IsReadOnly = true;

            entry41.IsReadOnly = true;
            entry43.IsReadOnly = true;
            entry45.IsReadOnly = true;

            entry52.IsReadOnly = true;
            entry54.IsReadOnly = true;

        }

        Random rnd = new Random();
        int isaretRnd, isaretRnd2;
        int degisken11, degisken13, degisken15, degisken16;
        int degisken22, degisken24, degisken26, degisken27;
        int degisken31, degisken33, degisken35, degisken36;
        int degisken42, degisken44, degisken46, degisken47;
        int degisken51, degisken53, degisken55, degisken56;
        int degisken61;
        int degisken72;
        int degisken62;
        int degisken63;
        int degisken64;
        int degisken74;
        int degisken65;

        public void tebrikler()
        {
            if (entry11.Text == degisken11.ToString() && entry13.Text == degisken13.ToString() && entry15.Text==degisken15.ToString() && entry22.Text==degisken22.ToString()&& entry24.Text==degisken24.ToString()&& entry26.Text==degisken26.ToString() && entry31.Text==degisken31.ToString()&& entry33.Text==degisken33.ToString() && entry35.Text==degisken35.ToString() && entry42.Text==degisken42.ToString()&&entry44.Text==degisken44.ToString()&& entry46.Text==degisken46.ToString()&&entry51.Text==degisken51.ToString()&&entry53.Text==degisken53.ToString()&& entry55.Text==degisken55.ToString() && entry62.Text==degisken62.ToString()&& entry64.Text==degisken64.ToString() )
            {
                imageX.Source = "tebriklersiyah.png";
                btnCikis.IsVisible = true;
                btnTekrar.IsVisible = true;
            }
        }
        public void islemler10()
        {
            if (entry25.Text == "*")
            {

                if (entry45.Text == "*")
                {

                    degisken65 = degisken15 * degisken35 * degisken55;
                }
                else if (entry45.Text == "+")
                {

                    degisken65 = degisken15 * degisken35 + degisken55;
                }
                else if (entry45.Text == "-")
                {

                    degisken65 = degisken15 * degisken35 - degisken55;
                }
            }
            else if (entry25.Text == "+")
            {

                if (entry45.Text == "*")
                {

                    degisken65 = degisken15 + degisken35 * degisken55;
                }
                else if (entry45.Text == "+")
                {

                    degisken65 = degisken15 + degisken35 + degisken55;
                }
                else if (entry45.Text == "-")
                {

                    degisken65 = degisken15 + degisken35 - degisken55;
                }
            }

            else if (entry25.Text == "-")
            {

                if (entry45.Text == "*")
                {

                    degisken65 = degisken15 - degisken35 * degisken55;
                }
                else if (entry45.Text == "+")
                {

                    degisken65 = degisken15 - degisken35 + degisken55;
                }
                else if (entry45.Text == "-")
                {

                    degisken65 = degisken15 - degisken35 - degisken55;
                }
            }


            lbl65.Text = degisken65.ToString();

        }
        public void islemler9()
        {
            degisken64 = rnd.Next(1, 11);
            if (entry34.Text == "*")
            {

                if (entry54.Text == "*")
                {

                    degisken74 = degisken24 * degisken44 * degisken64;
                }
                else if (entry54.Text == "+")
                {

                    degisken74 = degisken24 * degisken44 + degisken64;
                }
                else if (entry54.Text == "-")
                {

                    degisken74 = degisken24 * degisken44 - degisken64;
                }
            }
            else if (entry34.Text == "+")
            {

                if (entry54.Text == "*")
                {

                    degisken74 = degisken24 + degisken44 * degisken64;
                }
                else if (entry54.Text == "+")
                {

                    degisken74 = degisken24 + degisken44 + degisken64;
                }
                else if (entry54.Text == "-")
                {

                    degisken74 = degisken24 + degisken44 - degisken64;
                }
            }

            else if (entry34.Text == "-")
            {

                if (entry54.Text == "*")
                {

                    degisken74 = degisken24 - degisken44 * degisken64;
                }
                else if (entry54.Text == "+")
                {

                    degisken74 = degisken24 - degisken44 + degisken64;
                }
                else if (entry54.Text == "-")
                {

                    degisken74 = degisken24 - degisken44 - degisken64;
                }
            }


            lbl74.Text = degisken74.ToString();
        }

        public void islemler8()
        {
            if (entry23.Text == "*")
            {

                if (entry43.Text == "*")
                {

                    degisken63 = degisken13 * degisken33 * degisken53;
                }
                else if (entry43.Text == "+")
                {

                    degisken63 = degisken13 * degisken33 + degisken53;
                }
                else if (entry43.Text == "-")
                {

                    degisken63 = degisken13 * degisken33 - degisken53;
                }
            }
            else if (entry23.Text == "+")
            {

                if (entry43.Text == "*")
                {

                    degisken63 = degisken13 + degisken33 * degisken53;
                }
                else if (entry43.Text == "+")
                {

                    degisken63 = degisken13 + degisken33 + degisken53;
                }
                else if (entry43.Text == "-")
                {

                    degisken63 = degisken13 + degisken33 - degisken53;
                }
            }

            else if (entry23.Text == "-")
            {

                if (entry43.Text == "*")
                {

                    degisken63 = degisken13 - degisken33 * degisken53;
                }
                else if (entry43.Text == "+")
                {

                    degisken63 = degisken13 - degisken33 + degisken53;
                }
                else if (entry43.Text == "-")
                {

                    degisken63 = degisken13 - degisken33 - degisken53;
                }
            }


            lbl63.Text = degisken63.ToString();
        }
        public void islemler7()
        {
            degisken62 = rnd.Next(1, 11);

            if (entry32.Text == "*")
            {

                if (entry52.Text == "*")
                {

                    degisken72 = degisken22 * degisken42 * degisken62;
                }
                else if (entry52.Text == "+")
                {

                    degisken72 = degisken22 * degisken42 + degisken62;
                }
                else if (entry52.Text == "-")
                {

                    degisken72 = degisken22 * degisken42 - degisken62;
                }
            }
            else if (entry32.Text == "+")
            {

                if (entry52.Text == "*")
                {

                    degisken72 = degisken22 + degisken42 * degisken62;
                }
                else if (entry52.Text == "+")
                {

                    degisken72 = degisken22 + degisken42 + degisken62;
                }
                else if (entry52.Text == "-")
                {

                    degisken72 = degisken22 + degisken42 - degisken62;
                }
            }

            else if (entry32.Text == "-")
            {

                if (entry52.Text == "*")
                {

                    degisken72 = degisken22 - degisken42 * degisken62;
                }
                else if (entry52.Text == "+")
                {

                    degisken72 = degisken22 - degisken42 + degisken62;
                }
                else if (entry52.Text == "-")
                {

                    degisken72 = degisken22 - degisken42 - degisken62;
                }
            }


            lbl72.Text = degisken72.ToString();
        }
        public void islemler6()
        {
            isaret();
            isaret2();

            if (isaretRnd == 1)
            {
                entry21.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry41.Text = "*";
                    degisken61 = degisken11 * degisken31 * degisken51;
                }
                else if (isaretRnd2 == 2)
                {
                    entry41.Text = "+";
                    degisken61 = degisken11 * degisken31 + degisken51;
                }
                else if (isaretRnd2 == 3)
                {
                    entry41.Text = "-";
                    degisken61 = degisken11 * degisken31 - degisken51;
                }
            }
            else if (isaretRnd == 2)
            {
                entry21.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry41.Text = "*";
                    degisken61 = degisken11 + degisken31 * degisken51;
                }
                else if (isaretRnd2 == 2)
                {
                    entry41.Text = "+";
                    degisken61 = degisken11 + degisken31 + degisken51;
                }
                else if (isaretRnd2 == 3)
                {
                    entry41.Text = "-";
                    degisken61 = degisken11 + degisken31 - degisken51;
                }
            }

            else if (isaretRnd == 3)
            {
                entry21.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry41.Text = "*";
                    degisken61 = degisken11 - degisken31 * degisken51;
                }
                else if (isaretRnd2 == 2)
                {
                    entry41.Text = "+";
                    degisken61 = degisken11 - degisken31 + degisken51;
                }
                else if (isaretRnd2 == 3)
                {
                    entry41.Text = "-";
                    degisken61 = degisken11 - degisken31 - degisken51;
                }
            }


            lbl61.Text = degisken61.ToString();

        }
        public void islemler5()
        {
            degisken51 = rnd.Next(1, 11);
            degisken53 = rnd.Next(1, 11);
            degisken55 = rnd.Next(1, 11);
            isaret();
            isaret2();
            if (isaretRnd == 1)
            {
                entry52.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry54.Text = "*";
                    degisken56 = degisken51 * degisken53 * degisken55;
                }
                else if (isaretRnd2 == 2)
                {
                    entry54.Text = "+";
                    degisken56 = degisken51 * degisken53 + degisken55;
                }
                else if (isaretRnd2 == 3)
                {
                    entry54.Text = "-";
                    degisken56 = degisken51 * degisken53 - degisken55;
                }
            }
            else if (isaretRnd == 2)
            {
                entry52.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry54.Text = "*";
                    degisken56 = degisken51 + degisken53 * degisken55;
                }
                else if (isaretRnd2 == 2)
                {
                    entry54.Text = "+";
                    degisken56 = degisken51 + degisken53 + degisken55;
                }
                else if (isaretRnd2 == 3)
                {
                    entry54.Text = "-";
                    degisken56 = degisken51 + degisken53 - degisken55;
                }
            }

            else if (isaretRnd == 3)
            {
                entry52.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry54.Text = "*";
                    degisken56 = degisken51 - degisken53 * degisken55;
                }
                else if (isaretRnd2 == 2)
                {
                    entry54.Text = "+";
                    degisken56 = degisken51 - degisken53 + degisken55;
                }
                else if (isaretRnd2 == 3)
                {
                    entry54.Text = "-";
                    degisken56 = degisken51 - degisken53 - degisken55;
                }
            }


            lbl56.Text = degisken56.ToString();

        }
        public void islemler4()
        {
            degisken42 = rnd.Next(1, 11);
            degisken44 = rnd.Next(1, 11);
            degisken46 = rnd.Next(1, 11);
            isaret();
            isaret2();

            if (isaretRnd == 1)
            {
                entry43.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry45.Text = "*";
                    degisken47 = degisken42 * degisken44 * degisken46;
                }
                else if (isaretRnd2 == 2)
                {
                    entry45.Text = "+";
                    degisken47 = degisken42 * degisken44 + degisken46;
                }
                else if (isaretRnd2 == 3)
                {
                    entry45.Text = "-";
                    degisken47 = degisken42 * degisken44 - degisken46;
                }
            }
            else if (isaretRnd == 2)
            {
                entry43.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry45.Text = "*";
                    degisken47 = degisken42 + degisken44 * degisken46;
                }
                else if (isaretRnd2 == 2)
                {
                    entry45.Text = "+";
                    degisken47 = degisken42 + degisken44 + degisken46;
                }
                else if (isaretRnd2 == 3)
                {
                    entry45.Text = "-";
                    degisken47 = degisken42 + degisken44 - degisken46;
                }
            }

            else if (isaretRnd == 3)
            {
                entry43.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry45.Text = "*";
                    degisken47 = degisken42 - degisken44 * degisken46;
                }
                else if (isaretRnd2 == 2)
                {
                    entry45.Text = "+";
                    degisken47 = degisken42 - degisken44 + degisken46;
                }
                else if (isaretRnd2 == 3)
                {
                    entry45.Text = "-";
                    degisken47 = degisken42 - degisken44 - degisken46;
                }
            }


            lbl47.Text = degisken47.ToString();


        }
        public void islemler3()
        {
            degisken31 = rnd.Next(1, 11);
            degisken33 = rnd.Next(1, 11);
            degisken35 = rnd.Next(1, 11);
            isaret();
            isaret2();
            if (isaretRnd == 1)
            {
                entry32.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry34.Text = "*";
                    degisken36 = degisken31 * degisken33 * degisken35;
                }
                else if (isaretRnd2 == 2)
                {
                    entry34.Text = "+";
                    degisken36 = degisken31 * degisken33 + degisken35;
                }
                else if (isaretRnd2 == 3)
                {
                    entry34.Text = "-";
                    degisken36 = degisken31 * degisken33 - degisken35;
                }
            }
            else if (isaretRnd == 2)
            {
                entry32.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry34.Text = "*";
                    degisken36 = degisken31 + degisken33 * degisken35;
                }
                else if (isaretRnd2 == 2)
                {
                    entry34.Text = "+";
                    degisken36 = degisken31 + degisken33 + degisken35;
                }
                else if (isaretRnd2 == 3)
                {
                    entry34.Text = "-";
                    degisken36 = degisken31 + degisken33 - degisken35;
                }
            }

            else if (isaretRnd == 3)
            {
                entry32.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry34.Text = "*";
                    degisken36 = degisken31 - degisken33 * degisken35;
                }
                else if (isaretRnd2 == 2)
                {
                    entry34.Text = "+";
                    degisken36 = degisken31 - degisken33 + degisken35;
                }
                else if (isaretRnd2 == 3)
                {
                    entry34.Text = "-";
                    degisken36 = degisken31 - degisken33 - degisken35;
                }
            }


            lbl36.Text = degisken36.ToString();
        }
        public void islemler2()
        {
            degisken22 = rnd.Next(1, 11);
            degisken24 = rnd.Next(1, 11);
            degisken26 = rnd.Next(1, 11);
            isaret();
            isaret2();


            if (isaretRnd == 1)
            {
                entry23.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry25.Text = "*";
                    degisken27 = degisken22 * degisken24 * degisken26;
                }
                else if (isaretRnd2 == 2)
                {
                    entry25.Text = "+";
                    degisken27 = degisken22 * degisken24 + degisken26;
                }
                else if (isaretRnd2 == 3)
                {
                    entry25.Text = "-";
                    degisken27 = degisken22 * degisken24 - degisken26;
                }
            }
            else if (isaretRnd == 2)
            {
                entry23.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry25.Text = "*";
                    degisken27 = degisken22 + degisken24 * degisken26;
                }
                else if (isaretRnd2 == 2)
                {
                    entry25.Text = "+";
                    degisken27 = degisken22 + degisken24 + degisken26;
                }
                else if (isaretRnd2 == 3)
                {
                    entry25.Text = "-";
                    degisken27 = degisken22 + degisken24 - degisken26;
                }
            }

            else if (isaretRnd == 3)
            {
                entry23.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry25.Text = "*";
                    degisken27 = degisken22 - degisken24 * degisken26;
                }
                else if (isaretRnd2 == 2)
                {
                    entry25.Text = "+";
                    degisken27 = degisken22 - degisken24 + degisken26;
                }
                else if (isaretRnd2 == 3)
                {
                    entry25.Text = "-";
                    degisken27 = degisken22 - degisken24 - degisken26;
                }
            }


            lbl27.Text = degisken27.ToString();


        }

        public void islemler()
        {

            degisken11 = rnd.Next(1, 11);
            degisken13 = rnd.Next(1, 11);
            degisken15 = rnd.Next(1, 11);
            isaret();
            isaret2();
            if (isaretRnd == 1)
            {
                entry12.Text = "*";
                if (isaretRnd2 == 1)
                {
                    entry14.Text = "*";
                    degisken16 = degisken11 * degisken13 * degisken15;
                }
                else if (isaretRnd2 == 2)
                {
                    entry14.Text = "+";
                    degisken16 = degisken11 * degisken13 + degisken15;
                }
                else if (isaretRnd2 == 3)
                {
                    entry14.Text = "-";
                    degisken16 = degisken11 * degisken13 - degisken15;
                }
            }
            else if (isaretRnd == 2)
            {
                entry12.Text = "+";
                if (isaretRnd2 == 1)
                {
                    entry14.Text = "*";
                    degisken16 = degisken11 + degisken13 * degisken15;
                }
                else if (isaretRnd2 == 2)
                {
                    entry14.Text = "+";
                    degisken16 = degisken11 + degisken13 + degisken15;
                }
                else if (isaretRnd2 == 3)
                {
                    entry14.Text = "-";
                    degisken16 = degisken11 + degisken13 - degisken15;
                }
            }

            else if (isaretRnd == 3)
            {
                entry12.Text = "-";
                if (isaretRnd2 == 1)
                {
                    entry14.Text = "*";
                    degisken16 = degisken11 - degisken13 * degisken15;
                }
                else if (isaretRnd2 == 2)
                {
                    entry14.Text = "+";
                    degisken16 = degisken11 - degisken13 + degisken15;
                }
                else if (isaretRnd2 == 3)
                {
                    entry14.Text = "-";
                    degisken16 = degisken11 - degisken13 - degisken15;
                }
            }


            lbl16.Text = degisken16.ToString();


        }

        public void isaret()
        {
            isaretRnd = rnd.Next(1, 4);
            if (isaretRnd == 1)
            {
                isaretRnd = 1;
            }
            else if (isaretRnd == 2)
            {
                isaretRnd = 2;
            }
            else if (isaretRnd == 3)
            {
                isaretRnd = 3;
            }
        }

        public void isaret2()
        {
            isaretRnd2 = rnd.Next(1, 4);
            if (isaretRnd2 == 1)
            {
                isaretRnd2 = 1;
            }
            else if (isaretRnd2 == 2)
            {
                isaretRnd2 = 2;
            }
            else if (isaretRnd2 == 3)
            {
                isaretRnd2 = 3;
            }
        }


        private void entry11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry11.Text == degisken11.ToString())
            {
                entry11.BackgroundColor = Color.White;
            }
            else if (entry11.Text != degisken11.ToString())
            {
                entry11.BackgroundColor = Color.FromHex("3F3521");
            }

            tebrikler();
        }

        private void btnTekrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
            Navigation.PushModalAsync(new Anasayfa());
        }

        private void btnCikis_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void entry13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry13.Text == degisken13.ToString())
            {
                entry13.BackgroundColor = Color.White;
            }
            else if (entry13.Text != degisken13.ToString())
            {
                entry13.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry15_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry15.Text == degisken15.ToString())
            {
                entry15.BackgroundColor = Color.White;
            }
            else if (entry15.Text != degisken15.ToString())
            {
                entry15.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry22_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry22.Text == degisken22.ToString())
            {
                entry22.BackgroundColor = Color.White;
            }
            else if (entry22.Text != degisken22.ToString())
            {
                entry22.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry24_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry24.Text == degisken24.ToString())
            {
                entry24.BackgroundColor = Color.White;
            }
            else if (entry24.Text != degisken24.ToString())
            {
                entry24.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry26_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry26.Text == degisken26.ToString())
            {
                entry26.BackgroundColor = Color.White;
            }
            else if (entry26.Text != degisken26.ToString())
            {
                entry26.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry31_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry31.Text == degisken31.ToString())
            {
                entry31.BackgroundColor = Color.White;
            }
            else if (entry31.Text != degisken31.ToString())
            {
                entry31.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry33_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry33.Text == degisken33.ToString())
            {
                entry33.BackgroundColor = Color.White;
            }
            else if (entry33.Text != degisken33.ToString())
            {
                entry33.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry35_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry35.Text == degisken35.ToString())
            {
                entry35.BackgroundColor = Color.White;
            }
            else if (entry35.Text != degisken35.ToString())
            {
                entry35.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry42_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry42.Text == degisken42.ToString())
            {
                entry42.BackgroundColor = Color.White;
            }
            else if (entry42.Text != degisken42.ToString())
            {
                entry42.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry44_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry44.Text == degisken44.ToString())
            {
                entry44.BackgroundColor = Color.White;
            }
            else if (entry44.Text != degisken44.ToString())
            {
                entry44.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry46_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry46.Text == degisken46.ToString())
            {
                entry46.BackgroundColor = Color.White;
            }
            else if (entry46.Text != degisken46.ToString())
            {
                entry46.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry51_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry51.Text == degisken51.ToString())
            {
                entry51.BackgroundColor = Color.White;
            }
            else if (entry51.Text != degisken51.ToString())
            {
                entry51.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry53_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry53.Text == degisken53.ToString())
            {
                entry53.BackgroundColor = Color.White;
            }
            else if (entry53.Text != degisken53.ToString())
            {
                entry53.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry55_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry55.Text == degisken55.ToString())
            {
                entry55.BackgroundColor = Color.White;
            }
            else if (entry55.Text != degisken55.ToString())
            {
                entry55.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry62_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry62.Text == degisken62.ToString())
            {
                entry62.BackgroundColor = Color.White;
            }
            else if (entry62.Text != degisken62.ToString())
            {
                entry62.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }

        private void entry64_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (entry64.Text == degisken64.ToString())
            {
                entry64.BackgroundColor = Color.White;
            }
            else if (entry64.Text != degisken64.ToString())
            {
                entry64.BackgroundColor = Color.FromHex("3F3521");
            }
            tebrikler();
        }
    }
}