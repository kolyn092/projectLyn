using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApi
{
    public class AdminHostedService : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (ServerLib.App.Services.Contains("AdminApi") == false)
            {
                Logger.Default.LogInformation("Cancel AdminApi HostedService");
                return;
            }

            Logger.Default.LogInformation("Start AdminApi HostedService");


        }
        public async Task StopAsync(CancellationToken cancellationToken)
        {
        }
    }
}
