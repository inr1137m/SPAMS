Imports System.Data.SqlClient
Public Class Form8
    Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))
    Dim con As SqlConnection
    Dim com As SqlCommand
   
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection
        com = New SqlCommand
        con.ConnectionString = "Data Source=INR;Initial Catalog=msdb;Integrated Security=True"
        con.Open()
        com.Connection = con
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Then
            MsgBox("Please enter the Register number to delete !")
        End If
        com.CommandText = "delete from spamstable where regno='" + TextBox1.Text + "'"
        com.ExecuteNonQuery()
        MsgBox("Data's deleted successfully !")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
        Close()
    End Sub
End Class