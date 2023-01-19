using System.ComponentModel.DataAnnotations;

namespace MyCursovProject.Domain.Entities
{
	public class TextField : EntityBase
	{
		[Required]
		public string CodeWord { get; set; }

		[Display(Name = "Name page (title)")]
		public override string Title { get; set; } = "Information page";

		[Display(Name = "Page content (title)")]
		public override string Text { get; set; } = "Content filling up admin";
	}
}
