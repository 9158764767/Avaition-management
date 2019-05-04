Public Class PlainDetails

    Private Sub PlanedetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanedetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanedetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub PlainDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Planedetails' table. You can move, or remove it, as needed.
        Me.PlanedetailsTableAdapter.Fill(Me.AircraftMSDataSet.Planedetails)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PlanedetailsBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            PlanedetailsBindingSource.EndEdit()
            PlanedetailsTableAdapter.Update(AircraftMSDataSet.Planedetails)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PlanedetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            PlanedetailsBindingSource.EndEdit()
            PlanedetailsTableAdapter.Update(AircraftMSDataSet.Planedetails)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub
End Class