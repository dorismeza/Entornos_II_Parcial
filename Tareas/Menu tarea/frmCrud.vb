Imports System.ComponentModel

Public Class frmCrud
    ' se instancia la clase conexion.vb con el nombre conexion para ser utilizada dentro del formulario
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable
    Private Sub frmCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el evento load del formulario se abre la conexion a la base de datos
        conexion.conectar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        mostrarDatos()
    End Sub

    Public Sub Limpiar()
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegApellido.Clear()
        txtEdad.Clear()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        conexion.conexion.Close()

    End Sub


    Private Sub mostrarDatos()
        Try

            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim edad As String
        edad = txtEdad.Text
        Try
            If Not IsNumeric(txtCodigo.Text) Then
                MessageBox.Show("Codigo Incorrecto")
            ElseIf IsNumeric(txtNombre.Text) Then
                MessageBox.Show("Nombre Incorrecto")
            ElseIf IsNumeric(txtPrimerApellido.Text) Then
                MessageBox.Show("Apellido Incorrecto")
            ElseIf IsNumeric(txtSegApellido.Text) Then
                MessageBox.Show("Apellido Incorrecto")
            ElseIf Not IsNumeric(txtEdad.Text) And edad.Length >= 99 Then
                MessageBox.Show("Revise y introduzca correctamente la edad")
            ElseIf cmbCodigoClase.Text = "" And cmbSexo.Text = "" Then
                MessageBox.Show("Elija una opcion")
            Else


                Dim guardar As String =
             "insert into personas.estudiante values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtPrimerApellido.Text + "',
             '" + txtSegApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "','" + cmbCodigoClase.Text + "')"

                If (conexion.insertar(guardar)) Then
                    MessageBox.Show("Guardado")
                    mostrarDatos()
                    Limpiar()
                    conexion.conexion.Close()
                Else
                    MessageBox.Show("Error al guardar")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminar("personas.estudiante", "codigo=" + txtCodigo.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtgRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentClick
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        txtCodigo.Enabled = False
        llenarCampos(e)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim edad As String
            edad = txtEdad.Text
            If Not IsNumeric(txtCodigo.Text) Then
                    MessageBox.Show("Codigo Incorrecto")
                ElseIf IsNumeric(txtNombre.Text) Then
                    MessageBox.Show("Nombre Incorrecto")
                ElseIf IsNumeric(txtPrimerApellido.Text) Then
                    MessageBox.Show("Apellido Incorrecto")
                ElseIf IsNumeric(txtSegApellido.Text) Then
                    MessageBox.Show("Apellido Incorrecto")
                ElseIf Not IsNumeric(txtEdad.Text) And edad.Length >= 99 Then
                    MessageBox.Show("Revise y introduzca correctamente la edad")
                ElseIf cmbCodigoClase.Text = "" And cmbSexo.Text = "" Then
                    MessageBox.Show("Elija una opcion")
                Else
                    Dim modificar As String =
            "nombre='" + txtNombre.Text + "', primerApellido='" + txtPrimerApellido.Text + "', segundoApellido='" + txtSegApellido.Text + "', edad='" + txtEdad.Text + "', codigoClase='" + cmbCodigoClase.Text + "'"
                    If (conexion.modificar("personas.estudiante", modificar, " codigo=" + txtCodigo.Text)) Then
                        MessageBox.Show("Actualizado")
                        mostrarDatos()
                        Limpiar()
                        conexion.conexion.Close()
                    Else
                        MessageBox.Show("Error al actualizar")
                    End If
                End If

            Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = dtgRegistros.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            txtNombre.Text = dtg.Cells(1).Value.ToString()
            txtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
            txtSegApellido.Text = dtg.Cells(3).Value.ToString()
            txtEdad.Text = dtg.Cells(4).Value.ToString()
            cmbSexo.Text = dtg.Cells(5).Value.ToString()
            cmbCodigoClase.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub mostrarBusqueda()

        Try

            dt = conexion.buscarEstudiante("codigo like '%" + txtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt 'Rellena el datagrid
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing 'No retorna nada, deja vació el datagrid ya que no existe un codigo
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un nombre")
        End If
    End Sub
    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese nombre completo")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un codigo")
        End If
    End Sub
    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo.MouseHover
        ToolTip1.SetToolTip(txtCodigo, "Ingrese codigo ejemplo: 1807197300145")
        ToolTip1.ToolTipTitle = "Codigo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimerApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Primer Apellido")
        End If
    End Sub
    Private Sub txtPrimerApellido_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerApellido.MouseHover
        ToolTip1.SetToolTip(txtPrimerApellido, "Ingrese Primer Apellido")
        ToolTip1.ToolTipTitle = "Primer Apellido"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtSegApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Segundo Apellido")
        End If
    End Sub
    Private Sub txtSegApellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegApellido.MouseHover
        ToolTip1.SetToolTip(txtSegApellido, "Ingrese Primer Apellido")
        ToolTip1.ToolTipTitle = "Primer Apellido"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese la edad")
        End If
    End Sub
    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingrese la edad")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese Sexo")
        End If
    End Sub
    Private Sub cmbSexo_MouseHover(sender As Object, e As EventArgs) Handles cmbSexo.MouseHover
        ToolTip1.SetToolTip(cmbSexo, "Defina el sexo ")
        ToolTip1.ToolTipTitle = "Sexo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub cmbCodigoClase_Validating(sender As Object, e As CancelEventArgs) Handles cmbCodigoClase.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese codigo de clase")
        End If
    End Sub
    Private Sub cmbCodigoClase_MouseHover(sender As Object, e As EventArgs) Handles cmbCodigoClase.MouseHover
        ToolTip1.SetToolTip(cmbCodigoClase, "Defina el codigo de clase ")
        ToolTip1.ToolTipTitle = "Codigo Clave"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class

