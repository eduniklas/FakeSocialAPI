using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly AppDbContext _dbContext;
        public LikeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Like>> GetLikeList(Expression<Func<Like, bool>> filter = null)
        {
            IQueryable<Like> likes = _dbContext.Likes.Include(u => u.User).Include(p => p.Post);
            if(filter != null)
            {
                likes = likes.Where(filter);
            }
            return await likes.Select(l => new Like
            {
                Like_ID = l.Like_ID,
                Post_ID = l.Post_ID,
                Post = l.Post,
                User_ID = l.User_ID,
                User = l.User,
                Liked_On = l.Liked_On
            }).ToListAsync();
        }
        public async Task<Like> GetLikeByFilter(Expression<Func<Like, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Like> likes = _dbContext.Likes.Include(u => u.User).Include(p => p.Post.User);
            if(!tracked == true)
            {
                likes = likes.AsNoTracking();
            }
            if(filter != null)
            {
                likes = likes.Where(filter);
            }
            return await likes.Select(l => new Like
            {
                Like_ID = l.Like_ID,
                Post_ID = l.Post_ID,
                Post = l.Post,
                User_ID = l.User_ID,
                User = l.User,
                Liked_On = l.Liked_On
            }).FirstOrDefaultAsync();
        }
        public async Task<Like> AddNewLike(Like newLike)
        {
            var result = await _dbContext.Likes.AddAsync(newLike);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Like> DeleteLike(Like deleteLike)
        {
            var result = _dbContext.Likes.Remove(deleteLike);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}