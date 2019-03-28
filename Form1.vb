Public Class pantPpal
    Private Sub NuevaElaboraciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaElaboraciónToolStripMenuItem1.Click
        pantElaboracion.Show()

    End Sub

    Private Sub ImprimirEtiquetaToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        pantProducto.Show()
    End Sub

    Private Sub ImprimirEtiquetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirEtiquetaToolStripMenuItem.Click
        pantAcertaDe.Show()
    End Sub

    Private Sub pantPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btBajar_Click(sender As Object, e As EventArgs) Handles btBajar.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Esto funciona")
    End Sub
End Class
