var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddRazorPages();
var app = builder.Build();


app.MapControllerRoute(name: "default",
        pattern: "{controller=Home}/{action=Index}"

    );
//app.MapGet("/", () => "Hello World!");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.Run();
