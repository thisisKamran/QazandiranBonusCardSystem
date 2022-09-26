using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QazandiranBonusCardSystem.Data;
using QazandiranBonusCardSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QazandiranBonusCardSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public ProductController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("{BasketId}")]
        public async Task<ActionResult<List<Product>>> GetProductsByBasketId(Guid BasketId)
        {
            var _bas = await _dbContext.Baskets.Include(u => u.Products).FirstOrDefaultAsync(u => u.Id == BasketId);
            return Ok(_bas.Products);
        }
        //public async Task<ActionResult<List<Product>>> GetAll()
        //{

        //    return Ok();
        //}
    }
}
