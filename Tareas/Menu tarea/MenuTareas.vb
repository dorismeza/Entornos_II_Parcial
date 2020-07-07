Imports System.Runtime.InteropServices
Public Class MenuTareas
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMaximizar_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForm.Controls.Count > 0 Then
            Me.PanelForm.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForm.Controls.Add(frm)
        Me.PanelForm.Tag = frm
        frm.Show()
    End Sub


    Private Sub BtnArreglos_Click(sender As Object, e As EventArgs) Handles BtnArreglos.Click
        abrirFormulario(frmArreglos)
    End Sub

    Private Sub btnFunciones_Click(sender As Object, e As EventArgs) Handles btnFunciones.Click
        abrirFormulario(frmLibretaAhorro)
    End Sub

    Private Sub btnBolsa_Click(sender As Object, e As EventArgs) Handles btnBolsa.Click
        abrirFormulario(frmBolsaSolidaria)
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If PanelMenu.Width = 80 Then
            While (PanelMenu.Width < 474)
                Me.PanelMenu.Width = PanelMenu.Width + 20
            End While
            btnMostrar.Visible = False
            btnEsconder.Visible = True
        End If
    End Sub

    Private Sub btnEsconder_Click(sender As Object, e As EventArgs) Handles btnEsconder.Click
        If PanelMenu.Width >= 380 Then
            While (PanelMenu.Width > 80)
                Me.PanelMenu.Width = PanelMenu.Width - 20
            End While
            btnMostrar.Visible = True
            btnEsconder.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(frmLibretaAhorroTarea)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormulario(frmCrud)
    End Sub
End Class