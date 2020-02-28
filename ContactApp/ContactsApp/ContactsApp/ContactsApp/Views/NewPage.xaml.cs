using ContactsApp.Models;
using ContactsApp.ModelViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        public NewPage(ObservableCollection<Contact> contact)
        {
            InitializeComponent();
            BindingContext = new DisplayContacts(contact); 

        }
    }
}