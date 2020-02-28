using ContactApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactApplication.ModelViews
{
    public class AddPageViewModel
    {
        public ICommand AddContact { get; set; }
        public Contact ContactsTapped { get; set; } = new Contact();
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public AddPageViewModel()
        {
            AddContact = new Command(async () =>
                {
                    Contacts.Add(new Contact() { Name = ContactsTapped.Name, Number = ContactsTapped.Number });
                    await App.Current.MainPage.Navigation.PushAsync(new ContactApplication());
                });
        }
    }
}       
