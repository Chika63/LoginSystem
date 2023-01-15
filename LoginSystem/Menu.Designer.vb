<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.MenuName = New System.Windows.Forms.Label()
        Me.Path = New System.Windows.Forms.Label()
        Me.MenuTb = New System.Windows.Forms.TextBox()
        Me.PathTb = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Okbtn
        '
        Me.Okbtn.Location = New System.Drawing.Point(364, 306)
        Me.Okbtn.Name = "Okbtn"
        Me.Okbtn.Size = New System.Drawing.Size(75, 23)
        Me.Okbtn.TabIndex = 0
        Me.Okbtn.Text = "OK"
        Me.Okbtn.UseVisualStyleBackColor = True
        '
        'Kysbtn
        '
        Me.Kysbtn.Location = New System.Drawing.Point(445, 306)
        Me.Kysbtn.Name = "Kysbtn"
        Me.Kysbtn.Size = New System.Drawing.Size(75, 23)
        Me.Kysbtn.TabIndex = 1
        Me.Kysbtn.Text = "キャンセル"
        Me.Kysbtn.UseVisualStyleBackColor = True
        '
        'MenuName
        '
        Me.MenuName.AutoSize = True
        Me.MenuName.Location = New System.Drawing.Point(260, 126)
        Me.MenuName.Name = "MenuName"
        Me.MenuName.Size = New System.Drawing.Size(53, 12)
        Me.MenuName.TabIndex = 2
        Me.MenuName.Text = "ログイン名"
        '
        'Path
        '
        Me.Path.AutoSize = True
        Me.Path.Location = New System.Drawing.Point(260, 225)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(52, 12)
        Me.Path.TabIndex = 3
        Me.Path.Text = "パスワード"
        '
        'MenuTb
        '
        Me.MenuTb.Location = New System.Drawing.Point(262, 141)
        Me.MenuTb.Name = "MenuTb"
        Me.MenuTb.Size = New System.Drawing.Size(258, 19)
        Me.MenuTb.TabIndex = 4
        '
        'PathTb
        '
        Me.PathTb.Location = New System.Drawing.Point(260, 240)
        Me.PathTb.Name = "PathTb"
        Me.PathTb.Size = New System.Drawing.Size(260, 19)
        Me.PathTb.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(548, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PathTb)
        Me.Controls.Add(Me.MenuTb)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.MenuName)
        Me.Controls.Add(Me.Kysbtn)
        Me.Controls.Add(Me.Okbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Okbtn As Button
    Friend WithEvents Kysbtn As Button
    Friend WithEvents MenuName As Label
    Friend WithEvents Path As Label
    Friend WithEvents MenuTb As TextBox
    Friend WithEvents PathTb As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
