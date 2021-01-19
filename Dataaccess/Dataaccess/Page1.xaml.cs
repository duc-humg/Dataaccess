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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new mylist();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var vm = (mylist)BindingContext;
            var lms = vm.list.Where(c => c.name.ToLower().Contains(search.Text.ToLower()));
            List1.ItemsSource = lms;
        }

        private async void List1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myday = e.Item as listmovies;
            await Navigation.PushAsync(new Page2(myday.image, myday.name, myday.time, myday.noidung));

        }
    }
}