using Template10.Mvvm;

namespace Diablo3Hub.Commons
{
    /// <summary>
    ///     일반적인 데이터를 담아서 사용하기 위해 만들어진 모델입니다.
    ///     1. 각 데이터 타입별로 추가 프로퍼티를 만들 수 있습니다.
    ///     2. PropertyChanged 이벤트를 일으켜야 하면 형태를 변경 할 수 있습니다.
    /// </summary>
    public class CommonData : BindableBase
    {
        private string _description;
        private string _name;
        private bool _valueBool;
        private int _valueInt;
        private long _valueLong;
        private object _valueObject;
        private string _valueString;

        /// <summary>
        ///     아이디
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     이름
        /// </summary>
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        /// <summary>
        ///     설명
        /// </summary>
        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        /// <summary>
        ///     Int 값
        /// </summary>
        public int ValueInt
        {
            get => _valueInt;
            set => Set(ref _valueInt, value);
        }

        /// <summary>
        ///     long 값
        /// </summary>
        public long ValueLong
        {
            get => _valueLong;
            set => Set(ref _valueLong, value);
        }

        /// <summary>
        ///     string 값
        /// </summary>
        public string ValueString
        {
            get => _valueString;
            set => Set(ref _valueString, value);
        }

        /// <summary>
        ///     object 값
        /// </summary>
        public object ValueObject
        {
            get => _valueObject;
            set => Set(ref _valueObject, value);
        }

        /// <summary>
        ///     bool 값
        /// </summary>
        public bool ValueBool
        {
            get => _valueBool;
            set => Set(ref _valueBool, value);
        }
    }
}