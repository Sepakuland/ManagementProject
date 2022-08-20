using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using htmlproject.core.domain.Entities;
using KendoUI.Models;
using KendoUI.Services;
using Management.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UIS5HW.Core.Domain.Entities;

namespace Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        private readonly IAPIService aPIService;

        public GoodController(IAPIService aPIService)
        {
            this.aPIService = aPIService;
        }

        [Route("~/api/Good/GetAll")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var res = await aPIService.ForGetting("https://localhost:44398/api/Good");
             studentResponseModel = JsonConvert.DeserializeObject<StudentResponseModel>(res);
            
            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Students = studentResponseModel.Data
            };
            
            return Ok(studentViewModel.Students);
        }

        [Route("~/api/student/create")]
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await aPIService.ForCreating("https://localhost:44398/api/Student", data);

            var result = await response.Content.ReadAsStringAsync();

            return RedirectToAction("index");
        }

        [Route("~/api/student/update")]
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await aPIService.ForUpdating("https://localhost:44398/api/Good", data);

            var result = await response.Content.ReadAsStringAsync();

            return RedirectToAction("index");
        }

        [Route("~/api/Good/destroy/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await aPIService.ForDeleting($"https://localhost:44398/api/Good/?id={id}");
            return RedirectToAction("index");
        }
    }
}
