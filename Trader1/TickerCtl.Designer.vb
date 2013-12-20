<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TickerCtl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbName = New System.Windows.Forms.Label()
        Me.LBVolume = New System.Windows.Forms.Label()
        Me.lblBuy = New System.Windows.Forms.Label()
        Me.LBSpread = New System.Windows.Forms.Label()
        Me.LBChange = New System.Windows.Forms.Label()
        Me.LBProvider = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(56, 0)
        Me.lbName.Margin = New System.Windows.Forms.Padding(0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(58, 15)
        Me.lbName.TabIndex = 0
        '
        'LBVolume
        '
        Me.LBVolume.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBVolume.Location = New System.Drawing.Point(191, 0)
        Me.LBVolume.Margin = New System.Windows.Forms.Padding(0)
        Me.LBVolume.Name = "LBVolume"
        Me.LBVolume.Size = New System.Drawing.Size(73, 15)
        Me.LBVolume.TabIndex = 1
        '
        'lblBuy
        '
        Me.lblBuy.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuy.Location = New System.Drawing.Point(114, 0)
        Me.lblBuy.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBuy.Name = "lblBuy"
        Me.lblBuy.Size = New System.Drawing.Size(73, 15)
        Me.lblBuy.TabIndex = 1
        '
        'LBSpread
        '
        Me.LBSpread.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSpread.Location = New System.Drawing.Point(268, 0)
        Me.LBSpread.Margin = New System.Windows.Forms.Padding(0)
        Me.LBSpread.Name = "LBSpread"
        Me.LBSpread.Size = New System.Drawing.Size(56, 15)
        Me.LBSpread.TabIndex = 1
        '
        'LBChange
        '
        Me.LBChange.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBChange.Location = New System.Drawing.Point(327, 0)
        Me.LBChange.Margin = New System.Windows.Forms.Padding(0)
        Me.LBChange.Name = "LBChange"
        Me.LBChange.Size = New System.Drawing.Size(49, 15)
        Me.LBChange.TabIndex = 1
        '
        'LBProvider
        '
        Me.LBProvider.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBProvider.Location = New System.Drawing.Point(0, 0)
        Me.LBProvider.Margin = New System.Windows.Forms.Padding(0)
        Me.LBProvider.Name = "LBProvider"
        Me.LBProvider.Size = New System.Drawing.Size(56, 15)
        Me.LBProvider.TabIndex = 1
        '
        'TickerCtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LBProvider)
        Me.Controls.Add(Me.LBChange)
        Me.Controls.Add(Me.LBSpread)
        Me.Controls.Add(Me.lblBuy)
        Me.Controls.Add(Me.LBVolume)
        Me.Controls.Add(Me.lbName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TickerCtl"
        Me.Size = New System.Drawing.Size(380, 16)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents LBVolume As System.Windows.Forms.Label
    Friend WithEvents lblBuy As System.Windows.Forms.Label
    Friend WithEvents LBSpread As System.Windows.Forms.Label
    Friend WithEvents LBChange As System.Windows.Forms.Label
    Friend WithEvents LBProvider As System.Windows.Forms.Label

End Class
