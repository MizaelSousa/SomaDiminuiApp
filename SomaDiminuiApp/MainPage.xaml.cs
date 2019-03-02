using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SomaDiminuiApp
{
    public partial class MainPage : ContentPage
    {
        void Aumentar(Object sender, EventArgs e)
        {
            int resultado = Int32.Parse(Result.Text) + 1;
            Result.Text = resultado.ToString();
        }

        void Diminuir(Object sender, EventArgs e)
        {
            int resultado = Int32.Parse(Result.Text) - 1;
            Result.Text = resultado.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
