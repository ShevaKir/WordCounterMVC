using Microsoft.AspNetCore.Mvc;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
    public class WordController : Controller
    {
        public IActionResult Index()
        {
            TextParse text = new TextParse("Hello, my dear friends");
            WordAnalysis wordAnalysis = new WordAnalysis(text);

            return View(wordAnalysis.GetTopWordPharse());
        }
    }
}
