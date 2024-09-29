using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class TaskAssignees
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public int TaskId {  get; set; }
        public int UserId { get; set; }
    } 
}
