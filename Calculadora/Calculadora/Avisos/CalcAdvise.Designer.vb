<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcAdvise
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
        Me.lblsyntax = New System.Windows.Forms.Label()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblsyntax
        '
        Me.lblsyntax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblsyntax.AutoSize = True
        Me.lblsyntax.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsyntax.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsyntax.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblsyntax.Location = New System.Drawing.Point(95, 74)
        Me.lblsyntax.Name = "lblsyntax"
        Me.lblsyntax.Size = New System.Drawing.Size(155, 32)
        Me.lblsyntax.TabIndex = 0
        Me.lblsyntax.Text = "Syntax Error"
        '
        'btnaceptar
        '
        Me.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnaceptar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnaceptar.FlatAppearance.BorderSize = 0
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Image = Global.Calculadora.My.Resources.Resources.check
        Me.btnaceptar.Location = New System.Drawing.Point(-28, 133)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(378, 47)
        Me.btnaceptar.TabIndex = 1
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'CalcAdvise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(349, 227)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lblsyntax)
        Me.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "CalcAdvise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalcAdvise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblsyntax As Label
    Friend WithEvents btnaceptar As Button
End Class
