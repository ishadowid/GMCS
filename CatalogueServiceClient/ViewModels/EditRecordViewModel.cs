using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueServiceClient.Enums;
using CatalogueServiceClient.PeopleCatalogueServiceReference;

namespace CatalogueServiceClient.ViewModels
{
    public class EditRecordViewModel : BaseViewModel
    {
        private Int32 _id;
        private String _name;
        private String _phoneNumber;
        private EditMode _mode;

        public int Id
        {
            get { return _id; }
        }

        public EditMode Mode
        {
            get { return _mode; }
            private set
            {
                if (_mode != value)
                {
                    SetProperty(ref _mode, value);
                    OnPropertyChanged("IsNewRecord");
                }

            }
        }

        public String Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                    SetProperty(ref _name, value);
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                    SetProperty(ref _phoneNumber, value);
            }
        }

        public Boolean IsNewRecord
        {
            get { return _mode == EditMode.Add; }
        }

        public EditRecordViewModel(PersonViewModel person, EditMode mode)
        {
            if (person != null)
            {
                _id = person.Id;
                Name = person.Name;
                PhoneNumber = person.PhoneNumber;
            }
            Mode = mode;
        }


    }
}
