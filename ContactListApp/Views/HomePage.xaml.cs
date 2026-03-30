

using ContactListApp.Models.ViewModels;

namespace ContactListApp.Views;

public partial class HomePage : ContentPage
{
    private ContactListViewModel contactsViewModel;

    public HomePage()
    {
        InitializeComponent();
        contactsViewModel = new ContactListViewModel();
        BindingContext = contactsViewModel;
    }
}