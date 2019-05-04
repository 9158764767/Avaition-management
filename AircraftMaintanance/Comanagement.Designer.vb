<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comanagement
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
        Dim General_ManagerLabel As System.Windows.Forms.Label
        Dim Quality_AnalystLabel As System.Windows.Forms.Label
        Dim Maintanance_DirectorLabel As System.Windows.Forms.Label
        Dim Technical_Quality_OfficerLabel As System.Windows.Forms.Label
        Dim Logistics_ManagerLabel As System.Windows.Forms.Label
        Dim Chief_Of_MaintananceLabel As System.Windows.Forms.Label
        Dim Chief_EngineerLabel As System.Windows.Forms.Label
        Dim TechniciansLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comanagement))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Company_ManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Company_ManagementTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Company_ManagementTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Company_ManagementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Company_ManagementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.General_ManagerTextBox = New System.Windows.Forms.TextBox
        Me.Quality_AnalystTextBox = New System.Windows.Forms.TextBox
        Me.Maintanance_DirectorTextBox = New System.Windows.Forms.TextBox
        Me.Technical_Quality_OfficerTextBox = New System.Windows.Forms.TextBox
        Me.Logistics_ManagerTextBox = New System.Windows.Forms.TextBox
        Me.Chief_Of_MaintananceTextBox = New System.Windows.Forms.TextBox
        Me.Chief_EngineerTextBox = New System.Windows.Forms.TextBox
        Me.TechniciansTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GeneralManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QualityAnalystDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaintananceDirectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TechnicalQualityOfficerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LogisticsManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChiefOfMaintananceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChiefEngineerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TechniciansDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        General_ManagerLabel = New System.Windows.Forms.Label
        Quality_AnalystLabel = New System.Windows.Forms.Label
        Maintanance_DirectorLabel = New System.Windows.Forms.Label
        Technical_Quality_OfficerLabel = New System.Windows.Forms.Label
        Logistics_ManagerLabel = New System.Windows.Forms.Label
        Chief_Of_MaintananceLabel = New System.Windows.Forms.Label
        Chief_EngineerLabel = New System.Windows.Forms.Label
        TechniciansLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_ManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_ManagementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Company_ManagementBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'General_ManagerLabel
        '
        General_ManagerLabel.AutoSize = True
        General_ManagerLabel.BackColor = System.Drawing.Color.FloralWhite
        General_ManagerLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        General_ManagerLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        General_ManagerLabel.Location = New System.Drawing.Point(272, 95)
        General_ManagerLabel.Name = "General_ManagerLabel"
        General_ManagerLabel.Size = New System.Drawing.Size(151, 19)
        General_ManagerLabel.TabIndex = 1
        General_ManagerLabel.Text = "General Manager:"
        '
        'Quality_AnalystLabel
        '
        Quality_AnalystLabel.AutoSize = True
        Quality_AnalystLabel.BackColor = System.Drawing.Color.FloralWhite
        Quality_AnalystLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quality_AnalystLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Quality_AnalystLabel.Location = New System.Drawing.Point(272, 121)
        Quality_AnalystLabel.Name = "Quality_AnalystLabel"
        Quality_AnalystLabel.Size = New System.Drawing.Size(144, 19)
        Quality_AnalystLabel.TabIndex = 3
        Quality_AnalystLabel.Text = "Quality Analyst:"
        '
        'Maintanance_DirectorLabel
        '
        Maintanance_DirectorLabel.AutoSize = True
        Maintanance_DirectorLabel.BackColor = System.Drawing.Color.FloralWhite
        Maintanance_DirectorLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Maintanance_DirectorLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Maintanance_DirectorLabel.Location = New System.Drawing.Point(272, 147)
        Maintanance_DirectorLabel.Name = "Maintanance_DirectorLabel"
        Maintanance_DirectorLabel.Size = New System.Drawing.Size(191, 19)
        Maintanance_DirectorLabel.TabIndex = 5
        Maintanance_DirectorLabel.Text = "Maintanance Director:"
        '
        'Technical_Quality_OfficerLabel
        '
        Technical_Quality_OfficerLabel.AutoSize = True
        Technical_Quality_OfficerLabel.BackColor = System.Drawing.Color.FloralWhite
        Technical_Quality_OfficerLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Technical_Quality_OfficerLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Technical_Quality_OfficerLabel.Location = New System.Drawing.Point(272, 173)
        Technical_Quality_OfficerLabel.Name = "Technical_Quality_OfficerLabel"
        Technical_Quality_OfficerLabel.Size = New System.Drawing.Size(219, 19)
        Technical_Quality_OfficerLabel.TabIndex = 7
        Technical_Quality_OfficerLabel.Text = "Technical Quality Officer:"
        '
        'Logistics_ManagerLabel
        '
        Logistics_ManagerLabel.AutoSize = True
        Logistics_ManagerLabel.BackColor = System.Drawing.Color.FloralWhite
        Logistics_ManagerLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Logistics_ManagerLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Logistics_ManagerLabel.Location = New System.Drawing.Point(272, 199)
        Logistics_ManagerLabel.Name = "Logistics_ManagerLabel"
        Logistics_ManagerLabel.Size = New System.Drawing.Size(159, 19)
        Logistics_ManagerLabel.TabIndex = 9
        Logistics_ManagerLabel.Text = "Logistics Manager:"
        '
        'Chief_Of_MaintananceLabel
        '
        Chief_Of_MaintananceLabel.AutoSize = True
        Chief_Of_MaintananceLabel.BackColor = System.Drawing.Color.FloralWhite
        Chief_Of_MaintananceLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chief_Of_MaintananceLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Chief_Of_MaintananceLabel.Location = New System.Drawing.Point(272, 225)
        Chief_Of_MaintananceLabel.Name = "Chief_Of_MaintananceLabel"
        Chief_Of_MaintananceLabel.Size = New System.Drawing.Size(188, 19)
        Chief_Of_MaintananceLabel.TabIndex = 11
        Chief_Of_MaintananceLabel.Text = "Chief Of Maintanance:"
        '
        'Chief_EngineerLabel
        '
        Chief_EngineerLabel.AutoSize = True
        Chief_EngineerLabel.BackColor = System.Drawing.Color.FloralWhite
        Chief_EngineerLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chief_EngineerLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Chief_EngineerLabel.Location = New System.Drawing.Point(272, 251)
        Chief_EngineerLabel.Name = "Chief_EngineerLabel"
        Chief_EngineerLabel.Size = New System.Drawing.Size(135, 19)
        Chief_EngineerLabel.TabIndex = 13
        Chief_EngineerLabel.Text = "Chief Engineer:"
        '
        'TechniciansLabel
        '
        TechniciansLabel.AutoSize = True
        TechniciansLabel.BackColor = System.Drawing.Color.FloralWhite
        TechniciansLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TechniciansLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        TechniciansLabel.Location = New System.Drawing.Point(272, 277)
        TechniciansLabel.Name = "TechniciansLabel"
        TechniciansLabel.Size = New System.Drawing.Size(111, 19)
        TechniciansLabel.TabIndex = 15
        TechniciansLabel.Text = "Technicians:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_ManagementBindingSource
        '
        Me.Company_ManagementBindingSource.DataMember = "Company Management"
        Me.Company_ManagementBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Company_ManagementTableAdapter
        '
        Me.Company_ManagementTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.BranchesTableAdapter = Nothing
        Me.TableAdapterManager.Company_ManagementTableAdapter = Me.Company_ManagementTableAdapter
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
        'Company_ManagementBindingNavigator
        '
        Me.Company_ManagementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Company_ManagementBindingNavigator.BindingSource = Me.Company_ManagementBindingSource
        Me.Company_ManagementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Company_ManagementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Company_ManagementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Company_ManagementBindingNavigatorSaveItem})
        Me.Company_ManagementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Company_ManagementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Company_ManagementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Company_ManagementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Company_ManagementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Company_ManagementBindingNavigator.Name = "Company_ManagementBindingNavigator"
        Me.Company_ManagementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Company_ManagementBindingNavigator.Size = New System.Drawing.Size(722, 26)
        Me.Company_ManagementBindingNavigator.TabIndex = 0
        Me.Company_ManagementBindingNavigator.Text = "BindingNavigator1"
        Me.Company_ManagementBindingNavigator.Visible = False
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
        'Company_ManagementBindingNavigatorSaveItem
        '
        Me.Company_ManagementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Company_ManagementBindingNavigatorSaveItem.Image = CType(resources.GetObject("Company_ManagementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Company_ManagementBindingNavigatorSaveItem.Name = "Company_ManagementBindingNavigatorSaveItem"
        Me.Company_ManagementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Company_ManagementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'General_ManagerTextBox
        '
        Me.General_ManagerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "General Manager", True))
        Me.General_ManagerTextBox.Location = New System.Drawing.Point(504, 94)
        Me.General_ManagerTextBox.Name = "General_ManagerTextBox"
        Me.General_ManagerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.General_ManagerTextBox.TabIndex = 2
        '
        'Quality_AnalystTextBox
        '
        Me.Quality_AnalystTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Quality Analyst", True))
        Me.Quality_AnalystTextBox.Location = New System.Drawing.Point(504, 120)
        Me.Quality_AnalystTextBox.Name = "Quality_AnalystTextBox"
        Me.Quality_AnalystTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Quality_AnalystTextBox.TabIndex = 4
        '
        'Maintanance_DirectorTextBox
        '
        Me.Maintanance_DirectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Maintanance Director", True))
        Me.Maintanance_DirectorTextBox.Location = New System.Drawing.Point(504, 146)
        Me.Maintanance_DirectorTextBox.Name = "Maintanance_DirectorTextBox"
        Me.Maintanance_DirectorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Maintanance_DirectorTextBox.TabIndex = 6
        '
        'Technical_Quality_OfficerTextBox
        '
        Me.Technical_Quality_OfficerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Technical Quality Officer", True))
        Me.Technical_Quality_OfficerTextBox.Location = New System.Drawing.Point(504, 172)
        Me.Technical_Quality_OfficerTextBox.Name = "Technical_Quality_OfficerTextBox"
        Me.Technical_Quality_OfficerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Technical_Quality_OfficerTextBox.TabIndex = 8
        '
        'Logistics_ManagerTextBox
        '
        Me.Logistics_ManagerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Logistics Manager", True))
        Me.Logistics_ManagerTextBox.Location = New System.Drawing.Point(504, 198)
        Me.Logistics_ManagerTextBox.Name = "Logistics_ManagerTextBox"
        Me.Logistics_ManagerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Logistics_ManagerTextBox.TabIndex = 10
        '
        'Chief_Of_MaintananceTextBox
        '
        Me.Chief_Of_MaintananceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Chief Of Maintanance", True))
        Me.Chief_Of_MaintananceTextBox.Location = New System.Drawing.Point(504, 224)
        Me.Chief_Of_MaintananceTextBox.Name = "Chief_Of_MaintananceTextBox"
        Me.Chief_Of_MaintananceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Chief_Of_MaintananceTextBox.TabIndex = 12
        '
        'Chief_EngineerTextBox
        '
        Me.Chief_EngineerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Chief Engineer", True))
        Me.Chief_EngineerTextBox.Location = New System.Drawing.Point(504, 250)
        Me.Chief_EngineerTextBox.Name = "Chief_EngineerTextBox"
        Me.Chief_EngineerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Chief_EngineerTextBox.TabIndex = 14
        '
        'TechniciansTextBox
        '
        Me.TechniciansTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_ManagementBindingSource, "Technicians", True))
        Me.TechniciansTextBox.Location = New System.Drawing.Point(504, 276)
        Me.TechniciansTextBox.Name = "TechniciansTextBox"
        Me.TechniciansTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TechniciansTextBox.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GeneralManagerDataGridViewTextBoxColumn, Me.QualityAnalystDataGridViewTextBoxColumn, Me.MaintananceDirectorDataGridViewTextBoxColumn, Me.TechnicalQualityOfficerDataGridViewTextBoxColumn, Me.LogisticsManagerDataGridViewTextBoxColumn, Me.ChiefOfMaintananceDataGridViewTextBoxColumn, Me.ChiefEngineerDataGridViewTextBoxColumn, Me.TechniciansDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Company_ManagementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(653, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(425, 276)
        Me.DataGridView1.TabIndex = 17
        '
        'GeneralManagerDataGridViewTextBoxColumn
        '
        Me.GeneralManagerDataGridViewTextBoxColumn.DataPropertyName = "General Manager"
        Me.GeneralManagerDataGridViewTextBoxColumn.HeaderText = "General Manager"
        Me.GeneralManagerDataGridViewTextBoxColumn.Name = "GeneralManagerDataGridViewTextBoxColumn"
        '
        'QualityAnalystDataGridViewTextBoxColumn
        '
        Me.QualityAnalystDataGridViewTextBoxColumn.DataPropertyName = "Quality Analyst"
        Me.QualityAnalystDataGridViewTextBoxColumn.HeaderText = "Quality Analyst"
        Me.QualityAnalystDataGridViewTextBoxColumn.Name = "QualityAnalystDataGridViewTextBoxColumn"
        '
        'MaintananceDirectorDataGridViewTextBoxColumn
        '
        Me.MaintananceDirectorDataGridViewTextBoxColumn.DataPropertyName = "Maintanance Director"
        Me.MaintananceDirectorDataGridViewTextBoxColumn.HeaderText = "Maintanance Director"
        Me.MaintananceDirectorDataGridViewTextBoxColumn.Name = "MaintananceDirectorDataGridViewTextBoxColumn"
        '
        'TechnicalQualityOfficerDataGridViewTextBoxColumn
        '
        Me.TechnicalQualityOfficerDataGridViewTextBoxColumn.DataPropertyName = "Technical Quality Officer"
        Me.TechnicalQualityOfficerDataGridViewTextBoxColumn.HeaderText = "Technical Quality Officer"
        Me.TechnicalQualityOfficerDataGridViewTextBoxColumn.Name = "TechnicalQualityOfficerDataGridViewTextBoxColumn"
        '
        'LogisticsManagerDataGridViewTextBoxColumn
        '
        Me.LogisticsManagerDataGridViewTextBoxColumn.DataPropertyName = "Logistics Manager"
        Me.LogisticsManagerDataGridViewTextBoxColumn.HeaderText = "Logistics Manager"
        Me.LogisticsManagerDataGridViewTextBoxColumn.Name = "LogisticsManagerDataGridViewTextBoxColumn"
        '
        'ChiefOfMaintananceDataGridViewTextBoxColumn
        '
        Me.ChiefOfMaintananceDataGridViewTextBoxColumn.DataPropertyName = "Chief Of Maintanance"
        Me.ChiefOfMaintananceDataGridViewTextBoxColumn.HeaderText = "Chief Of Maintanance"
        Me.ChiefOfMaintananceDataGridViewTextBoxColumn.Name = "ChiefOfMaintananceDataGridViewTextBoxColumn"
        '
        'ChiefEngineerDataGridViewTextBoxColumn
        '
        Me.ChiefEngineerDataGridViewTextBoxColumn.DataPropertyName = "Chief Engineer"
        Me.ChiefEngineerDataGridViewTextBoxColumn.HeaderText = "Chief Engineer"
        Me.ChiefEngineerDataGridViewTextBoxColumn.Name = "ChiefEngineerDataGridViewTextBoxColumn"
        '
        'TechniciansDataGridViewTextBoxColumn
        '
        Me.TechniciansDataGridViewTextBoxColumn.DataPropertyName = "Technicians"
        Me.TechniciansDataGridViewTextBoxColumn.HeaderText = "Technicians"
        Me.TechniciansDataGridViewTextBoxColumn.Name = "TechniciansDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Cooper Black", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(470, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 36)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Cooper Black", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(353, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 36)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Cooper Black", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(470, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 37)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(353, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Company Management"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Cooper Black", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(406, 427)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 37)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Comanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1013, 487)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(General_ManagerLabel)
        Me.Controls.Add(Me.General_ManagerTextBox)
        Me.Controls.Add(Quality_AnalystLabel)
        Me.Controls.Add(Me.Quality_AnalystTextBox)
        Me.Controls.Add(Maintanance_DirectorLabel)
        Me.Controls.Add(Me.Maintanance_DirectorTextBox)
        Me.Controls.Add(Technical_Quality_OfficerLabel)
        Me.Controls.Add(Me.Technical_Quality_OfficerTextBox)
        Me.Controls.Add(Logistics_ManagerLabel)
        Me.Controls.Add(Me.Logistics_ManagerTextBox)
        Me.Controls.Add(Chief_Of_MaintananceLabel)
        Me.Controls.Add(Me.Chief_Of_MaintananceTextBox)
        Me.Controls.Add(Chief_EngineerLabel)
        Me.Controls.Add(Me.Chief_EngineerTextBox)
        Me.Controls.Add(TechniciansLabel)
        Me.Controls.Add(Me.TechniciansTextBox)
        Me.Controls.Add(Me.Company_ManagementBindingNavigator)
        Me.Name = "Comanagement"
        Me.Text = "Comanagement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_ManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_ManagementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Company_ManagementBindingNavigator.ResumeLayout(False)
        Me.Company_ManagementBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Company_ManagementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Company_ManagementTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Company_ManagementTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Company_ManagementBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Company_ManagementBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents General_ManagerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Quality_AnalystTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maintanance_DirectorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Technical_Quality_OfficerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logistics_ManagerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Chief_Of_MaintananceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Chief_EngineerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TechniciansTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GeneralManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QualityAnalystDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaintananceDirectorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechnicalQualityOfficerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogisticsManagerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChiefOfMaintananceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChiefEngineerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechniciansDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
