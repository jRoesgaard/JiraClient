using System;

namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public User UpdateAuthor { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}