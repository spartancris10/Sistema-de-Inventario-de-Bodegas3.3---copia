Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public Class Producto_Form
    Public con As New SqlConnection
    Public cmd As New SqlCommand

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.ProductoBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Inv - Bodegas_DataSet)
    End Sub

    Private Sub Producto_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Inv_Bodegas_DataSet.Requisición' table. You can move, or remove it, as needed.
        'Me.RequisiciónTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Requisición)
        'TODO: This line of code loads data into the '_Inv_Bodegas_DataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Producto)
        'TODO: This line of code loads data into the 'DataSet11.Producto' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet1.Producto' table. You can move, or remove it, as needed.
        'Me.ProductoTableAdapter.Fill(Me.Inv-Bodegas_DataSet.Producto)
        Me.ProductoBindingSource.ResetBindings(True)
        Me.ProductoBindingNavigator.Refresh()



        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()
    End Sub
    Private Sub ProductoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Guardar_Button_Producto.Click
        If IdProductoTextBox.Text = Nothing Then
            MsgBox("El Campo IdProducto no Puede quedar Vacio", vbInformation)
        ElseIf NombreTextBox.Text = Nothing Then
            MsgBox("El Campo Nombre no Puede quedar Vacio", vbInformation)
        ElseIf MarcaTextBox.Text = Nothing Then
            MsgBox("El Campo Marca no Puede quedar Vacio", vbInformation)
        ElseIf EstadoComboBox.Text = Nothing Then
            MsgBox("El Campo Estado no Puede quedar Vacio", vbInformation)
        ElseIf TipoComboBox.Text = Nothing Then
            MsgBox("El Campo Tipo no Puede quedar Vacio", vbInformation)
        Else

            Me.Validate()
            Me.ProductoBindingSource.EndEdit()
            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_Producto.Enabled = True
            ProductoDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
        End If



    End Sub

    Private Sub Editar_Button_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Cancelar_Producto_Click(sender As Object, e As EventArgs) Handles Cancelar_Producto.Click

    End Sub
    Private Sub Nuevo_Producto_Click_1(sender As Object, e As EventArgs) Handles Agregar_Button_Producto.Click
        ProductoBindingSource.AddNew()
        Agregar_Button_Producto.Enabled = False
        IdProductoTextBox.Focus()

    End Sub

    Private Sub Eliminar_Producto_Click(sender As Object, e As EventArgs) Handles Eliminar_Producto_Button.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            ProductoBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            ProductoDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub
End Class