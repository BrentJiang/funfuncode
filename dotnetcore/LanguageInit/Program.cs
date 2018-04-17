using System;
using Microsoft.Data.Sqlite;

namespace LanguageInit
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: <program> <target-db(code.db)>");
                return;
            }
            using (var targetconn = new SqliteConnection(
                "" +
                new SqliteConnectionStringBuilder
                {
                    DataSource = args[0]
                }))
            {
                targetconn.Open();
                using (var transaction = targetconn.BeginTransaction())
                {
                    var insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText =
                        $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 1, 'zh_CN', '简体中文'  )";
                    insertCommand.ExecuteNonQuery();
                    insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText =
                        $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 2, 'en_US', '美国英语'  )";
                    insertCommand.ExecuteNonQuery();
                    insertCommand = targetconn.CreateCommand();
                    insertCommand.Transaction = transaction;
                    insertCommand.CommandText =
                        $"INSERT or replace into Languages ( LanguageType, LanguageCode, LanguageName )" +
                        $" VALUES ( 3, 'cn_BlockChain', '区块链中文'  )";
                    insertCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
            }
        }
    }
}
