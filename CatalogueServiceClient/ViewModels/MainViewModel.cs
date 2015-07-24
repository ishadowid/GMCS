using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows;
using CatalogueServiceClient.PeopleCatalogueServiceReference;

namespace CatalogueServiceClient.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IEnumerable<PersonViewModel> _dataCollection;

        public IEnumerable<PersonViewModel> DataCollection
        {
            get { return _dataCollection; }
            set
            {
                if (_dataCollection != value)
                    SetProperty(ref _dataCollection, value);
            }
        }

        public MainViewModel()
        {
            using (var client = new PeopleCatalogueServiceClient())
            {
                try
                {
                    DataCollection = new ObservableCollection<PersonViewModel>(client.GetAddressBook().Select(p => new PersonViewModel { Id = p.Id, Name = p.Name, PhoneNumber = p.PhoneNumber }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
