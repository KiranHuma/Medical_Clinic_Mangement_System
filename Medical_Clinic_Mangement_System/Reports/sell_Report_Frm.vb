Imports Microsoft.Reporting.WinForms

Public Class sell_Report_Frm
    Private Sub sell_Report_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim testparameter1 As New ReportParameter("selldateParameter", dashboard_Frm.datePicker_Sell.Text)
        Dim testparameter2 As New ReportParameter("nameParameter", dashboard_Frm.patientName_txt.Text)

        Dim testparameter4 As New ReportParameter("priceParameter", dashboard_Frm.grand_Single_Pc.Text)
        Dim testparameter5 As New ReportParameter("sellquantityParameter", dashboard_Frm.sell_Qty_Txt.Text)
        Dim testparameter6 As New ReportParameter("sellbyParameter", dashboard_Frm.billby_txt.Text)
        Dim testparameter7 As New ReportParameter("listParameter", dashboard_Frm.product_List_Txt.Text)

        ReportViewer1.LocalReport.SetParameters(testparameter1)
        ReportViewer1.LocalReport.SetParameters(testparameter2)

        ReportViewer1.LocalReport.SetParameters(testparameter4)
        ReportViewer1.LocalReport.SetParameters(testparameter5)
        ReportViewer1.LocalReport.SetParameters(testparameter6)
        ReportViewer1.LocalReport.SetParameters(testparameter7)


        Me.ReportViewer1.RefreshReport()



    End Sub
End Class