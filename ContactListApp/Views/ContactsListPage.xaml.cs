
using ContactListApp.Models;
using ContactListApp.Models.ViewModels;

namespace ContactListApp.Views;

public partial class ContactsListPage : ContentPage
{
	public ContactsListPage()
	{
		InitializeComponent();
	}

	private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var contact = e.Item as Contact;
		var contactViewModel = new ContactDetailViewModel { Contact = contact };
		var contactDetail = new ContactDetail();
		contactDetail.BindingContext = contactViewModel;
		Navigation.PushAsync(contactDetail);
		contact = "";
	}
}