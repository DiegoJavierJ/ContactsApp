using ContactApplication.Models;
using ContactApplication.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactApplication.ModelViews
{
    public class ContactAppViewModel
    {
        public ICommand AddNavigation { get; set; }
        public ICommand AddContact { get; set; }
        public Contact ContactsTapped { get; set; } = new Contact();
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public ContactAppViewModel()
        {
            AddNavigation = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddPage());
            });

            AddContact = new Command(async() =>
            {
                Contacts.Add(new Contact() { Name = ContactsTapped.Name, Number = ContactsTapped.Number });
                await App.Current.MainPage.Navigation.PushAsync(new ContactApplication());
            });
        }
    }


}
