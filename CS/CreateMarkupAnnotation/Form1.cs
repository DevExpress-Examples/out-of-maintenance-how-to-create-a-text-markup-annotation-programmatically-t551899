using System.Drawing;
using System.Windows.Forms;

namespace CreateMarkupAnnotation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a document.
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");

            // Select the document area where the markup annotation will be created.
            pdfViewer1.Select(new RectangleF(-230, 420, 1240, 150));

            // Highlight a selected text.
            pdfViewer1.HighlightSelectedText();
        }
    }
}
