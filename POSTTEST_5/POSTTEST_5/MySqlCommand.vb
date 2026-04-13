Friend Class MySqlCommand
    Friend ReadOnly Parameters As Object
    Private sql As String
    Private conn As MySqlConnection

    Public Sub New(sql As String, conn As MySqlConnection)
        Me.Sql1 = sql
        Me.Conn1 = conn
    End Sub

    Public Property Sql1 As String
        Get
            Return sql
        End Get
        Set(value As String)
            sql = value
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

    Friend Sub ExecuteNonQuery()
        Throw New NotImplementedException()
    End Sub

    Friend Function ExecuteScalar() As Boolean
        Throw New NotImplementedException()
    End Function
End Class

Friend Class MySqlConnection
    Private connectionString As String

    Public Sub New(connectionString As String)
        Me.connectionString = connectionString
    End Sub

    Public Property ConnectionString1 As String
        Get
            Return connectionString
        End Get
        Set(value As String)
            connectionString = value
        End Set
    End Property

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub

    Friend Sub Close()
        Throw New NotImplementedException()
    End Sub

    Friend Function State() As ConnectionState
        Throw New NotImplementedException()
    End Function

    Public Shared Widening Operator CType(v As MySqlConnection) As MySqlConnector.MySqlConnection
        Throw New NotImplementedException()
    End Operator
End Class
