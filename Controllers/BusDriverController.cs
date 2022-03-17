using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Controllers;
using Data;
using ViewModel;
[Route("[Controller]")]
public class BusDriverController:ControllerBase
{
      private readonly KoobsadeDbContext _context;
      public BusDriverController(KoobsadeDbContext context)
      {
         _context =context   ;
      }

      [HttpGet]
      public async Task<IActionResult> GetDriver()
      {
            var Driver = await _context.BusDrivers.ToListAsync();
            return Ok(Driver);

      }
      [HttpPost]
      public async Task<IActionResult> AddDriver([FromBody] BusDriver busDriver )
      {
        _context.BusDrivers.AddAsync(busDriver);
    await _context.SaveChangesAsync();
    return Ok( busDriver);
      }

   
}