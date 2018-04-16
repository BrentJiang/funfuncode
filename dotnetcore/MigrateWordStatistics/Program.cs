using Microsoft.Data.Sqlite;
using System;

namespace MigrateWordStatistics
{
    /// <summary>
    /// migrate from BookReader to QRCodeMain for WordStatistics
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqliteConnection("" +
    new SqliteConnectionStringBuilder
    {
        DataSource = @"D:\dev_me\funfuncode\bin\book_xiabook_mz.db"
    })) using (var targetconn = new SqliteConnection("" +
        new SqliteConnectionStringBuilder
        {
            DataSource = @"D:\dev_me\funfuncode\dotnetcore\QRCodeMain\code.db"
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
                            insertCommand.CommandText = $"INSERT INTO WordStatisticses ( MaxOccur, MaxRatio, MaxWords, TotalBook, TotalOccur, TotalWords, WordUnicode )" +
                                $" VALUES ( {reader.GetInt32(1)}, {reader.GetDouble(2)}, {reader.GetInt32(3)}, {reader.GetInt32(4)}, {reader.GetInt32(5)}, {reader.GetInt32(6)}, '{reader.GetString(7)}'  )";
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
            }
        }
    }
}
