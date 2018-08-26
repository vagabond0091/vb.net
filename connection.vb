Imports MySql.Data.MySqlClient
Module connection
    Public conn As MySqlConnection = New MySqlConnection("Data Source = localhost;Database = normals;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public databaseAdapter1 As MySqlDataAdapter
    Public ds As DataSet
    Public db As Integer
    Public it As Integer
    Public count As Integer
    Public totalexp As Integer
    Public price As Decimal
    Public price1 As Decimal
    Public totalsss As Integer
   
End Module
