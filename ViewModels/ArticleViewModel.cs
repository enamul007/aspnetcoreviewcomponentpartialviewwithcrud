﻿using ArticleCRUD.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ArticleCRUD.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public ArticleViewModel()
        {
            tutorials = new List<Tutorial>();
        }

        [Required(ErrorMessage = "Please enter article title")]
        [Display(Name = "Please enter article title")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Please enter article content")]
        [Display(Name = "Write article")]
        public string ArticleContent { get; set; }
        public int TutorialId { get; set; }
        public List<Tutorial> tutorials { get; set; }
    }
}
