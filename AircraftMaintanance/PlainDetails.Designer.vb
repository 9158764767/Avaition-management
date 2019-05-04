<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlainDetails
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
        Dim Aeroplane_TypeLabel As System.Windows.Forms.Label
        Dim No_Of_EmployeesLabel As System.Windows.Forms.Label
        Dim No_Of_PilotsLabel As System.Windows.Forms.Label
        Dim Type_Of_Landing_GairsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlainDetails))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.PlanedetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanedetailsTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.PlanedetailsTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.PlanedetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PlanedetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Aeroplane_TypeTextBox = New System.Windows.Forms.TextBox
        Me.No_Of_EmployeesTextBox = New System.Windows.Forms.TextBox
        Me.No_Of_PilotsTextBox = New System.Windows.Forms.TextBox
        Me.Type_Of_Landing_GairsTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.AeroplaneTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoOfEmployeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoOfPilotsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeOfLandingGairsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Aeroplane_TypeLabel = New System.Windows.Forms.Label
        No_Of_EmployeesLabel = New System.Windows.Forms.Label
        No_Of_PilotsLabel = New System.Windows.Forms.Label
        Type_Of_Landing_GairsLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanedetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanedetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanedetailsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Aeroplane_TypeLabel
        '
        Aeroplane_TypeLabel.AutoSize = True
        Aeroplane_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Aeroplane_TypeLabel.Location = New System.Drawing.Point(195, 129)
        Aeroplane_TypeLabel.Name = "Aeroplane_TypeLabel"
        Aeroplane_TypeLabel.Size = New System.Drawing.Size(100, 13)
        Aeroplane_TypeLabel.TabIndex = 1
        Aeroplane_TypeLabel.Text = "Aeroplane Type:"
        '
        'No_Of_EmployeesLabel
        '
        No_Of_EmployeesLabel.AutoSize = True
        No_Of_EmployeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_Of_EmployeesLabel.Location = New System.Drawing.Point(195, 155)
        No_Of_EmployeesLabel.Name = "No_Of_EmployeesLabel"
        No_Of_EmployeesLabel.Size = New System.Drawing.Size(108, 13)
        No_Of_EmployeesLabel.TabIndex = 3
        No_Of_EmployeesLabel.Text = "No Of Employees:"
        '
        'No_Of_PilotsLabel
        '
        No_Of_PilotsLabel.AutoSize = True
        No_Of_PilotsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_Of_PilotsLabel.Location = New System.Drawing.Point(195, 181)
        No_Of_PilotsLabel.Name = "No_Of_PilotsLabel"
        No_Of_PilotsLabel.Size = New System.Drawing.Size(79, 13)
        No_Of_PilotsLabel.TabIndex = 5
        No_Of_PilotsLabel.Text = "No Of Pilots:"
        '
        'Type_Of_Landing_GairsLabel
        '
        Type_Of_Landing_GairsLabel.AutoSize = True
        Type_Of_Landing_GairsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.333333!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Type_Of_Landing_GairsLabel.Location = New System.Drawing.Point(195, 207)
        Type_Of_Landing_GairsLabel.Name = "Type_Of_Landing_GairsLabel"
        Type_Of_Landing_GairsLabel.Size = New System.Drawing.Size(138, 13)
        Type_Of_Landing_GairsLabel.TabIndex = 7
        Type_Of_Landing_GairsLabel.Text = "Type Of Landing Gairs:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanedetailsBindingSource
        '
        Me.PlanedetailsBindingSource.DataMember = "Planedetails"
        Me.PlanedetailsBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'PlanedetailsTableAdapter
        '
        Me.PlanedetailsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Me.PlanedetailsTableAdapter
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'PlanedetailsBindingNavigator
        '
        Me.PlanedetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanedetailsBindingNavigator.BindingSource = Me.PlanedetailsBindingSource
        Me.PlanedetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanedetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanedetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanedetailsBindingNavigatorSaveItem})
        Me.PlanedetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanedetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanedetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanedetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanedetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanedetailsBindingNavigator.Name = "PlanedetailsBindingNavigator"
        Me.PlanedetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanedetailsBindingNavigator.Size = New System.Drawing.Size(748, 26)
        Me.PlanedetailsBindingNavigator.TabIndex = 0
        Me.PlanedetailsBindingNavigator.Text = "BindingNavigator1"
        Me.PlanedetailsBindingNavigator.Visible = False
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
        'PlanedetailsBindingNavigatorSaveItem
        '
        Me.PlanedetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanedetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanedetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanedetailsBindingNavigatorSaveItem.Name = "PlanedetailsBindingNavigatorSaveItem"
        Me.PlanedetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PlanedetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Aeroplane_TypeTextBox
        '
        Me.Aeroplane_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanedetailsBindingSource, "Aeroplane Type", True))
        Me.Aeroplane_TypeTextBox.Location = New System.Drawing.Point(364, 129)
        Me.Aeroplane_TypeTextBox.Name = "Aeroplane_TypeTextBox"
        Me.Aeroplane_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Aeroplane_TypeTextBox.TabIndex = 2
        '
        'No_Of_EmployeesTextBox
        '
        Me.No_Of_EmployeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanedetailsBindingSource, "No Of Employees", True))
        Me.No_Of_EmployeesTextBox.Location = New System.Drawing.Point(364, 155)
        Me.No_Of_EmployeesTextBox.Name = "No_Of_EmployeesTextBox"
        Me.No_Of_EmployeesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_EmployeesTextBox.TabIndex = 4
        '
        'No_Of_PilotsTextBox
        '
        Me.No_Of_PilotsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanedetailsBindingSource, "No Of Pilots", True))
        Me.No_Of_PilotsTextBox.Location = New System.Drawing.Point(364, 181)
        Me.No_Of_PilotsTextBox.Name = "No_Of_PilotsTextBox"
        Me.No_Of_PilotsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_PilotsTextBox.TabIndex = 6
        '
        'Type_Of_Landing_GairsTextBox
        '
        Me.Type_Of_Landing_GairsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanedetailsBindingSource, "Type Of Landing Gairs", True))
        Me.Type_Of_Landing_GairsTextBox.Location = New System.Drawing.Point(364, 207)
        Me.Type_Of_Landing_GairsTextBox.Name = "Type_Of_Landing_GairsTextBox"
        Me.Type_Of_Landing_GairsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Type_Of_Landing_GairsTextBox.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AeroplaneTypeDataGridViewTextBoxColumn, Me.NoOfEmployeesDataGridViewTextBoxColumn, Me.NoOfPilotsDataGridViewTextBoxColumn, Me.TypeOfLandingGairsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PlanedetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(609, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(334, 204)
        Me.DataGridView1.TabIndex = 9
        '
        'AeroplaneTypeDataGridViewTextBoxColumn
        '
        Me.AeroplaneTypeDataGridViewTextBoxColumn.DataPropertyName = "Aeroplane Type"
        Me.AeroplaneTypeDataGridViewTextBoxColumn.HeaderText = "Aeroplane Type"
        Me.AeroplaneTypeDataGridViewTextBoxColumn.Name = "AeroplaneTypeDataGridViewTextBoxColumn"
        '
        'NoOfEmployeesDataGridViewTextBoxColumn
        '
        Me.NoOfEmployeesDataGridViewTextBoxColumn.DataPropertyName = "No Of Employees"
        Me.NoOfEmployeesDataGridViewTextBoxColumn.HeaderText = "No Of Employees"
        Me.NoOfEmployeesDataGridViewTextBoxColumn.Name = "NoOfEmployeesDataGridViewTextBoxColumn"
        '
        'NoOfPilotsDataGridViewTextBoxColumn
        '
        Me.NoOfPilotsDataGridViewTextBoxColumn.DataPropertyName = "No Of Pilots"
        Me.NoOfPilotsDataGridViewTextBoxColumn.HeaderText = "No Of Pilots"
        Me.NoOfPilotsDataGridViewTextBoxColumn.Name = "NoOfPilotsDataGridViewTextBoxColumn"
        '
        'TypeOfLandingGairsDataGridViewTextBoxColumn
        '
        Me.TypeOfLandingGairsDataGridViewTextBoxColumn.DataPropertyName = "Type Of Landing Gairs"
        Me.TypeOfLandingGairsDataGridViewTextBoxColumn.HeaderText = "Type Of Landing Gairs"
        Me.TypeOfLandingGairsDataGridViewTextBoxColumn.Name = "TypeOfLandingGairsDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Coral
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(374, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 30)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Coral
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(257, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 30)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Coral
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(374, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 31)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(257, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 31)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 40)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Aeroplane Details"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(987, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 31)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Coral
        Me.Button6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(316, 388)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 31)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PlainDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 487)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Aeroplane_TypeLabel)
        Me.Controls.Add(Me.Aeroplane_TypeTextBox)
        Me.Controls.Add(No_Of_EmployeesLabel)
        Me.Controls.Add(Me.No_Of_EmployeesTextBox)
        Me.Controls.Add(No_Of_PilotsLabel)
        Me.Controls.Add(Me.No_Of_PilotsTextBox)
        Me.Controls.Add(Type_Of_Landing_GairsLabel)
        Me.Controls.Add(Me.Type_Of_Landing_GairsTextBox)
        Me.Controls.Add(Me.PlanedetailsBindingNavigator)
        Me.Name = "PlainDetails"
        Me.Text = "PlainDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanedetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanedetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanedetailsBindingNavigator.ResumeLayout(False)
        Me.PlanedetailsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents PlanedetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanedetailsTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.PlanedetailsTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanedetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PlanedetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Aeroplane_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_Of_EmployeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_Of_PilotsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Type_Of_Landing_GairsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AeroplaneTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfEmployeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfPilotsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfLandingGairsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
