using System;
using System.Windows.Controls;

namespace Awesome.WpfSelectDialog.Controls
{
    public class EmptySelector : ISelect
    {
        public event EventHandler<SelectionChangedEventArgs> SelectionChanged;
        public bool AllowMultiple { get; set; } = false;
        public bool CanDoOk => true;

    }
}