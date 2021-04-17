using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AssigmentTwo.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase
    {
        private FileContext fileContext;

        public FamilyController(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamily()
        {
            try
            {
                IList<Family> tempFamilies = fileContext.Families;
                return Ok(tempFamilies);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}