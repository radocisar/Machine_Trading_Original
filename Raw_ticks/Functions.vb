Public Class Functions

    Public Shared Function cntrt() As IBApi.Contract

        Dim i_cntrt As IBApi.Contract
        i_cntrt = New IBApi.Contract

        'Dim mktDataOptions As IBApi.TagValue
        'Dim m_mtkDataOptions As List(Of IBApi.TagValue)

        'i_cntrt.Symbol = "SPY"
        'i_cntrt.SecType = "STK"
        'i_cntrt.Currency = "USD"
        'i_cntrt.Exchange = "SMART"
        'i_cntrt.Strike = 0
        'i_cntrt.IncludeExpired = 0

        i_cntrt.Symbol = "EUR"
        i_cntrt.SecType = "CASH"
        i_cntrt.Currency = "USD"
        i_cntrt.Exchange = "IDEALPRO"
        'i_cntrt.Strike = 0
        'i_cntrt.IncludeExpired = 0

        cntrt = i_cntrt

    End Function

    Public Shared Function ordr(ByVal action As String, ByVal quantity As Double, ByVal ord_prc As Double) As IBApi.Order

        Dim i_ordr As IBApi.Order
        i_ordr = New IBApi.Order

        i_ordr.Action = action
        i_ordr.OrderType = "LMT"
        i_ordr.LmtPrice = ord_prc
        i_ordr.TotalQuantity = quantity

        ordr = i_ordr

    End Function


End Class
