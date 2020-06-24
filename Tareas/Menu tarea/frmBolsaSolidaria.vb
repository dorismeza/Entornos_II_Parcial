Imports System.ComponentModel
Public Class frmBolsaSolidaria
    Private identidad As String
    Private nombre As String
    Private municipio As String
    Private direccion As String
    Private integrantes As Integer
    Private datos(,) As String
    Private i, cont As Integer
    Private id(10) As String

    Private Sub frmBolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim x As String
        Dim itemDepartamento As String
        ReDim Preserve id(10)
        ReDim Preserve datos(100, 5)
        itemDepartamento = cmbDepartamento.SelectedItem
        municipio = txtMunicipio.Text
        nombre = txtNombre.Text
        direccion = txtDireccion.Text

        x = txtIdentidad.Text
        Try
            If txtNombre.Text = "" Then
                MsgBox("Ingrese un Nombre")
            ElseIf IsNumeric(txtNombre.Text) Then
                MsgBox("Ingrese un nombre correcto")
            ElseIf txtDireccion.Text = "" Then
                MsgBox("Ingrese una Direccion")
            ElseIf txtMunicipio.Text = "" Then
                MsgBox("Ingrese Municipio")
            ElseIf cmbDepartamento.Text = "" Then
                MsgBox("Ingrese Departamento")
            ElseIf txtIdentidad.Text = "" Then
                MsgBox("Ingrese Municipio")
            ElseIf Not IsNumeric(txtIdentidad.Text) Then
                MsgBox("Ingrese un valor numerico")
            ElseIf x.Length <> 13 Then
                MsgBox("Ingrese una identidad Correcta")
            Else
                For j = 0 To 10 Step 1
                    If x = id(j) Then
                        MessageBox.Show("¡La bolsa ya ha sido entregada a esta persona!", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtIdentidad.Clear()
                        grpDatosFam.Enabled = False
                    Else
                        For c = 0 To i Step 1
                            id(c) = txtIdentidad.Text
                            datos(c, 0) = nombre
                            datos(c, 1) = x
                            datos(c, 2) = municipio
                            datos(c, 3) = departamento()
                            datos(c, 4) = direccion
                            grpDatosFam.Enabled = True

                        Next
                    End If
                Next
            End If
            mostrarReporte(datos)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        integrantes = txtIntegrantes.Text
        cont += 1

        If integrantes >= 1 And integrantes <= 3 Then
            lstContenido.Items.Clear()
            lbBasica.Visible = True
            lstContenido.Items.Add("Frijoles")
            lstContenido.Items.Add("Arroz")
            lstContenido.Items.Add("Manteca")
            lstContenido.Items.Add("Jabón")
            lstContenido.Items.Add("Harina")
            lstContenido.Items.Add("Papel Higiénico")
            lstContenido.Items.Add("Sal")
            MsgBox("Bolsa Entregada con exito", vbInformation)

        ElseIf integrantes > 3 Then
            lstContenido.Items.Clear()
            lbRegular.Visible = True
            lstContenido.Items.Add("Frijoles")
            lstContenido.Items.Add("Arroz")
            lstContenido.Items.Add("Manteca")
            lstContenido.Items.Add("Jabón")
            lstContenido.Items.Add("Harina")
            lstContenido.Items.Add("Papel Higiénico")
            lstContenido.Items.Add("Sal")
            lstContenido.Items.Add("Pasta")
            lstContenido.Items.Add("Desinfectante")
            lstContenido.Items.Add("Azúcar")
            MsgBox("Bolsa Entregada con exito", vbInformation)

        End If



    End Sub
    Private Function departamento()
        Dim depto, itemDepartamento As String
        Dim idDepartamento As Integer
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString

        Try
            Select Case (idDepartamento)
                Case 0
                    depto = "Atlantida"

                Case 1
                    depto = "Colon"
                Case 2
                    depto = "Comayagua"
                Case 3
                    depto = "Copán"
                Case 4
                    depto = "Cortes"
                Case 5
                    depto = "Choluteca"
                Case 6
                    depto = "El Paraiso"
                Case 7
                    depto = "Francisco Morazán"
                Case 8
                    depto = "Gracias a Dios"
                Case 9
                    depto = "Intibuca"
                Case 10
                    depto = "Islas de la Bahia"
                Case 11
                    depto = "La paz"
                Case 12
                    depto = "Lempira"
                Case 13
                    depto = "Ocotepeque"
                Case 14
                    depto = "Olancho"
                Case 15
                    depto = "Santa Barbara"
                Case 16
                    depto = "Valle"
                Case 17
                    depto = "Yoro"
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return depto
    End Function
    Private Sub mostrarReporte(datos(,) As String)
        Dim idEstado, f, c As Integer
        Dim itemEstado As String
        idEstado = cmbEstado.SelectedIndex
        itemEstado = cmbDepartamento.SelectedItem.ToString

        lstReporte.Items.Clear()
        For c = 0 To i Step 1
            If integrantes >= 1 And integrantes <= 3 Then
                datos(c, 5) = "Básica"
            ElseIf integrantes <= 3 Then
                datos(c, 5) = "Regular"
            End If
        Next

        For f = 0 To UBound(datos)
            For c = 0 To UBound(datos)
                lstReporte.Items.Add(datos(f, c))
            Next
        Next

        txtTotal.Text = cont
    End Sub

    Private Sub btnNueo_Click(sender As Object, e As EventArgs) Handles btnNueo.Click
        i = i + 1
        txtNombre.Clear()
        txtDireccion.Clear()
        txtMunicipio.Clear()
        txtIdentidad.Clear()
        txtIntegrantes.Clear()
        grpDatosFam.Enabled = False

    End Sub
    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un Municipio")
        End If
    End Sub
    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una direccion")
        End If
    End Sub
    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
    Private Sub txtIntegrantes_Validating(sender As Object, e As CancelEventArgs) Handles txtIntegrantes.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Elige un Estado")
        End If
    End Sub
    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese nombre completo")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Ingrese la identidad")
        ToolTip.ToolTipTitle = "Numero de Identida"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese Municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "Ingrese la Direccion")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles txtIntegrantes.MouseHover
        ToolTip.SetToolTip(txtIntegrantes, "Ingrese una cantidad")
        ToolTip.ToolTipTitle = "Integrantes"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class