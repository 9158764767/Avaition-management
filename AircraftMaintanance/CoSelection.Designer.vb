<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoSelection
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
        Dim Company_NameLabel As System.Windows.Forms.Label
        Dim Select_Yes_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoSelection))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.Company_nameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Company_nameTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.Company_nameTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.Company_nameBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Company_nameBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Company_NameTextBox = New System.Windows.Forms.TextBox
        Me.Select_Yes_NoCheckBox = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SelectYesNoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Company_NameLabel = New System.Windows.Forms.Label
        Select_Yes_NoLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_nameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_nameBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Company_nameBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Company_NameLabel
        '
        Company_NameLabel.AutoSize = True
        Company_NameLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Company_NameLabel.Location = New System.Drawing.Point(6, 133)
        Company_NameLabel.Name = "Company_NameLabel"
        Company_NameLabel.Size = New System.Drawing.Size(103, 13)
        Company_NameLabel.TabIndex = 1
        Company_NameLabel.Text = "Company Name:"
        '
        'Select_Yes_NoLabel
        '
        Select_Yes_NoLabel.AutoSize = True
        Select_Yes_NoLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Select_Yes_NoLabel.Location = New System.Drawing.Point(6, 161)
        Select_Yes_NoLabel.Name = "Select_Yes_NoLabel"
        Select_Yes_NoLabel.Size = New System.Drawing.Size(103, 13)
        Select_Yes_NoLabel.TabIndex = 3
        Select_Yes_NoLabel.Text = "Select Yes/No:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_nameBindingSource
        '
        Me.Company_nameBindingSource.DataMember = "Company name"
        Me.Company_nameBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'Company_nameTableAdapter
        '
        Me.Company_nameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Available_StockTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Nothing
        Me.TableAdapterManager.BranchesTableAdapter = Nothing
        Me.TableAdapterManager.Company_ManagementTableAdapter = Nothing
        Me.TableAdapterManager.Company_nameTableAdapter = Me.Company_nameTableAdapter
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
        'Company_nameBindingNavigator
        '
        Me.Company_nameBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Company_nameBindingNavigator.BindingSource = Me.Company_nameBindingSource
        Me.Company_nameBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Company_nameBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Company_nameBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Company_nameBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.Company_nameBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Company_nameBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Company_nameBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Company_nameBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Company_nameBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Company_nameBindingNavigator.Name = "Company_nameBindingNavigator"
        Me.Company_nameBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Company_nameBindingNavigator.Size = New System.Drawing.Size(675, 26)
        Me.Company_nameBindingNavigator.TabIndex = 0
        Me.Company_nameBindingNavigator.Text = "BindingNavigator1"
        Me.Company_nameBindingNavigator.Visible = False
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
        'Company_nameBindingNavigatorSaveItem
        '
        Me.Company_nameBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Company_nameBindingNavigatorSaveItem.Image = CType(resources.GetObject("Company_nameBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Company_nameBindingNavigatorSaveItem.Name = "Company_nameBindingNavigatorSaveItem"
        Me.Company_nameBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Company_nameBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Company_NameTextBox
        '
        Me.Company_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_nameBindingSource, "Company Name", True))
        Me.Company_NameTextBox.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company_NameTextBox.Location = New System.Drawing.Point(136, 130)
        Me.Company_NameTextBox.Name = "Company_NameTextBox"
        Me.Company_NameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Company_NameTextBox.TabIndex = 2
        '
        'Select_Yes_NoCheckBox
        '
        Me.Select_Yes_NoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Company_nameBindingSource, "Select Yes/No", True))
        Me.Select_Yes_NoCheckBox.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Yes_NoCheckBox.Location = New System.Drawing.Point(136, 156)
        Me.Select_Yes_NoCheckBox.Name = "Select_Yes_NoCheckBox"
        Me.Select_Yes_NoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Select_Yes_NoCheckBox.TabIndex = 4
        Me.Select_Yes_NoCheckBox.Text = "Yes/No"
        Me.Select_Yes_NoCheckBox.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyNameDataGridViewTextBoxColumn, Me.SelectYesNoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.Company_nameBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(296, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(243, 151)
        Me.DataGridView1.TabIndex = 5
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "Company Name"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        '
        'SelectYesNoDataGridViewCheckBoxColumn
        '
        Me.SelectYesNoDataGridViewCheckBoxColumn.DataPropertyName = "Select Yes/No"
        Me.SelectYesNoDataGridViewCheckBoxColumn.HeaderText = "Select Yes/No"
        Me.SelectYesNoDataGridViewCheckBoxColumn.Name = "SelectYesNoDataGridViewCheckBoxColumn"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(148, 286)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 36)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(31, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(148, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(31, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Company Selection For Maintenance Parts"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(31, 346)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 37)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CoSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(675, 473)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Company_NameLabel)
        Me.Controls.Add(Me.Company_NameTextBox)
        Me.Controls.Add(Select_Yes_NoLabel)
        Me.Controls.Add(Me.Select_Yes_NoCheckBox)
        Me.Controls.Add(Me.Company_nameBindingNavigator)
        Me.Name = "CoSelection"
        Me.Text = "CoSelection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_nameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_nameBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Company_nameBindingNavigator.ResumeLayout(False)
        Me.Company_nameBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents Company_nameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Company_nameTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.Company_nameTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Company_nameBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Company_nameBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Company_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Select_Yes_NoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectYesNoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
