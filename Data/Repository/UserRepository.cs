using Siga_Hrms.Data.Interfaces;
using Siga_Hrms.Data.Model;
using Siga_Hrms.Data.DataContext;


namespace Siga_Hrms.Data.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext Context) : base(Context)
    {
    }

}
