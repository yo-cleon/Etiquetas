Imports System.Data.SqlClient

Public Class pantElaboracion
    Public Sub cargarProductos()
        Dim conexion = New SqlConnection("server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Try
            conexion.Open()
            Dim query As String = "select * from Productos order By Codigo"
            Dim da As New SqlDataAdapter(query, conexion)
            Dim ds As New DataSet
            da.Fill(ds)
            With Me.cbProducto
                Me.cbProducto.DataSource = ds.Tables(0)
                Me.cbProducto.DisplayMember = "Nombre"
                Me.cbProducto.ValueMember = "Codigo"
            End With
            conexion.Close()
            cargarIngredientes()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos:" & vbLf & ex.Message)
        End Try
    End Sub

    Private Sub cargarIngredientes()
        Dim conexion = New SqlConnection("server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Try
            conexion.Open()
            Dim ingredientes As String = "select Ingredientes from Productos where Codigo = @Codigo"
            Dim comando As SqlCommand = New SqlCommand(ingredientes, conexion)
            comando.Parameters.AddWithValue("@Codigo", cbProducto.SelectedValue)
            If comando.ExecuteScalar() Is DBNull.Value Then
                taIngredientes.Text = ""
            Else
                taIngredientes.Text = comando.ExecuteScalar()
            End If
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los ingredientes" & vbLf & ex.Message)
        End Try

    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim aux As Int32 = cbProducto.SelectedValue
        Dim conexion = New SqlConnection("server=TRIBUNAL-PC\SQLEXPRESS ; database=Etiquetas ; integrated security = true")
        Try
            conexion.Open()
            Dim comando As SqlCommand

            'VER EL CÓDIGO DE UNA NUEVA ELABORACIÓN
            Dim query1 As String = "SELECT TOP 1 Codigo FROM Elaboraciones ORDER BY Codigo DESC"
            comando = New SqlCommand(query1, conexion)
            Dim nuevoCodigo = comando.ExecuteScalar + 1

            'INSERTAR LA NUEVA ELABORACIÓN
            Dim query2 As String = "insert into Elaboraciones(Codigo, Producto, FechaElaboracion, FechaConsumo)
                                    values (" & nuevoCodigo & " , " & aux & ",'" & Format(fechaElaboracion.Value, "yyyy/MM/dd") & "','" & Format(fechaConsumo.Value, "yyyy/MM/dd") & "' )"
            comando = New SqlCommand(query2, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Los datos se guardaron correctamente")
            conexion.Close()
            pantPpal.CargarTabla()
            Dim dr As DialogResult = MessageBox.Show("¿Va a añadir más Elaboraciones?",
                                                 "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dr = DialogResult.No) Then
                Me.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR SQL: " + vbLf + ex.StackTrace)
        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub pantElaboracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProductos()
    End Sub

    Private Sub cbProducto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbProducto.SelectionChangeCommitted
        cargarIngredientes()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmProducto As New pantProducto()
        frmProducto.ShowDialog(Me)
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click

    End Sub
End Class