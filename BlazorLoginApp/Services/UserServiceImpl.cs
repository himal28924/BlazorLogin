using BlazorLoginApp.Models;

namespace BlazorLoginApp.Services;

public class UserServiceImpl:IUserService

{
    public async Task<User?> GetUserAsync(string username)
    {
        User? find = users.Find(user => user.Name.Equals(username));
        return find;
    }
    
    private List<User> users = new()
    {
        new User("Troels", "Troels1234", "Teacher", 3, 1986),
        new User("Himal", "Himal123", "Student", 2, 2000),
        new User("Anne", "password", "HeadOfDepartment", 5, 1975)        
    };
}