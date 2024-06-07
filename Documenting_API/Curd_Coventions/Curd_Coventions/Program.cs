using Curd_Coventions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CompanyContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddEndpointsApiExplorer();
var xmlfile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlfile);
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title="Demo API For Curd Operations",
        Description="this is used for curd operations using webapi!!",
        Contact= new OpenApiContact
        {
            Name="Priyanka",
            Email="priya@gmail.com",
            Url=new Uri("https://www.ritechpune.com")
        }
    });
    options.IncludeXmlComments(xmlpath);
}

).AddSwaggerGenNewtonsoftSupport();

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
if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.MapControllers();
app.Run();
