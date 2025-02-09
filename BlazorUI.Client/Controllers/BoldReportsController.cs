﻿using BoldReports.Web.ReportViewer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace BlazorUI.Client.Controllers;

[Route("api/{controller}/{action}/{id?}")]
public class BoldReportsController : Controller, IReportController
{
    // Report viewer requires a memory cache to store the information of consecutive client requests and
    // the rendered report viewer in the server.
    private IMemoryCache _cache;

    // IWebHostEnvironment used with sample to get the application data from wwwroot.
    private IWebHostEnvironment _hostingEnvironment;

    public BoldReportsController(IMemoryCache memoryCache, IWebHostEnvironment hostingEnvironment)
    {
        _cache = memoryCache;
        _hostingEnvironment = hostingEnvironment;
    }
    //Get action for getting resources from the report
    [ActionName("GetResource")]
    [AcceptVerbs("GET")]
    // Method will be called from Report Viewer client to get the image src for Image report item.
    public object GetResource(ReportResource resource)
    {
        return ReportHelper.GetResource(resource, this, _cache);
    }

    // Method will be called to initialize the report information to load the report with ReportHelper for processing.
    [NonAction]
    public void OnInitReportOptions(ReportViewerOptions reportOption)
    {
        string basePath = _hostingEnvironment.WebRootPath;
        // Here, we have loaded the sales-order-detail.rdl report from the application folder wwwrootResources. sales-order-detail.rdl should be located in the wwwrootResources application folder.
        FileStream inputStream = new FileStream(basePath + @"Reports" + reportOption.ReportModel.ReportPath + ".rdl", FileMode.Open, FileAccess.Read);
        MemoryStream reportStream = new MemoryStream();
        inputStream.CopyTo(reportStream);
        reportStream.Position = 0;
        inputStream.Close();
        reportOption.ReportModel.Stream = reportStream;
    }

    // Method will be called when report is loaded internally to start the layout process with ReportHelper.
    [NonAction]
    public void OnReportLoaded(ReportViewerOptions reportOption)
    {
    }

    [HttpPost]
    public object PostFormReportAction()
    {
        return ReportHelper.ProcessReport(null, this, _cache);
    }

    // Post action to process the report from the server based on json parameters and send the result back to the client.
    [HttpPost]
    public object PostReportAction([FromBody] Dictionary<string, object> jsonArray)
    {
        return ReportHelper.ProcessReport(jsonArray, this, _cache);
    }
}