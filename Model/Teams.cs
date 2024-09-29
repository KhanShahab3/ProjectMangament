using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public string TeamName {  get; set; }

    }
}
