using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactListApp.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}
