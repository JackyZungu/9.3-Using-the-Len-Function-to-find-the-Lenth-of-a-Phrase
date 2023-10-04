<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnShow = New Button()
        SuspendLayout()
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(294, 191)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(132, 68)
        btnShow.TabIndex = 0
        btnShow.Text = "Show"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnShow)
        Name = "Form1"
        Text = "Using the Len Function to find the Lenth of a Phrase"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnShow As Button
End Class
