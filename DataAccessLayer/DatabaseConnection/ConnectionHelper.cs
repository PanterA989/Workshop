
namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public static class ConnectionHelper
    {

        /// <returns>Database connection string string.</returns>
        public static string ConnectionString()
        {
            /*
             * As this is a training project,the login and password will be hardcoded into app.
             * In normall app I would put this data in App.Config to bo able to modify it after compilation
             */
            return "Server=DESKTOP-4LI1MUL;Database=WorkshopDB;User Id=WorkshopAdmin;Password=WorkshopAdmin;";

            //Windows Authentication
            //return "Server=DESKTOP-4LI1MUL;Database=WorkshopDB;Trusted_Connection=True;";
        }
    }
}
