<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Form))
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.PCname_Label = New System.Windows.Forms.Label()
        Me.DateandTime_Label = New System.Windows.Forms.Label()
        Me.MenuBorder_Label = New System.Windows.Forms.Label()
        Me.Salida_Botton = New System.Windows.Forms.Button()
        Me.Ayuda_Botton = New System.Windows.Forms.Button()
        Me.Reportes_Botton = New System.Windows.Forms.Button()
        Me.Inventario_Botton = New System.Windows.Forms.Button()
        Me.ReqInv_Botton = New System.Windows.Forms.Button()
        Me.MenuTitle_Label = New System.Windows.Forms.Label()
        Me.Menu_MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoDeRequisicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalledERequisicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDeSalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleDeEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Menu_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Menu_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.Username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_Label.Location = New System.Drawing.Point(609, 499)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(167, 18)
        Me.Username_Label.TabIndex = 23
        Me.Username_Label.Text = "Nombre Usuario: Admin"
        '
        'PCname_Label
        '
        Me.PCname_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.PCname_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCname_Label.Location = New System.Drawing.Point(0, 499)
        Me.PCname_Label.Name = "PCname_Label"
        Me.PCname_Label.Size = New System.Drawing.Size(172, 23)
        Me.PCname_Label.TabIndex = 22
        Me.PCname_Label.Text = "Nombre de Equipo: Host"
        '
        'DateandTime_Label
        '
        Me.DateandTime_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateandTime_Label.AutoSize = True
        Me.DateandTime_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.DateandTime_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateandTime_Label.Location = New System.Drawing.Point(296, 500)
        Me.DateandTime_Label.Name = "DateandTime_Label"
        Me.DateandTime_Label.Size = New System.Drawing.Size(104, 18)
        Me.DateandTime_Label.TabIndex = 20
        Me.DateandTime_Label.Text = "Date and Time"
        Me.DateandTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuBorder_Label
        '
        Me.MenuBorder_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuBorder_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.MenuBorder_Label.Location = New System.Drawing.Point(0, 495)
        Me.MenuBorder_Label.Name = "MenuBorder_Label"
        Me.MenuBorder_Label.Size = New System.Drawing.Size(798, 28)
        Me.MenuBorder_Label.TabIndex = 21
        Me.MenuBorder_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Salida_Botton
        '
        Me.Salida_Botton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Salida_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Salida_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Salida_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salida_Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salida_Botton.ImageKey = "16 (Cancel).ico"
        Me.Salida_Botton.ImageList = Me.Menu_ImageList
        Me.Salida_Botton.Location = New System.Drawing.Point(674, 67)
        Me.Salida_Botton.Name = "Salida_Botton"
        Me.Salida_Botton.Size = New System.Drawing.Size(123, 44)
        Me.Salida_Botton.TabIndex = 18
        Me.Salida_Botton.Text = "Salir"
        Me.Salida_Botton.UseVisualStyleBackColor = False
        '
        'Ayuda_Botton
        '
        Me.Ayuda_Botton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Ayuda_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Ayuda_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ayuda_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ayuda_Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ayuda_Botton.ImageKey = "16 (Information-2).ico"
        Me.Ayuda_Botton.ImageList = Me.Menu_ImageList
        Me.Ayuda_Botton.Location = New System.Drawing.Point(531, 67)
        Me.Ayuda_Botton.Name = "Ayuda_Botton"
        Me.Ayuda_Botton.Size = New System.Drawing.Size(137, 44)
        Me.Ayuda_Botton.TabIndex = 17
        Me.Ayuda_Botton.Text = "Ayuda"
        Me.Ayuda_Botton.UseVisualStyleBackColor = False
        '
        'Reportes_Botton
        '
        Me.Reportes_Botton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Reportes_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Reportes_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reportes_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reportes_Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reportes_Botton.ImageKey = "16 (Header).ico"
        Me.Reportes_Botton.ImageList = Me.Menu_ImageList
        Me.Reportes_Botton.Location = New System.Drawing.Point(344, 67)
        Me.Reportes_Botton.Name = "Reportes_Botton"
        Me.Reportes_Botton.Size = New System.Drawing.Size(181, 44)
        Me.Reportes_Botton.TabIndex = 16
        Me.Reportes_Botton.Text = "Reportes"
        Me.Reportes_Botton.UseVisualStyleBackColor = False
        '
        'Inventario_Botton
        '
        Me.Inventario_Botton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Inventario_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.Inventario_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Inventario_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inventario_Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inventario_Botton.ImageKey = "16 (Card edit).ico"
        Me.Inventario_Botton.ImageList = Me.Menu_ImageList
        Me.Inventario_Botton.Location = New System.Drawing.Point(159, 67)
        Me.Inventario_Botton.Name = "Inventario_Botton"
        Me.Inventario_Botton.Size = New System.Drawing.Size(179, 44)
        Me.Inventario_Botton.TabIndex = 15
        Me.Inventario_Botton.Text = " Inventario"
        Me.Inventario_Botton.UseVisualStyleBackColor = False
        '
        'ReqInv_Botton
        '
        Me.ReqInv_Botton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ReqInv_Botton.BackColor = System.Drawing.Color.PowderBlue
        Me.ReqInv_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ReqInv_Botton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqInv_Botton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReqInv_Botton.ImageKey = "16 (Address book).ico"
        Me.ReqInv_Botton.ImageList = Me.Menu_ImageList
        Me.ReqInv_Botton.Location = New System.Drawing.Point(0, 67)
        Me.ReqInv_Botton.Name = "ReqInv_Botton"
        Me.ReqInv_Botton.Size = New System.Drawing.Size(153, 44)
        Me.ReqInv_Botton.TabIndex = 14
        Me.ReqInv_Botton.Text = "Requisición Inventario"
        Me.ReqInv_Botton.UseVisualStyleBackColor = False
        '
        'MenuTitle_Label
        '
        Me.MenuTitle_Label.BackColor = System.Drawing.Color.DarkCyan
        Me.MenuTitle_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MenuTitle_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTitle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTitle_Label.Location = New System.Drawing.Point(0, 0)
        Me.MenuTitle_Label.Name = "MenuTitle_Label"
        Me.MenuTitle_Label.Size = New System.Drawing.Size(798, 65)
        Me.MenuTitle_Label.TabIndex = 13
        Me.MenuTitle_Label.Text = "Sistema de Inventario de Bodega"
        Me.MenuTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_MenuStrip
        '
        Me.Menu_MenuStrip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Menu_MenuStrip.AutoSize = False
        Me.Menu_MenuStrip.BackColor = System.Drawing.Color.PowderBlue
        Me.Menu_MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Menu_MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDeRequisicionesToolStripMenuItem, Me.MantenimientoDeInventarioToolStripMenuItem})
        Me.Menu_MenuStrip.Location = New System.Drawing.Point(0, 114)
        Me.Menu_MenuStrip.Name = "Menu_MenuStrip"
        Me.Menu_MenuStrip.Size = New System.Drawing.Size(797, 31)
        Me.Menu_MenuStrip.TabIndex = 19
        Me.Menu_MenuStrip.Text = "MenuStrip1"
        '
        'MantenimientoDeRequisicionesToolStripMenuItem
        '
        Me.MantenimientoDeRequisicionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalledERequisicionesToolStripMenuItem, Me.SalidasToolStripMenuItem, Me.DetalleDeSalidasToolStripMenuItem, Me.DepartamentosToolStripMenuItem})
        Me.MantenimientoDeRequisicionesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MantenimientoDeRequisicionesToolStripMenuItem.Name = "MantenimientoDeRequisicionesToolStripMenuItem"
        Me.MantenimientoDeRequisicionesToolStripMenuItem.Size = New System.Drawing.Size(264, 27)
        Me.MantenimientoDeRequisicionesToolStripMenuItem.Text = "Mantenimiento de Requisiciones"
        '
        'DetalledERequisicionesToolStripMenuItem
        '
        Me.DetalledERequisicionesToolStripMenuItem.Name = "DetalledERequisicionesToolStripMenuItem"
        Me.DetalledERequisicionesToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.DetalledERequisicionesToolStripMenuItem.Text = "Detalle de Solicitud"
        '
        'SalidasToolStripMenuItem
        '
        Me.SalidasToolStripMenuItem.Name = "SalidasToolStripMenuItem"
        Me.SalidasToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.SalidasToolStripMenuItem.Text = "Salidas"
        '
        'DetalleDeSalidasToolStripMenuItem
        '
        Me.DetalleDeSalidasToolStripMenuItem.Name = "DetalleDeSalidasToolStripMenuItem"
        Me.DetalleDeSalidasToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.DetalleDeSalidasToolStripMenuItem.Text = "Detalle de Salidas"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'MantenimientoDeInventarioToolStripMenuItem
        '
        Me.MantenimientoDeInventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.EntradasToolStripMenuItem, Me.DetalleDeEntradasToolStripMenuItem, Me.BodegasToolStripMenuItem})
        Me.MantenimientoDeInventarioToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MantenimientoDeInventarioToolStripMenuItem.Name = "MantenimientoDeInventarioToolStripMenuItem"
        Me.MantenimientoDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(231, 27)
        Me.MantenimientoDeInventarioToolStripMenuItem.Text = "Mantenimiento de Inventario"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'EntradasToolStripMenuItem
        '
        Me.EntradasToolStripMenuItem.Name = "EntradasToolStripMenuItem"
        Me.EntradasToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.EntradasToolStripMenuItem.Text = "Entradas"
        '
        'DetalleDeEntradasToolStripMenuItem
        '
        Me.DetalleDeEntradasToolStripMenuItem.Name = "DetalleDeEntradasToolStripMenuItem"
        Me.DetalleDeEntradasToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.DetalleDeEntradasToolStripMenuItem.Text = "Detalle de Entradas"
        '
        'BodegasToolStripMenuItem
        '
        Me.BodegasToolStripMenuItem.Name = "BodegasToolStripMenuItem"
        Me.BodegasToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.BodegasToolStripMenuItem.Text = "Bodegas"
        '
        'Menu_ImageList
        '
        Me.Menu_ImageList.ImageStream = CType(resources.GetObject("Menu_ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Menu_ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.Menu_ImageList.Images.SetKeyName(0, "16 (Address book).ico")
        Me.Menu_ImageList.Images.SetKeyName(1, "16 (Card edit).ico")
        Me.Menu_ImageList.Images.SetKeyName(2, "16 (Header).ico")
        Me.Menu_ImageList.Images.SetKeyName(3, "16 (Information-2).ico")
        Me.Menu_ImageList.Images.SetKeyName(4, "16 (Cancel).ico")
        '
        'Menu_Timer
        '
        '
        'Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(798, 523)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.PCname_Label)
        Me.Controls.Add(Me.DateandTime_Label)
        Me.Controls.Add(Me.MenuBorder_Label)
        Me.Controls.Add(Me.Salida_Botton)
        Me.Controls.Add(Me.Ayuda_Botton)
        Me.Controls.Add(Me.Reportes_Botton)
        Me.Controls.Add(Me.Inventario_Botton)
        Me.Controls.Add(Me.ReqInv_Botton)
        Me.Controls.Add(Me.MenuTitle_Label)
        Me.Controls.Add(Me.Menu_MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu_MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Menu_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu_MenuStrip.ResumeLayout(False)
        Me.Menu_MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username_Label As Label
    Friend WithEvents PCname_Label As Label
    Friend WithEvents DateandTime_Label As Label
    Friend WithEvents MenuBorder_Label As Label
    Friend WithEvents Salida_Botton As Button
    Friend WithEvents Ayuda_Botton As Button
    Friend WithEvents Reportes_Botton As Button
    Friend WithEvents Inventario_Botton As Button
    Friend WithEvents ReqInv_Botton As Button
    Friend WithEvents MenuTitle_Label As Label
    Friend WithEvents Menu_MenuStrip As MenuStrip
    Friend WithEvents MantenimientoDeRequisicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalledERequisicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleDeSalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleDeEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BodegasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_ImageList As ImageList
    Friend WithEvents Menu_Timer As Timer
End Class
