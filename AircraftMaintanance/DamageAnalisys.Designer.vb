<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DamageAnalisys
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
        Dim Plane_TypeLabel As System.Windows.Forms.Label
        Dim Cocpit_damageLabel As System.Windows.Forms.Label
        Dim Cabin_PressureLabel As System.Windows.Forms.Label
        Dim Engine_DamageLabel As System.Windows.Forms.Label
        Dim Turbine_DamageLabel As System.Windows.Forms.Label
        Dim Stalibilizers_DamageLabel As System.Windows.Forms.Label
        Dim Wings_DamageLabel As System.Windows.Forms.Label
        Dim Landing_Gairs_DamageLabel As System.Windows.Forms.Label
        Dim Wingate_DamageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DamageAnalisys))
        Me.DamageAnalysisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DamageAnalysisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Plane_TypeTextBox = New System.Windows.Forms.TextBox
        Me.Cocpit_damageTextBox = New System.Windows.Forms.TextBox
        Me.Cabin_PressureTextBox = New System.Windows.Forms.TextBox
        Me.Engine_DamageTextBox = New System.Windows.Forms.TextBox
        Me.Turbine_DamageTextBox = New System.Windows.Forms.TextBox
        Me.Stalibilizers_DamageTextBox = New System.Windows.Forms.TextBox
        Me.Wings_DamageTextBox = New System.Windows.Forms.TextBox
        Me.Landing_Gairs_DamageTextBox = New System.Windows.Forms.TextBox
        Me.Wingate_DamageTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PlaneTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CocpitDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CabinPressureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EngineDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurbineDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StalibilizersDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WingsDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LandingGairsDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WingateDamageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DamageAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.DamageAnalysisTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.DamageAnalysisTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.AircraftMSDataSet1 = New AircraftMaintanance.AircraftMSDataSet
        Plane_TypeLabel = New System.Windows.Forms.Label
        Cocpit_damageLabel = New System.Windows.Forms.Label
        Cabin_PressureLabel = New System.Windows.Forms.Label
        Engine_DamageLabel = New System.Windows.Forms.Label
        Turbine_DamageLabel = New System.Windows.Forms.Label
        Stalibilizers_DamageLabel = New System.Windows.Forms.Label
        Wings_DamageLabel = New System.Windows.Forms.Label
        Landing_Gairs_DamageLabel = New System.Windows.Forms.Label
        Wingate_DamageLabel = New System.Windows.Forms.Label
        CType(Me.DamageAnalysisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DamageAnalysisBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.DamageAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AircraftMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Plane_TypeLabel
        '
        Plane_TypeLabel.AutoSize = True
        Plane_TypeLabel.BackColor = System.Drawing.Color.Bisque
        Plane_TypeLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plane_TypeLabel.ForeColor = System.Drawing.Color.DarkBlue
        Plane_TypeLabel.Location = New System.Drawing.Point(36, 102)
        Plane_TypeLabel.Name = "Plane_TypeLabel"
        Plane_TypeLabel.Size = New System.Drawing.Size(71, 11)
        Plane_TypeLabel.TabIndex = 1
        Plane_TypeLabel.Text = "Plane Type:"
        '
        'Cocpit_damageLabel
        '
        Cocpit_damageLabel.AutoSize = True
        Cocpit_damageLabel.BackColor = System.Drawing.Color.Bisque
        Cocpit_damageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cocpit_damageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Cocpit_damageLabel.Location = New System.Drawing.Point(36, 128)
        Cocpit_damageLabel.Name = "Cocpit_damageLabel"
        Cocpit_damageLabel.Size = New System.Drawing.Size(91, 11)
        Cocpit_damageLabel.TabIndex = 3
        Cocpit_damageLabel.Text = "Cocpit damage:"
        '
        'Cabin_PressureLabel
        '
        Cabin_PressureLabel.AutoSize = True
        Cabin_PressureLabel.BackColor = System.Drawing.Color.Bisque
        Cabin_PressureLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cabin_PressureLabel.ForeColor = System.Drawing.Color.DarkBlue
        Cabin_PressureLabel.Location = New System.Drawing.Point(36, 154)
        Cabin_PressureLabel.Name = "Cabin_PressureLabel"
        Cabin_PressureLabel.Size = New System.Drawing.Size(96, 11)
        Cabin_PressureLabel.TabIndex = 5
        Cabin_PressureLabel.Text = "Cabin Pressure:"
        '
        'Engine_DamageLabel
        '
        Engine_DamageLabel.AutoSize = True
        Engine_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Engine_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Engine_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Engine_DamageLabel.Location = New System.Drawing.Point(36, 180)
        Engine_DamageLabel.Name = "Engine_DamageLabel"
        Engine_DamageLabel.Size = New System.Drawing.Size(92, 11)
        Engine_DamageLabel.TabIndex = 7
        Engine_DamageLabel.Text = "Engine Damage:"
        '
        'Turbine_DamageLabel
        '
        Turbine_DamageLabel.AutoSize = True
        Turbine_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Turbine_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Turbine_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Turbine_DamageLabel.Location = New System.Drawing.Point(36, 206)
        Turbine_DamageLabel.Name = "Turbine_DamageLabel"
        Turbine_DamageLabel.Size = New System.Drawing.Size(98, 11)
        Turbine_DamageLabel.TabIndex = 9
        Turbine_DamageLabel.Text = "Turbine Damage:"
        '
        'Stalibilizers_DamageLabel
        '
        Stalibilizers_DamageLabel.AutoSize = True
        Stalibilizers_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Stalibilizers_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stalibilizers_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Stalibilizers_DamageLabel.Location = New System.Drawing.Point(36, 232)
        Stalibilizers_DamageLabel.Name = "Stalibilizers_DamageLabel"
        Stalibilizers_DamageLabel.Size = New System.Drawing.Size(127, 11)
        Stalibilizers_DamageLabel.TabIndex = 11
        Stalibilizers_DamageLabel.Text = "Stalibilizers Damage:"
        '
        'Wings_DamageLabel
        '
        Wings_DamageLabel.AutoSize = True
        Wings_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Wings_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wings_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Wings_DamageLabel.Location = New System.Drawing.Point(36, 258)
        Wings_DamageLabel.Name = "Wings_DamageLabel"
        Wings_DamageLabel.Size = New System.Drawing.Size(88, 11)
        Wings_DamageLabel.TabIndex = 13
        Wings_DamageLabel.Text = "Wings Damage:"
        '
        'Landing_Gairs_DamageLabel
        '
        Landing_Gairs_DamageLabel.AutoSize = True
        Landing_Gairs_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Landing_Gairs_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Landing_Gairs_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Landing_Gairs_DamageLabel.Location = New System.Drawing.Point(36, 284)
        Landing_Gairs_DamageLabel.Name = "Landing_Gairs_DamageLabel"
        Landing_Gairs_DamageLabel.Size = New System.Drawing.Size(134, 11)
        Landing_Gairs_DamageLabel.TabIndex = 15
        Landing_Gairs_DamageLabel.Text = "Landing Gairs Damage:"
        '
        'Wingate_DamageLabel
        '
        Wingate_DamageLabel.AutoSize = True
        Wingate_DamageLabel.BackColor = System.Drawing.Color.Bisque
        Wingate_DamageLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wingate_DamageLabel.ForeColor = System.Drawing.Color.DarkBlue
        Wingate_DamageLabel.Location = New System.Drawing.Point(36, 310)
        Wingate_DamageLabel.Name = "Wingate_DamageLabel"
        Wingate_DamageLabel.Size = New System.Drawing.Size(101, 11)
        Wingate_DamageLabel.TabIndex = 17
        Wingate_DamageLabel.Text = "Wingate Damage:"
        '
        'DamageAnalysisBindingNavigator
        '
        Me.DamageAnalysisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DamageAnalysisBindingNavigator.BindingSource = Me.DamageAnalysisBindingSource
        Me.DamageAnalysisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DamageAnalysisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DamageAnalysisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DamageAnalysisBindingNavigatorSaveItem})
        Me.DamageAnalysisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DamageAnalysisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DamageAnalysisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DamageAnalysisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DamageAnalysisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DamageAnalysisBindingNavigator.Name = "DamageAnalysisBindingNavigator"
        Me.DamageAnalysisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DamageAnalysisBindingNavigator.Size = New System.Drawing.Size(815, 26)
        Me.DamageAnalysisBindingNavigator.TabIndex = 0
        Me.DamageAnalysisBindingNavigator.Text = "BindingNavigator1"
        Me.DamageAnalysisBindingNavigator.Visible = False
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
        'DamageAnalysisBindingNavigatorSaveItem
        '
        Me.DamageAnalysisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DamageAnalysisBindingNavigatorSaveItem.Image = CType(resources.GetObject("DamageAnalysisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DamageAnalysisBindingNavigatorSaveItem.Name = "DamageAnalysisBindingNavigatorSaveItem"
        Me.DamageAnalysisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DamageAnalysisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Plane_TypeTextBox
        '
        Me.Plane_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Plane Type", True))
        Me.Plane_TypeTextBox.Location = New System.Drawing.Point(262, 102)
        Me.Plane_TypeTextBox.Name = "Plane_TypeTextBox"
        Me.Plane_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plane_TypeTextBox.TabIndex = 2
        '
        'Cocpit_damageTextBox
        '
        Me.Cocpit_damageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Cocpit damage", True))
        Me.Cocpit_damageTextBox.Location = New System.Drawing.Point(262, 128)
        Me.Cocpit_damageTextBox.Name = "Cocpit_damageTextBox"
        Me.Cocpit_damageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cocpit_damageTextBox.TabIndex = 4
        '
        'Cabin_PressureTextBox
        '
        Me.Cabin_PressureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Cabin Pressure", True))
        Me.Cabin_PressureTextBox.Location = New System.Drawing.Point(262, 154)
        Me.Cabin_PressureTextBox.Name = "Cabin_PressureTextBox"
        Me.Cabin_PressureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cabin_PressureTextBox.TabIndex = 6
        '
        'Engine_DamageTextBox
        '
        Me.Engine_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Engine Damage", True))
        Me.Engine_DamageTextBox.Location = New System.Drawing.Point(262, 180)
        Me.Engine_DamageTextBox.Name = "Engine_DamageTextBox"
        Me.Engine_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Engine_DamageTextBox.TabIndex = 8
        '
        'Turbine_DamageTextBox
        '
        Me.Turbine_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Turbine Damage", True))
        Me.Turbine_DamageTextBox.Location = New System.Drawing.Point(262, 206)
        Me.Turbine_DamageTextBox.Name = "Turbine_DamageTextBox"
        Me.Turbine_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Turbine_DamageTextBox.TabIndex = 10
        '
        'Stalibilizers_DamageTextBox
        '
        Me.Stalibilizers_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Stalibilizers Damage", True))
        Me.Stalibilizers_DamageTextBox.Location = New System.Drawing.Point(262, 232)
        Me.Stalibilizers_DamageTextBox.Name = "Stalibilizers_DamageTextBox"
        Me.Stalibilizers_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stalibilizers_DamageTextBox.TabIndex = 12
        '
        'Wings_DamageTextBox
        '
        Me.Wings_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Wings Damage", True))
        Me.Wings_DamageTextBox.Location = New System.Drawing.Point(262, 258)
        Me.Wings_DamageTextBox.Name = "Wings_DamageTextBox"
        Me.Wings_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Wings_DamageTextBox.TabIndex = 14
        '
        'Landing_Gairs_DamageTextBox
        '
        Me.Landing_Gairs_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Landing Gairs Damage", True))
        Me.Landing_Gairs_DamageTextBox.Location = New System.Drawing.Point(262, 284)
        Me.Landing_Gairs_DamageTextBox.Name = "Landing_Gairs_DamageTextBox"
        Me.Landing_Gairs_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Landing_Gairs_DamageTextBox.TabIndex = 16
        '
        'Wingate_DamageTextBox
        '
        Me.Wingate_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DamageAnalysisBindingSource, "Wingate Damage", True))
        Me.Wingate_DamageTextBox.Location = New System.Drawing.Point(262, 310)
        Me.Wingate_DamageTextBox.Name = "Wingate_DamageTextBox"
        Me.Wingate_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Wingate_DamageTextBox.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlaneTypeDataGridViewTextBoxColumn, Me.CocpitDamageDataGridViewTextBoxColumn, Me.CabinPressureDataGridViewTextBoxColumn, Me.EngineDamageDataGridViewTextBoxColumn, Me.TurbineDamageDataGridViewTextBoxColumn, Me.StalibilizersDamageDataGridViewTextBoxColumn, Me.WingsDamageDataGridViewTextBoxColumn, Me.LandingGairsDamageDataGridViewTextBoxColumn, Me.WingateDamageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DamageAnalysisBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(421, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 301)
        Me.DataGridView1.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button4.Location = New System.Drawing.Point(160, 405)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button3.Location = New System.Drawing.Point(43, 405)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button2.Location = New System.Drawing.Point(160, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button1.Location = New System.Drawing.Point(43, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Location = New System.Drawing.Point(304, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 35)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Damage Analysis And Details"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button5.Location = New System.Drawing.Point(276, 405)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1015, 25)
        Me.FillByToolStrip.TabIndex = 46
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'PlaneTypeDataGridViewTextBoxColumn
        '
        Me.PlaneTypeDataGridViewTextBoxColumn.DataPropertyName = "Plane Type"
        Me.PlaneTypeDataGridViewTextBoxColumn.HeaderText = "Plane Type"
        Me.PlaneTypeDataGridViewTextBoxColumn.Name = "PlaneTypeDataGridViewTextBoxColumn"
        '
        'CocpitDamageDataGridViewTextBoxColumn
        '
        Me.CocpitDamageDataGridViewTextBoxColumn.DataPropertyName = "Cocpit damage"
        Me.CocpitDamageDataGridViewTextBoxColumn.HeaderText = "Cocpit damage"
        Me.CocpitDamageDataGridViewTextBoxColumn.Name = "CocpitDamageDataGridViewTextBoxColumn"
        '
        'CabinPressureDataGridViewTextBoxColumn
        '
        Me.CabinPressureDataGridViewTextBoxColumn.DataPropertyName = "Cabin Pressure"
        Me.CabinPressureDataGridViewTextBoxColumn.HeaderText = "Cabin Pressure"
        Me.CabinPressureDataGridViewTextBoxColumn.Name = "CabinPressureDataGridViewTextBoxColumn"
        '
        'EngineDamageDataGridViewTextBoxColumn
        '
        Me.EngineDamageDataGridViewTextBoxColumn.DataPropertyName = "Engine Damage"
        Me.EngineDamageDataGridViewTextBoxColumn.HeaderText = "Engine Damage"
        Me.EngineDamageDataGridViewTextBoxColumn.Name = "EngineDamageDataGridViewTextBoxColumn"
        '
        'TurbineDamageDataGridViewTextBoxColumn
        '
        Me.TurbineDamageDataGridViewTextBoxColumn.DataPropertyName = "Turbine Damage"
        Me.TurbineDamageDataGridViewTextBoxColumn.HeaderText = "Turbine Damage"
        Me.TurbineDamageDataGridViewTextBoxColumn.Name = "TurbineDamageDataGridViewTextBoxColumn"
        '
        'StalibilizersDamageDataGridViewTextBoxColumn
        '
        Me.StalibilizersDamageDataGridViewTextBoxColumn.DataPropertyName = "Stalibilizers Damage"
        Me.StalibilizersDamageDataGridViewTextBoxColumn.HeaderText = "Stalibilizers Damage"
        Me.StalibilizersDamageDataGridViewTextBoxColumn.Name = "StalibilizersDamageDataGridViewTextBoxColumn"
        '
        'WingsDamageDataGridViewTextBoxColumn
        '
        Me.WingsDamageDataGridViewTextBoxColumn.DataPropertyName = "Wings Damage"
        Me.WingsDamageDataGridViewTextBoxColumn.HeaderText = "Wings Damage"
        Me.WingsDamageDataGridViewTextBoxColumn.Name = "WingsDamageDataGridViewTextBoxColumn"
        '
        'LandingGairsDamageDataGridViewTextBoxColumn
        '
        Me.LandingGairsDamageDataGridViewTextBoxColumn.DataPropertyName = "Landing Gairs Damage"
        Me.LandingGairsDamageDataGridViewTextBoxColumn.HeaderText = "Landing Gairs Damage"
        Me.LandingGairsDamageDataGridViewTextBoxColumn.Name = "LandingGairsDamageDataGridViewTextBoxColumn"
        '
        'WingateDamageDataGridViewTextBoxColumn
        '
        Me.WingateDamageDataGridViewTextBoxColumn.DataPropertyName = "Wingate Damage"
        Me.WingateDamageDataGridViewTextBoxColumn.HeaderText = "Wingate Damage"
        Me.WingateDamageDataGridViewTextBoxColumn.Name = "WingateDamageDataGridViewTextBoxColumn"
        '
        'DamageAnalysisBindingSource
        '
        Me.DamageAnalysisBindingSource.DataMember = "DamageAnalysis"
        Me.DamageAnalysisBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DamageAnalysisTableAdapter
        '
        Me.DamageAnalysisTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DamageAnalysisTableAdapter = Me.DamageAnalysisTableAdapter
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
        'AircraftMSDataSet1
        '
        Me.AircraftMSDataSet1.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DamageAnalisys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1015, 484)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Plane_TypeLabel)
        Me.Controls.Add(Me.Plane_TypeTextBox)
        Me.Controls.Add(Cocpit_damageLabel)
        Me.Controls.Add(Me.Cocpit_damageTextBox)
        Me.Controls.Add(Cabin_PressureLabel)
        Me.Controls.Add(Me.Cabin_PressureTextBox)
        Me.Controls.Add(Engine_DamageLabel)
        Me.Controls.Add(Me.Engine_DamageTextBox)
        Me.Controls.Add(Turbine_DamageLabel)
        Me.Controls.Add(Me.Turbine_DamageTextBox)
        Me.Controls.Add(Stalibilizers_DamageLabel)
        Me.Controls.Add(Me.Stalibilizers_DamageTextBox)
        Me.Controls.Add(Wings_DamageLabel)
        Me.Controls.Add(Me.Wings_DamageTextBox)
        Me.Controls.Add(Landing_Gairs_DamageLabel)
        Me.Controls.Add(Me.Landing_Gairs_DamageTextBox)
        Me.Controls.Add(Wingate_DamageLabel)
        Me.Controls.Add(Me.Wingate_DamageTextBox)
        Me.Controls.Add(Me.DamageAnalysisBindingNavigator)
        Me.Name = "DamageAnalisys"
        Me.Text = "DamageAnalisys"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DamageAnalysisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DamageAnalysisBindingNavigator.ResumeLayout(False)
        Me.DamageAnalysisBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.DamageAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AircraftMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents DamageAnalysisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DamageAnalysisTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.DamageAnalysisTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DamageAnalysisBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DamageAnalysisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Plane_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cocpit_damageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cabin_PressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Engine_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Turbine_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stalibilizers_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wings_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Landing_Gairs_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wingate_DamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlaneTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CocpitDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CabinPressureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EngineDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurbineDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StalibilizersDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WingsDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandingGairsDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WingateDamageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AircraftMSDataSet1 As AircraftMaintanance.AircraftMSDataSet
End Class
