<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.letter1 = New System.Windows.Forms.Label()
        Me.letter2 = New System.Windows.Forms.Label()
        Me.letter3 = New System.Windows.Forms.Label()
        Me.letter4 = New System.Windows.Forms.Label()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.combo = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'letter1
        '
        Me.letter1.AutoSize = True
        Me.letter1.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter1.Location = New System.Drawing.Point(338, 125)
        Me.letter1.Name = "letter1"
        Me.letter1.Size = New System.Drawing.Size(108, 43)
        Me.letter1.TabIndex = 0
        Me.letter1.Text = "Label1"
        '
        'letter2
        '
        Me.letter2.AutoSize = True
        Me.letter2.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter2.Location = New System.Drawing.Point(208, 73)
        Me.letter2.Name = "letter2"
        Me.letter2.Size = New System.Drawing.Size(113, 43)
        Me.letter2.TabIndex = 1
        Me.letter2.Text = "Label2"
        '
        'letter3
        '
        Me.letter3.AutoSize = True
        Me.letter3.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter3.Location = New System.Drawing.Point(338, 73)
        Me.letter3.Name = "letter3"
        Me.letter3.Size = New System.Drawing.Size(114, 43)
        Me.letter3.TabIndex = 2
        Me.letter3.Text = "Label3"
        '
        'letter4
        '
        Me.letter4.AutoSize = True
        Me.letter4.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letter4.Location = New System.Drawing.Point(208, 125)
        Me.letter4.Name = "letter4"
        Me.letter4.Size = New System.Drawing.Size(112, 43)
        Me.letter4.TabIndex = 3
        Me.letter4.Text = "Label4"
        '
        'clock
        '
        '
        'combo
        '
        Me.combo.Interval = 800
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(216, 201)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(230, 46)
        Me.input.TabIndex = 5
        Me.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.letter4)
        Me.Controls.Add(Me.letter3)
        Me.Controls.Add(Me.letter2)
        Me.Controls.Add(Me.letter1)
        Me.Name = "game"
        Me.Text = "Play Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents letter1 As Label
    Friend WithEvents letter2 As Label
    Friend WithEvents letter3 As Label
    Friend WithEvents letter4 As Label
    Friend WithEvents clock As Timer
    Friend WithEvents combo As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents input As TextBox
End Class
