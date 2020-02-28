using ContactsApp.Models;
using ContactsApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactsApp.ModelViews
{
    public class ContactPageModelView : INotifyPropertyChanged
    {
        Contact showContact;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddContact { get; set; }
        public Contact ContactsTapped { get; set; } = new Contact();
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public Contact ShowContact
        {
            get
            {
                return ShowContact;
            }
            set
            {
                showContact = value;
                if (showContact != null)
                    DisplayContacts();
            }
        }

        public ICommand AddNavigation { get; set; }
        public ContactPageModelView()
        {
            AddNavigation = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
            });

                AddContact = new Command(async () =>
                {
                    Contacts.Add(new Contact() { Name = ContactsTapped.Name, Number = ContactsTapped.Number });
                    await App.Current.MainPage.Navigation.PushAsync(new ContactPage());
                });

        }
        async void DisplayContacts()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NewPage(Contacts));
        }
    }
}
