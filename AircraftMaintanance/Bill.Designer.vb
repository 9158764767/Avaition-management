<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill
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
        Dim CostLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim PartsLabel As System.Windows.Forms.Label
        Dim Sr_noLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.BillTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.BillBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BillBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CostTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.PartsTextBox = New System.Windows.Forms.TextBox
        Me.Sr_noTextBox = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbltotalcost = New System.Windows.Forms.Label
        Me.lblcost = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblparts = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button7 = New System.Windows.Forms.Button
        CostLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        PartsLabel = New System.Windows.Forms.Label
        Sr_noLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CostLabel.Location = New System.Drawing.Point(90, 216)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(40, 15)
        CostLabel.TabIndex = 7
        CostLabel.Text = "Cost:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(90, 190)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 15)
        QuantityLabel.TabIndex = 5
        QuantityLabel.Text = "Quantity:"
        '
        'PartsLabel
        '
        PartsLabel.AutoSize = True
        PartsLabel.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PartsLabel.Location = New System.Drawing.Point(90, 164)
        PartsLabel.Name = "PartsLabel"
        PartsLabel.Size = New System.Drawing.Size(46, 15)
        PartsLabel.TabIndex = 3
        PartsLabel.Text = "Parts:"
        '
        'Sr_noLabel
        '
        Sr_noLabel.AutoSize = True
        Sr_noLabel.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sr_noLabel.Location = New System.Drawing.Point(90, 138)
        Sr_noLabel.Name = "Sr_noLabel"
        Sr_noLabel.Size = New System.Drawing.Size(46, 15)
        Sr_noLabel.TabIndex = 1
        Sr_noLabel.Text = "Sr no:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "Bill"
        Me.BillBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Me.BillTableAdapter
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
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'BillBindingNavigator
        '
        Me.BillBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BillBindingNavigator.BindingSource = Me.BillBindingSource
        Me.BillBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BillBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BillBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BillBindingNavigatorSaveItem})
        Me.BillBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BillBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BillBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BillBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BillBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BillBindingNavigator.Name = "BillBindingNavigator"
        Me.BillBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BillBindingNavigator.Size = New System.Drawing.Size(745, 26)
        Me.BillBindingNavigator.TabIndex = 0
        Me.BillBindingNavigator.Text = "BindingNavigator1"
        Me.BillBindingNavigator.Visible = False
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 23)
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
        'BillBindingNavigatorSaveItem
        '
        Me.BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BillBindingNavigatorSaveItem.Image = CType(resources.GetObject("BillBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BillBindingNavigatorSaveItem.Name = "BillBindingNavigatorSaveItem"
        Me.BillBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BillBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button4.Location = New System.Drawing.Point(185, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 36)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button3.Location = New System.Drawing.Point(66, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button2.Location = New System.Drawing.Point(185, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 37)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button1.Location = New System.Drawing.Point(66, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(420, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 35)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Bill Reports"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(169, 213)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 8
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(169, 187)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 6
        '
        'PartsTextBox
        '
        Me.PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Parts", True))
        Me.PartsTextBox.Location = New System.Drawing.Point(169, 161)
        Me.PartsTextBox.Name = "PartsTextBox"
        Me.PartsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartsTextBox.TabIndex = 4
        '
        'Sr_noTextBox
        '
        Me.Sr_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Sr no", True))
        Me.Sr_noTextBox.Location = New System.Drawing.Point(169, 135)
        Me.Sr_noTextBox.Name = "Sr_noTextBox"
        Me.Sr_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sr_noTextBox.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button5.Location = New System.Drawing.Point(312, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 40)
        Me.Button5.TabIndex = 44
        Me.Button5.Text = "Generate Bill"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Cooper Black", 9.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button6.Location = New System.Drawing.Point(114, 384)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 36)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbltotalcost)
        Me.Panel1.Controls.Add(Me.lblcost)
        Me.Panel1.Controls.Add(Me.lblqty)
        Me.Panel1.Controls.Add(Me.lblparts)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(515, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 453)
        Me.Panel1.TabIndex = 58
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(248, 248)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 24)
        Me.Button9.TabIndex = 68
        Me.Button9.Text = "Print"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(123, 248)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 24)
        Me.Button10.TabIndex = 67
        Me.Button10.Text = "Close"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(158, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Bill of All Parts"
        '
        'lbltotalcost
        '
        Me.lbltotalcost.AutoSize = True
        Me.lbltotalcost.ForeColor = System.Drawing.Color.Black
        Me.lbltotalcost.Location = New System.Drawing.Point(293, 198)
        Me.lbltotalcost.Name = "lbltotalcost"
        Me.lbltotalcost.Size = New System.Drawing.Size(0, 13)
        Me.lbltotalcost.TabIndex = 65
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.ForeColor = System.Drawing.Color.Black
        Me.lblcost.Location = New System.Drawing.Point(293, 156)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(0, 13)
        Me.lblcost.TabIndex = 64
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.ForeColor = System.Drawing.Color.Black
        Me.lblqty.Location = New System.Drawing.Point(293, 124)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(0, 13)
        Me.lblqty.TabIndex = 63
        '
        'lblparts
        '
        Me.lblparts.AutoSize = True
        Me.lblparts.ForeColor = System.Drawing.Color.Black
        Me.lblparts.Location = New System.Drawing.Point(293, 93)
        Me.lblparts.Name = "lblparts"
        Me.lblparts.Size = New System.Drawing.Size(0, 13)
        Me.lblparts.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(116, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Total Cost"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(116, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Cost"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(116, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(116, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Parts"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PartsDataGridViewTextBoxColumn
        '
        Me.PartsDataGridViewTextBoxColumn.DataPropertyName = "Parts"
        Me.PartsDataGridViewTextBoxColumn.HeaderText = "Parts"
        Me.PartsDataGridViewTextBoxColumn.Name = "PartsDataGridViewTextBoxColumn"
        '
        'SrNoDataGridViewTextBoxColumn
        '
        Me.SrNoDataGridViewTextBoxColumn.DataPropertyName = "Sr no"
        Me.SrNoDataGridViewTextBoxColumn.HeaderText = "Sr no"
        Me.SrNoDataGridViewTextBoxColumn.Name = "SrNoDataGridViewTextBoxColumn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrNoDataGridViewTextBoxColumn, Me.PartsDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BillBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(312, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(421, 150)
        Me.DataGridView1.TabIndex = 38
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button7.Location = New System.Drawing.Point(312, 326)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(134, 50)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "Generate Report"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(860, 506)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Sr_noLabel)
        Me.Controls.Add(Me.Sr_noTextBox)
        Me.Controls.Add(PartsLabel)
        Me.Controls.Add(Me.PartsTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.BillBindingNavigator)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.Name = "Bill"
        Me.Text = "Bill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BillBindingNavigator.ResumeLayout(False)
        Me.BillBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.BillTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BillBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BillBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sr_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotalcost As System.Windows.Forms.Label
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblparts As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
