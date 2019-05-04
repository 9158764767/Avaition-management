Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New AircraftMSDataSet
        Dim ad As New AircraftMSDataSetTableAdapters.Damage_EstimateTableAdapter
        ad.Fill(ds.Damage_Estimate)
        Dim rpt As New CrystalReport3
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class