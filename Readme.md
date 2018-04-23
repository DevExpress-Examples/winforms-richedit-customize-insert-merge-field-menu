# How to customize the "Insert Merge Field" menu


<p>This example illustrates how to customize the "Insert Merge Field" menu to group merge field names with identical prefixes (Employees and Customers in this example) into submenus. Note that we completely replace built-in InsertMergeFieldItem with a custom one. You can find its implementation in the CustomInsertMergeFieldItem.cs (CustomInsertMergeFieldItem.vb for VB.NET) code file. We are creating a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsPopupMenutopic"><u>PopupMenu Class</u></a> instance and populating it with menu items/subitems on the fly. The field names of the datasource are obtained with help of a special <strong>DataBindingController </strong>class.</p><p>Finally, the actual merge field insertion is accomplished in the <strong>CustomInsertMergeFieldMenuItem</strong><strong>'s</strong><strong> </strong><strong>OnClick</strong> method. Take a moment to look at the <a href="https://www.devexpress.com/Support/Center/p/Q327983">Create DOCVARIABLE in code</a> and <a href="https://www.devexpress.com/Support/Center/p/E4004">How to create nested fields programmatically</a> code example to learn more on this subject.</p><p>Take note of a <strong>CustomInsertMergeFieldItem</strong><strong>'s</strong> <strong>OnClick </strong>method. It delegates handling to the regular <a href="http://documentation.devexpress.com/#Silverlight/clsDevExpressXtraRichEditCommandsShowInsertMergeFieldFormCommandtopic"><u>ShowInsertMergeFieldFormCommand</u></a>. You can implement and display your own dialog here if necessary.</p><p>Here is a screenshot that illustrates a sample application in action:</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-insert-merge-field-menu-e4177/11.1.12+/media/4c2ca3c3-807f-41d3-8934-88fe103f4b80.png"></p>

<br/>


