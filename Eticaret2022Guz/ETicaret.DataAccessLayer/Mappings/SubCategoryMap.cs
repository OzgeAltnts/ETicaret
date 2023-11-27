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
	internal class SubCategoryMap : IEntityTypeConfiguration<SubCategory>
	{
		public void Configure(EntityTypeBuilder<SubCategory> builder)
		{
			builder.HasKey("SubCategoryId");
			builder.Property(x => x.SortKey).HasDefaultValue(0);
			builder.Property(x => x.SubCategoryStatu).HasDefaultValue(true);
			builder.Property(x => x.SubCategoryName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

			builder.HasData(new SubCategory
			{
				SubCategoryId = 1,
				SubCategoryStatu = true,
				SubCategoryName = "Telefon",
				SortKey = 1
			});

		}
	}
}
