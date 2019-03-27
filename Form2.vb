Public Class pantElaboracion
    Private Sub pantElaboracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        MessageBox.Show(cbProducto.SelectedValue)
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class