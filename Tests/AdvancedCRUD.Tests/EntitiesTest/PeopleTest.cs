using AdvancedCRUD.Domain.CommomEntities;
using AdvancedCRUD.Domain.Entities;
using AdvancedCRUD.Domain.ObjectValue;
using Xunit;
using Xunit.Abstractions;

namespace AdvancedCRUD.Tests.EntitiesTest
{
    public class PeopleTest
    {
        private readonly ITestOutputHelper _output;

        public PeopleTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestAddContactInReadOnlyList()
        {
            string name = "Teste Name";
            string email = "test@teste.com";
            string cellPhone = "555-555-555";
            var listOfPeopleIds = new List<dynamic>() { 10 };
            Address address = new Address();
            Contact contact = new Contact(listOfPeopleIds);
            var people = new People(name, email, cellPhone, address);
            people.Contacts.Append(contact);
            Assert.Throws<ArgumentOutOfRangeException>(() => _output.WriteLine(Convert.ToString(people.Contacts[0].IdsPeoplesContacts[0])));
        }

        [Fact]
        public void TestAddContactNull()
        {
            string name = "Teste Name";
            string email = "test@teste.com";
            string emailUm = "test@teste.com";
            string cellPhone = "555-555-555";
            Address address = new Address();
            var people = new People(name, email, cellPhone, address);
            Assert.Throws<DomainExceptions> people.AddContact(null);
        }
    }
}
