using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YurtOtomasyon.DataAccess
{
    public static class Defaults
    {
        public static string GetConnectionString(string optionStr = "DB_1",string jsonFile = "appsettings.json")
        {
            return new ConfigurationBuilder().
                SetBasePath("C:\\Users\\bw\\source\\repos\\YurtOtomasyon\\YurtOtomasyon.DataAccess").
                AddJsonFile(jsonFile).
                Build().
                GetConnectionString(optionStr) ?? string.Empty;
        }

        

    }
}
