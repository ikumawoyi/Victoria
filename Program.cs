using VictorianPlumbing.Context;
using VictorianPlumbing.Helpers;
using VictorianPlumbing.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<Loader>();
builder.Services.AddDbContext<VictoriaPlumbingDbContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));



var app = builder.Build();

var scopeeee = app.Services.CreateScope();
var product = scopeeee.ServiceProvider.GetRequiredService<IProductService>();

product.Create();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
