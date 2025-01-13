Public Class ClienteControle

    Private f As New ClienteForm
    Dim l As New List(Of Cliente)

    Sub New()       

        l.Add(New Cliente("fernando", #4/5/1986#, "3191990751"))
        l.Add(New Cliente("joao", #12/31/1990#, String.Empty))
        l.Add(New Cliente("maria", #1/1/1900#, String.Empty))

        f.PreencherGrid(l)
    End Sub

    Sub Abrir()
        f.Show()
    End Sub

End Class
