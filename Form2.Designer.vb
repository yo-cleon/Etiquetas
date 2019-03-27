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
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fechaElaboracion = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.EtiquetasDataSet = New Etiquetas.EtiquetasDataSet()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cbProducto
        '
        Me.cbProducto.DataSource = Me.ProductosBindingSource
        Me.cbProducto.DisplayMember = "Nombre"
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(31, 33)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(260, 21)
        Me.cbProducto.TabIndex = 4
        Me.cbProducto.ValueMember = "Codigo"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(181, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(31, 137)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 64)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'EtiquetasDataSet
        '
        Me.EtiquetasDataSet.DataSetName = "EtiquetasDataSet"
        Me.EtiquetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(31, 222)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 8
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Location = New System.Drawing.Point(216, 222)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btCancelar.TabIndex = 9
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btImprimir
        '
        Me.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btImprimir.Location = New System.Drawing.Point(125, 222)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btImprimir.TabIndex = 10
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.UseVisualStyleBackColor = True
        '
        'pantElaboracion
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btCancelar
        Me.ClientSize = New System.Drawing.Size(326, 267)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
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
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents fechaElaboracion As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents EtiquetasDataSet As EtiquetasDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents btAceptar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents btImprimir As Button
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
End Class
