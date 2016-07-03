Public Class Inventario_Form
    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
        Guardar_Inventario.Visible = False
        Nuevo_Inventario.Visible = False
        Eliminar_Inventario.Visible = False
        Cancelar_Operacion.Visible = False

    End Sub

    Private Sub Inventario_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Bodega)
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Bodega' Puede moverla o quitarla según sea necesario.
        'Me.BodegaTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Bodega)
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Producto)
        'TODO: This line of code loads data into the '_Inv_Bodegas_DataSet.Producto' table. You can move, or remove it, as needed.
        Me.InventarioTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Inventario)
        'TODO: This line of code loads data into the '_Inv_Bodegas_DataSet.Inventario' table. You can move, or remove it, as needed.
        Me.InventarioTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Inventario)

    End Sub
    Private Sub Salir_Button_Inventario_Click(sender As Object, e As EventArgs) Handles Salir_Button_inventario.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Editar_Button_Inventario_Click(sender As Object, e As EventArgs) Handles Editar_Button_inventario.Click
        Guardar_Inventario.Visible = True
        Nuevo_Inventario.Visible = True
        Eliminar_Inventario.Visible = True
        Cancelar_Operacion.Visible = True



    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs) Handles Cancelar_Operacion.Click
        Guardar_Inventario.Visible = False
        Nuevo_Inventario.Visible = False
        Eliminar_Inventario.Visible = False
        Cancelar_Operacion.Visible = False

    End Sub
End Class