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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_ブラウス = New System.Windows.Forms.Button()
        Me.txt_ファイル = New System.Windows.Forms.TextBox()
        Me.btn_アップロード = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_btn_ヘッダーなし = New System.Windows.Forms.RadioButton()
        Me.rd_btn_ヘッダーあり = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ヘッダー行 = New System.Windows.Forms.TextBox()
        Me.txt_データ開始行 = New System.Windows.Forms.TextBox()
        Me.btn_キャンセル = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ri_txt_ファイル内容 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "*.csv"
        '
        'btn_ブラウス
        '
        Me.btn_ブラウス.Location = New System.Drawing.Point(549, 21)
        Me.btn_ブラウス.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ブラウス.Name = "btn_ブラウス"
        Me.btn_ブラウス.Size = New System.Drawing.Size(75, 36)
        Me.btn_ブラウス.TabIndex = 0
        Me.btn_ブラウス.Text = "ブラウス"
        Me.btn_ブラウス.UseVisualStyleBackColor = True
        '
        'txt_ファイル
        '
        Me.txt_ファイル.Location = New System.Drawing.Point(36, 22)
        Me.txt_ファイル.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ファイル.Name = "txt_ファイル"
        Me.txt_ファイル.Size = New System.Drawing.Size(499, 22)
        Me.txt_ファイル.TabIndex = 1
        '
        'btn_アップロード
        '
        Me.btn_アップロード.Location = New System.Drawing.Point(288, 145)
        Me.btn_アップロード.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_アップロード.Name = "btn_アップロード"
        Me.btn_アップロード.Size = New System.Drawing.Size(97, 34)
        Me.btn_アップロード.TabIndex = 2
        Me.btn_アップロード.Text = "アップロード"
        Me.btn_アップロード.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_btn_ヘッダーなし)
        Me.GroupBox1.Controls.Add(Me.rd_btn_ヘッダーあり)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 84)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ヘッダー有無設定"
        '
        'rd_btn_ヘッダーなし
        '
        Me.rd_btn_ヘッダーなし.AutoSize = True
        Me.rd_btn_ヘッダーなし.Location = New System.Drawing.Point(5, 52)
        Me.rd_btn_ヘッダーなし.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rd_btn_ヘッダーなし.Name = "rd_btn_ヘッダーなし"
        Me.rd_btn_ヘッダーなし.Size = New System.Drawing.Size(91, 21)
        Me.rd_btn_ヘッダーなし.TabIndex = 6
        Me.rd_btn_ヘッダーなし.Text = "ヘッダーなし"
        Me.rd_btn_ヘッダーなし.UseVisualStyleBackColor = True
        '
        'rd_btn_ヘッダーあり
        '
        Me.rd_btn_ヘッダーあり.AutoSize = True
        Me.rd_btn_ヘッダーあり.Checked = True
        Me.rd_btn_ヘッダーあり.Location = New System.Drawing.Point(5, 25)
        Me.rd_btn_ヘッダーあり.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rd_btn_ヘッダーあり.Name = "rd_btn_ヘッダーあり"
        Me.rd_btn_ヘッダーあり.Size = New System.Drawing.Size(89, 21)
        Me.rd_btn_ヘッダーあり.TabIndex = 5
        Me.rd_btn_ヘッダーあり.TabStop = True
        Me.rd_btn_ヘッダーあり.Text = "ヘッダーあり"
        Me.rd_btn_ヘッダーあり.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ヘッダー行"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "データ開始行"
        '
        'txt_ヘッダー行
        '
        Me.txt_ヘッダー行.Location = New System.Drawing.Point(421, 73)
        Me.txt_ヘッダー行.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ヘッダー行.Name = "txt_ヘッダー行"
        Me.txt_ヘッダー行.Size = New System.Drawing.Size(132, 22)
        Me.txt_ヘッダー行.TabIndex = 9
        Me.txt_ヘッダー行.Text = "1"
        '
        'txt_データ開始行
        '
        Me.txt_データ開始行.Location = New System.Drawing.Point(421, 107)
        Me.txt_データ開始行.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_データ開始行.Name = "txt_データ開始行"
        Me.txt_データ開始行.Size = New System.Drawing.Size(132, 22)
        Me.txt_データ開始行.TabIndex = 10
        Me.txt_データ開始行.Text = "2"
        '
        'btn_キャンセル
        '
        Me.btn_キャンセル.Location = New System.Drawing.Point(421, 145)
        Me.btn_キャンセル.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_キャンセル.Name = "btn_キャンセル"
        Me.btn_キャンセル.Size = New System.Drawing.Size(97, 34)
        Me.btn_キャンセル.TabIndex = 11
        Me.btn_キャンセル.Text = "キャンセル"
        Me.btn_キャンセル.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ファイル内容"
        '
        'ri_txt_ファイル内容
        '
        Me.ri_txt_ファイル内容.Location = New System.Drawing.Point(16, 209)
        Me.ri_txt_ファイル内容.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ri_txt_ファイル内容.Name = "ri_txt_ファイル内容"
        Me.ri_txt_ファイル内容.Size = New System.Drawing.Size(616, 240)
        Me.ri_txt_ファイル内容.TabIndex = 13
        Me.ri_txt_ファイル内容.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 458)
        Me.Controls.Add(Me.ri_txt_ファイル内容)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_キャンセル)
        Me.Controls.Add(Me.txt_データ開始行)
        Me.Controls.Add(Me.txt_ヘッダー行)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_アップロード)
        Me.Controls.Add(Me.txt_ファイル)
        Me.Controls.Add(Me.btn_ブラウス)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_ブラウス As Button
    Friend WithEvents txt_ファイル As TextBox
    Friend WithEvents btn_アップロード As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_btn_ヘッダーなし As RadioButton
    Friend WithEvents rd_btn_ヘッダーあり As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ヘッダー行 As TextBox
    Friend WithEvents txt_データ開始行 As TextBox
    Friend WithEvents btn_キャンセル As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ri_txt_ファイル内容 As RichTextBox
End Class
