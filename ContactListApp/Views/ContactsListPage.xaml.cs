
using ContactListApp.Models;
using ContactListApp.Models.ViewModels;

namespace ContactListApp.Views;

public partial class ContactsListPage : ContentPage
{
	public ContactsListPage()
	{
		InitializeComponent();
	}

	private async void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		if (e.Item is not Contact contact)
			return;

		var contactViewModel = new ContactDetailViewModel { Contact = contact };
		var contactDetail = new ContactDetailPage
		{
			BindingContext = contactViewModel
		};
		await Navigation.PushAsync(contactDetail);

		if (sender is ListView listView)
			listView.SelectedItem = null;
	}
}