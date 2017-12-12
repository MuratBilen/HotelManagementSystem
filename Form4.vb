Imports System.IO

Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fw As FileStream = New FileStream("D:\Rezervasyon\" & TextBox3.Text & ".txt", FileMode.Append, FileAccess.Write)
        Dim yazdır As StreamWriter = New StreamWriter(fw)
        yazdır.WriteLine(TextBox1.Text)
        yazdır.WriteLine(TextBox2.Text)
        yazdır.WriteLine(ComboBox1.Text)
        yazdır.WriteLine(TextBox3.Text)
        yazdır.WriteLine(ComboBox2.Text)
        yazdır.WriteLine(ComboBox3.Text)
        yazdır.WriteLine(TextBox4.Text)
        yazdır.WriteLine(TextBox5.Text)
        yazdır.Close()
        MsgBox("Rezervasyonunuz başarıyla tamamlandı. Otelimizi tercih ettiğiniz için teşekkürler.")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (ComboBox2.Text = "") Then
            ComboBox2.Text = 0
        End If
        If (ComboBox3.Text = "") Then
            ComboBox3.Text = 0
        End If
        TextBox5.Text = (ComboBox2.Text * 100) + (ComboBox3.Text * 25)
            TextBox5.Text = TextBox5.Text & "€"
    End Sub
End Class