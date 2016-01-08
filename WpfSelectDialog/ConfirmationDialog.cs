using System.Windows;
using Awesome.WpfSelectDialog.Controls;

namespace Awesome.WpfSelectDialog
{
    public class ConfirmationDialog
    {
        /// <summary>
        ///  returns a basic content frame with an ok button
        /// </summary>
        /// <param name="userControl"></param>
        /// <returns></returns>
        internal static FrameWindow OkFrame(UIElement userControl)
        {
            return new FrameWindow(userControl, OkNavigation(userControl as ISelect));
        }

        internal static IHaveNavigation OkNavigation(ISelect selector)
        {
            return new OkNavigation(selector);
        }

        public static FrameWindow For(UIElement userControl)
        {
            return OkFrame(userControl);
        }
    }
}