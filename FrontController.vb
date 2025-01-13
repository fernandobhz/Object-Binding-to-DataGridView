Public Class FrontController

    Shared Sub Main()
        Dim tela As New TelaPrincipal
        AddHandler tela.Button1.Click, AddressOf FrontController.CadClientes

        tela.ShowDialog()
    End Sub

    Shared Sub CadClientes()
        Dim x As New ClienteControle
        x.Abrir()
    End Sub

End Class

