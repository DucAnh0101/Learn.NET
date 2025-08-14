using MIddleware.Filters;
using MIddleware.Middleware;
using MIddleware.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<CustomActionFilter>();
builder.Services.AddScoped<LoggingActionFilter>();
builder.Services.AddSingleton<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseErrorHandlingMiddleware();
app.UseLoggingMiddleware();
app.UseRequestHeaderCheckMiddleware();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
