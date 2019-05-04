<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repaint
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
        Dim Airplane_TypeLabel As System.Windows.Forms.Label
        Dim Wing_ColorLabel As System.Windows.Forms.Label
        Dim Airplane_Body_ColorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Repaint))
        Me.AircraftMSDataSet = New AircraftMaintanance.AircraftMSDataSet
        Me.RepaintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepaintTableAdapter = New AircraftMaintanance.AircraftMSDataSetTableAdapters.RepaintTableAdapter
        Me.TableAdapterManager = New AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
        Me.RepaintBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RepaintBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Airplane_TypeTextBox = New System.Windows.Forms.TextBox
        Me.Wing_ColorTextBox = New System.Windows.Forms.TextBox
        Me.Airplane_Body_ColorTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.AirplaneTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WingColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AirplaneBodyColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Airplane_TypeLabel = New System.Windows.Forms.Label
        Wing_ColorLabel = New System.Windows.Forms.Label
        Airplane_Body_ColorLabel = New System.Windows.Forms.Label
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepaintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepaintBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RepaintBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Airplane_TypeLabel
        '
        Airplane_TypeLabel.AutoSize = True
        Airplane_TypeLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Airplane_TypeLabel.Location = New System.Drawing.Point(190, 139)
        Airplane_TypeLabel.Name = "Airplane_TypeLabel"
        Airplane_TypeLabel.Size = New System.Drawing.Size(97, 13)
        Airplane_TypeLabel.TabIndex = 1
        Airplane_TypeLabel.Text = "Airplane Type:"
        '
        'Wing_ColorLabel
        '
        Wing_ColorLabel.AutoSize = True
        Wing_ColorLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Wing_ColorLabel.Location = New System.Drawing.Point(190, 165)
        Wing_ColorLabel.Name = "Wing_ColorLabel"
        Wing_ColorLabel.Size = New System.Drawing.Size(83, 13)
        Wing_ColorLabel.TabIndex = 3
        Wing_ColorLabel.Text = "Wing Color:"
        '
        'Airplane_Body_ColorLabel
        '
        Airplane_Body_ColorLabel.AutoSize = True
        Airplane_Body_ColorLabel.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Airplane_Body_ColorLabel.Location = New System.Drawing.Point(190, 191)
        Airplane_Body_ColorLabel.Name = "Airplane_Body_ColorLabel"
        Airplane_Body_ColorLabel.Size = New System.Drawing.Size(143, 13)
        Airplane_Body_ColorLabel.TabIndex = 5
        Airplane_Body_ColorLabel.Text = "Airplane Body Color:"
        '
        'AircraftMSDataSet
        '
        Me.AircraftMSDataSet.DataSetName = "AircraftMSDataSet"
        Me.AircraftMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepaintBindingSource
        '
        Me.RepaintBindingSource.DataMember = "Repaint"
        Me.RepaintBindingSource.DataSource = Me.AircraftMSDataSet
        '
        'RepaintTableAdapter
        '
        Me.RepaintTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PlanedetailsTableAdapter = Nothing
        Me.TableAdapterManager.RepaintTableAdapter = Me.RepaintTableAdapter
        Me.TableAdapterManager.ScrapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'RepaintBindingNavigator
        '
        Me.RepaintBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RepaintBindingNavigator.BindingSource = Me.RepaintBindingSource
        Me.RepaintBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RepaintBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RepaintBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RepaintBindingNavigatorSaveItem})
        Me.RepaintBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RepaintBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RepaintBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RepaintBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RepaintBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RepaintBindingNavigator.Name = "RepaintBindingNavigator"
        Me.RepaintBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RepaintBindingNavigator.Size = New System.Drawing.Size(758, 26)
        Me.RepaintBindingNavigator.TabIndex = 0
        Me.RepaintBindingNavigator.Text = "BindingNavigator1"
        Me.RepaintBindingNavigator.Visible = False
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
        'RepaintBindingNavigatorSaveItem
        '
        Me.RepaintBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RepaintBindingNavigatorSaveItem.Image = CType(resources.GetObject("RepaintBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RepaintBindingNavigatorSaveItem.Name = "RepaintBindingNavigatorSaveItem"
        Me.RepaintBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RepaintBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Airplane_TypeTextBox
        '
        Me.Airplane_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepaintBindingSource, "Airplane Type", True))
        Me.Airplane_TypeTextBox.Location = New System.Drawing.Point(348, 139)
        Me.Airplane_TypeTextBox.Name = "Airplane_TypeTextBox"
        Me.Airplane_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Airplane_TypeTextBox.TabIndex = 2
        '
        'Wing_ColorTextBox
        '
        Me.Wing_ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepaintBindingSource, "Wing Color", True))
        Me.Wing_ColorTextBox.Location = New System.Drawing.Point(348, 165)
        Me.Wing_ColorTextBox.Name = "Wing_ColorTextBox"
        Me.Wing_ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Wing_ColorTextBox.TabIndex = 4
        '
        'Airplane_Body_ColorTextBox
        '
        Me.Airplane_Body_ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepaintBindingSource, "Airplane Body Color", True))
        Me.Airplane_Body_ColorTextBox.Location = New System.Drawing.Point(348, 191)
        Me.Airplane_Body_ColorTextBox.Name = "Airplane_Body_ColorTextBox"
        Me.Airplane_Body_ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Airplane_Body_ColorTextBox.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AirplaneTypeDataGridViewTextBoxColumn, Me.WingColorDataGridViewTextBoxColumn, Me.AirplaneBodyColorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RepaintBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(498, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 280)
        Me.DataGridView1.TabIndex = 7
        '
        'AirplaneTypeDataGridViewTextBoxColumn
        '
        Me.AirplaneTypeDataGridViewTextBoxColumn.DataPropertyName = "Airplane Type"
        Me.AirplaneTypeDataGridViewTextBoxColumn.HeaderText = "Airplane Type"
        Me.AirplaneTypeDataGridViewTextBoxColumn.Name = "AirplaneTypeDataGridViewTextBoxColumn"
        '
        'WingColorDataGridViewTextBoxColumn
        '
        Me.WingColorDataGridViewTextBoxColumn.DataPropertyName = "Wing Color"
        Me.WingColorDataGridViewTextBoxColumn.HeaderText = "Wing Color"
        Me.WingColorDataGridViewTextBoxColumn.Name = "WingColorDataGridViewTextBoxColumn"
        '
        'AirplaneBodyColorDataGridViewTextBoxColumn
        '
        Me.AirplaneBodyColorDataGridViewTextBoxColumn.DataPropertyName = "Airplane Body Color"
        Me.AirplaneBodyColorDataGridViewTextBoxColumn.HeaderText = "Airplane Body Color"
        Me.AirplaneBodyColorDataGridViewTextBoxColumn.Name = "AirplaneBodyColorDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(348, 309)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 30)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(231, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 30)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 31)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(231, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 31)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Repaint Of Aircraft"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.333333!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(279, 369)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 31)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Repaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(870, 454)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Airplane_TypeLabel)
        Me.Controls.Add(Me.Airplane_TypeTextBox)
        Me.Controls.Add(Wing_ColorLabel)
        Me.Controls.Add(Me.Wing_ColorTextBox)
        Me.Controls.Add(Airplane_Body_ColorLabel)
        Me.Controls.Add(Me.Airplane_Body_ColorTextBox)
        Me.Controls.Add(Me.RepaintBindingNavigator)
        Me.Name = "Repaint"
        Me.Text = "Repaint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AircraftMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepaintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepaintBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RepaintBindingNavigator.ResumeLayout(False)
        Me.RepaintBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AircraftMSDataSet As AircraftMaintanance.AircraftMSDataSet
    Friend WithEvents RepaintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepaintTableAdapter As AircraftMaintanance.AircraftMSDataSetTableAdapters.RepaintTableAdapter
    Friend WithEvents TableAdapterManager As AircraftMaintanance.AircraftMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RepaintBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RepaintBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Airplane_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Wing_ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Airplane_Body_ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AirplaneTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WingColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AirplaneBodyColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
