﻿using ETicaret.EntityLayer.Abstracts;
using System.Collections.Generic;

namespace ETicaret.EntityLayer.Concretes
{
    public class SubCategory : IEntity
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public bool SubCategoryStatu { get; set; }
		public short SortKey { get; set; }
	}
}
