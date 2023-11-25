using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
    public static class Constants
    {
        private const string DBFileName = "ProsperDaily.db3";

        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get => Path.Combine(FileSystem.AppDataDirectory, DBFileName);
        }
    }
}
