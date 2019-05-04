Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New AircraftMSDataSet
        Dim ad As New AircraftMSDataSetTableAdapters.BillTableAdapter
        ad.Fill(ds.Bill)
        Dim rpt As New CrystalReport1
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class