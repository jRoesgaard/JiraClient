namespace Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string TimeZone { get; set; }
        public bool Active { get; set; }
    }
}
