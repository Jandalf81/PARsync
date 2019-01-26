<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SyncDecision
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_UseLocalRating = New System.Windows.Forms.Button()
        Me.btn_UseRemoteRating = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please decide which rating to use for this track"
        '
        'btn_UseLocalRating
        '
        Me.btn_UseLocalRating.Location = New System.Drawing.Point(30, 227)
        Me.btn_UseLocalRating.Name = "btn_UseLocalRating"
        Me.btn_UseLocalRating.Size = New System.Drawing.Size(75, 23)
        Me.btn_UseLocalRating.TabIndex = 1
        Me.btn_UseLocalRating.Text = "btn_UseLocalRating"
        Me.btn_UseLocalRating.UseVisualStyleBackColor = True
        '
        'btn_UseRemoteRating
        '
        Me.btn_UseRemoteRating.Location = New System.Drawing.Point(192, 226)
        Me.btn_UseRemoteRating.Name = "btn_UseRemoteRating"
        Me.btn_UseRemoteRating.Size = New System.Drawing.Size(75, 23)
        Me.btn_UseRemoteRating.TabIndex = 2
        Me.btn_UseRemoteRating.Text = "btn_UseRemoteRating"
        Me.btn_UseRemoteRating.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(334, 226)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "btn_Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'frm_SyncDecision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(566, 372)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_UseRemoteRating)
        Me.Controls.Add(Me.btn_UseLocalRating)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_SyncDecision"
        Me.ShowInTaskbar = False
        Me.Text = "PARsync - Sync Decision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_UseLocalRating As Button
    Friend WithEvents btn_UseRemoteRating As Button
    Friend WithEvents btn_Cancel As Button
End Class
