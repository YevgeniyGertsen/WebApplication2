namespace WebApplication2.Models
{
    public class TeamViewModel
    {
        public string TeamImage { get; set; }
        public PictireSize PictireSize { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string[] TeamLinks { get; set; }
    }
}