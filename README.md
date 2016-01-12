[![Build status](https://ci.appveyor.com/api/projects/status/o3gkdu3e4tfbaivw?svg=true)](https://ci.appveyor.com/project/awesome-inc-build/wpfselectdialog)
[![NuGet](https://img.shields.io/nuget/v/WpfSelectDialog.svg?style=flat-square)](https://www.nuget.org/packages/WpfSelectDialog/) 
[![Nuget](https://img.shields.io/nuget/vpre/WpfSelectDialog.svg)](https://www.nuget.org/packages/WpfSelectDialog/)
[![NuGet](https://img.shields.io/nuget/dt/WpfSelectDialog.svg?style=flat-square)](https://www.nuget.org/packages/WpfSelectDialog/) 
[![Issue Stats](http://issuestats.com/github/awesome-inc/wpfselectdialog/badge/pr)](http://issuestats.com/github/awesome-inc/wpfselectdialog)
[![Coverage Status](https://coveralls.io/repos/awesome-inc/WpfSelectDialog/badge.svg?branch=develop&service=github)](https://coveralls.io/github/awesome-inc/WpfSelectDialog?branch=develop)

# WpfSelectDialog
Select dialogs for WPF.

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
