Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New AircraftMSDataSet
        Dim ad As New AircraftMSDataSetTableAdapters.ScrapTableAdapter
        ad.Fill(ds.Scrap)
        Dim rpt As New CrystalReport4
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class