Imports System.Data.SqlClient

Public Class pantPpal
    'Procedimiento para cargar la tabla principal
    Public Sub CargarTabla()
        Dim cnn As New SqlConnection(“server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Dim da As New SqlDataAdapter(“SELECT * from ListadoElaboraciones order by Elaboracion Desc”, cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub NuevaElaboraciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaElaboraciónToolStripMenuItem1.Click
        pantElaboracion.ShowDialog()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        pantProducto.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        pantAcertaDe.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pantElaboracion.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pantProducto.ShowDialog()
    End Sub

    Private Sub pantPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Llamada la método para cargar los datos en la tabla
        CargarTabla()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub pantPpal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Modificación del funcionamiento de cierre del formulario
        Dim dr As DialogResult = MessageBox.Show("Va a cerrar la aplicación," + vbLf + " ¿Desea continuar?",
                                                 "Salir de la Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = DialogResult.No) Then
            ' Cancelamos el cierre del formulario.
            e.Cancel = True
        Else
            Me.Dispose()
        End If
    End Sub

End Class
