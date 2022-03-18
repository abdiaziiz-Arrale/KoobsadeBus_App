
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Helpers;

public static class PrincipalUtilities
{
	public static int GetId(this ClaimsPrincipal principal)
	{
		var input = principal.FindFirstValue(JwtRegisteredClaimNames.Sub);
		if (string.IsNullOrEmpty(input))
		{
			input = principal.FindFirstValue(ClaimTypes.NameIdentifier);
		}

		int.TryParse(input, out var userId);
		return userId;
	}
      public static int GetDriverId(this ClaimsPrincipal principal)
      {
		var isConversionSuccessful =int.TryParse(principal.FindFirstValue(JwtRegisteredClaimNames.Sub) ,out var DriverId);
		if (isConversionSuccessful )
		{
			return DriverId;
	}	
	return 0;
		}
}