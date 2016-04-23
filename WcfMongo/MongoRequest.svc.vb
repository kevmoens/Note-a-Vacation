' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization
Imports MongoDB.Driver
Imports WcfMongo
Imports System.Xml
Imports System.IO
Imports System.Runtime.Serialization.Json

Public Class MongoRequest
    Implements IRequest

    Public Sub New()
    End Sub

    Public Function InsertOne(Table As String, value As String) As String Implements IRequest.InsertOne
        Try
            Dim client As New MongoClient(gsNAVConnect)
            Dim db = client.GetDatabase(gsNVADatabase)
            Dim dbcollection = db.GetCollection(Of BsonDocument)(Table)
            Dim newrec = MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(value)
            dbcollection.InsertOne(newrec)
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ""
    End Function

    Public Function Query(Table As String, value As String) As String Implements IRequest.Query

        Dim client As New MongoClient(gsNAVConnect)
        Dim db = client.GetDatabase(gsNVADatabase)

        Dim dbcollection = db.GetCollection(Of BsonDocument)(Table)
        Dim dbquery As New BsonDocument
        dbquery = MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(value)

        Dim results = dbcollection.Find(dbquery).ToList
        Dim result As New BsonArray()
        For Each bdoc In results
            result.Add(MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(bdoc.ToJson.JsonClean))
        Next
        Dim resultDoc As New BsonDocument("elements", result)
        Return resultDoc.ToJson.JsonClean
    End Function

    Public Function Update(Table As String, Command As String, ByVal query As String, value As String) As String Implements IRequest.Update
        Try
            Dim client As New MongoClient(gsNAVConnect)
            Dim db = client.GetDatabase(gsNVADatabase)

            Dim dbcollection = db.GetCollection(Of BsonDocument)(Table)
            Dim dbquery As New BsonDocument
            dbquery = MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(query)
            Dim dbvalue As New BsonDocument
            dbvalue = MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(value)
            Dim dbupdate = New BsonDocument(Command, dbvalue)
            'Dim filter As New BsonDocument()
            Dim updateresult = dbcollection.UpdateOne(dbquery, dbupdate)
            Return updateresult.ToBsonDocument.ToJson.JsonClean
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Public Function QueryXML(Table As String, value As String) As String Implements IRequest.QueryXML

        Dim client As New MongoClient(gsNAVConnect)
        Dim db = client.GetDatabase(gsNVADatabase)

        Dim dbcollection = db.GetCollection(Of BsonDocument)(Table)
        Dim dbquery As New BsonDocument
        dbquery = MongoDB.Bson.Serialization.BsonSerializer.Deserialize(Of BsonDocument)(value)

        Dim results = dbcollection.Find(dbquery).ToList

        Dim result As New BsonDocument
        For Each orslt In results
            Dim bytes As Byte() = Encoding.ASCII.GetBytes(orslt.ToJson.JsonClean)
            Using stream = New MemoryStream(bytes)
                Dim quotas = New XmlDictionaryReaderQuotas()
                Dim jsonReader = JsonReaderWriterFactory.CreateJsonReader(stream, quotas)
                Dim xml = XDocument.Load(jsonReader)
                result.Add(New BsonElement("element", xml.ToString))
            End Using
        Next
        Dim doc As XmlDocument = DirectCast(Newtonsoft.Json.JsonConvert.DeserializeXmlNode(result.ToJson.JsonClean), XmlDocument)
        Using stringWriter = New StringWriter()
            Using xmlTextWriter = XmlWriter.Create(stringWriter)
                doc.WriteTo(xmlTextWriter)
                xmlTextWriter.Flush()
                Return stringWriter.GetStringBuilder().ToString()
            End Using
        End Using
    End Function
End Class