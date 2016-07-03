Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq
Public Class Ingresar_Producto_Form
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Public Sub Ingresar_Producto_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Inv_Bodegas_DataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me._Inv_Bodegas_DataSet.Producto)
        Producto_Form.ProductoBindingSource.ResetBindings(True)
        Producto_Form.ProductoBindingNavigator.Refresh()

        Dim x = Me.Controls.OfType(Of TextBox)()
        For Each n As TextBox In x
            n.Clear()
        Next

        con.ConnectionString = My.Settings.Inventario_de_Bodegas_UNICAHConnectionString
        con.Open()

    End Sub


    Private Sub Guardar_Mtn_Click(sender As Object, e As EventArgs) Handles Guardar_Mtn.Click
        If IdProductoTextBox.Text = Nothing Then
            MsgBox("El Campo no Puede quedar Vacio", vbInformation)
        ElseIf NombreTextBox.Text = Nothing Then
            MsgBox("El Campo no Puede quedar Vacio", vbInformation)
        ElseIf MarcaTextBox.Text = Nothing Then
            MsgBox("El Campo no Puede quedar Vacio", vbInformation)
        ElseIf EstadoComboBox.Text = Nothing Then
            MsgBox("El Campo  no Puede quedar Vacio", vbInformation)
        ElseIf TipoComboBox.Text = Nothing Then
            MsgBox("El Campo  no Puede quedar Vacio", vbInformation)
        ElseIf Producto_Form.ProductoDataGridView.Equals(IdProductoTextBox.Text) Then
            MsgBox("El id ya esta ocupado", MsgBoxStyle.Information)
        Else

            Dim cmd As New SqlCommand("ProductoGR", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdProducto", IdProductoTextBox.Text)
            cmd.Parameters.AddWithValue("@Nombre", NombreTextBox.Text)
            cmd.Parameters.AddWithValue("@Marca", MarcaTextBox.Text)
            cmd.Parameters.AddWithValue("@Estado", EstadoComboBox.Text)
            cmd.Parameters.AddWithValue("@Tipo", TipoComboBox.Text)
            Try
                cmd.ExecuteNonQuery()



                MsgBox("Los datos se guardaron Exitosamente")
                Producto_Form.ProductoDataGridView.Refresh()
                Producto_Form.ActualizarDataProducto()


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

    Private Sub Salir_Mtn_Click(sender As Object, e As EventArgs) Handles Salir_Mtn.Click
        Me.Close()
        Producto_Form.Show()
        Producto_Form.Refresh()
    End Sub
End Class