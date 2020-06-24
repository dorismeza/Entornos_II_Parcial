Public Class frmArreglos
    Private mComputadoras(,) As String
    Private cantComputadoras, stock As Integer
    Private index As Byte
    Private encuentra As Boolean = False
    Private Sub btnGenCompu_Click(sender As Object, e As EventArgs) Handles btnGenCompu.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"

        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputador.Items.Add(computadoras(i))
        Next

    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        Dim precios(3) As String
        precios(0) = "22500"
        precios(1) = "21000"
        precios(2) = "29000"
        precios(3) = "42000"

        For i = 0 To (precios.Length - 1) Step 1
            cmbPrecios.Items.Add(precios(i))
        Next

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String
        cant = Val(txtCantComp.Text)

        ReDim comp(cant)

        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la PC", "Ingreso")
        Next
        For j = 0 To cant Step 1
            cmbSolicitar.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbComputador.Items.Clear()
        cmbPrecios.Items.Clear()
    End Sub

    Private Sub ARREGLO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCantidad2.Text)
        ReDim mComputadoras(cantComputadoras, 3)

        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")

            index = i
            mComputadoras(i, 3) += mComputadoras(i, 3)
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim marca As String
        marca = txtMarca.Text
        marca = Asc(txtMarca.Text)

        For i = 0 To (cantComputadoras - 1) Step 1
            Asc(mComputadoras(i, 0))
            If mComputadoras(i, 0) = marca Then

                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(i, 2)
                txtCantidad.Text = mComputadoras(i, 3)
                txtMarca.Enabled = True
                encuentra = True
                btnVender.Enabled = True
                btnBuscar.Enabled = True

            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantVender As Integer
        cantVender = Val(txtCantVender.Text)

        stock = mComputadoras(index, 3)

        If (cantVender > stock) Then
            MessageBox.Show("Sin stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (cantVender <= stock) Then
            mComputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtCantidad.Text = mComputadoras(index, 3)

    End Sub



End Class
