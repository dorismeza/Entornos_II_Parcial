﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTareas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTareas))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.btnFunciones = New System.Windows.Forms.Button()
        Me.BtnArreglos = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBolsa = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 434)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(685, 33)
        Me.Panel4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UNICAH | Doris Torres "
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.ForeColor = System.Drawing.Color.Maroon
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(685, 40)
        Me.PanelSuperior.TabIndex = 5
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DimGray
        Me.PanelMenu.Controls.Add(Me.btnBolsa)
        Me.PanelMenu.Controls.Add(Me.btnFunciones)
        Me.PanelMenu.Controls.Add(Me.BtnArreglos)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(137, 394)
        Me.PanelMenu.TabIndex = 9
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.White
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(137, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(548, 394)
        Me.PanelForm.TabIndex = 10
        '
        'btnFunciones
        '
        Me.btnFunciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFunciones.BackColor = System.Drawing.Color.DimGray
        Me.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFunciones.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFunciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFunciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFunciones.Image = CType(resources.GetObject("btnFunciones.Image"), System.Drawing.Image)
        Me.btnFunciones.Location = New System.Drawing.Point(38, 127)
        Me.btnFunciones.Name = "btnFunciones"
        Me.btnFunciones.Size = New System.Drawing.Size(100, 40)
        Me.btnFunciones.TabIndex = 10
        Me.btnFunciones.Text = "Funciones"
        Me.btnFunciones.UseVisualStyleBackColor = False
        '
        'BtnArreglos
        '
        Me.BtnArreglos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnArreglos.BackColor = System.Drawing.Color.DimGray
        Me.BtnArreglos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnArreglos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnArreglos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.BtnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArreglos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArreglos.Image = CType(resources.GetObject("BtnArreglos.Image"), System.Drawing.Image)
        Me.BtnArreglos.Location = New System.Drawing.Point(38, 79)
        Me.BtnArreglos.Name = "BtnArreglos"
        Me.BtnArreglos.Size = New System.Drawing.Size(100, 40)
        Me.BtnArreglos.TabIndex = 9
        Me.BtnArreglos.Text = "Arreglos"
        Me.BtnArreglos.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Menu_tarea.My.Resources.Resources.software
        Me.btnMaximizar.Location = New System.Drawing.Point(604, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(44, 39)
        Me.btnMaximizar.TabIndex = 7
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Menu_tarea.My.Resources.Resources.geometria
        Me.btnRestaurar.Location = New System.Drawing.Point(604, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(44, 40)
        Me.btnRestaurar.TabIndex = 8
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(563, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(44, 39)
        Me.btnMinimizar.TabIndex = 7
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(644, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(44, 39)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnBolsa
        '
        Me.btnBolsa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBolsa.BackColor = System.Drawing.Color.DimGray
        Me.btnBolsa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBolsa.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBolsa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBolsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBolsa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolsa.Image = CType(resources.GetObject("btnBolsa.Image"), System.Drawing.Image)
        Me.btnBolsa.Location = New System.Drawing.Point(39, 175)
        Me.btnBolsa.Name = "btnBolsa"
        Me.btnBolsa.Size = New System.Drawing.Size(100, 44)
        Me.btnBolsa.TabIndex = 11
        Me.btnBolsa.Text = "Bolsa Solidaria"
        Me.btnBolsa.UseVisualStyleBackColor = False
        '
        'FormTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 467)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTareas"
        Me.Text = "FormTareas"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnArreglos As Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents btnFunciones As Button
    Friend WithEvents btnBolsa As Button
End Class
