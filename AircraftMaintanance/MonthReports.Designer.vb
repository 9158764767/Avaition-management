<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthReports
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
        Dim No_Of_Aircraft_RepairLabel As System.Windows.Forms.Label
        Dim Total_No_Of_ScrapLabel As System.Windows.Forms.Label
        Dim Total_Manpower_RequiredLabel As System.Windows.Forms.Label
        Dim Stock_Used_In_PercentLabel As System.Windows.Forms.Label
        Dim Total_CostLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthReports))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Monthly_ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Monthly_ReportsTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Monthly_ReportsTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Monthly_ReportsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Monthly_ReportsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.No_Of_Aircraft_RepairTextBox = New System.Windows.Forms.TextBox
        Me.Total_No_Of_ScrapTextBox = New System.Windows.Forms.TextBox
        Me.Total_Manpower_RequiredTextBox = New System.Windows.Forms.TextBox
        Me.Stock_Used_In_PercentTextBox = New System.Windows.Forms.TextBox
        Me.Total_CostTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NoOfAircraftRepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalNoOfScrapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalManpowerRequiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StockUsedInPercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.lblFinalCost = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Button9 = New System.Windows.Forms.Button
        No_Of_Aircraft_RepairLabel = New System.Windows.Forms.Label
        Total_No_Of_ScrapLabel = New System.Windows.Forms.Label
        Total_Manpower_RequiredLabel = New System.Windows.Forms.Label
        Stock_Used_In_PercentLabel = New System.Windows.Forms.Label
        Total_CostLabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monthly_ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monthly_ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Monthly_ReportsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'No_Of_Aircraft_RepairLabel
        '
        No_Of_Aircraft_RepairLabel.AutoSize = True
        No_Of_Aircraft_RepairLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_Of_Aircraft_RepairLabel.Location = New System.Drawing.Point(21, 117)
        No_Of_Aircraft_RepairLabel.Name = "No_Of_Aircraft_RepairLabel"
        No_Of_Aircraft_RepairLabel.Size = New System.Drawing.Size(152, 13)
        No_Of_Aircraft_RepairLabel.TabIndex = 1
        No_Of_Aircraft_RepairLabel.Text = "No Of Aircraft Repair:"
        '
        'Total_No_Of_ScrapLabel
        '
        Total_No_Of_ScrapLabel.AutoSize = True
        Total_No_Of_ScrapLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_No_Of_ScrapLabel.Location = New System.Drawing.Point(21, 143)
        Total_No_Of_ScrapLabel.Name = "Total_No_Of_ScrapLabel"
        Total_No_Of_ScrapLabel.Size = New System.Drawing.Size(127, 13)
        Total_No_Of_ScrapLabel.TabIndex = 3
        Total_No_Of_ScrapLabel.Text = "Total No Of Scrap:"
        '
        'Total_Manpower_RequiredLabel
        '
        Total_Manpower_RequiredLabel.AutoSize = True
        Total_Manpower_RequiredLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Manpower_RequiredLabel.Location = New System.Drawing.Point(21, 169)
        Total_Manpower_RequiredLabel.Name = "Total_Manpower_RequiredLabel"
        Total_Manpower_RequiredLabel.Size = New System.Drawing.Size(177, 13)
        Total_Manpower_RequiredLabel.TabIndex = 5
        Total_Manpower_RequiredLabel.Text = "Total Manpower Required:"
        '
        'Stock_Used_In_PercentLabel
        '
        Stock_Used_In_PercentLabel.AutoSize = True
        Stock_Used_In_PercentLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stock_Used_In_PercentLabel.Location = New System.Drawing.Point(21, 195)
        Stock_Used_In_PercentLabel.Name = "Stock_Used_In_PercentLabel"
        Stock_Used_In_PercentLabel.Size = New System.Drawing.Size(152, 13)
        Stock_Used_In_PercentLabel.TabIndex = 7
        Stock_Used_In_PercentLabel.Text = "Stock Used In Percent:"
        '
        'Total_CostLabel
        '
        Total_CostLabel.AutoSize = True
        Total_CostLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_CostLabel.Location = New System.Drawing.Point(21, 221)
        Total_CostLabel.Name = "Total_CostLabel"
        Total_CostLabel.Size = New System.Drawing.Size(78, 13)
        Total_CostLabel.TabIndex = 9
        Total_CostLabel.Text = "Total Cost:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(21, 50)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(152, 13)
        Label4.TabIndex = 10
        Label4.Text = "No Of Aircraft Repair:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(21, 76)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(127, 13)
        Label5.TabIndex = 11
        Label5.Text = "Total No Of Scrap:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(21, 102)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(177, 13)
        Label6.TabIndex = 12
        Label6.Text = "Total Manpower Required:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(21, 154)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(99, 13)
        Label8.TabIndex = 14
        Label8.Text = "All Total Cost"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Monthly_ReportsBindingSource
        '
        Me.Monthly_ReportsBindingSource.DataMember = "Monthly Reports"
        Me.Monthly_ReportsBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Monthly_ReportsTableAdapter
        '
        Me.Monthly_ReportsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Monthly_ReportsTableAdapter = Me.Monthly_ReportsTableAdapter
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Monthly_ReportsBindingNavigator
        '
        Me.Monthly_ReportsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Monthly_ReportsBindingNavigator.BindingSource = Me.Monthly_ReportsBindingSource
        Me.Monthly_ReportsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Monthly_ReportsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Monthly_ReportsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Monthly_ReportsBindingNavigatorSaveItem})
        Me.Monthly_ReportsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Monthly_ReportsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Monthly_ReportsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Monthly_ReportsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Monthly_ReportsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Monthly_ReportsBindingNavigator.Name = "Monthly_ReportsBindingNavigator"
        Me.Monthly_ReportsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Monthly_ReportsBindingNavigator.Size = New System.Drawing.Size(769, 26)
        Me.Monthly_ReportsBindingNavigator.TabIndex = 0
        Me.Monthly_ReportsBindingNavigator.Text = "BindingNavigator1"
        Me.Monthly_ReportsBindingNavigator.Visible = False
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
        'Monthly_ReportsBindingNavigatorSaveItem
        '
        Me.Monthly_ReportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Monthly_ReportsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Monthly_ReportsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Monthly_ReportsBindingNavigatorSaveItem.Name = "Monthly_ReportsBindingNavigatorSaveItem"
        Me.Monthly_ReportsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Monthly_ReportsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'No_Of_Aircraft_RepairTextBox
        '
        Me.No_Of_Aircraft_RepairTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "No Of Aircraft Repair", True))
        Me.No_Of_Aircraft_RepairTextBox.Location = New System.Drawing.Point(226, 117)
        Me.No_Of_Aircraft_RepairTextBox.Name = "No_Of_Aircraft_RepairTextBox"
        Me.No_Of_Aircraft_RepairTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_Aircraft_RepairTextBox.TabIndex = 2
        '
        'Total_No_Of_ScrapTextBox
        '
        Me.Total_No_Of_ScrapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Total No Of Scrap", True))
        Me.Total_No_Of_ScrapTextBox.Location = New System.Drawing.Point(226, 143)
        Me.Total_No_Of_ScrapTextBox.Name = "Total_No_Of_ScrapTextBox"
        Me.Total_No_Of_ScrapTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_No_Of_ScrapTextBox.TabIndex = 4
        '
        'Total_Manpower_RequiredTextBox
        '
        Me.Total_Manpower_RequiredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Total Manpower Required", True))
        Me.Total_Manpower_RequiredTextBox.Location = New System.Drawing.Point(226, 169)
        Me.Total_Manpower_RequiredTextBox.Name = "Total_Manpower_RequiredTextBox"
        Me.Total_Manpower_RequiredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_Manpower_RequiredTextBox.TabIndex = 6
        '
        'Stock_Used_In_PercentTextBox
        '
        Me.Stock_Used_In_PercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Stock Used In Percent", True))
        Me.Stock_Used_In_PercentTextBox.Location = New System.Drawing.Point(226, 195)
        Me.Stock_Used_In_PercentTextBox.Name = "Stock_Used_In_PercentTextBox"
        Me.Stock_Used_In_PercentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stock_Used_In_PercentTextBox.TabIndex = 8
        '
        'Total_CostTextBox
        '
        Me.Total_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Total Cost", True))
        Me.Total_CostTextBox.Location = New System.Drawing.Point(226, 221)
        Me.Total_CostTextBox.Name = "Total_CostTextBox"
        Me.Total_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_CostTextBox.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoOfAircraftRepairDataGridViewTextBoxColumn, Me.TotalNoOfScrapDataGridViewTextBoxColumn, Me.TotalManpowerRequiredDataGridViewTextBoxColumn, Me.StockUsedInPercentDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Monthly_ReportsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(597, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(381, 225)
        Me.DataGridView1.TabIndex = 11
        '
        'NoOfAircraftRepairDataGridViewTextBoxColumn
        '
        Me.NoOfAircraftRepairDataGridViewTextBoxColumn.DataPropertyName = "No Of Aircraft Repair"
        Me.NoOfAircraftRepairDataGridViewTextBoxColumn.HeaderText = "No Of Aircraft Repair"
        Me.NoOfAircraftRepairDataGridViewTextBoxColumn.Name = "NoOfAircraftRepairDataGridViewTextBoxColumn"
        '
        'TotalNoOfScrapDataGridViewTextBoxColumn
        '
        Me.TotalNoOfScrapDataGridViewTextBoxColumn.DataPropertyName = "Total No Of Scrap"
        Me.TotalNoOfScrapDataGridViewTextBoxColumn.HeaderText = "Total No Of Scrap"
        Me.TotalNoOfScrapDataGridViewTextBoxColumn.Name = "TotalNoOfScrapDataGridViewTextBoxColumn"
        '
        'TotalManpowerRequiredDataGridViewTextBoxColumn
        '
        Me.TotalManpowerRequiredDataGridViewTextBoxColumn.DataPropertyName = "Total Manpower Required"
        Me.TotalManpowerRequiredDataGridViewTextBoxColumn.HeaderText = "Total Manpower Required"
        Me.TotalManpowerRequiredDataGridViewTextBoxColumn.Name = "TotalManpowerRequiredDataGridViewTextBoxColumn"
        '
        'StockUsedInPercentDataGridViewTextBoxColumn
        '
        Me.StockUsedInPercentDataGridViewTextBoxColumn.DataPropertyName = "Stock Used In Percent"
        Me.StockUsedInPercentDataGridViewTextBoxColumn.HeaderText = "Stock Used In Percent"
        Me.StockUsedInPercentDataGridViewTextBoxColumn.Name = "StockUsedInPercentDataGridViewTextBoxColumn"
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(187, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(70, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(187, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 40)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Dynamic Monthly Reports"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.lblFinalCost)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Location = New System.Drawing.Point(469, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 460)
        Me.Panel1.TabIndex = 33
        Me.Panel1.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(203, 235)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 34)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Print"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(55, 235)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 34)
        Me.Button7.TabIndex = 31
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'lblFinalCost
        '
        Me.lblFinalCost.AutoSize = True
        Me.lblFinalCost.Location = New System.Drawing.Point(369, 153)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(7, 15)
        Me.lblFinalCost.TabIndex = 30
        Me.lblFinalCost.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(369, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 15)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(369, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 15)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(369, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 15)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Label22"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(369, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 15)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Total Cost"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(295, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(295, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(295, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(295, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 15)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(227, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(227, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Quantity"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(197, 414)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 29)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Generate Bill"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "No Of Aircraft Repair", True))
        Me.TextBox1.Location = New System.Drawing.Point(352, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Total No Of Scrap", True))
        Me.TextBox2.Location = New System.Drawing.Point(352, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Total Manpower Required", True))
        Me.TextBox3.Location = New System.Drawing.Point(352, 169)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Monthly_ReportsBindingSource, "Stock Used In Percent", True))
        Me.TextBox4.Location = New System.Drawing.Point(352, 195)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cost"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(301, 355)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 37)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(70, 414)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(121, 29)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Generate Report"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'MonthReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(990, 484)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(No_Of_Aircraft_RepairLabel)
        Me.Controls.Add(Me.No_Of_Aircraft_RepairTextBox)
        Me.Controls.Add(Total_No_Of_ScrapLabel)
        Me.Controls.Add(Me.Total_No_Of_ScrapTextBox)
        Me.Controls.Add(Total_Manpower_RequiredLabel)
        Me.Controls.Add(Me.Total_Manpower_RequiredTextBox)
        Me.Controls.Add(Stock_Used_In_PercentLabel)
        Me.Controls.Add(Me.Stock_Used_In_PercentTextBox)
        Me.Controls.Add(Total_CostLabel)
        Me.Controls.Add(Me.Total_CostTextBox)
        Me.Controls.Add(Me.Monthly_ReportsBindingNavigator)
        Me.Name = "MonthReports"
        Me.Text = "MonthReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monthly_ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monthly_ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Monthly_ReportsBindingNavigator.ResumeLayout(False)
        Me.Monthly_ReportsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Monthly_ReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Monthly_ReportsTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Monthly_ReportsTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Monthly_ReportsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Monthly_ReportsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents No_Of_Aircraft_RepairTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_No_Of_ScrapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_Manpower_RequiredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_Used_In_PercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NoOfAircraftRepairDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNoOfScrapDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalManpowerRequiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockUsedInPercentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFinalCost As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
