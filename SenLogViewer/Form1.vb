Public Class Form1

    Private _objSENLOG As Sen3Log = Nothing
    Private Const VIEW_GYAP As Integer = 10

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' OpenFileDialog1.FileName = ""
        ' TxtLOGFILE.Text = ""
    End Sub

    Private Sub BtnLOGFILE_Click(sender As System.Object, e As System.EventArgs) Handles BtnLOGFILE.Click
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        'TxtLOGFILE.Text = OpenFileDialog1.FileName
        'End If
    End Sub

    Private Sub TxtLOGFILE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtLOGFILE.TextChanged
        If Not IsNothing(_objSENLOG) Then
            _objSENLOG.Close()
            _objSENLOG = Nothing
        End If
        Dim backCursor As Cursor = Me.Cursor
        PBoxWAVE.Visible = False
        HScrollBar1.Value = 0
        HScrollBar1.Minimum = 0
        HScrollBar1.Maximum = 0
        HScrollBar1.LargeChange = 1
        Lblサンプル位置.Text = ""
        LblP0.Text = "P0 :"
        LblP1.Text = "P1 :"
        LblW0.Text = "W0 :"
        LblW1.Text = "W1 :"
        NumericUpDown1.Value = HScrollBar1.Value
        NumericUpDown1.Maximum = HScrollBar1.Maximum
        Try
            If Not String.IsNullOrEmpty(TxtLOGFILE.Text) Then
                Me.Cursor = Cursors.WaitCursor
                Trace.WriteLine("■LOAD START = " & TxtLOGFILE.Text & " " & Now)
                _objSENLOG = New Sen3Log(TxtLOGFILE.Text)
                Trace.WriteLine("■LOAD END = " & TxtLOGFILE.Text & " " & Now)
            End If

            InitScrollProperty()
            HScrollBar1.Value = HScrollBar1.Minimum
            PBoxWAVE.Visible = True
            NumericUpDown1_ValueChanged(sender, e)
        Catch ex As Exception
            Trace.WriteLine("例外:" + ex.Message)
            MsgBox("ファイルを開けませんでした。[" & ex.Message & "]")
            If Not IsNothing(_objSENLOG) Then
                _objSENLOG.Close()
                _objSENLOG = Nothing
            End If
        Finally
            Me.Cursor = backCursor
        End Try
    End Sub

    Private Function GetTimeStringBySample(ByVal value) As String
        Dim tvalH As Integer = Math.Truncate(value / (30 * 60 * 60))
        Dim tvalM As Integer = Math.Truncate(value / (30 * 60)) Mod 60
        Dim tvalS As Integer = value Mod (30 * 60)
        Return String.Format("{0:#,##0}:{1:00}:{2:00.00}", tvalH, tvalM, tvalS / 30)
    End Function

    Private Sub PBoxWAVE_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PBoxWAVE.MouseUp
        If Not IsNothing(_objSENLOG) Then
            Dim dvs As Double = _objSENLOG.SampleCount / PBoxWAVE.ClientSize.Width
            Dim pos As Integer = e.X * dvs

            NumericUpDown1.Value = pos
        End If
    End Sub

    Private Sub PBoxVIEW_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PBoxVIEW.MouseUp
        If Not IsNothing(_objSENLOG) Then
            Dim pos As Integer = e.X + HScrollBar1.Value
            If pos >= NumericUpDown1.Minimum And pos <= NumericUpDown1.Maximum Then
                NumericUpDown1.Value = pos
            End If
        End If
    End Sub

    Private Sub PBoxVIEW_SizeChanged(sender As Object, e As System.EventArgs) Handles PBoxVIEW.SizeChanged
        If Not IsNothing(_objSENLOG) Then
            InitScrollProperty()
            PBoxWAVE.Invalidate()
            PBoxVIEW.Invalidate()
        End If
    End Sub

    Private Sub InitScrollProperty()
        NumericUpDown1.Maximum = _objSENLOG.SampleCount - 1
        HScrollBar1.Minimum = -VIEW_GYAP
        HScrollBar1.Maximum = NumericUpDown1.Maximum + VIEW_GYAP
        HScrollBar1.LargeChange = PBoxVIEW.ClientSize.Width
        'HScrollBar1.Value = HScrollBar1.Minimum
    End Sub

    Private Sub HScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim currPos As Integer = NumericUpDown1.Value + (e.NewValue - e.OldValue)
        If currPos >= e.NewValue And currPos <= e.NewValue + HScrollBar1.LargeChange Then NumericUpDown1.Value = currPos
        PBoxWAVE.Invalidate()
        PBoxVIEW.Invalidate()
    End Sub
    Private Sub HScrollBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles HScrollBar1.ValueChanged
        PBoxWAVE.Invalidate()
        PBoxVIEW.Invalidate()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If Not IsNothing(_objSENLOG) Then
            Lblサンプル位置.Text = String.Format("({0}) / {1:#,##0}({2})", GetTimeStringBySample(NumericUpDown1.Value), _objSENLOG.SampleCount, GetTimeStringBySample(_objSENLOG.SampleCount))
            LblP0.Text = "P0 : " & _objSENLOG.P0(NumericUpDown1.Value) - 128
            LblP1.Text = "P1 : " & _objSENLOG.P1(NumericUpDown1.Value) - 128
            LblW0.Text = "W0 : " & _objSENLOG.W0(NumericUpDown1.Value)
            LblW1.Text = "W1 : " & _objSENLOG.W1(NumericUpDown1.Value)
            If NumericUpDown1.Value < HScrollBar1.Value Then
                HScrollBar1.Value = _max(NumericUpDown1.Value - HScrollBar1.LargeChange / 2, HScrollBar1.Minimum)
            ElseIf NumericUpDown1.Value > (HScrollBar1.Value + HScrollBar1.LargeChange) Then
                HScrollBar1.Value = _min(NumericUpDown1.Value - HScrollBar1.LargeChange / 2, HScrollBar1.Maximum - HScrollBar1.LargeChange)
            Else
                PBoxWAVE.Invalidate()
                PBoxVIEW.Invalidate()
            End If

        End If
    End Sub

    Private Sub PBoxWAVE_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PBoxWAVE.Paint
        Dim wGyap As Integer = 3 + (PBoxWAVE.ClientSize.Height Mod 2)
        Dim wHeight As Integer = (PBoxWAVE.ClientSize.Height - wGyap) / 3

        Trace.WriteLine("■PBoxWAVE_Paint START  " & Now)
        'Trace.WriteLine("ClientSize = " & PBoxWAVE.ClientSize.Width & ", " & PBoxWAVE.ClientSize.Height)
        'Trace.WriteLine("Size       = " & PBoxWAVE.Width & ", " & PBoxWAVE.Height)

        e.Graphics.FillRectangle(Brushes.DimGray, e.ClipRectangle)
        If IsNothing(_objSENLOG) Then Exit Sub

        '枠
        Dim pt As New Point(_getWavePointX(HScrollBar1.Value), 0)
        Dim sz As New Size(_getWavePointX(_min(_objSENLOG.SampleCount, PBoxVIEW.ClientSize.Width)), PBoxWAVE.ClientSize.Height - 1)
        Trace.WriteLine("枠 pos=(" & pt.X & ", " & pt.Y & ") size=(" & sz.Width & ", " & sz.Height & ")")
        e.Graphics.FillRectangle(Brushes.Black, pt.X, pt.Y, sz.Width, sz.Height)
        e.Graphics.DrawRectangle(Pens.Azure, pt.X, pt.Y, sz.Width, sz.Height)

        'P0, P1, W0, W1
        Dim arrY(255) As Integer, x1 As Integer, x2 As Integer, nsk As Integer
        Dim offset1 As Integer = 0
        Dim offset2 As Integer = (wHeight + 1)
        Dim offset3 As Integer = offset2 * 2

        For y As Integer = 0 To 255
            arrY(y) = wHeight - (y * wHeight / 256)
        Next

