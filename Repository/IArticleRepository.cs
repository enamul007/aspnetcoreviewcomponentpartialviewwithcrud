using ArticleCRUD.Models;
using ArticleCRUD.ViewModels;

namespace ArticleCRUD.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(ArticleViewModel article);

        Article UpdateArticle(Article article);

       void DeleteArticle(int Id);

        Task<Article> GetArticleById(int Id);

        Task<IEnumerable<Article>> GetAllArticle();

        Task<IEnumerable<Tutorial>> GetAllTutorials();

        Task<IEnumerable<Article>> GetArticlesByTutorialId(int tutorialId);
    }
}
