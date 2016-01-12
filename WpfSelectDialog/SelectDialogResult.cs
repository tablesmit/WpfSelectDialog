using System.Collections.Generic;

namespace Awesome.WpfSelectDialog
{
    public class SelectDialogResult<T>
    {
        public SelectDialogResult(bool? dialogResult, IEnumerable<T> selectedItems)
        {
            DialogResult = dialogResult;
            SelectedItems = selectedItems;
        }

        public bool? DialogResult { get; private set; }
        public IEnumerable<T> SelectedItems { get; private set; }
    }
}