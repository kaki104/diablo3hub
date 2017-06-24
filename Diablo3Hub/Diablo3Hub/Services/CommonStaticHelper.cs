using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Microsoft.Toolkit.Uwp.UI.Extensions;
using ApplicationView = Windows.UI.ViewManagement.ApplicationView;

namespace Diablo3Hub.Services
{
    public static class CommonStaticHelper
    {
        /// <summary>
        ///     공통 확인 창 출력 메서드 입니다.
        ///     상세 내용은 아래 페이지 참고
        ///     https://www.reflectionit.nl/blog/2015/windows-10-xaml-tips-messagedialog-and-contentdialog
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static async Task<object> ShowConfirmBoxAsync(string message, string title = null)
        {
            var dialog = title == null
                ? new MessageDialog(message)
                : new MessageDialog(message, title);
            dialog.Commands.Add(new UICommand("Yes") {Id = 1});
            dialog.Commands.Add(new UICommand("No") {Id = 0});

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 0;
            var result = await dialog.ShowAsync();
            return result.Id;
        }
        /// <summary>
        /// 간단한 메시지 박스 출력
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static async Task<object> ShowMessageBoxAsync(string message, string title = null)
        {
            var dialog = title == null
                ? new MessageDialog(message)
                : new MessageDialog(message, title);

            var result = await dialog.ShowAsync();
            return result.Id;
        }
        /// <summary>
        /// 윈도우 바운드 반환
        /// </summary>
        /// <returns></returns>
        public static Rect GetWindowBounds()
        {
            var view = ApplicationView.GetForCurrentView();
            return view.VisibleBounds;
        }

        public static async Task ShowPopupAsync(FrameworkElement content, string okText, string cancelText)
        {
            
        }
    }
}