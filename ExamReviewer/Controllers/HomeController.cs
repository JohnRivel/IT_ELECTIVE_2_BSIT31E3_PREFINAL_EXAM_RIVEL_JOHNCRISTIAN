using Microsoft.AspNetCore.Mvc;
using ExamReviewer.Data;

namespace ExamReviewer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = QuestionBank.All.OrderBy(q => q.Id).ToList();
            return View(questions);
        }

        public IActionResult Details(int id)
        {
            var question = QuestionBank.All.FirstOrDefault(q => q.Id == id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}