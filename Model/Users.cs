using ProjectMangament.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjectMangament.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; } 
        public string UserName {  get; set; }
        public string Email {  get; set; }
        public string Role {  get; set; }
        public DateTime DateJoined {  get; set; }
    }
}
