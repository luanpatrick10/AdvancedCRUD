namespace AdvancedCRUD.Domain.CommomEntities
{
    public abstract class Entity
    {
        public dynamic? Id { get; set; }
        public abstract void Validate();
    }
}
