using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MRE.Repo
{
    public class Repo
    {
        private readonly MyDbContext _context;

        public Repo(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddWeatherForecast(WeatherForecast entity)
        {
            await _context.Entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public Task<WeatherForecast[]> GetWeatherForecast()
        {
            return _context.Entities.ToArrayAsync();
        }
    }
}