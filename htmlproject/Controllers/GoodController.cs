using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Models;
using KendoUI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UIS5HW.Core.Domain.Entities;

namespace ManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IAPIService aPIService;

        public StudentController(IAPIService aPIService)
        {
            this.aPIService = aPIService;
        }

        [Route("~/api/student/GetAll")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var res = await aPIService.ForGetting("https://localhost:44398/api/Student");
            StudentResponseModel studentResponseModel = JsonConvert.DeserializeObject<StudentResponseModel>(res);

            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Students = studentResponseModel.Data
            };

            return Ok(studentViewModel.Students);
        }

        [Route("~/api/student/create")]
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {

            var json = JsonConvert.SerializeObject(student);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await aPIService.ForCreating("https://localhost:44398/api/Student", data);

            var result = await response.Content.ReadAsStringAsync();

            return RedirectToAction("index");
        }

        [Route("~/api/student/update")]
        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            var json = JsonConvert.SerializeObject(student);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await aPIService.ForUpdating("https://localhost:44398/api/Student", data);

            var result = await response.Content.ReadAsStringAsync();

            return RedirectToAction("index");
        }

        [Route("~/api/student/destroy/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await aPIService.ForDeleting($"https://localhost:44398/api/Student/?id={id}");
            return RedirectToAction("index");
        }
    }
}
