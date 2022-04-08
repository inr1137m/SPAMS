Imports System.Data.SqlClient
Public Class Form9
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsdbDataSet.spamstable' table. You can move, or remove it, as needed.
        Me.SpamstableTableAdapter.Fill(Me.MsdbDataSet.spamstable)
        con = New SqlConnection
        com = New SqlCommand
        con.ConnectionString = "Data Source=INR;Initial Catalog=msdb;Integrated Security=True"
        con.Open()
        com.Connection = con

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        da = New SqlDataAdapter("select * from spamstable", con)
        ds = New DataSet
        da.Fill(ds, "spamstable")
        DataGridView1.DataSource = ds.Tables("spamstable")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
        Close()
    End Sub
End Class