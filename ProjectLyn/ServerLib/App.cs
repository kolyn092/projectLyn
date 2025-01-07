using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLib
{
    public static class App
    {
        private static string _environmentName;
        public static string ConfigEnvironment => EnvironmentName.ToLower();

        public static string EnvironmentName
        {
            get
            {
                if (string.IsNullOrEmpty(_environmentName))
                {
                    _environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                }

                return _environmentName;
            }
        }
    }
}
