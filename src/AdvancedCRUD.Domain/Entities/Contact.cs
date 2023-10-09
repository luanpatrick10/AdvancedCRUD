using AdvancedCRUD.Domain.CommomEntities;

namespace AdvancedCRUD.Domain.Entities
{
    public class Contact : Entity
    {
        public Contact(List<dynamic> idsPeoplesContacts)
        {
            IdsPeoplesContacts = idsPeoplesContacts;
            Validate();
        }

        public List<dynamic> IdsPeoplesContacts { get; private set; }
        public override void Validate()
        {
            Console.Write("´Validated");
        }
    }
}
