Imports System.Data.SqlClient

Module Connection
    Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MyInstance;Initial Catalog=Sales_Person;Integrated Security=True")

End Module
