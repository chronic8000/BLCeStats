Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Runtime.Serialization
Imports System.Collections.Concurrent
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Numerics
Imports System.Windows.Forms.DataVisualization.Charting



Public Class Form1
    Public Shared MTGoxSecret As String = ""
    Public Shared MTGoxAPI As String = ""
    Public Shared USDGBPValue As Single
    Public Shared USDCNYValue As Single
    Public Shared USDEURValue As Single
    Public Shared LastAsks As Single
    Public Shared LastBids As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateRates()

        Dim cS1 As New DataVisualization.Charting.Series("S1")
        cS1.Color = Color.Black
        cS1.IsVisibleInLegend = False
        cS1.IsXValueIndexed = False
        cS1.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart1.Series.Add(cS1)

        Dim cS2 As New DataVisualization.Charting.Series("S2")
        cS2.Color = Color.Red
        cS2.IsVisibleInLegend = False
        cS2.IsXValueIndexed = False
        cS2.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart1.Series.Add(cS2)

        Dim cS3 As New DataVisualization.Charting.Series("S3")
        cS3.Color = Color.Green
        cS3.IsVisibleInLegend = False
        cS3.IsXValueIndexed = False
        cS3.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart2.Series.Add(cS3)

        Dim cS4 As New DataVisualization.Charting.Series("S4")
        cS4.Color = Color.Blue
        cS4.IsVisibleInLegend = False
        cS4.IsXValueIndexed = False
        cS4.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart2.Series.Add(cS4)

        Dim cS5 As New DataVisualization.Charting.Series("S5")
        cS5.Color = Color.Brown
        cS5.IsVisibleInLegend = False
        cS5.IsXValueIndexed = False
        cS5.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart1.Series.Add(cS5)

        Dim cS6 As New DataVisualization.Charting.Series("S6")
        cS6.Color = Color.Orange
        cS6.IsVisibleInLegend = False
        cS6.IsXValueIndexed = False
        cS6.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart1.Series.Add(cS6)

        Dim cS7 As New DataVisualization.Charting.Series("S7")
        cS7.Color = Color.Purple
        cS7.IsVisibleInLegend = False
        cS7.IsXValueIndexed = False
        cS7.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart1.Series.Add(cS7)

        Dim cS8 As New DataVisualization.Charting.Series("S8")
        cS8.Color = Color.Purple
        cS8.IsVisibleInLegend = False
        cS8.IsXValueIndexed = False
        cS8.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart2.Series.Add(cS8)

        Dim cS9 As New DataVisualization.Charting.Series("S9")
        cS9.Color = Color.Purple
        cS9.IsVisibleInLegend = False
        cS9.IsXValueIndexed = False
        cS9.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart2.Series.Add(cS9)

        Dim cS10 As New DataVisualization.Charting.Series("S10")
        cS10.Color = Color.Purple
        cS10.IsVisibleInLegend = False
        cS10.IsXValueIndexed = False
        cS10.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Chart2.Series.Add(cS10)

        Chart1.ChartAreas(0).AxisY.IsStartedFromZero = False
        Chart2.ChartAreas(0).AxisY.IsStartedFromZero = False
        ' Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.Enabled = True
        ' Show scale break if more than 25% of the chart is empty space.     
        ' Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 25
        ' Set the line width of the scale break.    
        ' Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.LineWidth = 2
        ' Set the color of the scale break. 
        ' Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.LineColor = Color.Red
        ' If all data points are significantly far from zero, the chart will calculate the scale minimum value. 
        Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto
        Chart2.ChartAreas(0).AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto
        ' Set the spacing gap between the lines of the scale break (as a percentage of the Y-axis).
        ' Chart1.ChartAreas(0).AxisY.ScaleBreakStyle.Spacing = 2

        '// Set Chart Area position
        Chart1.ChartAreas(0).Position.Auto = False
        Chart1.ChartAreas(0).Position.X = 8
        Chart1.ChartAreas(0).Position.Y = 0
        Chart1.ChartAreas(0).Position.Width = 90
        Chart1.ChartAreas(0).Position.Height = 90

        '    // Set the plotting area position. Coordinates of a plotting 
        '   // area are relative to a chart area position.
        Chart1.ChartAreas(0).InnerPlotPosition.Auto = False
        Chart1.ChartAreas(0).InnerPlotPosition.X = 0
        Chart1.ChartAreas(0).InnerPlotPosition.Y = 0
        Chart1.ChartAreas(0).InnerPlotPosition.Width = 100
        Chart1.ChartAreas(0).InnerPlotPosition.Height = 100

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckDepthGo("http://btc-e.com/api/2/ltc_usd/depth", "BTC-e")
        ' Exit Sub
        CheckTickGo("http://data.btcchina.com/data/ticker", "china")
        CheckTickGo("http://btc-e.com/api/2/ltc_usd/ticker", "ltcu")
        CheckTickGo("http://btc-e.com/api/2/btc_usd/ticker", "btcu")
        'CheckTickGo("http://btc-e.com/api/2/ltc_btc/ticker", "btcl")
        CheckTickGo("http://www.okcoin.com/api/ticker.do?symbol=ltc_cny", "ok")
        CheckTickGo("http://www.okcoin.com/api/ticker.do?symbol=btc_cny", "okb")
        ' CheckTickGo("http://api.796.com/apiV2/ticker.html?op=futures", "796")
        ' CheckTickGo("http://btc100.org/api/ticker.php", "b100")
        ' CheckTickGo("http://www.crypto-trade.com/api/1/ticker/ltc_usd", "cryptol")
        '  CheckFTickGo("http://bter.com/api/1/ticker/ltc_cny", "bter")
        CheckGTickGo("http://data.mtgox.com/api/2/BTCUSD/money/ticker", "mtG")
        CheckFTickGo("http://api.bitfinex.com/v1/ticker/ltcusd", "bit")
        'www.crypto-trade.com/api/1/ticker/btc_usd
        '?symbol=ltc_cny

        'https://bter.com/api/1/ticker/ltc_cny
        'https://www.crypto-trade.com/api/1/ticker/ltc_usd
        'http://api.796.com/apiV2/ticker.html?op=futures

        'https://emebtc.com/api/1/ticker/ltc_usd

        'http://www.bitstamp.net/api/ticker/
        'https://btc100.org/api/ticker.php

    End Sub

    Public Function CheckGTick(url As String, Feed As String) As GoxTicks
        Dim eti As GoxTicks
        Try
            eti = GetGTicker(url, Feed)
        Catch ex As Exception
            Debug.Print(Feed & " Error: " & ex.ToString)
        End Try
        Return eti
    End Function
    Public Sub CheckGTickGo(Url As String, Feed As String)
        Dim TickCheck As Tasks.Task(Of GoxTicks) = Tasks.Task(Of GoxTicks).Factory.StartNew(Function()
                                                                                                Return CheckGTick(Url, Feed)
                                                                                            End Function)
        TickCheck.ContinueWith(AddressOf GTickComplete)
    End Sub

    Public Function CheckFTick(url As String, Feed As String) As BitFinTicks
        Dim eti As BitFinTicks
        Try
            eti = GetFTicker(url, Feed)
        Catch ex As Exception
            Debug.Print(Feed & " Error: " & ex.ToString)
        End Try
        Return eti
    End Function
    Public Sub CheckFTickGo(Url As String, Feed As String)
        Dim TickCheck As Tasks.Task(Of BitFinTicks) = Tasks.Task(Of BitFinTicks).Factory.StartNew(Function()
                                                                                                      Return CheckFTick(Url, Feed)
                                                                                                  End Function)
        TickCheck.ContinueWith(AddressOf fTickComplete)
    End Sub

    Public Function CheckTick(url As String, Feed As String) As Eticker
        Dim eti As Eticker
        Try
            eti = GetTicker(url, Feed)
        Catch ex As Exception
            Debug.Print(Feed & " Error: " & ex.ToString)
        End Try
        Return eti
    End Function
    Public Sub CheckTickGo(Url As String, Feed As String)
        ' Dim context = TaskScheduler.FromCurrentSynchronizationContext()
        ' Dim token = Tasks.Task.Factory.CancellationToken
        Dim TickCheck As Tasks.Task(Of Eticker) = Tasks.Task(Of Eticker).Factory.StartNew(Function()
                                                                                              Return CheckTick(Url, Feed)
                                                                                          End Function)
        ', token, TaskCreationOptions.None, context)
        TickCheck.ContinueWith(AddressOf TickComplete) ', context)
    End Sub

    Public Sub GTickComplete(action As Tasks.Task(Of GoxTicks))
        Dim eti = action.Result
        If IsNothing(eti) Then Exit Sub
        Dim usd As Single
        Single.TryParse(USDCNYValue, usd)
        eti.BaseCurr = "BTC"
        eti.ToCurr = "USD"
        eti.Provider = "MT Gox"
        TickerCtl6.ConvertVal = False
        TickerCtl6.USD = usd
        TickerCtl6.UpdateTicker(eti)
        SetChart((CSng(eti.buy.value)), "S6")
    End Sub

    Public Sub fTickComplete(action As Tasks.Task(Of BitFinTicks))
        Dim eti = action.Result
        If IsNothing(eti) Then Exit Sub

        Dim usd As Single
        Single.TryParse(USDCNYValue, usd)
        Select Case eti.Feed
            Case "bit"
                eti.BaseCurr = "LTC"
                eti.ToCurr = "USD"
                eti.Provider = "BitFinex"
                TickerCtl9.ConvertVal = False
                TickerCtl9.USD = usd
                TickerCtl9.UpdateTicker(eti)
                SetChart((CSng(eti.ask)), "S9")
            Case "bter"
                eti.BaseCurr = "LTC"
                eti.ToCurr = "USD"
                eti.Provider = "BTer"
                TickerCtl8.ConvertVal = True
                TickerCtl8.USD = usd
                TickerCtl8.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S8")
        End Select

      
    End Sub

    Public Sub TickComplete(action As Tasks.Task(Of Eticker))
        Dim eti = action.Result
        If IsNothing(eti) Then Exit Sub
        Dim usd As Single
        Single.TryParse(USDCNYValue, usd)
        Select Case eti.Feed
            Case "b100"
                eti.BaseCurr = "BTC"
                eti.ToCurr = "USD"
                eti.Provider = "Btc100"
                TickerCtl7.ConvertVal = True
                TickerCtl7.USD = usd
                TickerCtl7.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S7")
            Case "btcu"
                eti.BaseCurr = "BTC"
                eti.ToCurr = "USD"
                eti.Provider = "BTC-e"
                TickerCtl5.ConvertVal = False
                TickerCtl5.USD = usd
                TickerCtl5.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S5")
            Case "china"
                eti.BaseCurr = "BTC"
                eti.ToCurr = "USD"
                eti.Provider = "BTCChina"
                TickerCtl1.ConvertVal = True
                TickerCtl1.USD = usd
                TickerCtl1.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S1")
            Case "okb"
                eti.BaseCurr = "BTC"
                eti.ToCurr = "USD"
                eti.Provider = "OKCoin"
                TickerCtl2.ConvertVal = True
                TickerCtl2.USD = usd
                TickerCtl2.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S2")
            Case "btcl"
                eti.BaseCurr = "LTC"
                eti.ToCurr = "BTC"
                eti.Provider = "BTC-e"
                TickerCtl3.ConvertVal = False
                TickerCtl3.USD = usd
                TickerCtl3.UpdateTicker(eti)
                '   SetChart((CSng(eti.buy)), "S3")
           
            Case "ltcu"
                eti.BaseCurr = "LTC"
                eti.ToCurr = "USD"
                eti.Provider = "BTC-e"
                TickerCtl4.ConvertVal = False
                TickerCtl4.USD = usd
                TickerCtl4.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S4")
          
            Case "ok"
                eti.BaseCurr = "LTC"
                eti.ToCurr = "USD"
                eti.Provider = "OKCoin"
                TickerCtl10.ConvertVal = True
                TickerCtl10.USD = usd
                TickerCtl10.UpdateTicker(eti)
                SetChart((CSng(eti.buy)), "S10")

        End Select

    End Sub
    Private Sub UpdateRates()
        Try
            Dim ret As RateList = GetRates("http://openexchangerates.org/api/latest.json?app_id=3de4c8fe54314ed59f64c9f7cae29f94")
            USDGBPValue = CSng(ret.GBP)
            USDCNYValue = CSng(ret.CNY)
            USDEURValue = CSng(ret.EUR)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CheckDepthGo(Url As String, Feed As String)
        Dim DepthCheck As Tasks.Task(Of BTCDepth) = Tasks.Task(Of BTCDepth).Factory.StartNew(Function()
                                                                                                 Return CheckDepth(Url, Feed)
                                                                                             End Function)
        DepthCheck.ContinueWith(AddressOf DepthComplete) ', context)
    End Sub
    Public Function CheckDepth(url As String, Feed As String) As BTCDepth
        Dim eti As BTCDepth
        Try
            eti = GetDepth(url, Feed)
        Catch ex As Exception
            Debug.Print(Feed & " Error: " & ex.ToString)
        End Try
        Return eti
    End Function
    Public Sub DepthComplete(action As Tasks.Task(Of BTCDepth))
        Dim eti = action.Result
        If IsNothing(eti) Then Exit Sub
        Dim asks As Single = 0
        Dim askAmt As Single = 0

        For a As Integer = 0 To eti.asks.Count - 1
            asks += CSng(eti.asks(a)(0)) * CSng(eti.asks(a)(1))
            askAmt += CSng(eti.asks(a)(1))
        Next

        Dim asksAve As Single = askAmt / eti.asks.Count
        Dim atotAve As Single = asks / eti.asks.Count

        Dim bids As Single = 0
        Dim bidAmt As Single = 0
        For b As Integer = 0 To eti.bids.Count - 1
            bids += CSng(eti.bids(b)(0)) * CSng(eti.bids(b)(1))
            bidAmt += CSng(eti.bids(b)(1))
        Next
        Dim bidsAve As Single = bidAmt / eti.bids.Count
        Dim btotAve As Single = bids / eti.bids.Count

        SetDepth({asks, bids}, {asksAve, bidsAve, atotAve, btotAve})
    End Sub

    Public Function GetDepth(url As String, Feed As String) As BTCDepth
        Dim jResults As String = HTTPGET2(url)
        Dim r As BTCDepth
        Using ms As New MemoryStream(Encoding.UTF8.GetBytes(jResults))
            Dim js As New System.Runtime.Serialization.Json.DataContractJsonSerializer(GetType(BTCDepth))
            r = TryCast(js.ReadObject(ms), BTCDepth)
            ms.Close()
        End Using
        Return r
    End Function

    Delegate Sub SetChartCallback(bVal As Single, ChartNum As String)
    Delegate Sub SetDepthCallback(ABs() As Single, Aves() As Single)

    Public Sub SetDepth(ABS() As Single, AveS() As Single)
        If Chart1.InvokeRequired Then
            Dim d As New SetDepthCallback(AddressOf SetDepth)
            Me.Invoke(d, New Object() {ABS, AveS})
        Else

            If ABS(0) = LastAsks Then lbAsks.BackColor = Color.Transparent
            If ABS(0) > LastAsks Then lbAsks.BackColor = Color.LightGreen
            If ABS(0) < LastAsks Then lbAsks.BackColor = Color.Red
            lbAsks.Text = "$" & FormatNumber(ABS(0), 2)
            LastAsks = ABS(0)
            lbAskAve.Text = "#" & FormatNumber(AveS(0), 2) & "   $" & FormatNumber(AveS(2), 2)

            If ABS(1) = LastBids Then lbBids.BackColor = Color.Transparent
            If ABS(1) > LastBids Then lbBids.BackColor = Color.LightGreen
            If ABS(1) < LastBids Then lbBids.BackColor = Color.Red
            lbBids.Text = "$" & FormatNumber(ABS(1), 2)
            LastBids = ABS(1)
            lbBidsAve.Text = "#" & FormatNumber(AveS(1), 2) & "   $" & FormatNumber(AveS(3), 2)
            Dim rtot = (ABS(0) + ABS(1)) / 100

            Dim r1 = (ABS(0) / rtot)
            Dim r2 = (ABS(1) / rtot)

            lbRatio.Text = FormatNumber(r1, 2) & " : " & FormatNumber(r2, 2)
        End If
    End Sub

    Public Sub SetChart(bVal As Single, ChartNum As String)
        If Chart1.InvokeRequired Then
            Dim d As New SetChartCallback(AddressOf SetChart)
            Me.Invoke(d, New Object() {bVal, ChartNum})
        Else
            Dim points() As Double
            Select Case ChartNum
                Case "S1"
                    ' points = TickerCtl1.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart1.Series(ChartNum).Points.Add(CDbl(bVal))
                    '  Chart1.ChartAreas(0).RecalculateAxesScale()
                    Chart1.Invalidate()
                Case "S2"
                    '  points = TickerCtl2.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart1.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart1.ChartAreas(0).RecalculateAxesScale()
                    Chart1.Invalidate()
                Case "S3"
                    '   points = TickerCtl3.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart2.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart2.ChartAreas(0).RecalculateAxesScale()
                    Chart2.Invalidate()
                Case "S4"
                    '  points = TickerCtl4.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart2.Series(ChartNum).Points.Add(CDbl(bVal))
                    '  Chart2.ChartAreas(0).RecalculateAxesScale()
                    Chart2.Invalidate()
                Case "S5"
                    '   points = TickerCtl5.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart1.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart1.ChartAreas(0).RecalculateAxesScale()
                    Chart1.Invalidate()
                Case "S6"
                    '  points = TickerCtl6.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart1.Series(ChartNum).Points.Add(CDbl(bVal))
                    '    Chart1.ChartAreas(0).RecalculateAxesScale()
                    Chart1.Invalidate()
                Case "S7"
                    '  points = TickerCtl7.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart1.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart1.ChartAreas(0).RecalculateAxesScale()
                    Chart1.Invalidate()
                Case "S8"
                    '  points = TickerCtl8.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart2.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart2.ChartAreas(0).RecalculateAxesScale()
                    Chart2.Invalidate()
                Case "S9"
                    '  points = TickerCtl8.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart2.Series(ChartNum).Points.Add(CDbl(bVal))
                    '   Chart2.ChartAreas(0).RecalculateAxesScale()
                    Chart2.Invalidate()
                Case "S10"
                    '  points = TickerCtl8.Tickers.ToArray.Select(Function(x) CDbl(x.buy)).ToArray
                    Chart2.Series(ChartNum).Points.Add(CDbl(bVal))
                    '    Chart2.ChartAreas(0).RecalculateAxesScale()
                    Chart2.Invalidate()
            End Select
            
            
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        UpdateRates()
        Label25.Text = USDGBPValue
        Label24.Text = USDCNYValue
        Label23.Text = USDEURValue
        Label13.Text = FormatDateTime(Date.Now, DateFormat.ShortTime)
        Label12.Text = FormatDateTime(Date.Now.AddHours(8), DateFormat.ShortTime)
        Label11.Text = FormatDateTime(Date.Now.AddHours(-5), DateFormat.ShortTime)
    End Sub

    Public Function GetTicker(url As String, Feed As String) As Eticker
        Dim jResults As String = HTTPGET2(url)
        If jResults = "" Then Return New Eticker

        Dim r As OutETicker
        Using ms As New MemoryStream(Encoding.UTF8.GetBytes(jResults))
            Dim js As New System.Runtime.Serialization.Json.DataContractJsonSerializer(GetType(OutETicker))
            r = TryCast(js.ReadObject(ms), OutETicker)
            ms.Close()
        End Using
        If Not IsNothing(r.ticks) Then
            r.ticks.Feed = Feed
            Return r.ticks
        End If
        If Not IsNothing(r.data) Then
            r.data.Feed = Feed
            Return r.data
        End If
        If Not IsNothing(r.return) Then
            r.return.Feed = Feed
            Return r.return
        End If
    End Function
    Public Function GetGTicker(url As String, Feed As String) As GoxTicks
        Dim jResults As String = HTTPGET2(url)
        Dim r As GoxTicker
        Using ms As New MemoryStream(Encoding.UTF8.GetBytes(jResults))
            Dim js As New System.Runtime.Serialization.Json.DataContractJsonSerializer(GetType(GoxTicker))
            r = TryCast(js.ReadObject(ms), GoxTicker)
            ms.Close()
        End Using
        Return r.data
    End Function

    Public Function GetFTicker(url As String, Feed As String) As BitFinTicks
        Dim jResults As String = HTTPGET2(url)
        Dim r As BitFinTicks
        Using ms As New MemoryStream(Encoding.UTF8.GetBytes(jResults))
            Dim js As New System.Runtime.Serialization.Json.DataContractJsonSerializer(GetType(BitFinTicks))
            r = TryCast(js.ReadObject(ms), BitFinTicks)
            ms.Close()
        End Using
        Return r
    End Function

    Public Function GetRates(url As String) As RateList
        Dim jResults As String = HTTPGET2(url)
        Dim r As Rates
        Using ms As New MemoryStream(Encoding.UTF8.GetBytes(jResults))
            Dim js As New System.Runtime.Serialization.Json.DataContractJsonSerializer(GetType(Rates))
            r = TryCast(js.ReadObject(ms), Rates)
            ms.Close()
        End Using
        Return r.rates
    End Function
    Public Shared Function HTTPGET2(url As String) As String
        Dim wikipage As String = ""
        Dim req As HttpWebRequest = WebRequest.Create(url)
        'req.Headers.Add("Accept", "text/json")
        'req.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;")
        'req.ContentType = ""
        Dim cookies As CookieContainer = New CookieContainer
        req.CookieContainer = cookies
        req.Method = "GET"
        Using res As Net.WebResponse = req.GetResponse
            Using westream As Stream = res.GetResponseStream
                Using reader As StreamReader = New StreamReader(westream)
                    wikipage = reader.ReadToEnd
                    reader.Close()
                End Using
                westream.Close()
            End Using
            res.Close()
        End Using
        Return wikipage

    End Function
    Public Function HTTPPost(ByVal itm As String, ByVal path As String) As String
        itm = "nonce=" & Environment.TickCount
        Dim base As String = "https://data.mtgox.com/api/2/"
        path = "BTCUSD/money/ticker"
        Dim mssg As String = path & "\0" & itm


        Using web As New System.Net.WebClient()
            web.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
            web.Headers.Add("Rest-Key", MTGoxAPI)
            Dim DScrt = System.Convert.FromBase64String(MTGoxSecret)
            Dim ma = HMACSHA512.Create()
            ma.Key = (DScrt)
            Dim d As Byte() = System.Text.Encoding.UTF8.GetBytes(mssg)
            Dim Sign As String = System.Convert.ToBase64String(ma.ComputeHash(d))
            web.Headers.Add("Rest-Sign", Sign)


            Try
                Dim res As Byte() = web.UploadData(base & path & "?" & itm, "POST", d)
                Return System.Text.Encoding.UTF8.GetString(res)
            Catch wex As System.Net.WebException
                Return "ERROR: " & wex.Message
            Catch ex As Exception
                Return "ERROR: " & ex.Message
            End Try
        End Using
    End Function

   
