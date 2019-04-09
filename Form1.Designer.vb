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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantPpal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaElaboraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaElaboraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Elaboracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaElaborado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListadoElaboracionesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet2 = New Etiquetas.EtiquetasDataSet2()
        Me.ListadoElaboracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet = New Etiquetas.EtiquetasDataSet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btDelElaboracion = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.btAddElaboracion = New System.Windows.Forms.Button()
        Me.btSubir = New System.Windows.Forms.Button()
        Me.btBajar = New System.Windows.Forms.Button()
        Me.ListadoElaboracionesTableAdapter = New Etiquetas.EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter()
        Me.ListadoElaboracionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoElaboracionesTableAdapter1 = New Etiquetas.EtiquetasDataSet2TableAdapters.ListadoElaboracionesTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoElaboracionesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoElaboracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoElaboracionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaElaboraciónToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaElaboraciónToolStripMenuItem
        '
        Me.NuevaElaboraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaElaboraciónToolStripMenuItem1, Me.ProductosToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elaboracion, Me.Producto, Me.FechaElaborado, Me.FechaConsumoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListadoElaboracionesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(515, 411)
        Me.DataGridView1.TabIndex = 6
        '
        'Elaboracion
        '
        Me.Elaboracion.DataPropertyName = "Elaboracion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Elaboracion.DefaultCellStyle = DataGridViewCellStyle3
        Me.Elaboracion.HeaderText = "Elaboracion"
        Me.Elaboracion.Name = "Elaboracion"
        Me.Elaboracion.ReadOnly = True
        Me.Elaboracion.Width = 80
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 190
        '
        'FechaElaborado
        '
        Me.FechaElaborado.DataPropertyName = "FechaElaborado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaElaborado.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaElaborado.HeaderText = "Fecha de Elaboración"
        Me.FechaElaborado.Name = "FechaElaborado"
        Me.FechaElaborado.ReadOnly = True
        '
        'FechaConsumoDataGridViewTextBoxColumn
        '
        Me.FechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "FechaConsumo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaConsumoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaConsumoDataGridViewTextBoxColumn.HeaderText = "Fecha Máx. de Consumo"
        Me.FechaConsumoDataGridViewTextBoxColumn.Name = "FechaConsumoDataGridViewTextBoxColumn"
        Me.FechaConsumoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListadoElaboracionesBindingSource2
        '
        Me.ListadoElaboracionesBindingSource2.DataMember = "ListadoElaboraciones"
        Me.ListadoElaboracionesBindingSource2.DataSource = Me.EtiquetasDataSet2
        '
        'EtiquetasDataSet2
        '
        Me.EtiquetasDataSet2.DataSetName = "EtiquetasDataSet2"
        Me.EtiquetasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoElaboracionesBindingSource
        '
        Me.ListadoElaboracionesBindingSource.DataMember = "ListadoElaboraciones"
        Me.ListadoElaboracionesBindingSource.DataSource = Me.EtiquetasDataSetBindingSource
        '
        'EtiquetasDataSetBindingSource
        '
        Me.EtiquetasDataSetBindingSource.DataSource = Me.EtiquetasDataSet
        Me.EtiquetasDataSetBindingSource.Position = 0
        '
        'EtiquetasDataSet
        '
        Me.EtiquetasDataSet.DataSetName = "EtiquetasDataSet"
        Me.EtiquetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 100
        '
        'btDelElaboracion
        '
        Me.btDelElaboracion.BackColor = System.Drawing.Color.Transparent
        Me.btDelElaboracion.BackgroundImage = Global.Etiquetas.My.Resources.Resources.del_elaboracion
        Me.btDelElaboracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btDelElaboracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDelElaboracion.FlatAppearance.BorderSize = 0
        Me.btDelElaboracion.Location = New System.Drawing.Point(546, 281)
        Me.btDelElaboracion.Name = "btDelElaboracion"
        Me.btDelElaboracion.Padding = New System.Windows.Forms.Padding(10)
        Me.btDelElaboracion.Size = New System.Drawing.Size(43, 43)
        Me.btDelElaboracion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btDelElaboracion, "Borrar elaboración")
        Me.btDelElaboracion.UseVisualStyleBackColor = False
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btImprimir.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1587433
        Me.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.FlatAppearance.BorderSize = 0
        Me.btImprimir.Location = New System.Drawing.Point(546, 217)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Padding = New System.Windows.Forms.Padding(10)
        Me.btImprimir.Size = New System.Drawing.Size(43, 41)
        Me.btImprimir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btImprimir, "Nueva producto")
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'btAddElaboracion
        '
        Me.btAddElaboracion.BackColor = System.Drawing.Color.Transparent
        Me.btAddElaboracion.BackgroundImage = Global.Etiquetas.My.Resources.Resources.add_elaboracion
        Me.btAddElaboracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAddElaboracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAddElaboracion.FlatAppearance.BorderSize = 0
        Me.btAddElaboracion.Location = New System.Drawing.Point(546, 150)
        Me.btAddElaboracion.Name = "btAddElaboracion"
        Me.btAddElaboracion.Padding = New System.Windows.Forms.Padding(10)
        Me.btAddElaboracion.Size = New System.Drawing.Size(43, 43)
        Me.btAddElaboracion.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btAddElaboracion, "Nueva elaboración")
        Me.btAddElaboracion.UseVisualStyleBackColor = False
        '
        'btSubir
        '
        Me.btSubir.BackColor = System.Drawing.Color.Transparent
        Me.btSubir.BackgroundImage = Global.Etiquetas.My.Resources.Resources.arrow_up
        Me.btSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSubir.FlatAppearance.BorderSize = 0
        Me.btSubir.Location = New System.Drawing.Point(546, 85)
        Me.btSubir.Name = "btSubir"
        Me.btSubir.Padding = New System.Windows.Forms.Padding(10)
        Me.btSubir.Size = New System.Drawing.Size(43, 41)
        Me.btSubir.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btSubir, "Registro anterior")
        Me.btSubir.UseVisualStyleBackColor = False
        '
        'btBajar
        '
        Me.btBajar.BackColor = System.Drawing.Color.Transparent
        Me.btBajar.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1620738
        Me.btBajar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBajar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBajar.FlatAppearance.BorderSize = 0
        Me.btBajar.Location = New System.Drawing.Point(546, 348)
        Me.btBajar.Name = "btBajar"
        Me.btBajar.Padding = New System.Windows.Forms.Padding(10)
        Me.btBajar.Size = New System.Drawing.Size(43, 41)
        Me.btBajar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btBajar, "Registro siguiente")
        Me.btBajar.UseVisualStyleBackColor = False
        '
        'ListadoElaboracionesTableAdapter
        '
        Me.ListadoElaboracionesTableAdapter.ClearBeforeFill = True
        '
        'ListadoElaboracionesBindingSource1
        '
        Me.ListadoElaboracionesBindingSource1.DataMember = "ListadoElaboraciones"
        Me.ListadoElaboracionesBindingSource1.DataSource = Me.EtiquetasDataSet2
        '
        'ListadoElaboracionesTableAdapter1
        '
        Me.ListadoElaboracionesTableAdapter1.ClearBeforeFill = True
        '
        'pantPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.btDelElaboracion)
        Me.Controls.Add(Me.btImprimir)
        Me.Controls.Add(Me.btAddElaboracion)
        Me.Controls.Add(Me.btSubir)
        Me.Controls.Add(Me.btBajar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pantPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaboraciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoElaboracionesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoElaboracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoElaboracionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaElaboraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaElaboraciónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btBajar As Button
    Friend WithEvents btSubir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btAddElaboracion As Button
    Friend WithEvents btImprimir As Button
    Friend WithEvents EtiquetasDataSetBindingSource As BindingSource
    Friend WithEvents EtiquetasDataSet As EtiquetasDataSet
    Friend WithEvents ListadoElaboracionesBindingSource As BindingSource
    Friend WithEvents ListadoElaboracionesTableAdapter As EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasDataSet2 As EtiquetasDataSet2
    Friend WithEvents ListadoElaboracionesBindingSource1 As BindingSource
    Friend WithEvents ListadoElaboracionesTableAdapter1 As EtiquetasDataSet2TableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents ListadoElaboracionesBindingSource2 As BindingSource
    Friend WithEvents btDelElaboracion As Button
    Friend WithEvents Elaboracion As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents FechaElaborado As DataGridViewTextBoxColumn
    Friend WithEvents FechaConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
