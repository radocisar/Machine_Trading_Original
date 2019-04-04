Imports System.IO
Imports System.Threading

Public Class Data_Requests_Handlers_Bollinger_Bands

    Private BID_price As Double
    Private ASK_price As Double

    Sub mm_price_return_handler(tickerId As Integer, field As Integer, price As Double, canAutoExecute As Integer)

        Dim upper_band As Double
        Dim lower_band As Double
        Dim middle_band As Double

        Select Case field
            Case 1
                'tick_type = "BID"
                BID_price = price
            Case 2
                'tick_type = "ASK"
                ASK_price = price
            Case 6
                'tick_type = "HIGH"
                Exit Sub
            Case 7
                'tick_type = "LOW"
                Exit Sub
            Case 9
                'tick_type = "CLOSE"
                Exit Sub
        End Select


    End Sub

End Class
