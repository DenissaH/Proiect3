using Microsoft.Maui.Controls;
using Proiect3.Models;
using System;
namespace Proiect3;

public partial class ListProfesorPage : ContentPage
{
	public ListProfesorPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.GetProfesorDatabase().GetProfesorAsync();
    }

    async void OnProfesorListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new Profesor()
        });
    }
     async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as Profesor
            });
        }
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ProfesorList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.ProfesorDatabase.SaveProfesorListAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ProfesorList)BindingContext;
        await App.ProfesorDatabase.DeleteProfesorListAsync(slist);
        await Navigation.PopAsync();
    }
}