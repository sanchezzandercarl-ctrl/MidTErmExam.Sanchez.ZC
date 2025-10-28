<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmbArtworkCategory = New System.Windows.Forms.ComboBox()
        Me.txtArtworkTitle = New System.Windows.Forms.TextBox()
        Me.txtArtistName = New System.Windows.Forms.TextBox()
        Me.nudArtworkPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnAddWork = New System.Windows.Forms.Button()
        Me.btnAnalizeExhibit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lsbDetails = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.nudArtworkPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(89, 26)
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.UpToolStripMenuItem.Text = "up"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.Name = "ContextMenuStrip5"
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(61, 4)
        '
        'cmbArtworkCategory
        '
        Me.cmbArtworkCategory.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.cmbArtworkCategory.FormattingEnabled = True
        Me.cmbArtworkCategory.Items.AddRange(New Object() {"Painting", "Sculpture", "Digital Art", "photography", "Craft"})
        Me.cmbArtworkCategory.Location = New System.Drawing.Point(12, 12)
        Me.cmbArtworkCategory.Name = "cmbArtworkCategory"
        Me.cmbArtworkCategory.Size = New System.Drawing.Size(317, 21)
        Me.cmbArtworkCategory.TabIndex = 7
        Me.cmbArtworkCategory.Text = "Select Category"
        '
        'txtArtworkTitle
        '
        Me.txtArtworkTitle.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtArtworkTitle.Location = New System.Drawing.Point(12, 39)
        Me.txtArtworkTitle.Multiline = True
        Me.txtArtworkTitle.Name = "txtArtworkTitle"
        Me.txtArtworkTitle.Size = New System.Drawing.Size(317, 69)
        Me.txtArtworkTitle.TabIndex = 8
        Me.txtArtworkTitle.Text = "Add Title"
        '
        'txtArtistName
        '
        Me.txtArtistName.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtArtistName.Location = New System.Drawing.Point(12, 114)
        Me.txtArtistName.Multiline = True
        Me.txtArtistName.Name = "txtArtistName"
        Me.txtArtistName.Size = New System.Drawing.Size(317, 69)
        Me.txtArtistName.TabIndex = 9
        Me.txtArtistName.Text = "Add Name"
        '
        'nudArtworkPrice
        '
        Me.nudArtworkPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.nudArtworkPrice.Location = New System.Drawing.Point(12, 189)
        Me.nudArtworkPrice.Name = "nudArtworkPrice"
        Me.nudArtworkPrice.Size = New System.Drawing.Size(114, 20)
        Me.nudArtworkPrice.TabIndex = 10
        '
        'btnAddWork
        '
        Me.btnAddWork.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddWork.Location = New System.Drawing.Point(12, 263)
        Me.btnAddWork.Name = "btnAddWork"
        Me.btnAddWork.Size = New System.Drawing.Size(114, 34)
        Me.btnAddWork.TabIndex = 11
        Me.btnAddWork.Text = "ADD WORK"
        Me.btnAddWork.UseVisualStyleBackColor = False
        '
        'btnAnalizeExhibit
        '
        Me.btnAnalizeExhibit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAnalizeExhibit.Location = New System.Drawing.Point(12, 303)
        Me.btnAnalizeExhibit.Name = "btnAnalizeExhibit"
        Me.btnAnalizeExhibit.Size = New System.Drawing.Size(114, 34)
        Me.btnAnalizeExhibit.TabIndex = 16
        Me.btnAnalizeExhibit.Text = "ANALIZE EXHIBIT"
        Me.btnAnalizeExhibit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClear.Location = New System.Drawing.Point(12, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 34)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lsbDetails
        '
        Me.lsbDetails.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lsbDetails.FormattingEnabled = True
        Me.lsbDetails.Items.AddRange(New Object() {"Sunrise Bloom", "Metal Dreams", "Pexel Heart"})
        Me.lsbDetails.Location = New System.Drawing.Point(132, 189)
        Me.lsbDetails.Name = "lsbDetails"
        Me.lsbDetails.Size = New System.Drawing.Size(197, 225)
        Me.lsbDetails.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 428)
        Me.Controls.Add(Me.lsbDetails)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAnalizeExhibit)
        Me.Controls.Add(Me.btnAddWork)
        Me.Controls.Add(Me.nudArtworkPrice)
        Me.Controls.Add(Me.txtArtistName)
        Me.Controls.Add(Me.txtArtworkTitle)
        Me.Controls.Add(Me.cmbArtworkCategory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.nudArtworkPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents UpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents cmbArtworkCategory As ComboBox
    Friend WithEvents txtArtworkTitle As TextBox
    Friend WithEvents txtArtistName As TextBox
    Friend WithEvents nudArtworkPrice As NumericUpDown
    Friend WithEvents btnAddWork As Button
    Friend WithEvents btnAnalizeExhibit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lsbDetails As ListBox
End Class
