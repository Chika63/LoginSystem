﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Engbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Engbtn
        '
        Me.Engbtn.Location = New System.Drawing.Point(129, 136)
        Me.Engbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Engbtn.Name = "Engbtn"
        Me.Engbtn.Size = New System.Drawing.Size(165, 63)
        Me.Engbtn.TabIndex = 0
        Me.Engbtn.Text = "英単語アプリ"
        Me.Engbtn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 562)
        Me.Controls.Add(Me.Engbtn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.Text = "メニュー"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Engbtn As Button
End Class
