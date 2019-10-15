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
    public ActionResult<Burger> Post([FromBody]Burger newBurger)
    {
      try
      {
        newBurger.Id = Guid.NewGuid().ToString();
        Burgers.Add(newBurger);
        return Ok(newBurger);
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Burger> Edit(string id, [FromBody]Burger newBurgerData)
    {
      try
      {
        Burger burgertoEdit = Burgers.Find(burger => burger.Id == id);
        if (burgertoEdit == null) { throw new Exception("invalid id"); }
        burgertoEdit.Name = newBurgerData.Name;
        burgertoEdit.Description = newBurgerData.Description;

        return Ok(burgertoEdit);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }


}