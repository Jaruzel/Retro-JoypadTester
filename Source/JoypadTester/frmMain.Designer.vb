<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.btnSelect = New System.Windows.Forms.Button
    Me.txtDir = New System.Windows.Forms.TextBox
    Me.txtButtons = New System.Windows.Forms.TextBox
    Me.timerPoll = New System.Windows.Forms.Timer(Me.components)
    Me.ComboBox1 = New System.Windows.Forms.ComboBox
    Me.btnScan = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnSelect
    '
    Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSelect.Location = New System.Drawing.Point(653, 11)
    Me.btnSelect.Name = "btnSelect"
    Me.btnSelect.Size = New System.Drawing.Size(99, 27)
    Me.btnSelect.TabIndex = 0
    Me.btnSelect.Text = "Select Device"
    Me.btnSelect.UseVisualStyleBackColor = True
    '
    'txtDir
    '
    Me.txtDir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDir.Location = New System.Drawing.Point(12, 55)
    Me.txtDir.Multiline = True
    Me.txtDir.Name = "txtDir"
    Me.txtDir.Size = New System.Drawing.Size(740, 534)
    Me.txtDir.TabIndex = 3
    '
    'txtButtons
    '
    Me.txtButtons.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtButtons.Location = New System.Drawing.Point(758, 55)
    Me.txtButtons.Multiline = True
    Me.txtButtons.Name = "txtButtons"
    Me.txtButtons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtButtons.Size = New System.Drawing.Size(184, 534)
    Me.txtButtons.TabIndex = 4
    '
    'timerPoll
    '
    '
    'ComboBox1
    '
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(597, 25)
    Me.ComboBox1.TabIndex = 5
    '
    'btnScan
    '
    Me.btnScan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnScan.Location = New System.Drawing.Point(843, 11)
    Me.btnScan.Name = "btnScan"
    Me.btnScan.Size = New System.Drawing.Size(99, 27)
    Me.btnScan.TabIndex = 6
    Me.btnScan.Text = "Device Scan"
    Me.btnScan.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(954, 601)
    Me.Controls.Add(Me.btnScan)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.txtButtons)
    Me.Controls.Add(Me.txtDir)
    Me.Controls.Add(Me.btnSelect)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "frmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Joypad / Joystick Tester - github.com/Jaruzel"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnSelect As System.Windows.Forms.Button
  Friend WithEvents txtDir As System.Windows.Forms.TextBox
  Friend WithEvents txtButtons As System.Windows.Forms.TextBox
  Friend WithEvents timerPoll As System.Windows.Forms.Timer
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents btnScan As System.Windows.Forms.Button

End Class
