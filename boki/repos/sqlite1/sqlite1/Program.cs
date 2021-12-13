using System;
using System.Data.SQLite;

namespace sqlite1
{
    class Exercise
    {
        public static void Main()
        {
            var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "test.db" };
            var cn = new SQLiteConnection(sqlConnectionSb.ToString());

            cn.Open();

            var cmd = new SQLiteCommand(cn);
            // 表「社員名簿」を作成する。
            // IF NOT EXISTSで表が既にあったときは作成しないようにする。
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS 社員名簿(" +
                "社員番号 TEXT NOT NULL," +
                "名前     TEXT NOT NULL," +
                "生年月日 TEXT NOT NULL)";
            cmd.ExecuteNonQuery();

            // 表「保有資格」を作成する
            // IF NOT EXISTSで表が既にあったときは作成しないようにする。
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS 保有資格(" +
                "社員番号 TEXT NOT NULL," +
                "保有資格 TEXT NOT NULL)";
            cmd.ExecuteNonQuery();

            // 表「社員名簿」のデータを削除する。
            cmd.CommandText = "DELETE FROM 社員名簿";
            cmd.ExecuteNonQuery();

            // 表「保有資格」のデータを削除する。
            cmd.CommandText = "DELETE FROM 保有資格";
            cmd.ExecuteNonQuery();

            // 表「社員名簿」にデータを挿入する。
            cmd.CommandText = "INSERT INTO 社員名簿 VALUES (" +
                "'A010', '相沢Ａ子', '2001/10/01')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO 社員名簿 VALUES (" +
                "'B020', '高橋Ｂ男', '2001/05/18')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO 社員名簿 VALUES (" +
                "'C030', '中島Ｃ助', '2002/03/21')";
            cmd.ExecuteNonQuery(); 
            
            

            // 表「保有資格」にデータを挿入する。
            cmd.CommandText = "INSERT INTO 保有資格 VALUES (" +
                "'C030', '基本情報技術者試験')";
            cmd.ExecuteNonQuery();

            // 社員の生年月日を間違えていたので変更する。
            cmd.CommandText = "UPDATE 社員名簿 SET 生年月日 = '2001/10/02'" +
                " WHERE 社員番号 = 'A010'";
            cmd.ExecuteNonQuery();

            // 2つの表の外部結合の結果を表示する。
            cmd.CommandText = "SELECT 社員名簿.社員番号, 社員名簿.名前, 社員名簿.生年月日, 保有資格.保有資格" +
                    " FROM 社員名簿  LEFT OUTER JOIN 保有資格 ON 社員名簿.社員番号 = 保有資格.社員番号";
            SQLiteDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.Write(sdr["社員番号"] + ", ");
                Console.Write(sdr["名前"] + ", ");
                Console.Write(sdr["生年月日"] + ", ");
                Console.WriteLine(sdr["保有資格"]);
            }


            cn.Close();
        }
    }
}
