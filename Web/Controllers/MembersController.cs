using System.Linq;
using System.Web.Mvc;
using Heuristics.TechEval.Core;
using Heuristics.TechEval.Web.Models;
using Heuristics.TechEval.Core.Models;
using Newtonsoft.Json;

namespace Heuristics.TechEval.Web.Controllers {

	public class MembersController : Controller {

		private readonly DataContext _context;

		public MembersController() {
			_context = new DataContext();
		}

		public ActionResult List() {
			var allMembers = _context.Members.ToList();

			return View(allMembers);
		}

		[HttpPost]
		public ActionResult New(NewMember data) {
			var newMember = new Member {
				Name = data.Name,
				Email = data.Email
			};

			_context.Members.Add(newMember);
			_context.SaveChanges();

			return Json(JsonConvert.SerializeObject(newMember));
		}

		[HttpGet]
		public ActionResult Edit(int id)
		{
			
			var member = _context.Members.Find(id);
			if (member == null)
            {
				return HttpNotFound();
            }
			
			return PartialView(member);
        }


		[HttpPost]
		public ActionResult Edit([Bind(Include = "Id, Name, Email")] EditMember data)
		{
			var member = new Member { Id = data.Id, Name = data.Name, Email = data.Email };
			if (ModelState.IsValid) {
				_context.Entry(member).State = System.Data.Entity.EntityState.Modified;
				_context.SaveChanges();
				//todo: clientside refreshes on success, sure would be nice if we didn't have to reload the whole page...
				//doing a redirect here until clientside state management is more online
				//return Json(JsonConvert.SerializeObject(member));
				return RedirectToAction("List");
			} else
            {
				//todo: return error/validation dict? need to decide on client/server validation or both, and how to present that
				return HttpNotFound();
            }




		}
	}
}