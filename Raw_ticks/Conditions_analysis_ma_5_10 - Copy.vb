Imports System.IO
Imports System.Threading

Public Class Conditions_analysis_ma_5_10

    Dim i_execute As Execute = New Execute
    Dim i_Auto_open_trade_parameters As Auto_open_trade_parameters = New Auto_open_trade_parameters

    Sub conditions_analysis_ma_5_over_10(ByVal ma_5_ticks As Double, ByVal ma_10_ticks As Double, ByVal ma_5_ticks_prior_per As Double, ByVal ma_10_ticks_prior_per As Double, VOLUME_TIME_SALES_arr() As String)

        Dim thrd_1 As Thread
        'Dim action_to_execute As String

        thrd_1 = New Thread(AddressOf i_execute.execute_in_ord_LMT)
        i_Auto_open_trade_parameters.Auto_open_trade_action = "BUY"
        i_Auto_open_trade_parameters.Auto_open_trade_price = CDbl(VOLUME_TIME_SALES_arr(0))

        If ma_5_ticks > ma_10_ticks And ma_5_ticks > ma_5_ticks_prior_per And ma_10_ticks > ma_10_ticks_prior_per And CDbl(VOLUME_TIME_SALES_arr(0)) > ma_5_ticks Then

            '-----Logging - Auto Trading
            'Dim str_wrt As StreamWriter = New StreamWriter("C:\Raw_Data\Logging _Auto_Trading\log.txt", True)
            'str_wrt.WriteLine("Long Entry Condition met" & vbNewLine & "ma_5_ticks=" & ma_5_ticks & vbNewLine & "ma_5_ticks_prior_per=" & ma_5_ticks_prior_per & vbNewLine & "ma_10_ticks=" & ma_10_ticks & vbNewLine &
            '"ma_10_ticks_prior_per=" & ma_10_ticks_prior_per & vbNewLine & "Last Price=" & VOLUME_TIME_SALES_arr(0) & vbNewLine)
            Debug.Print("Long Entry Condition met" & vbNewLine & "ma_5_ticks=" & ma_5_ticks & vbNewLine & "ma_5_ticks_prior_per=" & ma_5_ticks_prior_per & vbNewLine & "ma_10_ticks=" & ma_10_ticks & vbNewLine &
                              "ma_10_ticks_prior_per=" & ma_10_ticks_prior_per & vbNewLine & "Last Price=" & VOLUME_TIME_SALES_arr(0) & vbNewLine)
            'str_wrt.Close()

            'execute in trade
            thrd_1.Start(i_Auto_open_trade_parameters)

        End If

    End Sub


    Sub conditions_analysis_ma_5_under_10(ByVal ma_5_ticks As Double, ByVal ma_10_ticks As Double, ByVal ma_5_ticks_prior_per As Double, ByVal ma_10_ticks_prior_per As Double, VOLUME_TIME_SALES_arr() As String)

        Dim thrd_2 As Thread
        'Dim action_to_execute As String

        thrd_2 = New Thread(AddressOf i_execute.execute_in_ord_LMT)
        i_Auto_open_trade_parameters.Auto_open_trade_action = "SELL"
        i_Auto_open_trade_parameters.Auto_open_trade_price = CDbl(VOLUME_TIME_SALES_arr(0))

        If ma_5_ticks < ma_10_ticks And ma_5_ticks < ma_5_ticks_prior_per And ma_10_ticks < ma_10_ticks_prior_per And CDbl(VOLUME_TIME_SALES_arr(0)) < ma_5_ticks Then

            '-----Logging - Auto Trading
            'Dim str_wrt As StreamWriter = New StreamWriter("C:\Raw_Data\Logging _Auto_Trading\log.txt", True)
            'str_wrt.WriteLine("Short Entry Condition met" & vbNewLine & "ma_5_ticks=" & ma_5_ticks & vbNewLine & "ma_5_ticks_prior_per=" & ma_5_ticks_prior_per & vbNewLine & "ma_10_ticks=" & ma_10_ticks & vbNewLine &
            '"ma_10_ticks_prior_per=" & ma_10_ticks_prior_per & vbNewLine & "Last Price=" & VOLUME_TIME_SALES_arr(0) & vbNewLine)
            Debug.Print("Short Entry Condition met" & vbNewLine & "ma_5_ticks=" & ma_5_ticks & vbNewLine & "ma_5_ticks_prior_per=" & ma_5_ticks_prior_per & vbNewLine & "ma_10_ticks=" & ma_10_ticks & vbNewLine &
                              "ma_10_ticks_prior_per=" & ma_10_ticks_prior_per & vbNewLine & "Last Price=" & VOLUME_TIME_SALES_arr(0) & vbNewLine)
            'str_wrt.Close()

            'execute in trade
            thrd_2.Start(i_Auto_open_trade_parameters)

        End If

    End Sub

End Class
