Imports System
Imports System.IO.Ports

Public Class Form1
    Dim theBitmap As Bitmap = New Bitmap(84, 48)
    Dim PenColor As Color


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Serial_Write(New Bitmap("84x48.bmp"))
        'Serial_Write(Format(Now(), "HHmm"))
        Dim theString = "test"
        Dim theFont As Font = New Font("Courier", "24", FontStyle.Bold, GraphicsUnit.Pixel)
        Dim theGraphics As Graphics = Graphics.FromImage(theBitmap)
        theGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        theGraphics.FillRectangle(Brushes.White, 0, 0, theBitmap.Width, theBitmap.Height)
        'theGraphics.DrawString(theString, theFont, Brushes.Black, ((theBitmap.Width - theGraphics.MeasureString(theString, theFont).Width) / 2), ((theBitmap.Height - theGraphics.MeasureString(theString, theFont).Height) / 2))
        PenColor = Color.Black

        ' Init Serial Port
        cbPort.Items.Add("--")

        For Each port In SerialPort.GetPortNames()
            cbPort.Items.Add(port)
        Next port

        cbBaudrate.Items.Add("9600")
        cbBaudrate.Items.Add("19200")
        cbBaudrate.Items.Add("38400")
        cbBaudrate.Items.Add("57600")
        cbBaudrate.Items.Add("115200")

        cbPort.SelectedIndex = 0
        cbBaudrate.SelectedIndex = 0
    End Sub




    Private Sub Serial_Write(ByVal theString As String)

        Dim theFont As Font = New Font("Courier", "24", FontStyle.Bold, GraphicsUnit.Pixel)
        Dim theGraphics As Graphics = Graphics.FromImage(theBitmap)
        theGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        theGraphics.FillRectangle(Brushes.White, 0, 0, theBitmap.Width, theBitmap.Height)
        'theGraphics.DrawString(theString, theFont, Brushes.Black, ((theBitmap.Width - theGraphics.MeasureString(theString, theFont).Width) / 2), ((theBitmap.Height - theGraphics.MeasureString(theString, theFont).Height) / 2))
        'Serial_Write(theBitmap)
    End Sub

    Private Sub Serial_Write()
        Dim theByteArray() As Byte = New Byte() {}
        For theWidth As Integer = 0 To 83
            For theHeight As Integer = 0 To 5
                ReDim Preserve theByteArray(theByteArray.GetUpperBound(0) + 1)
                For theBit As Integer = 0 To 7
                    If theBitmap.GetPixel(theWidth, (theHeight * 8) + theBit).R Then
                        theByteArray(theByteArray.GetUpperBound(0)) = theByteArray(theByteArray.GetUpperBound(0)) And Not (2 ^ theBit)
                    Else
                        theByteArray(theByteArray.GetUpperBound(0)) = theByteArray(theByteArray.GetUpperBound(0)) Or (2 ^ theBit)
                    End If
                Next
            Next
        Next

        Try
            SerialPort.Open()
            SerialPort.Write(theByteArray, 0, theByteArray.Length)
            SerialPort.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Image = theBitmap
        pbRealSize.Image = theBitmap
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mygraphics As Graphics = Graphics.FromImage(theBitmap)
            Dim pen As New Drawing.Pen(PenColor, 1)
            'mygraphics.DrawEllipse(pen, 0, 0, 100, 100)
            'mygraphics.DrawLine(pen, e.Location, New System.Drawing.Point(e.X + 1, e.Y + 1))
            mygraphics.DrawRectangle(pen, New Rectangle(New Point(e.X / 3, e.Y / 3), New Size(1, 1)))
            PictureBox1.Invalidate()
            pen.Dispose()
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mygraphics As Graphics = Graphics.FromImage(theBitmap)
            Dim pen As New Drawing.Pen(PenColor, 1)
            mygraphics.DrawRectangle(pen, New Rectangle(New Point(e.X / 3, e.Y / 3), New Size(1, 1)))
            PictureBox1.Invalidate()
            pen.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim theGraphics As Graphics = Graphics.FromImage(theBitmap)
        theGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        theGraphics.FillRectangle(Brushes.White, 0, 0, theBitmap.Width, theBitmap.Height)
    End Sub

    Private Sub btDraw_Click(sender As System.Object, e As System.EventArgs) Handles btDraw.Click

        If cbPort.SelectedItem.ToString() = "--" Then
            MessageBox.Show("Please select serial port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SerialPort.BaudRate = Convert.ToInt32(cbBaudrate.SelectedItem.ToString())
        SerialPort.PortName = cbPort.SelectedItem.ToString()
        Serial_Write()
    End Sub

    Private Sub rbEraser_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbEraser.CheckedChanged
        PenColor = Color.White
    End Sub

    Private Sub rbPen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPen.CheckedChanged
        PenColor = Color.Black
    End Sub

    Private Sub btSaveImage_Click(sender As System.Object, e As System.EventArgs) Handles btSaveImage.Click
        Dim Ds As New System.Windows.Forms.SaveFileDialog
        Ds.Filter = "Bitmap (*.bmp)|*.bmp"
        Ds.RestoreDirectory = True

        If Ds.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'MsgBox("Save Ok", , "Save File")
            'Ds.FileName
            theBitmap.Save(Ds.FileName)
        End If
    End Sub

    Private Sub btLoadImage_Click(sender As System.Object, e As System.EventArgs) Handles btLoadImage.Click
        Dim Ds As New System.Windows.Forms.OpenFileDialog
        Ds.Filter = "Bitmap (*.bmp)|*.bmp"
        'Ds.RestoreDirectory = True

        If Ds.ShowDialog() = Windows.Forms.DialogResult.OK Then
            theBitmap = Image.FromFile(Ds.FileName)
        End If
    End Sub

    Private Sub btGenerateCode_Click(sender As System.Object, e As System.EventArgs) Handles btGenerateCode.Click
        Dim theByteArray() As Byte = New Byte() {}
        For theWidth As Integer = 0 To 83
            For theHeight As Integer = 0 To 5
                ReDim Preserve theByteArray(theByteArray.GetUpperBound(0) + 1)
                For theBit As Integer = 0 To 7
                    If theBitmap.GetPixel(theWidth, (theHeight * 8) + theBit).R Then
                        theByteArray(theByteArray.GetUpperBound(0)) = theByteArray(theByteArray.GetUpperBound(0)) And Not (2 ^ theBit)
                    Else
                        theByteArray(theByteArray.GetUpperBound(0)) = theByteArray(theByteArray.GetUpperBound(0)) Or (2 ^ theBit)
                    End If
                Next
            Next
        Next

        tbCode.Clear()
        tbCode.AppendText("byte img[] = {" & vbNewLine)
        Dim index As Integer = 0
        For Each tmpByte As Byte In theByteArray
            tbCode.AppendText("0x" & tmpByte.ToString("X2"))

            If Not index = theByteArray.Length - 1 Then
                tbCode.AppendText(",")
            End If


            index = index + 1

            If Not index = 0 Then
                If index Mod 5 = 0 Then
                    tbCode.AppendText(vbNewLine)
                End If
            End If

        Next
        tbCode.AppendText(vbNewLine & "}")
        My.Computer.Clipboard.SetText(tbCode.Text)
    End Sub
End Class
