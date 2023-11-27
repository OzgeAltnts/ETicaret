using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstracts
{
	public interface ICategoryDal : IGenericDal<Category>
	{
		Task<List<Category>> Get3Category();
	}


}
