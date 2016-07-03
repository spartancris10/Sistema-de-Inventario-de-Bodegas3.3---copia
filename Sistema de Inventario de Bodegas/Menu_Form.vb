Public Class Menu_Form
    Private Sub ReqInv_Botton_Click(sender As Object, e As EventArgs) Handles ReqInv_Botton.Click
        ''Requisicion_Inventario.Show()
        ''Me.Hide()
    End Sub

    Private Sub Inventario_Botton_Click(sender As Object, e As EventArgs) Handles Inventario_Botton.Click
        Inventario_Form.Show()
    End Sub

    Private Sub Reportes_Botton_Click(sender As Object, e As EventArgs) Handles Reportes_Botton.Click
        ''Reportes.Show()
        ''Me.Hide()
    End Sub

    Private Sub Ayuda_Botton_Click(sender As Object, e As EventArgs) Handles Ayuda_Botton.Click
        ''Ayuda.Show()
        ''Me.Hide()
    End Sub

    Private Sub Salida_Botton_Click(sender As Object, e As EventArgs) Handles Salida_Botton.Click
        Login_Form.Close()
        Me.Close()
    End Sub

    Private Sub DetalledERequisicionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalledERequisicionesToolStripMenuItem.Click
        ''Detalle_Solicitud.Show()
        ''Me.Hide()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        ''Salidas.Show()
        ''Me.Hide()
    End Sub

    Private Sub DetalleDeSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeSalidasToolStripMenuItem.Click
        ''Detalle_Salidas.Show()
        ''Me.Hide()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        ''Departamento.Show()
        ''Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Producto_Form.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        ''Entradas.Show()
        ''Me.Hide()
    End Sub

    Private Sub DetalleDeEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeEntradasToolStripMenuItem.Click
        ''Detalle_Entradas()
        ''Me.Hide()
    End Sub

    Private Sub BodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegasToolStripMenuItem.Click
        Bodega_Form.Show()
    End Sub

    Private Sub Menu_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu_Timer.Enabled = True
    End Sub

    Private Sub Menu_Timer_Tick(sender As Object, e As EventArgs) Handles Menu_Timer.Tick
        DateandTime_Label.Text = DateAndTime.Now.ToString()
    End Sub
End Class