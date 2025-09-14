using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(e =>
{
    e.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Api Career",
        Description = "Provide information about career",
        Contact = new OpenApiContact
        {
            Name = "Lúcio Brito",
            Url = new Uri("https://portfolio.luciopbrito.com.br"),
        },
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsStaging()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/api-career/swagger/v1/swagger.json", "API v1");
        c.RoutePrefix = "swagger";
    });
        
    app.Use(async (context, next) =>
    {
        if (context.Request.Path == "/index.html" || context.Request.Path == "/")
        {
            context.Response.Redirect("/swagger", permanent: false);
            return;
        }
        await next();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
