#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSampleBrowser.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DefaultSchedule
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Description { get; set; }
        public Nullable<int> Owner { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<byte> Recurrence { get; set; }
        public string RecurrenceType { get; set; }
        public Nullable<int> RecurrenceTypeCount { get; set; }
        public Nullable<int> Reminder { get; set; }
        public string Categorize { get; set; }
        public string CustomStyle { get; set; }
        public Nullable<bool> AllDay { get; set; }
        public Nullable<System.DateTime> RecurrenceStartDate { get; set; }
        public Nullable<System.DateTime> RecurrenceEndDate { get; set; }
        public string RecurrenceRule { get; set; }
    }
}
