<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequiredEquipment
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
        Dim CocpitEnclosureLabel As System.Windows.Forms.Label
        Dim SeatsLabel As System.Windows.Forms.Label
        Dim Flight_DeckLabel As System.Windows.Forms.Label
        Dim Control_ColumnLabel As System.Windows.Forms.Label
        Dim Rudder_PaddlesLabel As System.Windows.Forms.Label
        Dim Instrument_PanelLabel As System.Windows.Forms.Label
        Dim PedstalLabel As System.Windows.Forms.Label
        Dim EnginesLabel As System.Windows.Forms.Label
        Dim TurbineLabel As System.Windows.Forms.Label
        Dim WingsLabel As System.Windows.Forms.Label
        Dim Landing_GairsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequiredEquipment))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.EquipmentRequiredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentRequiredTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.EquipmentRequiredTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.EquipmentRequiredBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EquipmentRequiredBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CocpitEnclosureTextBox = New System.Windows.Forms.TextBox
        Me.SeatsTextBox = New System.Windows.Forms.TextBox
        Me.Flight_DeckTextBox = New System.Windows.Forms.TextBox
        Me.Control_ColumnTextBox = New System.Windows.Forms.TextBox
        Me.Rudder_PaddlesTextBox = New System.Windows.Forms.TextBox
        Me.Instrument_PanelTextBox = New System.Windows.Forms.TextBox
        Me.PedstalTextBox = New System.Windows.Forms.TextBox
        Me.EnginesTextBox = New System.Windows.Forms.TextBox
        Me.TurbineTextBox = New System.Windows.Forms.TextBox
        Me.WingsTextBox = New System.Windows.Forms.TextBox
        Me.Landing_GairsTextBox = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CocpitEnclosureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FlightDeckDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ControlColumnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RudderPaddlesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InstrumentPanelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PedstalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnginesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurbineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WingsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LandingGairsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        CocpitEnclosureLabel = New System.Windows.Forms.Label
        SeatsLabel = New System.Windows.Forms.Label
        Flight_DeckLabel = New System.Windows.Forms.Label
        Control_ColumnLabel = New System.Windows.Forms.Label
        Rudder_PaddlesLabel = New System.Windows.Forms.Label
        Instrument_PanelLabel = New System.Windows.Forms.Label
        PedstalLabel = New System.Windows.Forms.Label
        EnginesLabel = New System.Windows.Forms.Label
        TurbineLabel = New System.Windows.Forms.Label
        WingsLabel = New System.Windows.Forms.Label
        Landing_GairsLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentRequiredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentRequiredBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipmentRequiredBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CocpitEnclosureLabel
        '
        CocpitEnclosureLabel.AutoSize = True
        CocpitEnclosureLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CocpitEnclosureLabel.Location = New System.Drawing.Point(117, 82)
        CocpitEnclosureLabel.Name = "CocpitEnclosureLabel"
        CocpitEnclosureLabel.Size = New System.Drawing.Size(122, 13)
        CocpitEnclosureLabel.TabIndex = 1
        CocpitEnclosureLabel.Text = "Cocpit Enclosure:"
        '
        'SeatsLabel
        '
        SeatsLabel.AutoSize = True
        SeatsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeatsLabel.Location = New System.Drawing.Point(117, 108)
        SeatsLabel.Name = "SeatsLabel"
        SeatsLabel.Size = New System.Drawing.Size(46, 13)
        SeatsLabel.TabIndex = 3
        SeatsLabel.Text = "Seats:"
        '
        'Flight_DeckLabel
        '
        Flight_DeckLabel.AutoSize = True
        Flight_DeckLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Flight_DeckLabel.Location = New System.Drawing.Point(117, 134)
        Flight_DeckLabel.Name = "Flight_DeckLabel"
        Flight_DeckLabel.Size = New System.Drawing.Size(84, 13)
        Flight_DeckLabel.TabIndex = 5
        Flight_DeckLabel.Text = "Flight Deck:"
        '
        'Control_ColumnLabel
        '
        Control_ColumnLabel.AutoSize = True
        Control_ColumnLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Control_ColumnLabel.Location = New System.Drawing.Point(117, 160)
        Control_ColumnLabel.Name = "Control_ColumnLabel"
        Control_ColumnLabel.Size = New System.Drawing.Size(114, 13)
        Control_ColumnLabel.TabIndex = 7
        Control_ColumnLabel.Text = "Control Column:"
        '
        'Rudder_PaddlesLabel
        '
        Rudder_PaddlesLabel.AutoSize = True
        Rudder_PaddlesLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rudder_PaddlesLabel.Location = New System.Drawing.Point(117, 186)
        Rudder_PaddlesLabel.Name = "Rudder_PaddlesLabel"
        Rudder_PaddlesLabel.Size = New System.Drawing.Size(113, 13)
        Rudder_PaddlesLabel.TabIndex = 9
        Rudder_PaddlesLabel.Text = "Rudder Paddles:"
        '
        'Instrument_PanelLabel
        '
        Instrument_PanelLabel.AutoSize = True
        Instrument_PanelLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Instrument_PanelLabel.Location = New System.Drawing.Point(117, 212)
        Instrument_PanelLabel.Name = "Instrument_PanelLabel"
        Instrument_PanelLabel.Size = New System.Drawing.Size(121, 13)
        Instrument_PanelLabel.TabIndex = 11
        Instrument_PanelLabel.Text = "Instrument Panel:"
        '
        'PedstalLabel
        '
        PedstalLabel.AutoSize = True
        PedstalLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PedstalLabel.Location = New System.Drawing.Point(117, 238)
        PedstalLabel.Name = "PedstalLabel"
        PedstalLabel.Size = New System.Drawing.Size(60, 13)
        PedstalLabel.TabIndex = 13
        PedstalLabel.Text = "Pedstal:"
        '
        'EnginesLabel
        '
        EnginesLabel.AutoSize = True
        EnginesLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnginesLabel.Location = New System.Drawing.Point(117, 264)
        EnginesLabel.Name = "EnginesLabel"
        EnginesLabel.Size = New System.Drawing.Size(59, 13)
        EnginesLabel.TabIndex = 15
        EnginesLabel.Text = "Engines:"
        '
        'TurbineLabel
        '
        TurbineLabel.AutoSize = True
        TurbineLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TurbineLabel.Location = New System.Drawing.Point(117, 290)
        TurbineLabel.Name = "TurbineLabel"
        TurbineLabel.Size = New System.Drawing.Size(58, 13)
        TurbineLabel.TabIndex = 17
        TurbineLabel.Text = "Turbine:"
        '
        'WingsLabel
        '
        WingsLabel.AutoSize = True
        WingsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WingsLabel.Location = New System.Drawing.Point(117, 316)
        WingsLabel.Name = "WingsLabel"
        WingsLabel.Size = New System.Drawing.Size(48, 13)
        WingsLabel.TabIndex = 19
        WingsLabel.Text = "Wings:"
        '
        'Landing_GairsLabel
        '
        Landing_GairsLabel.AutoSize = True
        Landing_GairsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Landing_GairsLabel.Location = New System.Drawing.Point(117, 342)
        Landing_GairsLabel.Name = "Landing_GairsLabel"
        Landing_GairsLabel.Size = New System.Drawing.Size(99, 13)
        Landing_GairsLabel.TabIndex = 21
        Landing_GairsLabel.Text = "Landing Gairs:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipmentRequiredBindingSource
        '
        Me.EquipmentRequiredBindingSource.DataMember = "EquipmentRequired"
        Me.EquipmentRequiredBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'EquipmentRequiredTableAdapter
        '
        Me.EquipmentRequiredTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EquipmentRequiredTableAdapter = Me.EquipmentRequiredTableAdapter
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
        'EquipmentRequiredBindingNavigator
        '
        Me.EquipmentRequiredBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipmentRequiredBindingNavigator.BindingSource = Me.EquipmentRequiredBindingSource
        Me.EquipmentRequiredBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipmentRequiredBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipmentRequiredBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipmentRequiredBindingNavigatorSaveItem})
        Me.EquipmentRequiredBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipmentRequiredBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipmentRequiredBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipmentRequiredBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipmentRequiredBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipmentRequiredBindingNavigator.Name = "EquipmentRequiredBindingNavigator"
        Me.EquipmentRequiredBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipmentRequiredBindingNavigator.Size = New System.Drawing.Size(804, 26)
        Me.EquipmentRequiredBindingNavigator.TabIndex = 0
        Me.EquipmentRequiredBindingNavigator.Text = "BindingNavigator1"
        Me.EquipmentRequiredBindingNavigator.Visible = False
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
        'EquipmentRequiredBindingNavigatorSaveItem
        '
        Me.EquipmentRequiredBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipmentRequiredBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipmentRequiredBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipmentRequiredBindingNavigatorSaveItem.Name = "EquipmentRequiredBindingNavigatorSaveItem"
        Me.EquipmentRequiredBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EquipmentRequiredBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CocpitEnclosureTextBox
        '
        Me.CocpitEnclosureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "CocpitEnclosure", True))
        Me.CocpitEnclosureTextBox.Location = New System.Drawing.Point(252, 82)
        Me.CocpitEnclosureTextBox.Name = "CocpitEnclosureTextBox"
        Me.CocpitEnclosureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CocpitEnclosureTextBox.TabIndex = 2
        '
        'SeatsTextBox
        '
        Me.SeatsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Seats", True))
        Me.SeatsTextBox.Location = New System.Drawing.Point(252, 108)
        Me.SeatsTextBox.Name = "SeatsTextBox"
        Me.SeatsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeatsTextBox.TabIndex = 4
        '
        'Flight_DeckTextBox
        '
        Me.Flight_DeckTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Flight Deck", True))
        Me.Flight_DeckTextBox.Location = New System.Drawing.Point(252, 134)
        Me.Flight_DeckTextBox.Name = "Flight_DeckTextBox"
        Me.Flight_DeckTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Flight_DeckTextBox.TabIndex = 6
        '
        'Control_ColumnTextBox
        '
        Me.Control_ColumnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Control Column", True))
        Me.Control_ColumnTextBox.Location = New System.Drawing.Point(252, 160)
        Me.Control_ColumnTextBox.Name = "Control_ColumnTextBox"
        Me.Control_ColumnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Control_ColumnTextBox.TabIndex = 8
        '
        'Rudder_PaddlesTextBox
        '
        Me.Rudder_PaddlesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Rudder Paddles", True))
        Me.Rudder_PaddlesTextBox.Location = New System.Drawing.Point(252, 186)
        Me.Rudder_PaddlesTextBox.Name = "Rudder_PaddlesTextBox"
        Me.Rudder_PaddlesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rudder_PaddlesTextBox.TabIndex = 10
        '
        'Instrument_PanelTextBox
        '
        Me.Instrument_PanelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Instrument Panel", True))
        Me.Instrument_PanelTextBox.Location = New System.Drawing.Point(252, 212)
        Me.Instrument_PanelTextBox.Name = "Instrument_PanelTextBox"
        Me.Instrument_PanelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Instrument_PanelTextBox.TabIndex = 12
        '
        'PedstalTextBox
        '
        Me.PedstalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Pedstal", True))
        Me.PedstalTextBox.Location = New System.Drawing.Point(252, 238)
        Me.PedstalTextBox.Name = "PedstalTextBox"
        Me.PedstalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PedstalTextBox.TabIndex = 14
        '
        'EnginesTextBox
        '
        Me.EnginesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Engines", True))
        Me.EnginesTextBox.Location = New System.Drawing.Point(252, 264)
        Me.EnginesTextBox.Name = "EnginesTextBox"
        Me.EnginesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnginesTextBox.TabIndex = 16
        '
        'TurbineTextBox
        '
        Me.TurbineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Turbine", True))
        Me.TurbineTextBox.Location = New System.Drawing.Point(252, 290)
        Me.TurbineTextBox.Name = "TurbineTextBox"
        Me.TurbineTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TurbineTextBox.TabIndex = 18
        '
        'WingsTextBox
        '
        Me.WingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Wings", True))
        Me.WingsTextBox.Location = New System.Drawing.Point(252, 316)
        Me.WingsTextBox.Name = "WingsTextBox"
        Me.WingsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WingsTextBox.TabIndex = 20
        '
        'Landing_GairsTextBox
        '
        Me.Landing_GairsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipmentRequiredBindingSource, "Landing Gairs", True))
        Me.Landing_GairsTextBox.Location = New System.Drawing.Point(252, 342)
        Me.Landing_GairsTextBox.Name = "Landing_GairsTextBox"
        Me.Landing_GairsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Landing_GairsTextBox.TabIndex = 22
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button4.Location = New System.Drawing.Point(233, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button3.Location = New System.Drawing.Point(116, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button2.Location = New System.Drawing.Point(233, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button1.Location = New System.Drawing.Point(116, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CocpitEnclosureDataGridViewTextBoxColumn, Me.SeatsDataGridViewTextBoxColumn, Me.FlightDeckDataGridViewTextBoxColumn, Me.ControlColumnDataGridViewTextBoxColumn, Me.RudderPaddlesDataGridViewTextBoxColumn, Me.InstrumentPanelDataGridViewTextBoxColumn, Me.PedstalDataGridViewTextBoxColumn, Me.EnginesDataGridViewTextBoxColumn, Me.TurbineDataGridViewTextBoxColumn, Me.WingsDataGridViewTextBoxColumn, Me.LandingGairsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EquipmentRequiredBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(403, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 202)
        Me.DataGridView1.TabIndex = 40
        '
        'CocpitEnclosureDataGridViewTextBoxColumn
        '
        Me.CocpitEnclosureDataGridViewTextBoxColumn.DataPropertyName = "CocpitEnclosure"
        Me.CocpitEnclosureDataGridViewTextBoxColumn.HeaderText = "CocpitEnclosure"
        Me.CocpitEnclosureDataGridViewTextBoxColumn.Name = "CocpitEnclosureDataGridViewTextBoxColumn"
        '
        'SeatsDataGridViewTextBoxColumn
        '
        Me.SeatsDataGridViewTextBoxColumn.DataPropertyName = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.HeaderText = "Seats"
        Me.SeatsDataGridViewTextBoxColumn.Name = "SeatsDataGridViewTextBoxColumn"
        '
        'FlightDeckDataGridViewTextBoxColumn
        '
        Me.FlightDeckDataGridViewTextBoxColumn.DataPropertyName = "Flight Deck"
        Me.FlightDeckDataGridViewTextBoxColumn.HeaderText = "Flight Deck"
        Me.FlightDeckDataGridViewTextBoxColumn.Name = "FlightDeckDataGridViewTextBoxColumn"
        '
        'ControlColumnDataGridViewTextBoxColumn
        '
        Me.ControlColumnDataGridViewTextBoxColumn.DataPropertyName = "Control Column"
        Me.ControlColumnDataGridViewTextBoxColumn.HeaderText = "Control Column"
        Me.ControlColumnDataGridViewTextBoxColumn.Name = "ControlColumnDataGridViewTextBoxColumn"
        '
        'RudderPaddlesDataGridViewTextBoxColumn
        '
        Me.RudderPaddlesDataGridViewTextBoxColumn.DataPropertyName = "Rudder Paddles"
        Me.RudderPaddlesDataGridViewTextBoxColumn.HeaderText = "Rudder Paddles"
        Me.RudderPaddlesDataGridViewTextBoxColumn.Name = "RudderPaddlesDataGridViewTextBoxColumn"
        '
        'InstrumentPanelDataGridViewTextBoxColumn
        '
        Me.InstrumentPanelDataGridViewTextBoxColumn.DataPropertyName = "Instrument Panel"
        Me.InstrumentPanelDataGridViewTextBoxColumn.HeaderText = "Instrument Panel"
        Me.InstrumentPanelDataGridViewTextBoxColumn.Name = "InstrumentPanelDataGridViewTextBoxColumn"
        '
        'PedstalDataGridViewTextBoxColumn
        '
        Me.PedstalDataGridViewTextBoxColumn.DataPropertyName = "Pedstal"
        Me.PedstalDataGridViewTextBoxColumn.HeaderText = "Pedstal"
        Me.PedstalDataGridViewTextBoxColumn.Name = "PedstalDataGridViewTextBoxColumn"
        '
        'EnginesDataGridViewTextBoxColumn
        '
        Me.EnginesDataGridViewTextBoxColumn.DataPropertyName = "Engines"
        Me.EnginesDataGridViewTextBoxColumn.HeaderText = "Engines"
        Me.EnginesDataGridViewTextBoxColumn.Name = "EnginesDataGridViewTextBoxColumn"
        '
        'TurbineDataGridViewTextBoxColumn
        '
        Me.TurbineDataGridViewTextBoxColumn.DataPropertyName = "Turbine"
        Me.TurbineDataGridViewTextBoxColumn.HeaderText = "Turbine"
        Me.TurbineDataGridViewTextBoxColumn.Name = "TurbineDataGridViewTextBoxColumn"
        '
        'WingsDataGridViewTextBoxColumn
        '
        Me.WingsDataGridViewTextBoxColumn.DataPropertyName = "Wings"
        Me.WingsDataGridViewTextBoxColumn.HeaderText = "Wings"
        Me.WingsDataGridViewTextBoxColumn.Name = "WingsDataGridViewTextBoxColumn"
        '
        'LandingGairsDataGridViewTextBoxColumn
        '
        Me.LandingGairsDataGridViewTextBoxColumn.DataPropertyName = "Landing Gairs"
        Me.LandingGairsDataGridViewTextBoxColumn.HeaderText = "Landing Gairs"
        Me.LandingGairsDataGridViewTextBoxColumn.Name = "LandingGairsDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Coral
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(405, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 40)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Required Equipements"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button5.Location = New System.Drawing.Point(348, 424)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'RequiredEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 496)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CocpitEnclosureLabel)
        Me.Controls.Add(Me.CocpitEnclosureTextBox)
        Me.Controls.Add(SeatsLabel)
        Me.Controls.Add(Me.SeatsTextBox)
        Me.Controls.Add(Flight_DeckLabel)
        Me.Controls.Add(Me.Flight_DeckTextBox)
        Me.Controls.Add(Control_ColumnLabel)
        Me.Controls.Add(Me.Control_ColumnTextBox)
        Me.Controls.Add(Rudder_PaddlesLabel)
        Me.Controls.Add(Me.Rudder_PaddlesTextBox)
        Me.Controls.Add(Instrument_PanelLabel)
        Me.Controls.Add(Me.Instrument_PanelTextBox)
        Me.Controls.Add(PedstalLabel)
        Me.Controls.Add(Me.PedstalTextBox)
        Me.Controls.Add(EnginesLabel)
        Me.Controls.Add(Me.EnginesTextBox)
        Me.Controls.Add(TurbineLabel)
        Me.Controls.Add(Me.TurbineTextBox)
        Me.Controls.Add(WingsLabel)
        Me.Controls.Add(Me.WingsTextBox)
        Me.Controls.Add(Landing_GairsLabel)
        Me.Controls.Add(Me.Landing_GairsTextBox)
        Me.Controls.Add(Me.EquipmentRequiredBindingNavigator)
        Me.Name = "RequiredEquipment"
        Me.Text = "RequiredEquipment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentRequiredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentRequiredBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipmentRequiredBindingNavigator.ResumeLayout(False)
        Me.EquipmentRequiredBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents EquipmentRequiredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipmentRequiredTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.EquipmentRequiredTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipmentRequiredBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EquipmentRequiredBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CocpitEnclosureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeatsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Flight_DeckTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Control_ColumnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rudder_PaddlesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Instrument_PanelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PedstalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnginesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TurbineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Landing_GairsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CocpitEnclosureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlightDeckDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlColumnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RudderPaddlesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstrumentPanelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PedstalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnginesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurbineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WingsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandingGairsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
