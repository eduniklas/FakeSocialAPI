using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepository;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Users>> GetUsersList(Expression<Func<Users, bool>> filter = null)
        {
            IQueryable<Users> users = _dbContext.Users;
            if (filter != null)
            {
                users = users.Where(filter);
            }
            return await users.Select(u => new Users{
                User_ID = u.User_ID,
                Username = u.Username,
                EmailAddress = u.EmailAddress,
                Password = u.Password,
                Creation_Date = u.Creation_Date,
                Last_Login = u.Last_Login
            }).ToListAsync();
        }

        public async Task<Users> GetUserByFilter(Expression<Func<Users, bool>> filter = null, bool tracked = true)
        {
            IQueryable<Users> user = _dbContext.Users;
            if (!tracked == true)
            {
                user = user.AsNoTracking();
            }
            if (filter != null)
            {
                user = user.Where(filter);
            }
            return await user.Select(u => new Users
            {
                User_ID = u.User_ID,
                Username = u.Username,
                EmailAddress = u.EmailAddress,
                Password = u.Password,
                Creation_Date = u.Creation_Date,
                Last_Login = u.Last_Login
            }).FirstOrDefaultAsync();
        }
    }
}