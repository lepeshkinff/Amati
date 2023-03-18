namespace Amati.Engine.Services
{
    public interface IAuthenticationService
    {
        public Task<bool> Login(string login, string password);

        public Task<RegistrationResult> Registrate(string login, string password);
    }

    public enum RegistrationResult
    {
        Success, 
        LoginIsInUse,
        PasswordTooSimple
    }
}