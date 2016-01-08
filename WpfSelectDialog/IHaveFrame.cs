using System.Windows;

namespace Awesome.WpfSelectDialog
{
    public interface IHaveFrame
    {
        UIElement ContentControl { get; }
        IHaveNavigation NavigationControl { get; }
    }
}