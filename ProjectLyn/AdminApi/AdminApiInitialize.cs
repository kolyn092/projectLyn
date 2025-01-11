using Microsoft.Extensions.DependencyInjection;
using ServerLib;

namespace AdminApi
{
    public class AdminApiInitialize
    {
        [InitializeConfigureServices]
        private static void InitializeOnStartup(IServiceCollection services)
        {

        }
    }
}
