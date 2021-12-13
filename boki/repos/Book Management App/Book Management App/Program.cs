using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Book_Management_App
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "data.db" };
            var cn = new SQLiteConnection(sqlConnectionSb.ToString());

            cn.Open();

            var cmd = new SQLiteCommand(cn);
            // 表「書籍一覧」を作成する。
            // IF NOT EXISTSで表が既にあったときは作成しないようにする。
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS 書籍一覧(" +
                "ID TEXT NOT NULL," +
                "書籍名 TEXT NOT NULL," +
                "著者 TEXT NOT NULL," +
                "ジャンル TEXT NOT NULL)";
            cmd.ExecuteNonQuery();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            cn.Close();
            cmd.CommandText = "INSERT INTO 書籍一覧 VALUES(" + "'1','c#超入門','北村愛美','参考書')";
            cmd.ExecuteNonQuery();


           



        }
    }
}
