#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript.Web;
using Syncfusion.JavaScript.Web.Olap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSampleBrowser
{
    public partial class Events : System.Web.UI.Page
    {
        

        protected void PivotGridEvent(object sender, PivotGridEventArgs e)
        {
            this.EventLog.InnerText += e.EventType + " event is triggered\n";
        }
    }
}