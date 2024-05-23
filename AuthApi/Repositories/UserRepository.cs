using AuthApi.Data;
using AuthApi.Interfaces.Repositories;
using AuthApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context, DbSet<User> dbSet) : base(context, dbSet)
    {
    }
}

