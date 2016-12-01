<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdExecButton = New System.Windows.Forms.Button()
        Me.tbConnectionString = New System.Windows.Forms.TextBox()
        Me.lblConnectionString = New System.Windows.Forms.Label()
        Me.tbCommand = New System.Windows.Forms.TextBox()
        Me.lblCommand = New System.Windows.Forms.Label()
        Me.dgvResultTable = New System.Windows.Forms.DataGridView()
        Me.cmdCreateMdf = New System.Windows.Forms.Button()
        CType(Me.dgvResultTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExecButton
        '
        Me.cmdExecButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExecButton.Location = New System.Drawing.Point(268, 229)
        Me.cmdExecButton.Name = "cmdExecButton"
        Me.cmdExecButton.Size = New System.Drawing.Size(75, 23)
        Me.cmdExecButton.TabIndex = 0
        Me.cmdExecButton.Text = "実行"
        Me.cmdExecButton.UseVisualStyleBackColor = True
        '
        'tbConnectionString
        '
        Me.tbConnectionString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbConnectionString.Location = New System.Drawing.Point(12, 28)
        Me.tbConnectionString.Multiline = True
        Me.tbConnectionString.Name = "tbConnectionString"
        Me.tbConnectionString.Size = New System.Drawing.Size(330, 51)
        Me.tbConnectionString.TabIndex = 1
        Me.tbConnectionString.Text = "Data Source=(LocalDB)\MSSQLLocalDB;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AttachDbFileName=C:\TEMP\LocalDBSample.mdf;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Integrated Security=True;"
        '
        'lblConnectionString
        '
        Me.lblConnectionString.AutoSize = True
        Me.lblConnectionString.Location = New System.Drawing.Point(13, 13)
        Me.lblConnectionString.Name = "lblConnectionString"
        Me.lblConnectionString.Size = New System.Drawing.Size(29, 12)
        Me.lblConnectionString.TabIndex = 2
        Me.lblConnectionString.Text = "接続"
        '
        'tbCommand
        '
        Me.tbCommand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCommand.Location = New System.Drawing.Point(12, 110)
        Me.tbCommand.Multiline = True
        Me.tbCommand.Name = "tbCommand"
        Me.tbCommand.Size = New System.Drawing.Size(330, 113)
        Me.tbCommand.TabIndex = 1
        Me.tbCommand.Text = resources.GetString("tbCommand.Text")
        '
        'lblCommand
        '
        Me.lblCommand.AutoSize = True
        Me.lblCommand.Location = New System.Drawing.Point(13, 95)
        Me.lblCommand.Name = "lblCommand"
        Me.lblCommand.Size = New System.Drawing.Size(26, 12)
        Me.lblCommand.TabIndex = 2
        Me.lblCommand.Text = "SQL"
        '
        'dgvResultTable
        '
        Me.dgvResultTable.AllowUserToAddRows = False
        Me.dgvResultTable.AllowUserToDeleteRows = False
        Me.dgvResultTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultTable.Location = New System.Drawing.Point(12, 258)
        Me.dgvResultTable.Name = "dgvResultTable"
        Me.dgvResultTable.ReadOnly = True
        Me.dgvResultTable.RowTemplate.Height = 21
        Me.dgvResultTable.Size = New System.Drawing.Size(331, 94)
        Me.dgvResultTable.TabIndex = 3
        '
        'cmdCreateMdf
        '
        Me.cmdCreateMdf.Location = New System.Drawing.Point(12, 230)
        Me.cmdCreateMdf.Name = "cmdCreateMdf"
        Me.cmdCreateMdf.Size = New System.Drawing.Size(75, 23)
        Me.cmdCreateMdf.TabIndex = 4
        Me.cmdCreateMdf.Text = ".mdf 作成"
        Me.cmdCreateMdf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 364)
        Me.Controls.Add(Me.cmdCreateMdf)
        Me.Controls.Add(Me.dgvResultTable)
        Me.Controls.Add(Me.lblCommand)
        Me.Controls.Add(Me.lblConnectionString)
        Me.Controls.Add(Me.tbCommand)
        Me.Controls.Add(Me.tbConnectionString)
        Me.Controls.Add(Me.cmdExecButton)
        Me.Name = "Form1"
        Me.Text = "LocalDBSample"
        CType(Me.dgvResultTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdExecButton As Button
    Friend WithEvents tbConnectionString As TextBox
    Friend WithEvents lblConnectionString As Label
    Friend WithEvents tbCommand As TextBox
    Friend WithEvents lblCommand As Label
    Friend WithEvents dgvResultTable As DataGridView
    Friend WithEvents cmdCreateMdf As Button
End Class
