Public Class Cliente

    Property nome As String
    Property dataNasc As Date

    Private _telefone As String
    Property telefone As String
        Get
            Return _telefone
        End Get
        Private Set(value As String)

            If value.Length > 10 Then
                'Não estou considerando os celulares de são paulo ainda, necessita implementação
                Throw New Exception("Telefone deve conter 10 digitos")
            End If

            _telefone = value
        End Set
    End Property


    ReadOnly Property idade As Int16
        Get
            Return DateDiff(DateInterval.Year, Me.dataNasc, Now)
        End Get
    End Property

    Sub New(nome As String, dataNasc As Date, telefone As String)
        Me.nome = nome
        Me.dataNasc = dataNasc
        Me.telefone = telefone
    End Sub

    Sub New(nome As String)

    End Sub

    Sub Salvar()
        MsgBox("Salvando: " & Me.nome)
    End Sub

    Protected Overrides Sub Finalize()
        MsgBox("Finalizing: " & Me.nome)
    End Sub

End Class
