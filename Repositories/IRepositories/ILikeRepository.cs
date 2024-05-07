using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepositories
{
    public interface ILikeRepository
    {
        Task<List<Like>> GetLikeList(Expression<Func<Like, bool>> filter = null);
        Task<Like> GetLikeByFilter(Expression<Func<Like, bool>> filter = null, bool tracked = true);
        Task<Like> AddNewLike(Like newLike);
        Task<Like> DeleteLike(Like deleteLike);
    }
}