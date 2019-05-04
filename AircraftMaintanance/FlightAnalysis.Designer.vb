<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlightAnalysis
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
        Dim Flight_nameLabel As System.Windows.Forms.Label
        Dim Cocpit_CheckLabel As System.Windows.Forms.Label
        Dim Fusalage_CheckLabel As System.Windows.Forms.Label
        Dim Engines_CheckLabel As System.Windows.Forms.Label
        Dim Fuel_Tank_CheckLabel As System.Windows.Forms.Label
        Dim Stabilizers_ChectLabel As System.Windows.Forms.Label
        Dim Interior_CheckLabel As System.Windows.Forms.Label
        Dim Elevators_CheckLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlightAnalysis))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Flight_AnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flight_AnalysisTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Flight_AnalysisTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Flight_AnalysisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Flight_AnalysisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Flight_nameTextBox = New System.Windows.Forms.TextBox
        Me.Cocpit_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.Fusalage_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.Engines_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.Fuel_Tank_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.Stabilizers_ChectCheckBox = New System.Windows.Forms.CheckBox
        Me.Interior_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.Elevators_CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FlightNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CocpitCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FusalageCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EnginesCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FuelTankCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.StabilizersChectDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.InteriorCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ElevatorsCheckDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Flight_nameLabel = New System.Windows.Forms.Label
        Cocpit_CheckLabel = New System.Windows.Forms.Label
        Fusalage_CheckLabel = New System.Windows.Forms.Label
        Engines_CheckLabel = New System.Windows.Forms.Label
        Fuel_Tank_CheckLabel = New System.Windows.Forms.Label
        Stabilizers_ChectLabel = New System.Windows.Forms.Label
        Interior_CheckLabel = New System.Windows.Forms.Label
        Elevators_CheckLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flight_AnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flight_AnalysisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Flight_AnalysisBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Flight_nameLabel
        '
        Flight_nameLabel.AutoSize = True
        Flight_nameLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Flight_nameLabel.Location = New System.Drawing.Point(86, 110)
        Flight_nameLabel.Name = "Flight_nameLabel"
        Flight_nameLabel.Size = New System.Drawing.Size(84, 13)
        Flight_nameLabel.TabIndex = 1
        Flight_nameLabel.Text = "Flight name:"
        '
        'Cocpit_CheckLabel
        '
        Cocpit_CheckLabel.AutoSize = True
        Cocpit_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cocpit_CheckLabel.Location = New System.Drawing.Point(86, 138)
        Cocpit_CheckLabel.Name = "Cocpit_CheckLabel"
        Cocpit_CheckLabel.Size = New System.Drawing.Size(94, 13)
        Cocpit_CheckLabel.TabIndex = 3
        Cocpit_CheckLabel.Text = "Cocpit Check:"
        '
        'Fusalage_CheckLabel
        '
        Fusalage_CheckLabel.AutoSize = True
        Fusalage_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fusalage_CheckLabel.Location = New System.Drawing.Point(86, 168)
        Fusalage_CheckLabel.Name = "Fusalage_CheckLabel"
        Fusalage_CheckLabel.Size = New System.Drawing.Size(113, 13)
        Fusalage_CheckLabel.TabIndex = 5
        Fusalage_CheckLabel.Text = "Fusalage Check:"
        '
        'Engines_CheckLabel
        '
        Engines_CheckLabel.AutoSize = True
        Engines_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Engines_CheckLabel.Location = New System.Drawing.Point(86, 198)
        Engines_CheckLabel.Name = "Engines_CheckLabel"
        Engines_CheckLabel.Size = New System.Drawing.Size(102, 13)
        Engines_CheckLabel.TabIndex = 7
        Engines_CheckLabel.Text = "Engines Check:"
        '
        'Fuel_Tank_CheckLabel
        '
        Fuel_Tank_CheckLabel.AutoSize = True
        Fuel_Tank_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fuel_Tank_CheckLabel.Location = New System.Drawing.Point(86, 228)
        Fuel_Tank_CheckLabel.Name = "Fuel_Tank_CheckLabel"
        Fuel_Tank_CheckLabel.Size = New System.Drawing.Size(116, 13)
        Fuel_Tank_CheckLabel.TabIndex = 9
        Fuel_Tank_CheckLabel.Text = "Fuel Tank Check:"
        '
        'Stabilizers_ChectLabel
        '
        Stabilizers_ChectLabel.AutoSize = True
        Stabilizers_ChectLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stabilizers_ChectLabel.Location = New System.Drawing.Point(86, 258)
        Stabilizers_ChectLabel.Name = "Stabilizers_ChectLabel"
        Stabilizers_ChectLabel.Size = New System.Drawing.Size(121, 13)
        Stabilizers_ChectLabel.TabIndex = 11
        Stabilizers_ChectLabel.Text = "Stabilizers Chect:"
        '
        'Interior_CheckLabel
        '
        Interior_CheckLabel.AutoSize = True
        Interior_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Interior_CheckLabel.Location = New System.Drawing.Point(86, 288)
        Interior_CheckLabel.Name = "Interior_CheckLabel"
        Interior_CheckLabel.Size = New System.Drawing.Size(105, 13)
        Interior_CheckLabel.TabIndex = 13
        Interior_CheckLabel.Text = "Interior Check:"
        '
        'Elevators_CheckLabel
        '
        Elevators_CheckLabel.AutoSize = True
        Elevators_CheckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Elevators_CheckLabel.Location = New System.Drawing.Point(86, 318)
        Elevators_CheckLabel.Name = "Elevators_CheckLabel"
        Elevators_CheckLabel.Size = New System.Drawing.Size(118, 13)
        Elevators_CheckLabel.TabIndex = 15
        Elevators_CheckLabel.Text = "Elevators Check:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Flight_AnalysisBindingSource
        '
        Me.Flight_AnalysisBindingSource.DataMember = "Flight Analysis"
        Me.Flight_AnalysisBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Flight_AnalysisTableAdapter
        '
        Me.Flight_AnalysisTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Flight_AnalysisTableAdapter = Me.Flight_AnalysisTableAdapter
        Me.TableAdapterManager.Hanger_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.Monthly_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Flight_AnalysisBindingNavigator
        '
        Me.Flight_AnalysisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Flight_AnalysisBindingNavigator.BindingSource = Me.Flight_AnalysisBindingSource
        Me.Flight_AnalysisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Flight_AnalysisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Flight_AnalysisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Flight_AnalysisBindingNavigatorSaveItem})
        Me.Flight_AnalysisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Flight_AnalysisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Flight_AnalysisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Flight_AnalysisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Flight_AnalysisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Flight_AnalysisBindingNavigator.Name = "Flight_AnalysisBindingNavigator"
        Me.Flight_AnalysisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Flight_AnalysisBindingNavigator.Size = New System.Drawing.Size(794, 26)
        Me.Flight_AnalysisBindingNavigator.TabIndex = 0
        Me.Flight_AnalysisBindingNavigator.Text = "BindingNavigator1"
        Me.Flight_AnalysisBindingNavigator.Visible = False
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
        'Flight_AnalysisBindingNavigatorSaveItem
        '
        Me.Flight_AnalysisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Flight_AnalysisBindingNavigatorSaveItem.Image = CType(resources.GetObject("Flight_AnalysisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Flight_AnalysisBindingNavigatorSaveItem.Name = "Flight_AnalysisBindingNavigatorSaveItem"
        Me.Flight_AnalysisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Flight_AnalysisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Flight_nameTextBox
        '
        Me.Flight_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Flight_AnalysisBindingSource, "Flight name", True))
        Me.Flight_nameTextBox.Location = New System.Drawing.Point(232, 110)
        Me.Flight_nameTextBox.Name = "Flight_nameTextBox"
        Me.Flight_nameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Flight_nameTextBox.TabIndex = 2
        '
        'Cocpit_CheckCheckBox
        '
        Me.Cocpit_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Cocpit Check", True))
        Me.Cocpit_CheckCheckBox.Location = New System.Drawing.Point(232, 136)
        Me.Cocpit_CheckCheckBox.Name = "Cocpit_CheckCheckBox"
        Me.Cocpit_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Cocpit_CheckCheckBox.TabIndex = 4
        Me.Cocpit_CheckCheckBox.Text = "Yes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Cocpit_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'Fusalage_CheckCheckBox
        '
        Me.Fusalage_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Fusalage Check", True))
        Me.Fusalage_CheckCheckBox.Location = New System.Drawing.Point(232, 166)
        Me.Fusalage_CheckCheckBox.Name = "Fusalage_CheckCheckBox"
        Me.Fusalage_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Fusalage_CheckCheckBox.TabIndex = 6
        Me.Fusalage_CheckCheckBox.Text = "Yes"
        Me.Fusalage_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'Engines_CheckCheckBox
        '
        Me.Engines_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Engines Check", True))
        Me.Engines_CheckCheckBox.Location = New System.Drawing.Point(232, 196)
        Me.Engines_CheckCheckBox.Name = "Engines_CheckCheckBox"
        Me.Engines_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Engines_CheckCheckBox.TabIndex = 8
        Me.Engines_CheckCheckBox.Text = "Yes"
        Me.Engines_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'Fuel_Tank_CheckCheckBox
        '
        Me.Fuel_Tank_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Fuel Tank Check", True))
        Me.Fuel_Tank_CheckCheckBox.Location = New System.Drawing.Point(232, 226)
        Me.Fuel_Tank_CheckCheckBox.Name = "Fuel_Tank_CheckCheckBox"
        Me.Fuel_Tank_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Fuel_Tank_CheckCheckBox.TabIndex = 10
        Me.Fuel_Tank_CheckCheckBox.Text = "Yes"
        Me.Fuel_Tank_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'Stabilizers_ChectCheckBox
        '
        Me.Stabilizers_ChectCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Stabilizers Chect", True))
        Me.Stabilizers_ChectCheckBox.Location = New System.Drawing.Point(232, 256)
        Me.Stabilizers_ChectCheckBox.Name = "Stabilizers_ChectCheckBox"
        Me.Stabilizers_ChectCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Stabilizers_ChectCheckBox.TabIndex = 12
        Me.Stabilizers_ChectCheckBox.Text = "Yes"
        Me.Stabilizers_ChectCheckBox.UseVisualStyleBackColor = True
        '
        'Interior_CheckCheckBox
        '
        Me.Interior_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Interior Check", True))
        Me.Interior_CheckCheckBox.Location = New System.Drawing.Point(232, 286)
        Me.Interior_CheckCheckBox.Name = "Interior_CheckCheckBox"
        Me.Interior_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Interior_CheckCheckBox.TabIndex = 14
        Me.Interior_CheckCheckBox.Text = "Yes"
        Me.Interior_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'Elevators_CheckCheckBox
        '
        Me.Elevators_CheckCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Flight_AnalysisBindingSource, "Elevators Check", True))
        Me.Elevators_CheckCheckBox.Location = New System.Drawing.Point(232, 316)
        Me.Elevators_CheckCheckBox.Name = "Elevators_CheckCheckBox"
        Me.Elevators_CheckCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Elevators_CheckCheckBox.TabIndex = 16
        Me.Elevators_CheckCheckBox.Text = "Yes"
        Me.Elevators_CheckCheckBox.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FlightNameDataGridViewTextBoxColumn, Me.CocpitCheckDataGridViewCheckBoxColumn, Me.FusalageCheckDataGridViewCheckBoxColumn, Me.EnginesCheckDataGridViewCheckBoxColumn, Me.FuelTankCheckDataGridViewCheckBoxColumn, Me.StabilizersChectDataGridViewCheckBoxColumn, Me.InteriorCheckDataGridViewCheckBoxColumn, Me.ElevatorsCheckDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.Flight_AnalysisBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(386, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 313)
        Me.DataGridView1.TabIndex = 17
        '
        'FlightNameDataGridViewTextBoxColumn
        '
        Me.FlightNameDataGridViewTextBoxColumn.DataPropertyName = "Flight name"
        Me.FlightNameDataGridViewTextBoxColumn.HeaderText = "Flight name"
        Me.FlightNameDataGridViewTextBoxColumn.Name = "FlightNameDataGridViewTextBoxColumn"
        '
        'CocpitCheckDataGridViewCheckBoxColumn
        '
        Me.CocpitCheckDataGridViewCheckBoxColumn.DataPropertyName = "Cocpit Check"
        Me.CocpitCheckDataGridViewCheckBoxColumn.HeaderText = "Cocpit Check"
        Me.CocpitCheckDataGridViewCheckBoxColumn.Name = "CocpitCheckDataGridViewCheckBoxColumn"
        '
        'FusalageCheckDataGridViewCheckBoxColumn
        '
        Me.FusalageCheckDataGridViewCheckBoxColumn.DataPropertyName = "Fusalage Check"
        Me.FusalageCheckDataGridViewCheckBoxColumn.HeaderText = "Fusalage Check"
        Me.FusalageCheckDataGridViewCheckBoxColumn.Name = "FusalageCheckDataGridViewCheckBoxColumn"
        '
        'EnginesCheckDataGridViewCheckBoxColumn
        '
        Me.EnginesCheckDataGridViewCheckBoxColumn.DataPropertyName = "Engines Check"
        Me.EnginesCheckDataGridViewCheckBoxColumn.HeaderText = "Engines Check"
        Me.EnginesCheckDataGridViewCheckBoxColumn.Name = "EnginesCheckDataGridViewCheckBoxColumn"
        '
        'FuelTankCheckDataGridViewCheckBoxColumn
        '
        Me.FuelTankCheckDataGridViewCheckBoxColumn.DataPropertyName = "Fuel Tank Check"
        Me.FuelTankCheckDataGridViewCheckBoxColumn.HeaderText = "Fuel Tank Check"
        Me.FuelTankCheckDataGridViewCheckBoxColumn.Name = "FuelTankCheckDataGridViewCheckBoxColumn"
        '
        'StabilizersChectDataGridViewCheckBoxColumn
        '
        Me.StabilizersChectDataGridViewCheckBoxColumn.DataPropertyName = "Stabilizers Chect"
        Me.StabilizersChectDataGridViewCheckBoxColumn.HeaderText = "Stabilizers Chect"
        Me.StabilizersChectDataGridViewCheckBoxColumn.Name = "StabilizersChectDataGridViewCheckBoxColumn"
        '
        'InteriorCheckDataGridViewCheckBoxColumn
        '
        Me.InteriorCheckDataGridViewCheckBoxColumn.DataPropertyName = "Interior Check"
        Me.InteriorCheckDataGridViewCheckBoxColumn.HeaderText = "Interior Check"
        Me.InteriorCheckDataGridViewCheckBoxColumn.Name = "InteriorCheckDataGridViewCheckBoxColumn"
        '
        'ElevatorsCheckDataGridViewCheckBoxColumn
        '
        Me.ElevatorsCheckDataGridViewCheckBoxColumn.DataPropertyName = "Elevators Check"
        Me.ElevatorsCheckDataGridViewCheckBoxColumn.HeaderText = "Elevators Check"
        Me.ElevatorsCheckDataGridViewCheckBoxColumn.Name = "ElevatorsCheckDataGridViewCheckBoxColumn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(200, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(96, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(96, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(200, 432)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 40)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Flight Analysis"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(303, 432)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FlightAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 508)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Flight_nameLabel)
        Me.Controls.Add(Me.Flight_nameTextBox)
        Me.Controls.Add(Cocpit_CheckLabel)
        Me.Controls.Add(Me.Cocpit_CheckCheckBox)
        Me.Controls.Add(Fusalage_CheckLabel)
        Me.Controls.Add(Me.Fusalage_CheckCheckBox)
        Me.Controls.Add(Engines_CheckLabel)
        Me.Controls.Add(Me.Engines_CheckCheckBox)
        Me.Controls.Add(Fuel_Tank_CheckLabel)
        Me.Controls.Add(Me.Fuel_Tank_CheckCheckBox)
        Me.Controls.Add(Stabilizers_ChectLabel)
        Me.Controls.Add(Me.Stabilizers_ChectCheckBox)
        Me.Controls.Add(Interior_CheckLabel)
        Me.Controls.Add(Me.Interior_CheckCheckBox)
        Me.Controls.Add(Elevators_CheckLabel)
        Me.Controls.Add(Me.Elevators_CheckCheckBox)
        Me.Controls.Add(Me.Flight_AnalysisBindingNavigator)
        Me.Name = "FlightAnalysis"
        Me.Text = "FlightAnalysis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flight_AnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flight_AnalysisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Flight_AnalysisBindingNavigator.ResumeLayout(False)
        Me.Flight_AnalysisBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Flight_AnalysisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_AnalysisTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Flight_AnalysisTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Flight_AnalysisBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Flight_AnalysisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Flight_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cocpit_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Fusalage_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Engines_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Fuel_Tank_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Stabilizers_ChectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Interior_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Elevators_CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FlightNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CocpitCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FusalageCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EnginesCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FuelTankCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StabilizersChectDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InteriorCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ElevatorsCheckDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
