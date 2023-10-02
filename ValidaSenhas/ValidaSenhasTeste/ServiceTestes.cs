using ValidaSenhas.Model.Request;
using ValidaSenhas.Service;

namespace ValidaSenhasTeste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateNineCharacters()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.NineCharacters("ThisPasswordHasMoreThanNineCharacters");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoValidateNineCharacters()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.NineCharacters("Password");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateOneLowerCaseChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneLowerCaseChar("password");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoValidateOneLowerCaseChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneLowerCaseChar("PASSWORD");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateAtLeastOneDigit()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneDigit("Password123");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoValidateAtLeastOneDigit()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneDigit("Password");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateOneUpperCaseChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneUpperCaseChar("Password");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoValidateOneUpperCaseChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneUpperCaseChar("123password");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateOneSpecialChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneSpecialChar("@Password*");
            Assert.IsTrue(result);
        }

        [Test]
        public void NoValidateOneSpecialChar()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.OneSpecialChar("123password");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateNoRepeatedChars()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.NoRepetition("123pasword");
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateRepeatedChars()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            var result = passwordValidationService.NoRepetition("AbTp9!foA");
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidatePassword()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            PasswordRequest request = new PasswordRequest("AbTp9!fok");
            var result = passwordValidationService.ValidatePassword(request);
            Assert.IsTrue(result.Valid);
        }

        [Test]
        public void NoValidatePassword()
        {
            PasswordValidationService passwordValidationService = new PasswordValidationService();
            PasswordRequest request = new PasswordRequest("AbTp9!foA");
            var result = passwordValidationService.ValidatePassword(request);
            Assert.IsFalse(result.Valid);
        }
    }
}