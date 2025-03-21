﻿

using ArticleCRUD.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ArticleCRUD.ViewComponents
{
    public class TutorialMenuViewComponent:ViewComponent
    {
        private readonly ITutorialRepository _tutorialRepository;
        public TutorialMenuViewComponent(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }

        //Asynchronous method
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tutorials = await _tutorialRepository.GetAllTutorial();
            return View(tutorials);
        }
    }
}
