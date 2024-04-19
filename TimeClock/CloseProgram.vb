'Title:         Close Program
'Date:          5-11-15
'Author;        Terry Holmes

'Description:   This will close the program

Public Class CloseProgram

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'Returns to application
        Me.Close()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        'Closes the program
        Form1.Close()

    End Sub
End Class