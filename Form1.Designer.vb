<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pantPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantPpal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaElaboraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaElaboraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirEtiquetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetasDataSet1 = New Etiquetas.EtiquetasDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListadoElaboracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoElaboracionesTableAdapter = New Etiquetas.EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaElaboracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EtiquetasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoElaboracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaElaboraciónToolStripMenuItem, Me.ImprimirEtiquetaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaElaboraciónToolStripMenuItem
        '
        Me.NuevaElaboraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaElaboraciónToolStripMenuItem1, Me.NuevoProductoToolStripMenuItem})
        Me.NuevaElaboraciónToolStripMenuItem.Name = "NuevaElaboraciónToolStripMenuItem"
        Me.NuevaElaboraciónToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.NuevaElaboraciónToolStripMenuItem.Text = "Archivo"
        '
        'NuevaElaboraciónToolStripMenuItem1
        '
        Me.NuevaElaboraciónToolStripMenuItem1.Name = "NuevaElaboraciónToolStripMenuItem1"
        Me.NuevaElaboraciónToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.NuevaElaboraciónToolStripMenuItem1.Text = "Nueva Elaboración"
        '
        'ImprimirEtiquetaToolStripMenuItem
        '
        Me.ImprimirEtiquetaToolStripMenuItem.Name = "ImprimirEtiquetaToolStripMenuItem"
        Me.ImprimirEtiquetaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ImprimirEtiquetaToolStripMenuItem.Text = "Acerca de"
        '
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "Nuevo Producto"
        '
        'EtiquetasDataSet1
        '
        Me.EtiquetasDataSet1.DataSetName = "ListadoElaboracionesDataSet"
        Me.EtiquetasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.FechaElaboracionDataGridViewTextBoxColumn, Me.FechaConsumoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListadoElaboracionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(87, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ListadoElaboracionesBindingSource
        '
        Me.ListadoElaboracionesBindingSource.DataMember = "ListadoElaboraciones"
        Me.ListadoElaboracionesBindingSource.DataSource = Me.EtiquetasDataSet1
        '
        'ListadoElaboracionesTableAdapter
        '
        Me.ListadoElaboracionesTableAdapter.ClearBeforeFill = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'FechaElaboracionDataGridViewTextBoxColumn
        '
        Me.FechaElaboracionDataGridViewTextBoxColumn.DataPropertyName = "FechaElaboracion"
        Me.FechaElaboracionDataGridViewTextBoxColumn.HeaderText = "FechaElaboracion"
        Me.FechaElaboracionDataGridViewTextBoxColumn.Name = "FechaElaboracionDataGridViewTextBoxColumn"
        '
        'FechaConsumoDataGridViewTextBoxColumn
        '
        Me.FechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "FechaConsumo"
        Me.FechaConsumoDataGridViewTextBoxColumn.HeaderText = "FechaConsumo"
        Me.FechaConsumoDataGridViewTextBoxColumn.Name = "FechaConsumoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'pantPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "pantPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaboraciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EtiquetasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoElaboracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaElaboraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaElaboraciónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirEtiquetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasDataSet1 As EtiquetasDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListadoElaboracionesBindingSource As BindingSource
    Friend WithEvents ListadoElaboracionesTableAdapter As EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaElaboracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
