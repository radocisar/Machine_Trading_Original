Imports IBApi


Public Class Current_time

    Private WithEvents Wrapper_events As New EWrapperImpl

    Public Sub req_current_time()

        '** Request TWS' current time ***
        'Me.socket_client.reqCurrentTime()

        Form1.cnnt_cls.socket_client.reqCurrentTime()

        '** Setting TWS logging level  ***
        'client.setServerLogLevel(1)
    End Sub


    Sub show_time_handler(time As Long) Handles Wrapper_events.on_current_time

        Dim dt As DateTime

        dt = New DateTime(1970, 1, 1, 0, 0, 0)

        dt = dt.AddSeconds(time)

        MsgBox(dt)

    End Sub

End Class
