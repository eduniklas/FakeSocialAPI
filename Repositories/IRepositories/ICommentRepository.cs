using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepositories
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetCommentList(Expression<Func<Comment, bool>> filter = null);
        Task<Comment> GetCommentByFilter(Expression<Func<Comment, bool>> filter = null, bool tracked = true);
    }
}