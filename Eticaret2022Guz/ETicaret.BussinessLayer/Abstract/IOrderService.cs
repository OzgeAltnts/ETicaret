using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
	public interface IOrderService
	{
		Task<Order> AddAsync(Order order);
		Task<Order> UpdateAsync(Order order);
		Task<bool> DeleteByIdAsync(int id);

		Task<List<Order>> GetListAsync(Expression<Func<Order, bool>> filter = null);

		Task<Order> GetAsync(Expression<Func<Order, bool>> filter);

		Task<Order> GetModelByIdAsync(int id);
	}
}
