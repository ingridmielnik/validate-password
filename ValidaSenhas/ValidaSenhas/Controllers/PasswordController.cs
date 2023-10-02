using Microsoft.AspNetCore.Mvc;
using ValidaSenhas.Model.Request;
using ValidaSenhas.Model.Response;
using ValidaSenhas.Service.Interfaces;

namespace ValidaSenhas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordValidationService _service;
        public PasswordController(IPasswordValidationService service) => _service = service;

        [HttpPost]
        public ActionResult<PasswordResponse> PasswordValidation(PasswordRequest password)
        {
            var result = _service.ValidatePassword(password);
            return result;
        }
    }
}