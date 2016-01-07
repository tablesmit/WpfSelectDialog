# WpfSelectDialog
Dialogs for WPF.

## Open a select dialog for a key-value list

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
