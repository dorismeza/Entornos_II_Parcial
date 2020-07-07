<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibretaAhorro
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.listRetiros = New System.Windows.Forms.ListBox()
        Me.listDepositos = New System.Windows.Forms.ListBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(223, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Informacion"
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(277, 24)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(85, 58)
        Me.btnAperturar.TabIndex = 2
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(106, 60)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(102, 20)
        Me.txtMonto.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(108, 24)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 87)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(222, 29)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(81, 42)
        Me.btnRetirar.TabIndex = 4
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(79, 29)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(80, 42)
        Me.btnDepositar.TabIndex = 3
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(223, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 176)
        Me.GroupBox3.TabIndex = 1
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmLibretaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 574)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibretaAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLibretaAhorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents listRetiros As ListBox
    Friend WithEvents listDepositos As ListBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
