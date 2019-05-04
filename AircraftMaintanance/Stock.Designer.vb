<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim Cocpit_PartsLabel As System.Windows.Forms.Label
        Dim EnginesLabel As System.Windows.Forms.Label
        Dim StabilizersLabel As System.Windows.Forms.Label
        Dim WingsLabel As System.Windows.Forms.Label
        Dim ElevatorsLabel As System.Windows.Forms.Label
        Dim Landing_GairsLabel As System.Windows.Forms.Label
        Dim Painting_colorsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Available_StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Available_StockTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Available_StockTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Available_StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Available_StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Cocpit_PartsTextBox = New System.Windows.Forms.TextBox
        Me.EnginesTextBox = New System.Windows.Forms.TextBox
        Me.StabilizersTextBox = New System.Windows.Forms.TextBox
        Me.WingsTextBox = New System.Windows.Forms.TextBox
        Me.ElevatorsTextBox = New System.Windows.Forms.TextBox
        Me.Landing_GairsTextBox = New System.Windows.Forms.TextBox
        Me.Painting_colorsTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CocpitPartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnginesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StabilizersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WingsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ElevatorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LandingGairsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaintingColorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Cocpit_PartsLabel = New System.Windows.Forms.Label
        EnginesLabel = New System.Windows.Forms.Label
        StabilizersLabel = New System.Windows.Forms.Label
        WingsLabel = New System.Windows.Forms.Label
        ElevatorsLabel = New System.Windows.Forms.Label
        Landing_GairsLabel = New System.Windows.Forms.Label
        Painting_colorsLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Available_StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Available_StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Available_StockBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cocpit_PartsLabel
        '
        Cocpit_PartsLabel.AutoSize = True
        Cocpit_PartsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cocpit_PartsLabel.Location = New System.Drawing.Point(12, 97)
        Cocpit_PartsLabel.Name = "Cocpit_PartsLabel"
        Cocpit_PartsLabel.Size = New System.Drawing.Size(91, 13)
        Cocpit_PartsLabel.TabIndex = 1
        Cocpit_PartsLabel.Text = "Cocpit Parts:"
        '
        'EnginesLabel
        '
        EnginesLabel.AutoSize = True
        EnginesLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnginesLabel.Location = New System.Drawing.Point(12, 123)
        EnginesLabel.Name = "EnginesLabel"
        EnginesLabel.Size = New System.Drawing.Size(59, 13)
        EnginesLabel.TabIndex = 3
        EnginesLabel.Text = "Engines:"
        '
        'StabilizersLabel
        '
        StabilizersLabel.AutoSize = True
        StabilizersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StabilizersLabel.Location = New System.Drawing.Point(12, 149)
        StabilizersLabel.Name = "StabilizersLabel"
        StabilizersLabel.Size = New System.Drawing.Size(80, 13)
        StabilizersLabel.TabIndex = 5
        StabilizersLabel.Text = "Stabilizers:"
        '
        'WingsLabel
        '
        WingsLabel.AutoSize = True
        WingsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WingsLabel.Location = New System.Drawing.Point(12, 175)
        WingsLabel.Name = "WingsLabel"
        WingsLabel.Size = New System.Drawing.Size(48, 13)
        WingsLabel.TabIndex = 7
        WingsLabel.Text = "Wings:"
        '
        'ElevatorsLabel
        '
        ElevatorsLabel.AutoSize = True
        ElevatorsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElevatorsLabel.Location = New System.Drawing.Point(12, 201)
        ElevatorsLabel.Name = "ElevatorsLabel"
        ElevatorsLabel.Size = New System.Drawing.Size(75, 13)
        ElevatorsLabel.TabIndex = 9
        ElevatorsLabel.Text = "Elevators:"
        '
        'Landing_GairsLabel
        '
        Landing_GairsLabel.AutoSize = True
        Landing_GairsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Landing_GairsLabel.Location = New System.Drawing.Point(12, 227)
        Landing_GairsLabel.Name = "Landing_GairsLabel"
        Landing_GairsLabel.Size = New System.Drawing.Size(99, 13)
        Landing_GairsLabel.TabIndex = 11
        Landing_GairsLabel.Text = "Landing Gairs:"
        '
        'Painting_colorsLabel
        '
        Painting_colorsLabel.AutoSize = True
        Painting_colorsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Painting_colorsLabel.Location = New System.Drawing.Point(12, 253)
        Painting_colorsLabel.Name = "Painting_colorsLabel"
        Painting_colorsLabel.Size = New System.Drawing.Size(110, 13)
        Painting_colorsLabel.TabIndex = 13
        Painting_colorsLabel.Text = "Painting colors:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Available_StockBindingSource
        '
        Me.Available_StockBindingSource.DataMember = "Available Stock"
        Me.Available_StockBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Available_StockTableAdapter
        '
        Me.Available_StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Me.Available_StockTableAdapter
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
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Available_StockBindingNavigator
        '
        Me.Available_StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Available_StockBindingNavigator.BindingSource = Me.Available_StockBindingSource
        Me.Available_StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Available_StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Available_StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Available_StockBindingNavigatorSaveItem})
        Me.Available_StockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Available_StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Available_StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Available_StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Available_StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Available_StockBindingNavigator.Name = "Available_StockBindingNavigator"
        Me.Available_StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Available_StockBindingNavigator.Size = New System.Drawing.Size(661, 26)
        Me.Available_StockBindingNavigator.TabIndex = 0
        Me.Available_StockBindingNavigator.Text = "BindingNavigator1"
        Me.Available_StockBindingNavigator.Visible = False
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
        'Available_StockBindingNavigatorSaveItem
        '
        Me.Available_StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Available_StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("Available_StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Available_StockBindingNavigatorSaveItem.Name = "Available_StockBindingNavigatorSaveItem"
        Me.Available_StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Available_StockBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cocpit_PartsTextBox
        '
        Me.Cocpit_PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Cocpit Parts", True))
        Me.Cocpit_PartsTextBox.Location = New System.Drawing.Point(130, 93)
        Me.Cocpit_PartsTextBox.Name = "Cocpit_PartsTextBox"
        Me.Cocpit_PartsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cocpit_PartsTextBox.TabIndex = 2
        '
        'EnginesTextBox
        '
        Me.EnginesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Engines", True))
        Me.EnginesTextBox.Location = New System.Drawing.Point(130, 119)
        Me.EnginesTextBox.Name = "EnginesTextBox"
        Me.EnginesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnginesTextBox.TabIndex = 4
        '
        'StabilizersTextBox
        '
        Me.StabilizersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Stabilizers", True))
        Me.StabilizersTextBox.Location = New System.Drawing.Point(130, 145)
        Me.StabilizersTextBox.Name = "StabilizersTextBox"
        Me.StabilizersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StabilizersTextBox.TabIndex = 6
        '
        'WingsTextBox
        '
        Me.WingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Wings", True))
        Me.WingsTextBox.Location = New System.Drawing.Point(130, 171)
        Me.WingsTextBox.Name = "WingsTextBox"
        Me.WingsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WingsTextBox.TabIndex = 8
        '
        'ElevatorsTextBox
        '
        Me.ElevatorsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Elevators", True))
        Me.ElevatorsTextBox.Location = New System.Drawing.Point(130, 197)
        Me.ElevatorsTextBox.Name = "ElevatorsTextBox"
        Me.ElevatorsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ElevatorsTextBox.TabIndex = 10
        '
        'Landing_GairsTextBox
        '
        Me.Landing_GairsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Landing Gairs", True))
        Me.Landing_GairsTextBox.Location = New System.Drawing.Point(130, 223)
        Me.Landing_GairsTextBox.Name = "Landing_GairsTextBox"
        Me.Landing_GairsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Landing_GairsTextBox.TabIndex = 12
        '
        'Painting_colorsTextBox
        '
        Me.Painting_colorsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Available_StockBindingSource, "Painting colors", True))
        Me.Painting_colorsTextBox.Location = New System.Drawing.Point(130, 249)
        Me.Painting_colorsTextBox.Name = "Painting_colorsTextBox"
        Me.Painting_colorsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Painting_colorsTextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CocpitPartsDataGridViewTextBoxColumn, Me.EnginesDataGridViewTextBoxColumn, Me.StabilizersDataGridViewTextBoxColumn, Me.WingsDataGridViewTextBoxColumn, Me.ElevatorsDataGridViewTextBoxColumn, Me.LandingGairsDataGridViewTextBoxColumn, Me.PaintingColorsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Available_StockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(306, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 303)
        Me.DataGridView1.TabIndex = 15
        '
        'CocpitPartsDataGridViewTextBoxColumn
        '
        Me.CocpitPartsDataGridViewTextBoxColumn.DataPropertyName = "Cocpit Parts"
        Me.CocpitPartsDataGridViewTextBoxColumn.HeaderText = "Cocpit Parts"
        Me.CocpitPartsDataGridViewTextBoxColumn.Name = "CocpitPartsDataGridViewTextBoxColumn"
        '
        'EnginesDataGridViewTextBoxColumn
        '
        Me.EnginesDataGridViewTextBoxColumn.DataPropertyName = "Engines"
        Me.EnginesDataGridViewTextBoxColumn.HeaderText = "Engines"
        Me.EnginesDataGridViewTextBoxColumn.Name = "EnginesDataGridViewTextBoxColumn"
        '
        'StabilizersDataGridViewTextBoxColumn
        '
        Me.StabilizersDataGridViewTextBoxColumn.DataPropertyName = "Stabilizers"
        Me.StabilizersDataGridViewTextBoxColumn.HeaderText = "Stabilizers"
        Me.StabilizersDataGridViewTextBoxColumn.Name = "StabilizersDataGridViewTextBoxColumn"
        '
        'WingsDataGridViewTextBoxColumn
        '
        Me.WingsDataGridViewTextBoxColumn.DataPropertyName = "Wings"
        Me.WingsDataGridViewTextBoxColumn.HeaderText = "Wings"
        Me.WingsDataGridViewTextBoxColumn.Name = "WingsDataGridViewTextBoxColumn"
        '
        'ElevatorsDataGridViewTextBoxColumn
        '
        Me.ElevatorsDataGridViewTextBoxColumn.DataPropertyName = "Elevators"
        Me.ElevatorsDataGridViewTextBoxColumn.HeaderText = "Elevators"
        Me.ElevatorsDataGridViewTextBoxColumn.Name = "ElevatorsDataGridViewTextBoxColumn"
        '
        'LandingGairsDataGridViewTextBoxColumn
        '
        Me.LandingGairsDataGridViewTextBoxColumn.DataPropertyName = "Landing Gairs"
        Me.LandingGairsDataGridViewTextBoxColumn.HeaderText = "Landing Gairs"
        Me.LandingGairsDataGridViewTextBoxColumn.Name = "LandingGairsDataGridViewTextBoxColumn"
        '
        'PaintingColorsDataGridViewTextBoxColumn
        '
        Me.PaintingColorsDataGridViewTextBoxColumn.DataPropertyName = "Painting colors"
        Me.PaintingColorsDataGridViewTextBoxColumn.HeaderText = "Painting colors"
        Me.PaintingColorsDataGridViewTextBoxColumn.Name = "PaintingColorsDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FloralWhite
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(130, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FloralWhite
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(13, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FloralWhite
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(130, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FloralWhite
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Stock Information"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FloralWhite
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(68, 419)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(920, 468)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Cocpit_PartsLabel)
        Me.Controls.Add(Me.Cocpit_PartsTextBox)
        Me.Controls.Add(EnginesLabel)
        Me.Controls.Add(Me.EnginesTextBox)
        Me.Controls.Add(StabilizersLabel)
        Me.Controls.Add(Me.StabilizersTextBox)
        Me.Controls.Add(WingsLabel)
        Me.Controls.Add(Me.WingsTextBox)
        Me.Controls.Add(ElevatorsLabel)
        Me.Controls.Add(Me.ElevatorsTextBox)
        Me.Controls.Add(Landing_GairsLabel)
        Me.Controls.Add(Me.Landing_GairsTextBox)
        Me.Controls.Add(Painting_colorsLabel)
        Me.Controls.Add(Me.Painting_colorsTextBox)
        Me.Controls.Add(Me.Available_StockBindingNavigator)
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Available_StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Available_StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Available_StockBindingNavigator.ResumeLayout(False)
        Me.Available_StockBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Available_StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Available_StockTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Available_StockTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Available_StockBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Available_StockBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cocpit_PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnginesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StabilizersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ElevatorsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Landing_GairsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Painting_colorsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CocpitPartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnginesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StabilizersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WingsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElevatorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandingGairsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaintingColorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
