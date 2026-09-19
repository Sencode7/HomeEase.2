using HomeEase.Data;
using HomeEase.Models;
using Microsoft.AspNetCore.Identity;
namespace HomeEase.Services
{
    public class LandlordService
    {
        private readonly UserContext _context;
        private readonly IPasswordHasher<Landlord> _passwordHasher;

        public LandlordService(UserContext context, IPasswordHasher<Landlord> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<Landlord> SaveLandlord(Landlord landlord)
        {
            landlord.Password = _passwordHasher.HashPassword(landlord, landlord.Password);
            _context.Landlords.Add(landlord);
            await _context.SaveChangesAsync();
            return landlord;
        }


    }
}