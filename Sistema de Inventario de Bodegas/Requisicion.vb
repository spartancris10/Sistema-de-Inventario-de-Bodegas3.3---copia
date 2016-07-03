Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class Requisicion
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Private Sub Requisicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Requisición' Puede moverla o quitarla según sea necesario.
        Me.RequisiciónTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Requisición)
        '        Me.RequisicionBindingSource.ResetBindings(True)
        '       Me.InventarioBindingNavigator.Refresh()



        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub

    Private Sub Cancelar_Operacion_Click(sender As Object, e As EventArgs)

        Cancelar_Operacion.Visible = False
        BuscarTextBox.Enabled = False
        BuscarButton.Enabled = False
        IdRequisicionTextBox.Enabled = False
        IdDeptoTextBox.Enabled = False
        DateTimePicker1.Enabled = False
        ObservacionTextBox.Enabled = False
        NombreProductoTextBox.Enabled = False
        CantidadTextBox.Enabled = False
        Agregar_Button_Requisicion.Enabled = True
        RequisicionDataGridView.Enabled = False
    End Sub

    Private Sub Agregar_Button_Requisicion_Click(sender As Object, e As EventArgs) Handles Agregar_Button_Requisicion.Click
        RequisicionBindingSource.AddNew()
        Agregar_Button_Requisicion.Enabled = False
        IdRequisicionTextBox.Focus()

        Cancelar_Operacion.Visible = True
        BuscarTextBox.Enabled = True
        BuscarButton.Enabled = True
        IdRequisicionTextBox.Enabled = True
        IdDeptoTextBox.Enabled = True
        DateTimePicker1.Enabled = True
        ObservacionTextBox.Enabled = True
        NombreProductoTextBox.Enabled = True
        CantidadTextBox.Enabled = True
        RequisicionDataGridView.Enabled = True


    End Sub

    Private Sub Salir_Button_Click(sender As Object, e As EventArgs) Handles Salir_Button.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Eliminar_Requisicion_Button_Click(sender As Object, e As EventArgs) Handles Eliminar_Requisicion_Button.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            Me.Validate()
            RequisicionBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            RequisicionDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

        End If
    End Sub

    Private Sub RequisicionBindingNavigatorSaveItem(sender As Object, e As EventArgs) Handles Guardar_Button_Producto.Click
        If IdRequisicionTextBox.Text = Nothing Then
            MsgBox("El Campo IdRequisicion no Puede quedar Vacio", vbInformation)
        ElseIf IdDeptoTextBox.Text = Nothing Then
            MsgBox("El Campo IdDepartamento no Puede quedar Vacio", vbInformation)
        ElseIf NombreProductoTextBox.Text = Nothing Then
            MsgBox("El Campo NombreProducto no Puede quedar Vacio", vbInformation)
        ElseIf ObservacionTextBox.Text = Nothing Then
            MsgBox("El Campo Observacion no Puede quedar Vacio", vbInformation)
        ElseIf CantidadTextBox.Text = Nothing Then
            MsgBox("El Campo Cantidad no Puede quedar Vacio", vbInformation)
        Else


            MsgBox("Los datos se guardaron exitosamente", vbInformation)
            Agregar_Button_Requisicion.Enabled = True

            Me.Validate()
            Me.RequisicionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
            RequisicionDataGridView.Refresh()
        End If
    End Sub
End Class