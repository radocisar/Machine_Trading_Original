Imports IBApi
Imports System.Threading

Public Class Connect

    Public Shared wrapper_imp As EWrapperImpl = New EWrapperImpl
    Public socket_client As EClientSocket = wrapper_imp.socketClient
    Public Shared bool As Boolean

    Private WithEvents Wrapper_events As New EWrapperImpl

    'AddHandler() wrapper_events.on_current_time, AddressOf show_time

    Public Sub connect()

        socket_client.eConnect("127.0.0.1", 7496, 1111530)
        'socket_client.eConnect("127.0.0.1", 7496, 0)

        Dim msgThread As Thread = New Thread(AddressOf messageProcessing)
        msgThread.IsBackground = True
        If wrapper_imp.socketClient.IsConnected Then
            Call msgThread.Start()
        End If

    End Sub

    Private Sub messageProcessing()
        Dim reader As EReader = New EReader(wrapper_imp.socketClient, wrapper_imp.eReaderSignal)
        reader.Start()
        While (wrapper_imp.socketClient.IsConnected)
            wrapper_imp.eReaderSignal.waitForSignal()
            reader.processMsgs()
        End While
    End Sub

    'Public Sub req_current_time()
    'Public Sub req_current_time()

    '    '** Request TWS' current time ***
    '    'Me.socket_client.reqCurrentTime()

    '    socket_client.reqCurrentTime()
    '    '** Setting TWS logging level  ***
    '    'client.setServerLogLevel(1)
    'End Sub

    'Public Sub req_data()

    '    Dim cntrt As IBApi.Contract
    '    cntrt = New IBApi.Contract

    '    'Dim mktDataOptions As IBApi.TagValue
    '    'Dim m_mtkDataOptions As List(Of IBApi.TagValue)

    '    cntrt.Symbol = "EUR"
    '    cntrt.SecType = "CASH"
    '    cntrt.Currency = "USD"
    '    cntrt.Exchange = "IDEALPRO"
    '    cntrt.Strike = 0
    '    cntrt.IncludeExpired = 0
    '    socket_client.reqMktData(11, cntrt, String.Empty, False, Nothing)

    'End Sub

End Class
