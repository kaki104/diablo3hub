using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3Hub.Models;
using SQLite;
using System.Collections;

namespace Diablo3Hub.Services
{
    public class DBHelper
    {
        private const string DB_NAME = "diablo3hub";
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
            var conn = new SQLiteAsyncConnection(DB_NAME);
            //배틀테그 테이블
            await conn.CreateTableAsync<BattleTag>();
            //즐겨찾기 히어로 테이블
            await conn.CreateTableAsync<FavoriteHero>();
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
            var conn = new SQLiteAsyncConnection(DB_NAME);
            return conn.Table<BattleTag>();
        }

        public AsyncTableQuery<FavoriteHero> FavoriteHeroTable()
        {
            if (!_initDb)
            {
                Debug.WriteLine("Init first!");
                return null;
            }
            var conn = new SQLiteAsyncConnection(DB_NAME);
            return conn.Table<FavoriteHero>();
        }
        /// <summary>
        /// 아이템 추가
        /// </summary>
        /// <param name="addItem"></param>
        /// <returns></returns>
        public async Task<int> InsertAsync(object addItem)
        {
            var conn = new SQLiteAsyncConnection(DB_NAME);
            var result = await conn.InsertAsync(addItem);
            return result;
        }
        /// <summary>
        /// 아이템 업데이트
        /// </summary>
        /// <param name="updateItem"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(object updateItem)
        {
            var conn = new SQLiteAsyncConnection(DB_NAME);
            var result = await conn.UpdateAsync(updateItem);
            return result;
        }
        /// <summary>
        /// 아이템 삭제
        /// </summary>
        /// <param name="deleteItem"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(object deleteItem)
        {
            var conn = new SQLiteAsyncConnection(DB_NAME);
            var result = await conn.DeleteAsync(deleteItem);
            return result;
        }

        /// <summary>
        /// Battle Tag 아이템 여러개 삭제
        /// </summary>
        public async Task<int> DeleteTagItemsAsync(IList<BattleTag> items)
        {
            if (items == null || items.Any() == false) return 0;
            var tagIds = items.Select(e => e.Id.ToString()).ToList();
            var paramStr = string.Join(",", tagIds);

            var conn = new SQLiteAsyncConnection(DB_NAME);
            var quryStr = string.Format("DELETE FROM BATTLETAG WHERE ID IN ({0})", paramStr);
            var result = await conn.ExecuteAsync(quryStr);
            return result;
        }

    }
}
