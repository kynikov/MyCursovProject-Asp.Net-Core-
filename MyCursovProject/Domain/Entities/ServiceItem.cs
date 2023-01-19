using System.ComponentModel.DataAnnotations;

namespace MyCursovProject.Domain.Entities
{
	public class ServiceItem : EntityBase
	{

		[Required]

		[Display(Name = "Name of the service (title)")]
		public override string Title { get; set; }

		[Display(Name = "Short description service")]
		public override string Subtitle { get; set; }

		[Display(Name = "Full description service")]
		public override string Text { get; set; }
	}
}
