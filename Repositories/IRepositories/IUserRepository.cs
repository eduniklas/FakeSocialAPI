using System.Linq.Expressions;
using FakeSocialAPI.Models;
using FakeSocialAPI.Models.DTO;

namespace FakeSocialAPI.IRepositories
{
    public interface IUserRepository
    {
        Task<List<Users>> GetUsersList(Expression<Func<Users, bool>> filter = null);
        Task<Users> GetUserByFilter(Expression<Func<Users, bool>> filter = null, bool tracked = true);
        Task<Users> CreateUser(Users newUser);
        Task<Users> DeleteUser(Users deleteUser);
        Task<Users> UpdateUser(UsersDTO updateUser);
    }
}