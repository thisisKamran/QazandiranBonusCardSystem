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
    public class UserController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public UserController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var _users = await _dbContext.Users.ToListAsync();
            return Ok(_users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(Guid id)
        {
            var _user= await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (_user == null)
                return NotFound();
            return Ok(_user);
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserCreationDTO dto)
        {
            var _user = new User { Firstname = dto.Firstname, Lastname = dto.Lastname };
            await _dbContext.Users.AddAsync(_user);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
