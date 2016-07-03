Public Class Login_Form
    Dim fu
    Dim eu

    Private Sub Login_Timer_Tick(sender As Object, e As EventArgs) Handles Login_Timer.Tick
        Login_ProgressBar.Increment(5)
        If Login_ProgressBar.Value = 100 Then
            Login_Timer.Enabled = False
            MsgBox("Bienvenido al sistema " & txtUser.Text)
            Me.Hide()
            Menu_Form.Show()
        End If
    End Sub

    Private Sub Exit_Botton_Click(sender As Object, e As EventArgs) Handles Exit_Botton.Click
        Me.Close()
    End Sub

    Private Sub Experimental_Button_Click(sender As Object, e As EventArgs) Handles Experimental_Button.Click
        Try
            If txtPassword.Text <> "" And txtUser.Text <> "" Then
                Dim dt As New DataTable
                eu._users = txtUser.Text
                eu._passwords = txtPassword.Text
                dt = fu.validarusuario(eu)
                If dt.Rows.Count > 0 Then
                    Login_Timer.Start()
                    'Dim nivel As String
                    'nivel = dt.Rows(0)("nivel")
                    'If nivel = "usuario" Then
                    '    My.Forms.MDIParent1.msmantenimiento.Enabled = False
                    'ElseIf nivel = "administrador" Then

                    '    My.Forms.MDIParent1.MenuStrip.Enabled = True
                    'End If
                Else
                    Static intento As Integer
                    intento = intento + 1
                    MsgBox("estimado usuario te quedan " & (3 - intento) & " intentos")
                    If intento = 3 Then
                        MsgBox("el sistema se cerrara , gracias", MsgBoxStyle.Critical, "SISTEMA")
                        Me.Close()
                        'inicio de proceso de apagado
                        'Process.Start("shutdow.exe", "-s -t 00")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Enter_Button_Click(sender As Object, e As EventArgs) Handles Enter_Button.Click
        If txtUser.Text = "" And txtPassword.Text = "" Then
            MsgBox("Los campos se encuentran vacios")
        Else
            If txtUser.Text = "" Then
                MsgBox("El campo USUARIO se encuentra vacio")
            Else
                If txtPassword.Text = "" Then
                    MsgBox("El campo CONTRASEÑA se encuentra vacio")
                Else
                    If txtUser.Text = "unicah" And txtPassword.Text = "unicah" Then
                        'Me.Hide()
                        Login_ProgressBar.Visible = True
                        Login_Timer.Start()
                    Else
                        MsgBox("Los datos son incorrectos")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Enter_Button.PerformClick()
        End If
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class