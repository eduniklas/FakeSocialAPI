using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepository;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _dbContext;
        public CommentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Comment>> GetCommentList(Expression<Func<Comment, bool>> filter = null)
        {
            IQueryable<Comment> comments = _dbContext.Comments;
            if (filter != null)
            {
                comments = comments.Where(filter);
            }
            return await comments.Select(c => new Comment{
                Comment_ID = c.Comment_ID,
                Post_ID = c.Post_ID, // Select to get post data
                User_ID = c.User_ID, // Select to get user data
                Comment_Text = c.Comment_Text,
                Commented_On = c.Commented_On
            }).ToListAsync();
        }

        public async Task<Comment> GetCommentByFilter(Expression<Func<Comment, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Comment> comment = _dbContext.Comments;
            if (!tracked == true)
            {
                comment = comment.AsNoTracking();
            }
            if (filter != null)
            {
                comment = comment.Where(filter);
            }
            return await comment.Select(c => new Comment
            {
                Comment_ID = c.Comment_ID,
                Post_ID = c.Post_ID, // Select to get post data
                User_ID = c.User_ID, // Select to get user data
                Comment_Text = c.Comment_Text,
                Commented_On = c.Commented_On
            }).FirstOrDefaultAsync();
        }
    }
}