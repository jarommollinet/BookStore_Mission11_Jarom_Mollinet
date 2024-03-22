using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Project
    {
        [Key]
        public int ProjectID {  get; set; }
        public string Title
    }
}
