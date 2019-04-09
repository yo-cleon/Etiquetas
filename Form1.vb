Imports System.Data.SqlClient

Public Class pantPpal
    'Procedimiento para cargar la tabla principal
    Public Sub CargarTabla()
        Dim cnn As New SqlConnection(“server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Dim da As New SqlDataAdapter(“SELECT * from ListadoElaboraciones order by Elaboracion Desc”, cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.CurrentRow.Selected = True
    End Sub

    Private Sub NuevaElaboraciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevaElaboraciónToolStripMenuItem1.Click
        Dim frmElaboracion As New pantElaboracion()
        frmElaboracion.ShowDialog(Me)
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim frmProducto As New pantProducto()
        frmProducto.ShowDialog(Me)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim frmAcercaDe As New pantAcertaDe()
        frmAcercaDe.ShowDialog(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btAddElaboracion.Click
        pantElaboracion.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
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

    Private Sub btDelElaboracion_Click(sender As Object, e As EventArgs) Handles btDelElaboracion.Click
        Dim dr As DialogResult = MessageBox.Show("Va a elminar la Elaboración seleccionada." + vbLf + " ¿Desea continuar?",
                                                 "Salir de la Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = DialogResult.Yes) Then
            Dim registroABorrar As Int16 = DataGridView1.CurrentRow.Cells(0).Value
            Dim conexion As New SqlConnection(“server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
            Try
                conexion.Open()
                Dim comando As SqlCommand
                Dim query As String = "delete from Elaboraciones where Codigo= @Codigo"
                comando = New SqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@Codigo", Str(registroABorrar))
                Dim i As String = comando.ExecuteNonQuery()
                conexion.Close()
                If (i > 0) Then
                    MessageBox.Show("Se ha borrado la elaboración correctamente.")
                    CargarTabla()
                Else
                    MessageBox.Show("No se ha podido borrar el registro.")
                    CargarTabla()
                End If
            Catch ex As Exception
                MessageBox.Show("Ha habido un error al realizar el borrado:" & vbLf & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.CurrentRow.Selected = True
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim params(2) As Microsoft.Reporting.WinForms.ReportParameter
        params(0) = New Microsoft.Reporting.WinForms.ReportParameter("ReportProducto", DataGridView1.CurrentRow.Cells(1).Value.ToString)
        params(1) = New Microsoft.Reporting.WinForms.ReportParameter("ReportFechaElaboracion", DataGridView1.CurrentRow.Cells(2).Value.ToString)
        params(2) = New Microsoft.Reporting.WinForms.ReportParameter("ReportFechaConsumo", DataGridView1.CurrentRow.Cells(3).Value.ToString)
        Form7.ReportViewer1.LocalReport.SetParameters(params)
        Form7.Show()
    End Sub
End Class
