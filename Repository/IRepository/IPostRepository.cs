using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepository
{
    public interface IPostRepository
    {
        Task<List<Post>> GetPostList(Expression<Func<Post, bool>> filter = null);
        Task<Post> GetPostByFilter(Expression<Func<Post, bool>> filter = null, bool tracked = true);
    }
}