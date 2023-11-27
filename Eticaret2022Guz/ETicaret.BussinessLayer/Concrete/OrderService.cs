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
	public class OrderService : IOrderService
	{
		private readonly IOrderDal _orderDal;

		public OrderService(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}


		public async Task<Order> AddAsync(Order order)
		{
			return await _orderDal.AddAsync(order);
		}

		public async Task<bool> DeleteByIdAsync(int id)
		{
			return await _orderDal.DeleteByIdAsync(id);
		}

		public async Task<Order> GetAsync(Expression<Func<Order, bool>> filter)
		{
			return await _orderDal.GetAsync(filter);
		}

		public async Task<List<Order>> GetListAsync(Expression<Func<Order, bool>> filter = null)
		{
			return await _orderDal.GetListAsync(filter);
		}

		public async Task<Order> GetModelByIdAsync(int id)
		{
			return await _orderDal.GetModelByIdAsync(id);
		}

		public async Task<Order> UpdateAsync(Order order)
		{
			return await _orderDal.UpdateAsync(order);
		}
	}
}
