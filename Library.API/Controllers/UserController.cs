using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class UserController:BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var users = await _userService.GetAllAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDTO>>(users.ToList());
            return Ok(userDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        { 
            try
            {
                var user = await _userService.GetByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                var userDto = _mapper.Map<BookDTO>(user);
                return Ok(userDto);
            }
            catch (Exception)
            {

                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserDTO userDto)
        {
            try
            {
                var user = await _userService.AddAsync(_mapper.Map<User>(userDto));
                var userDTO = _mapper.Map<BookDTO>(user);

                return Ok(userDTO);
            }
            catch (Exception)
            {

               return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserDTO userDto)
        {
            try
            {
                await _userService.UpdateAsync(_mapper.Map<User>(userDto));

                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var user = await _userService.GetByIdAsync(id);
                await _userService.RemoveAsync(user);
                return Ok();
            }
            catch (Exception)
            {

               return BadRequest();
            }
        }
    }
}
