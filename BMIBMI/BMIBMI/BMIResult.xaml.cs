using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIBMI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BMIResult : ContentPage
	{
		public BMIResult ()
		{
			InitializeComponent();
		}

        public BMIResult(float bmi)
        {
            InitializeComponent();
            label1.Text = "" + bmi;
        }

        
	}
}