using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIBMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiClickEvent;
        }

        private void ButtonBmiClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);
            if(height <= 10)
            {
                LabelResult.Text = "" + (weight / ( height * height ));
            }
            else
            {
                LabelResult.Text = "" + (weight / ((height/100) * (height/100)));
            }
                


        }

        private void ButtonBmiClickEvent2(object sender,EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            float weight = float.Parse(EntryWeight.Text);
            if(height <= 10)
            {
                float bmi = weight / (height * height);
                Navigation.PushAsync(new BMIResult(bmi));
            }
            else
            {
                float bmi = weight / ((height/100) * (height/100));
                Navigation.PushAsync(new BMIResult(bmi));
            }
            
            
        }
           
    }
}
