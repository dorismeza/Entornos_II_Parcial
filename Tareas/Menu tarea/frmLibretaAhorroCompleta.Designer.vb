<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibretaAhorroCompleta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.listRetiros = New System.Windows.Forms.ListBox()
        Me.listDepositos = New System.Windows.Forms.ListBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOperaciones = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdOperaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3.SuspendLayout()
        Me.grpOperaciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtSaldoTotal)
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.listRetiros)
        Me.GroupBox3.Controls.Add(Me.listDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(126, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(511, 176)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Retiros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Depositos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Saldo Total"
        '
        'txtSaldoTotal
        '
        Me.txtSaldoTotal.Location = New System.Drawing.Point(290, 77)
        Me.txtSaldoTotal.Name = "txtSaldoTotal"
        Me.txtSaldoTotal.Size = New System.Drawing.Size(106, 20)
        Me.txtSaldoTotal.TabIndex = 8
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(300, 117)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'listRetiros
        '
        Me.listRetiros.FormattingEnabled = True
        Me.listRetiros.Location = New System.Drawing.Point(155, 44)
        Me.listRetiros.Name = "listRetiros"
        Me.listRetiros.Size = New System.Drawing.Size(120, 121)
        Me.listRetiros.TabIndex = 6
        '
        'listDepositos
        '
        Me.listDepositos.FormattingEnabled = True
        Me.listDepositos.Location = New System.Drawing.Point(9, 44)
        Me.listDepositos.Name = "listDepositos"
        Me.listDepositos.Size = New System.Drawing.Size(120, 121)
        Me.listDepositos.TabIndex = 5
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(366, 29)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(81, 42)
        Me.btnRetirar.TabIndex = 4
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(246, 29)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(80, 42)
        Me.btnDepositar.TabIndex = 3
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(436, 19)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(69, 63)
        Me.btnAperturar.TabIndex = 2
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(63, 24)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentidad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'grpOperaciones
        '
        Me.grpOperaciones.Controls.Add(Me.txtIdOperaciones)
        Me.grpOperaciones.Controls.Add(Me.Label6)
        Me.grpOperaciones.Controls.Add(Me.btnRetirar)
        Me.grpOperaciones.Controls.Add(Me.btnDepositar)
        Me.grpOperaciones.Location = New System.Drawing.Point(126, 155)
        Me.grpOperaciones.Name = "grpOperaciones"
        Me.grpOperaciones.Size = New System.Drawing.Size(511, 87)
        Me.grpOperaciones.TabIndex = 2
        Me.grpOperaciones.TabStop = False
        Me.grpOperaciones.Text = "Operaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 143)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Informacion"
        '
        'txtIdOperaciones
        '
        Me.txtIdOperaciones.Location = New System.Drawing.Point(72, 41)
        Me.txtIdOperaciones.Name = "txtIdOperaciones"
        Me.txtIdOperaciones.Size = New System.Drawing.Size(100, 20)
        Me.txtIdOperaciones.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Identidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Edad"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(246, 27)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(102, 20)
        Me.txtPais.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Pais"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(182, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Saldo de Apertura"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(280, 79)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(102, 20)
        Me.txtSaldo.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Ciudad"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(246, 53)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(102, 20)
        Me.txtCiudad.TabIndex = 11
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(63, 80)
        Me.txtEdad.Mask = "999"
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(47, 20)
        Me.txtEdad.TabIndex = 12
        Me.txtEdad.ValidatingType = GetType(Integer)
        '
        'frmLibretaAhorroCompleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpOperaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLibretaAhorroCompleta"
        Me.Text = "frmLibretaAhorroCompleta"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpOperaciones.ResumeLayout(False)
        Me.grpOperaciones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents listRetiros As ListBox
    Friend WithEvents listDepositos As ListBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnAperturar As Button
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpOperaciones As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIdOperaciones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEdad As MaskedTextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
End Class
