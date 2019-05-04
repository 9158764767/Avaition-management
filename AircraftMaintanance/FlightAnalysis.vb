Public Class FlightAnalysis

    Private Sub Flight_AnalysisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Flight_AnalysisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Flight_AnalysisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub FlightAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Flight_Analysis' table. You can move, or remove it, as needed.
        Me.Flight_AnalysisTableAdapter.Fill(Me.AircraftMSDataSet.Flight_Analysis)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Flight_AnalysisBindingSource.EndEdit()
            Flight_AnalysisTableAdapter.Update(AircraftMSDataSet.Flight_Analysis)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Flight_AnalysisBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Flight_AnalysisBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Flight_AnalysisBindingSource.EndEdit()
            Flight_AnalysisTableAdapter.Update(AircraftMSDataSet.Flight_Analysis)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub
End Class