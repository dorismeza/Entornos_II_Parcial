Imports System.Runtime.InteropServices
Public Class Form1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnmaximizar_Click(sender As Object, e As EventArgs) Handles btnmaximizar.Click
        btnmaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnmaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub





    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        TimerOcultarMenu.Enabled = True
    End Sub

    Private Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
        If PanelMenu.Width >= 210 Then
            Me.timerMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub TimerOcultarMenu_Tick_1(sender As Object, e As EventArgs) Handles TimerOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.TimerOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub
End Class
