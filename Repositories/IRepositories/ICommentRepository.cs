using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepositories
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetCommentList(Expression<Func<Comment, bool>> filter = null);
        Task<Comment> GetCommentByFilter(Expression<Func<Comment, bool>> filter = null, bool tracked = true);
        Task<Comment> AddNewComment(Comment newComment);
        Task<Comment> DeleteComment(Comment deleteComment);
        Task<Comment> UpdateComment(Comment updateComment);
    }
}