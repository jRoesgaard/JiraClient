using System.Collections.Generic;

namespace Domain.Entities
{
    public class Avatar
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public bool IsSystemAvatar { get; set; }
        public bool IsSelected { get; set; }
        public bool Selected { get; set; }
        public IDictionary<string, string> Urls { get; set; }
    }
}
