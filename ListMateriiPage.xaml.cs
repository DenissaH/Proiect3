using Proiect3.Models;
namespace Proiect3;

public partial class ListMateriiPage : ContentPage
{
	public ListMateriiPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.MaterieDatabase.GetMaterieAsync();
    }
    async void OnMateriiAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new Materie()
        });
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as Materie
            });
        }

    }
}