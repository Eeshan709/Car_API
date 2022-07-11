using Car_API.EF;
using Car_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Car_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private CarDBContext _db;
        public MakesController(CarDBContext db) {
            _db = db;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {

            var makes = _db.Makes.ToList();

            return Ok(makes);
        }

        [Route("Get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {

            var make = _db.Makes.Find(id);

            if (make == null)
                return NotFound();

            return Ok(make);
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(MakeModel model)
        {
            if(string.IsNullOrEmpty(model.Make))
                return BadRequest("No data was found.");

            Make make = new Make();
            make.MakeName = model.Make;

            _db.Makes.Add(make);
            _db.SaveChanges();

            return Ok(make);
        }

        [Route("Update")]
        [HttpPut]
        public IActionResult Update(MakeModel model)
        {
            if (model.Id == 0)
                return BadRequest("No Id specified.");

            if (string.IsNullOrEmpty(model.Make))
                return BadRequest("No data was found.");

            var make = _db.Makes.Find(model.Id);

            if (make is null)
                return BadRequest("Incorrect Make Id.");

            make.MakeName = model.Make;

            _db.Makes.Attach(make);
            _db.SaveChanges();

            

            return Ok(make);
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            var make = _db.Makes.Find(id);

            if (make == null)
                return NotFound();

            _db.Makes.Remove(make);
            _db.SaveChanges();

            return Ok(make);
        }

    }
}
