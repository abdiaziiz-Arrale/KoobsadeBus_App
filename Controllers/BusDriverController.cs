using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
namespace Controllers;
using Microsoft.AspNetCore.Authorization;
using Data;
using Helpers;
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
            var Driver = await _context.BusDrivers.Include(d=> d.User).ToListAsync();
            return Ok(Driver);

      }
      [HttpPost]
      // [Authorize]
      public async Task<IActionResult> AddDriver( [FromBody] BusDriverViewModel busDriverViewModel )
 
 {
       var driver = await _context.BusDrivers.SingleOrDefaultAsync(d=> d.UserId==User.GetId());
       if( driver  is not null)
       {
             return BadRequest("ka bax meesha");
       }
      driver =new BusDriver
      {
       DriverLisence = busDriverViewModel.DriverLisence ,
       CarTrNo = busDriverViewModel.CarTrNo,
       TypeOfBus = busDriverViewModel.TypeOfBus,
       NumberOfseats = busDriverViewModel.NumberOfseats,
 
          UserId = User.GetId()

      };
        await _context.AddAsync(driver);
     await _context.SaveChangesAsync();
     return Created("",driver);
 }

   
}