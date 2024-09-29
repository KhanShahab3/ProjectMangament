using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName {  get; set; }
        public string Description {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status {  get; set; }

    }
}
