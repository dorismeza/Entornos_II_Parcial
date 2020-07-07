
Imports System.ComponentModel

Public Class frmLibretaAhorro
    Private monto As Integer


    Private Sub activarControles()
        txtUsuario.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True

    End Sub
    Private Sub desactiveControles()
        txtUsuario.Enabled = True
        txtMonto.Enabled = True
        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False

    End Sub
    Private Sub limpiar()
        desactiveControles()
        txtUsuario.Clear()
        txtSaldoTotal.Clear()
        txtMonto.Clear()
        listDepositos.Items.Clear()
        listRetiros.Items.Clear()

    End Sub

    Private Sub frmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactiveControles()

    End Sub
    Private Sub mostrarSaldo()
        txtSaldoTotal.Text = monto
    End Sub
    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim cliente As String
        cliente = txtUsuario.Text
        monto = Val(txtMonto.Text)
        If IsNumeric(txtUsuario.Text) Then
            MsgBox("Ingrese un nombre correcto")
        ElseIf Not IsNumeric(txtMonto.Text) Then
            MsgBox("Ingrese un nombre correcto")
        Else
            If (monto > 0) Then
                activarControles()
            Else
                MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operacion")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        listDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            listRetiros.Items.Add(retiro)
            mostrarSaldo()

        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip1.SetToolTip(txtUsuario, "Ingrese un nombre")
        ToolTip1.ToolTipTitle = "Nombre usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles txtMonto.Validating
        If Val(txtMonto.Text) - Int(Val(txtMonto.Text)) = 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un monto")
        End If
    End Sub

    Private Sub txtMonto_MouseHover(sender As Object, e As EventArgs) Handles txtMonto.MouseHover
        ToolTip1.SetToolTip(txtMonto, "Ingrese un monto")
        ToolTip1.ToolTipTitle = "Monto"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If Val(txtUsuario.Text) - Int(Val(txtUsuario.Text)) = 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un nombre")
        End If
    End Sub
End Class