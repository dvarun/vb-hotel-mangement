<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_BACK = New System.Windows.Forms.Button()
        Me.lbl_Normal = New System.Windows.Forms.Label()
        Me.lbl_del = New System.Windows.Forms.Label()
        Me.lbl_exec = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(134, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Availability"
        '
        'btn_BACK
        '
        Me.btn_BACK.Location = New System.Drawing.Point(171, 222)
        Me.btn_BACK.Name = "btn_BACK"
        Me.btn_BACK.Size = New System.Drawing.Size(111, 41)
        Me.btn_BACK.TabIndex = 2
        Me.btn_BACK.Text = "BACK"
        Me.btn_BACK.UseVisualStyleBackColor = True
        '
        'lbl_Normal
        '
        Me.lbl_Normal.AutoSize = True
        Me.lbl_Normal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Normal.Location = New System.Drawing.Point(78, 78)
        Me.lbl_Normal.Name = "lbl_Normal"
        Me.lbl_Normal.Size = New System.Drawing.Size(82, 26)
        Me.lbl_Normal.TabIndex = 3
        Me.lbl_Normal.Text = "Normal:"
        '
        'lbl_del
        '
        Me.lbl_del.AutoSize = True
        Me.lbl_del.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_del.Location = New System.Drawing.Point(78, 108)
        Me.lbl_del.Name = "lbl_del"
        Me.lbl_del.Size = New System.Drawing.Size(78, 26)
        Me.lbl_del.TabIndex = 4
        Me.lbl_del.Text = "Deluxe:"
        '
        'lbl_exec
        '
        Me.lbl_exec.AutoSize = True
        Me.lbl_exec.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exec.Location = New System.Drawing.Point(59, 137)
        Me.lbl_exec.Name = "lbl_exec"
        Me.lbl_exec.Size = New System.Drawing.Size(101, 26)
        Me.lbl_exec.TabIndex = 5
        Me.lbl_exec.Text = "Executive:"
        '
        'Avail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 310)
        Me.Controls.Add(Me.lbl_exec)
        Me.Controls.Add(Me.lbl_del)
        Me.Controls.Add(Me.lbl_Normal)
        Me.Controls.Add(Me.btn_BACK)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Avail"
        Me.Text = "Avail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_BACK As System.Windows.Forms.Button
    Friend WithEvents lbl_Normal As System.Windows.Forms.Label
    Friend WithEvents lbl_del As System.Windows.Forms.Label
    Friend WithEvents lbl_exec As System.Windows.Forms.Label
End Class
