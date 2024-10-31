var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<User> repo = [];

app.MapGet("/", () => "Hello World!");

app.Run();

class User
{
    public int Id { get; set; } 
    public string Login { get; set; }
    public string Password { get; set; }
}