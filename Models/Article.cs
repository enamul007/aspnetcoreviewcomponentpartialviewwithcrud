
namespace ArticleCRUD.Models
{
    public class Article
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }

        [ForeignKey(nameof(Tutorial))]       
        public int TutorialId { get; set; } //Foreign Key
        public Tutorial Tutorial { get; set; } //Reference navigaton property
    }
}
