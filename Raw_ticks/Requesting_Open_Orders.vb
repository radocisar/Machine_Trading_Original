Imports IBApi
Imports System.Threading

Public Class Requesting_Open_Orders

    Dim WithEvents wrapper_events As New EWrapperImpl
    Public req_next_ord_ID_bool As Boolean
    Public next_ord_ID_for_trading As Integer

#Region "Orders Raisers"

    Public Sub req_next_ord_ID()

        Form1.cnnt_cls.socket_client.reqIds(-1)

    End Sub

    Public Sub req_open_ords()

        Form1.cnnt_cls.socket_client.reqOpenOrders()

    End Sub

    Public Sub req_TWS_open_ords()

        Form1.cnnt_cls.socket_client.reqAutoOpenOrders(False)

    End Sub

    'Public Sub submit_ords(ByVal action As String, ByVal quantity As Double, ByVal ord_prc As Double)

    '    'Form1.cnnt_cls.socket_client.placeOrder(Interlocked.Increment(Form1.cnnt_cls.wrapper_imp.nextOrderId), Functions.cntrt, Functions.ordr(action, quantity, ord_prc))
    '    Form1.cnnt_cls.socket_client.placeOrder(Form1.cnnt_cls.wrapper_imp.nextOrderId, Functions.cntrt, Functions.ordr(action, quantity, ord_prc))

    'End Sub

    Public Sub cancel_ords(ByVal orderID As Integer)

        Form1.cnnt_cls.socket_client.cancelOrder(orderID)

    End Sub
#End Region

#Region "Orders Handlers"

    Sub next_valid_ID_handler(next_order_ID As Integer) Handles wrapper_events.on_next_valid_id_return

        If req_next_ord_ID_bool = True Then
            next_ord_ID_for_trading = next_order_ID
        Else
            MsgBox("Next Valid ID: " & next_order_ID)
        End If

    End Sub

    Sub open_ords_handler(orderId As Integer, contract As IBApi.Contract, order As IBApi.Order, orderState As IBApi.OrderState) Handles wrapper_events.on_open_ords

        'For testing
        'MsgBox("Open Orders:" & vbCrLf & "OpenOrder ID: " & orderId & vbCrLf & contract.Symbol & vbCrLf & contract.SecType & vbCrLf & contract.Exchange &
        'vbCrLf & order.Action & vbCrLf & order.OrderType & vbCrLf & order.TotalQuantity & vbCrLf & orderState.Status)

    End Sub

    'Sub ords_stts_handler(orderId As Integer, status As String, filled As Double, remaining As Double, avgFillPrice As Double, permId As Integer,
    '                      parentId As Integer, lastFillPrice As Double, clientId As Integer, whyHeld As String) Handles wrapper_events.on_ords_status

    '    MsgBox("Order Status:" & vbCrLf & "OrderStatus Id: " & orderId & vbCrLf & "Status: " & status & vbCrLf & "Filled: " & filled & vbCrLf & "Remaining: " & remaining &
    '           vbCrLf & "AvgFillPrice: " & avgFillPrice & vbCrLf & "PermId: " & permId & vbCrLf & "ParentId: " & parentId & vbCrLf & "LastFillPrice: " & lastFillPrice &
    '            vbCrLf & "ClientId: " & clientId & vbCrLf & "WhyHeld: " & whyHeld)

    'End Sub

    Sub ords_end_handler() Handles wrapper_events.on_open_ords_end

        MsgBox("All orders received")

    End Sub

    'Sub exec_details_handler(reqId As Integer, contract As IBApi.Contract, execution As IBApi.Execution) Handles wrapper_events.on_exec_details

    '    MsgBox("ExecDetails:" & vbCrLf & "Req ID: " & reqId & vbCrLf & contract.Symbol & vbCrLf & contract.SecType & vbCrLf & "Price: " & execution.Price & vbCrLf & execution.Exchange)

    'End Sub

    'Sub cmssn_rpt_handler(commissionReport As IBApi.CommissionReport) Handles wrapper_events.on_cmssn_rpt

    '    MsgBox("CommissionReport:" & vbCrLf & "Commission: " & commissionReport.Currency & " " & commissionReport.Commission)

    'End Sub

#End Region

End Class
