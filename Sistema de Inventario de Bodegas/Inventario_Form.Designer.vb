<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario_Form))
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Opciones_Label = New System.Windows.Forms.Label()
        Me.Salir_Button_inventario = New System.Windows.Forms.Button()
        Me.Editar_Button_inventario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Inventario = New System.Windows.Forms.Label()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Nuevo_Inventario = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.Eliminar_Inventario = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Guardar_Inventario = New System.Windows.Forms.ToolStripButton()
        Me.Cancelar_Operacion = New System.Windows.Forms.ToolStripButton()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter()
        Me.BodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BodegaTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter()
        Me.InventarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Opciones_Label
        '
        Me.Opciones_Label.AutoSize = True
        Me.Opciones_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opciones_Label.Location = New System.Drawing.Point(13, 486)
        Me.Opciones_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Opciones_Label.Name = "Opciones_Label"
        Me.Opciones_Label.Size = New System.Drawing.Size(111, 25)
        Me.Opciones_Label.TabIndex = 29
        Me.Opciones_Label.Text = "Opciones:"
        '
        'Salir_Button_inventario
        '
        Me.Salir_Button_inventario.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button_inventario.ImageKey = "16 (Exit).ico"
        Me.Salir_Button_inventario.Location = New System.Drawing.Point(433, 513)
        Me.Salir_Button_inventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Salir_Button_inventario.Name = "Salir_Button_inventario"
        Me.Salir_Button_inventario.Size = New System.Drawing.Size(159, 58)
        Me.Salir_Button_inventario.TabIndex = 28
        Me.Salir_Button_inventario.Text = "Salir"
        Me.Salir_Button_inventario.UseVisualStyleBackColor = False
        '
        'Editar_Button_inventario
        '
        Me.Editar_Button_inventario.BackColor = System.Drawing.Color.PowderBlue
        Me.Editar_Button_inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar_Button_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Button_inventario.ImageKey = "16 (Tools).ico"
        Me.Editar_Button_inventario.Location = New System.Drawing.Point(188, 513)
        Me.Editar_Button_inventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editar_Button_inventario.Name = "Editar_Button_inventario"
        Me.Editar_Button_inventario.Size = New System.Drawing.Size(159, 58)
        Me.Editar_Button_inventario.TabIndex = 27
        Me.Editar_Button_inventario.Text = "Editar"
        Me.Editar_Button_inventario.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(16, 496)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(769, 87)
        Me.Label2.TabIndex = 26
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(841, 53)
        Me.Label_Inventario.TabIndex = 37
        Me.Label_Inventario.Text = "Inventario"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Me.Nuevo_Inventario
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.BindingSource = Me.InventarioBindingSource
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Me.Eliminar_Inventario
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Nuevo_Inventario, Me.Eliminar_Inventario, Me.Guardar_Inventario, Me.Cancelar_Operacion})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 53)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(841, 27)
        Me.InventarioBindingNavigator.TabIndex = 38
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'Nuevo_Inventario
        '
        Me.Nuevo_Inventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo_Inventario.Image = CType(resources.GetObject("Nuevo_Inventario.Image"), System.Drawing.Image)
        Me.Nuevo_Inventario.Name = "Nuevo_Inventario"
        Me.Nuevo_Inventario.RightToLeftAutoMirrorImage = True
        Me.Nuevo_Inventario.Size = New System.Drawing.Size(24, 24)
        Me.Nuevo_Inventario.Text = "Add new"
        Me.Nuevo_Inventario.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'Eliminar_Inventario
        '
        Me.Eliminar_Inventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar_Inventario.Image = CType(resources.GetObject("Eliminar_Inventario.Image"), System.Drawing.Image)
        Me.Eliminar_Inventario.Name = "Eliminar_Inventario"
        Me.Eliminar_Inventario.RightToLeftAutoMirrorImage = True
        Me.Eliminar_Inventario.Size = New System.Drawing.Size(24, 24)
        Me.Eliminar_Inventario.Text = "Delete"
        Me.Eliminar_Inventario.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Guardar_Inventario
        '
        Me.Guardar_Inventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Guardar_Inventario.Image = CType(resources.GetObject("Guardar_Inventario.Image"), System.Drawing.Image)
        Me.Guardar_Inventario.Name = "Guardar_Inventario"
        Me.Guardar_Inventario.Size = New System.Drawing.Size(24, 24)
        Me.Guardar_Inventario.Text = "Save Data"
        Me.Guardar_Inventario.Visible = False
        '
        'Cancelar_Operacion
        '
        Me.Cancelar_Operacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancelar_Operacion.Image = CType(resources.GetObject("Cancelar_Operacion.Image"), System.Drawing.Image)
        Me.Cancelar_Operacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cancelar_Operacion.Name = "Cancelar_Operacion"
        Me.Cancelar_Operacion.Size = New System.Drawing.Size(24, 24)
        Me.Cancelar_Operacion.Text = "ToolStripButton1"
        Me.Cancelar_Operacion.Visible = False
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'BodegaBindingSource
        '
        Me.BodegaBindingSource.DataMember = "Bodega"
        Me.BodegaBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        'BodegaTableAdapter
        '
        Me.BodegaTableAdapter.ClearBeforeFill = True
        '
        'InventarioBindingSource1
        '
        Me.InventarioBindingSource1.DataMember = "FK_Inventario_Bodega"
        Me.InventarioBindingSource1.DataSource = Me.BodegaBindingSource
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AllowUserToAddRows = False
        Me.InventarioDataGridView.AllowUserToDeleteRows = False
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        Me.InventarioDataGridView.Location = New System.Drawing.Point(0, 119)
        Me.InventarioDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.ReadOnly = True
        Me.InventarioDataGridView.Size = New System.Drawing.Size(841, 298)
        Me.InventarioDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdInventario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdInventario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Medida"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Medida"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Existencia_Inicial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Existencia_Inicial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Existencia_Final"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Existencia_Final"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdBodega"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IdBodega"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Inventario_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(841, 598)
        Me.Controls.Add(Me.InventarioDataGridView)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Controls.Add(Me.Opciones_Label)
        Me.Controls.Add(Me.Salir_Button_inventario)
        Me.Controls.Add(Me.Editar_Button_inventario)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inventario_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario_Form"
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As _Inv_Bodegas_DataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Opciones_Label As Label
    Friend WithEvents Salir_Button_inventario As Button
    Friend WithEvents Editar_Button_inventario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Inventario As Label
    Friend WithEvents InventarioBindingNavigator As BindingNavigator
    Friend WithEvents Nuevo_Inventario As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents Eliminar_Inventario As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Guardar_Inventario As ToolStripButton
    Friend WithEvents Cancelar_Operacion As ToolStripButton
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents BodegaBindingSource As BindingSource
    Friend WithEvents BodegaTableAdapter As _Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter
    Friend WithEvents InventarioBindingSource1 As BindingSource
    Friend WithEvents InventarioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
