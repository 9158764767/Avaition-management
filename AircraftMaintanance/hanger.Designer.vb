<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hanger
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
        Dim No_Of_HangersLabel As System.Windows.Forms.Label
        Dim Busy_HangersLabel As System.Windows.Forms.Label
        Dim Available_HangersLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hanger))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Hanger_ManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hanger_ManagementTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Hanger_ManagementTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Hanger_ManagementBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Hanger_ManagementBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.No_Of_HangersTextBox = New System.Windows.Forms.TextBox
        Me.Busy_HangersTextBox = New System.Windows.Forms.TextBox
        Me.Available_HangersTextBox = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NoOfHangersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BusyHangersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AvailableHangersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        No_Of_HangersLabel = New System.Windows.Forms.Label
        Busy_HangersLabel = New System.Windows.Forms.Label
        Available_HangersLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hanger_ManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hanger_ManagementBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Hanger_ManagementBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'No_Of_HangersLabel
        '
        No_Of_HangersLabel.AutoSize = True
        No_Of_HangersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_Of_HangersLabel.Location = New System.Drawing.Point(173, 141)
        No_Of_HangersLabel.Name = "No_Of_HangersLabel"
        No_Of_HangersLabel.Size = New System.Drawing.Size(105, 13)
        No_Of_HangersLabel.TabIndex = 1
        No_Of_HangersLabel.Text = "No Of Hangers:"
        '
        'Busy_HangersLabel
        '
        Busy_HangersLabel.AutoSize = True
        Busy_HangersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Busy_HangersLabel.Location = New System.Drawing.Point(173, 167)
        Busy_HangersLabel.Name = "Busy_HangersLabel"
        Busy_HangersLabel.Size = New System.Drawing.Size(99, 13)
        Busy_HangersLabel.TabIndex = 3
        Busy_HangersLabel.Text = "Busy Hangers:"
        '
        'Available_HangersLabel
        '
        Available_HangersLabel.AutoSize = True
        Available_HangersLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Available_HangersLabel.Location = New System.Drawing.Point(173, 193)
        Available_HangersLabel.Name = "Available_HangersLabel"
        Available_HangersLabel.Size = New System.Drawing.Size(129, 13)
        Available_HangersLabel.TabIndex = 5
        Available_HangersLabel.Text = "Available Hangers:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hanger_ManagementBindingSource
        '
        Me.Hanger_ManagementBindingSource.DataMember = "Hanger Management"
        Me.Hanger_ManagementBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Hanger_ManagementTableAdapter
        '
        Me.Hanger_ManagementTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Hanger_ManagementTableAdapter = Me.Hanger_ManagementTableAdapter
        Me.TableAdapterManager.Monthly_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.Order_FormTableAdapter = Nothing
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Nothing
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Hanger_ManagementBindingNavigator
        '
        Me.Hanger_ManagementBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Hanger_ManagementBindingNavigator.BindingSource = Me.Hanger_ManagementBindingSource
        Me.Hanger_ManagementBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Hanger_ManagementBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Hanger_ManagementBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Hanger_ManagementBindingNavigatorSaveItem})
        Me.Hanger_ManagementBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Hanger_ManagementBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Hanger_ManagementBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Hanger_ManagementBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Hanger_ManagementBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Hanger_ManagementBindingNavigator.Name = "Hanger_ManagementBindingNavigator"
        Me.Hanger_ManagementBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Hanger_ManagementBindingNavigator.Size = New System.Drawing.Size(649, 26)
        Me.Hanger_ManagementBindingNavigator.TabIndex = 0
        Me.Hanger_ManagementBindingNavigator.Text = "BindingNavigator1"
        Me.Hanger_ManagementBindingNavigator.Visible = False
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
        'Hanger_ManagementBindingNavigatorSaveItem
        '
        Me.Hanger_ManagementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Hanger_ManagementBindingNavigatorSaveItem.Image = CType(resources.GetObject("Hanger_ManagementBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Hanger_ManagementBindingNavigatorSaveItem.Name = "Hanger_ManagementBindingNavigatorSaveItem"
        Me.Hanger_ManagementBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Hanger_ManagementBindingNavigatorSaveItem.Text = "Save Data"
        '
        'No_Of_HangersTextBox
        '
        Me.No_Of_HangersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hanger_ManagementBindingSource, "No Of Hangers", True))
        Me.No_Of_HangersTextBox.Location = New System.Drawing.Point(350, 134)
        Me.No_Of_HangersTextBox.Name = "No_Of_HangersTextBox"
        Me.No_Of_HangersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_HangersTextBox.TabIndex = 2
        '
        'Busy_HangersTextBox
        '
        Me.Busy_HangersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hanger_ManagementBindingSource, "Busy Hangers", True))
        Me.Busy_HangersTextBox.Location = New System.Drawing.Point(350, 160)
        Me.Busy_HangersTextBox.Name = "Busy_HangersTextBox"
        Me.Busy_HangersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Busy_HangersTextBox.TabIndex = 4
        '
        'Available_HangersTextBox
        '
        Me.Available_HangersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hanger_ManagementBindingSource, "Available Hangers", True))
        Me.Available_HangersTextBox.Location = New System.Drawing.Point(350, 186)
        Me.Available_HangersTextBox.Name = "Available_HangersTextBox"
        Me.Available_HangersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Available_HangersTextBox.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Coral
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(316, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 36)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Coral
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(199, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 36)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Coral
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(316, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 37)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(199, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoOfHangersDataGridViewTextBoxColumn, Me.BusyHangersDataGridViewTextBoxColumn, Me.AvailableHangersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Hanger_ManagementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(544, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 206)
        Me.DataGridView1.TabIndex = 28
        '
        'NoOfHangersDataGridViewTextBoxColumn
        '
        Me.NoOfHangersDataGridViewTextBoxColumn.DataPropertyName = "No Of Hangers"
        Me.NoOfHangersDataGridViewTextBoxColumn.HeaderText = "No Of Hangers"
        Me.NoOfHangersDataGridViewTextBoxColumn.Name = "NoOfHangersDataGridViewTextBoxColumn"
        '
        'BusyHangersDataGridViewTextBoxColumn
        '
        Me.BusyHangersDataGridViewTextBoxColumn.DataPropertyName = "Busy Hangers"
        Me.BusyHangersDataGridViewTextBoxColumn.HeaderText = "Busy Hangers"
        Me.BusyHangersDataGridViewTextBoxColumn.Name = "BusyHangersDataGridViewTextBoxColumn"
        '
        'AvailableHangersDataGridViewTextBoxColumn
        '
        Me.AvailableHangersDataGridViewTextBoxColumn.DataPropertyName = "Available Hangers"
        Me.AvailableHangersDataGridViewTextBoxColumn.HeaderText = "Available Hangers"
        Me.AvailableHangersDataGridViewTextBoxColumn.Name = "AvailableHangersDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(309, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 40)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Hanger Management"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Coral
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(199, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 37)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'hanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 461)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(No_Of_HangersLabel)
        Me.Controls.Add(Me.No_Of_HangersTextBox)
        Me.Controls.Add(Busy_HangersLabel)
        Me.Controls.Add(Me.Busy_HangersTextBox)
        Me.Controls.Add(Available_HangersLabel)
        Me.Controls.Add(Me.Available_HangersTextBox)
        Me.Controls.Add(Me.Hanger_ManagementBindingNavigator)
        Me.Name = "hanger"
        Me.Text = "hanger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hanger_ManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hanger_ManagementBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Hanger_ManagementBindingNavigator.ResumeLayout(False)
        Me.Hanger_ManagementBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Hanger_ManagementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hanger_ManagementTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Hanger_ManagementTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Hanger_ManagementBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Hanger_ManagementBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents No_Of_HangersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Busy_HangersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Available_HangersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NoOfHangersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BusyHangersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableHangersDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
