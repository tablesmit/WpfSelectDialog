using System.Windows;
using Awesome.WpfSelectDialog.Controls;

namespace Awesome.WpfSelectDialog
{
    public class FrameWindow : Window
    {
        public FrameWindow(UIElement control, IHaveNavigation navigation)
        {
            this.Content = new ContentFrame(control, navigation);
        }
    }
}