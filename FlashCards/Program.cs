using Blazored.LocalStorage;
using Fluxor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddFluxor(opt =>
{
    opt.ScanAssemblies(typeof(Program).Assembly);
    opt.UseRouting();
    opt.UseReduxDevTools();
});
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();