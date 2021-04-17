using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace AssigmentTwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private FileContext fileContext;

        public AdultsController(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults()
        {
            try
            {
                IList<Adult> tempAdults = await fileContext.getAllAdultsFromFamilies();
                return Ok(tempAdults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}