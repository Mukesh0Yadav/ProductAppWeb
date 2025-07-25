using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TeamBackend.Data;
using TeamBackend.Models;
using TeamBackend.Repositories;
using System.Data.Entity;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Create(UserData user)
    {
        var sql = "EXEC CreateUser @FirstName, @LastName, @Email, @Organization, @AddressLine1, @State, @Pincode";

        int rowsAffected = await _context.Database.ExecuteSqlCommandAsync(
            sql,
            new SqlParameter("@FirstName", user.FirstName ?? (object)DBNull.Value),
            new SqlParameter("@LastName", user.LastName ?? (object)DBNull.Value),
            new SqlParameter("@Email", user.Email ?? (object)DBNull.Value),
            new SqlParameter("@Organization", user.Organization ?? (object)DBNull.Value),
            new SqlParameter("@AddressLine1", user.AddressLine1 ?? (object)DBNull.Value),
            new SqlParameter("@State", user.State ?? (object)DBNull.Value),
            new SqlParameter("@Pincode", user.Pincode ?? (object)DBNull.Value)
        );

        return rowsAffected > 0;
    }

    
    public async Task<bool> Update(UserData user)
    {
        var sql = "EXEC UpdateUser @Id, @FirstName, @LastName, @Email, @Organization, @AddressLine1, @State, @Pincode";

        int rowsAffected = await _context.Database.ExecuteSqlCommandAsync(
            sql,
            new SqlParameter("@Id", user.Id),  
            new SqlParameter("@FirstName", user.FirstName ?? (object)DBNull.Value),
            new SqlParameter("@LastName", user.LastName ?? (object)DBNull.Value),
            new SqlParameter("@Email", user.Email ?? (object)DBNull.Value),
            new SqlParameter("@Organization", user.Organization ?? (object)DBNull.Value),
            new SqlParameter("@AddressLine1", user.AddressLine1 ?? (object)DBNull.Value),
            new SqlParameter("@State", user.State ?? (object)DBNull.Value),
            new SqlParameter("@Pincode", user.Pincode ?? (object)DBNull.Value)
        );

        return rowsAffected > 0;
    }
}
