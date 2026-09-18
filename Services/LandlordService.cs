using HomeEase.Data;
using HomeEase.Models;
namespace HomeEase.Services
{
    public class LandlordService
    {
        private readonly UserContext _context;

        public LandlordService(UserContext context)
        {
            _context = context;
        }

        public async Task<Landlord> SaveLandlord(Landlord landlord)
        {
            _context.Landlords.Add(landlord);
            await _context.SaveChangesAsync();
            return landlord;
        }


    }
}