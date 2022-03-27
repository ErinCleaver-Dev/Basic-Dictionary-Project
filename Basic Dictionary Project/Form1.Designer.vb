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
        Me.bntCreateFile = New System.Windows.Forms.Button()
        Me.bntOpenFile = New System.Windows.Forms.Button()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.bntAdd = New System.Windows.Forms.Button()
        Me.bntRemove = New System.Windows.Forms.Button()
        Me.bntCheck = New System.Windows.Forms.Button()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bntCreateFile
        '
        Me.bntCreateFile.Location = New System.Drawing.Point(106, 93)
        Me.bntCreateFile.Name = "bntCreateFile"
        Me.bntCreateFile.Size = New System.Drawing.Size(89, 54)
        Me.bntCreateFile.TabIndex = 0
        Me.bntCreateFile.Text = "Create File"
        Me.bntCreateFile.UseVisualStyleBackColor = True
        '
        'bntOpenFile
        '
        Me.bntOpenFile.Location = New System.Drawing.Point(106, 163)
        Me.bntOpenFile.Name = "bntOpenFile"
        Me.bntOpenFile.Size = New System.Drawing.Size(89, 54)
        Me.bntOpenFile.TabIndex = 1
        Me.bntOpenFile.Text = "Open File"
        Me.bntOpenFile.UseVisualStyleBackColor = True
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 15
        Me.lstInventory.Location = New System.Drawing.Point(214, 93)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(247, 289)
        Me.lstInventory.TabIndex = 2
        '
        'bntAdd
        '
        Me.bntAdd.Location = New System.Drawing.Point(502, 93)
        Me.bntAdd.Name = "bntAdd"
        Me.bntAdd.Size = New System.Drawing.Size(89, 54)
        Me.bntAdd.TabIndex = 3
        Me.bntAdd.Text = "Add"
        Me.bntAdd.UseVisualStyleBackColor = True
        '
        'bntRemove
        '
        Me.bntRemove.Location = New System.Drawing.Point(502, 163)
        Me.bntRemove.Name = "bntRemove"
        Me.bntRemove.Size = New System.Drawing.Size(89, 54)
        Me.bntRemove.TabIndex = 4
        Me.bntRemove.Text = "Remove"
        Me.bntRemove.UseVisualStyleBackColor = True
        '
        'bntCheck
        '
        Me.bntCheck.Location = New System.Drawing.Point(502, 233)
        Me.bntCheck.Name = "bntCheck"
        Me.bntCheck.Size = New System.Drawing.Size(89, 54)
        Me.bntCheck.TabIndex = 5
        Me.bntCheck.Text = "Check"
        Me.bntCheck.UseVisualStyleBackColor = True
        '
        'bntExit
        '
        Me.bntExit.Location = New System.Drawing.Point(502, 304)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(89, 54)
        Me.bntExit.TabIndex = 6
        Me.bntExit.Text = "Exit"
        Me.bntExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(377, 67)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 15)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Product Name"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(377, 39)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 15)
        Me.lblId.TabIndex = 8
        Me.lblId.Text = "id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(504, 35)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 9
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(504, 64)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(208, 23)
        Me.txtProductName.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.bntExit)
        Me.Controls.Add(Me.bntCheck)
        Me.Controls.Add(Me.bntRemove)
        Me.Controls.Add(Me.bntAdd)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.bntOpenFile)
        Me.Controls.Add(Me.bntCreateFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bntCreateFile As Button
    Friend WithEvents bntOpenFile As Button
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents bntAdd As Button
    Friend WithEvents bntRemove As Button
    Friend WithEvents bntCheck As Button
    Friend WithEvents bntExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtProductName As TextBox
End Class
