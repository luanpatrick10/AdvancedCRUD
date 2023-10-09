using AdvancedCRUD.Domain.CommomEntities;
using AdvancedCRUD.Domain.ObjectValue;
using System.Collections.ObjectModel;

namespace AdvancedCRUD.Domain.Entities
{
    public class People : Entity
    {
        private List<Contact> _contacts;
        public People(string name, string email, string cellPhone, Address address)
        {
            Name = name;
            Email = email;
            CellPhone = cellPhone;
            Address = address;
            _contacts = new List<Contact>();
            Contacts = new ReadOnlyCollection<Contact>(_contacts);
            Validate();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string CellPhone { get; private set; }
        public Address Address { get; private set; }
        public ReadOnlyCollection<Contact> Contacts { get; set; }

        public override void Validate()
        {
            Console.Write("´Validated");
        }

        public void AddContact(Contact contact)
        {
            DomainValidations.ValidateIfNotNull(contact, ValidationMessage.PropertyNullOrEmpty);
            _contacts.Add(contact);
        }
    }
}
