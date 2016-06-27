using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using TrenningApp.Properties;

namespace TrenningApp
{
    static class DatabaseCreator
    {
        private static readonly string _databaseName = "TrainingApp";

        private static readonly string _masterConnectionString =
            "Server=localhost;Integrated security=SSPI;database=master";

        private static readonly string _treningAppConnectionString = ConnectionParams.ConnectionString =
            "Server=localhost;Integrated security=SSPI;database=" + _databaseName;

        public static void CreateDatabase()
        {
            using (SqlConnection myConn = new SqlConnection(_masterConnectionString))
            {
                if (DatabaseExists(myConn, _databaseName))
                {
                    return;
                }

                var str = "CREATE DATABASE " + _databaseName + " ON PRIMARY " +
                          "(NAME = TrainingApp_Data, " + "FILENAME = '" +
                          Path.Combine(Application.StartupPath, "TrainingAppData.mdf") +
                          "',SIZE = 10MB, MAXSIZE = 100MB, FILEGROWTH = 10%) " +
                          "LOG ON (NAME = TrainingApp_Log, " + "FILENAME = '" +
                          Path.Combine(Application.StartupPath, "TrainingAppLog.ldf") +
                          "',SIZE = 5MB, " +
                          "MAXSIZE = 50MB, " +
                          "FILEGROWTH = 10%)";

                using (SqlCommand myCommand = new SqlCommand(str, myConn))
                {
                    try
                    {
                        myConn.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("DataBase is Created Successfully", _databaseName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), _databaseName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        if (myConn.State == ConnectionState.Open)
                        {
                            myConn.Close();
                        }
                    }
                }
            }
        }

        private static bool DatabaseExists(SqlConnection sqlConnection, string databaseName)
        {
            var sqlCheckDatabaseQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'",
                databaseName);

            try
            {
                using (SqlCommand sqlCmd = new SqlCommand(sqlCheckDatabaseQuery, sqlConnection))
                {
                    sqlConnection.Open();

                    object resultObj = sqlCmd.ExecuteScalar();

                    int databaseID = 0;

                    if (resultObj != null)
                    {
                        int.TryParse(resultObj.ToString(), out databaseID);
                    }

                    sqlConnection.Close();

                    return (databaseID > 0);
                }
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void SeedDatabase()
        {
            using (SqlConnection myConn = new SqlConnection(_treningAppConnectionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(Resources.AddCustomer, myConn))
                {
                    myConn.Open();

                    sqlCmd.ExecuteNonQuery();

                    myConn.Close();
                }
            }
        }
    }
}