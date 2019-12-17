#region Copyright Syncfusion Inc. 2001 - 2019
//
//  Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.ComponentModel;

namespace WebSampleBrowser.DocIO
{
    public partial class FootnotesAndEndnotes : System.Web.UI.Page
    {
        # region Private Members
        string dataPath;
        # endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events
        /// <summary>
        /// Creates word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get Image files Path. 
            dataPath = ResolveApplicationDataPath("");

            //A new document is created.
            WordDocument document = new WordDocument();

            //Create footnotes at the bottom of the page
            CreateFootNote(document);

            //Create endnotes at the end of the section
            CreateEndNote(document);


            if (rdButtonDoc.Checked)
            {
                //Save as .doc format
                document.Save("Sample.doc", FormatType.Doc, Response, HttpContentDisposition.Attachment);
            }
            //Save as .docx format
            else if (rdButtonDocx.Checked)
            {
                try
                {
                    document.Save("Sample.docx", FormatType.Docx, Response, HttpContentDisposition.Attachment);
                }
                catch (Win32Exception ex)
                {
                    Response.Write("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
            //Save as .xml(WordML) format
            else if (rdButtonWordML.Checked)
            {
                try
                {
                    document.Save("Sample.xml", FormatType.WordML, Response, HttpContentDisposition.Attachment);
                }
                catch (Win32Exception ex)
                {
                    Response.Write("Microsoft Word Viewer or Microsoft Word is not installed in this system");
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        # endregion

        #region Helper Methods
        #region CreateFootNote

        void CreateFootNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();

            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Footnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "google.png")));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "yahoo.gif")));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Footnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "Northwind_logo.png")));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. ");

            //Setting number format for Footnote
            document.FootnoteNumberFormat = FootEndNoteNumberFormat.Arabic;

            //Setting Footnote position
            document.FootnotePosition = FootnotePosition.PrintAtBottomOfPage;

        }
        #endregion

        #region CreateEndNote

        void CreateEndNote(WordDocument document)
        {
            //Add a new section to the document.
            IWSection section = document.AddSection();

            //Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            IWTextRange textRange = paragraph.AppendText("\t\t\t\t\tDemo for Endnote");
            textRange.CharacterFormat.TextColor = Color.Black;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 20;

            section.AddParagraph();
            section.AddParagraph();
            paragraph = section.AddParagraph();
            WFootnote footnote = new WFootnote(document);
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Google").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "google.png")));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Google is the most famous search engines in the Word ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;


            //Insert Text into the paragraph
            paragraph.AppendText("Yahoo").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "yahoo.gif")));

            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" Yahoo experience makes it easier to discover the news and information that you care about most. ");

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();

            paragraph = section.AddParagraph();
            footnote = paragraph.AppendFootnote(FootnoteType.Endnote);
            footnote.MarkerCharacterFormat.SubSuperScript = SubSuperScript.SuperScript;

            //Insert Text into the paragraph
            paragraph.AppendText("Northwind Traders").CharacterFormat.Bold = true;
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            paragraph.AppendPicture(System.Drawing.Image.FromFile(Path.Combine(dataPath, "Northwind_logo.png")));
            paragraph = footnote.TextBody.AddParagraph();
            paragraph.AppendText(" The Northwind sample database (Northwind.mdb) is included with all versions of Access. It provides data you can experiment with and database objects that demonstrate features you might want to implement in your own databases. ");

            //Set the number format for the Endnote.
            document.EndnoteNumberFormat = Syncfusion.DocIO.FootEndNoteNumberFormat.LowerCaseRoman;
            document.RestartIndexForEndnote = Syncfusion.DocIO.EndnoteRestartIndex.DoNotRestart;
            //Set the Endnote position.
            document.EndnotePosition = Syncfusion.DocIO.EndnotePosition.DisplayEndOfSection;
        }
        #endregion

        protected string ResolveApplicationDataPath(string fileName)
        {
            //Data folder path is resolved from requested page physical path.
            string dataPath = new System.IO.DirectoryInfo(Request.PhysicalPath + "..\\..\\..\\Content\\DocIO\\").FullName;
            return string.Format("{0}\\{1}", dataPath, fileName);
        }
        #endregion
    }
}