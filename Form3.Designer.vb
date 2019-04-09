<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantProducto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taIngredientes = New System.Windows.Forms.RichTextBox()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingredientes"
        '
        'taIngredientes
        '
        Me.taIngredientes.Location = New System.Drawing.Point(29, 94)
        Me.taIngredientes.Name = "taIngredientes"
        Me.taIngredientes.Size = New System.Drawing.Size(256, 64)
        Me.taIngredientes.TabIndex = 2
        Me.taIngredientes.Text = ""
        '
        'tbCodigo
        '
        Me.tbCodigo.BackColor = System.Drawing.SystemColors.Info
        Me.tbCodigo.Location = New System.Drawing.Point(29, 42)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.ReadOnly = True
        Me.tbCodigo.Size = New System.Drawing.Size(47, 20)
        Me.tbCodigo.TabIndex = 0
        Me.tbCodigo.TabStop = False
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(105, 42)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(180, 20)
        Me.tbNombre.TabIndex = 1
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btAceptar.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1633396
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.Location = New System.Drawing.Point(29, 193)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(43, 43)
        Me.btAceptar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Guardar cambios")
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.BackgroundImage = Global.Etiquetas.My.Resources.Resources.cross
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Location = New System.Drawing.Point(242, 193)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(43, 43)
        Me.btCancelar.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btCancelar, "Cancelar y cerrar pantalla")
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btBuscar.BackgroundImage = Global.Etiquetas.My.Resources.Resources.icono_buscar
        Me.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btBuscar.Location = New System.Drawing.Point(78, 42)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(21, 20)
        Me.btBuscar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btBuscar, "Buscar producto")
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Etiquetas.My.Resources.Resources.add_producto
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(92, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 43)
        Me.Button1.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar cambios")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pantProducto
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(316, 267)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.taIngredientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "pantProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo producto..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents taIngredientes As RichTextBox
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btBuscar As Button
    Friend WithEvents Button1 As Button
End Class
