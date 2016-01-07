using System.Threading;
using System.Windows.Controls;
using FluentAssertions;
using NEdifis.Attributes;
using NSubstitute;
using NUnit.Framework;

namespace Awesome.WpfSelectDialog.Controls
{
    [TestFixtureFor(typeof(ContentFrame))]
    // ReSharper disable once InconsistentNaming
    class ContentFrame_Should
    {
        [Test]
        [Apartment(ApartmentState.STA)]
        public void Be_Creatable()
        {
            var control = new ContentFrame();

            control.Should().BeAssignableTo<IHaveFrame>();
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void Assign_Controls()
        {
            var content = Substitute.For<Control>();
            var navigation = Substitute.For<IHaveNavigation, Control>();

            var control = new ContentFrame(content, navigation);

            control.Content.Content.Should().Be(content);
            control.Navigation.Content.Should().Be(navigation);
        }
    }
}