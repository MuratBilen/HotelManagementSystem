Public Class Form3
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else

            Form4.Show()
            Button6.BackColor = Color.Red
            Me.Close()
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else

            Form4.Show()
            Button1.BackColor = Color.Green
            Me.Close()

        End If






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else

            Form4.Show()
            Button2.BackColor = Color.Red
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else

            Form4.Show()
            Button3.BackColor = Color.Red
            Me.Close()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else
            Button4.BackColor = Color.Red
            Form4.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else
            Button5.BackColor = Color.Red
            Form4.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else
            Button7.BackColor = Color.Red
            Form4.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else
            Button8.BackColor = Color.Red
            Form4.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.BackColor = Color.Red Then
            MsgBox("Bu odayı seçemezsiniz.Lütfen yeşille gösterilmiş olan müsait odalardan birini seçiniz!")
        Else
            Button9.BackColor = Color.Red
            Form4.Show()
            Me.Close()
        End If


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.MinDate = DateTime.Now.Date
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker2.MinDate = DateTime.Now.Date
    End Sub
End Class