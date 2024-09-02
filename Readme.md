<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609910/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4177)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to customize the "Insert Merge Field" menu

This example illustrates how to customize the [Insert Merge Field](https://docs.devexpress.com/WindowsForms/9589/controls-and-libraries/rich-text-editor/visual-elements/dialogs/insert-merge-field-dialog) menu to group merge field names with identical prefixes (**Employees** and **Customers** in this example) into submenus.

![image](./media/4c2ca3c3-807f-41d3-8934-88fe103f4b80.png)

## Implementation Details

The `DataBindingController` class generates menu items/subitems from the mail merge data source on the fly. These items are added to a [popup menu](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.PopupMenu).

When a custom menu item is clicked, the `CustomInsertMergeFieldMenuItem.OnClick` method is executed to insert the current merge field.

When you click the **Insert Merge Field** Ribbon item, the built-in **Insert Merge Field** form is shown.

Note that the custom **Insert Merge Field** Ribbon item uses resources (images) from the project's **Images** folder to initialize the `BarButtomItem.LargeGlyph` and `BarButtonItem.Glyph` properties. Customize the `LargeGlyph` and `Glyph` properties of the `CustomInsertMergeFieldItem` class to use another source for images.

## Files to Review

<!-- default file list -->
* [CustomInsertMergeFieldItem.cs](./CS/CustomInsertMergeFieldItem.cs) (VB: [CustomInsertMergeFieldItem.vb](./VB/CustomInsertMergeFieldItem.vb))
* [DataBindingController.cs](./CS/DataBindingController.cs) (VB: [DataBindingController.vb](./VB/DataBindingController.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

## Documentation

* [How to: Customize the Hyperlink Form](https://docs.devexpress.com/WindowsForms/9683/controls-and-libraries/rich-text-editor/examples/ui-customization/how-to-customize-the-hyperlink-form)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-customize-insert-merge-field-menu&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-customize-insert-merge-field-menu&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
