Public Class ClienteForm
    Private l As List(Of Cliente)

    Sub PreencherGrid(l As List(Of Cliente))
        Me.l = l

        For i = 0 To l.Count - 1
            Me.ClienteBindingSource.Add(l.Item(i))
        Next
    End Sub

    Private Sub DataGridView1_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MsgBox(e.Exception.Message)
    End Sub

    Private Sub ClienteForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For i = 0 To l.Count - 1
            l.Item(i).Salvar()
        Next
    End Sub

End Class