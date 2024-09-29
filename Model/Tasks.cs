using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; } 
        public int ProjectId {  get; set; }
        public string TaskName {  get; set; }
        public string Description {  get; set; }
        public DateTime DueDate { get; set; }
        public string Priority {  get; set; }
        public string Status {  get; set; }

    }
}
