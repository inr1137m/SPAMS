Imports System.Data.SqlClient
Public Class Form7
    Dim path As String = (Microsoft.VisualBasic.Left(Application.StartupPath, Len(Application.StartupPath) - 9))
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection
        com = New SqlCommand
        con.ConnectionString = "Data Source=INR;Initial Catalog=msdb;Integrated Security=True"
        con.Open()
        com.Connection = con
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Or TextBox2.Text = " " Or TextBox3.Text = " " Or TextBox4.Text = " " Or TextBox5.Text = " " Or TextBox6.Text = " " Or TextBox7.Text = " " Or TextBox8.Text = " " Or TextBox9.Text = " " Or TextBox10.Text = " " Or TextBox11.Text = " " Or TextBox12.Text = " " Or TextBox13.Text = " " Or TextBox14.Text = " " Or TextBox15.Text = " " Or TextBox16.Text = " " Or TextBox17.Text = " " Or TextBox18.Text = " " Or TextBox19.Text = " " Or TextBox20.Text = " " Or TextBox21.Text = " " Then
            MsgBox("Please fill all the details")
        End If
        com.CommandText = "select regno from spamstable where regno='" + TextBox21.Text + "'"
        rd = com.ExecuteReader()
        If rd.Read() = TextBox21.Text Then
            rd.Close()
            com.CommandText = "update spamstable set regno='" + TextBox1.Text + "',name='" + TextBox2.Text + "',dept='" + TextBox3.Text + "',year='" + TextBox4.Text + "',sem='" + TextBox5.Text + "',cinch='" + TextBox6.Text + "',attendance='" + TextBox7.Text + "',marks='" + TextBox8.Text + "',activities='" + TextBox9.Text + "',achievements='" + TextBox10.Text + "',dob='" + TextBox11.Text + "',country='" + TextBox12.Text + "',religion='" + TextBox13.Text + "',community='" + TextBox14.Text + "',state='" + TextBox15.Text + "',city='" + TextBox16.Text + "',address='" + TextBox17.Text + "',pincode='" + TextBox18.Text + "',mobile='" + TextBox19.Text + "',email='" + TextBox20.Text + "' where regno='" + TextBox21.Text + "'"
            com.ExecuteNonQuery()
            MsgBox("THE STUDENT'S DATA YOU ENTERED WERE SUCCESSFULLY REGISTERED IN SPAMS")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
    End Sub
End Class