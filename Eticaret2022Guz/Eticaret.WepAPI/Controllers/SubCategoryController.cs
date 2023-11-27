using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubCategoryController : ControllerBase
	{

		private readonly ISubCategoryService _ISubCategoryService;

		public SubCategoryController(ISubCategoryService ıSubCategoryService)
		{
			_ISubCategoryService = ıSubCategoryService;
		}

		[HttpGet]
		[Route("[action]")]
		public async Task<IActionResult> GetList()
		{
			var result = await _ISubCategoryService.GetListAsync(x => x.SubCategoryStatu == true);
			if (result is not null)
				return Ok(result);
			return NotFound(result);
		}

		[HttpGet]
		[Route("[action]/{id:int}")]
		public async Task<IActionResult> GetById(int id)
		{
			var result = await _ISubCategoryService.GetModelByIdAsync(id);
			if (result is not null)
				return Ok(result);
			return NotFound(result);
		}

		[HttpPost]
		[Route("[action]")]
		public async Task<IActionResult> Add([FromBody] SubCategory subcategory)
		{
			var result = await _ISubCategoryService.AddAsync(subcategory);
			if (result is not null)
				return Ok(result);
			return BadRequest(result);
		}

		[HttpDelete]
		[Route("[action]/{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			var result = await _ISubCategoryService.DeleteByIdAsync(id);
			if (result)
				return Ok(result);
			return NotFound(result);
		}

		[HttpPut]
		[Route("[action]")]
		public async Task<IActionResult> Update([FromBody] SubCategory subcategory)
		{
			var result = await _ISubCategoryService.UpdateAsync(subcategory);
			if (result is not null)
				return Ok(result);
			return BadRequest(result);
		}
	}
}
