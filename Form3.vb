Imports System.Data.SqlClient

Public Class pantProducto
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click, btAceptar.Click
        'Me.Dispose()
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pantProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Dispose()
        MessageBox.Show("cerrando formulario de productos")
    End Sub

    Private Sub pantProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim aux As Int32 = cbProducto.SelectedValue
        Dim conexion = New SqlConnection("server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Try
            conexion.Open()
            Dim comando As SqlCommand
            'VER EL CÓDIGO DEL NUEVO PRODUCTO
            Dim query1 As String = "SELECT TOP 1 Codigo FROM Productos ORDER BY Codigo DESC"
            comando = New SqlCommand(query1, conexion)
            Dim aux As Int16 = comando.ExecuteScalar + 1
            conexion.Close()
            tbCodigo.Text = aux.ToString
        Catch ex As Exception
            MessageBox.Show("Error SQL al cargar la pantalla: " + vbLf + ex.StackTrace)
        End Try
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim frmBuscarProducto As New pantBuscarProducto()
        frmBuscarProducto.ShowDialog()

    End Sub
End Class