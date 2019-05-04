Public Class MonthReports

    Private Sub Monthly_ReportsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monthly_ReportsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Monthly_ReportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub MonthReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Monthly_Reports' table. You can move, or remove it, as needed.
        Me.Monthly_ReportsTableAdapter.Fill(Me.AircraftMSDataSet.Monthly_Reports)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Monthly_ReportsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Monthly_ReportsBindingSource.EndEdit()
            Monthly_ReportsTableAdapter.Update(AircraftMSDataSet.Monthly_Reports)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Monthly_ReportsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label10.Text = No_Of_Aircraft_RepairTextBox.Text
        Label11.Text = Total_No_Of_ScrapTextBox.Text
        Label12.Text = Total_Manpower_RequiredTextBox.Text
        Label17.Text = TextBox1.Text
        Label16.Text = TextBox2.Text
        Label15.Text = TextBox3.Text
        Label22.Text = Convert.ToInt32(Label10.Text) * Convert.ToInt32(Label17.Text)
        Label21.Text = Convert.ToInt32(Label11.Text) * Convert.ToInt32(Label16.Text)
        Label20.Text = Convert.ToInt32(Label12.Text) * Convert.ToInt32(Label15.Text)

        lblFinalCost.Text = Convert.ToInt32(Label20.Text) + Convert.ToInt32(Label21.Text) + Convert.ToInt32(Label22.Text)
        Total_CostTextBox.Text = lblFinalCost.Text
        Panel1.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Monthly_ReportsBindingSource.EndEdit()
            Monthly_ReportsTableAdapter.Update(AircraftMSDataSet.Monthly_Reports)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form6.Show()
    End Sub
End Class