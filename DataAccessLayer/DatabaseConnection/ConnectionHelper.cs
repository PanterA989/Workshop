using System.Configuration;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public static class ConnectionHelper
    {

        /// <summary>
        /// Gets database connection string from App.config file.
        /// </summary>
        /// <returns>Database connection string.</returns>
        public static string GetConnectionString()
        {
            //TODO: Cannot get the connectionstring from config
            return "Data Source=.;Initial Catalog=WorkshopDB;Integrated Security=True;";
            return ConfigurationManager.ConnectionStrings["WorkshopDB"].ConnectionString;
        }
    }
}
