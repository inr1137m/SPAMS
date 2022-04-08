Imports System.Data.SqlClient
Public Class Form3
    Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As DataSet
        Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection
        com = New SqlCommand
        con.ConnectionString = "Data Source=INR;Initial Catalog=msdb;Integrated Security=True"
        con.Open()
        com.Connection = con
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Then
            MsgBox("Please enter the register number to search the student details !")
        End If
        com.CommandText = "select regno from spamstable where regno='" + TextBox1.Text + "'"
        rd = com.ExecuteReader()
        If rd.Read() = TextBox1.Text Then
            rd.Close()
            da = New SqlDataAdapter("select * from spamstable where regno='" + TextBox1.Text + "'", con)
            ds = New DataSet
            da.Fill(ds, "spamstable")
            Form5.DataGridView1.DataSource = ds.Tables("spamstable")
            Form5.Show()
            Close()
        Else
            MsgBox("THE ENTERED REGISTER NUMBER DOESN'T MATCH WITH ANY OF THE STUDENTS DETAILS IN THE DATABASE")
        End If
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Close()
    End Sub
End Class