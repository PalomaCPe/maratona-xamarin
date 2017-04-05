using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AjaiouApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cats : ContentPage
    {
        public Cats()
        {
            InitializeComponent();

            ListViewCats.ItemSelected += ListViewCats_ItemSelected;
        }

        private async void ListViewCats_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedCat = e.SelectedItem as Models.Cat;
            if (SelectedCat != null)
            {
                await Navigation.PushAsync(new AjaiouApp.Views.DetailsPage(SelectedCat));
                ListViewCats.SelectedItem = null;
            }
        }
    }
}
