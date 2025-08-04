using System;

using System.Collections.Generic;

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
            new SqlParameter("@FirstName", user.FirstName),
            new SqlParameter("@LastName", user.LastName),
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@Organization", user.Organization),
            new SqlParameter("@AddressLine1", user.AddressLine1),
            new SqlParameter("@State", user.State),
            new SqlParameter("@Pincode", user.Pincode)
        );

        return rowsAffected > 0;
    }

    // ✅ Get all users using stored procedure

    public async Task<List<UserData>> GetAll()

    {

        var users = await _context.Database.SqlQuery<UserData>("EXEC GetAllUsers").ToListAsync();

        return users;

    }

    // ✅ Delete user by ID using stored procedure

    public async Task<bool> Delete(int id)

    {

        var sql = "EXEC DeleteUser @Id";

        int rowsAffected = await _context.Database.ExecuteSqlCommandAsync(

            sql,

            new SqlParameter("@Id", id)

        );

        return rowsAffected > 0;

    }

}

