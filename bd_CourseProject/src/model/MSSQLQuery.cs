using Microsoft.SqlServer.Management.Smo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace bd_CourseProject.src.model
{
    public static class MSSQLQuery
    {
        static string connectionString = "";

        public static async Task Connection(string dataSource, string initialCatalog)
        {
            try
            {
                connectionString = $"Data Source={dataSource};" +
                    $"Initial Catalog={initialCatalog};" +
                    $"Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                }
            }
            catch
            {
                MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task Connection(string dataSource, string initialCatalog, string login, string pass)
        {
            try
            {
                connectionString = $"Data Source={dataSource};" +
                   $"Initial Catalog={initialCatalog};" +
                   $"User ID={login};Password={pass};" +
                   $"Network Library=dbmssocn";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                }
            }
            catch
            {
                MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task CreateParsedTableAsync(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand();
                command.CommandText = $"CREATE TABLE {tableName} " +
                    "(id INT IDENTITY(1, 1) PRIMARY KEY NOT NULL, " +
                    "territory_id INT, " +
                    "territory varchar(255), " +
                    "ped_work_edu_preschool varchar(255), " +
                    "ped_work_edu_gnrl varchar(255), " +
                    "ped_work_edu_addchldrn varchar(255), " +
                    "tchrs_edu_organprim_secondvoc varchar(255), " +
                    "tchrs_edu_higherprof varchar(255), " +
                    "dctrs_highermed_edu_medsrvcs varchar(255), " +
                    "par_med_prs_medsrvcs varchar(255), " +
                    "junior_dctrs_medsrvcs varchar(255), " +
                    "social_work varchar(255), " +
                    "work_cultural_institutions varchar(255), " +
                    "scientific_staff varchar(255), " +
                    "ped_work_edu_med_sclsrvcs varchar(255))";
                command.Connection = connection;
                await command.ExecuteNonQueryAsync();
            }
        }

        public static void InsertDataIntoParsedTable(List<AverageSalary> averageSalaries, string tableName)
        {
            DapperPlusManager.Entity<AverageSalary>().Table($"{tableName}");
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.BulkInsert(averageSalaries);
            }
        }

        public static async Task CreateDirectoryTableAsync(string tableName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    await connection.OpenAsync();

                    command.CommandText = "CREATE TABLE tbl_territory " +
                        "(id INT IDENTITY(1, 1) NOT NULL, " +
                        "territory VARCHAR(255) NOT NULL)";
                    await command.ExecuteNonQueryAsync();

                    command.CommandText = $"ALTER TABLE tbl_territory ADD PRIMARY KEY(id)";
                    await command.ExecuteNonQueryAsync();

                    command.CommandText = $"INSERT INTO tbl_territory(territory) SELECT DISTINCT {tableName}.territory FROM {tableName}";
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public static async Task InsertDataIntoDirectoryTableAsync(string tableName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"ALTER TABLE {tableName} ADD FOREIGN KEY(territory_id) REFERENCES tbl_territory(id)";
                    await command.ExecuteNonQueryAsync();

                    command.CommandText = $"UPDATE {tableName} SET {tableName}.territory_id = tbl_territory.id FROM {tableName}, tbl_territory " +
                        $"WHERE {tableName}.territory = tbl_territory.territory";
                    await command.ExecuteNonQueryAsync();

                    command.CommandText = $"ALTER TABLE {tableName} DROP COLUMN territory";
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public static async Task<bool> ExistenceСheckDirectoryTableAsync()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT count(id) FROM sysobjects WHERE name = 'tbl_territory' AND type = 'U'", connection))
                {
                    await connection.OpenAsync();
                    int count = (int)await command.ExecuteScalarAsync();
                    connection.Close();
                    return count == 1;
                }
            }
        }

        public static List<string> GetDatabaseList(string nameSQLServer)
        {
            var dbList = new List<string>();
            try
            {
                Server server = new Server(nameSQLServer);
                dbList = (from Database database in server.Databases
                          where !database.IsSystemObject && !database.IsDatabaseSnapshot
                          select database.Name).ToList();
            }
            catch
            {
                MessageBox.Show("Error getting list of databases");
            }
            return dbList;
        }
    }
}
