namespace VerticalSliceArchitecture.Domain.Entities
{
    public class Role(string name, string description) : Entity
    {
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
        public ICollection<User> Users { get; private set; }
    }
}
