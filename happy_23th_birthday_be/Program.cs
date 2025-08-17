using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using MudBlazor.Services;

namespace happy_23th_birthday_be
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Create a new WebAssembly host builder
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
