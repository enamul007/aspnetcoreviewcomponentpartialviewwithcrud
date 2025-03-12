using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticleCRUD.Models
{
    public class Tutorial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Name { get; set; }= string.Empty;
        public string Description { get; set; }= string.Empty;
       public List<Article> Articles { get; set; } = new();
    }
}
