Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.DirectoryServices.ActiveDirectory
Imports System.Threading

Public Class ShopManagement
    Public CurrentClass As String
    ''' <summary>
    ''' First sub to get triggered 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            writeErrorLog("", "")
            OnLoadInit()
            Dim i As New ShoppingMart
            LoadDataFromDB("SELECT * FROM " & ProdTbl, ProdTbl)
            LoadDataFromDB("SELECT * FROM " & CustTbl, CustTbl)
            LoadDataFromDB("SELECT * FROM " & CatgTbl, CatgTbl)
            LoadDataFromDB("select * from " & InvoiceTbl & " where " & IdCol & " = -1", CurrentClass)
            i.display(CurrentClass, DgvInvoice)
            LoadCmbItems()
        Catch ex As Exception
            writeErrorLog(Err.Description, "Customer_Load")
        End Try
    End Sub
    ''' <summary>
    ''' Load Customers data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MnuCustomers_Click(sender As Object, e As EventArgs) Handles MnuCustomers.Click
        Try
            LblAddress.Text = "Address"
            LblContact.Text = "ContactNo"
            LblEmail.Text = "Email"
            DgvDisplayGrid.Visible = True
            CurrentClass = CustTbl
            initalizeComponents_Customer()
            clearAllTextBoxes()
            Dim c As New Customers
            c.display(CurrentClass, DgvDisplayGrid)

        Catch ex As Exception
            writeErrorLog(Err.Description, "MnuCustomers_Click")
        End Try


    End Sub
    ''' <summary>
    ''' Add items to db
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If CurrentClass = CustTbl OrElse CurrentClass = InvoiceTbl Then
                If TxtName.Text = "" OrElse (TxtContact.Text.Length <> 10) Then
                    MsgBox("Enter Name and Contact Number")
                    Exit Sub
                End If
                If (TxtEmail.Text.Contains("@") = False AndAlso TxtEmail.Text.Contains(".") = False) Then
                    MsgBox("Enter valid Email")
                    Exit Sub
                End If
                If TxtId.Text = "" Then
                    Customers.name = TxtName.Text
                    Customers.address = TxtAddress.Text
                    Customers.contactNo = TxtContact.Text
                    Customers.email = TxtEmail.Text
                Else
                    MsgBox("Customer already exists in the database!")
                    Exit Sub
                End If
                Dim c As New Customers
                c.Add()
                c = Nothing
                If CurrentClass = InvoiceTbl Then
                    MsgBox("Customer added successfully to DB!")
                End If
            ElseIf CurrentClass = ProdTbl Then
                If TxtName.Text = "" OrElse TxtContact.Text = "" Then
                    MsgBox("Enter Name and Category Number")
                    Exit Sub
                End If

                If TxtId.Text = "" Then
                    Products.Price = TxtAddress.Text
                    Products.Quantity = TxtQuantity.Text
                    Products.name = TxtName.Text
                    Products.description = TxtEmail.Text
                    Products.category = TxtContact.Text
                Else
                    MsgBox("Product already exists in the database!")
                    Exit Sub
                End If
                Dim p As New Products
                p.add()
                p = Nothing
            ElseIf CurrentClass = CatgTbl Then
                If TxtName.Text = "" Then
                    MsgBox("Enter Name")
                    Exit Sub
                End If

                If TxtId.Text = "" Then
                    categories.name = TxtName.Text
                    categories.description = TxtEmail.Text
                Else
                    MsgBox("Category already exists in the database!")
                    Exit Sub
                End If
                Dim ct As New categories
                ct.add()
                ct = Nothing
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "BtnAdd_Click")
        End Try
    End Sub
    ''' <summary>
    ''' update to db
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If TxtId.Text = "" Then
                MsgBox("Row does not exist in the database, Please add the row!")
                Exit Sub
            End If
            If CurrentClass = CustTbl Then
                If TxtName.Text = "" OrElse (TxtContact.Text.Length <> 10) Then
                    MsgBox("Enter Name and Contact Number")
                    Exit Sub
                End If
                If (TxtEmail.Text.Contains("@") = False AndAlso TxtEmail.Text.Contains(".") = False) Then
                    MsgBox("Enter valid Email")
                    Exit Sub
                End If
                Dim c As New Customers
                Customers.name = TxtName.Text
                Customers.address = TxtAddress.Text
                Customers.contactNo = TxtContact.Text
                Customers.email = TxtEmail.Text
                Customers.id = TxtId.Text
                c.update()
                c = Nothing
            ElseIf CurrentClass = ProdTbl Then
                If TxtName.Text = "" OrElse TxtContact.Text = "" Then
                    MsgBox("Enter Name and Category Number")
                    Exit Sub
                End If
                Dim p As New Products
                Products.Price = TxtAddress.Text
                Products.Quantity = TxtQuantity.Text
                Products.name = TxtName.Text
                Products.description = TxtEmail.Text
                Products.category = TxtContact.Text
                Products.id = TxtId.Text
                p.update()
                p = Nothing
            ElseIf CurrentClass = CatgTbl Then
                If TxtName.Text = "" Then
                    MsgBox("Enter Name")
                    Exit Sub
                End If
                Dim ct As New categories
                categories.name = TxtName.Text
                categories.description = TxtEmail.Text
                categories.id = TxtId.Text
                ct.update()
                ct = Nothing
            End If

        Catch ex As Exception
            writeErrorLog(Err.Description, "BtnUpdate_Click")
        End Try
    End Sub
    ''' <summary>
    ''' delete from db
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If TxtId.Text = "" Then
                MsgBox("Row does not exist in the database!")
                Exit Sub
            End If
            If CurrentClass = CustTbl Then
                Dim c As New Customers
                Customers.name = TxtName.Text
                Customers.contactNo = TxtContact.Text
                Customers.id = TxtId.Text
                c.delete()
                Customers.id = Nothing
                c = Nothing
            ElseIf CurrentClass = ProdTbl Then
                Dim p As New Products
                Products.name = TxtName.Text
                Products.category = TxtQuantity.Text
                Products.id = TxtId.Text
                p.delete()
                Products.id = Nothing
                p = Nothing
            ElseIf CurrentClass = CatgTbl Then
                Dim ct As New categories
                categories.name = TxtName.Text
                categories.description = TxtEmail.Text
                categories.id = TxtId.Text
                ct.delete()
                categories.id = Nothing
                ct = Nothing
            End If
            TxtId.Text = ""


        Catch ex As Exception
            writeErrorLog(Err.Description, "BtnDelete_Click")
        End Try

    End Sub
    ''' <summary>
    ''' Loading Products data
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MnuProducts_Click(sender As Object, e As EventArgs) Handles MnuProducts.Click
        Try
            DgvDisplayGrid.Visible = True
            CurrentClass = ProdTbl
            LblEmail.Text = "Description"
            LblAddress.Text = "Price"
            LblContact.Text = "Category"
            LblCategory.Text = "Quantity"
            initalizeComponents_Customer()
            clearAllTextBoxes()
            Dim p As New Products
            LoadDataFromDB("SELECT * FROM " & ProdTbl, CurrentClass)
            p.display(ProdTbl, DgvDisplayGrid)

        Catch ex As Exception
            writeErrorLog(Err.Description, "MnuProducts_Click")
        End Try
    End Sub
    ''' <summary>
    ''' loading categories table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MnuCategories_Click(sender As Object, e As EventArgs) Handles MnuCategories.Click
        Try
            DgvDisplayGrid.Visible = True
            CurrentClass = CatgTbl
            LblEmail.Text = "Description"
            'initalizeComponents_Customer()

            LblCategory.Visible = False
            TxtQuantity.Visible = False
            TxtName.Visible = True
            TxtEmail.Visible = True
            TxtContact.Visible = False
            TxtAddress.Visible = False
            BtnAdd.Visible = True
            BtnDelete.Visible = True
            BtnUpdate.Visible = True
            LblAddress.Visible = False
            LblContact.Visible = False
            LblEmail.Visible = True
            LblName.Visible = True
            DgvInvoice.Visible = False
            CmbItems.Visible = False
            TxtQuant.Visible = False
            TxtDiscount.Visible = False
            BtnAddInvoice.Visible = False
            BtnGenInvoice.Visible = False
            LblCmbbx.Visible = False
            LblQuant.Visible = False
            Lbldiscount.Visible = False
            LblId.Visible = True
            TxtId.Visible = True
            LblModeofPay.Visible = False
            LblFlatdiscount.Visible = False
            TxtFlatDiscount.Visible = False
            CmbMode.Visible = False
            clearAllTextBoxes()


            Dim p As New categories

            LoadDataFromDB("SELECT * FROM " & CatgTbl, CurrentClass)
            p.display(CatgTbl, DgvDisplayGrid)

        Catch ex As Exception
            writeErrorLog(Err.Description, "MnuCategories_Click")
        End Try
    End Sub
    ''' <summary>
    ''' Adding invoice to DB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAddInvoice_Click(sender As Object, e As EventArgs) Handles BtnAddInvoice.Click
        Try
            If TxtName.Text = "" OrElse TxtContact.Text = "" Then
                MsgBox("Enter Customer Details")
                Exit Sub
            End If
            Dim checkquantity As Integer = 0
            Dim newRow As DataGridViewRow = New DataGridViewRow()

            Dim rows As DataRow() = ShoppingMart.dt_Data.Tables(ProdTbl).Select(NameCol & "='" & CmbItems.SelectedItem & "'")
            Dim row As DataRow = rows(0)
            checkquantity = Val(row(quantCol))
            If checkquantity < Val(TxtQuant.Text) Then
                MsgBox("Sorry! Stock empty..Only " & checkquantity & " left")
                Exit Sub
            End If
            ShoppingMart.ProductName = CmbItems.SelectedItem
            ShoppingMart.DiscountonProd = Val(TxtDiscount.Text)
            ShoppingMart.InQuantity = (Val(TxtQuant.Text))
            ShoppingMart.price = Val(row(PriceCol))
            ShoppingMart.Total = (Val(TxtQuant.Text) * Val(row(PriceCol))) - Val(TxtDiscount.Text)
            ShoppingMart.FlatDiscOnProd = Val(TxtFlatDiscount.Text)
            ShoppingMart.PaymentMode = CmbMode.SelectedItem
            rows = ShoppingMart.dt_Data.Tables(CustTbl).Select(NameCol & "='" & TxtName.Text & "' and " & ContactCol & " = '" & TxtContact.Text & "'")
            row = rows(0)
            ShoppingMart.Cust_Id = row(IdCol)
            Dim i As New ShoppingMart
            i.Add()

        Catch ex As Exception
            writeErrorLog(Err.Description, "MnuCategories_Click")
        End Try
    End Sub
    ''' <summary>
    ''' Home - Default load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Try
            clearAllTextBoxes()
            Call Customer_Load(Nothing, Nothing)
        Catch ex As Exception
            writeErrorLog(Err.Description, "HomeToolStripMenuItem_Click")
        End Try
    End Sub
    ''' <summary>
    ''' Validation - auto fill textboxes based on compulsory value entries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtContact_LostFocus(sender As Object, e As EventArgs) Handles TxtContact.LostFocus
        Dim connection As SqlConnection = Nothing
        Try

            Dim sqlcommand As String = ""
            open_connection(dbname, connection)
            connection.Open()
            If CurrentClass = CustTbl Or CurrentClass = InvoiceTbl Then
                sqlcommand = "select * from [" & CustTbl & "] where " & NameCol & " = '" & TxtName.Text & "' and " & ContactCol & " = '" & TxtContact.Text & "'"
            ElseIf CurrentClass = ProdTbl Then
                sqlcommand = "select * from [" & CurrentClass & "] where " & NameCol & " = '" & TxtName.Text & "' and " & catgcol & " = '" & TxtContact.Text & "'"
            ElseIf CurrentClass = CatgTbl Then
                sqlcommand = "select * from [" & CurrentClass & "] where " & NameCol & " = '" & TxtName.Text & "'"
            End If
            Dim sqladapter As New SqlDataAdapter(sqlcommand, connection)
            Dim tempdt As New DataTable
            Dim temprow As DataRow
            sqladapter.Fill(tempdt)
            If tempdt.Rows.Count < 1 Then
                If CurrentClass = InvoiceTbl Then

                    MsgBox("Customer doesn't exist in database! Please Add the customer to the database")
                    initalizeComponents_Customer()
                    Exit Sub

                End If
                Exit Sub
            End If
            temprow = tempdt.Rows(0)


            If CurrentClass = CustTbl Or CurrentClass = InvoiceTbl Then

                TxtId.Text = temprow(IdCol).ToString
                TxtAddress.Text = temprow(AddressCol).ToString
                TxtContact.Text = temprow(ContactCol).ToString
                TxtEmail.Text = temprow(EmailCol).ToString
                Customers.name = TxtName.Text
                Customers.address = TxtAddress.Text
                Customers.contactNo = TxtContact.Text
                Customers.email = TxtEmail.Text
                Customers.id = Val(TxtId.Text)
            ElseIf CurrentClass = ProdTbl Then
                TxtId.Text = temprow(IdCol).ToString
                TxtAddress.Text = temprow(PriceCol).ToString
                TxtContact.Text = temprow(catgcol).ToString
                TxtEmail.Text = temprow(descCol).ToString
                TxtQuantity.Text = temprow(quantCol).ToString
                Products.Price = TxtAddress.Text
                Products.Quantity = TxtQuantity.Text
                Products.name = TxtName.Text
                Products.description = TxtEmail.Text
                Products.category = TxtContact.Text
                Products.id = Val(TxtId.Text)
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "TxtName_LostFocus")
        Finally
            connection.Close()
        End Try
    End Sub
    ''' <summary>
    ''' Validation - auto fill textboxes based on compulsory value entries
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtName_LostFocus(sender As Object, e As EventArgs) Handles TxtName.LostFocus
        Dim connection As SqlConnection = Nothing
        Try
            If CurrentClass = CatgTbl Then

                Dim sqlcommand As String = ""
                open_connection(dbname, connection)
                connection.Open()
                sqlcommand = "select * from [" & CurrentClass & "] where " & NameCol & " = '" & TxtName.Text & "'"
                Dim tempdt As New DataTable
                Dim temprow As DataRow
                Dim sqladapter As New SqlDataAdapter(sqlcommand, connection)
                sqladapter.Fill(tempdt)
                If tempdt.Rows.Count < 1 Then
                    Exit Sub
                End If
                temprow = tempdt.Rows(0)
                TxtEmail.Text = temprow(descCol).ToString
                TxtId.Text = temprow(IdCol)
                categories.name = TxtName.Text
                categories.description = TxtEmail.Text
                categories.id = Val(TxtId.Text)
            End If
        Catch ex As Exception
            writeErrorLog(Err.Description, "TxtName_LostFocus")
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If

        End Try
    End Sub
    ''' <summary>
    ''' displaying design components 
    ''' </summary>
    Public Sub initalizeComponents_Customer()
        Try
            TxtName.Visible = True
            TxtEmail.Visible = True
            TxtContact.Visible = True
            TxtAddress.Visible = True
            BtnAdd.Visible = True
            BtnDelete.Visible = True
            BtnUpdate.Visible = True
            LblAddress.Visible = True
            LblContact.Visible = True
            LblEmail.Visible = True
            LblName.Visible = True
            LblCategory.Visible = False
            TxtQuantity.Visible = False
            If CurrentClass <> InvoiceTbl Then
                CmbItems.Visible = False
                TxtQuant.Visible = False
                TxtDiscount.Visible = False
                BtnAddInvoice.Visible = False
                BtnGenInvoice.Visible = False
                LblCmbbx.Visible = False
                LblQuant.Visible = False
                Lbldiscount.Visible = False
                LblModeofPay.Visible = False
                LblFlatdiscount.Visible = False
                TxtFlatDiscount.Visible = False
                CmbMode.Visible = False
                DgvInvoice.Visible = False
            End If

            LblId.Visible = True
            TxtId.Visible = True

        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' print invoice
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnGenInvoice_Click(sender As Object, e As EventArgs) Handles BtnGenInvoice.Click
        Try

            Dim newrow As Integer = 0
            For Each row As DataGridViewRow In DgvInvoice.Rows
                If Not row.IsNewRow Then
                    newrow = newrow + Val(row.Cells(4).Value)
                End If
            Next
            ExportDataGridViewToPDF(DgvInvoice, "C:\Users\nayak\source\repos\EGProject\WinFormsApp1\Invoice_" & TxtName.Text & "_" & Replace(Format(Now, "HH:MM:ss"), ":", "_") & ".pdf", newrow.ToString)
            clearAllTextBoxes()

        Catch ex As Exception
            writeErrorLog(Err.Description, "BtnGenInvoice_Click")
        End Try
    End Sub


    ''' <summary>
    ''' procedure to export data from grid to pdf
    ''' </summary>
    ''' <param name="dataGridView"></param>
    ''' <param name="filePath"></param>
    ''' <param name="total">Total amount</param>
    Public Sub ExportDataGridViewToPDF(dataGridView As DataGridView, filePath As String, total As String)
        Try
            Dim document As New Document()
            Dim content As String = "Invoice" & vbCrLf & "Date: " & Today.Date & vbCrLf & "Time: " & Format(Now, "HH:MM:ss") & vbCrLf & "Name : " & TxtName.Text & vbCrLf & "Contact Number :" & TxtContact.Text & vbCrLf & vbCrLf & vbCrLf
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
            document.Open()


            Dim pdfTable As PdfPTable = New PdfPTable(dataGridView.Columns.Count)
            Dim paragraph As New Paragraph(content)
            document.Add(paragraph)
            ' Add header row
            For Each column As DataGridViewColumn In dataGridView.Columns
                pdfTable.AddCell(New PdfPCell(New Phrase(column.HeaderText)))
            Next

            ' Add data rows
            For Each row As DataGridViewRow In dataGridView.Rows
                If Not row.IsNewRow Then
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(New PdfPCell(New Phrase(cell.Value.ToString())))
                    Next
                End If

            Next

            document.Add(pdfTable)
            content = vbCrLf & vbCrLf & vbCrLf & "Amount : " & total & vbCrLf & "GST(5% on all products) : " & ((0.05 * Val(total))) & vbCrLf & "Discount on Total bill : " & TxtFlatDiscount.Text & vbCrLf & "Total :" & (Val(total) + (0.05 * Val(total)) - Val(TxtFlatDiscount.Text))
            paragraph = New Paragraph(content)
            document.Add(paragraph)
            document.Close()

            writer.Close()

            If My.Computer.FileSystem.FileExists(filePath) Then
                Try
                    OpenPdfAndBringToFront(filePath)
                Catch ex As Exception
                    MsgBox("File generated in " & filePath)
                End Try
            End If

        Catch ex As Exception
            writeErrorLog(Err.Description, "ExportDataGridViewToPDF")
        End Try

    End Sub
    Sub OpenPdfAndBringToFront(filePath As String)
        Try
            Dim startInfo As New ProcessStartInfo()

            startInfo.FileName = filePath
            startInfo.UseShellExecute = True
            startInfo.WindowStyle = ProcessWindowStyle.Maximized ' Optional, might not always work

            Process.Start(startInfo)
        Catch ex As Exception

        End Try

    End Sub
    ''' <summary>
    ''' Display design components
    ''' </summary>
    Public Sub OnLoadInit()
        Try
            CurrentClass = InvoiceTbl
            TxtName.Visible = True
            TxtEmail.Visible = False
            TxtContact.Visible = True
            TxtAddress.Visible = False
            BtnAdd.Visible = False
            BtnDelete.Visible = False
            BtnUpdate.Visible = False
            LblAddress.Visible = False
            LblContact.Visible = True
            LblContact.Text = "ContactNo"
            LblEmail.Visible = False
            LblName.Visible = True
            LblCategory.Visible = False
            TxtQuantity.Visible = False
            DgvDisplayGrid.Visible = False
            DgvInvoice.Visible = True
            CmbItems.Visible = True
            TxtQuant.Visible = True
            TxtDiscount.Visible = True
            BtnAddInvoice.Visible = True
            BtnGenInvoice.Visible = True
            LblCmbbx.Visible = True
            LblQuant.Visible = True
            Lbldiscount.Visible = True
            LblId.Visible = False
            TxtId.Visible = False
            LblModeofPay.Visible = True
            LblFlatdiscount.Visible = True
            TxtFlatDiscount.Visible = True
            CmbMode.Visible = True
        Catch ex As Exception
            writeErrorLog(Err.Description, "OnLoadInit")
        End Try
    End Sub
    ''' <summary>
    ''' Loading Products combo box
    ''' </summary>
    Public Sub LoadCmbItems()
        Try
            CmbItems.Items.Clear()
            For Each row As DataRow In ShoppingMart.dt_Data.Tables(ProdTbl).Rows
                CmbItems.Items.Add(row(NameCol))
            Next
        Catch ex As Exception
            writeErrorLog(Err.Description, "LoadCmbItems")
        End Try


    End Sub
    Public Sub clearAllTextBoxes()
        Try
            TxtAddress.Text = ""
            TxtContact.Text = ""
            TxtDiscount.Text = ""
            TxtEmail.Text = ""
            TxtFlatDiscount.Text = ""
            TxtId.Text = ""
            TxtName.Text = ""
            TxtQuant.Text = ""
            TxtQuantity.Text = ""
            CmbItems.SelectedItem = ""
            CmbMode.SelectedItem = ""
        Catch ex As Exception
            writeErrorLog(Err.Description, "LoadCmbItems")
        End Try
    End Sub
End Class
