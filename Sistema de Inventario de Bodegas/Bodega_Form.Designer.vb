<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bodega_Form
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
        Dim IdBodegaLabel As System.Windows.Forms.Label
        Dim LocalizaciónLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bodega_Form))
        Me.BodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Inv_Bodegas_DataSet = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSet()
        Me.BodegaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdBodegaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalizaciónTextBox = New System.Windows.Forms.TextBox()
        Me.Guardar_Btn_Bodega = New System.Windows.Forms.Button()
        Me.Salir_Btn_Bodega = New System.Windows.Forms.Button()
        Me.BodegaTableAdapter = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager()
        Me.Agregar_Btn_Bodega = New System.Windows.Forms.Button()
        Me.Eliminar_Btn_Bodega = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.BodegaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BodegaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IdBodegaLabel = New System.Windows.Forms.Label()
        LocalizaciónLabel = New System.Windows.Forms.Label()
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodegaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BodegaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdBodegaLabel
        '
        IdBodegaLabel.AutoSize = True
        IdBodegaLabel.Location = New System.Drawing.Point(12, 72)
        IdBodegaLabel.Name = "IdBodegaLabel"
        IdBodegaLabel.Size = New System.Drawing.Size(59, 13)
        IdBodegaLabel.TabIndex = 2
        IdBodegaLabel.Text = "Id Bodega:"
        '
        'LocalizaciónLabel
        '
        LocalizaciónLabel.AutoSize = True
        LocalizaciónLabel.Location = New System.Drawing.Point(12, 98)
        LocalizaciónLabel.Name = "LocalizaciónLabel"
        LocalizaciónLabel.Size = New System.Drawing.Size(69, 13)
        LocalizaciónLabel.TabIndex = 4
        LocalizaciónLabel.Text = "Localización:"
        '
        'BodegaBindingSource
        '
        Me.BodegaBindingSource.DataMember = "Bodega"
        Me.BodegaBindingSource.DataSource = Me._Inv_Bodegas_DataSet
        '
        '_Inv_Bodegas_DataSet
        '
        Me._Inv_Bodegas_DataSet.DataSetName = "Inv-Bodegas_DataSet"
        Me._Inv_Bodegas_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BodegaDataGridView
        '
        Me.BodegaDataGridView.AllowUserToAddRows = False
        Me.BodegaDataGridView.AllowUserToDeleteRows = False
        Me.BodegaDataGridView.AutoGenerateColumns = False
        Me.BodegaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BodegaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BodegaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.BodegaDataGridView.DataSource = Me.BodegaBindingSource
        Me.BodegaDataGridView.Location = New System.Drawing.Point(12, 134)
        Me.BodegaDataGridView.Name = "BodegaDataGridView"
        Me.BodegaDataGridView.ReadOnly = True
        Me.BodegaDataGridView.Size = New System.Drawing.Size(342, 122)
        Me.BodegaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdBodega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdBodega"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Localización"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Localización"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'IdBodegaTextBox
        '
        Me.IdBodegaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BodegaBindingSource, "IdBodega", True))
        Me.IdBodegaTextBox.Location = New System.Drawing.Point(87, 69)
        Me.IdBodegaTextBox.Name = "IdBodegaTextBox"
        Me.IdBodegaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdBodegaTextBox.TabIndex = 3
        '
        'LocalizaciónTextBox
        '
        Me.LocalizaciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BodegaBindingSource, "Localización", True))
        Me.LocalizaciónTextBox.Location = New System.Drawing.Point(87, 95)
        Me.LocalizaciónTextBox.Name = "LocalizaciónTextBox"
        Me.LocalizaciónTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocalizaciónTextBox.TabIndex = 5
        '
        'Guardar_Btn_Bodega
        '
        Me.Guardar_Btn_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar_Btn_Bodega.Location = New System.Drawing.Point(0, 262)
        Me.Guardar_Btn_Bodega.Name = "Guardar_Btn_Bodega"
        Me.Guardar_Btn_Bodega.Size = New System.Drawing.Size(91, 31)
        Me.Guardar_Btn_Bodega.TabIndex = 6
        Me.Guardar_Btn_Bodega.Text = "Guardar"
        Me.Guardar_Btn_Bodega.UseVisualStyleBackColor = True
        '
        'Salir_Btn_Bodega
        '
        Me.Salir_Btn_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Btn_Bodega.Location = New System.Drawing.Point(289, 262)
        Me.Salir_Btn_Bodega.Name = "Salir_Btn_Bodega"
        Me.Salir_Btn_Bodega.Size = New System.Drawing.Size(91, 31)
        Me.Salir_Btn_Bodega.TabIndex = 7
        Me.Salir_Btn_Bodega.Text = "Salir"
        Me.Salir_Btn_Bodega.UseVisualStyleBackColor = True
        '
        'BodegaTableAdapter
        '
        Me.BodegaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BodegaTableAdapter = Me.BodegaTableAdapter
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Inventario_de_Bodegas._Inv_Bodegas_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Agregar_Btn_Bodega
        '
        Me.Agregar_Btn_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_Btn_Bodega.Location = New System.Drawing.Point(97, 262)
        Me.Agregar_Btn_Bodega.Name = "Agregar_Btn_Bodega"
        Me.Agregar_Btn_Bodega.Size = New System.Drawing.Size(88, 31)
        Me.Agregar_Btn_Bodega.TabIndex = 8
        Me.Agregar_Btn_Bodega.Text = "Agregar"
        Me.Agregar_Btn_Bodega.UseVisualStyleBackColor = True
        '
        'Eliminar_Btn_Bodega
        '
        Me.Eliminar_Btn_Bodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_Btn_Bodega.Location = New System.Drawing.Point(191, 262)
        Me.Eliminar_Btn_Bodega.Name = "Eliminar_Btn_Bodega"
        Me.Eliminar_Btn_Bodega.Size = New System.Drawing.Size(91, 31)
        Me.Eliminar_Btn_Bodega.TabIndex = 9
        Me.Eliminar_Btn_Bodega.Text = "Eliminar"
        Me.Eliminar_Btn_Bodega.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(390, 41)
        Me.LabelTitulo.TabIndex = 10
        Me.LabelTitulo.Text = "Bodega"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BodegaBindingNavigator
        '
        Me.BodegaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BodegaBindingNavigator.BackColor = System.Drawing.Color.PowderBlue
        Me.BodegaBindingNavigator.BindingSource = Me.BodegaBindingSource
        Me.BodegaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BodegaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BodegaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BodegaBindingNavigatorSaveItem})
        Me.BodegaBindingNavigator.Location = New System.Drawing.Point(0, 41)
        Me.BodegaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BodegaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BodegaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BodegaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BodegaBindingNavigator.Name = "BodegaBindingNavigator"
        Me.BodegaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BodegaBindingNavigator.Size = New System.Drawing.Size(390, 25)
        Me.BodegaBindingNavigator.TabIndex = 11
        Me.BodegaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BodegaBindingNavigatorSaveItem
        '
        Me.BodegaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BodegaBindingNavigatorSaveItem.Image = CType(resources.GetObject("BodegaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BodegaBindingNavigatorSaveItem.Name = "BodegaBindingNavigatorSaveItem"
        Me.BodegaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BodegaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Bodega_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(390, 328)
        Me.Controls.Add(Me.BodegaBindingNavigator)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Eliminar_Btn_Bodega)
        Me.Controls.Add(Me.Agregar_Btn_Bodega)
        Me.Controls.Add(Me.Salir_Btn_Bodega)
        Me.Controls.Add(Me.Guardar_Btn_Bodega)
        Me.Controls.Add(IdBodegaLabel)
        Me.Controls.Add(Me.IdBodegaTextBox)
        Me.Controls.Add(LocalizaciónLabel)
        Me.Controls.Add(Me.LocalizaciónTextBox)
        Me.Controls.Add(Me.BodegaDataGridView)
        Me.Name = "Bodega_Form"
        Me.Text = "Bodega"
        CType(Me.BodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Inv_Bodegas_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodegaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BodegaBindingNavigator.ResumeLayout(False)
        Me.BodegaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Inv_Bodegas_DataSet As _Inv_Bodegas_DataSet
    Friend WithEvents BodegaBindingSource As BindingSource
    Friend WithEvents BodegaTableAdapter As _Inv_Bodegas_DataSetTableAdapters.BodegaTableAdapter
    Friend WithEvents TableAdapterManager As _Inv_Bodegas_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BodegaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdBodegaTextBox As TextBox
    Friend WithEvents LocalizaciónTextBox As TextBox
    Friend WithEvents Guardar_Btn_Bodega As Button
    Friend WithEvents Salir_Btn_Bodega As Button
    Friend WithEvents Agregar_Btn_Bodega As Button
    Friend WithEvents Eliminar_Btn_Bodega As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents BodegaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BodegaBindingNavigatorSaveItem As ToolStripButton
End Class
