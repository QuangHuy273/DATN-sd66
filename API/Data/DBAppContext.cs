
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.Data
{
    public class DBAppContext : DbContext
    {
        public DBAppContext(DbContextOptions options) : base(options)
        {
        }

        public DBAppContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=maliss;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");

            //string dbFilePath = "dbconfig.txt";
            //string Dbcheck = "check.txt";
            //string Db = "";
            //string check = ""; 


            //if (File.Exists(Dbcheck))
            //{
            //    check = File.ReadAllText(dbFilePath).Trim();
            //}


            //if (string.IsNullOrWhiteSpace(check))
            //{
            //    DataTable instances = SqlDataSourceEnumerator.Instance.GetDataSources();
            //    if (instances.Rows.Count > 0)
            //    {
            //        DataRow firstRow = instances.Rows[0];
            //        Db = firstRow["InstanceName"].ToString();
            //        File.WriteAllText(Dbcheck, Db);
            //        File.WriteAllText(Dbcheck, "True");
            //    }
            //}


            //string connectionString = $"Data Source=.\\{Db};Initial Catalog=Jolly;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True";

            //optionsBuilder.UseSqlServer($"Data Source=.\\{Db};Initial Catalog=Jolly;Integrated Security=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
