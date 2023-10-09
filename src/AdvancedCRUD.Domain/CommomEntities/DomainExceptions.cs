namespace AdvancedCRUD.Domain.CommomEntities
{
    public class DomainExceptions : Exception
    {
        public DomainExceptions()
        {
        }

        public DomainExceptions(string mensagem) : base(mensagem)
        {
        }

        public DomainExceptions(string mensagem, Exception exception) : base(mensagem, exception)
        {
        }
    }
}
