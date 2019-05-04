<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class branches
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
        Dim Branch_NameLabel As System.Windows.Forms.Label
        Dim Branch_codeLabel As System.Windows.Forms.Label
        Dim Branch_AddressLabel As System.Windows.Forms.Label
        Dim Branch_HeadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(branches))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.BranchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchesTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.BranchesTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.BranchesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BranchesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Branch_NameTextBox = New System.Windows.Forms.TextBox
        Me.Branch_codeTextBox = New System.Windows.Forms.TextBox
        Me.Branch_AddressTextBox = New System.Windows.Forms.TextBox
        Me.Branch_HeadTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BranchNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BranchCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BranchAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BranchHeadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Branch_NameLabel = New System.Windows.Forms.Label
        Branch_codeLabel = New System.Windows.Forms.Label
        Branch_AddressLabel = New System.Windows.Forms.Label
        Branch_HeadLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BranchesBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Branch_NameLabel
        '
        Branch_NameLabel.AutoSize = True
        Branch_NameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Branch_NameLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_NameLabel.Location = New System.Drawing.Point(172, 134)
        Branch_NameLabel.Name = "Branch_NameLabel"
        Branch_NameLabel.Size = New System.Drawing.Size(135, 18)
        Branch_NameLabel.TabIndex = 1
        Branch_NameLabel.Text = "Branch Name:"
        '
        'Branch_codeLabel
        '
        Branch_codeLabel.AutoSize = True
        Branch_codeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Branch_codeLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_codeLabel.Location = New System.Drawing.Point(172, 157)
        Branch_codeLabel.Name = "Branch_codeLabel"
        Branch_codeLabel.Size = New System.Drawing.Size(130, 18)
        Branch_codeLabel.TabIndex = 3
        Branch_codeLabel.Text = "Branch code:"
        '
        'Branch_AddressLabel
        '
        Branch_AddressLabel.AutoSize = True
        Branch_AddressLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Branch_AddressLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_AddressLabel.Location = New System.Drawing.Point(172, 183)
        Branch_AddressLabel.Name = "Branch_AddressLabel"
        Branch_AddressLabel.Size = New System.Drawing.Size(163, 18)
        Branch_AddressLabel.TabIndex = 5
        Branch_AddressLabel.Text = "Branch Address:"
        '
        'Branch_HeadLabel
        '
        Branch_HeadLabel.AutoSize = True
        Branch_HeadLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Branch_HeadLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_HeadLabel.Location = New System.Drawing.Point(172, 209)
        Branch_HeadLabel.Name = "Branch_HeadLabel"
        Branch_HeadLabel.Size = New System.Drawing.Size(133, 18)
        Branch_HeadLabel.TabIndex = 7
        Branch_HeadLabel.Text = "Branch Head:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchesBindingSource
        '
        Me.BranchesBindingSource.DataMember = "Branches"
        Me.BranchesBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'BranchesTableAdapter
        '
        Me.BranchesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.BranchesTableAdapter = Me.BranchesTableAdapter
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
        'BranchesBindingNavigator
        '
        Me.BranchesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BranchesBindingNavigator.BindingSource = Me.BranchesBindingSource
        Me.BranchesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BranchesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BranchesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BranchesBindingNavigatorSaveItem})
        Me.BranchesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BranchesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BranchesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BranchesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BranchesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BranchesBindingNavigator.Name = "BranchesBindingNavigator"
        Me.BranchesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BranchesBindingNavigator.Size = New System.Drawing.Size(746, 26)
        Me.BranchesBindingNavigator.TabIndex = 0
        Me.BranchesBindingNavigator.Text = "BindingNavigator1"
        Me.BranchesBindingNavigator.Visible = False
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
        'BranchesBindingNavigatorSaveItem
        '
        Me.BranchesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BranchesBindingNavigatorSaveItem.Image = CType(resources.GetObject("BranchesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BranchesBindingNavigatorSaveItem.Name = "BranchesBindingNavigatorSaveItem"
        Me.BranchesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BranchesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Branch_NameTextBox
        '
        Me.Branch_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchesBindingSource, "Branch Name", True))
        Me.Branch_NameTextBox.Location = New System.Drawing.Point(343, 125)
        Me.Branch_NameTextBox.Name = "Branch_NameTextBox"
        Me.Branch_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Branch_NameTextBox.TabIndex = 2
        '
        'Branch_codeTextBox
        '
        Me.Branch_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchesBindingSource, "Branch code", True))
        Me.Branch_codeTextBox.Location = New System.Drawing.Point(343, 151)
        Me.Branch_codeTextBox.Name = "Branch_codeTextBox"
        Me.Branch_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Branch_codeTextBox.TabIndex = 4
        '
        'Branch_AddressTextBox
        '
        Me.Branch_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchesBindingSource, "Branch Address", True))
        Me.Branch_AddressTextBox.Location = New System.Drawing.Point(343, 177)
        Me.Branch_AddressTextBox.Name = "Branch_AddressTextBox"
        Me.Branch_AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Branch_AddressTextBox.TabIndex = 6
        '
        'Branch_HeadTextBox
        '
        Me.Branch_HeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchesBindingSource, "Branch Head", True))
        Me.Branch_HeadTextBox.Location = New System.Drawing.Point(343, 203)
        Me.Branch_HeadTextBox.Name = "Branch_HeadTextBox"
        Me.Branch_HeadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Branch_HeadTextBox.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BranchNameDataGridViewTextBoxColumn, Me.BranchCodeDataGridViewTextBoxColumn, Me.BranchAddressDataGridViewTextBoxColumn, Me.BranchHeadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BranchesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(504, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(436, 332)
        Me.DataGridView1.TabIndex = 9
        '
        'BranchNameDataGridViewTextBoxColumn
        '
        Me.BranchNameDataGridViewTextBoxColumn.DataPropertyName = "Branch Name"
        Me.BranchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name"
        Me.BranchNameDataGridViewTextBoxColumn.Name = "BranchNameDataGridViewTextBoxColumn"
        '
        'BranchCodeDataGridViewTextBoxColumn
        '
        Me.BranchCodeDataGridViewTextBoxColumn.DataPropertyName = "Branch code"
        Me.BranchCodeDataGridViewTextBoxColumn.HeaderText = "Branch code"
        Me.BranchCodeDataGridViewTextBoxColumn.Name = "BranchCodeDataGridViewTextBoxColumn"
        '
        'BranchAddressDataGridViewTextBoxColumn
        '
        Me.BranchAddressDataGridViewTextBoxColumn.DataPropertyName = "Branch Address"
        Me.BranchAddressDataGridViewTextBoxColumn.HeaderText = "Branch Address"
        Me.BranchAddressDataGridViewTextBoxColumn.Name = "BranchAddressDataGridViewTextBoxColumn"
        '
        'BranchHeadDataGridViewTextBoxColumn
        '
        Me.BranchHeadDataGridViewTextBoxColumn.DataPropertyName = "Branch Head"
        Me.BranchHeadDataGridViewTextBoxColumn.HeaderText = "Branch Head"
        Me.BranchHeadDataGridViewTextBoxColumn.Name = "BranchHeadDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(305, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 36)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(164, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 36)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(305, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 37)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(164, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 35)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Information Of All Branches"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(221, 380)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 36)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Update"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'branches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1009, 486)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Branch_NameLabel)
        Me.Controls.Add(Me.Branch_NameTextBox)
        Me.Controls.Add(Branch_codeLabel)
        Me.Controls.Add(Me.Branch_codeTextBox)
        Me.Controls.Add(Branch_AddressLabel)
        Me.Controls.Add(Me.Branch_AddressTextBox)
        Me.Controls.Add(Branch_HeadLabel)
        Me.Controls.Add(Me.Branch_HeadTextBox)
        Me.Controls.Add(Me.BranchesBindingNavigator)
        Me.Name = "branches"
        Me.Text = "branches"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BranchesBindingNavigator.ResumeLayout(False)
        Me.BranchesBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents BranchesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchesTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.BranchesTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BranchesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BranchesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Branch_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Branch_HeadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BranchNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchHeadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
