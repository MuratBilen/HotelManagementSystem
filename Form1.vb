Imports System.IO

Public Class Form1

    Dim şifre As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim şifre As String

        şifre = My.Computer.FileSystem.ReadAllText("D:\Personel\" & TextBox1.Text & ".txt")



            If şifre = TextBox2.Text Then
                Form2.Show()
            Me.Hide()

        Else
                MsgBox(" Hatalı kullanıcı adı veya şifre girişi yaptınız. Lütfen kontrol edip tekrar deneyiniz. ")


            End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
