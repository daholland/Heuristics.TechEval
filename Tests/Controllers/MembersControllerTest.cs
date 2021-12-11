using System.Web.Mvc;
using Heuristics.TechEval.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Heuristics.TechEval.Tests.Controllers
{

	[TestClass]
	public class MembersControllerTest
	{

		[TestMethod]
		public void EditGET()
		{
			// TODO: this test fails right now because its not able to access the database properly
			// I think this is where a mock DataContext that fakes the db would be useful for these
			// MVC tests. I also think in newer dotnet core (and perhaps this version of .Net as well), there's also a prevalence of DI constructors
			// for helping deal with this for testing? I'm unsure what the .Net 4.5.2 preference for testing is here.
			// Arrange
			
			MembersController controller = new MembersController();

			// Act
			ViewResult result = controller.Edit(1) as ViewResult;

			Web.Models.EditMember model = (Web.Models.EditMember) result.Model;
			Assert.AreEqual(1, model.Id);
			//Assert result.contents [get to <div></div> response on result] == [rawstring from JS console]
			
		}
	}
}
