using System.Collections.Generic;
using burgercats.db;
using burgercats.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgercats.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class BurgerController : ControllerBase
  {
    public List<Burger> Burgers { get; set; } = fakeDB.Burgers;

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      return Ok(Burgers);
    }

  }


}