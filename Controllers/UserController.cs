using FakeSocialAPI.Data;
using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using FakeSocialAPI.Models.DTO;
using FakeSocialAPI.ResponseExtention;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FakeSocialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private IValidator<Users> _validator;
        public UserController(IValidator<Users> validator, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _validator = validator;
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
        
        [HttpPost("CreateNewUser")]
        public async Task<ActionResult<ApiResponse>> CreateNewUser([FromBody] Users newUser) // change to userDTO ?
        {
            ValidationResult response = await _validator.ValidateAsync(newUser);
            if(!response.IsValid)
            {
                return BadRequest(response.Errors);
            }
            return CreateResponseExtention.CreateResponse(await _userRepository.CreateUser(newUser));
        }
        [HttpPatch("UpdateUser")]
        public async Task<ActionResult<ApiResponse>> UpdateUser([FromBody] UsersDTO updateUser)
        {
            return CreateResponseExtention.CreateResponse(await _userRepository.UpdateUser(updateUser));
        }
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<ApiResponse>> DeleteUser([FromBody] Users user) // change to DTO ?
        {
            return CreateResponseExtention.CreateResponse(await _userRepository.DeleteUser(user));
        }
    }
}