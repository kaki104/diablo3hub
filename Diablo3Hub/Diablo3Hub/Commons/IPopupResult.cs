using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Hub.Commons
{
    /// <summary>
    /// 팝업이 결과를 반환하는 경우 인터페이스
    /// </summary>
    interface IPopupResult
    {
        object Result { get; set; }
    }
}
