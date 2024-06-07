using Curd_Coventions.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CompanyContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddCors(
    opt =>
    {
        opt.AddDefaultPolicy(p =>
        {
            p.AllowAnyOrigin();
            p.AllowAnyMethod();
            p.AllowAnyHeader();
        });
    }
    );


var app = builder.Build();

app.UseCors();
app.MapControllers();
app.Run();
