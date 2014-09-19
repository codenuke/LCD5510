<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btGenerateCode = New System.Windows.Forms.Button()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.btDraw = New System.Windows.Forms.Button()
        Me.rbPen = New System.Windows.Forms.RadioButton()
        Me.rbEraser = New System.Windows.Forms.RadioButton()
        Me.btSaveImage = New System.Windows.Forms.Button()
        Me.btLoadImage = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBaudrate = New System.Windows.Forms.ComboBox()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.pbRealSize = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbRealSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btGenerateCode
        '
        Me.btGenerateCode.Location = New System.Drawing.Point(270, 124)
        Me.btGenerateCode.Name = "btGenerateCode"
        Me.btGenerateCode.Size = New System.Drawing.Size(157, 32)
        Me.btGenerateCode.TabIndex = 2
        Me.btGenerateCode.Text = "Generate Code"
        Me.btGenerateCode.UseVisualStyleBackColor = True
        '
        'tbCode
        '
        Me.tbCode.Location = New System.Drawing.Point(14, 162)
        Me.tbCode.Multiline = True
        Me.tbCode.Name = "tbCode"
        Me.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCode.Size = New System.Drawing.Size(250, 241)
        Me.tbCode.TabIndex = 3
        '
        'btDraw
        '
        Me.btDraw.Location = New System.Drawing.Point(58, 79)
        Me.btDraw.Name = "btDraw"
        Me.btDraw.Size = New System.Drawing.Size(83, 23)
        Me.btDraw.TabIndex = 4
        Me.btDraw.Text = "Serial Send"
        Me.btDraw.UseVisualStyleBackColor = True
        '
        'rbPen
        '
        Me.rbPen.AutoSize = True
        Me.rbPen.Checked = True
        Me.rbPen.Location = New System.Drawing.Point(19, 24)
        Me.rbPen.Name = "rbPen"
        Me.rbPen.Size = New System.Drawing.Size(44, 17)
        Me.rbPen.TabIndex = 5
        Me.rbPen.TabStop = True
        Me.rbPen.Text = "Pen"
        Me.rbPen.UseVisualStyleBackColor = True
        '
        'rbEraser
        '
        Me.rbEraser.AutoSize = True
        Me.rbEraser.Location = New System.Drawing.Point(19, 47)
        Me.rbEraser.Name = "rbEraser"
        Me.rbEraser.Size = New System.Drawing.Size(55, 17)
        Me.rbEraser.TabIndex = 6
        Me.rbEraser.Text = "Eraser"
        Me.rbEraser.UseVisualStyleBackColor = True
        '
        'btSaveImage
        '
        Me.btSaveImage.Location = New System.Drawing.Point(94, 16)
        Me.btSaveImage.Name = "btSaveImage"
        Me.btSaveImage.Size = New System.Drawing.Size(57, 23)
        Me.btSaveImage.TabIndex = 7
        Me.btSaveImage.Text = "Save"
        Me.btSaveImage.UseVisualStyleBackColor = True
        '
        'btLoadImage
        '
        Me.btLoadImage.Location = New System.Drawing.Point(94, 45)
        Me.btLoadImage.Name = "btLoadImage"
        Me.btLoadImage.Size = New System.Drawing.Size(57, 23)
        Me.btLoadImage.TabIndex = 8
        Me.btLoadImage.Text = "Load"
        Me.btLoadImage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPen)
        Me.GroupBox1.Controls.Add(Me.btLoadImage)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btSaveImage)
        Me.GroupBox1.Controls.Add(Me.rbEraser)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 105)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bitmap"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPort)
        Me.GroupBox2.Controls.Add(Me.cbBaudrate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btDraw)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 115)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Serial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baudrate"
        '
        'cbBaudrate
        '
        Me.cbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBaudrate.FormattingEnabled = True
        Me.cbBaudrate.Location = New System.Drawing.Point(58, 49)
        Me.cbBaudrate.Name = "cbBaudrate"
        Me.cbBaudrate.Size = New System.Drawing.Size(83, 21)
        Me.cbBaudrate.TabIndex = 5
        '
        'cbPort
        '
        Me.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(58, 21)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(83, 21)
        Me.cbPort.TabIndex = 11
        '
        'pbRealSize
        '
        Me.pbRealSize.Location = New System.Drawing.Point(309, 317)
        Me.pbRealSize.Name = "pbRealSize"
        Me.pbRealSize.Size = New System.Drawing.Size(84, 48)
        Me.pbRealSize.TabIndex = 11
        Me.pbRealSize.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 414)
        Me.Controls.Add(Me.pbRealSize)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.btGenerateCode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "LCD 5510"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbRealSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btGenerateCode As System.Windows.Forms.Button
    Friend WithEvents tbCode As System.Windows.Forms.TextBox
    Friend WithEvents btDraw As System.Windows.Forms.Button
    Friend WithEvents rbPen As System.Windows.Forms.RadioButton
    Friend WithEvents rbEraser As System.Windows.Forms.RadioButton
    Friend WithEvents btSaveImage As System.Windows.Forms.Button
    Friend WithEvents btLoadImage As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPort As System.Windows.Forms.ComboBox
    Friend WithEvents pbRealSize As System.Windows.Forms.PictureBox

End Class
