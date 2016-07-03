<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requisicion
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
        Dim BuscarLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim IdDeptoLabel As System.Windows.Forms.Label
        Dim IdRequisicionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requisicion))
        Me.Label_Inventario = New System.Windows.Forms.Label()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProductoTextBox = New System.Windows.Forms.TextBox()
        Me.IdDeptoTextBox = New System.Windows.Forms.TextBox()
        Me.IdRequisicionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxOpciones_p = New System.Windows.Forms.GroupBox()
        Me.Eliminar_Requisicion_Button = New System.Windows.Forms.Button()
        Me.Agregar_Button_Requisicion = New System.Windows.Forms.Button()
        Me.Salir_Button = New System.Windows.Forms.Button()
        Me.Guardar_Button_Producto = New System.Windows.Forms.Button()
        Me.RequisicionDataGridView = New System.Windows.Forms.DataGridView()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cancelar_Operacion = New System.Windows.Forms.ToolStripButton()
        Me.IdRequisiciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequisicionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.RequisiciónTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.RequisiciónTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        BuscarLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        IdDeptoLabel = New System.Windows.Forms.Label()
        IdRequisicionLabel = New System.Windows.Forms.Label()
        Me.GroupBoxOpciones_p.SuspendLayout()
        CType(Me.RequisicionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.RequisicionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarLabel
        '
        BuscarLabel.AutoSize = True
        BuscarLabel.Location = New System.Drawing.Point(16, 97)
        BuscarLabel.Name = "BuscarLabel"
        BuscarLabel.Size = New System.Drawing.Size(56, 17)
        BuscarLabel.TabIndex = 80
        BuscarLabel.Text = "Buscar:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(344, 153)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 79
        FechaLabel.Text = "Fecha:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(344, 231)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(68, 17)
        CantidadLabel.TabIndex = 76
        CantidadLabel.Text = "Cantidad:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(344, 192)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(92, 17)
        ObservacionLabel.TabIndex = 74
        ObservacionLabel.Text = "Observación:"
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.Location = New System.Drawing.Point(16, 226)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(127, 17)
        NombreProductoLabel.TabIndex = 72
        NombreProductoLabel.Text = "Nombre_Producto:"
        '
        'IdDeptoLabel
        '
        IdDeptoLabel.AutoSize = True
        IdDeptoLabel.Location = New System.Drawing.Point(15, 186)
        IdDeptoLabel.Name = "IdDeptoLabel"
        IdDeptoLabel.Size = New System.Drawing.Size(117, 17)
        IdDeptoLabel.TabIndex = 69
        IdDeptoLabel.Text = "Id Departamento:"
        '
        'IdRequisicionLabel
        '
        IdRequisicionLabel.AutoSize = True
        IdRequisicionLabel.Location = New System.Drawing.Point(16, 144)
        IdRequisicionLabel.Name = "IdRequisicionLabel"
        IdRequisicionLabel.Size = New System.Drawing.Size(100, 17)
        IdRequisicionLabel.TabIndex = 68
        IdRequisicionLabel.Text = "Id Requisición:"
        '
        'Label_Inventario
        '
        Me.Label_Inventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Inventario.Location = New System.Drawing.Point(0, 0)
        Me.Label_Inventario.Name = "Label_Inventario"
        Me.Label_Inventario.Size = New System.Drawing.Size(799, 53)
        Me.Label_Inventario.TabIndex = 39
        Me.Label_Inventario.Text = "Requisición de Inventario"
        Me.Label_Inventario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BuscarButton
        '
        Me.BuscarButton.BackgroundImage = Global.Sistema_de_Inventario_de_Bodegas.My.Resources.Resources._16__Search_
        Me.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuscarButton.Enabled = False
        Me.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BuscarButton.Location = New System.Drawing.Point(297, 96)
        Me.BuscarButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(37, 28)
        Me.BuscarButton.TabIndex = 82
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Enabled = False
        Me.BuscarTextBox.Location = New System.Drawing.Point(145, 97)
        Me.BuscarTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BuscarTextBox.Multiline = True
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(188, 25)
        Me.BuscarTextBox.TabIndex = 81
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(473, 145)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 22)
        Me.DateTimePicker1.TabIndex = 78
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Enabled = False
        Me.CantidadTextBox.Location = New System.Drawing.Point(473, 228)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CantidadTextBox.TabIndex = 77
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Enabled = False
        Me.ObservacionTextBox.Location = New System.Drawing.Point(473, 188)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ObservacionTextBox.TabIndex = 75
        '
        'NombreProductoTextBox
        '
        Me.NombreProductoTextBox.Enabled = False
        Me.NombreProductoTextBox.Location = New System.Drawing.Point(145, 223)
        Me.NombreProductoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreProductoTextBox.Name = "NombreProductoTextBox"
        Me.NombreProductoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombreProductoTextBox.TabIndex = 73
        '
        'IdDeptoTextBox
        '
        Me.IdDeptoTextBox.Enabled = False
        Me.IdDeptoTextBox.Location = New System.Drawing.Point(145, 182)
        Me.IdDeptoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdDeptoTextBox.Name = "IdDeptoTextBox"
        Me.IdDeptoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdDeptoTextBox.TabIndex = 71
        '
        'IdRequisicionTextBox
        '
        Me.IdRequisicionTextBox.Enabled = False
        Me.IdRequisicionTextBox.Location = New System.Drawing.Point(145, 140)
        Me.IdRequisicionTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdRequisicionTextBox.Name = "IdRequisicionTextBox"
        Me.IdRequisicionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdRequisicionTextBox.TabIndex = 70
        '
        'GroupBoxOpciones_p
        '
        Me.GroupBoxOpciones_p.Controls.Add(Me.Eliminar_Requisicion_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Agregar_Button_Requisicion)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Salir_Button)
        Me.GroupBoxOpciones_p.Controls.Add(Me.Guardar_Button_Producto)
        Me.GroupBoxOpciones_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxOpciones_p.Location = New System.Drawing.Point(20, 527)
        Me.GroupBoxOpciones_p.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxOpciones_p.Name = "GroupBoxOpciones_p"
        Me.GroupBoxOpciones_p.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxOpciones_p.Size = New System.Drawing.Size(748, 102)
        Me.GroupBoxOpciones_p.TabIndex = 84
        Me.GroupBoxOpciones_p.TabStop = False
        Me.GroupBoxOpciones_p.Text = "Opciones"
        '
        'Eliminar_Requisicion_Button
        '
        Me.Eliminar_Requisicion_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Eliminar_Requisicion_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Requisicion_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Eliminar_Requisicion_Button.ImageKey = "(ninguno)"
        Me.Eliminar_Requisicion_Button.Location = New System.Drawing.Point(396, 31)
        Me.Eliminar_Requisicion_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminar_Requisicion_Button.Name = "Eliminar_Requisicion_Button"
        Me.Eliminar_Requisicion_Button.Size = New System.Drawing.Size(181, 58)
        Me.Eliminar_Requisicion_Button.TabIndex = 36
        Me.Eliminar_Requisicion_Button.Text = "Eliminar"
        Me.Eliminar_Requisicion_Button.UseVisualStyleBackColor = False
        '
        'Agregar_Button_Requisicion
        '
        Me.Agregar_Button_Requisicion.BackColor = System.Drawing.Color.PowderBlue
        Me.Agregar_Button_Requisicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Button_Requisicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Agregar_Button_Requisicion.ImageKey = "(ninguno)"
        Me.Agregar_Button_Requisicion.Location = New System.Drawing.Point(207, 31)
        Me.Agregar_Button_Requisicion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregar_Button_Requisicion.Name = "Agregar_Button_Requisicion"
        Me.Agregar_Button_Requisicion.Size = New System.Drawing.Size(181, 58)
        Me.Agregar_Button_Requisicion.TabIndex = 35
        Me.Agregar_Button_Requisicion.Text = "Agregar"
        Me.Agregar_Button_Requisicion.UseVisualStyleBackColor = False
        '
        'Salir_Button
        '
        Me.Salir_Button.BackColor = System.Drawing.Color.PowderBlue
        Me.Salir_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salir_Button.ImageKey = "16 (Exit).ico"
        Me.Salir_Button.Location = New System.Drawing.Point(581, 31)
        Me.Salir_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Salir_Button.Name = "Salir_Button"
        Me.Salir_Button.Size = New System.Drawing.Size(159, 58)
        Me.Salir_Button.TabIndex = 24
        Me.Salir_Button.Text = "Salir"
        Me.Salir_Button.UseVisualStyleBackColor = False
        '
        'Guardar_Button_Producto
        '
        Me.Guardar_Button_Producto.BackColor = System.Drawing.Color.PowderBlue
        Me.Guardar_Button_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Button_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_Button_Producto.ImageKey = "(ninguno)"
        Me.Guardar_Button_Producto.Location = New System.Drawing.Point(17, 31)
        Me.Guardar_Button_Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guardar_Button_Producto.Name = "Guardar_Button_Producto"
        Me.Guardar_Button_Producto.Size = New System.Drawing.Size(181, 58)
        Me.Guardar_Button_Producto.TabIndex = 34
        Me.Guardar_Button_Producto.Text = "Guardar"
        Me.Guardar_Button_Producto.UseVisualStyleBackColor = False
        '
        'RequisicionDataGridView
        '
        Me.RequisicionDataGridView.AutoGenerateColumns = False
        Me.RequisicionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RequisicionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequisicionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRequisiciónDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdDepartamentoDataGridViewTextBoxColumn, Me.ObservaciónDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.RequisicionDataGridView.DataSource = Me.RequisicionBindingSource
        Me.RequisicionDataGridView.Enabled = False
        Me.RequisicionDataGridView.Location = New System.Drawing.Point(19, 276)
        Me.RequisicionDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RequisicionDataGridView.Name = "RequisicionDataGridView"
        Me.RequisicionDataGridView.Size = New System.Drawing.Size(745, 185)
        Me.RequisicionDataGridView.TabIndex = 85
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Nothing
        Me.InventarioBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Nothing
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Cancelar_Operacion})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 53)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(799, 27)
        Me.InventarioBindingNavigator.TabIndex = 86
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'IdRequisiciónDataGridViewTextBoxColumn
        '
        Me.IdRequisiciónDataGridViewTextBoxColumn.DataPropertyName = "IdRequisición"
        Me.IdRequisiciónDataGridViewTextBoxColumn.HeaderText = "IdRequisición"
        Me.IdRequisiciónDataGridViewTextBoxColumn.Name = "IdRequisiciónDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        '
        'ObservaciónDataGridViewTextBoxColumn
        '
        Me.ObservaciónDataGridViewTextBoxColumn.DataPropertyName = "Observación"
        Me.ObservaciónDataGridViewTextBoxColumn.HeaderText = "Observación"
        Me.ObservaciónDataGridViewTextBoxColumn.Name = "ObservaciónDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'RequisicionBindingSource
        '
        Me.RequisicionBindingSource.DataMember = "Requisición"
        Me.RequisicionBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisiciónTableAdapter
        '
        Me.RequisiciónTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentoTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.RequisiciónTableAdapter = Me.RequisiciónTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Requisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(799, 644)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.RequisicionDataGridView)
        Me.Controls.Add(Me.GroupBoxOpciones_p)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(BuscarLabel)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(NombreProductoLabel)
        Me.Controls.Add(Me.NombreProductoTextBox)
        Me.Controls.Add(IdDeptoLabel)
        Me.Controls.Add(Me.IdDeptoTextBox)
        Me.Controls.Add(IdRequisicionLabel)
        Me.Controls.Add(Me.IdRequisicionTextBox)
        Me.Controls.Add(Me.Label_Inventario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Requisicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisicion"
        Me.GroupBoxOpciones_p.ResumeLayout(False)
        CType(Me.RequisicionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.RequisicionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Inventario As Label
    Friend WithEvents BuscarButton As Button
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents NombreProductoTextBox As TextBox
    Friend WithEvents IdDeptoTextBox As TextBox
    Friend WithEvents IdRequisicionTextBox As TextBox
    Friend WithEvents GroupBoxOpciones_p As GroupBox
    Friend WithEvents Eliminar_Requisicion_Button As Button
    Friend WithEvents Agregar_Button_Requisicion As Button
    Friend WithEvents Salir_Button As Button
    Friend WithEvents Guardar_Button_Producto As Button
    Friend WithEvents RequisicionDataGridView As DataGridView
    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents RequisicionBindingSource As BindingSource
    Friend WithEvents RequisiciónTableAdapter As _Inv_Bodegas_DataSetTableAdapters.RequisiciónTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdRequisiciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventarioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Cancelar_Operacion As ToolStripButton
End Class
