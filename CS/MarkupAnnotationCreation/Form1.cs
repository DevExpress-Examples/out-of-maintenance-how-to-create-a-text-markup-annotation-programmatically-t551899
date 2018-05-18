using DevExpress.XtraPdfViewer;
using System.Drawing;
using System.Windows.Forms;

namespace MarkupAnnotationCreation {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a document.
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");

            // Select the document area where the markup annotation will be created.
            pdfViewer1.Select(new RectangleF(-220, 420, 1240, 150));

            // Handle the TextMarkupAnnotationCreating event to specify the annotation properties. 
            pdfViewer1.TextMarkupAnnotationCreating += PdfViewer1_TextMarkupAnnotationCreating;

            // Highlight a selected text.
            pdfViewer1.HighlightSelectedText();
        }

        private void PdfViewer1_TextMarkupAnnotationCreating(object sender, PdfTextMarkupAnnotationCreatingEventArgs e) {
            e.Author = "John Smith";
            e.Comment = "Note.";
            e.Color = Color.Gold;
        }
    }
}
