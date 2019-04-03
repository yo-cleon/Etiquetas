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
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListadoElaboracionesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet2 = New Etiquetas.EtiquetasDataSet2()
        Me.ListadoElaboracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtiquetasDataSet = New Etiquetas.EtiquetasDataSet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btBajar = New System.Windows.Forms.Button()
        Me.ListadoElaboracionesTableAdapter = New Etiquetas.EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter()
        Me.ListadoElaboracionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListadoElaboracionesTableAdapter1 = New Etiquetas.EtiquetasDataSet2TableAdapters.ListadoElaboracionesTableAdapter()
        Me.Elaboracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaElaborado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaElaboraciónToolStripMenuItem
        '
        Me.NuevaElaboraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaElaboraciónToolStripMenuItem1, Me.NuevoProductoToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "Nuevo Producto"
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elaboracion, Me.Producto, Me.FechaElaborado, Me.FechaConsumoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListadoElaboracionesBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 411)
        Me.DataGridView1.TabIndex = 1
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1587433
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Location = New System.Drawing.Point(574, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10)
        Me.Button2.Size = New System.Drawing.Size(43, 41)
        Me.Button2.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Button2, "Nueva producto")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1591319
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.Location = New System.Drawing.Point(574, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10)
        Me.Button4.Size = New System.Drawing.Size(43, 43)
        Me.Button4.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Button4, "Nuevo producto")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1524399
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Location = New System.Drawing.Point(574, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10)
        Me.Button3.Size = New System.Drawing.Size(43, 43)
        Me.Button3.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button3, "Nueva elaboración")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Etiquetas.My.Resources.Resources.arrow_up
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Location = New System.Drawing.Point(574, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10)
        Me.Button1.Size = New System.Drawing.Size(43, 41)
        Me.Button1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button1, "Registro anterior")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btBajar
        '
        Me.btBajar.BackColor = System.Drawing.Color.Transparent
        Me.btBajar.BackgroundImage = Global.Etiquetas.My.Resources.Resources._1620738
        Me.btBajar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBajar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBajar.FlatAppearance.BorderSize = 0
        Me.btBajar.Location = New System.Drawing.Point(574, 349)
        Me.btBajar.Name = "btBajar"
        Me.btBajar.Padding = New System.Windows.Forms.Padding(10)
        Me.btBajar.Size = New System.Drawing.Size(43, 41)
        Me.btBajar.TabIndex = 2
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
        'Elaboracion
        '
        Me.Elaboracion.DataPropertyName = "Elaboracion"
        Me.Elaboracion.HeaderText = "Elaboracion"
        Me.Elaboracion.Name = "Elaboracion"
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'FechaElaborado
        '
        Me.FechaElaborado.DataPropertyName = "FechaElaborado"
        Me.FechaElaborado.HeaderText = "Fecha de Elaboración"
        Me.FechaElaborado.Name = "FechaElaborado"
        '
        'FechaConsumoDataGridViewTextBoxColumn
        '
        Me.FechaConsumoDataGridViewTextBoxColumn.DataPropertyName = "FechaConsumo"
        Me.FechaConsumoDataGridViewTextBoxColumn.HeaderText = "FechaConsumo"
        Me.FechaConsumoDataGridViewTextBoxColumn.Name = "FechaConsumoDataGridViewTextBoxColumn"
        '
        'pantPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(634, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btBajar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
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
    Friend WithEvents NuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btBajar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents EtiquetasDataSetBindingSource As BindingSource
    Friend WithEvents EtiquetasDataSet As EtiquetasDataSet
    Friend WithEvents ListadoElaboracionesBindingSource As BindingSource
    Friend WithEvents ListadoElaboracionesTableAdapter As EtiquetasDataSetTableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasDataSet2 As EtiquetasDataSet2
    Friend WithEvents ListadoElaboracionesBindingSource1 As BindingSource
    Friend WithEvents ListadoElaboracionesTableAdapter1 As EtiquetasDataSet2TableAdapters.ListadoElaboracionesTableAdapter
    Friend WithEvents ListadoElaboracionesBindingSource2 As BindingSource
    Friend WithEvents Elaboracion As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents FechaElaborado As DataGridViewTextBoxColumn
    Friend WithEvents FechaConsumoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
