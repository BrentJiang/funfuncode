using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace MigrateWordStatistics
{
    /// <summary>
    /// migrate from BookReader to QRCodeMain for WordStatistics
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Usage: <program> <source-db(book_xiabook_mz.db)> <target-db(code.db)>");
                return;
            }

            if (!File.Exists("chineseLetters.txt"))
            {
                Console.WriteLine("Not exists chineseLetters.txt");
                return;
            }

            var zdict = new Dictionary<char, string>();
            var lines = File.ReadAllLines("chineseLetters.txt");
            foreach(var line in lines)
            {
                zdict[line[0]] = line.Substring(2).Replace('\"','\'');
            }

            using (var connection = new SqliteConnection("" +
    new SqliteConnectionStringBuilder
    {
        DataSource = args[0]//@"D:\dev_me\funfuncode\bin\book_xiabook_mz.db"
    })) using (var targetconn = new SqliteConnection("" +
        new SqliteConnectionStringBuilder
        {
            DataSource = args[1]//@"D:\dev_me\funfuncode\dotnetcore\QRCodeMain\code.db"
        })){
                connection.Open();

                targetconn.Open();

                using (var transaction = targetconn.BeginTransaction())
                {
                    var selectCommand = connection.CreateCommand();
                    selectCommand.CommandText = "SELECT * FROM WordStatisticses";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var insertCommand = targetconn.CreateCommand();
                            insertCommand.Transaction = transaction;
                            insertCommand.CommandText = $"INSERT or replace into WordStatisticses ( MaxOccur, MaxRatio, MaxWords, TotalBook, TotalOccur, TotalWords, WordUnicode, WordDescription )" +
                                $" VALUES ( {reader.GetInt32(1)}, {reader.GetDouble(2)}, {reader.GetInt32(3)}, {reader.GetInt32(4)}, {reader.GetInt32(5)}, {reader.GetInt32(6)}, \"{reader.GetString(7)}\", \"{zdict[reader.GetString(7)[0]]}\"  )";
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    //var selectCommand = targetconn.CreateCommand();
                    //selectCommand.Transaction = transaction;
                    //selectCommand.CommandText = "SELECT text FROM message";
                    //using (var reader = selectCommand.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        var message = reader.GetString(0);
                    //        Console.WriteLine(message);
                    //    }
                    //}

                    transaction.Commit();
                }
                using (var transaction = targetconn.BeginTransaction())
                {
                    var insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText = $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 1, 'zh_CN', '简体中文'  )";
                    insertCommand.ExecuteNonQuery();
                    insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText = $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 2, 'en_US', '美国英语'  )";
                    insertCommand.ExecuteNonQuery();
                    insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText = $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 3, 'cn_BlockChain', '区块链中文'  )";
                    insertCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
        }
    }
}
