Public Class Auto_open_trade_parameters

    Dim open_trade_action As String
    Dim open_trade_price As Double

    Public Property Auto_open_trade_action As String

        Get
            Return open_trade_action
        End Get

        Set(ByVal value As String)
            open_trade_action = value
        End Set

    End Property

    Public Property Auto_open_trade_size As Integer

        Get
            Select Case Functions.cntrt.SecType
                Case "STOCK"
                    Return 100
                Case "CASH"
                    Return 10000
                Case Else
                    Return 100
            End Select

        End Get

        Set

        End Set

    End Property

    Public Property Auto_open_trade_price As Double

        Get
            Return Math.Round(open_trade_price, 4, MidpointRounding.AwayFromZero)
        End Get

        Set(ByVal value As Double)
            open_trade_price = value
        End Set

    End Property


End Class
