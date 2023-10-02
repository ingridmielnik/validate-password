using System.Text.RegularExpressions;
using ValidaSenhas.Model.Request;
using ValidaSenhas.Model.Response;
using ValidaSenhas.Service.Interfaces;

namespace ValidaSenhas.Service
{
    public class PasswordValidationService : IPasswordValidationService
    {
        public bool NineCharacters(string input)
        {
            if (input.Length >= 9)
            {
                return true;
            }
            return false;
        }
        public bool OneLowerCaseChar(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool OneDigit(string input)
        {
            if (input.Any(char.IsDigit))
                return true;
            else
                return false;
        }
        public bool OneUpperCaseChar(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }
        public bool OneSpecialChar(string input)
        {
            Regex check = new Regex("[^a-zA-Z0-9]");
            return check.IsMatch(input);
        }
        public bool NoRepetition(string input)
        {
            char[] caracteres = input.ToCharArray();
            var grupos = caracteres.GroupBy(c => c);

            if (grupos.Any(grupo => grupo.Count() > 1))
            {
                return false; 
            }

            return true; 
        }
        public PasswordResponse ValidatePassword(PasswordRequest pr)
        {
            PasswordResponse passRes = new PasswordResponse();

            if (NoRepetition(pr.Password) == true && OneSpecialChar(pr.Password) == true && OneUpperCaseChar(pr.Password) == true && OneDigit(pr.Password) == true && OneLowerCaseChar(pr.Password) == true && NineCharacters(pr.Password) == true)
            {
                passRes.Valid = true;
                return passRes;
            }
            passRes.Valid = false;
            return passRes;
        }
    }
}