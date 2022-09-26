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
    public class BasketController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public BasketController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("{UserId}")]
        public async Task<ActionResult<List<Product>>> GetProductsByUserId(Guid userId)
        {
            var _user = await _dbContext.Users.Include(u => u.Basket).FirstOrDefaultAsync(u => u.Id == userId);
            return Ok(_user.Basket.Products);
        }
    }
}
