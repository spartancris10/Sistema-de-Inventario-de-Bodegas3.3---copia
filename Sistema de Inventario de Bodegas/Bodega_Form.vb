Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public Class Bodega_Form
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub BodegaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BodegaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)

    End Sub

    Private Sub Bodega_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Bodega' Puede moverla o quitarla según sea necesario.
        Me.BodegaTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Bodega)
        Dim x = Me.Controls.OfType(Of TextBox)()
        For Each n As TextBox In x
            n.Clear()
        Next

        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub

    Private Sub Salir_Btn_Bodega_Click(sender As Object, e As EventArgs) Handles Salir_Btn_Bodega.Click
        Me.Close()
        Menu_Form.Show()
    End Sub

    Private Sub Guardar_Btn_Bodega_Click(sender As Object, e As EventArgs) Handles Guardar_Btn_Bodega.Click
        If IdBodegaTextBox.Text = Nothing Then
            MsgBox("Los Campos no Pueden quedar Vacios", vbInformation)
        ElseIf LocalizaciónTextBox.Text = Nothing Then
            MsgBox("Los campos no Pueden quedar Vacios", vbInformation)

        Else

            Dim cmd As New SqlCommand("Bodega_insert", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdBodega", IdBodegaTextBox.Text)
            cmd.Parameters.AddWithValue("@Localización", LocalizaciónTextBox.Text)

            Try
                cmd.ExecuteNonQuery()



                MsgBox("Los datos se guardaron Exitosamente")

                BodegaDataGridView.Refresh()
                Me.Refresh()
                BodegaDataGridView.Enabled = True
                Agregar_Btn_Bodega.Enabled = True



                Dim x = Me.Controls.OfType(Of TextBox)()
                For Each n As TextBox In x
                    n.Clear()
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cmd.Dispose()


        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) 
        'BodegaBindingSource.AddNew()

    End Sub

    Private Sub Agregar_Btn_Bodega_Click(sender As Object, e As EventArgs) Handles Agregar_Btn_Bodega.Click
        BodegaBindingSource.AddNew()

        Agregar_Btn_Bodega.Enabled = False
        BodegaDataGridView.Enabled = False
        IdBodegaTextBox.Focus()

    End Sub

    Private Sub Eliminar_Btn_Bodega_Click(sender As Object, e As EventArgs) Handles Eliminar_Btn_Bodega.Click
        If MsgBox("Desea Eliminar el registro Seleccionado", vbYesNo) = MsgBoxResult.Yes Then

            BodegaBindingSource.RemoveCurrent()
            MsgBox("Los datos se eliminaron correctamente", vbExclamation)
            BodegaDataGridView.Refresh()
            Me.TableAdapterManager.UpdateAll(Me._Inv_Bodegas_DataSet)
        End If
    End Sub
End Class