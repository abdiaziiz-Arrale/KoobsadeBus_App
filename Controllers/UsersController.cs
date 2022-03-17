using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using Models;
using Data;
namespace Controllers;
[Route("[Controller]")]
public class UsersController :ControllerBase
{
private readonly KoobsadeDbContext _context;
    public UsersController(KoobsadeDbContext Context)
    {
          _context =Context;
    }  
[HttpGet]
    public async Task<IActionResult> GetUsers()
    {
          var users = await _context.Users.ToListAsync();
          return Ok(users);
    }
    //get /single
[HttpGet("id")]
public async Task<IActionResult> GetUser(int id)
{
      var user = await _context.Users.FindAsync(id);

      return Ok(user );

}



[HttpPost]
    public async Task<IActionResult> AddUser([FromBody] User user)
    {

         await _context.Users.AddAsync(user);
          _context.SaveChanges();
          return Created("" ,user);
    }
[HttpPut("id")]
    public async Task<IActionResult> UpdateUser(int id,[FromBody] User user)
    {
          var Targetuser = await _context.Users.FindAsync(id);
          if (User is null)
          {
                return BadRequest();
          }
         Targetuser.FullName = user.FullName;
         Targetuser.Address = user.Address;
         Targetuser.Email = user.Email;
         Targetuser.Gender = user.Gender;
         Targetuser.Phone = user.Phone;
        _context.Update(Targetuser);
       await _context.SaveChangesAsync();
         return Created("" ,Targetuser);


    }

    [HttpDelete("id")]
    public async Task<IActionResult> DeleteUser(int id)
    {
       var DeleteUser = await _context.Users.FindAsync(id);
       if (DeleteUser is null)
       {
          return BadRequest();
       }
       _context.Users.Remove(DeleteUser);
       await _context.SaveChangesAsync();
       return NoContent();
    }
}
