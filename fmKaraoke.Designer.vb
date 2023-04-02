<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmKaraoke))
        Me.picKaraoke = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.cboSelectionAction = New System.Windows.Forms.ComboBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picKaraoke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picKaraoke
        '
        Me.picKaraoke.Image = CType(resources.GetObject("picKaraoke.Image"), System.Drawing.Image)
        Me.picKaraoke.Location = New System.Drawing.Point(1, -2)
        Me.picKaraoke.Name = "picKaraoke"
        Me.picKaraoke.Size = New System.Drawing.Size(970, 548)
        Me.picKaraoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKaraoke.TabIndex = 0
        Me.picKaraoke.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(626, 52)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(51, 17)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Label1"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(626, 230)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(51, 17)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Label2"
        '
        'cboSelectionAction
        '
        Me.cboSelectionAction.FormattingEnabled = True
        Me.cboSelectionAction.Location = New System.Drawing.Point(597, 143)
        Me.cboSelectionAction.Name = "cboSelectionAction"
        Me.cboSelectionAction.Size = New System.Drawing.Size(121, 24)
        Me.cboSelectionAction.TabIndex = 3
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(626, 429)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(51, 17)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Label3"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(597, 310)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 22)
        Me.txtValue.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(396, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 557)
        Me.Panel1.TabIndex = 6
        '
        'fmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 547)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.cboSelectionAction)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picKaraoke)
        Me.Name = "fmKaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Night Rental"
        CType(Me.picKaraoke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picKaraoke As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents cboSelectionAction As ComboBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Panel1 As Panel
End Class
