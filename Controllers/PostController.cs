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
        [HttpPost("CreateNewPost")]
        public async Task<ActionResult<ApiResponse>> CreateNewPost([FromBody] Post newPost)
        {
            return CreateResponseExtention.CreateResponse(await _postRepository.CreatePost(newPost));
        }
        [HttpPatch("UpdatePost")]
        public async Task<ActionResult<ApiResponse>> UpdatePost([FromBody] Post updatePost) // change to DTO ?
        {
            return CreateResponseExtention.CreateResponse(await _postRepository.UpdatePost(updatePost));
        }
        [HttpDelete("DeletePost")]
        public async Task<ActionResult<ApiResponse>> DeletePost([FromBody] Post newPost) // change to DTO ?
        {
            return CreateResponseExtention.CreateResponse(await _postRepository.DeletePost(newPost));
        }
    }
}