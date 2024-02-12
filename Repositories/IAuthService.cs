using team_gung_ho_coders_backend.Models;

namespace team_gung_ho_coders_backend.Repositories;

public interface IAuthService 
{
    User CreateUser(User user);
    string SignIn(string username, string email, string password);
}
