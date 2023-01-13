var builder = WebApplication.CreateBuilder(args);

var hostBuilder = builder.Host;
hostBuilder.ConfigureServices((context, services) =>
{
    services
        .AddAuthorization()
        .AddControllers();
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UsePathBase("/sabasapp");
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.MapGet("/tester", () => "Hello World!");

app.Run();