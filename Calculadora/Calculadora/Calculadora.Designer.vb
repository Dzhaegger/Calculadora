<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
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
        Me.pnlbarra = New System.Windows.Forms.Panel()
        Me.txtpantalla = New System.Windows.Forms.TextBox()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.lbltextbarra = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnwipe = New System.Windows.Forms.Button()
        Me.btnelevar = New System.Windows.Forms.Button()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.btnmultiplicar = New System.Windows.Forms.Button()
        Me.btnrestar = New System.Windows.Forms.Button()
        Me.btnsumar = New System.Windows.Forms.Button()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.btndecimal = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.pnlbarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlbarra
        '
        Me.pnlbarra.BackColor = System.Drawing.Color.Gray
        Me.pnlbarra.Controls.Add(Me.lbltextbarra)
        Me.pnlbarra.Controls.Add(Me.btncerrar)
        Me.pnlbarra.Controls.Add(Me.btnminimizar)
        Me.pnlbarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlbarra.Location = New System.Drawing.Point(0, 0)
        Me.pnlbarra.Name = "pnlbarra"
        Me.pnlbarra.Size = New System.Drawing.Size(742, 53)
        Me.pnlbarra.TabIndex = 0
        '
        'txtpantalla
        '
        Me.txtpantalla.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpantalla.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpantalla.Location = New System.Drawing.Point(87, 87)
        Me.txtpantalla.Multiline = True
        Me.txtpantalla.Name = "txtpantalla"
        Me.txtpantalla.Size = New System.Drawing.Size(569, 57)
        Me.txtpantalla.TabIndex = 1
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn7.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(186, 265)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(83, 76)
        Me.btn7.TabIndex = 2
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn8.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(282, 265)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(83, 76)
        Me.btn8.TabIndex = 3
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn9.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(377, 265)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(83, 76)
        Me.btn9.TabIndex = 4
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn4.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(186, 358)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(83, 76)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn5.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(282, 358)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(83, 76)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn6.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(377, 358)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(83, 76)
        Me.btn6.TabIndex = 7
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn1.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(186, 452)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(83, 76)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn2.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(282, 452)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(83, 76)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn3.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(377, 452)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(83, 76)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn0.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(186, 541)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(179, 76)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'lbltextbarra
        '
        Me.lbltextbarra.AutoSize = True
        Me.lbltextbarra.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltextbarra.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbltextbarra.Location = New System.Drawing.Point(16, 8)
        Me.lbltextbarra.Name = "lbltextbarra"
        Me.lbltextbarra.Size = New System.Drawing.Size(169, 37)
        Me.lbltextbarra.TabIndex = 21
        Me.lbltextbarra.Text = "Calculadora"
        '
        'btndelete
        '
        Me.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btndelete.Image = Global.Calculadora.My.Resources.Resources.delete32
        Me.btndelete.Location = New System.Drawing.Point(186, 177)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(83, 76)
        Me.btndelete.TabIndex = 20
        Me.btndelete.Text = "C--"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnwipe
        '
        Me.btnwipe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnwipe.Image = Global.Calculadora.My.Resources.Resources.THIN_C_32px
        Me.btnwipe.Location = New System.Drawing.Point(282, 177)
        Me.btnwipe.Name = "btnwipe"
        Me.btnwipe.Size = New System.Drawing.Size(83, 76)
        Me.btnwipe.TabIndex = 19
        Me.btnwipe.UseVisualStyleBackColor = True
        '
        'btnelevar
        '
        Me.btnelevar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnelevar.Image = Global.Calculadora.My.Resources.Resources.EXPO
        Me.btnelevar.Location = New System.Drawing.Point(377, 177)
        Me.btnelevar.Name = "btnelevar"
        Me.btnelevar.Size = New System.Drawing.Size(83, 76)
        Me.btnelevar.TabIndex = 18
        Me.btnelevar.UseVisualStyleBackColor = True
        '
        'btndividir
        '
        Me.btndividir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btndividir.Image = Global.Calculadora.My.Resources.Resources.DIV
        Me.btndividir.Location = New System.Drawing.Point(477, 177)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(83, 76)
        Me.btndividir.TabIndex = 17
        Me.btndividir.UseVisualStyleBackColor = True
        '
        'btnmultiplicar
        '
        Me.btnmultiplicar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnmultiplicar.Image = Global.Calculadora.My.Resources.Resources.CROSS_1
        Me.btnmultiplicar.Location = New System.Drawing.Point(477, 265)
        Me.btnmultiplicar.Name = "btnmultiplicar"
        Me.btnmultiplicar.Size = New System.Drawing.Size(83, 76)
        Me.btnmultiplicar.TabIndex = 16
        Me.btnmultiplicar.UseVisualStyleBackColor = True
        '
        'btnrestar
        '
        Me.btnrestar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnrestar.Image = Global.Calculadora.My.Resources.Resources._211863_minus_round_icon
        Me.btnrestar.Location = New System.Drawing.Point(477, 358)
        Me.btnrestar.Name = "btnrestar"
        Me.btnrestar.Size = New System.Drawing.Size(83, 76)
        Me.btnrestar.TabIndex = 15
        Me.btnrestar.UseVisualStyleBackColor = True
        '
        'btnsumar
        '
        Me.btnsumar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnsumar.Image = Global.Calculadora.My.Resources.Resources.PLUS
        Me.btnsumar.Location = New System.Drawing.Point(477, 452)
        Me.btnsumar.Name = "btnsumar"
        Me.btnsumar.Size = New System.Drawing.Size(83, 76)
        Me.btnsumar.TabIndex = 14
        Me.btnsumar.UseVisualStyleBackColor = True
        '
        'btnequal
        '
        Me.btnequal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnequal.Image = Global.Calculadora.My.Resources.Resources.EQUAL
        Me.btnequal.Location = New System.Drawing.Point(477, 541)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(83, 76)
        Me.btnequal.TabIndex = 13
        Me.btnequal.UseVisualStyleBackColor = True
        '
        'btndecimal
        '
        Me.btndecimal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btndecimal.Image = Global.Calculadora.My.Resources.Resources.comma
        Me.btndecimal.Location = New System.Drawing.Point(377, 541)
        Me.btndecimal.Name = "btndecimal"
        Me.btndecimal.Size = New System.Drawing.Size(83, 76)
        Me.btndecimal.TabIndex = 12
        Me.btndecimal.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = Global.Calculadora.My.Resources.Resources.Icono_cerrar_FN
        Me.btncerrar.Location = New System.Drawing.Point(682, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(60, 53)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = Global.Calculadora.My.Resources.Resources.Icono_Minimizar
        Me.btnminimizar.Location = New System.Drawing.Point(621, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(60, 53)
        Me.btnminimizar.TabIndex = 1
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(742, 697)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnwipe)
        Me.Controls.Add(Me.btnelevar)
        Me.Controls.Add(Me.btndividir)
        Me.Controls.Add(Me.btnmultiplicar)
        Me.Controls.Add(Me.btnrestar)
        Me.Controls.Add(Me.btnsumar)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.btndecimal)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.txtpantalla)
        Me.Controls.Add(Me.pnlbarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.pnlbarra.ResumeLayout(False)
        Me.pnlbarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlbarra As Panel
    Friend WithEvents btnminimizar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents txtpantalla As TextBox
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btndecimal As Button
    Friend WithEvents btnequal As Button
    Friend WithEvents btnsumar As Button
    Friend WithEvents btnrestar As Button
    Friend WithEvents btnmultiplicar As Button
    Friend WithEvents btndividir As Button
    Friend WithEvents btnelevar As Button
    Friend WithEvents btnwipe As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents lbltextbarra As Label
End Class
