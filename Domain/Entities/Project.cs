namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string AssigneeType { get; set; }
        public string Name { get; set; }

    }
}