End Class

<DataContract(Name:="ticker")> _
Public Class OutETicker
    <DataMember(Name:="ticker", EmitDefaultValue:=False)> _
    Public ticks As Eticker
    <DataMember(Name:="data", EmitDefaultValue:=False)> _
    Public data As Eticker
    <DataMember(Name:="return", EmitDefaultValue:=False)> _
    Public [return] As Eticker
End Class

<DataContract(Name:="ticker")> _
Public Class Eticker
    <DataMember(Name:="high", EmitDefaultValue:=False)> _
    Public high As String = "0"
    <DataMember(Name:="low", EmitDefaultValue:=False)> _
    Public low As String = "0"
    <DataMember(Name:="buy", EmitDefaultValue:=False)> _
    Public buy As String = "0"
    <DataMember(Name:="sell", EmitDefaultValue:=False)> _
    Public sell As String = "0"
    <DataMember(Name:="last", EmitDefaultValue:=False)> _
    Public last As String = "0"
    <DataMember(Name:="vol", EmitDefaultValue:=False)> _
    Public vol As String = "0"
    <DataMember(Name:="avg", EmitDefaultValue:=False)> _
    Public avg As String = "0"
    <DataMember(Name:="vol_cur", EmitDefaultValue:=False)> _
    Public vol_cur As String
    <DataMember(Name:="vol_usd", EmitDefaultValue:=False)> _
    Public vol_usd As String
    <DataMember(Name:="updated", EmitDefaultValue:=False)> _
    Public updated As String
    <DataMember(Name:="server_time", EmitDefaultValue:=False)> _
    Public server_time As String

    <DataMember(Name:="min_ask", EmitDefaultValue:=False)> _
    Public min_ask As String = "0"
    <DataMember(Name:="max_bid", EmitDefaultValue:=False)> _
    Public max_bid As String = "0"

    Public Provider As String
    Public Feed As String
    Public BaseCurr As String
    Public ToCurr As String
    Public Change As String
    Public Spread As String
