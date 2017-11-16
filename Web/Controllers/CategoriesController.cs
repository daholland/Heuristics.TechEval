using System.Linq;
using System.Web.Mvc;
using Heuristics.TechEval.Core;

namespace Heuristics.TechEval.Web.Controllers {

	public class CategoriesController : Controller {

		private readonly DataContext _context;

		public CategoriesController() {
			_context = new DataContext();
		}

		public ActionResult List() {
			var categories = _context.Categories.ToList();

			return View(categories);
		}
	}
}