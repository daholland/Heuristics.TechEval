using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Heuristics.TechEval.Web.Models
{

	/// <summary>
	/// DTO representing the creation of a new Member
	/// </summary>
	public class EditMember
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
	}
}