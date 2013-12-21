Imports System.Collections.Concurrent

Public Class TickerCtl
    Public Tickers As ConcurrentQueue(Of Eticker)
    Public LastBuy As String
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Tickers = New ConcurrentQueue(Of Eticker)
        'For i = 0 To 999            Tickers.Enqueue(New Eticker With {.buy = 1000, .sell = 1000})

    End Sub
    Private _USDVal As Single
    Public Property USD() As Single
        Get
            Return _USDVal
        End Get
        Set(ByVal value As Single)
            _USDVal = value
        End Set
    End Property
    Private _Convert As Boolean
    Public Property ConvertVal() As Boolean
        Get
            Return _Convert
        End Get
        Set(ByVal value As Boolean)
            _Convert = value
        End Set
    End Property

    Delegate Sub SetTextCallback(etick As Eticker)

    Public Sub SetText(etick As Eticker)
        If lblBuy.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {etick})
        Else
            '  lbName.Text = etick.BaseCurr & "/" & etick.ToCurr
            lblBuy.Text = etick.buy
            LBSpread.Text = FormatNumber(etick.Spread, 5)
            LBVolume.Text = FormatNumber(etick.vol, 0)
            LBChange.Text = FormatNumber(etick.Change, 5)
            LBProvider.Text = etick.Provider
            Dim changeSTR As String = FormatNumber(etick.Change, 5)
            If CSng(changeSTR) = 0 Then LBChange.BackColor = Color.Transparent
            If CSng(changeSTR) > 0 Then LBChange.BackColor = Color.LightGreen
            If CSng(changeSTR) < 0 Then LBChange.BackColor = Color.Red

        End If
    End Sub

    Public Sub UpdateTicker(etick As Eticker)

        If num(etick.buy) = "0" Then
            etick.buy = etick.min_ask
        End If
        If num(etick.sell) = "0" Then
            etick.sell = etick.max_bid
        End If
        If num(etick.vol) = "0" Then
            etick.vol = etick.vol_usd
        End If
        Dim buy As Single
        Single.TryParse(etick.buy, buy)
        Dim spread As Single
        Dim sell As Single
        Single.TryParse(etick.sell, sell)
        spread = Math.Abs(buy - sell)
        Dim previousBuy As Single
        Single.TryParse(LastBuy, previousBuy)
        If ConvertVal Then
            buy = (buy / USD)
        End If
        Dim change As Single = buy - previousBuy
        etick.buy = buy
        LastBuy = buy
        etick.Change = change
        etick.Spread = spread
        Tickers.Enqueue(etick)
        Dim tick As Eticker
        If Tickers.Count > 200 Then
            Tickers.TryDequeue(tick)
        End If
        Me.SetText(etick)
    End Sub

    Public Sub UpdateTicker(gtick As GoxTicks)
        Dim et As New Eticker
        et.buy = gtick.buy.value
        et.sell = gtick.sell.value
        et.vol = gtick.vol.value
        et.BaseCurr = gtick.BaseCurr
        et.ToCurr = gtick.ToCurr
        et.Provider = gtick.Provider
        UpdateTicker(et)
    End Sub

    Public Sub UpdateTicker(gtick As BitFinTicks)
        Dim et As New Eticker
        et.buy = gtick.ask
        et.sell = gtick.bid
        et.vol = gtick.vol
        et.BaseCurr = gtick.BaseCurr
        et.ToCurr = gtick.ToCurr
        et.Provider = gtick.Provider
        UpdateTicker(et)
    End Sub

    Public Shared Function dbn(ByVal obj As Object) As Object
        If obj Is Nothing Then
            Return New String("")
        Else
            If IsDBNull(obj) Then
                Return New String("")
            Else
                Return obj.ToString
            End If
        End If
    End Function
    Public Shared Function num(ByVal obj As Object) As String
        If obj Is Nothing Then
            Return "0"
        Else
            If IsDBNull(obj) Then
                Return "0"
            Else
                If IsNumeric(obj.ToString) Then
                    Return obj.ToString
                Else
                    Return "0"
                End If

            End If
        End If
    End Function
End Class
