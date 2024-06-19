namespace CapitalPlacementTask.Api.Models{
    public class ApplicationForm
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public List<Question> Questions { get; set; }
    }
}