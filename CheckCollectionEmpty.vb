Public Class CheckCollectionEmpty
    Public Shared Function IsCollectionEmpty(ByVal table As DataTable) As Boolean
        Return table.Rows.Count = 0
    End Function
End Class
