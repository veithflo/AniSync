using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AniSync
{


    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            tables tab = new tables();
            tab.init();

            Console.WriteLine(tab.users.Rows.Count);
            Console.WriteLine(tab.users.Rows.Contains("ASDF"));


            //animes xx;
            //
            //xx.id = "ADF";
            //xx.dub = "get";
            //
            //animes[] yy = new animes[99];
            //yy[0].id = "ASDF";




            //var aa = new List<animes>();
            //aa.Add(new animes { id = "asdf", name_jap = "asdf", name_eng = "asdf",  name_ger = "asdf", language = "asdf", sub = "asdf", dub = "asdf", tracker = "asdf", filename = "asdf", status = "asdf", rating = 0});



            //System.Data.DataTable tab;
            //System.Data.DataColumn col;
            //System.Data.DataRow row;
            //
            //System.Data.DataTable animes = new System.Data.DataTable("animes");
            //animes.Columns.Add("id", typeof(String));
            //animes.Columns.Add("user_id", typeof(String));
            //animes.Columns.Add("name_jap", typeof(String));
            //animes.Columns.Add("name_eng", typeof(String));
            //animes.Columns.Add("name_ger", typeof(String));
            //animes.Columns.Add("language", typeof(String));
            //animes.Columns.Add("sub", typeof(String));
            //animes.Columns.Add("dub", typeof(String));
            //animes.Columns.Add("tracker", typeof(String));
            //animes.Columns.Add("filename", typeof(String));
            //animes.Columns.Add("status", typeof(String));
            //animes.Columns.Add("rating", typeof(SByte));
            //animes.PrimaryKey = new System.Data.DataColumn[] { animes.Columns["id"] };
            //
            //Console.WriteLine("columns:"+ animes.Columns[0].ColumnName);
            //
            //row = tab.NewRow();
            //row["id"] = "asdf";
            //row["name_jap"] = "name_jap";
            //tab.Rows.Add(row);
            //Console.WriteLine("row.contains: " + tab.Rows.Contains("asdf"));





            //return;




            //MySqlConnection sqlconn = new MySqlConnection("server=r2web32.masterlogin.de;user id=q5web777wesql4;password=3lYNU6$!;database=q5web777wesql4db1;sslmode=none");
            //MySqlCommand sqlcmd = sqlconn.CreateCommand();
            //MySqlDataReader sqlread;
            //try
            //{
            //    sqlconn.Open();
            //    sqlcmd.CommandText = "select * from as_animes;";
            //    sqlread = sqlcmd.ExecuteReader();
            //    while (sqlread.Read())
            //    {
            //        for (int i = 0; i < sqlread.FieldCount; i++)
            //        {
            //            Console.WriteLine(">" + sqlread.GetName(i) + " : " + sqlread.GetValue(i));
            //        }
            //    }
            //    sqlconn.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.WriteLine("");
            Console.WriteLine("Press any key to close application ...");
            Console.ReadKey();


        }
    }
}
