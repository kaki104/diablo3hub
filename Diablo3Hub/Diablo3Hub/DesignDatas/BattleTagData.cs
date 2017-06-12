using System.Collections.Generic;
using Diablo3Hub.Models;

namespace Diablo3Hub.DesignDatas
{
    internal class BattleTagData
    {
        public static IList<BattleTag> GetBattleTags()
        {
            return new List<BattleTag>
            {
                new BattleTag {Tag = "aaaaasdf#123"},
                new BattleTag {Tag = "aaaasdfa#123"},
                new BattleTag {Tag = "aaaasdfa#123"},
                new BattleTag {Tag = "aaasfdaa#123"},
                new BattleTag {Tag = "aaaasfa#123"}
            };
        }
    }
}