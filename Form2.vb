Imports System.Data.SqlClient

Public Class pantElaboracion
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim aux As Int32 = cbProducto.SelectedValue
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Try
            conexion.Open()
            Dim comando As SqlCommand

            'VER EL CÓDIGO DE UNA NUEVA ELABORACIÓN
            Dim cadena1 As String = "SELECT TOP 1 Codigo FROM Elaboraciones ORDER BY Codigo DESC"
            comando = New SqlCommand(cadena1, conexion)
            Dim nuevoCodigo = comando.ExecuteScalar + 1

            'INSERTAR LA NUEVA ELABORACIÓN
            Dim cadena2 As String = "insert into Elaboraciones(Codigo, Producto, FechaElaboracion, FechaConsumo)
                                    values (" & nuevoCodigo & " , " & aux & ",'" & Format(fechaElaboracion.Value, "yyyy/MM/dd") & "','" & Format(fechaConsumo.Value, "yyyy/MM/dd") & "' )"
            comando = New SqlCommand(cadena2, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Los datos se guardaron correctamente")
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR SQL: " + vbLf + ex.StackTrace)
        End Try

    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub pantElaboracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EtiquetasDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.EtiquetasDataSet1.Productos)

    End Sub
End Class