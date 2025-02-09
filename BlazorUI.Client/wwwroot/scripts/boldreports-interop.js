// Interop file to render the Bold Report Viewer component with properties.
window.BoldReports = {
    RenderViewer: function (elementID, reportViewerOptions) {
        $("#" + elementID).boldReportViewer({
            reportPath: reportViewerOptions.ReportPath,
            reportServiceUrl: reportViewerOptions.ServiceURL
        });
    }
}