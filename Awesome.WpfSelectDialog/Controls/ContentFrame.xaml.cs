using System.Windows;

namespace Awesome.WpfSelectDialog.Controls
{
    public partial class ContentFrame : IHaveFrame
    {
        public ContentFrame() : this(null, null) { }

        public ContentFrame(UIElement content, IHaveNavigation navigation)
        {
            InitializeComponent();

            this.Content.Content = content;
            this.Navigation.Content = navigation;
        }

        public UIElement ContentControl
        {
            get { return (UIElement) this.Content.Content; }
        }

        public IHaveNavigation NavigationControl
        {
            get { return (IHaveNavigation) this.Navigation.Content; }
        }
    }
}
