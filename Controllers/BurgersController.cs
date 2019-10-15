using System;
using System.Collections.Generic;
using burgercats.db;
using burgercats.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgercats.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class BurgersController : ControllerBase
  {
    public List<Burger> Burgers { get; set; } = fakeDB.Burgers;

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      return Ok(Burgers);
    }

    [HttpGet("{id}")]
    public ActionResult<Burger> Get(string id)
    {
      try
      {
        Burger b = Burgers.Find(b => b.Id == id);
        if (b == null) { throw new Exception("Invalid Id"); }
        return Ok(b);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Burger> Post([FromBody]Burger Burger)
    {
      try
      {
        Burger.Id = Guid.NewGuid().ToString();

      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }

  }


}