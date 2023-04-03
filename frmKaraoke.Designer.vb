<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaraoke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.picKaraoke = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.cboSelectionAction = New System.Windows.Forms.ComboBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnValue = New System.Windows.Forms.Button()
        CType(Me.picKaraoke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(80, 41)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(363, 51)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Karaoke Night Rental"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Black
        Me.lblInstructions.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(47, 218)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(429, 62)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Please enter the number of xxxx"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSelectionAction
        '
        Me.cboSelectionAction.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectionAction.FormattingEnabled = True
        Me.cboSelectionAction.Items.AddRange(New Object() {"Rent $2.99 Per Song", "Rent $8.99 Per Hour"})
        Me.cboSelectionAction.Location = New System.Drawing.Point(96, 137)
        Me.cboSelectionAction.Name = "cboSelectionAction"
        Me.cboSelectionAction.Size = New System.Drawing.Size(330, 35)
        Me.cboSelectionAction.TabIndex = 3
        Me.cboSelectionAction.Text = "Rental Selection"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(126, 459)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(272, 61)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "$XXXXXX"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(227, 319)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(69, 34)
        Me.txtValue.TabIndex = 5
        Me.txtValue.Text = "XX"
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnValue)
        Me.Panel1.Controls.Add(Me.txtValue)
        Me.Panel1.Controls.Add(Me.lblHeading)
        Me.Panel1.Controls.Add(Me.cboSelectionAction)
        Me.Panel1.Controls.Add(Me.lblTotalCost)
        Me.Panel1.Controls.Add(Me.lblInstructions)
        Me.Panel1.Location = New System.Drawing.Point(396, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 557)
        Me.Panel1.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(298, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 51)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnValue
        '
        Me.btnValue.BackColor = System.Drawing.Color.LightGray
        Me.btnValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValue.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValue.Location = New System.Drawing.Point(61, 390)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(173, 51)
        Me.btnValue.TabIndex = 6
        Me.btnValue.Text = "Calculate"
        Me.btnValue.UseVisualStyleBackColor = False
        '
        'frmKaraoke
        '
        Me.AcceptButton = Me.btnValue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(919, 547)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picKaraoke)
        Me.Name = "frmKaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Night Rental"
        CType(Me.picKaraoke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picKaraoke As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents cboSelectionAction As ComboBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnValue As Button
End Class
