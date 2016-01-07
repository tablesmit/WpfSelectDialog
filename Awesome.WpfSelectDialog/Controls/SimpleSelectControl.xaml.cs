using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Awesome.WpfSelectDialog.Controls
{
    /// <summary>
    /// Interaction logic for SimpleSelectControl.xaml
    /// </summary>
    public partial class SimpleSelectControl
        //: ISelect<string>
        : ISelect<KeyValuePair<string, string>>
    {
        public event EventHandler<SelectionChangedEventArgs> SelectionChanged = (sender, e) => { };

        public SimpleSelectControl()
        {
            InitializeComponent();

            DataContext = this;
            SelectedItems = new List<KeyValuePair<string, string>>();
        }

        #region  dependency properties 

        public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
            "DataSource", typeof(IEnumerable<KeyValuePair<string, string>>), typeof(SimpleSelectControl), new PropertyMetadata(default(IEnumerable<KeyValuePair<string, string>>)));

        public IEnumerable<KeyValuePair<string, string>> DataSource
        {
            get { return (IEnumerable<KeyValuePair<string, string>>)GetValue(DataSourceProperty); }
            set { SetValue(DataSourceProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemsProperty = DependencyProperty.Register(
            "SelectedItems", typeof(IEnumerable<KeyValuePair<string, string>>), typeof(SimpleSelectControl), new PropertyMetadata(default(IEnumerable<KeyValuePair<string, string>>)));

        public IEnumerable<KeyValuePair<string, string>> SelectedItems
        {
            get { return (IEnumerable<KeyValuePair<string, string>>)GetValue(SelectedItemsProperty); }
            set { SetValue(SelectedItemsProperty, value); }
        }

        #endregion

        public bool AllowMultiple { get; set; }

        public bool CanDoOk => SelectedItems.Any();

        private void DataSource_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OnSelectionChanged(e);
        }

        protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        private void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.CloseParentWith(true);
        }
    }
}
