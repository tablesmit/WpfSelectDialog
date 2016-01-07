using System.Threading;
using System.Windows.Controls;
using Awesome.WpfSelectDialog.Controls;
using FluentAssertions;
using NEdifis.Attributes;
using NSubstitute;
using NUnit.Framework;

namespace Awesome.WpfSelectDialog
{
    [TestFixtureFor(typeof(FrameWindow))]
    // ReSharper disable once InconsistentNaming
    class FrameWindow_Should
    {
        [Test]
        [Apartment(ApartmentState.STA)]
        public void Be_Creatable()
        {
            var content = Substitute.For<Control>();
            var navigation = Substitute.For<IHaveNavigation, Control>();

            var window = new FrameWindow(content, navigation);
            window.Content.Should().BeAssignableTo<ContentFrame>();

            var frame = (ContentFrame)window.Content;
            frame.Content.Content.Should().Be(content);
            frame.Navigation.Content.Should().Be(navigation);
        }
    }
}