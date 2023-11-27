using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _IOrderService;

		public OrderController(IOrderService IOrderService)
		{
			_IOrderService = IOrderService;
		}

		[HttpGet]
		[Route("[action]")]
		public async Task<IActionResult> GetList()
		{
			var result = await _IOrderService.GetListAsync(x => x.OrderStatu == true);
			if (result is not null)
				return Ok(result);
			return NotFound(result);
		}

		[HttpGet]
		[Route("[action]/{id:int}")]
		public async Task<IActionResult> GetById(int id)
		{
			var result = await _IOrderService.GetModelByIdAsync(id);
			if (result is not null)
				return Ok(result);
			return NotFound(result);
		}


		[HttpPost]
		[Route("[action]")]
		public async Task<IActionResult> Add([FromBody] Order order)
		{
			var result = await _IOrderService.AddAsync(order);
			if (result is not null)
				return Ok(result);
			return BadRequest(result);
		}

		[HttpDelete]
		[Route("[action]/{id:int}")]

		public async Task<IActionResult> Delete(int id)
		{
			var result = await _IOrderService.DeleteByIdAsync(id);
			if (result)
				return Ok(result);
			return NotFound(result);
		}


		[HttpPut]
		[Route("[action]")]

		public async Task<IActionResult> Update([FromBody] Order order)
		{
			var result = await _IOrderService.UpdateAsync(order);
			if (result is not null)
				return Ok(result);
			return BadRequest(result);
		}


	}
}
