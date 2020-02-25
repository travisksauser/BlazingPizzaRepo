using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<OrderState>();

            // add authentication services
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();

            // notifier Service component communication method - not being used
            services.AddSingleton<NotifierService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
