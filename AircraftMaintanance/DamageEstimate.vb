Public Class DamageEstimate

    Private Sub Damage_EstimateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Damage_EstimateBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Damage_EstimateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub DamageEstimate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Damage_Estimate' table. You can move, or remove it, as needed.
        Me.Damage_EstimateTableAdapter.Fill(Me.AircraftMSDataSet.Damage_Estimate)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Damage_EstimateBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Damage_EstimateBindingSource.EndEdit()
            Damage_EstimateTableAdapter.Update(AircraftMSDataSet.Damage_Estimate)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Damage_EstimateBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Label3.Text = Convert.ToInt32(Cocpit_PartsTextBox.Text) + Convert.ToInt32(EnginesTextBox.Text) + Convert.ToInt32(StabilizersTextBox.Text) + Convert.ToInt32(ElevatorsTextBox.Text) + Convert.ToInt32(Landing_GairsTextBox.Text)
        Label11.Text = Label3.Text
        Panel1.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Damage_EstimateBindingSource.EndEdit()
            Damage_EstimateTableAdapter.Update(AircraftMSDataSet.Damage_Estimate)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while Updating data")
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Label11.Text = Label3.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form4.Show()
    End Sub
End Class