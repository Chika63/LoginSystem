<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFm
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
        Me.Okbtn = New System.Windows.Forms.Button()
        Me.Kysbtn = New System.Windows.Forms.Button()
        Me.LoginName = New System.Windows.Forms.Label()
        Me.Path = New System.Windows.Forms.Label()
        Me.LoginTb = New System.Windows.Forms.TextBox()
        Me.PathTb = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Okbtn
        '
        Me.Okbtn.Location = New System.Drawing.Point(425, 382)
        Me.Okbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Okbtn.Name = "Okbtn"
        Me.Okbtn.Size = New System.Drawing.Size(88, 29)
        Me.Okbtn.TabIndex = 0
        Me.Okbtn.Text = "OK"
        Me.Okbtn.UseVisualStyleBackColor = True
        '
        'Kysbtn
        '
        Me.Kysbtn.Location = New System.Drawing.Point(519, 382)
        Me.Kysbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Kysbtn.Name = "Kysbtn"
        Me.Kysbtn.Size = New System.Drawing.Size(88, 29)
        Me.Kysbtn.TabIndex = 1
        Me.Kysbtn.Text = "キャンセル"
        Me.Kysbtn.UseVisualStyleBackColor = True
        '
        'LoginName
        '
        Me.LoginName.AutoSize = True
        Me.LoginName.Location = New System.Drawing.Point(303, 158)
        Me.LoginName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(54, 15)
        Me.LoginName.TabIndex = 2
        Me.LoginName.Text = "ログイン名"
        '
        'Path
        '
        Me.Path.AutoSize = True
        Me.Path.Location = New System.Drawing.Point(303, 281)
        Me.Path.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(51, 15)
        Me.Path.TabIndex = 3
        Me.Path.Text = "パスワード"
        '
        'LoginTb
        '
        Me.LoginTb.Location = New System.Drawing.Point(306, 176)
        Me.LoginTb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LoginTb.Name = "LoginTb"
        Me.LoginTb.Size = New System.Drawing.Size(300, 23)
        Me.LoginTb.TabIndex = 4
        '
        'PathTb
        '
        Me.PathTb.Location = New System.Drawing.Point(303, 300)
        Me.PathTb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PathTb.Name = "PathTb"
        Me.PathTb.Size = New System.Drawing.Size(303, 23)
        Me.PathTb.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(639, 136)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(280, 188)
        Me.DataGridView1.TabIndex = 6
        '
        'LoginFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 562)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PathTb)
        Me.Controls.Add(Me.LoginTb)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.LoginName)
        Me.Controls.Add(Me.Kysbtn)
        Me.Controls.Add(Me.Okbtn)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LoginFm"
        Me.Text = "ログイン"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Okbtn As Button
    Friend WithEvents Kysbtn As Button
    Friend WithEvents LoginName As Label
    Friend WithEvents Path As Label
    Friend WithEvents LoginTb As TextBox
    Friend WithEvents PathTb As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
