using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

builder.Services.AddDbContext<ControleContext>(opt =>
{
   opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); 
});

var app = builder.Build();

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ControleContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

try
{
    context.Database.Migrate();
    DbInitializer.Initialize(context);
}
catch(Exception ex)
{
    logger.LogError(ex,"A problem occured during migration");
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors(policy => 
    policy.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod()
    );

app.MapControllers();

app.Run();
