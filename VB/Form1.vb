Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports RichEditCustomInsertMergeFieldMenu.Properties

Namespace RichEditCustomInsertMergeFieldMenu

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.Options.MailMerge.DataSource = GetMailMergeData()
        End Sub

        Private Function GetMailMergeData() As Object
            Dim connection As OleDbConnection = New OleDbConnection(Settings.Default.nwindConnectionString)
            Dim commandText As String = "SELECT Employees.*, Customers.* FROM (Employees INNER JOIN EmployeeCustomers ON Employees.EmployeeID = EmployeeCustomers.EmployeeId) INNER JOIN Customers ON EmployeeCustomers.CustomerId = Customers.CustomerID;"
            Dim selectCommand As OleDbCommand = New OleDbCommand(commandText, connection)
            Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommand)
            Dim dataSet As DataSet = New DataSet()
            dataAdapter.Fill(dataSet)
            Return dataSet.Tables(0)
        End Function
    End Class
End Namespace
