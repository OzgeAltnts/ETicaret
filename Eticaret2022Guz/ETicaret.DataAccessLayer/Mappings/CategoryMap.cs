using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
	internal class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{

		
			builder.Property(x => x.SortKey).HasDefaultValue(0);
			builder.Property(x => x.CategoryStatus).HasDefaultValue(true);
			builder.Property(x => x.CategoryName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

			builder.HasData(new Category
			{
				CategoryId = 1,
				CategoryStatus = true,
				CategoryName = "Elektronik",
				SortKey = 1
			});
		}
	}
}