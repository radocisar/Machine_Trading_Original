<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download_Ticks_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_req_time = New System.Windows.Forms.Button()
        Me.btn_download_raw_ticks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(33, 26)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(75, 23)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'btn_req_time
        '
        Me.btn_req_time.Location = New System.Drawing.Point(33, 68)
        Me.btn_req_time.Name = "btn_req_time"
        Me.btn_req_time.Size = New System.Drawing.Size(75, 23)
        Me.btn_req_time.TabIndex = 1
        Me.btn_req_time.Text = "Request Time"
        Me.btn_req_time.UseVisualStyleBackColor = True
        '
        'btn_download_raw_ticks
        '
        Me.btn_download_raw_ticks.Location = New System.Drawing.Point(33, 111)
        Me.btn_download_raw_ticks.Name = "btn_download_raw_ticks"
        Me.btn_download_raw_ticks.Size = New System.Drawing.Size(93, 23)
        Me.btn_download_raw_ticks.TabIndex = 2
        Me.btn_download_raw_ticks.Text = "Download Ticks"
        Me.btn_download_raw_ticks.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_download_raw_ticks)
        Me.Controls.Add(Me.btn_req_time)
        Me.Controls.Add(Me.btn_connect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_req_time As Button
    Friend WithEvents btn_download_raw_ticks As Button
End Class
