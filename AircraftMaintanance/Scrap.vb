Public Class Scrap

    Private Sub ScrapBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ScrapBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AircraftMSDataSet)

    End Sub

    Private Sub Scrap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AircraftMSDataSet.Scrap' table. You can move, or remove it, as needed.
        Me.ScrapTableAdapter.Fill(Me.AircraftMSDataSet.Scrap)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ScrapBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ScrapBindingSource.EndEdit()
            ScrapTableAdapter.Update(AircraftMSDataSet.Scrap)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ScrapBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox17.Text = Cocpit_PartsTextBox.Text
        TextBox18.Text = Wing_PartsTextBox.Text
        TextBox19.Text = Landing_GairsTextBox.Text
        TextBox20.Text = StabilizersTextBox.Text
        TextBox21.Text = ElevatorsTextBox.Text
        TextBox22.Text = FuselageTextBox.Text
        TextBox23.Text = Interior_PartsTextBox.Text
        TextBox9.Text = TextBox1.Text
        TextBox10.Text = TextBox2.Text
        TextBox11.Text = TextBox3.Text
        TextBox12.Text = TextBox4.Text
        TextBox13.Text = TextBox5.Text
        TextBox14.Text = TextBox6.Text
        TextBox15.Text = TextBox7.Text
        Label13.Text = Convert.ToInt32(TextBox17.Text)*Convert.ToInt32(TextBox9.Text)
        Label14.Text = Convert.ToInt32(TextBox17.Text) * Convert.ToInt32(TextBox10.Text)
        Label15.Text = Convert.ToInt32(TextBox18.Text) * Convert.ToInt32(TextBox11.Text)
        Label16.Text = Convert.ToInt32(TextBox19.Text) * Convert.ToInt32(TextBox12.Text)
        Label17.Text = Convert.ToInt32(TextBox20.Text) * Convert.ToInt32(TextBox13.Text)
        Label18.Text = Convert.ToInt32(TextBox21.Text) * Convert.ToInt32(TextBox14.Text)
        Label19.Text = Convert.ToInt32(TextBox22.Text) * Convert.ToInt32(TextBox15.Text)
        lblTotalCost.Text = Convert.ToInt32(Label13.Text) + Convert.ToInt32(Label14.Text) + Convert.ToInt32(Label15.Text) + Convert.ToInt32(Label16.Text) + Convert.ToInt32(Label17.Text) + Convert.ToInt32(Label18.Text) + Convert.ToInt32(Label19.Text)
        Panel1.Visible = True
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ScrapBindingSource.EndEdit()
            ScrapTableAdapter.Update(AircraftMSDataSet.Scrap)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while sabving data")
        End Try

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form5.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            ScrapBindingSource.EndEdit()
            ScrapTableAdapter.Update(AircraftMSDataSet.Scrap)
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured while Updating data")
        End Try
    End Sub
End Class