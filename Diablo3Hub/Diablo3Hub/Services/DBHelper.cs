using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3Hub.Models;
using SQLite;

namespace Diablo3Hub.Services
{
    public class DBHelper
    {
        private static DBHelper _instance;
        private bool _initDb;

        /// <summary>
        /// 인스턴스
        /// </summary>
        public static DBHelper Instance
        {
            get { return _instance = _instance ?? new DBHelper(); }
        }
        /// <summary>
        /// DB 초기화
        /// </summary>
        /// <returns></returns>
        public async Task InitAsync()
        {
            var conn = new SQLiteAsyncConnection("diablo3hub");
            await conn.CreateTableAsync<BattleTag>();
            _initDb = true;
        }
        /// <summary>
        /// 배틀테그 테이블 반환
        /// </summary>
        /// <returns></returns>
        public AsyncTableQuery<BattleTag> BattleTagTable()
        {
            if (!_initDb)
            {
                Debug.WriteLine("Init first!");
                return null;
            }
            var conn = new SQLiteAsyncConnection("diablo3hub");
            return conn.Table<BattleTag>();
        }
    }
}
