using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CatalogueService
{
    //Написать WCF службы, имитирующие работу с адресной книгой. Службы должны работать с сущностью Контактное лицо (ФИО, телефон) и поддерживать следуюшие операции:

    //Получение всех контактов
    //Поиск контакта по телефону
    //Поиск контакта по ФИО
    //Добавление контакта в адресную книгу
    //Изменение телефону у конктактного лица
    //Удление контакта из адресной книги

    //Написать WPF приложение, являющееся интерфейсом для работы с написанными службами.

    public class PersonNotFound
    { }

    [ServiceContract]
    public interface IPeopleCatalogueService
    {
        [OperationContract]
        IEnumerable<Person> GetAddressBook();

        [OperationContract]
        IEnumerable<Person> SearchPersonByPhone(string phoneNumber);

        [OperationContract]
        IEnumerable<Person> SearchPersonByName(string name);

        [OperationContract]
        Int32 AddPerson(Person newPerson);

        [OperationContract]
        [FaultContractAttribute(
            typeof(PersonNotFound))]
        void UpdatePerson(Person newPerson);

        [OperationContract]
        [FaultContractAttribute(
            typeof(PersonNotFound))]
        void DeletePerson(Person newPerson);
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
