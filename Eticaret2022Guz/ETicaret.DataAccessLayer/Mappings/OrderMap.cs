using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
	internal class OrderMap : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey("OrderId");
			builder.Property(x => x.SortKey).HasDefaultValue(0);
			builder.Property(x => x.OrderStatu).HasDefaultValue(true);
		    builder.Property(x => x.OrderName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			builder.Property(x => x.OrderCount).HasColumnType("int").HasMaxLength(100);
			builder.Property(x => x.OrderDate).HasColumnType("date");
			

		}
	}
}

