using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CatalogueService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PeopleCatalogueService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PeopleCatalogueService.svc or PeopleCatalogueService.svc.cs at the Solution Explorer and start debugging.
    public class PeopleCatalogueService : IPeopleCatalogueService
    {
        private static readonly Dictionary<Int32, Person> _personDictionary = new Dictionary<Int32, Person>
            {
                {1, new Person{ Id = 1, Name = "Иванов Иван Иванович", PhoneNumber = "1234567"}},
                {2, new Person{ Id = 2, Name = "Петров Петр Петрович", PhoneNumber = "8910111"}},
                {3, new Person{ Id = 3, Name = "Сидоров Дмитрий Иванович", PhoneNumber = "2131415"}},
                {4, new Person{ Id = 4, Name = "Козлов Сегей Александрович", PhoneNumber = "1617181"}}
            }; 

        public IEnumerable<Person> GetAddressBook()
        {
            return _personDictionary.Values;
        }

        public IEnumerable<Person> SearchPersonByPhone(string phoneNumber)
        {
            return _personDictionary.Where(p => p.Value.PhoneNumber.StartsWith(phoneNumber)).Select(p => p.Value);
        }

        public IEnumerable<Person> SearchPersonByName(string name)
        {
            return _personDictionary.Where(p => p.Value.Name.StartsWith(name)).Select(p => p.Value);
        }

        public Int32 AddPerson(Person newPerson)
        {
            var id = _personDictionary.Keys.Max() + 1;
            newPerson.Id = id;
            _personDictionary.Add(id, newPerson);
            return id;
        }

        public void UpdatePerson(Person newPerson)
        {
            if (!_personDictionary.ContainsKey(newPerson.Id))
                throw new FaultException<PersonNotFound>(new PersonNotFound());

            _personDictionary[newPerson.Id].PhoneNumber = newPerson.PhoneNumber;
        }

        public void DeletePerson(Person newPerson)
        {
            if (!_personDictionary.ContainsKey(newPerson.Id))
                throw new FaultException<PersonNotFound>( new PersonNotFound());

            _personDictionary.Remove(newPerson.Id);
        }
    }
}
