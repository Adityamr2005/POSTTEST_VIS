Friend Class MySqlDataAdapter
    Private v As String
    Private conn As MySqlConnection

    Public Sub New(cmd As MySqlCommand)
        Me.Cmd = cmd
    End Sub

    Public Sub New(v As String, conn As MySqlConnection)
        Me.v = v
        Me.conn = conn
    End Sub

    Public ReadOnly Property Cmd As MySqlCommand

    Public Property V1 As String
        Get
            Return v
        End Get
        Set(value As String)
            v = value
        End Set
    End Property

    Friend Property Conn1 As MySqlConnection
        Get
            Return conn
        End Get
        Set(value As MySqlConnection)
            conn = value
        End Set
    End Property

    Friend Sub Fill(ds As DataSet, v As String)
        Throw New NotImplementedException()
    End Sub

    Friend Sub Fill(dt As DataTable)
        Throw New NotImplementedException()
    End Sub

    Public Shared Widening Operator CType(cmd As MySqlCommand) As MySqlDataAdapter
        Return New MySqlDataAdapter(cmd)
    End Operator
End Class
