Imports System.IO
'Imports System.Threading

Public Class Open_positions_cond_analysis_ma_5_10

    Dim i_execute As Execute = New Execute
    Dim i_Auto_close_trade_parameters As Auto_close_trade_parameters = New Auto_close_trade_parameters
    'Dim i_Data_Requests_Handlers_ma_5_10 As Data_Requests_Handlers_ma_5_10 = New Data_Requests_Handlers_ma_5_10
    Public ma_5_ticks_for_exit_calc As Double
    Public ma_10_ticks_for_exit_calc As Double
    Public price_for_exit_calc As Double

    '-----Logging - Auto Trading
    'Dim str_wrt_2 As StreamWriter = New StreamWriter("C:\Raw_Data\Logging _Auto_Trading\log.txt", True)

    Sub open_positions_cond_analysis_ma_5_over_10(ByVal ma_ticks_arr() As Double)

        'Dim thrd_close_position As Thread
        'Dim action_to_execute As String

        'TOTO This open position checker only closes long positions. Need to adjust "action" to handle exiting of short positions too.
        'thrd_close_position = New Thread(AddressOf i_execute.execute_out_ord_LMT)
        i_Auto_close_trade_parameters.Auto_close_trade_action = "SELL"
        i_Auto_close_trade_parameters.Auto_close_trade_price = price_for_exit_calc

        If ma_5_ticks_for_exit_calc < ma_10_ticks_for_exit_calc Then

            '-----Logging - Auto Trading
            'Dim str_wrt As StreamWriter = New StreamWriter("C:\Raw_Data\Logging _Auto_Trading\log.txt", True)

            'str_wrt.WriteLine("Long Exit Condition met" & vbNewLine & "ma_5_ticks_for_exit_calc=" & ma_5_ticks_for_exit_calc & vbNewLine & "ma_10_ticks_for_exit_calc=" _
            '& ma_10_ticks_for_exit_calc & vbNewLine & "Last Price=" & price_for_exit_calc & vbNewLine)
            Log_to_file.main_lbl = "Long Exit Condition met"
            Log_to_file.ma_5_ticks_for_exit_calc_lbl = "ma_5_ticks_for_exit_calc="
            Log_to_file.ma_10_ticks_for_exit_calc_lbl = "ma_10_ticks_for_exit_calc="
            Log_to_file.price_lbl = "Last Price="
            Log_to_file.Log_to_file_method(Nothing, price_for_exit_calc, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, ma_5_ticks_for_exit_calc, ma_10_ticks_for_exit_calc)

            Debug.Print("Long Exit Condition met" & vbNewLine & "ma_5_ticks_for_exit_calc=" & ma_5_ticks_for_exit_calc & vbNewLine & "ma_10_ticks_for_exit_calc=" _
                              & ma_10_ticks_for_exit_calc & vbNewLine & "Last Price=" & price_for_exit_calc & vbNewLine)

            'str_wrt.Close()

            Data_Requests_Handlers_ma_5_10.first_exit_trade = True

            Call i_execute.execute_out_ord_LMT(i_Auto_close_trade_parameters)
            'thrd_close_position.Start(i_Auto_close_trade_parameters)

        End If

    End Sub

End Class
