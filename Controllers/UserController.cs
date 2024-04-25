// Controller for user data

using FakeSocialAPI.IRepository;
using FakeSocialAPI.Models;
using FakeSocialAPI.ResponseExtention;
using Microsoft.AspNetCore.Mvc;

namespace FakeSocialAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<ApiResponse>> GetAllUsers()
        {
            return CreateResponseExtention.CreateResponse(await _userRepository.GetUsersList());
        }
        [HttpGet("GetUserByUsername")]
        public async Task<ActionResult<ApiResponse>> GetUser(string username)
        {
            return CreateResponseExtention.CreateResponse(await _userRepository.GetUserByFilter(x => x.Username == username));
        }
    }
}