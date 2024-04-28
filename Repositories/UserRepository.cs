using System.Linq.Expressions;
using FakeSocialAPI.Data;
using FakeSocialAPI.IRepositories;
using FakeSocialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Repositories
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
                Last_Login = u.Last_Login,
                Friends = u.Friends.Select(f => new Friend  // need config relationship to work properly
                {
                    Friend_ID = f.Friend_ID,
                    User1_ID = f.User1_ID,
                    User2_ID = f.User2_ID,
                    Status = f.Status,
                    Since_Date = f.Since_Date
                }).ToList(),
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
                Last_Login = u.Last_Login,
                Friends = u.Friends.Select(f => new Friend  // need config relationship to work properly
                {
                    Friend_ID = f.Friend_ID,
                    User1_ID = f.User1_ID,
                    User1 = f.User1,
                    User2_ID = f.User2_ID,
                    // User2 = f.User2, 
                    Status = f.Status,
                    Since_Date = f.Since_Date
                }).ToList(),
            }).FirstOrDefaultAsync();
        }

        public async Task<Users> CreateUser(Users newUser)
        {
            var result = await _dbContext.Users.AddAsync(newUser);
            await _dbContext.SaveChangesAsync();
            Console.WriteLine(result + " - Saving data");
            return newUser;
        }
    }
}