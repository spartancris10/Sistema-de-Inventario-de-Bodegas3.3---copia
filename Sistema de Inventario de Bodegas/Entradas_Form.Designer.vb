<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entradas_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entradas_Form))
        Me.Label_Salidas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Salidas
        '
        Me.Label_Salidas.BackColor = System.Drawing.Color.DarkCyan
        Me.Label_Salidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Salidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Salidas.Location = New System.Drawing.Point(0, 0)
        Me.Label_Salidas.Name = "Label_Salidas"
        Me.Label_Salidas.Size = New System.Drawing.Size(799, 69)
        Me.Label_Salidas.TabIndex = 40
        Me.Label_Salidas.Text = "Salidas"
        Me.Label_Salidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Entradas_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(799, 644)
        Me.Controls.Add(Me.Label_Salidas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Entradas_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Salidas As Label
End Class
