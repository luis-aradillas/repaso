<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.suma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resta = New System.Windows.Forms.Button()
        Me.multiplicacion = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numero1
        '
        Me.numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(261, 42)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(211, 45)
        Me.numero1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primer número"
        '
        'suma
        '
        Me.suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suma.Location = New System.Drawing.Point(44, 162)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(201, 43)
        Me.suma.TabIndex = 2
        Me.suma.Text = "Sumar"
        Me.suma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Segundo número"
        '
        'numero2
        '
        Me.numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero2.Location = New System.Drawing.Point(261, 93)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(211, 45)
        Me.numero2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(587, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Acción"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resta.Location = New System.Drawing.Point(44, 211)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(201, 43)
        Me.resta.TabIndex = 7
        Me.resta.Text = "Restar"
        Me.resta.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplicacion.Location = New System.Drawing.Point(44, 260)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(201, 43)
        Me.multiplicacion.TabIndex = 8
        Me.multiplicacion.Text = "Multiplicación"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.division.Location = New System.Drawing.Point(44, 309)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(201, 43)
        Me.division.TabIndex = 9
        Me.division.Text = "División"
        Me.division.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numero1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numero1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents suma As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numero2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents resta As Button
    Friend WithEvents multiplicacion As Button
    Friend WithEvents division As Button
End Class
