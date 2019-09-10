using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.core.applicationService;
using PetShop.core.applicationService.service;
using PetShop.Core.Entity;

namespace PetShopApp.UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetsService _PetService;

        public PetController(IPetsService PetService)
        {
            _PetService = PetService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return _PetService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            return _PetService.ReadId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Pet animal)
        {
            _PetService.Creat(animal);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet Animal)
        {
            _PetService.UpdatePet( Animal);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _PetService.deletePet(id);
        }
    }
}
