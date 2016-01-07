using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Awesome.WpfSelectDialog.Controls;
using FluentAssertions;
using NUnit.Framework;

namespace Awesome.WpfSelectDialog.Tests
{
    [TestFixture]
    [Explicit("because this open a UI elements")]
    // ReSharper disable PossibleInvalidOperationException
    // ReSharper disable InconsistentNaming
    class Open_Input_Dialogs
    {
        [Test]
        [Apartment(ApartmentState.STA)]
        public void TextInput()
        {
            var ctrl = new TextBox();

            var window = ConfirmationDialog.For(ctrl);
            window.Title = "PLEASE CLICK OK";

            var result = window.ShowDialog();

            result.Should().HaveValue();
            result.Value.Should().BeTrue();
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void BasicSelector()
        {
            var values = new Dictionary<string, string>()
            {
                {"One", "Selection One"},
                {"Two", "Selection Two"},
            };

            var ctrl = new SimpleSelectControl { DataSource = values };

            var window = ConfirmationDialog.For(ctrl);
            window.Title = "PLEASE CLICK OK";
            window.Width = 300;
            window.Height = 250;

            var result = window.ShowDialog();

            result.Should().HaveValue();
            result.Value.Should().BeTrue();

            MessageBox.Show(ctrl.SelectedItems.First().Key + " ==> " + ctrl.SelectedItems.First().Value);
        }
    }
}
