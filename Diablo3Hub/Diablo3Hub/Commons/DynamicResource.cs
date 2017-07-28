using System.Dynamic;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Resources;
using Template10.Common;

namespace Diablo3Hub.Commons
{
    public class DynamicResource : DynamicObject
    {
        private static dynamic _instance;

        /// <summary>
        /// The resource manager
        /// </summary>
        private ResourceLoader _resourceLoader;

        /// <summary>
        /// Instance
        /// </summary>
        public static dynamic Instance
        {
            get
            {
                if (DesignMode.DesignModeEnabled)
                    _instance = new DynamicResource();
                else
                    _instance = BootStrapper.Current.Resources["DRes"] as DynamicResource;
                return _instance;
            }
        }

        /// <summary>
        /// Using XAML
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public string this[string identity]
        {
            get
            {
                string str;
                if (DesignMode.DesignModeEnabled == false)
                {
                    if (_resourceLoader == null)
                        _resourceLoader = new ResourceLoader();
                    str = _resourceLoader.GetString(identity);
                    if (string.IsNullOrEmpty(str))
                        str = string.Empty;
                }
                else
                {
                    //디자인 타임에서는 키값을 반환
                    str = identity;
                }
                return str;
            }
        }

        /// <summary>
        ///     Using instance
        /// </summary>
        /// <returns></returns>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string str;
            if (DesignMode.DesignModeEnabled == false)
            {
                if (_resourceLoader == null)
                    _resourceLoader = new ResourceLoader();
                str = _resourceLoader.GetString(binder.Name);
                if (string.IsNullOrEmpty(str))
                    str = string.Empty;
            }
            else
            {
                str = binder.Name;
            }
            result = str;
            return true;
        }
    }
}
