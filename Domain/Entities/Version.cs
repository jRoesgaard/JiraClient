using System;

namespace Domain.Entities
{
    public class Version
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
        public bool Released { get; set; }
        public bool Overdue { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime UserReleaseDate { get; set; }
    }
}
