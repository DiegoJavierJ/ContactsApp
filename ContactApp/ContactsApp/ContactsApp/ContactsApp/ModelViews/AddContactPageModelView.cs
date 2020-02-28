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
    public class AddContactPageModelView : INotifyPropertyChanged
    {
        public ICommand AddContact { get; set; }
        public Contact ContactsTapped { get; set; } = new Contact();
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        public AddContactPageModelView()
        {
            AddContact = new Command(async () =>
            {
                Contacts.Add(new Contact() { Name = ContactsTapped.Name, Number = ContactsTapped.Number });
                await App.Current.MainPage.Navigation.PushAsync(new ContactPage());
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
