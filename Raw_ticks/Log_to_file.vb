Imports System.IO

Public Class Log_to_file
    Public Shared main_lbl As String
    Public Shared i_ordr_Action_lbl As String
    Public Shared price_lbl As String
    Public Shared i_ordr_Quantity_lbl As String
    Public Shared i_ordr_OrderType_lbl As String
    Public Shared orderId_lbl As String
    Public Shared status_lbl As String
    Public Shared ma_5_ticks_lbl As String
    Public Shared ma_5_ticks_prior_per_lbl As String
    Public Shared ma_10_ticks_lbl As String
    Public Shared ma_10_ticks_prior_per_lbl As String
    Public Shared ma_5_ticks_for_exit_calc_lbl As String
    Public Shared ma_10_ticks_for_exit_calc_lbl As String


    Public Shared Sub Log_to_file_method(Action As String, price As Double, Quantity As Integer, OrderType As String, orderId As Integer, status As String, ma_5_ticks As Double, ma_5_ticks_prior_per As Double, ma_10_ticks As Double,
                                         ma_10_ticks_prior_per As Double, ma_5_ticks_for_exit_calc As Double, ma_10_ticks_for_exit_calc As Double)

        'Dim str_wrt As StreamWriter = New StreamWriter("C:\Raw_Data\Logging _Auto_Trading\log.txt", True)

        Open_str_wrt.str_wrt.WriteLine(main_lbl & vbNewLine & "Contract=" & Functions.cntrt.Symbol & vbNewLine & i_ordr_Action_lbl & Action & vbNewLine & price_lbl & price & vbNewLine & i_ordr_Quantity_lbl _
            & Quantity & vbNewLine & i_ordr_OrderType_lbl & OrderType & vbNewLine & orderId_lbl & orderId & vbNewLine & status_lbl & status & vbNewLine & ma_5_ticks_lbl & ma_5_ticks & vbNewLine & ma_5_ticks_prior_per_lbl & ma_5_ticks_prior_per &
            vbNewLine & ma_10_ticks_lbl & ma_10_ticks & vbNewLine & ma_10_ticks_prior_per_lbl & ma_10_ticks_prior_per & vbNewLine & vbNewLine & ma_5_ticks_for_exit_calc_lbl & ma_5_ticks_for_exit_calc & vbNewLine &
            ma_10_ticks_for_exit_calc_lbl & ma_10_ticks_for_exit_calc & vbNewLine)

        'str_wrt.Close()

    End Sub

End Class
