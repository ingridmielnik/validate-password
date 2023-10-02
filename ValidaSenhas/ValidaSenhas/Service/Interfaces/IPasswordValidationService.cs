using ValidaSenhas.Model.Request;
using ValidaSenhas.Model.Response;

namespace ValidaSenhas.Service.Interfaces
{
    public interface IPasswordValidationService
    {
        protected bool OneDigit(string input);
        protected bool OneLowerCaseChar(string input);
        protected bool NoRepetition(string input);
        protected bool OneUpperCaseChar(string input);
        protected bool NineCharacters(string input);
        protected bool OneSpecialChar(string input);
        PasswordResponse ValidatePassword(PasswordRequest pr);
    }
}