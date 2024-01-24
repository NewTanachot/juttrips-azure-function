using System.Threading.Tasks;
using juttrips_azure_function.Core.Repository;
using juttrips_azure_function.Domain.Entities;
using juttrips_azure_function.Infrastructure.DbConfiguration;

namespace juttrips_azure_function.Infrastructure.Repository;

public class AuthRepository : IAuthRepository
{
    private readonly JutTripsDbContext _jutTripsDbContext;

    public AuthRepository(JutTripsDbContext jutTripsDbContext)
    {
        _jutTripsDbContext = jutTripsDbContext;
    }

    public async Task<User> InsertUserAsync(User user)
    {
        var result = await _jutTripsDbContext.User.AddAsync(user);
        await _jutTripsDbContext.SaveChangesAsync();
        
        return result.Entity; 
    }
}