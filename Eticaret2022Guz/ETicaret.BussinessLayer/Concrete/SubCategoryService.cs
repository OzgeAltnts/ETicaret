using ETicaret.BussinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
	public class SubCategoryService : ISubCategoryService
	{
		private readonly ISubCategoryDal _subcategoryDal;

		public SubCategoryService(ISubCategoryDal subcategoryDal)
		{
			_subcategoryDal = subcategoryDal;
		}


		public async Task<SubCategory> AddAsync(SubCategory subCategory)
		{
			return await _subcategoryDal.AddAsync(subCategory);
		}

		public async Task<bool> DeleteByIdAsync(int id)
		{
			return await _subcategoryDal.DeleteByIdAsync(id);
		}

		public async Task<SubCategory> GetAsync(Expression<Func<SubCategory, bool>> filter)
		{
			return await _subcategoryDal.GetAsync(filter);
		}

		public async Task<List<SubCategory>> GetListAsync(Expression<Func<SubCategory, bool>> filter = null)
		{
			return await _subcategoryDal.GetListAsync(filter);
		}

		public async Task<SubCategory> GetModelByIdAsync(int id)
		{
			return await _subcategoryDal.GetModelByIdAsync(id);
		}

		public async Task<SubCategory> UpdateAsync(SubCategory subCategory)
		{
			return await _subcategoryDal.UpdateAsync(subCategory);
		}
	}
}
