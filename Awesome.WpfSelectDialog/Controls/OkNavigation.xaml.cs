using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using NEdifis.Attributes;
using NUnit.Framework;

namespace Awesome.WpfSelectDialog.Controls
{
    public partial class OkNavigation : IHaveNavigation
    {
        private readonly ISelect _selector;

        public OkNavigation() : this(null)
        {
        }

        public OkNavigation(ISelect selector)
        {
            InitializeComponent();

            _selector = selector ?? new EmptySelector();
            _selector.SelectionChanged += SelectorOnSelectionChanged;

            Ok.IsEnabled = _selector.CanDoOk;
        }

        private void SelectorOnSelectionChanged(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            Ok.IsEnabled = _selector.CanDoOk;
        }

        private void Ok_OnClick(object sender, RoutedEventArgs e)
        {
            this.CloseParentWith(true);
        }
    }

    //[TestFixtureFor(typeof(UiElementExtensions))]
    //// ReSharper disable once InconsistentNaming
    //class UiElementExtensions_Should
    //{
    //    [Test]
    //    [Apartment(ApartmentState.STA)]
    //    public void Set_Parent_DialogResult()
    //    {
    //        // arrange
    //        var control = new Control();
    //        var window = new Window { Content = control };

    //        var task = new Task(o => window.ShowDialog(), null);
    //        task.ContinueWith(task1 =>
    //            {
    //                window.DialogResult.Should().BeTrue();
    //                window.IsActive.Should().BeFalse();
    //            });
    //        task.Start();


    //        // act
    //        control.CloseParentWith(true);

    //        // assert
    //        task.Wait();
    //    }
    //}
}
