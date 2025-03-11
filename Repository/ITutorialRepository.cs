using ArticleCRUD.Models;
using ArticleCRUD.ViewModels;

namespace ArticleCRUD.Repository
{
    public interface ITutorialRepository
    {
        void Add(TutorialViewModel tutorial);

        Tutorial Update(Tutorial tutorial);

        void Delete(int Id);

        Task<Tutorial> GetTutorial(int Id);

        Task<IEnumerable<Tutorial>> GetAllTutorial();
    }
}
