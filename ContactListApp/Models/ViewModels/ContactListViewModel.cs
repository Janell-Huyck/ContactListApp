using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListApp.Models;
using ContactListApp.Views;
using System.Collections.ObjectModel;

namespace ContactListApp.Models.ViewModels;

partial class ContactListViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Contact> contacts = new();

    [ObservableProperty]
    private Contact contact = new();

    [RelayCommand]
    private async Task AddAsync()
    {
        Contacts.Add(Contact);
        Contact = new();

        var contactList = new ContactsListPage
        {
            BindingContext = this
        };

        if (Application.Current?.MainPage is NavigationPage nav)
            await nav.PushAsync(contactList);
    }
}