#If 1 Then
        nsk = 1
        If _objSENLOG.SampleCount > 8192 Then nsk = Math.Truncate(_objSENLOG.SampleCount / 4096)

        x1 = _getWavePointX(0)
        For i As Integer = 0 To _objSENLOG.SampleCount - (nsk * 2) Step nsk
            x2 = _getWavePointX(i + nsk)
            e.Graphics.DrawLine(Pens.Yellow, x1, arrY(_objSENLOG.P0(i)) + offset1, x2, arrY(_objSENLOG.P0(i + nsk)) + offset1)
            e.Graphics.DrawLine(Pens.Yellow, x1, arrY(_objSENLOG.P1(i)) + offset2, x2, arrY(_objSENLOG.P1(i + nsk)) + offset2)
            e.Graphics.DrawLine(Pens.Aqua, x1, arrY(_objSENLOG.W0(i)) + offset3, x2, arrY(_objSENLOG.W0(i + nsk)) + offset3)
            e.Graphics.DrawLine(Pens.Magenta, x1, arrY(_objSENLOG.W1(i)) + offset3, x2, arrY(_objSENLOG.W1(i + nsk)) + offset3)
            x1 = x2
        Next
#End If

        '現行位置
        x1 = _getWavePointX(NumericUpDown1.Value)
        e.Graphics.DrawLine(Pens.Pink, x1, 0, x1, PBoxWAVE.ClientSize.Height - 1)
        Trace.WriteLine("■PBoxWAVE_Paint END  " & Now)

    End Sub

    Private Function _getWavePointX(ByVal x As Long) As Long
        _getWavePointX = (x * PBoxWAVE.ClientSize.Width) / _objSENLOG.SampleCount
        'Trace.WriteLine(x & " --> " & _getWavePointX & "  " & PBoxWAVE.ClientSize.Width & ":" & _objSENLOG.SampleCount)
    End Function

    Private Function _min(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Return If(val1 < val2, val1, val2)
    End Function
    Private Function _max(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Return If(val1 > val2, val1, val2)
    End Function

    Private Sub PBoxVIEW_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PBoxVIEW.Paint
        Dim wGyap As Integer = 6 + (PBoxVIEW.ClientSize.Height Mod 2)
        Dim wHeight As Integer = (PBoxVIEW.ClientSize.Height - wGyap) / 3

        Trace.WriteLine("■PBoxVIEW_Paint START  " & Now)
        e.Graphics.FillRectangle(Brushes.Black, e.ClipRectangle)
        If IsNothing(_objSENLOG) Then Exit Sub

        '枠線
        Dim offset1 As Integer = 0
        Dim offset2 As Integer = (wHeight + 1)
        Dim offset3 As Integer = offset2 * 2

        e.Graphics.DrawLine(Pens.DimGray, e.ClipRectangle.Left, offset2, e.ClipRectangle.Right, offset2)
        e.Graphics.DrawLine(Pens.DimGray, e.ClipRectangle.Left, offset3, e.ClipRectangle.Right, offset3)
        e.Graphics.DrawLine(Pens.DimGray, 0 - HScrollBar1.Value, e.ClipRectangle.Top, 0 - HScrollBar1.Value, e.ClipRectangle.Bottom)
        e.Graphics.DrawLine(Pens.DimGray, (_objSENLOG.SampleCount - 1) - HScrollBar1.Value, e.ClipRectangle.Top, (_objSENLOG.SampleCount - 1) - HScrollBar1.Value, e.ClipRectangle.Bottom)
        e.Graphics.DrawLine(Pens.Pink, NumericUpDown1.Value - HScrollBar1.Value, e.ClipRectangle.Top, NumericUpDown1.Value - HScrollBar1.Value, e.ClipRectangle.Bottom)

        'P0, P1, W0, W1
        Dim arrY(255) As Integer, x As Integer

        For y As Integer = 0 To 255
            arrY(y) = wHeight - (y * wHeight / 256)
        Next

        Dim staPos As Integer = _max(HScrollBar1.Value + e.ClipRectangle.Left, 0)
        Dim endPos As Integer = _min(HScrollBar1.Value + e.ClipRectangle.Right, _objSENLOG.SampleCount - 1)
#If 1 Then
        For i As Integer = staPos To endPos - 1
            x = i - HScrollBar1.Value
            e.Graphics.DrawLine(Pens.Yellow, x, arrY(_objSENLOG.P0(i)) + offset1, x + 1, arrY(_objSENLOG.P0(i + 1)) + offset1)
            e.Graphics.DrawLine(Pens.Yellow, x, arrY(_objSENLOG.P1(i)) + offset2, x + 1, arrY(_objSENLOG.P1(i + 1)) + offset2)
            e.Graphics.DrawLine(Pens.Aqua, x, arrY(_objSENLOG.W0(i)) + offset3, x + 1, arrY(_objSENLOG.W0(i + 1)) + offset3)
            e.Graphics.DrawLine(Pens.Magenta, x, arrY(_objSENLOG.W1(i)) + offset3, x + 1, arrY(_objSENLOG.W1(i + 1)) + offset3)
        Next

#End If

#If 0 Then
        Dim staBlk As Integer = Math.Truncate(staPos / 8)
        Dim endBlk As Integer = Math.Ceiling(endPos / 8)
        staPos = staBlk * 8
        x = staPos - HScrollBar1.Value
        Trace.WriteLine("staPos=" & staPos & " -->  staBlk=" & staBlk)
        Trace.WriteLine("endPos=" & endPos & " -->  endBlk=" & endBlk)
        _objSENLOG.LoadSamples(staBlk, (endBlk - staBlk) + 1)
        For i As Integer = 0 To endPos - staPos
            e.Graphics.DrawLine(Pens.Yellow, x, arrY(_objSENLOG.P0crr(i)) + offset1, x + 1, arrY(_objSENLOG.P0crr(i + 1)) + offset1)
            e.Graphics.DrawLine(Pens.Yellow, x, arrY(_objSENLOG.P1crr(i)) + offset2, x + 1, arrY(_objSENLOG.P1crr(i + 1)) + offset2)
            e.Graphics.DrawLine(Pens.Aqua, x, arrY(_objSENLOG.W0crr(i)) + offset3, x + 1, arrY(_objSENLOG.W0crr(i + 1)) + offset3)
            e.Graphics.DrawLine(Pens.Magenta, x, arrY(_objSENLOG.W1crr(i)) + offset3, x + 1, arrY(_objSENLOG.W1crr(i + 1)) + offset3)
            x += 1
        Next

#End If

        '####

        Trace.WriteLine("■PBoxVIEW_Paint END  " & Now)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Trace.WriteLine("ryu")
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim res As String
        Dim ind As String = Val(NumericUpDown1.Value)

        If keyval = 1 Then
            res = String.Join(", ", ind.ToArray(), keyval.ToArray())
            ListBox1.Items.Add(res)
        ElseIf keyval = 2 Then
            res = String.Join(", ", ind.ToArray(), keyval.ToArray())
            ListBox1.Items.Add(res)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        keyval = 1
        Dim res As String
        Dim ind As String = Val(NumericUpDown1.Value)
        res = String.Join(", ", ind.ToArray(), keyval.ToArray())
        ListBox1.Items.Add(res)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        keyval = 2
        Dim res As String
        Dim ind As String = Val(NumericUpDown1.Value)
        res = String.Join(", ", ind.ToArray(), keyval.ToArray())
        ListBox1.Items.Add(res)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        keyval = 3
        Dim res As String
        Dim ind As String = Val(NumericUpDown1.Value)
        res = String.Join(", ", ind.ToArray(), keyval.ToArray())
        ListBox1.Items.Add(res)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        IO.Directory.CreateDirectory("C:\Users\User\Desktop")
        Dim w As New IO.StreamWriter("C:\Users\User\Desktop\test1.csv")
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            w.WriteLine(CType(ListBox1.Items.Item(i), String))
        Next
        w.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(IO.File.ReadAllLines("C:\Users\User\Desktop\test1.csv"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class

Public Module Module1
    Public keyval As String
End Module