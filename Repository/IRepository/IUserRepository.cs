using System.Linq.Expressions;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.IRepository
{
    public interface IUserRepository
    {
        Task<List<Users>> GetUsersList(Expression<Func<Users, bool>> filter = null);
        Task<Users> GetUserByFilter(Expression<Func<Users, bool>> filter = null, bool tracked = true);
    }
}