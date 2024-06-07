var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if(app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseDeveloperExceptionPage();
}
else if(app.Environment.IsProduction())
{
    app.UseExceptionHandler("/error");
}
app.MapControllers();
app.Run();
