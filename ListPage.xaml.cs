using Microsoft.Maui.Controls;
using System;
using Proiect3.Models;
using Proiect3.Data;
namespace Proiect3;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.GetEleviListDatabase().GetEleviListAsync();
    }

    async void OnEleviListListAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new EleviList()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as EleviList
            });
        }
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (EleviList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.EleviDatabase.SaveEleviListAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (EleviList)BindingContext;
        await App.EleviDatabase.DeleteEleviListAsync(slist);
        await Navigation.PopAsync();
    }
}