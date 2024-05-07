using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repositories
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
            IQueryable<Comment> comments = _dbContext.Comments.Include(u => u.User).Include(p => p.Post);
            if (filter != null)
            {
                comments = comments.Where(filter);
            }
            return await comments.Select(c => new Comment{
                Comment_ID = c.Comment_ID,
                Post_ID = c.Post_ID,
                Post = c.Post,
                User_ID = c.User_ID,
                User = c.User,
                Comment_Text = c.Comment_Text,
                Commented_On = c.Commented_On
            }).ToListAsync();
        }

        public async Task<Comment> GetCommentByFilter(Expression<Func<Comment, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Comment> comment = _dbContext.Comments.Include(u => u.User).Include(p => p.Post.User);
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
                Post_ID = c.Post_ID,
                Post = c.Post,
                User_ID = c.User_ID,
                User = c.User,
                Comment_Text = c.Comment_Text,
                Commented_On = c.Commented_On
            }).FirstOrDefaultAsync();
        }

        public async Task<Comment> AddNewComment(Comment newComment)
        {
            var result = await _dbContext.Comments.AddAsync(newComment);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Comment> UpdateComment(Comment updateComment) // Change to DTO
        {
            var result = _dbContext.Comments.Update(updateComment);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Comment> DeleteComment(Comment deleteComment)// Change to DTO
        {
            var result = _dbContext.Comments.Remove(deleteComment);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}