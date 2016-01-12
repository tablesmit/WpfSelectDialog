using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Awesome.WpfSelectDialog.Controls;

namespace Awesome.WpfSelectDialog
{
    public static class WindowExtensions
    {
        public static SelectDialogResult<T> ShowDialog<T>(this Func<Window> windowFactory)
        {
            var result = new SelectDialogResult<T>(null, null);

            var newWindowThread = new Thread(() =>
            {
                var window = windowFactory();
                window.Closed += (s, e) => Dispatcher.CurrentDispatcher.BeginInvokeShutdown(DispatcherPriority.Background);
                var dlgResult = window.ShowDialog();
                result = new SelectDialogResult<T>(dlgResult, null);

                Dispatcher.Run();

                var typedWindow = window as FrameWindow;
                var content = typedWindow?.Content as ContentFrame;
                var ctrl = content?.ContentControl as ISelect<T>;
                if (ctrl == null) return;
   
                result = new SelectDialogResult<T>(dlgResult, ctrl.SelectedItems);
            });

            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.Start();
            newWindowThread.Join();

            return result;
        }
    }
}
