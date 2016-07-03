<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Producto_Form
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
        Dim IdProductoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Form))
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Producto_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Productotitle_Label = New System.Windows.Forms.Label()
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.ProductoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Nuevo_Producto = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.Eliminar_Producto = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Guardar_Producto = New System.Windows.Forms.ToolStripButton()
        Me.Cancelar_Producto = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Guardar_Button_Producto = New System.Windows.Forms.Button()
        Me.GroupBoxProducto = New System.Windows.Forms.GroupBox()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Producto_Button = New System.Windows.Forms.Button()
        Me.Agregar_Button_Producto = New System.Windows.Forms.Button()
        Me.Filtro_Producto = New System.Windows.Forms.ComboBox()
        Me.Txt_Filtro_Producto = New System.Windows.Forms.TextBox()
        IdProductoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductoBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProducto.SuspendLayout()
        Me.GroupBoxOpciones_p.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.Location = New System.Drawing.Point(7, 34)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(111, 20)
        IdProductoLabel.TabIndex = 26
        IdProductoLabel.Text = "Id Producto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(39, 78)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(80, 20)
        NombreLabel.TabIndex = 28
        NombreLabel.Text = "Nombre:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(55, 113)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(67, 20)
        MarcaLabel.TabIndex = 30
        MarcaLabel.Text = "Marca:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(249, 25)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(73, 20)
        EstadoLabel.TabIndex = 31
        EstadoLabel.Text = "Estado:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(259, 59)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(51, 20)
        TipoLabel.TabIndex = 32
        TipoLabel.Text = "Tipo:"
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.ImageList = Me.Producto_ImageList
        Me.Salir_Button.Location = New System.Drawing.Point(581, 31)
        Me.Salir_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(159, 58)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Producto_ImageList
        '
        Me.Producto_ImageList.ImageStream = CType(resources.GetObject("Producto_ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Producto_ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.Producto_ImageList.Images.SetKeyName(0, "16 (Exit).ico")
        Me.Producto_ImageList.Images.SetKeyName(1, "16 (Tools).ico")
        '
        'Productotitle_Label
        '
        Me.Productotitle_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.Productotitle_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Productotitle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productotitle_Label.ForeColor = System.Drawing.Color.Black
        Me.Productotitle_Label.Location = New System.Drawing.Point(0, 0)
        Me.Productotitle_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Productotitle_Label.Name = "Productotitle_Label"
        Me.Productotitle_Label.Size = New System.Drawing.Size(811, 63)
        Me.Productotitle_Label.TabIndex = 19
        Me.Productotitle_Label.Text = "Producto"
        Me.Productotitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.RequisiciónTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductoBindingNavigator
        '
        Me.ProductoBindingNavigator.AddNewItem = Me.Nuevo_Producto
        Me.ProductoBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.ProductoBindingNavigator.BindingSource = Me.ProductoBindingSource
        Me.ProductoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductoBindingNavigator.DeleteItem = Me.Eliminar_Producto
        Me.ProductoBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProductoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Nuevo_Producto, Me.Eliminar_Producto, Me.Guardar_Producto, Me.Cancelar_Producto})
        Me.ProductoBindingNavigator.Location = New System.Drawing.Point(0, 63)
        Me.ProductoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductoBindingNavigator.Name = "ProductoBindingNavigator"
        Me.ProductoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductoBindingNavigator.Size = New System.Drawing.Size(811, 33)
        Me.ProductoBindingNavigator.TabIndex = 26
        Me.ProductoBindingNavigator.Text = "BindingNavigator1"
        Me.ProductoBindingNavigator.Visible = False
        '
        'Nuevo_Producto
        '
        Me.Nuevo_Producto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo_Producto.Image = CType(resources.GetObject("Nuevo_Producto.Image"), System.Drawing.Image)
        Me.Nuevo_Producto.Name = "Nuevo_Producto"
        Me.Nuevo_Producto.RightToLeftAutoMirrorImage = True
        Me.Nuevo_Producto.Size = New System.Drawing.Size(24, 30)
        Me.Nuevo_Producto.Text = "Agregar Producto"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 30)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'Eliminar_Producto
        '
        Me.Eliminar_Producto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar_Producto.Image = CType(resources.GetObject("Eliminar_Producto.Image"), System.Drawing.Image)
        Me.Eliminar_Producto.Name = "Eliminar_Producto"
        Me.Eliminar_Producto.RightToLeftAutoMirrorImage = True
        Me.Eliminar_Producto.Size = New System.Drawing.Size(24, 30)
        Me.Eliminar_Producto.Text = "Eliminar Producto"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 30)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 30)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 30)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 30)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'Guardar_Producto
        '
        Me.Guardar_Producto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Guardar_Producto.Image = CType(resources.GetObject("Guardar_Producto.Image"), System.Drawing.Image)
        Me.Guardar_Producto.Name = "Guardar_Producto"
        Me.Guardar_Producto.Size = New System.Drawing.Size(24, 30)
        Me.Guardar_Producto.Text = "Guardar Producto"
        '
        'Cancelar_Producto
        '
        Me.Cancelar_Producto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancelar_Producto.Image = CType(resources.GetObject("Cancelar_Producto.Image"), System.Drawing.Image)
        Me.Cancelar_Producto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cancelar_Producto.Name = "Cancelar_Producto"
        Me.Cancelar_Producto.Size = New System.Drawing.Size(24, 30)
        Me.Cancelar_Producto.Text = "Cancelar Operación"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AllowUserToAddRows = False
        Me.ProductoDataGridView.AllowUserToDeleteRows = False
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(15, 281)
        Me.ProductoDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.ReadOnly = True
        Me.ProductoDataGridView.RowTemplate.Height = 24
        Me.ProductoDataGridView.Size = New System.Drawing.Size(773, 226)
        Me.ProductoDataGridView.TabIndex = 26
        '
        'IdProducto
        '
        Me.IdProducto.DataPropertyName = "IdProducto"
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "IdProducto", True))
        Me.IdProductoTextBox.Location = New System.Drawing.Point(133, 31)
        Me.IdProductoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IdProductoTextBox.TabIndex = 27
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(133, 74)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NombreTextBox.TabIndex = 29
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(133, 110)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MarcaTextBox.TabIndex = 31
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Estado", True))
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(336, 21)
        Me.EstadoComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(121, 28)
        Me.EstadoComboBox.TabIndex = 32
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"Oficina", "Limpieza"})
        Me.TipoComboBox.Location = New System.Drawing.Point(336, 55)
        Me.TipoComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(121, 28)
        Me.TipoComboBox.TabIndex = 33
        '
        'Guardar_Button_Producto
        '
        Me.Guardar_Button_Producto.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Producto.ImageKey = "(ninguno)"
        Me.Guardar_Button_Producto.ImageList = Me.Producto_ImageList
        Me.Guardar_Button_Producto.Location = New System.Drawing.Point(17, 31)
        Me.Guardar_Button_Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guardar_Button_Producto.Name = "Guardar_Button_Producto"
        Me.Guardar_Button_Producto.Size = New System.Drawing.Size(181, 58)
        Me.Guardar_Button_Producto.TabIndex = 34
        Me.Guardar_Button_Producto.Text = "Guardar"
        Me.Guardar_Button_Producto.UseVisualStyleBackColor = False
        '
        'GroupBoxProducto
        '
        Me.GroupBoxProducto.BackColor = System.Drawing.Color.Silver
        Me.GroupBoxProducto.Controls.Add(Me.IdProductoTextBox)
        Me.GroupBoxProducto.Controls.Add(Me.MarcaTextBox)
        Me.GroupBoxProducto.Controls.Add(TipoLabel)
        Me.GroupBoxProducto.Controls.Add(MarcaLabel)
        Me.GroupBoxProducto.Controls.Add(Me.TipoComboBox)
        Me.GroupBoxProducto.Controls.Add(Me.NombreTextBox)
        Me.GroupBoxProducto.Controls.Add(EstadoLabel)
        Me.GroupBoxProducto.Controls.Add(NombreLabel)
        Me.GroupBoxProducto.Controls.Add(Me.EstadoComboBox)
        Me.GroupBoxProducto.Controls.Add(IdProductoLabel)
        Me.GroupBoxProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxProducto.Location = New System.Drawing.Point(29, 101)
        Me.GroupBoxProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxProducto.Name = "GroupBoxProducto"
        Me.GroupBoxProducto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxProducto.Size = New System.Drawing.Size(480, 149)
        Me.GroupBoxProducto.TabIndex = 35
        Me.GroupBoxProducto.TabStop = False
        Me.GroupBoxProducto.Text = "Ingresar Producto"
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Producto_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_Producto)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_Producto)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(40, 577)
        Me.GroupBoxOpciones_p.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(748, 102)
        Me.GroupBoxOpciones_p.TabIndex = 36
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Producto_Button
        '
        Me.Eliminar_Producto_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Producto_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Producto_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Producto_Button.ImageKey = "(ninguno)"
        Me.Eliminar_Producto_Button.ImageList = Me.Producto_ImageList
        Me.Eliminar_Producto_Button.Location = New System.Drawing.Point(396, 31)
        Me.Eliminar_Producto_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminar_Producto_Button.Name = "Eliminar_Producto_Button"
        Me.Eliminar_Producto_Button.Size = New System.Drawing.Size(181, 58)
        Me.Eliminar_Producto_Button.TabIndex = 36
        Me.Eliminar_Producto_Button.Text = "Eliminar"
        Me.Eliminar_Producto_Button.UseVisualStyleBackColor = False
        '
        'Agregar_Button_Producto
        '
        Me.Agregar_Button_Producto.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Producto.ImageKey = "(ninguno)"
        Me.Agregar_Button_Producto.ImageList = Me.Producto_ImageList
        Me.Agregar_Button_Producto.Location = New System.Drawing.Point(207, 31)
        Me.Agregar_Button_Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregar_Button_Producto.Name = "Agregar_Button_Producto"
        Me.Agregar_Button_Producto.Size = New System.Drawing.Size(181, 58)
        Me.Agregar_Button_Producto.TabIndex = 35
        Me.Agregar_Button_Producto.Text = "Agregar"
        Me.Agregar_Button_Producto.UseVisualStyleBackColor = False
        '
        'Filtro_Producto
        '
        Me.Filtro_Producto.FormattingEnabled = True
        Me.Filtro_Producto.Items.AddRange(New Object() {"IdProducto", "Nombre", "Marca"})
        Me.Filtro_Producto.Location = New System.Drawing.Point(547, 119)
        Me.Filtro_Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Filtro_Producto.Name = "Filtro_Producto"
        Me.Filtro_Producto.Size = New System.Drawing.Size(160, 24)
        Me.Filtro_Producto.TabIndex = 37
        '
        'Txt_Filtro_Producto
        '
        Me.Txt_Filtro_Producto.Location = New System.Drawing.Point(547, 209)
        Me.Txt_Filtro_Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Filtro_Producto.Name = "Txt_Filtro_Producto"
        Me.Txt_Filtro_Producto.Size = New System.Drawing.Size(160, 22)
        Me.Txt_Filtro_Producto.TabIndex = 38
        '
        'Producto_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(811, 708)
        Me.Controls.Add(Me.Txt_Filtro_Producto)
        Me.Controls.Add(Me.Filtro_Producto)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.GroupBoxProducto)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.ProductoBindingNavigator)
        Me.Controls.Add(Me.Productotitle_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Producto_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductoBindingNavigator.ResumeLayout(False)
        Me.ProductoBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProducto.ResumeLayout(False)
        Me.GroupBoxProducto.PerformLayout()
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Productotitle_Label As Label
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As _Inv_Bodegas_DataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoBindingNavigator As BindingNavigator
    Friend WithEvents Nuevo_Producto As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents Eliminar_Producto As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Guardar_Producto As ToolStripButton
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents Cancelar_Producto As ToolStripButton
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents Producto_ImageList As ImageList
    Friend WithEvents Guardar_Button_Producto As Button
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxProducto As GroupBox
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Agregar_Button_Producto As Button
    Friend WithEvents Eliminar_Producto_Button As Button
    Friend WithEvents Filtro_Producto As ComboBox
    Friend WithEvents Txt_Filtro_Producto As TextBox
End Class
