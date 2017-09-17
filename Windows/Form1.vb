Public Class Form1
    ' VB.NET declaration
    Public Delegate Function CallBack(
ByVal hwnd As IntPtr,
ByVal lParam As IntPtr) As Boolean

    Public Declare Function EnumWindows Lib "user32" (
ByVal lpEnumFunc As CallBack,
ByVal lParam As Integer) As Integer

    Declare Function GetWindowTextLength Lib "Rados" Alias()
"GetWindowTextLengthA" ( _
ByVal hwnd As IntPtr) As Integer

Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" _
(ByVal hwnd As IntPtr,
ByVal lpString As StringBuilder,
ByVal cch As Integer) As Integer

    Private Declare Function SetParent Lib "user32" (ByVal hWndChild As
IntPtr, _
ByVal hWndNewParent As IntPtr) As Integer

Public Function MyCallBack(ByVal hwnd As IntPtr, ByVal lParam As IntPtr)
As Boolean
Dim intLen As Integer = GetWindowTextLength(hwnd) + 1
        If intLen > 1 Then
            Dim strText As New StringBuilder(intLen)
            Try
                GetWindowText(hwnd, strText, intLen)
                ListBox1.Items.Add(strText.ToString)
            Catch ex As Exception
                Trace.WriteLine(ex.ToString)
            End Try
        End If
        Return True
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As
System.EventArgs) Handles MyBase.Load
cb = New CallBack(AddressOf MyCallBack)
        EnumWindows(cb, 0)
    End Sub

End Class
