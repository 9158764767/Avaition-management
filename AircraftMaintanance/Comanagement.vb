Public Class Comanagement

    Private Sub Company_ManagementBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Company_ManagementBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Company_ManagementBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub Comanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Company_Management' table. You can move, or remove it, as needed.
        Me.Company_ManagementTableAdapter.Fill(Me.AircraftMSDataSet.Company_Management)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Company_ManagementBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Company_ManagementBindingSource.EndEdit()
            Company_ManagementTableAdapter.Update(AircraftMSDataSet.Company_Management)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Company_ManagementBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Company_ManagementBindingSource.EndEdit()
            Company_ManagementTableAdapter.Update(AircraftMSDataSet.Company_Management)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub
End Class