using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CountingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        public void Handle_Clicked(object sender, System.EventArgs e)
        {
            int weight = Int32.Parse(Inp_weight.Text);
            int height = Int32.Parse(Inp_height.Text);
            int BMI = (int)(weight / Convert.ToDouble(height *height) * 703);
            Lbl_BMI.Text = $"Your BMI is {BMI}";
        }
    }
}
