Public Class Form1

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.users' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim login = UsersTableAdapter.UserPasswordString(UserTextBox.Text, PasswordTextBox.Text)
        If login Is Nothing Then
            MsgBox("Check user or password", MsgBoxStyle.Critical)
        Else
            MsgBox("Hi Welcome", MsgBoxStyle.Information)
            Homepage.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
    End Sub
End Class
