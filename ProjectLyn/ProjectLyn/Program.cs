using Microsoft.AspNetCore.Server.Kestrel.Https;

namespace ProjectLyn
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            var builder = CreateHostBuilder(args);

            var host = builder.Build();

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
            // ���� �ɼ� ����
            return Host.CreateDefaultBuilder(args).UseSystemd()
                .ConfigureHostConfiguration(builder => { }) // Host ������ �߰��ϱ� ���� ���. ������ ȣ��� �� �ִ�.
                .ConfigureWebHostDefaults(webBuilder => // HTTP
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
