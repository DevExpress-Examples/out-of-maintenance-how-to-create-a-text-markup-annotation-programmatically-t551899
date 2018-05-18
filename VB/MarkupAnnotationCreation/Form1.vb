Imports DevExpress.XtraPdfViewer
Imports System.Drawing
Imports System.Windows.Forms

Namespace MarkupAnnotationCreation

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a document.
            pdfViewer1.LoadDocument("..\..\Demo.pdf")

            ' Select the document area where the markup annotation will be created.
            pdfViewer1.Select(New RectangleF(-220, 420, 1240, 150))

            ' Handle the TextMarkupAnnotationCreating event to specify the annotation properties. 
            AddHandler pdfViewer1.TextMarkupAnnotationCreating, AddressOf PdfViewer1_TextMarkupAnnotationCreating

            ' Highlight a selected text.
            pdfViewer1.HighlightSelectedText()
        End Sub

        Private Sub PdfViewer1_TextMarkupAnnotationCreating(ByVal sender As Object, ByVal e As PdfTextMarkupAnnotationCreatingEventArgs)
            e.Author = "John Smith"
            e.Comment = "Note."
            e.Color = Color.Gold
        End Sub
    End Class
End Namespace
