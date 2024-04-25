using FakeSocialAPI.IRepository;
using FakeSocialAPI.Models;
using FakeSocialAPI.ResponseExtention;
using Microsoft.AspNetCore.Mvc;

namespace FakeSocialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        public CommentController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpGet("GetAllComments")]
        public async Task<ActionResult<ApiResponse>> GetAllPost()
        {
            return CreateResponseExtention.CreateResponse(await _commentRepository.GetCommentList());
        }
        [HttpGet("GetCommentByID")]
        public async Task<ActionResult<ApiResponse>> GetPost(int comment_id)
        {   
            return CreateResponseExtention.CreateResponse(await _commentRepository.GetCommentByFilter(x => x.Comment_ID == comment_id));
        }
    }
}