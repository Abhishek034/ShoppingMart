<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShopManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        MnuProducts = New ToolStripMenuItem()
        MnuCustomers = New ToolStripMenuItem()
        MnuCategories = New ToolStripMenuItem()
        DgvDisplayGrid = New DataGridView()
        BtnAdd = New Button()
        TxtName = New TextBox()
        TxtEmail = New TextBox()
        TxtAddress = New TextBox()
        TxtContact = New TextBox()
        LblName = New Label()
        LblEmail = New Label()
        LblAddress = New Label()
        LblContact = New Label()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        LblCategory = New Label()
        TxtQuantity = New TextBox()
        CmbItems = New ComboBox()
        TxtQuant = New TextBox()
        TxtDiscount = New TextBox()
        LblCmbbx = New Label()
        LblQuant = New Label()
        Lbldiscount = New Label()
        BtnAddInvoice = New Button()
        BtnGenInvoice = New Button()
        DgvInvoice = New DataGridView()
        LblId = New Label()
        TxtId = New TextBox()
        CmbMode = New ComboBox()
        LblModeofPay = New Label()
        LblFlatdiscount = New Label()
        TxtFlatDiscount = New TextBox()
        MenuStrip1.SuspendLayout()
        CType(DgvDisplayGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvInvoice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, MnuProducts, MnuCustomers, MnuCategories})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(994, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(64, 24)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' MnuProducts
        ' 
        MnuProducts.Name = "MnuProducts"
        MnuProducts.Size = New Size(80, 24)
        MnuProducts.Text = "Products"
        ' 
        ' MnuCustomers
        ' 
        MnuCustomers.Name = "MnuCustomers"
        MnuCustomers.Size = New Size(92, 24)
        MnuCustomers.Text = "Customers"
        ' 
        ' MnuCategories
        ' 
        MnuCategories.Name = "MnuCategories"
        MnuCategories.Size = New Size(94, 24)
        MnuCategories.Text = "Categories"
        ' 
        ' DgvDisplayGrid
        ' 
        DgvDisplayGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDisplayGrid.Location = New Point(12, 51)
        DgvDisplayGrid.Name = "DgvDisplayGrid"
        DgvDisplayGrid.RowHeadersWidth = 51
        DgvDisplayGrid.Size = New Size(433, 292)
        DgvDisplayGrid.TabIndex = 1
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(595, 362)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(77, 29)
        BtnAdd.TabIndex = 2
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(728, 95)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(125, 27)
        TxtName.TabIndex = 3
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(728, 271)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(125, 27)
        TxtEmail.TabIndex = 4
        ' 
        ' TxtAddress
        ' 
        TxtAddress.Location = New Point(728, 206)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(125, 27)
        TxtAddress.TabIndex = 5
        ' 
        ' TxtContact
        ' 
        TxtContact.Location = New Point(728, 149)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(125, 27)
        TxtContact.TabIndex = 6
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Location = New Point(610, 98)
        LblName.Name = "LblName"
        LblName.Size = New Size(49, 20)
        LblName.TabIndex = 7
        LblName.Text = "Name"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.Location = New Point(613, 274)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(46, 20)
        LblEmail.TabIndex = 8
        LblEmail.Text = "Email"
        ' 
        ' LblAddress
        ' 
        LblAddress.AutoSize = True
        LblAddress.Location = New Point(610, 209)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(62, 20)
        LblAddress.TabIndex = 9
        LblAddress.Text = "Address"
        ' 
        ' LblContact
        ' 
        LblContact.AutoSize = True
        LblContact.Location = New Point(610, 149)
        LblContact.Name = "LblContact"
        LblContact.Size = New Size(84, 20)
        LblContact.TabIndex = 10
        LblContact.Text = "Contact No"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(689, 362)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(77, 29)
        BtnUpdate.TabIndex = 11
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(786, 362)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(77, 29)
        BtnDelete.TabIndex = 12
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' LblCategory
        ' 
        LblCategory.AutoSize = True
        LblCategory.Location = New Point(610, 327)
        LblCategory.Name = "LblCategory"
        LblCategory.Size = New Size(84, 20)
        LblCategory.TabIndex = 13
        LblCategory.Text = "Contact No"
        ' 
        ' TxtQuantity
        ' 
        TxtQuantity.Location = New Point(728, 324)
        TxtQuantity.Name = "TxtQuantity"
        TxtQuantity.Size = New Size(125, 27)
        TxtQuantity.TabIndex = 14
        ' 
        ' CmbItems
        ' 
        CmbItems.FormattingEnabled = True
        CmbItems.Location = New Point(7, 376)
        CmbItems.Name = "CmbItems"
        CmbItems.Size = New Size(151, 28)
        CmbItems.TabIndex = 16
        ' 
        ' TxtQuant
        ' 
        TxtQuant.Location = New Point(187, 377)
        TxtQuant.Name = "TxtQuant"
        TxtQuant.Size = New Size(151, 27)
        TxtQuant.TabIndex = 17
        ' 
        ' TxtDiscount
        ' 
        TxtDiscount.Location = New Point(357, 379)
        TxtDiscount.Name = "TxtDiscount"
        TxtDiscount.Size = New Size(151, 27)
        TxtDiscount.TabIndex = 18
        ' 
        ' LblCmbbx
        ' 
        LblCmbbx.AutoSize = True
        LblCmbbx.Location = New Point(7, 353)
        LblCmbbx.Name = "LblCmbbx"
        LblCmbbx.Size = New Size(66, 20)
        LblCmbbx.TabIndex = 19
        LblCmbbx.Text = "Products"
        ' 
        ' LblQuant
        ' 
        LblQuant.AutoSize = True
        LblQuant.Location = New Point(187, 353)
        LblQuant.Name = "LblQuant"
        LblQuant.Size = New Size(65, 20)
        LblQuant.TabIndex = 20
        LblQuant.Text = "Quantity"
        ' 
        ' Lbldiscount
        ' 
        Lbldiscount.AutoSize = True
        Lbldiscount.Location = New Point(357, 353)
        Lbldiscount.Name = "Lbldiscount"
        Lbldiscount.Size = New Size(143, 20)
        Lbldiscount.TabIndex = 21
        Lbldiscount.Text = "Discount on Product"
        ' 
        ' BtnAddInvoice
        ' 
        BtnAddInvoice.Location = New Point(621, 394)
        BtnAddInvoice.Name = "BtnAddInvoice"
        BtnAddInvoice.Size = New Size(115, 29)
        BtnAddInvoice.TabIndex = 22
        BtnAddInvoice.Text = "Add to Invoice"
        BtnAddInvoice.UseVisualStyleBackColor = True
        ' 
        ' BtnGenInvoice
        ' 
        BtnGenInvoice.Location = New Point(759, 393)
        BtnGenInvoice.Name = "BtnGenInvoice"
        BtnGenInvoice.Size = New Size(94, 29)
        BtnGenInvoice.TabIndex = 23
        BtnGenInvoice.Text = "Invoice"
        BtnGenInvoice.UseVisualStyleBackColor = True
        ' 
        ' DgvInvoice
        ' 
        DgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInvoice.Location = New Point(12, 51)
        DgvInvoice.Name = "DgvInvoice"
        DgvInvoice.RowHeadersWidth = 51
        DgvInvoice.Size = New Size(560, 292)
        DgvInvoice.TabIndex = 24
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.Location = New Point(610, 51)
        LblId.Name = "LblId"
        LblId.Size = New Size(22, 20)
        LblId.TabIndex = 25
        LblId.Text = "Id"
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(728, 51)
        TxtId.Name = "TxtId"
        TxtId.ReadOnly = True
        TxtId.Size = New Size(125, 27)
        TxtId.TabIndex = 26
        ' 
        ' CmbMode
        ' 
        CmbMode.FormattingEnabled = True
        CmbMode.Items.AddRange(New Object() {"UPI", "Cash", "Card"})
        CmbMode.Location = New Point(7, 436)
        CmbMode.Name = "CmbMode"
        CmbMode.Size = New Size(151, 28)
        CmbMode.TabIndex = 27
        ' 
        ' LblModeofPay
        ' 
        LblModeofPay.AutoSize = True
        LblModeofPay.Location = New Point(7, 413)
        LblModeofPay.Name = "LblModeofPay"
        LblModeofPay.Size = New Size(126, 20)
        LblModeofPay.TabIndex = 28
        LblModeofPay.Text = "Mode of Payment"
        ' 
        ' LblFlatdiscount
        ' 
        LblFlatdiscount.AutoSize = True
        LblFlatdiscount.Location = New Point(187, 413)
        LblFlatdiscount.Name = "LblFlatdiscount"
        LblFlatdiscount.Size = New Size(95, 20)
        LblFlatdiscount.TabIndex = 29
        LblFlatdiscount.Text = "Flat Discount"
        ' 
        ' TxtFlatDiscount
        ' 
        TxtFlatDiscount.Location = New Point(187, 437)
        TxtFlatDiscount.Name = "TxtFlatDiscount"
        TxtFlatDiscount.Size = New Size(151, 27)
        TxtFlatDiscount.TabIndex = 30
        ' 
        ' ShopManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(994, 610)
        Controls.Add(TxtFlatDiscount)
        Controls.Add(LblFlatdiscount)
        Controls.Add(LblModeofPay)
        Controls.Add(CmbMode)
        Controls.Add(TxtId)
        Controls.Add(LblId)
        Controls.Add(DgvInvoice)
        Controls.Add(BtnGenInvoice)
        Controls.Add(BtnAddInvoice)
        Controls.Add(Lbldiscount)
        Controls.Add(LblQuant)
        Controls.Add(LblCmbbx)
        Controls.Add(TxtDiscount)
        Controls.Add(TxtQuant)
        Controls.Add(CmbItems)
        Controls.Add(TxtQuantity)
        Controls.Add(LblCategory)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(LblContact)
        Controls.Add(LblAddress)
        Controls.Add(LblEmail)
        Controls.Add(LblName)
        Controls.Add(TxtContact)
        Controls.Add(TxtAddress)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        Controls.Add(BtnAdd)
        Controls.Add(DgvDisplayGrid)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "ShopManagement"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DgvDisplayGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvInvoice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuProducts As ToolStripMenuItem
    Friend WithEvents MnuCustomers As ToolStripMenuItem
    Friend WithEvents MnuCategories As ToolStripMenuItem
    Friend WithEvents DgvDisplayGrid As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblContact As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblCategory As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmbItems As ComboBox
    Friend WithEvents TxtQuant As TextBox
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents LblCmbbx As Label
    Friend WithEvents LblQuant As Label
    Friend WithEvents Lbldiscount As Label
    Friend WithEvents BtnAddInvoice As Button
    Friend WithEvents BtnGenInvoice As Button
    Friend WithEvents DgvInvoice As DataGridView
    Friend WithEvents LblId As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CmbMode As ComboBox
    Friend WithEvents LblModeofPay As Label
    Friend WithEvents LblFlatdiscount As Label
    Friend WithEvents TxtFlatDiscount As TextBox

End Class
