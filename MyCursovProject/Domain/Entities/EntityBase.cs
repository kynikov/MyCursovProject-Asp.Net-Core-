using System;
using System.ComponentModel.DataAnnotations;

namespace MyCursovProject.Domain.Entities
{
	public abstract class EntityBase
	{
		protected EntityBase() => DateAdded = DateTime.UtcNow;

		[Required]
		public Guid Id { get; set; }

		[Display(Name = "Name(title)")]
		public virtual string Title { get; set; }

		[Display(Name = "Short description service")]
		public virtual string Subtitle { get; set; }

		[Display(Name = "Full description service")]
		public virtual string Text { get; set; }

		[Display(Name = "Title image")]
		public virtual string TitleImagePath { get; set; }

		[Display(Name = "SEO metatag Title")]
		public virtual string MetaTitle { get; set; }

		[Display(Name = "SEO metatag Description")]
		public virtual string MetaDescription { get; set; }

		[DataType(DataType.Time)]
		public DateTime DateAdded { get; set; }

	}
}
