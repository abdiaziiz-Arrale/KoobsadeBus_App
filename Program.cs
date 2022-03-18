using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json.Serialization;
using System.Text;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
.AddJsonOptions(options=> options.JsonSerializerOptions.ReferenceHandler =ReferenceHandler.IgnoreCycles);
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<Data.KoobsadeDbContext>(

      config=> config.UseSqlServer(connectionString)
);

builder.Services.AddAuthentication("Bearer").AddJwtBearer(
      options=>{
            options.RequireHttpsMetadata=false;
            var keyInput = "Somaliland_waa_dal_Kamida_Dalalka_Soo_Koraya";
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyInput));
            options.TokenValidationParameters= new TokenValidationParameters
            {
                  ValidateIssuer= true,
                  ValidIssuer = "MyFace",
                  ValidateAudience= true,
                  ValidAudience="MyonlyOne",
                  IssuerSigningKey =key
                  
            };

      });
builder.Services.AddCors(config => config.AddPolicy("Default",policy=> policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));


builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
