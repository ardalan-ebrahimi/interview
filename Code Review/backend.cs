// UserController.cs

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            try
            {
                // Fetch all users from the repository
                var users = _userRepository.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                // Log and handle the exception properly
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult AddUser(User newUser)
        {
            try
            {
                // Validate newUser and add it to the repository
                _userRepository.AddUser(newUser);
                return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
            }
            catch (Exception ex)
            {
                // Log and handle the exception properly
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }
    }
}
