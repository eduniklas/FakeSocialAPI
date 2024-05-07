using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetPostList(Expression<Func<Post, bool>> filter = null);
        Task<Post> GetPostByFilter(Expression<Func<Post, bool>> filter = null, bool tracked = true);
        Task<Post> CreatePost(Post newPost);
        Task<Post> DeletePost(Post post);
        Task<Post> UpdatePost(Post update);
    }
}