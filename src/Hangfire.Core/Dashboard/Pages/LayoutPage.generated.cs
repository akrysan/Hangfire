﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    using System.Linq;
    
    #line 4 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"");


            
            #line 10 "..\..\Dashboard\Pages\LayoutPage.cshtml"
       Write(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n<head>\r\n    <title>");


            
            #line 12 "..\..\Dashboard\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - Hangfire</title>\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n " +
"   <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width" +
", initial-scale=1.0\">\r\n    <meta name=\"robots\" content=\"none\">\r\n");


            
            #line 17 "..\..\Dashboard\Pages\LayoutPage.cshtml"
     if (!String.IsNullOrWhiteSpace(Context.AntiforgeryHeader))
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral(" <meta name=\"csrf-header\" content=\"");


            
            #line 19 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                        Write(Context.AntiforgeryHeader);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 20 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    }

            
            #line default
            #line hidden

            
            #line 21 "..\..\Dashboard\Pages\LayoutPage.cshtml"
     if (!String.IsNullOrWhiteSpace(Context.AntiforgeryToken))
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral(" <meta name=\"csrf-token\" content=\"");


            
            #line 23 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                       Write(Context.AntiforgeryToken);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 24 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    }

            
            #line default
            #line hidden

            
            #line 25 "..\..\Dashboard\Pages\LayoutPage.cshtml"
       var version = GetType().GetTypeInfo().Assembly.GetName().Version; 

            
            #line default
            #line hidden
WriteLiteral("    <link rel=\"stylesheet\" href=\"");


            
            #line 26 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                            Write(Url.To($"/css{version.Major}{version.Minor}{version.Build}"));

            
            #line default
            #line hidden
WriteLiteral(@""">
</head>
    <body>
        <!-- Wrap all page content here -->
        <div id=""wrap"">

            <!-- Fixed navbar -->
            <div class=""navbar navbar-default navbar-fixed-top"">
                <div class=""container"">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                        <a class=""navbar-brand"" href=""");


            
            #line 41 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                 Write(Url.Home());

            
            #line default
            #line hidden
WriteLiteral("\">Hangfire Dashboard</a>\r\n                    </div>\r\n                    <div cl" +
"ass=\"collapse navbar-collapse\">\r\n                        ");


            
            #line 44 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Html.RenderPartial(new Navigation()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 45 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                         if(@AppPath != null) {

            
            #line default
            #line hidden
WriteLiteral("                            <ul class=\"nav navbar-nav navbar-right\">\r\n           " +
"                     <li>\r\n                                    <a href=\"");


            
            #line 48 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                        Write(AppPath);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        <span class=\"glyphicon glyphicon-log-" +
"out\"></span>\r\n                                        ");


            
            #line 50 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                   Write(Strings.LayoutPage_Back);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n                                </li>" +
"\r\n                            </ul>\r\n");


            
            #line 54 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                    <!--/.nav-collapse -->\r\n         " +
"       </div>\r\n            </div>\r\n\r\n            <!-- Begin page content -->\r\n  " +
"          <div class=\"container\" style=\"margin-bottom: 20px;\">\r\n                " +
"");


            
            #line 62 "..\..\Dashboard\Pages\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
            </div>
        </div>

        <div id=""footer"">
            <div class=""container"">
                <ul class=""list-inline credit"">
                    <li>
                        <a href=""https://www.hangfire.io/"" target=""_blank"" rel=""noopener noreferrer"">Hangfire ");


            
            #line 70 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                                                                          Write($"{version.Major}.{version.Minor}.{version.Build}");

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");


            
            #line 73 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                     if(DashboardOptions.DisplayStorageConnectionString){

            
            #line default
            #line hidden
WriteLiteral("                    <li>");


            
            #line 74 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Storage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");


            
            #line 75 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <li>");


            
            #line 76 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Strings.LayoutPage_Footer_Time);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 76 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                   Write(Html.LocalTime(DateTime.UtcNow));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");


            
            #line 77 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(String.Format(Strings.LayoutPage_Footer_Generatedms, GenerationTime.Elapsed.TotalMilliseconds.ToString("N")));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        \r\n     " +
"   <div id=\"hangfireConfig\"\r\n             data-pollinterval=\"");


            
            #line 83 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                           Write(DashboardOptions.StatsPollingInterval);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n             data-pollurl=\"");


            
            #line 84 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                       Write(Url.To("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        </div>\r\n\r\n        <script src=\"");


            
            #line 87 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                Write(Url.To($"/js{version.Major}{version.Minor}{version.Build}"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n");


            
            #line 77 "..\..\Dashboard\Pages\LayoutPage.cshtml"
         if (!string.IsNullOrWhiteSpace(CustomDashboardScriptUrl)) {

            
            #line default
            #line hidden
WriteLiteral("            <script src=\"");


            
            #line 78 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                    Write(CustomDashboardScriptUrl);

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n");


            
            #line 79 "..\..\Dashboard\Pages\LayoutPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
