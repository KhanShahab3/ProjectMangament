using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class ProjectTeam
    {
        [Key]
        public int Id{get; set;}
        public int ProjectId {  get; set; }
        public int TeamId {  get; set; }

    }
}
