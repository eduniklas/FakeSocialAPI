using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepository;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _dbContext;
        public PostRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Post>> GetPostList(Expression<Func<Post, bool>> filter = null)
        {
            IQueryable<Post> posts = _dbContext.Posts;
            if (filter != null)
            {
                posts = posts.Where(filter);
            }
            return await posts.Select(p => new Post{
                Post_ID = p.Post_ID,
                User_ID = p.User_ID, // Select on user to get user data 
                Content = p.Content,
                Image_URL = p.Image_URL,
                Posted_On = p.Posted_On,
                Visibility = p.Visibility
            }).ToListAsync();
        }

        public async Task<Post> GetPostByFilter(Expression<Func<Post, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Post> post = _dbContext.Posts;
            if (!tracked == true)
            {
                post = post.AsNoTracking();
            }
            if (filter != null)
            {
                post = post.Where(filter);
            }
            return await post.Select(p => new Post
            {
                Post_ID = p.Post_ID,
                User_ID = p.User_ID, // Select on user to get user data 
                Content = p.Content,
                Image_URL = p.Image_URL,
                Posted_On = p.Posted_On,
                Visibility = p.Visibility
            }).FirstOrDefaultAsync();
        }
    }
}