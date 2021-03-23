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
            return ConfigurationManager.ConnectionStrings["WorkshopDB"].ConnectionString;
        }
    }
}
