using ETicaret.EntityLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concretes
{
	public class Order : IEntity
	{
		public int OrderId { get; set; }
		public string OrderName { get; set; }
		public int OrderNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public int OrderCount { get; set; }
		public bool OrderStatu { get; set; }
		public short SortKey { get; set; }
		
	}
}
