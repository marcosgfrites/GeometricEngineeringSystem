using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.PowerPoint.Application;

namespace PrimerasHU_GES
{
    public partial class ReporteDeAnalisisPablo : Form
    {
        public ReporteDeAnalisisPablo()
        {
            InitializeComponent();
        }

        private void ReporteDeAnalisisPablo_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application pptApplication = new Microsoft.Office.Interop.PowerPoint.Application();



            Microsoft.Office.Interop.PowerPoint.Slides slides;

            Microsoft.Office.Interop.PowerPoint._Slide slide;

            Microsoft.Office.Interop.PowerPoint.TextRange objText;



            // Create the Presentation File

            Presentation pptPresentation = pptApplication.Presentations.Add(MsoTriState.msoTrue);



            Microsoft.Office.Interop.PowerPoint.CustomLayout customLayout = pptPresentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];



            // Create new Slide

            slides = pptPresentation.Slides;

            slide = slides.AddSlide(1, customLayout);



            // Add title

            objText = slide.Shapes[1].TextFrame.TextRange;

            objText.Text = "FPPT.com";

            objText.Font.Name = "Arial";

            objText.Font.Size = 32;



            objText = slide.Shapes[2].TextFrame.TextRange;

            objText.Text = "Content goes here\nYou can add text\nItem 3";



            slide.NotesPage.Shapes[2].TextFrame.TextRange.Text = "This demo is created by FPPT using C# – Download free templates from http://FPPT.com";




pptPresentation.SaveAs(@"c:\temp\fppt.pptx", Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);

            //pptPresentation.Close();

            //pptApplication.Quit();
        }
    }
}
