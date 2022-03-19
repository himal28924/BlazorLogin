using System.Security.Claims;

namespace BlazorLoginApp.Authentication;

public interface IAuthService
{
    
    public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }

    public Task LoginAsync(string username, string password);
    public Task LogoutAsync();
    public Task<ClaimsPrincipal> GetAuthAsync();
    
    

}