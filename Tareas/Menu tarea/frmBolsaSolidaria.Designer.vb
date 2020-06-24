<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBolsaSolidaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.btnNueo = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.grpDatosFam = New System.Windows.Forms.GroupBox()
        Me.txtIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.lbRegular = New System.Windows.Forms.Label()
        Me.lbBasica = New System.Windows.Forms.Label()
        Me.lstContenido = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lstReporte = New System.Windows.Forms.ListBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpDatosFam.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.btnNueo)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnValidar)
        Me.GroupBox1.Controls.Add(Me.grpDatosFam)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlantida", "Colon", "Comayagua", "Copan", "Cortes", "Choluteca", "El Paraiso", "Francisco Morazan", "Gracias a Dios", "Intibuca", "Islas de la Bahia ", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Barbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(94, 90)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(144, 21)
        Me.cmbDepartamento.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Departamento"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(85, 58)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(153, 20)
        Me.txtIdentidad.TabIndex = 15
        '
        'btnNueo
        '
        Me.btnNueo.Location = New System.Drawing.Point(45, 231)
        Me.btnNueo.Name = "btnNueo"
        Me.btnNueo.Size = New System.Drawing.Size(75, 30)
        Me.btnNueo.TabIndex = 14
        Me.btnNueo.Text = "Nuevo"
        Me.btnNueo.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(85, 161)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(153, 49)
        Me.txtDireccion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Dirección"
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(175, 231)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 30)
        Me.btnValidar.TabIndex = 11
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'grpDatosFam
        '
        Me.grpDatosFam.Controls.Add(Me.txtIntegrantes)
        Me.grpDatosFam.Controls.Add(Me.btnEntregar)
        Me.grpDatosFam.Controls.Add(Me.lbRegular)
        Me.grpDatosFam.Controls.Add(Me.lbBasica)
        Me.grpDatosFam.Controls.Add(Me.lstContenido)
        Me.grpDatosFam.Controls.Add(Me.Label6)
        Me.grpDatosFam.Controls.Add(Me.cmbEstado)
        Me.grpDatosFam.Controls.Add(Me.Label5)
        Me.grpDatosFam.Controls.Add(Me.Label4)
        Me.grpDatosFam.Enabled = False
        Me.grpDatosFam.Location = New System.Drawing.Point(275, 8)
        Me.grpDatosFam.Name = "grpDatosFam"
        Me.grpDatosFam.Size = New System.Drawing.Size(310, 214)
        Me.grpDatosFam.TabIndex = 6
        Me.grpDatosFam.TabStop = False
        Me.grpDatosFam.Text = "Datos Familia"
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Location = New System.Drawing.Point(89, 33)
        Me.txtIntegrantes.Mask = "99"
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(63, 20)
        Me.txtIntegrantes.TabIndex = 14
        Me.txtIntegrantes.ValidatingType = GetType(Integer)
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(241, 45)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(57, 53)
        Me.btnEntregar.TabIndex = 10
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'lbRegular
        '
        Me.lbRegular.AutoSize = True
        Me.lbRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegular.Location = New System.Drawing.Point(94, 107)
        Me.lbRegular.Name = "lbRegular"
        Me.lbRegular.Size = New System.Drawing.Size(58, 15)
        Me.lbRegular.TabIndex = 12
        Me.lbRegular.Text = "Regular"
        Me.lbRegular.Visible = False
        '
        'lbBasica
        '
        Me.lbBasica.AutoSize = True
        Me.lbBasica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBasica.Location = New System.Drawing.Point(94, 105)
        Me.lbBasica.Name = "lbBasica"
        Me.lbBasica.Size = New System.Drawing.Size(50, 15)
        Me.lbBasica.TabIndex = 11
        Me.lbBasica.Text = "Básica"
        Me.lbBasica.Visible = False
        '
        'lstContenido
        '
        Me.lstContenido.FormattingEnabled = True
        Me.lstContenido.Location = New System.Drawing.Point(15, 133)
        Me.lstContenido.Name = "lstContenido"
        Me.lstContenido.Size = New System.Drawing.Size(256, 69)
        Me.lstContenido.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo de Bolsa: "
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pobreza moderada", "Pobreza relativa", "Pobreza extrema"})
        Me.cmbEstado.Location = New System.Drawing.Point(92, 65)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(123, 21)
        Me.cmbEstado.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Integrantes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(85, 126)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(153, 20)
        Me.txtMunicipio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. Identidad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.lstReporte)
        Me.GroupBox2.Location = New System.Drawing.Point(157, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Bolsas Entregadas"
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(352, 78)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(78, 20)
        Me.txtTotal.TabIndex = 8
        '
        'lstReporte
        '
        Me.lstReporte.FormattingEnabled = True
        Me.lstReporte.Location = New System.Drawing.Point(8, 19)
        Me.lstReporte.Name = "lstReporte"
        Me.lstReporte.Size = New System.Drawing.Size(323, 147)
        Me.lstReporte.TabIndex = 0
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmBolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 654)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBolsaSolidaria"
        Me.Text = "frmBolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDatosFam.ResumeLayout(False)
        Me.grpDatosFam.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnValidar As Button
    Friend WithEvents grpDatosFam As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents lbRegular As Label
    Friend WithEvents lbBasica As Label
    Friend WithEvents lstContenido As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstReporte As ListBox
    Friend WithEvents btnNueo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIntegrantes As MaskedTextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label9 As Label
End Class
