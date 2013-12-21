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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TickerCtl7 = New Trader1.TickerCtl()
        Me.TickerCtl5 = New Trader1.TickerCtl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TickerCtl6 = New Trader1.TickerCtl()
        Me.TickerCtl2 = New Trader1.TickerCtl()
        Me.TickerCtl1 = New Trader1.TickerCtl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TickerCtl10 = New Trader1.TickerCtl()
        Me.TickerCtl9 = New Trader1.TickerCtl()
        Me.TickerCtl8 = New Trader1.TickerCtl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TickerCtl4 = New Trader1.TickerCtl()
        Me.TickerCtl3 = New Trader1.TickerCtl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbBids = New System.Windows.Forms.Label()
        Me.lbBidsAve = New System.Windows.Forms.Label()
        Me.lbRatio = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbAsks = New System.Windows.Forms.Label()
        Me.lbAskAve = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbBidsB = New System.Windows.Forms.Label()
        Me.LBBidsAveB = New System.Windows.Forms.Label()
        Me.lbRatioB = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbAsksB = New System.Windows.Forms.Label()
        Me.lbAskAveB = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Chart1
        '
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.MaximumAutoSize = 99.0!
        ChartArea1.AxisX2.MaximumAutoSize = 99.0!
        ChartArea1.AxisY.IsStartedFromZero = False
        ChartArea1.AxisY.MaximumAutoSize = 99.0!
        ChartArea1.AxisY2.MaximumAutoSize = 99.0!
        ChartArea1.BorderColor = System.Drawing.Color.DarkGray
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(6, 171)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(460, 378)
        Me.Chart1.TabIndex = 26
        Me.Chart1.Text = "Chart1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30000
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TickerCtl7)
        Me.Panel1.Controls.Add(Me.TickerCtl5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TickerCtl6)
        Me.Panel1.Controls.Add(Me.TickerCtl2)
        Me.Panel1.Controls.Add(Me.TickerCtl1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(6, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 136)
        Me.Panel1.TabIndex = 27
        '
        'TickerCtl7
        '
        Me.TickerCtl7.ConvertVal = False
        Me.TickerCtl7.Location = New System.Drawing.Point(1, 24)
        Me.TickerCtl7.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl7.Name = "TickerCtl7"
        Me.TickerCtl7.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl7.TabIndex = 6
        Me.TickerCtl7.USD = 0.0!
        '
        'TickerCtl5
        '
        Me.TickerCtl5.ConvertVal = False
        Me.TickerCtl5.Location = New System.Drawing.Point(1, 67)
        Me.TickerCtl5.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl5.Name = "TickerCtl5"
        Me.TickerCtl5.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl5.TabIndex = 5
        Me.TickerCtl5.USD = 0.0!
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Change"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Spread"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Buy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Volume"
        '
        'TickerCtl6
        '
        Me.TickerCtl6.ConvertVal = False
        Me.TickerCtl6.Location = New System.Drawing.Point(1, 46)
        Me.TickerCtl6.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl6.Name = "TickerCtl6"
        Me.TickerCtl6.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl6.TabIndex = 3
        Me.TickerCtl6.USD = 0.0!
        '
        'TickerCtl2
        '
        Me.TickerCtl2.ConvertVal = False
        Me.TickerCtl2.Location = New System.Drawing.Point(1, 109)
        Me.TickerCtl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl2.Name = "TickerCtl2"
        Me.TickerCtl2.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl2.TabIndex = 1
        Me.TickerCtl2.USD = 0.0!
        '
        'TickerCtl1
        '
        Me.TickerCtl1.ConvertVal = False
        Me.TickerCtl1.Location = New System.Drawing.Point(1, 88)
        Me.TickerCtl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl1.Name = "TickerCtl1"
        Me.TickerCtl1.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl1.TabIndex = 0
        Me.TickerCtl1.USD = 0.0!
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "BTC/USD"
        '
        'Chart2
        '
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray
        ChartArea2.AxisX.MaximumAutoSize = 99.0!
        ChartArea2.AxisX2.MaximumAutoSize = 99.0!
        ChartArea2.AxisY.IsStartedFromZero = False
        ChartArea2.AxisY.MaximumAutoSize = 99.0!
        ChartArea2.AxisY2.MaximumAutoSize = 99.0!
        ChartArea2.BorderColor = System.Drawing.Color.DarkGray
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Location = New System.Drawing.Point(469, 171)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(460, 378)
        Me.Chart2.TabIndex = 29
        Me.Chart2.Text = "Chart2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "LTC/USD"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TickerCtl10)
        Me.Panel2.Controls.Add(Me.TickerCtl9)
        Me.Panel2.Controls.Add(Me.TickerCtl8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TickerCtl4)
        Me.Panel2.Controls.Add(Me.TickerCtl3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(591, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 136)
        Me.Panel2.TabIndex = 31
        '
        'TickerCtl10
        '
        Me.TickerCtl10.ConvertVal = False
        Me.TickerCtl10.Location = New System.Drawing.Point(1, 109)
        Me.TickerCtl10.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl10.Name = "TickerCtl10"
        Me.TickerCtl10.Size = New System.Drawing.Size(335, 19)
        Me.TickerCtl10.TabIndex = 7
        Me.TickerCtl10.USD = 0.0!
        '
        'TickerCtl9
        '
        Me.TickerCtl9.ConvertVal = False
        Me.TickerCtl9.Location = New System.Drawing.Point(1, 88)
        Me.TickerCtl9.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl9.Name = "TickerCtl9"
        Me.TickerCtl9.Size = New System.Drawing.Size(348, 19)
        Me.TickerCtl9.TabIndex = 6
        Me.TickerCtl9.USD = 0.0!
        '
        'TickerCtl8
        '
        Me.TickerCtl8.ConvertVal = False
        Me.TickerCtl8.Location = New System.Drawing.Point(1, 67)
        Me.TickerCtl8.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl8.Name = "TickerCtl8"
        Me.TickerCtl8.Size = New System.Drawing.Size(348, 19)
        Me.TickerCtl8.TabIndex = 5
        Me.TickerCtl8.USD = 0.0!
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 3)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Change"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Spread"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 3)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Buy"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(152, 3)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Volume"
        '
        'TickerCtl4
        '
        Me.TickerCtl4.ConvertVal = False
        Me.TickerCtl4.Location = New System.Drawing.Point(1, 24)
        Me.TickerCtl4.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl4.Name = "TickerCtl4"
        Me.TickerCtl4.Size = New System.Drawing.Size(348, 19)
        Me.TickerCtl4.TabIndex = 3
        Me.TickerCtl4.USD = 0.0!
        '
        'TickerCtl3
        '
        Me.TickerCtl3.ConvertVal = False
        Me.TickerCtl3.Location = New System.Drawing.Point(1, 46)
        Me.TickerCtl3.Margin = New System.Windows.Forms.Padding(2)
        Me.TickerCtl3.Name = "TickerCtl3"
        Me.TickerCtl3.Size = New System.Drawing.Size(348, 19)
        Me.TickerCtl3.TabIndex = 2
        Me.TickerCtl3.USD = 0.0!
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 101)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(109, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "USD/GBP"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(170, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(109, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "USD/CNY"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(170, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(109, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "USD/EUR"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(171, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 43
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(72, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Los Angeles"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(72, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "New York"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "London"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(72, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 39
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Sofia"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(72, 61)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Beijing"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(72, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbBids)
        Me.Panel3.Controls.Add(Me.lbBidsAve)
        Me.Panel3.Controls.Add(Me.lbRatio)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.lbAsks)
        Me.Panel3.Controls.Add(Me.lbAskAve)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Location = New System.Drawing.Point(469, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(460, 21)
        Me.Panel3.TabIndex = 41
        '
        'lbBids
        '
        Me.lbBids.Location = New System.Drawing.Point(203, 3)
        Me.lbBids.Margin = New System.Windows.Forms.Padding(0)
        Me.lbBids.Name = "lbBids"
        Me.lbBids.Size = New System.Drawing.Size(75, 13)
        Me.lbBids.TabIndex = 39
        '
        'lbBidsAve
        '
        Me.lbBidsAve.Location = New System.Drawing.Point(278, 3)
        Me.lbBidsAve.Margin = New System.Windows.Forms.Padding(0)
        Me.lbBidsAve.Name = "lbBidsAve"
        Me.lbBidsAve.Size = New System.Drawing.Size(55, 13)
        Me.lbBidsAve.TabIndex = 40
        '
        'lbRatio
        '
        Me.lbRatio.Location = New System.Drawing.Point(333, 3)
        Me.lbRatio.Margin = New System.Windows.Forms.Padding(0)
        Me.lbRatio.Name = "lbRatio"
        Me.lbRatio.Size = New System.Drawing.Size(110, 13)
        Me.lbRatio.TabIndex = 41
        Me.lbRatio.Text = ":"
        Me.lbRatio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(171, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "BIDS:"
        '
        'lbAsks
        '
        Me.lbAsks.Location = New System.Drawing.Point(38, 3)
        Me.lbAsks.Margin = New System.Windows.Forms.Padding(0)
        Me.lbAsks.Name = "lbAsks"
        Me.lbAsks.Size = New System.Drawing.Size(75, 13)
        Me.lbAsks.TabIndex = 43
        '
        'lbAskAve
        '
        Me.lbAskAve.Location = New System.Drawing.Point(113, 3)
        Me.lbAskAve.Margin = New System.Windows.Forms.Padding(0)
        Me.lbAskAve.Name = "lbAskAve"
        Me.lbAskAve.Size = New System.Drawing.Size(55, 13)
        Me.lbAskAve.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "ASKS:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbBidsB)
        Me.Panel4.Controls.Add(Me.LBBidsAveB)
        Me.Panel4.Controls.Add(Me.lbRatioB)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.lbAsksB)
        Me.Panel4.Controls.Add(Me.lbAskAveB)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Location = New System.Drawing.Point(6, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(460, 21)
        Me.Panel4.TabIndex = 41
        '
        'lbBidsB
        '
        Me.lbBidsB.Location = New System.Drawing.Point(203, 3)
        Me.lbBidsB.Margin = New System.Windows.Forms.Padding(0)
        Me.lbBidsB.Name = "lbBidsB"
        Me.lbBidsB.Size = New System.Drawing.Size(75, 13)
        Me.lbBidsB.TabIndex = 39
        '
        'LBBidsAveB
        '
        Me.LBBidsAveB.Location = New System.Drawing.Point(278, 3)
        Me.LBBidsAveB.Margin = New System.Windows.Forms.Padding(0)
        Me.LBBidsAveB.Name = "LBBidsAveB"
        Me.LBBidsAveB.Size = New System.Drawing.Size(55, 13)
        Me.LBBidsAveB.TabIndex = 40
        '
        'lbRatioB
        '
        Me.lbRatioB.Location = New System.Drawing.Point(333, 3)
        Me.lbRatioB.Margin = New System.Windows.Forms.Padding(0)
        Me.lbRatioB.Name = "lbRatioB"
        Me.lbRatioB.Size = New System.Drawing.Size(110, 13)
        Me.lbRatioB.TabIndex = 41
        Me.lbRatioB.Text = ":"
        Me.lbRatioB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(171, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "BIDS:"
        '
        'lbAsksB
        '
        Me.lbAsksB.Location = New System.Drawing.Point(38, 3)
        Me.lbAsksB.Margin = New System.Windows.Forms.Padding(0)
        Me.lbAsksB.Name = "lbAsksB"
        Me.lbAsksB.Size = New System.Drawing.Size(75, 13)
        Me.lbAsksB.TabIndex = 43
        '
        'lbAskAveB
        '
        Me.lbAskAveB.Location = New System.Drawing.Point(113, 3)
        Me.lbAskAveB.Margin = New System.Windows.Forms.Padding(0)
        Me.lbAskAveB.Name = "lbAskAveB"
        Me.lbAskAveB.Size = New System.Drawing.Size(55, 13)
        Me.lbAskAveB.TabIndex = 44
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 3)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 13)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "ASKS:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 554)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "BLCeStats"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TickerCtl1 As Trader1.TickerCtl
    Friend WithEvents TickerCtl4 As Trader1.TickerCtl
    Friend WithEvents TickerCtl3 As Trader1.TickerCtl
    Friend WithEvents TickerCtl2 As Trader1.TickerCtl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TickerCtl5 As Trader1.TickerCtl
    Friend WithEvents TickerCtl6 As Trader1.TickerCtl
    Friend WithEvents TickerCtl7 As Trader1.TickerCtl
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TickerCtl8 As Trader1.TickerCtl
    Friend WithEvents TickerCtl9 As Trader1.TickerCtl
    Friend WithEvents TickerCtl10 As Trader1.TickerCtl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbBids As System.Windows.Forms.Label
    Friend WithEvents lbBidsAve As System.Windows.Forms.Label
    Friend WithEvents lbRatio As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbAsks As System.Windows.Forms.Label
    Friend WithEvents lbAskAve As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbBidsB As System.Windows.Forms.Label
    Friend WithEvents LBBidsAveB As System.Windows.Forms.Label
    Friend WithEvents lbRatioB As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lbAsksB As System.Windows.Forms.Label
    Friend WithEvents lbAskAveB As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label

End Class
