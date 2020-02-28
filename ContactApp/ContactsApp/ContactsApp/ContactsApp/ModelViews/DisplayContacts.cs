using ContactsApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactsApp.ModelViews
{
    public class DisplayContacts
    {
        ObservableCollection<Contact> _contacts;
        public DisplayContacts(ObservableCollection<Contact> contacts)
        {
            _contacts = contacts;
        }
    }
}
