<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantencion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 108)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Eliminar registros de BBDD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 108)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Resetear campo ID"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 108)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 108)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(502, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(350, 147)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(201, 108)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = "Haciendo click en el boton 1 ud. borrara la totalidad de los registro de la base " & _
            "de datos, asegurese de realizar copias de seguridad de los datos " & Global.Microsoft.VisualBasic.ChrW(10) & "Estos no podra" & _
            "n ser recuperados !!!"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RichTextBox2.Enabled = False
        Me.RichTextBox2.Location = New System.Drawing.Point(350, 308)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(201, 108)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = "Antes de hacer click en el boton 2 debe asegurarse de haber borrado todos los reg" & _
            "istros de la base de datos,}" & Global.Microsoft.VisualBasic.ChrW(10) & "esta accion reseteara el campo ID de los registros." & _
            "" & Global.Microsoft.VisualBasic.ChrW(10) & "Esta accion no puede deshacerse!!!!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(335, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mantenedor de Base de datos "
        '
        'Mantencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(616, 509)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Mantencion"
        Me.Text = "Mantencion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
