Imports System.Net
Imports System.Data.SqlClient
Imports System.CodeDom

Module Module1
    Public Const dbname As String = "ShoppingMart"
    Public Const CustTbl As String = "Customers"
    Public Const ProdTbl As String = "Products"
    Public Const CatgTbl As String = "Categories"
    Public Const InvoiceTbl As String = "Invoice"
    Public Const IdCol As String = "Id"
    Public Const NameCol As String = "Name"
    Public Const PriceCol As String = "Price"
    Public Const ContactCol As String = "ContactNo"
    Public Const catgcol As String = "Category"
    Public Const AddressCol As String = "Address"
    Public Const EmailCol As String = "Email"
    Public Const descCol As String = "description"
    Public Const quantCol As String = "Quantity"
    Public Const prodcol As String = "Product Name"
    Public Const disccol As String = "DiscountOnProd"
    Public Const flatdisccol As String = "FlatDiscount"
    Public Const totalcol As String = "Total"
    Public Const paymentcol As String = "PaymentMode"
    Public Const cidcol As String = "Cust_ID"
    ''' <summary>
    ''' Procedure to write errorlog
    ''' </summary>
    ''' <param name="errorstring"></param>
    ''' <param name="procName"></param>
    Public Sub writeErrorLog(ByVal errorstring As String, ByVal procName As String)
        Try
            System.IO.File.AppendAllText(My.Application.Info.DirectoryPath & "\Errors\Errorlog.txt", Err.Description & vbCrLf)
        Catch ex As Exception
            MsgBox(Err.Description & "Error from " & procName & " " & errorstring)
        End Try
    End Sub
    ''' <summary>
    ''' Proceudre to get connection object
    ''' </summary>
    ''' <param name="databaseName"></param>
    ''' <param name="connection"></param>
    Public Sub open_connection(databaseName As String, ByRef connection As SqlConnection)
        Try
            Dim serverName As String = "ABHISHEK\SQLEXPRESS"  ' Replace with your SQL server name
            Dim connectionString As String = "Server=" & serverName & ";Database=" & databaseName & ";Trusted_Connection=True;"
            connection = New SqlConnection(connectionString)
        Catch ex As Exception
            writeErrorLog(Err.Description, "open_connection")
        End Try

    End Sub
    ''' <summary>
    ''' Procedure to load data from database
    ''' </summary>
    ''' <param name="Query"></param>
    ''' <param name="tblname"></param>
    Public Sub LoadDataFromDB(ByVal Query As String, ByVal tblname As String)
        Dim connection As SqlConnection = Nothing
        Try
            open_connection(dbname, connection)
            connection.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(Query, connection)
            Dim dataAdapter As New SqlDataAdapter(sqlCommand)
            If ShoppingMart.dt_Data.Tables.Contains(tblname) = True Then
                ShoppingMart.dt_Data.Tables(tblname).Clear()
            End If

            dataAdapter.Fill(ShoppingMart.dt_Data, tblname)
        Catch ex As Exception
            writeErrorLog(Err.Description, "LoadDataFromDB")
        Finally
            connection.Close()
        End Try

    End Sub
    ''' <summary>
    ''' Procedure to update database - insert/update/delete
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="retval"></param>
    Public Sub updatedatabase(ByVal query As String, Optional ByRef retval As Integer = 0)
        Dim connection As SqlConnection = Nothing
        Try
            open_connection(dbname, connection)
            connection.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(query, connection)
            If retval = 1 Then
                retval = CInt(sqlCommand.ExecuteScalar())
            Else
                sqlCommand.ExecuteNonQuery()
            End If

        Catch ex As Exception
            writeErrorLog(Err.Description, "LoadDataFromDB")
        Finally
            connection.Close()
        End Try
    End Sub

End Module
