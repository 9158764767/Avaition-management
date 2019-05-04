Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New AircraftMSDataSet
        Dim ad As New AircraftMSDataSetTableAdapters.Monthly_ReportsTableAdapter
        ad.Fill(ds.Monthly_Reports)
        Dim rpt As New CrystalReport5
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class