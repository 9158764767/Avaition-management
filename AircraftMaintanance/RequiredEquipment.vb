Public Class RequiredEquipment

    Private Sub EquipmentRequiredBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentRequiredBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipmentRequiredBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub RequiredEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.EquipmentRequired' table. You can move, or remove it, as needed.
        Me.EquipmentRequiredTableAdapter.Fill(Me.AircraftMSDataSet.EquipmentRequired)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EquipmentRequiredBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            EquipmentRequiredBindingSource.EndEdit()
            EquipmentRequiredTableAdapter.Update(AircraftMSDataSet.EquipmentRequired)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EquipmentRequiredBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            EquipmentRequiredBindingSource.EndEdit()
            EquipmentRequiredTableAdapter.Update(AircraftMSDataSet.EquipmentRequired)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub
End Class