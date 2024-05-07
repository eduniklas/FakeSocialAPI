using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using FakeSocialAPI.ResponseExtention;
using Microsoft.AspNetCore.Mvc;

namespace FakeSocialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeRepository _likeRepository;
        public LikeController(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }
        [HttpGet("GetAllLikes")]
        public async Task<ActionResult<ApiResponse>> GetAllLikes()
        {
            return CreateResponseExtention.CreateResponse(await _likeRepository.GetLikeList());
        }
        [HttpGet("GetLikeByID")]
        public async Task<ActionResult<ApiResponse>> GetLike(int like_id)
        {   
            return CreateResponseExtention.CreateResponse(await _likeRepository.GetLikeByFilter(x => x.Like_ID == like_id));
        }
        [HttpPost("CreateNewLike")]
        public async Task<ActionResult<ApiResponse>> AddNewLike([FromBody] Like newLike)
        {
            return CreateResponseExtention.CreateResponse(await _likeRepository.AddNewLike(newLike));
        }
        [HttpDelete("DeleteLike")]
        public async Task<ActionResult<ApiResponse>> DeleteLike([FromBody] Like deleteLike)
        {
            return CreateResponseExtention.CreateResponse(await _likeRepository.DeleteLike(deleteLike));
        }
    }
}