Imports System.Drawing
Imports System.Windows.Forms

Namespace CreateMarkupAnnotation
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a document.
            pdfViewer1.LoadDocument("..\..\Demo.pdf")

            ' Select the document area where the markup annotation will be created.
            pdfViewer1.Select(New RectangleF(-230, 420, 1240, 150))

            ' Highlight a selected text.
            pdfViewer1.HighlightSelectedText()
        End Sub
    End Class
End Namespace
