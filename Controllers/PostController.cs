using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using FakeSocialAPI.ResponseExtention;
using Microsoft.AspNetCore.Mvc;

namespace FakeSocialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }        
        [HttpGet("GetAllPosts")]
        public async Task<ActionResult<ApiResponse>> GetAllPost()
        {
            return CreateResponseExtention.CreateResponse(await _postRepository.GetPostList());
        }
        [HttpGet("GetPostByID")]
        public async Task<ActionResult<ApiResponse>> GetPost(int post_id)
        {   
            return CreateResponseExtention.CreateResponse(await _postRepository.GetPostByFilter(x => x.Post_ID == post_id));
        }
    }
}