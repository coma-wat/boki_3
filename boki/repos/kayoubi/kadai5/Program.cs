using System;
using System.IO;
namespace kadai5
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length<=1)
            {
                Console.WriteLine("入力ファイルと出力ファイルを指定してください");
                Environment.Exit(1);
            }
            if (!File.Exists(args[0])) 
            {
                Console.WriteLine("入力ファルがありません");
                Environment.Exit(2);
            }
            string filedata;
            using (StreamReader sr = new StreamReader(args[0]))
            {
                filedata = sr.ReadToEnd();
            }
            using (StreamWriter sw = new StreamWriter(args[1]))
            {
                sw.Write(filedata);
            }




}
    }
}
