var builder = WebApplication.CreateBuilder(args);

// ADICIONA ISSO
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// SWAGGER
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// ESSA LINHA É A MAIS IMPORTANTE 🚨
app.MapControllers();

app.Run();