<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DamageEstimate
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
        Dim Cocpit_PartsLabel As System.Windows.Forms.Label
        Dim EnginesLabel As System.Windows.Forms.Label
        Dim StabilizersLabel As System.Windows.Forms.Label
        Dim ElevatorsLabel As System.Windows.Forms.Label
        Dim Landing_GairsLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DamageEstimate))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Damage_EstimateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Damage_EstimateTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Damage_EstimateTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Damage_EstimateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Damage_EstimateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Plane_TypeTextBox = New System.Windows.Forms.TextBox
        Me.Cocpit_PartsTextBox = New System.Windows.Forms.TextBox
        Me.EnginesTextBox = New System.Windows.Forms.TextBox
        Me.StabilizersTextBox = New System.Windows.Forms.TextBox
        Me.ElevatorsTextBox = New System.Windows.Forms.TextBox
        Me.Landing_GairsTextBox = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PlaneTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CocpitPartsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnginesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StabilizersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ElevatorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LandingGairsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Button9 = New System.Windows.Forms.Button
        Plane_TypeLabel = New System.Windows.Forms.Label
        Cocpit_PartsLabel = New System.Windows.Forms.Label
        EnginesLabel = New System.Windows.Forms.Label
        StabilizersLabel = New System.Windows.Forms.Label
        ElevatorsLabel = New System.Windows.Forms.Label
        Landing_GairsLabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Damage_EstimateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Damage_EstimateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Damage_EstimateBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Plane_TypeLabel
        '
        Plane_TypeLabel.AutoSize = True
        Plane_TypeLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plane_TypeLabel.Location = New System.Drawing.Point(6, 120)
        Plane_TypeLabel.Name = "Plane_TypeLabel"
        Plane_TypeLabel.Size = New System.Drawing.Size(78, 13)
        Plane_TypeLabel.TabIndex = 1
        Plane_TypeLabel.Text = "Plane Type:"
        '
        'Cocpit_PartsLabel
        '
        Cocpit_PartsLabel.AutoSize = True
        Cocpit_PartsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cocpit_PartsLabel.Location = New System.Drawing.Point(6, 146)
        Cocpit_PartsLabel.Name = "Cocpit_PartsLabel"
        Cocpit_PartsLabel.Size = New System.Drawing.Size(124, 13)
        Cocpit_PartsLabel.TabIndex = 3
        Cocpit_PartsLabel.Text = "Cocpit Parts Cost:"
        '
        'EnginesLabel
        '
        EnginesLabel.AutoSize = True
        EnginesLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnginesLabel.Location = New System.Drawing.Point(6, 172)
        EnginesLabel.Name = "EnginesLabel"
        EnginesLabel.Size = New System.Drawing.Size(92, 13)
        EnginesLabel.TabIndex = 5
        EnginesLabel.Text = "Engines Cost:"
        '
        'StabilizersLabel
        '
        StabilizersLabel.AutoSize = True
        StabilizersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StabilizersLabel.Location = New System.Drawing.Point(6, 198)
        StabilizersLabel.Name = "StabilizersLabel"
        StabilizersLabel.Size = New System.Drawing.Size(113, 13)
        StabilizersLabel.TabIndex = 7
        StabilizersLabel.Text = "Stabilizers Cost:"
        '
        'ElevatorsLabel
        '
        ElevatorsLabel.AutoSize = True
        ElevatorsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElevatorsLabel.Location = New System.Drawing.Point(6, 224)
        ElevatorsLabel.Name = "ElevatorsLabel"
        ElevatorsLabel.Size = New System.Drawing.Size(108, 13)
        ElevatorsLabel.TabIndex = 9
        ElevatorsLabel.Text = "Elevators Cost:"
        '
        'Landing_GairsLabel
        '
        Landing_GairsLabel.AutoSize = True
        Landing_GairsLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Landing_GairsLabel.Location = New System.Drawing.Point(6, 250)
        Landing_GairsLabel.Name = "Landing_GairsLabel"
        Landing_GairsLabel.Size = New System.Drawing.Size(132, 13)
        Landing_GairsLabel.TabIndex = 11
        Landing_GairsLabel.Text = "Landing Gairs Cost:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(70, 48)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(78, 13)
        Label4.TabIndex = 13
        Label4.Text = "Plane Type:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(70, 74)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(124, 13)
        Label5.TabIndex = 15
        Label5.Text = "Cocpit Parts Cost:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(70, 100)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(92, 13)
        Label6.TabIndex = 17
        Label6.Text = "Engines Cost:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(70, 126)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(113, 13)
        Label7.TabIndex = 19
        Label7.Text = "Stabilizers Cost:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(70, 152)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(108, 13)
        Label8.TabIndex = 21
        Label8.Text = "Elevators Cost:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(70, 178)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(132, 13)
        Label9.TabIndex = 23
        Label9.Text = "Landing Gairs Cost:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Damage_EstimateBindingSource
        '
        Me.Damage_EstimateBindingSource.DataMember = "Damage Estimate"
        Me.Damage_EstimateBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Damage_EstimateTableAdapter
        '
        Me.Damage_EstimateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.BranchesTableAdapter = Nothing
        Me.TableAdapterManager.Company_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.Company_nameTableAdapter = Nothing
        Me.TableAdapterManager.Damage_EstimateTableAdapter = Me.Damage_EstimateTableAdapter
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
        'Damage_EstimateBindingNavigator
        '
        Me.Damage_EstimateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Damage_EstimateBindingNavigator.BindingSource = Me.Damage_EstimateBindingSource
        Me.Damage_EstimateBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Damage_EstimateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Damage_EstimateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Damage_EstimateBindingNavigatorSaveItem})
        Me.Damage_EstimateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Damage_EstimateBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Damage_EstimateBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Damage_EstimateBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Damage_EstimateBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Damage_EstimateBindingNavigator.Name = "Damage_EstimateBindingNavigator"
        Me.Damage_EstimateBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Damage_EstimateBindingNavigator.Size = New System.Drawing.Size(788, 26)
        Me.Damage_EstimateBindingNavigator.TabIndex = 0
        Me.Damage_EstimateBindingNavigator.Text = "BindingNavigator1"
        Me.Damage_EstimateBindingNavigator.Visible = False
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
        'Damage_EstimateBindingNavigatorSaveItem
        '
        Me.Damage_EstimateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Damage_EstimateBindingNavigatorSaveItem.Image = CType(resources.GetObject("Damage_EstimateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Damage_EstimateBindingNavigatorSaveItem.Name = "Damage_EstimateBindingNavigatorSaveItem"
        Me.Damage_EstimateBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Damage_EstimateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Plane_TypeTextBox
        '
        Me.Plane_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Plane Type", True))
        Me.Plane_TypeTextBox.Location = New System.Drawing.Point(215, 116)
        Me.Plane_TypeTextBox.Name = "Plane_TypeTextBox"
        Me.Plane_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Plane_TypeTextBox.TabIndex = 2
        '
        'Cocpit_PartsTextBox
        '
        Me.Cocpit_PartsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Cocpit Parts", True))
        Me.Cocpit_PartsTextBox.Location = New System.Drawing.Point(215, 142)
        Me.Cocpit_PartsTextBox.Name = "Cocpit_PartsTextBox"
        Me.Cocpit_PartsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cocpit_PartsTextBox.TabIndex = 4
        '
        'EnginesTextBox
        '
        Me.EnginesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Engines", True))
        Me.EnginesTextBox.Location = New System.Drawing.Point(215, 168)
        Me.EnginesTextBox.Name = "EnginesTextBox"
        Me.EnginesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnginesTextBox.TabIndex = 6
        '
        'StabilizersTextBox
        '
        Me.StabilizersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Stabilizers", True))
        Me.StabilizersTextBox.Location = New System.Drawing.Point(215, 194)
        Me.StabilizersTextBox.Name = "StabilizersTextBox"
        Me.StabilizersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StabilizersTextBox.TabIndex = 8
        '
        'ElevatorsTextBox
        '
        Me.ElevatorsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Elevators", True))
        Me.ElevatorsTextBox.Location = New System.Drawing.Point(215, 220)
        Me.ElevatorsTextBox.Name = "ElevatorsTextBox"
        Me.ElevatorsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ElevatorsTextBox.TabIndex = 10
        '
        'Landing_GairsTextBox
        '
        Me.Landing_GairsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Landing Gairs", True))
        Me.Landing_GairsTextBox.Location = New System.Drawing.Point(215, 246)
        Me.Landing_GairsTextBox.Name = "Landing_GairsTextBox"
        Me.Landing_GairsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Landing_GairsTextBox.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(155, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 38)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(38, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 38)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(155, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 39)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(38, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 39)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlaneTypeDataGridViewTextBoxColumn, Me.CocpitPartsDataGridViewTextBoxColumn, Me.EnginesDataGridViewTextBoxColumn, Me.StabilizersDataGridViewTextBoxColumn, Me.ElevatorsDataGridViewTextBoxColumn, Me.LandingGairsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Damage_EstimateBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(380, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(507, 202)
        Me.DataGridView1.TabIndex = 36
        '
        'PlaneTypeDataGridViewTextBoxColumn
        '
        Me.PlaneTypeDataGridViewTextBoxColumn.DataPropertyName = "Plane Type"
        Me.PlaneTypeDataGridViewTextBoxColumn.HeaderText = "Plane Type"
        Me.PlaneTypeDataGridViewTextBoxColumn.Name = "PlaneTypeDataGridViewTextBoxColumn"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 40)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Damage Estimate"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(38, 275)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 31)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Generate Bill"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.Location = New System.Drawing.Point(245, 382)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(59, 39)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Location = New System.Drawing.Point(352, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 450)
        Me.Panel1.TabIndex = 42
        Me.Panel1.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(279, 264)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Print"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(122, 267)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(276, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Total Cost"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Plane Type", True))
        Me.TextBox1.Location = New System.Drawing.Point(279, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Cocpit Parts", True))
        Me.TextBox2.Location = New System.Drawing.Point(279, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Engines", True))
        Me.TextBox3.Location = New System.Drawing.Point(279, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Stabilizers", True))
        Me.TextBox4.Location = New System.Drawing.Point(279, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Elevators", True))
        Me.TextBox5.Location = New System.Drawing.Point(279, 148)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Damage_EstimateBindingSource, "Landing Gairs", True))
        Me.TextBox6.Location = New System.Drawing.Point(279, 174)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 39
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.Location = New System.Drawing.Point(245, 325)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(101, 39)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Generate Report"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'DamageEstimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(999, 467)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Plane_TypeLabel)
        Me.Controls.Add(Me.Plane_TypeTextBox)
        Me.Controls.Add(Cocpit_PartsLabel)
        Me.Controls.Add(Me.Cocpit_PartsTextBox)
        Me.Controls.Add(EnginesLabel)
        Me.Controls.Add(Me.EnginesTextBox)
        Me.Controls.Add(StabilizersLabel)
        Me.Controls.Add(Me.StabilizersTextBox)
        Me.Controls.Add(ElevatorsLabel)
        Me.Controls.Add(Me.ElevatorsTextBox)
        Me.Controls.Add(Landing_GairsLabel)
        Me.Controls.Add(Me.Landing_GairsTextBox)
        Me.Controls.Add(Me.Damage_EstimateBindingNavigator)
        Me.Name = "DamageEstimate"
        Me.Text = "DamageEstimate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Damage_EstimateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Damage_EstimateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Damage_EstimateBindingNavigator.ResumeLayout(False)
        Me.Damage_EstimateBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Damage_EstimateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Damage_EstimateTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Damage_EstimateTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Damage_EstimateBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Damage_EstimateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Plane_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cocpit_PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnginesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StabilizersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ElevatorsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Landing_GairsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlaneTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CocpitPartsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnginesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StabilizersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElevatorsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandingGairsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
