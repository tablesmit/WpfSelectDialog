using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Awesome.WpfSelectDialog
{
    /// <summary>
    /// the implementation provides a view model to
    /// select a <see cref="T"/> from an IEnumerable of T/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISelect<T> : ISelect
    {
        IEnumerable<T> SelectedItems { get; }

        IEnumerable<T> DataSource { set; }
    }

    /// <summary>
    /// the implementation provides a view model to
    /// select a from an IEnumerable of T/>.
    /// The <see cref="CanDoOk"/> provides a validation if
    /// an item is select.
    /// This interface is a covariant extract of the full
    /// interface
    /// </summary>
    public interface ISelect
    {
        event EventHandler<SelectionChangedEventArgs> SelectionChanged;

        bool AllowMultiple { get; set; }

        bool CanDoOk { get; }
    }
}