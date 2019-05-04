Public Class DamageAnalisys

    Private Sub DamageAnalysisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageAnalysisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DamageAnalysisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub DamageAnalisys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.DamageAnalysis' table. You can move, or remove it, as needed.
        Me.DamageAnalysisTableAdapter.Fill(Me.AircraftMSDataSet.DamageAnalysis)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DamageAnalysisBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            DamageAnalysisBindingSource.EndEdit()
            DamageAnalysisTableAdapter.Update(AircraftMSDataSet.DamageAnalysis)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DamageAnalysisBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            DamageAnalysisBindingSource.EndEdit()
            DamageAnalysisTableAdapter.Update(AircraftMSDataSet.DamageAnalysis)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.DamageAnalysisTableAdapter.FillBy(Me.AircraftMSDataSet.DamageAnalysis)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class