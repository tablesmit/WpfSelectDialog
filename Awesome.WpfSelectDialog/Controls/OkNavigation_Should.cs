using System.Threading;
using System.Windows.Controls;
using FluentAssertions;
using NEdifis.Attributes;
using NUnit.Framework;

namespace Awesome.WpfSelectDialog.Controls
{
    [TestFixtureFor(typeof (OkNavigation))]
    // ReSharper disable once InconsistentNaming
    class OkNavigation_Should
    {
        [Test]
        [Apartment(ApartmentState.STA)]
        public void Be_Creatable()
        {
            var control = new OkNavigation();

            control.Should().BeAssignableTo<IHaveNavigation>();
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void Have_OkButton()
        {
            var control = new OkNavigation();

            control.Ok.Should().BeAssignableTo<Button>();
            control.Ok.Content.Should().Be("OK");
        }
    }
}