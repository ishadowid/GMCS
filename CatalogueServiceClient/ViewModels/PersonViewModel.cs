using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatalogueServiceClient.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        private string _name;
        private string _phoneNumber;
        private int _id;

        public Int32 Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                    SetProperty(ref _id, value);
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
    }
}
