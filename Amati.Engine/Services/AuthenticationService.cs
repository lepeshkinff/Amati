namespace Amati.Engine.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<bool> Login(string login, string password)
        {
            var result = (login, password) switch
            {
                ("l", "1") => true,
                _ => false,
            };
            return Task.FromResult(result);
        }

        Task<RegistrationResult> IAuthenticationService.Registrate(string login, string password)
        {
            var result = (login, password) switch
            {
                ("l", _) => RegistrationResult.LoginIsInUse,
                _ when password is { Length: < 6 } => RegistrationResult.PasswordTooSimple,
                _ => RegistrationResult.Success
            };
            return Task.FromResult(result);
        }
    }
}