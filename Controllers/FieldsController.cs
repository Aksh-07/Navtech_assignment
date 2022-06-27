using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NavTech_Assignment.Models;

namespace NavTech_Assignment.Controllers;

[ApiController]
public class PeopleApiController : ControllerBase
{
    // Some code omitted for clarity


    [HttpGet]
    public IActionResult Create(Product product)
    {
        try 
        {
            //code to store our product from page to our db 
        return Ok(product);
        }
        catch (Exception ex)
        {
            //call store procedure to save  ex to the database
            return StatusCode(500,"Please Contact ASG , Something went wrong");
        }

    }


}