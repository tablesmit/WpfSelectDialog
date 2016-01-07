using System.Threading;
using System.Windows.Controls;
using Awesome.WpfSelectDialog.Controls;
using FluentAssertions;
using NEdifis.Attributes;
using NUnit.Framework;

#pragma warning disable 618
namespace Awesome.WpfSelectDialog
{
    [TestFixtureFor(typeof(ConfirmationDialog))]
    // ReSharper disable once InconsistentNaming
    class ConfirmationDialog_Should
    {
        [Test]
        [RequiresSTA]
        [Apartment(ApartmentState.STA)]
        public void Have_Static_Method_To_Create_OK_Window()
        {
            var dummy = new UserControl();
            var dialog = ConfirmationDialog.For(dummy);

            dialog.Content.Should().BeOfType<ContentFrame>();

            var content = (ContentFrame) dialog.Content;
            content.ContentControl.Should().Be(dummy);
            content.NavigationControl.Should().BeOfType<OkNavigation>();
        }
    }
}