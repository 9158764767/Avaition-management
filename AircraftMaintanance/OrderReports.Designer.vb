<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim Order_ByLabel As System.Windows.Forms.Label
        Dim Vendor_NameLabel As System.Windows.Forms.Label
        Dim All_Cocpit_PartsLabel As System.Windows.Forms.Label
        Dim All_Fuselage_PartsLabel As System.Windows.Forms.Label
        Dim All_Interior_PartsLabel As System.Windows.Forms.Label
        Dim StabilizersLabel As System.Windows.Forms.Label
        Dim Payment_TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderReports))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Order_FormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_FormTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Order_FormTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Order_FormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Order_FormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllCocpitPartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllFuselagePartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllInteriorPartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StabilizersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Order_ByTextBox = New System.Windows.Forms.TextBox
        Me.Vendor_NameTextBox = New System.Windows.Forms.TextBox
        Me.All_Cocpit_PartsTextBox = New System.Windows.Forms.TextBox
        Me.All_Fuselage_PartsTextBox = New System.Windows.Forms.TextBox
        Me.All_Interior_PartsTextBox = New System.Windows.Forms.TextBox
        Me.StabilizersTextBox = New System.Windows.Forms.TextBox
        Me.Payment_TypeTextBox = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Order_DateLabel = New System.Windows.Forms.Label
        Order_ByLabel = New System.Windows.Forms.Label
        Vendor_NameLabel = New System.Windows.Forms.Label
        All_Cocpit_PartsLabel = New System.Windows.Forms.Label
        All_Fuselage_PartsLabel = New System.Windows.Forms.Label
        All_Interior_PartsLabel = New System.Windows.Forms.Label
        StabilizersLabel = New System.Windows.Forms.Label
        Payment_TypeLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_FormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_FormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_FormBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_DateLabel.Location = New System.Drawing.Point(5, 95)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(83, 13)
        Order_DateLabel.TabIndex = 17
        Order_DateLabel.Text = "Order Date:"
        '
        'Order_ByLabel
        '
        Order_ByLabel.AutoSize = True
        Order_ByLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_ByLabel.Location = New System.Drawing.Point(5, 120)
        Order_ByLabel.Name = "Order_ByLabel"
        Order_ByLabel.Size = New System.Drawing.Size(69, 13)
        Order_ByLabel.TabIndex = 19
        Order_ByLabel.Text = "Order By:"
        '
        'Vendor_NameLabel
        '
        Vendor_NameLabel.AutoSize = True
        Vendor_NameLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vendor_NameLabel.Location = New System.Drawing.Point(5, 146)
        Vendor_NameLabel.Name = "Vendor_NameLabel"
        Vendor_NameLabel.Size = New System.Drawing.Size(94, 13)
        Vendor_NameLabel.TabIndex = 21
        Vendor_NameLabel.Text = "Vendor Name:"
        '
        'All_Cocpit_PartsLabel
        '
        All_Cocpit_PartsLabel.AutoSize = True
        All_Cocpit_PartsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        All_Cocpit_PartsLabel.Location = New System.Drawing.Point(5, 172)
        All_Cocpit_PartsLabel.Name = "All_Cocpit_PartsLabel"
        All_Cocpit_PartsLabel.Size = New System.Drawing.Size(115, 13)
        All_Cocpit_PartsLabel.TabIndex = 23
        All_Cocpit_PartsLabel.Text = "All Cocpit Parts:"
        '
        'All_Fuselage_PartsLabel
        '
        All_Fuselage_PartsLabel.AutoSize = True
        All_Fuselage_PartsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        All_Fuselage_PartsLabel.Location = New System.Drawing.Point(5, 198)
        All_Fuselage_PartsLabel.Name = "All_Fuselage_PartsLabel"
        All_Fuselage_PartsLabel.Size = New System.Drawing.Size(133, 13)
        All_Fuselage_PartsLabel.TabIndex = 25
        All_Fuselage_PartsLabel.Text = "All Fuselage Parts:"
        '
        'All_Interior_PartsLabel
        '
        All_Interior_PartsLabel.AutoSize = True
        All_Interior_PartsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        All_Interior_PartsLabel.Location = New System.Drawing.Point(5, 224)
        All_Interior_PartsLabel.Name = "All_Interior_PartsLabel"
        All_Interior_PartsLabel.Size = New System.Drawing.Size(126, 13)
        All_Interior_PartsLabel.TabIndex = 27
        All_Interior_PartsLabel.Text = "All Interior Parts:"
        '
        'StabilizersLabel
        '
        StabilizersLabel.AutoSize = True
        StabilizersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StabilizersLabel.Location = New System.Drawing.Point(5, 250)
        StabilizersLabel.Name = "StabilizersLabel"
        StabilizersLabel.Size = New System.Drawing.Size(80, 13)
        StabilizersLabel.TabIndex = 29
        StabilizersLabel.Text = "Stabilizers:"
        '
        'Payment_TypeLabel
        '
        Payment_TypeLabel.AutoSize = True
        Payment_TypeLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Payment_TypeLabel.Location = New System.Drawing.Point(5, 276)
        Payment_TypeLabel.Name = "Payment_TypeLabel"
        Payment_TypeLabel.Size = New System.Drawing.Size(94, 13)
        Payment_TypeLabel.TabIndex = 31
        Payment_TypeLabel.Text = "Payment Type:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_FormBindingSource
        '
        Me.Order_FormBindingSource.DataMember = "Order Form"
        Me.Order_FormBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Order_FormTableAdapter
        '
        Me.Order_FormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.BranchesTableAdapter = Nothing
        Me.TableAdapterManager.Company_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.Company_nameTableAdapter = Nothing
        Me.TableAdapterManager.Damage_EstimateTableAdapter = Nothing
        Me.TableAdapterManager.DamageAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.EquipmentRequiredTableAdapter = Nothing
        Me.TableAdapterManager.Flight_AnalysisTableAdapter = Nothing
        Me.TableAdapterManager.Hanger_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.Monthly_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.Order_FormTableAdapter = Me.Order_FormTableAdapter
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Order_FormBindingNavigator
        '
        Me.Order_FormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Order_FormBindingNavigator.BindingSource = Me.Order_FormBindingSource
        Me.Order_FormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order_FormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Order_FormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Order_FormBindingNavigatorSaveItem})
        Me.Order_FormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order_FormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order_FormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order_FormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order_FormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order_FormBindingNavigator.Name = "Order_FormBindingNavigator"
        Me.Order_FormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order_FormBindingNavigator.Size = New System.Drawing.Size(803, 26)
        Me.Order_FormBindingNavigator.TabIndex = 0
        Me.Order_FormBindingNavigator.Text = "BindingNavigator1"
        Me.Order_FormBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(41, 23)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 26)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 23)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'Order_FormBindingNavigatorSaveItem
        '
        Me.Order_FormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order_FormBindingNavigatorSaveItem.Image = CType(resources.GetObject("Order_FormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Order_FormBindingNavigatorSaveItem.Name = "Order_FormBindingNavigatorSaveItem"
        Me.Order_FormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Order_FormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderDateDataGridViewTextBoxColumn, Me.OrderByDataGridViewTextBoxColumn, Me.VendorNameDataGridViewTextBoxColumn, Me.AllCocpitPartsDataGridViewTextBoxColumn, Me.AllFuselagePartsDataGridViewTextBoxColumn, Me.AllInteriorPartsDataGridViewTextBoxColumn, Me.StabilizersDataGridViewTextBoxColumn, Me.PaymentTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Order_FormBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(362, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(429, 306)
        Me.DataGridView1.TabIndex = 17
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "Order Date"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        '
        'OrderByDataGridViewTextBoxColumn
        '
        Me.OrderByDataGridViewTextBoxColumn.DataPropertyName = "Order By"
        Me.OrderByDataGridViewTextBoxColumn.HeaderText = "Order By"
        Me.OrderByDataGridViewTextBoxColumn.Name = "OrderByDataGridViewTextBoxColumn"
        '
        'VendorNameDataGridViewTextBoxColumn
        '
        Me.VendorNameDataGridViewTextBoxColumn.DataPropertyName = "Vendor Name"
        Me.VendorNameDataGridViewTextBoxColumn.HeaderText = "Vendor Name"
        Me.VendorNameDataGridViewTextBoxColumn.Name = "VendorNameDataGridViewTextBoxColumn"
        '
        'AllCocpitPartsDataGridViewTextBoxColumn
        '
        Me.AllCocpitPartsDataGridViewTextBoxColumn.DataPropertyName = "All Cocpit Parts"
        Me.AllCocpitPartsDataGridViewTextBoxColumn.HeaderText = "All Cocpit Parts"
        Me.AllCocpitPartsDataGridViewTextBoxColumn.Name = "AllCocpitPartsDataGridViewTextBoxColumn"
        '
        'AllFuselagePartsDataGridViewTextBoxColumn
        '
        Me.AllFuselagePartsDataGridViewTextBoxColumn.DataPropertyName = "All Fuselage Parts"
        Me.AllFuselagePartsDataGridViewTextBoxColumn.HeaderText = "All Fuselage Parts"
        Me.AllFuselagePartsDataGridViewTextBoxColumn.Name = "AllFuselagePartsDataGridViewTextBoxColumn"
        '
        'AllInteriorPartsDataGridViewTextBoxColumn
        '
        Me.AllInteriorPartsDataGridViewTextBoxColumn.DataPropertyName = "All Interior Parts"
        Me.AllInteriorPartsDataGridViewTextBoxColumn.HeaderText = "All Interior Parts"
        Me.AllInteriorPartsDataGridViewTextBoxColumn.Name = "AllInteriorPartsDataGridViewTextBoxColumn"
        '
        'StabilizersDataGridViewTextBoxColumn
        '
        Me.StabilizersDataGridViewTextBoxColumn.DataPropertyName = "Stabilizers"
        Me.StabilizersDataGridViewTextBoxColumn.HeaderText = "Stabilizers"
        Me.StabilizersDataGridViewTextBoxColumn.Name = "StabilizersDataGridViewTextBoxColumn"
        '
        'PaymentTypeDataGridViewTextBoxColumn
        '
        Me.PaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Payment Type"
        Me.PaymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type"
        Me.PaymentTypeDataGridViewTextBoxColumn.Name = "PaymentTypeDataGridViewTextBoxColumn"
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Order_FormBindingSource, "Order Date", True))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(156, 88)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Order_DateDateTimePicker.TabIndex = 18
        '
        'Order_ByTextBox
        '
        Me.Order_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "Order By", True))
        Me.Order_ByTextBox.Location = New System.Drawing.Point(156, 114)
        Me.Order_ByTextBox.Name = "Order_ByTextBox"
        Me.Order_ByTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Order_ByTextBox.TabIndex = 20
        '
        'Vendor_NameTextBox
        '
        Me.Vendor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "Vendor Name", True))
        Me.Vendor_NameTextBox.Location = New System.Drawing.Point(156, 140)
        Me.Vendor_NameTextBox.Name = "Vendor_NameTextBox"
        Me.Vendor_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vendor_NameTextBox.TabIndex = 22
        '
        'All_Cocpit_PartsTextBox
        '
        Me.All_Cocpit_PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "All Cocpit Parts", True))
        Me.All_Cocpit_PartsTextBox.Location = New System.Drawing.Point(156, 166)
        Me.All_Cocpit_PartsTextBox.Name = "All_Cocpit_PartsTextBox"
        Me.All_Cocpit_PartsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.All_Cocpit_PartsTextBox.TabIndex = 24
        '
        'All_Fuselage_PartsTextBox
        '
        Me.All_Fuselage_PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "All Fuselage Parts", True))
        Me.All_Fuselage_PartsTextBox.Location = New System.Drawing.Point(156, 192)
        Me.All_Fuselage_PartsTextBox.Name = "All_Fuselage_PartsTextBox"
        Me.All_Fuselage_PartsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.All_Fuselage_PartsTextBox.TabIndex = 26
        '
        'All_Interior_PartsTextBox
        '
        Me.All_Interior_PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "All Interior Parts", True))
        Me.All_Interior_PartsTextBox.Location = New System.Drawing.Point(156, 218)
        Me.All_Interior_PartsTextBox.Name = "All_Interior_PartsTextBox"
        Me.All_Interior_PartsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.All_Interior_PartsTextBox.TabIndex = 28
        '
        'StabilizersTextBox
        '
        Me.StabilizersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "Stabilizers", True))
        Me.StabilizersTextBox.Location = New System.Drawing.Point(156, 244)
        Me.StabilizersTextBox.Name = "StabilizersTextBox"
        Me.StabilizersTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StabilizersTextBox.TabIndex = 30
        '
        'Payment_TypeTextBox
        '
        Me.Payment_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_FormBindingSource, "Payment Type", True))
        Me.Payment_TypeTextBox.Location = New System.Drawing.Point(156, 270)
        Me.Payment_TypeTextBox.Name = "Payment_TypeTextBox"
        Me.Payment_TypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Payment_TypeTextBox.TabIndex = 32
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(138, 368)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(21, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(138, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Order Reports"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(73, 427)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OrderReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(803, 476)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Order_DateLabel)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Order_ByLabel)
        Me.Controls.Add(Me.Order_ByTextBox)
        Me.Controls.Add(Vendor_NameLabel)
        Me.Controls.Add(Me.Vendor_NameTextBox)
        Me.Controls.Add(All_Cocpit_PartsLabel)
        Me.Controls.Add(Me.All_Cocpit_PartsTextBox)
        Me.Controls.Add(All_Fuselage_PartsLabel)
        Me.Controls.Add(Me.All_Fuselage_PartsTextBox)
        Me.Controls.Add(All_Interior_PartsLabel)
        Me.Controls.Add(Me.All_Interior_PartsTextBox)
        Me.Controls.Add(StabilizersLabel)
        Me.Controls.Add(Me.StabilizersTextBox)
        Me.Controls.Add(Payment_TypeLabel)
        Me.Controls.Add(Me.Payment_TypeTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Order_FormBindingNavigator)
        Me.Name = "OrderReports"
        Me.Text = "OrderReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_FormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_FormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_FormBindingNavigator.ResumeLayout(False)
        Me.Order_FormBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Order_FormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order_FormTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Order_FormTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_FormBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Order_FormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllCocpitPartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllFuselagePartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllInteriorPartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StabilizersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Order_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Order_ByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents All_Cocpit_PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents All_Fuselage_PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents All_Interior_PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StabilizersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
