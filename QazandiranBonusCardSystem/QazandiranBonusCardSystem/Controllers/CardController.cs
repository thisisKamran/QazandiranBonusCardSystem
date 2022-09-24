using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QazandiranBonusCardSystem.Data;
using QazandiranBonusCardSystem.DTOs;
using QazandiranBonusCardSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QazandiranBonusCardSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public CardController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<List<Card>>> GetCardsByUserId(Guid userId)
        {
            var _user = await _dbContext.Users.Include(u => u.Cards).FirstOrDefaultAsync(u => u.Id == userId);
            return Ok(_user.Cards);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCard(CardCreationDTO dto)
        {
            var _user = await _dbContext.Users.Include(u=>u.Cards).FirstOrDefaultAsync(u => u.Id == dto.Userid);
            if(_user==null)
                return NotFound();
            var card = new Card();
            _user.Cards.Add(card);            
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