End Class

<DataContract(Name:="ticker")> _
Public Class GoxTicker
    <DataMember(Name:="result", EmitDefaultValue:=False)> _
    Public Result As String
    <DataMember(Name:="data", EmitDefaultValue:=False)> _
    Public data As GoxTicks
End Class

<DataContract(Name:="data")> _
Public Class GoxTicks
    <DataMember(Name:="high", EmitDefaultValue:=False)> _
    Public high As GoxTick
    <DataMember(Name:="low", EmitDefaultValue:=False)> _
    Public low As GoxTick
    <DataMember(Name:="avg", EmitDefaultValue:=False)> _
    Public avg As GoxTick
    <DataMember(Name:="vol", EmitDefaultValue:=False)> _
    Public vol As GoxTick
    <DataMember(Name:="buy", EmitDefaultValue:=False)> _
    Public buy As GoxTick
    <DataMember(Name:="sell", EmitDefaultValue:=False)> _
    Public sell As GoxTick
    Public Provider As String
    Public Feed As String
    Public BaseCurr As String
    Public ToCurr As String
    Public Change As String
    Public Spread As String
End Class

<DataContract()> _
Public Class GoxTick
    <DataMember(Name:="value", EmitDefaultValue:=False)> _
    Public value As String
    <DataMember(Name:="display", EmitDefaultValue:=False)> _
    Public display As String

