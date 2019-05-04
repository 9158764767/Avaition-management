Public Class Bill

    Private Sub BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.AircraftMSDataSet.Bill)
        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BillBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            BillBindingSource.EndEdit()
            BillTableAdapter.Update(AircraftMSDataSet.Bill)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BillBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Quantity = Convert.ToInt32(QuantityTextBox.Text)
        Dim Cost = Convert.ToInt32(CostTextBox.Text)
        Dim Bill = 0
        Bill = Quantity * Cost

        lblparts.Text = PartsTextBox.Text
        lblqty.Text = Quantity.ToString()
        lblcost.Text = Cost.ToString()
        lbltotalcost.Text = Bill.ToString()
        Panel1.Visible = True

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            BillBindingSource.EndEdit()
            BillTableAdapter.Update(AircraftMSDataSet.Bill)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while Updating data")
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False
    End Sub

    Private Sub Button7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button7_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub
End Class