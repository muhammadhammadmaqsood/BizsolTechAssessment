using BizsolTechAssessment.Models.DataAccessLayer;
using BizsolTechAssessment.Models.DBModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BizsolTechAssessment.Controllers
{
    public class DevelopersController : Controller
    {
        private IAllRepository<Developer> Developer;
        public DevelopersController(IAllRepository<Developer> developer)
        {
            this.Developer = developer;
        }

        public async Task<IActionResult> Index()
        {
            var developers = await this.Developer.GetData();
            return View(developers);
        }

        public IActionResult AddDeveloper()
        {
            return View();
        }

        public bool AddDeveloperData(string developerJson)
        {
            List<Developer> developer = JsonConvert.DeserializeObject<List<Developer>>(developerJson);
            foreach (var dev in developer)
            {
                this.Developer.AddRecord(dev);
            }
            this.Developer.Save();
            return true;
        }
    }
}
