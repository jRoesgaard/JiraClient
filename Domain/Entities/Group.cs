using System.Collections.Generic;

namespace Domain.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
