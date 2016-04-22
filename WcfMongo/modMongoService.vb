Module modMongoService
    Public gsMongoLabConnect As String = "mongodb://kevmoens:kevmoens@ds037095.mongolab.com:37095/kevmoens"
    Public gsMongoLabDatabase As String = "kevmoens"
    Public gsMongoLabCollection As String = "users"
    Public gsOpenShiftConect As String = "mongodb://admin:pMv9gZVvpYCD@127.0.0.1:27017"
    Public gsOpenShiftDatabase As String = "mongodb"
    <System.Runtime.CompilerServices.Extension()>
    Public Function JsonClean(json As String) As String

        Dim iStart As Integer = json.IndexOf("ObjectId(")
        If iStart > 0 Then
            Dim iend = json.IndexOf(")", iStart)
            If iend > 0 Then
                Return json.Substring(0, iStart) + json.Substring(iStart + 9, iend - iStart - 9) + json.Substring(iend + 1)
            End If
        End If
        Return json
    End Function
End Module
