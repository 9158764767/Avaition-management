Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New AircraftMSDataSet
        Dim ad As New AircraftMSDataSetTableAdapters.EmployeesTableAdapter
        ad.Fill(ds.Employees)
        Dim rpt As New CrystalReport2
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
End Class