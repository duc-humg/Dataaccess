using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dataaccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string image, string name , string time , string noidung)
        {
            InitializeComponent();
            images.Source = image;
            names.Text = name;
            times.Text = time;
            noidung1.Text = noidung;
        }
    }
}