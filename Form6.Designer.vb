<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantBuscarProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantBuscarProducto))
        Me.grProductos = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet3 = New Etiquetas.EtiquetasDataSet3()
        Me.EtiquetasDataSet = New Etiquetas.EtiquetasDataSet()
        Me.EtiquetasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Etiquetas.EtiquetasDataSet3TableAdapters.ProductosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grProductos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grProductos.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IngredientesDataGridViewTextBoxColumn})
        Me.grProductos.DataSource = Me.ProductosBindingSource
        Me.grProductos.Location = New System.Drawing.Point(2, 12)
        Me.grProductos.Name = "grProductos"
        Me.grProductos.ReadOnly = True
        Me.grProductos.Size = New System.Drawing.Size(321, 200)
        Me.grProductos.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 70
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IngredientesDataGridViewTextBoxColumn
        '
        Me.IngredientesDataGridViewTextBoxColumn.DataPropertyName = "Ingredientes"
        Me.IngredientesDataGridViewTextBoxColumn.HeaderText = "Ingredientes"
        Me.IngredientesDataGridViewTextBoxColumn.Name = "IngredientesDataGridViewTextBoxColumn"
        Me.IngredientesDataGridViewTextBoxColumn.ReadOnly = True
        Me.IngredientesDataGridViewTextBoxColumn.Width = 105
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.EtiquetasDataSet3
        '
        'EtiquetasDataSet3
        '
        Me.EtiquetasDataSet3.DataSetName = "EtiquetasDataSet3"
        Me.EtiquetasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1633396
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(73, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 41)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.BackgroundImage = Global.Etiquetas.My.Resources.Resources.cross
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Location = New System.Drawing.Point(208, 218)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(43, 43)
        Me.btCancelar.TabIndex = 13
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'pantBuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(326, 267)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pantBuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar producto"
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grProductos As DataGridView
    Friend WithEvents EtiquetasDataSet As EtiquetasDataSet
    Friend WithEvents EtiquetasDataSetBindingSource As BindingSource
    Friend WithEvents EtiquetasDataSet3 As EtiquetasDataSet3
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As EtiquetasDataSet3TableAdapters.ProductosTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngredientesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btCancelar As Button
End Class
