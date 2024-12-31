using Microsoft.AspNetCore.Server.Kestrel.Https;

namespace ProjectLyn
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = CreateHostBuilder(args);

            var host = builder.Build();
            /*
            // Configure the HTTP request pipeline.
            if (!host.Environment.IsDevelopment())
            {
                host.UseExceptionHandler("/Home/Error");
            }
            host.UseStaticFiles();

            // The default HSTS value is 30 days. You may want to change this production scenarios.
            host.UseHsts();

            host.UseRouting();

            host.UseAuthorization();

            host.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            */

            await Task.Run(async () =>
            {
                try
                {
                    await host.StartAsync(default);

                    await host.WaitForShutdownAsync(default);
                }
                finally
                {
                    if (host is IAsyncDisposable asyncDisposable)
                    {
                        await asyncDisposable.DisposeAsync();
                    }
                    else
                    {
                        host.Dispose();
                    }
                }
            });
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // 1. 각종 옵션 설정 세팅
            return Host.CreateDefaultBuilder(args).UseSystemd()
                .ConfigureHostConfiguration(builder => { })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.ConfigureHttpsDefaults(adapterOptions =>
                        {
                            adapterOptions.ClientCertificateMode = ClientCertificateMode.RequireCertificate;
                        });
                        options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(10);
                    }).UseStartup<Startup>();
                });
        }
    }
}
