using DsdRegistrationApi.Models;
using Microsoft.AspNetCore.Mvc;
using RegisterSvc;
using System.Threading.Tasks;

namespace DsdRegistrationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post(RegisterModel model)
        {
            Register register = new Register
            {
                PID = model.PID,
                Title = model.Title,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                LicenseType = model.LicenseType,
                ForPractice = model.ForPractice,
                ForTestSystem = model.ForTestSystem,
                CourseType = model.CourseType,
                SchoolId = model.SchoolId,
                ExamNumber = model.ExamNumber,
                BirthDate = model.BirthDate,
                ApprovedDateTime = model.ApprovedDateTime,
                ExpireDateTime = model.ExpireDateTime,
                AppointDateTime = model.AppointDateTime,
                Status = model.Status,
                Address = model.Address,
                QuizLanguage = model.QuizLanguage,
                ApplicationId = model.ApplicationId,
                IsListenQuiz = model.IsListenQuiz,
                PhoneNumber = model.PhoneNumber,
            };

            Register[] registers = new Register[] { register };
            await new RegistrationServiceClient().RegisterNewPersonAsync(registers);

            return Ok();
        }
    }
}