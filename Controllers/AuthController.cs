
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Data;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// using Data;
// using Microsoft.IdentityModel.JsonWebTokens;
namespace Controllers;
// [ApiController]

[Route("[Controller]")]
// [Authorize]

public class AuthController:ControllerBase
{
      private readonly KoobsadeDbContext _context;
      public AuthController(KoobsadeDbContext context)
      {
           _context = context; 
      }
      [HttpGet]
//   [Authorize]
  public async Task<IActionResult> Login(string email)
  {
        var login = await _context.Users.SingleOrDefaultAsync(l=> l.Email==email);
        if(login is null)
        {
              return BadRequest("Laguuma ogala");
        }
        var now = DateTime.Now;
       	var claims = new List<Claim>
		{
			new(JwtRegisteredClaimNames.Sub , login.Id.ToString()),
                  new(JwtRegisteredClaimNames.Name, login.FullName),
			new(JwtRegisteredClaimNames.Gender, login.Gender),
			new(JwtRegisteredClaimNames.Email, login.Email),
		};


		var Driver = await _context.BusDrivers.SingleOrDefaultAsync(b=> b.UserId ==login.Id);
		if (Driver is not null)
		{
			claims.Add(new("DriverId", Driver.Id.ToString()));
		}

  var keyInput = "Somaliland_waa_dal_Kamida_Dalalka_Soo_Koraya";
   
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyInput));
		var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var token = new JwtSecurityToken("Myface", "MyonlyOne", claims, now, now.AddDays(2), credentials);

		var handler = new JwtSecurityTokenHandler();
		var jwt = handler.WriteToken(token);

		var result = new
		{
			token = jwt
		};

		return Ok(result);
	}
}
  