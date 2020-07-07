Imports System.ComponentModel

Public Class frmLibretaAhorroTarea
    Dim cuenta(10, 5) As String
    Dim IdOperaciones As String
    Dim bandera As Boolean
    Private monto, i As Integer


    Private Sub activarControles()

        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True

    End Sub
    Private Sub desactiveControles()

        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False

    End Sub
    Private Sub limpiar()
        desactiveControles()
        txtSaldoTotal.Clear()
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
        Dim i As Integer
        ReDim Preserve cuenta(10, 5)

        cuenta(i, 0) = InputBox("Ingrese identidad", "Apertura de cuenta")
        cuenta(i, 1) = InputBox("Ingrese Nombre", "Apertura de cuenta")
        cuenta(i, 2) = InputBox("Ingrese la edad", "Apertura de cuenta")
        cuenta(i, 3) = InputBox("Ingrese Pais", "Apertura de cuenta")
        cuenta(i, 4) = InputBox("Ingrese Ciudad", "Apertura de cuenta")
        cuenta(i, 5) = InputBox("Ingrese el saldo de apertura", "Apertura de cuenta")
        i += 1
        monto = Val(cuenta(i, 5))
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
        'If (monto > 0) Then
        'activarControles()
        'Else
        'MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub
    Private Function HacerOperacion()
        txtIdOperaciones.Text = IdOperaciones

        For c = 0 To i Step 1
            If IdOperaciones = cuenta(c, 0) Then
                bandera = True
            Else
                bandera = False
            End If
        Next
        Return bandera
    End Function

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = Val(InputBox("Ingrese un monto a " & mensaje, "Operacion"))
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        IdOperaciones = txtIdOperaciones.Text
        For c = 0 To 10 Step 1
            If IdOperaciones = cuenta(c, 0) Then
                deposito = leer("Depositar")
                monto += deposito
                listDepositos.Items.Add(deposito)
                mostrarSaldo()
            ElseIf c = 10 Then
                MsgBox("Debe aperturar una cuenta", vbObjectError)
            End If
        Next

    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double

        For c = 0 To i Step 1
            If IdOperaciones = cuenta(c, 0) Then

                retiro = leer("Retirar")
                If (retiro > monto) Then
                    MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    monto -= retiro
                    listRetiros.Items.Add(retiro)
                    mostrarSaldo()
                End If
            Else
                MsgBox("Debe aperturar una cuenta", vbObjectError)
            End If
        Next
    End Sub


    Private Sub txtIdOperaciones_TextChanged(sender As Object, e As EventArgs) Handles txtIdOperaciones.TextChanged

    End Sub

    Private Sub txtIdOperaciones_MouseHover(sender As Object, e As EventArgs) Handles txtIdOperaciones.MouseHover
        ToolTip1.SetToolTip(txtIdOperaciones, "Ingrese una Identidad")
        ToolTip1.ToolTipTitle = "Identidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdOperaciones_Validating(sender As Object, e As CancelEventArgs) Handles txtIdOperaciones.Validating
        If Val(txtIdOperaciones.Text) - Int(Val(txtIdOperaciones.Text)) = 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una identidad")
        End If
    End Sub
End Class
