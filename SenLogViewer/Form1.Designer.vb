<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtLOGFILE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLOGFILE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.PBoxVIEW = New System.Windows.Forms.PictureBox()
        Me.PBoxWAVE = New System.Windows.Forms.PictureBox()
        Me.Lblサンプル位置 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LblP0 = New System.Windows.Forms.Label()
        Me.LblP1 = New System.Windows.Forms.Label()
        Me.LblW0 = New System.Windows.Forms.Label()
        Me.LblW1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxWAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLOGFILE
        '
        Me.TxtLOGFILE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLOGFILE.Location = New System.Drawing.Point(71, 8)
        Me.TxtLOGFILE.Name = "TxtLOGFILE"
        Me.TxtLOGFILE.Size = New System.Drawing.Size(804, 20)
        Me.TxtLOGFILE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ログファイル :"
        '
        'BtnLOGFILE
        '
        Me.BtnLOGFILE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLOGFILE.Location = New System.Drawing.Point(876, 6)
        Me.BtnLOGFILE.Name = "BtnLOGFILE"
        Me.BtnLOGFILE.Size = New System.Drawing.Size(33, 25)
        Me.BtnLOGFILE.TabIndex = 14
        Me.BtnLOGFILE.Text = "..."
        Me.BtnLOGFILE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.HScrollBar1)
        Me.Panel1.Controls.Add(Me.PBoxVIEW)
        Me.Panel1.Controls.Add(Me.PBoxWAVE)
        Me.Panel1.Location = New System.Drawing.Point(5, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 528)
        Me.Panel1.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(865, 468)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 25)
        Me.Button3.TabIndex = 33
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(772, 468)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 29)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(658, 468)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(836, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(741, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(655, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(801, 88)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(85, 40)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(715, 88)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 40)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 88)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 40)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(695, 166)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(131, 290)
        Me.ListBox1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(819, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(68, 20)
        Me.TextBox1.TabIndex = 21
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 510)
        Me.HScrollBar1.Maximum = 0
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(905, 17)
        Me.HScrollBar1.TabIndex = 20
        '
        'PBoxVIEW
        '
        Me.PBoxVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBoxVIEW.BackColor = System.Drawing.Color.Black
        Me.PBoxVIEW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBoxVIEW.Location = New System.Drawing.Point(21, 99)
        Me.PBoxVIEW.Margin = New System.Windows.Forms.Padding(0)
        Me.PBoxVIEW.Name = "PBoxVIEW"
        Me.PBoxVIEW.Size = New System.Drawing.Size(597, 368)
        Me.PBoxVIEW.TabIndex = 19
        Me.PBoxVIEW.TabStop = False
        '
        'PBoxWAVE
        '
        Me.PBoxWAVE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBoxWAVE.BackColor = System.Drawing.Color.DimGray
        Me.PBoxWAVE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBoxWAVE.Location = New System.Drawing.Point(0, 73)
        Me.PBoxWAVE.Margin = New System.Windows.Forms.Padding(0)
        Me.PBoxWAVE.Name = "PBoxWAVE"
        Me.PBoxWAVE.Size = New System.Drawing.Size(905, 8)
        Me.PBoxWAVE.TabIndex = 18
        Me.PBoxWAVE.TabStop = False
        Me.PBoxWAVE.Visible = False
        '
        'Lblサンプル位置
        '
        Me.Lblサンプル位置.AutoSize = True
        Me.Lblサンプル位置.Location = New System.Drawing.Point(115, 38)
        Me.Lblサンプル位置.Name = "Lblサンプル位置"
        Me.Lblサンプル位置.Size = New System.Drawing.Size(72, 13)
        Me.Lblサンプル位置.TabIndex = 18
        Me.Lblサンプル位置.Text = "wave position"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(31, 36)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(79, 20)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblP0
        '
        Me.LblP0.AutoSize = True
        Me.LblP0.Location = New System.Drawing.Point(383, 38)
        Me.LblP0.Name = "LblP0"
        Me.LblP0.Size = New System.Drawing.Size(49, 13)
        Me.LblP0.TabIndex = 20
        Me.LblP0.Text = "P0 : xxxx"
        '
        'LblP1
        '
        Me.LblP1.AutoSize = True
        Me.LblP1.Location = New System.Drawing.Point(452, 38)
        Me.LblP1.Name = "LblP1"
        Me.LblP1.Size = New System.Drawing.Size(49, 13)
        Me.LblP1.TabIndex = 21
        Me.LblP1.Text = "P1 : xxxx"
        '
        'LblW0
        '
        Me.LblW0.AutoSize = True
        Me.LblW0.Location = New System.Drawing.Point(524, 38)
        Me.LblW0.Name = "LblW0"
        Me.LblW0.Size = New System.Drawing.Size(53, 13)
        Me.LblW0.TabIndex = 22
        Me.LblW0.Text = "W0 : xxxx"
        '
        'LblW1
        '
        Me.LblW1.AutoSize = True
        Me.LblW1.Location = New System.Drawing.Point(597, 38)
        Me.LblW1.Name = "LblW1"
        Me.LblW1.Size = New System.Drawing.Size(53, 13)
        Me.LblW1.TabIndex = 23
        Me.LblW1.Text = "W1 : xxxx"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 598)
        Me.Controls.Add(Me.LblW1)
        Me.Controls.Add(Me.LblW0)
        Me.Controls.Add(Me.LblP1)
        Me.Controls.Add(Me.LblP0)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Lblサンプル位置)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnLOGFILE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLOGFILE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(638, 315)
        Me.Name = "Form1"
        Me.Text = "センサーログビューア"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxWAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLOGFILE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLOGFILE As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PBoxWAVE As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxVIEW As System.Windows.Forms.PictureBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Lblサンプル位置 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblP0 As System.Windows.Forms.Label
    Friend WithEvents LblP1 As System.Windows.Forms.Label
    Friend WithEvents LblW0 As System.Windows.Forms.Label
    Friend WithEvents LblW1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
