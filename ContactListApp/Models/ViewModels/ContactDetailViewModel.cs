using CommunityToolkit.Mvvm.ComponentModel;
using ContactListApp.Models;

namespace ContactListApp.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}