End Class

<DataContract(Name:="data")> _
Public Class BitFinTicks
    <DataMember(Name:="high", EmitDefaultValue:=False)> _
    Public high As String
    <DataMember(Name:="low", EmitDefaultValue:=False)> _
    Public low As String
    <DataMember(Name:="avg", EmitDefaultValue:=False)> _
    Public avg As String
    <DataMember(Name:="vol", EmitDefaultValue:=False)> _
    Public vol As String
    <DataMember(Name:="bid", EmitDefaultValue:=False)> _
    Public bid As String
    <DataMember(Name:="ask", EmitDefaultValue:=False)> _
    Public ask As String
    <DataMember(Name:="buy", EmitDefaultValue:=False)> _
    Public buy As String
    <DataMember(Name:="sell", EmitDefaultValue:=False)> _
    Public sell As String
    Public Provider As String
    Public Feed As String
    Public BaseCurr As String
    Public ToCurr As String
    Public Change As String
    Public Spread As String
End Class



<DataContract()> _
Public Class Rates
    <DataMember(Name:="timestamp", EmitDefaultValue:=False)> _
    Public timestamp As String
    <DataMember(Name:="base", EmitDefaultValue:=False)> _
    Public base As String
    <DataMember(Name:="rates", EmitDefaultValue:=False)> _
    Public rates As RateList
End Class

<DataContract()> _
Public Class RateList
    <DataMember(Name:="USD", EmitDefaultValue:=False)> _
    Public USD As String
    <DataMember(Name:="GBP", EmitDefaultValue:=False)> _
    Public GBP As String
    <DataMember(Name:="CNY", EmitDefaultValue:=False)> _
    Public CNY As String
    <DataMember(Name:="EUR", EmitDefaultValue:=False)> _
    Public EUR As String
End Class


<DataContract()> _
Public Class BTCDepth
    <DataMember(Name:="asks", EmitDefaultValue:=False)> _
    Public asks As List(Of List(Of Single))
    <DataMember(Name:="bids", EmitDefaultValue:=False)> _
    Public bids As List(Of List(Of Single))
End Class

<DataContract()> _
Public Class PA
    <DataMember(EmitDefaultValue:=False)> _
    Public AskBids As List(Of Single)
End Class

<DataContract()> _
Public Class AskBid
    <DataMember(Name:="price", EmitDefaultValue:=False)> _
    Public price As String
    <DataMember(Name:="amount", EmitDefaultValue:=False)> _
    Public amount As String
End Class
