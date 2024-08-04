Imports System.Net
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.AccessControl
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles

Public Class ShoppingMart
    Public Shared dt_Data As New DataSet
    Public Shared ProductName As String
    Public Shared InQuantity As Integer
    Public Shared DiscountonProd As Integer
    Public Shared FlatDiscOnProd As Integer
    Public Shared Total As Integer
    Public Shared PaymentMode As String
    Public Shared Cust_Id As Integer
    Private Shared inserted_id As String = ""
    Public Shared price As Integer

    Public Sub New()
        Try
            add_Invoicecolumns_to_DT()
        Catch ex As Exception
            writeErrorLog(Err.Description, "Constructor -- ShoppingMart")
        End Try

    End Sub
    ''' <summary>
    ''' Loading columns to dataset
    ''' </summary>
    Public Sub add_Invoicecolumns_to_DT()

        Try
            If dt_Data.Tables.Contains(InvoiceTbl) = False Then
                dt_Data.Tables.Add(InvoiceTbl)
                dt_Data.Tables(InvoiceTbl).Columns.Add(prodcol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(quantCol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(disccol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(flatdisccol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(totalcol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(paymentcol, GetType(String))
                dt_Data.Tables(InvoiceTbl).Columns.Add(cidcol, GetType(String))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "add_Invoicecolumns_to_DT -- ShoppingMart")
        End Try
    End Sub
    ''' <summary>
    ''' Adding to db and dataset
    ''' </summary>
    Public Sub Add()
        Try
            Dim retval As Integer = 1
            Dim sqlcommand As String = "INSERT INTO [" & InvoiceTbl & "]
           ([" & prodcol & "]
           ,[" & quantCol & "]
           ,[" & disccol & "]
           ,[" & flatdisccol & "]
           ,[" & totalcol & "]
           ,[" & cidcol & "]
           ,[" & paymentcol & "],[" & PriceCol & "]) values ('" & ProductName & "','" & InQuantity & "','" & DiscountonProd & "','" & FlatDiscOnProd & "','" & Total & "','" & Cust_Id & "','" & PaymentMode & "','" & price & "'); SELECT SCOPE_IDENTITY()"
            updatedatabase(sqlcommand, retval)
            If inserted_id = "" Then
                inserted_id = retval
            Else
                inserted_id = inserted_id & "," & retval
            End If

            LoadDataFromDB("Select * from " & InvoiceTbl & " where " & IdCol & " in (" & inserted_id & ")", InvoiceTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "add -- Invoice")
        End Try
    End Sub

    'Public Sub delete()
    'End Sub
    'Public Sub update()
    'End Sub
    ''' <summary>
    ''' Displaying data to grid from dataset
    ''' </summary>
    ''' <param name="tablename"></param>
    ''' <param name="dgv_data"></param>
    Public Sub display(ByVal tablename As String, ByRef dgv_data As DataGridView)
        Try
            dgv_data.DataSource = dt_Data.Tables(tablename)
        Catch ex As Exception
            writeErrorLog(Err.Description, "Display -- Customers")
        End Try
    End Sub
End Class
Public Class Customers
    Inherits ShoppingMart
    Public Shared name As String
    Public Shared email As String
    Public Shared address As String
    Public Shared contactNo As String
    Public Shared id As Integer
    Public Sub New()
        Try
            add_Custcolumns_to_DT()
        Catch ex As Exception
            writeErrorLog(Err.Description, "Constructor -- Customers")
        End Try

    End Sub
    ''' <summary>
    ''' Adding columns to dataset
    ''' </summary>
    Public Sub add_Custcolumns_to_DT()
        Try
            If dt_Data.Tables.Contains(CustTbl) = False Then
                dt_Data.Tables.Add(CustTbl)
                dt_Data.Tables(CustTbl).Columns.Add(NameCol, GetType(String))
                dt_Data.Tables(CustTbl).Columns.Add(EmailCol, GetType(String))
                dt_Data.Tables(CustTbl).Columns.Add(AddressCol, GetType(String))
                dt_Data.Tables(CustTbl).Columns.Add(ContactCol, GetType(String))
            Else
                Exit Sub
            End If

        Catch ex As Exception
            writeErrorLog(Err.Description, "add_columns_to_DT -- Customers")
        End Try
    End Sub
    ''' <summary>
    ''' adding to db and dataset
    ''' </summary>
    Public Overloads Sub Add()
        Try
            Dim sqlcommand As String = "insert into " & CustTbl & "([" & NameCol & "],[" & ContactCol & "],[" & AddressCol & "],[" & EmailCol & "]) values ('" & name & "','" & contactNo & "','" & address & "','" & email & "')"
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & CustTbl & "]", CustTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "Add -- Customers")
        End Try
    End Sub
    ''' <summary>
    ''' deleting from database
    ''' </summary>
    Public Overloads Sub delete()
        Try
            updatedatabase("delete from " & CustTbl & " where " & IdCol & " = " & id)
            LoadDataFromDB("Select * from [" & CustTbl & "]", CustTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "update -- Customers")
        End Try
    End Sub
    ''' <summary>
    ''' Updating to database
    ''' </summary>
    Public Overloads Sub update()
        Try
            Dim sqlcommand As String = "update " & CustTbl & " set " & EmailCol & " = '" & email & "', " & AddressCol & " = '" & address & "' where " & IdCol & " = " & id
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & CustTbl & "]", CustTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "update -- Customers")

        End Try
    End Sub
End Class
Public Class Products
    Inherits ShoppingMart
    Public Shared name As String
    Public Shared description As String
    Public Shared Price As String
    Public Shared Quantity As String
    Public Shared category As String
    Public Shared id As Integer
    Public Sub New()
        Try
            add_Prodcolumns_to_DT()
        Catch ex As Exception
            writeErrorLog(Err.Description, "Constructor -- Products")
        End Try

    End Sub
    ''' <summary>
    ''' Adding columns to dataset
    ''' </summary>
    Public Sub add_Prodcolumns_to_DT()
        Try
            If dt_Data.Tables.Contains(ProdTbl) = False Then
                dt_Data.Tables.Add(ProdTbl)
                dt_Data.Tables(ProdTbl).Columns.Add(NameCol, GetType(String))
                dt_Data.Tables(ProdTbl).Columns.Add(descCol, GetType(String))
                dt_Data.Tables(ProdTbl).Columns.Add(PriceCol, GetType(String))
                dt_Data.Tables(ProdTbl).Columns.Add(quantCol, GetType(String))
                dt_Data.Tables(ProdTbl).Columns.Add(catgcol, GetType(String))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "add_columns_to_DT -- Products")
        End Try
    End Sub
    ''' <summary>
    ''' Adding to database and dataset
    ''' </summary>
    Public Overloads Sub add()
        Try
            Dim sqlcommand As String = "insert into " & ProdTbl & "([" & NameCol & "],[" & descCol & "],[" & quantCol & "],[" & PriceCol & "],[" & catgcol & "]) values ('" & name & "','" & description & "','" & Quantity & "','" & Price & "','" & category & "')"
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & ProdTbl & "]", ProdTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "add -- products")
        End Try
    End Sub
    ''' <summary>
    ''' Updating to database
    ''' </summary>
    Public Overloads Sub update()
        Try
            Dim sqlcommand As String = "update " & ProdTbl & " set " & descCol & " = '" & description & "', " & quantCol & " = '" & Quantity & "', " & PriceCol & " = '" & Price & "' where " & IdCol & " = " & id
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & ProdTbl & "]", ProdTbl)

        Catch ex As Exception
            writeErrorLog(Err.Description, "update -- Products")

        End Try
    End Sub
    ''' <summary>
    ''' deleting from database
    ''' </summary>
    Public Overloads Sub delete()
        Try
            updatedatabase("delete from " & ProdTbl & " where " & IdCol & " = " & id)
            LoadDataFromDB("Select * from [" & ProdTbl & "]", ProdTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "delete -- products")
        End Try
    End Sub
End Class
Public Class categories
    Inherits ShoppingMart
    Public Shared name As String
    Public Shared description As String
    Public Shared id As Integer
    Public Sub New()
        Try
            add_Catcolumns_to_DT()
        Catch ex As Exception
            writeErrorLog(Err.Description, "Constructor -- Products")
        End Try
    End Sub
    ''' <summary>
    ''' adding columns to dataset
    ''' </summary>
    Public Sub add_Catcolumns_to_DT()
        Try
            If dt_Data.Tables.Contains(CatgTbl) = False Then
                dt_Data.Tables.Add(CatgTbl)
                dt_Data.Tables(CatgTbl).Columns.Add(NameCol, GetType(String))
                dt_Data.Tables(CatgTbl).Columns.Add(descCol, GetType(String))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "add_columns_to_DT -- Products")
        End Try
    End Sub
    ''' <summary>
    ''' adding to database and dataset
    ''' </summary>
    Public Overloads Sub add()
        Try
            Dim sqlcommand As String = "insert into " & CatgTbl & "([" & NameCol & "],[" & descCol & "]) values ('" & name & "','" & description & "')"
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & CatgTbl & "]", CatgTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "add -- Categories")
        End Try
    End Sub
    ''' <summary>
    ''' updating to database
    ''' </summary>
    Public Overloads Sub update()
        Try
            Dim sqlcommand As String = "update " & CatgTbl & " set " & descCol & " = '" & description & "' where " & IdCol & " = " & id
            updatedatabase(sqlcommand)
            LoadDataFromDB("Select * from [" & CatgTbl & "]", CatgTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "update -- Categories")

        End Try
    End Sub
    ''' <summary>
    ''' deleting from database
    ''' </summary>
    Public Overloads Sub delete()
        Try
            updatedatabase("delete from " & CatgTbl & " where " & IdCol & " = " & id)
            LoadDataFromDB("Select * from [" & CatgTbl & "]", CatgTbl)
        Catch ex As Exception
            writeErrorLog(Err.Description, "delete -- categories")
        End Try
    End Sub
End Class


