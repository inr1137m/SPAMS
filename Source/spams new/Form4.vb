Imports System.Data.SqlClient
Public Class Form4
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection
        com = New SqlCommand
        con.ConnectionString = "Data Source=INR;Initial Catalog=msdb;Integrated Security=True"
        con.Open()
        com.Connection = con
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Show()
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form7.Show()
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form8.Show()
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        da = New SqlDataAdapter("select * from spamstable", con)
        ds = New DataSet
        da.Fill(ds, "spamstable")
        Form9.DataGridView1.DataSource = ds.Tables("spamstable")
        Form9.Show()
        Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form10.Show()
        Close()
    End Sub
End Class