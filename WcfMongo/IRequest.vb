' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IRequest

    <OperationContract()>
    Function Query(ByVal Table As String, ByVal value As String) As String

    <OperationContract()>
    Function QueryXML(ByVal Table As String, ByVal value As String) As String

    <OperationContract()>
    Function InsertOne(ByVal Table As String, ByVal value As String) As String

    <OperationContract()>
    Function Update(ByVal Table As String, ByVal Command As String, ByVal query As String, ByVal value As String) As String


    '<OperationContract()>
    'Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Add your service operations here

End Interface

'' Use a data contract as illustrated in the sample below to add composite types to service operations.

'<DataContract()>
'Public Class CompositeType

'    <DataMember()>
'    Public Property BoolValue() As Boolean

'    <DataMember()>
'    Public Property StringValue() As String

'End Class
