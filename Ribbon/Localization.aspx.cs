#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSampleBrowser.Ribbon
{
    public partial class Localization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fontlist = new List<string> {"Segoe UI", "Arial","Times New Roman", "Tahoma", "Helvetica" };
            var fontsize = new List<string>() { "1pt", "2pt", "3pt", "4pt", "5pt" };            
        }
       
    }
}