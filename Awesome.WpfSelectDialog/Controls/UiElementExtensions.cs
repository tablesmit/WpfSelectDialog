using System;
using System.Windows;

namespace Awesome.WpfSelectDialog.Controls
{
    public static class UiElementExtensions
    {
        public static void CloseParentWith(this UIElement source, bool dialogResult)
        {
            var parent = Window.GetWindow(source);
            if (parent == null) throw new ArgumentException($"Cannot get parent window for control '{source.GetType().Name}'. Window.GetWindow(this) returned null.");

            parent.DialogResult = true;
            parent.Close();
        }
    }
}