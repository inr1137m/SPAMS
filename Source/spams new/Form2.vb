Imports System.Data.SqlClient
Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Or TextBox2.Text = " " Then
            MsgBox("please fill the username box and password box with corresponding values")
        End If
        If TextBox1.Text = "iyyanar" Or TextBox2.Text = "cseinr" Then
            MsgBox("Login Successfull")
            Form4.Show()
            Close()
        ElseIf TextBox1.Text = "inrinr" Or TextBox2.Text = "inrcse" Then
            MsgBox("Login Successfull")
            Form4.Show()
            Close()
        ElseIf TextBox1.Text = "iyyanarinr" Or TextBox2.Text = "inrinr" Then
            MsgBox("Login Successfull")
            Form4.Show()
            Close()
        ElseIf TextBox1.Text = "inriyyanar" Or TextBox2.Text = "inrinr" Then
            MsgBox("Login Successfull")
            Form4.Show()
            Close()
        ElseIf TextBox1.Text = "cseinr" Or TextBox2.Text = "cseinr" Then
            MsgBox("Login Successfull")
            Form4.Show()
            Close()
        Else
            MsgBox("Please check the username and password")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Close()
    End Sub

End Class