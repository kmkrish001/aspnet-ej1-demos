#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSampleBrowser.TreeGrid.Model;

namespace WebSampleBrowser.TreeGrid
{
    public partial class TreeGridColumnChooser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TaskDetailsCollection TaskCollection = new TaskDetailsCollection();
            this.TreeGridControlColumnChooser.DataSource = TaskCollection.GetDataSource();
            this.TreeGridControlColumnChooser.DataBind();

        }
    }
}