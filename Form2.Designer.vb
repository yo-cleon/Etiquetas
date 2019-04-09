<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pantElaboracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantElaboracion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechaElaboracion = New System.Windows.Forms.DateTimePicker()
        Me.fechaConsumo = New System.Windows.Forms.DateTimePicker()
        Me.taIngredientes = New System.Windows.Forms.RichTextBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet1 = New Etiquetas.EtiquetasDataSet1()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.EtiquetasDataSet = New Etiquetas.EtiquetasDataSet()
        Me.EtiquetasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Etiquetas.EtiquetasDataSet1TableAdapters.ProductosTableAdapter()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Elaboración:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Máx. Consumo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingredientes:"
        '
        'fechaElaboracion
        '
        Me.fechaElaboracion.CustomFormat = "MM/dd/yy"
        Me.fechaElaboracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaElaboracion.Location = New System.Drawing.Point(31, 88)
        Me.fechaElaboracion.Name = "fechaElaboracion"
        Me.fechaElaboracion.Size = New System.Drawing.Size(106, 20)
        Me.fechaElaboracion.TabIndex = 5
        '
        'fechaConsumo
        '
        Me.fechaConsumo.CustomFormat = "MM/dd/yy"
        Me.fechaConsumo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaConsumo.Location = New System.Drawing.Point(181, 88)
        Me.fechaConsumo.Name = "fechaConsumo"
        Me.fechaConsumo.Size = New System.Drawing.Size(106, 20)
        Me.fechaConsumo.TabIndex = 6
        Me.fechaConsumo.Value = New Date(2019, 4, 4, 0, 0, 0, 0)
        '
        'taIngredientes
        '
        Me.taIngredientes.BackColor = System.Drawing.SystemColors.Info
        Me.taIngredientes.Location = New System.Drawing.Point(31, 137)
        Me.taIngredientes.Name = "taIngredientes"
        Me.taIngredientes.ReadOnly = True
        Me.taIngredientes.Size = New System.Drawing.Size(260, 64)
        Me.taIngredientes.TabIndex = 7
        Me.taIngredientes.Text = ""
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btAceptar.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1633396
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.Location = New System.Drawing.Point(31, 211)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(43, 43)
        Me.btAceptar.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Guardar los cambios")
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.BackgroundImage = Global.Etiquetas.My.Resources.Resources.cross
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Location = New System.Drawing.Point(244, 211)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(43, 43)
        Me.btCancelar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btCancelar, "Cancelar y cerrar pantalla")
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btImprimir.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1587433
        Me.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btImprimir.Location = New System.Drawing.Point(103, 211)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btImprimir.Size = New System.Drawing.Size(43, 43)
        Me.btImprimir.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btImprimir, "Imprimir etiqueta")
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(31, 33)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(260, 21)
        Me.cbProducto.TabIndex = 4
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.EtiquetasDataSet1
        '
        'EtiquetasDataSet1
        '
        Me.EtiquetasDataSet1.DataSetName = "EtiquetasDataSet1"
        Me.EtiquetasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1591319
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.Location = New System.Drawing.Point(172, 212)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10)
        Me.Button4.Size = New System.Drawing.Size(43, 43)
        Me.Button4.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button4, "Añadir o editar productos")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'EtiquetasDataSet
        '
        Me.EtiquetasDataSet.DataSetName = "EtiquetasDataSet"
        Me.EtiquetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EtiquetasDataSetBindingSource
        '
        Me.EtiquetasDataSetBindingSource.DataSource = Me.EtiquetasDataSet
        Me.EtiquetasDataSetBindingSource.Position = 0
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'pantElaboracion
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(326, 267)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.taIngredientes)
        Me.Controls.Add(Me.fechaConsumo)
        Me.Controls.Add(Me.fechaElaboracion)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "pantElaboracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva elaboración..."
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fechaElaboracion As DateTimePicker
    Friend WithEvents fechaConsumo As DateTimePicker
    Friend WithEvents taIngredientes As RichTextBox
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btImprimir As Button
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents ListadoProductosTableAdapter As EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents EtiquetasDataSetBindingSource As BindingSource
    Friend WithEvents EtiquetasDataSet As EtiquetasDataSet
    Friend WithEvents EtiquetasDataSet1 As EtiquetasDataSet1
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As EtiquetasDataSet1TableAdapters.ProductosTableAdapter
    Friend WithEvents Button4 As Button
End Class
