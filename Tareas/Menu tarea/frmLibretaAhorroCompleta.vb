Public Class frmLibretaAhorroCompleta
    Dim identidad As String
    Dim nombre As String
    Dim edad, i As Integer
    Dim pais, ciudad As String
    Dim saldo As String
    Dim cuenta(10, 5) As String
    Dim IdOperaciones As String
    Dim bandera As Boolean

    Private Sub frmLibretaAhorroCompleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private monto As Integer

    Private Sub activarControles()
        txtIdentidad.Enabled = False
        txtNombre.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True

    End Sub
    Private Sub desactiveControles()
        txtIdentidad.Enabled = True
        txtNombre.Enabled = True
        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False

    End Sub
    Private Sub limpiar()
        desactiveControles()
        txtIdentidad.Clear()
        txtSaldoTotal.Clear()
        txtNombre.Clear()
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
        ReDim Preserve cuenta(10, 5)
        identidad = txtIdentidad.Text
        edad = Val(txtEdad.Text)
        nombre = txtNombre.Text
        pais = txtPais.Text
        ciudad = txtNombre.Text
        saldo = Val(txtSaldo.Text)


        cuenta(i, 0) = identidad
        cuenta(i, 1) = nombre
        cuenta(i, 2) = edad
        cuenta(i, 3) = pais
        cuenta(i, 4) = ciudad
        cuenta(i, 5) = saldo

        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
        'If (monto > 0) Then
        'activarControles()
        'Else
        'MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        i += 1
    End Sub
    Private Function HacerOperacion()
        IdOperaciones = txtIdOperaciones.Text
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
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operacion")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        For c = 0 To i Step 1
            If IdOperaciones = cuenta(c, 0) Then
                deposito = leer("Depositar")
                saldo += deposito
                listDepositos.Items.Add(deposito)
                mostrarSaldo()
            End If
        Next
        MsgBox("Debe aperturar una cuenta", vbObjectError)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        For c = 0 To i Step 1
            If IdOperaciones = cuenta(c, 0) Then

                retiro = leer("Retirar")
                    If (retiro > saldo) Then
                        MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                    saldo -= retiro
                    listRetiros.Items.Add(retiro)
                        mostrarSaldo()
                    End If
                Else
                    MsgBox("Debe aperturar una cuenta", vbObjectError)
                End If
         Next
    End Sub
End Class