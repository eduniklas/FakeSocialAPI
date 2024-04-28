using FakeSocialAPI.Data;
using FakeSocialAPI.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FakeSocialAPI.Validators
{
    public class UserValidator : AbstractValidator<Users>
    {
        private readonly AppDbContext _dbContext;
        public UserValidator(AppDbContext dbContext)
        {
            _dbContext = dbContext;

            RuleFor(x => x.Username)
                .MustAsync(BeUniqueUsername).WithMessage("Username already in use");
                
            RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("Email address is required")
                .EmailAddress().WithMessage("Invalid email format")
                .MustAsync(BeUniqueEmail).WithMessage("Email address already in use");
        }
        private async Task<bool> BeUniqueEmail(string email, CancellationToken token)
        {
            return await _dbContext.Users.AllAsync(u => u.EmailAddress != email, token);
        }
        private async Task<bool> BeUniqueUsername(string username, CancellationToken token)
        {
            return await _dbContext.Users.AllAsync(u => u.Username != username, token);
        }
    }
}