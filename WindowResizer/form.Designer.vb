﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.btnResize = New System.Windows.Forms.Button()
        Me.cbProcessList = New System.Windows.Forms.ComboBox()
        Me.valueX = New System.Windows.Forms.NumericUpDown()
        Me.valueY = New System.Windows.Forms.NumericUpDown()
        Me.valueHeight = New System.Windows.Forms.NumericUpDown()
        Me.valueWidth = New System.Windows.Forms.NumericUpDown()
        Me.labelX = New System.Windows.Forms.Label()
        Me.labelY = New System.Windows.Forms.Label()
        Me.labelWidth = New System.Windows.Forms.Label()
        Me.labelHeight = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.valueX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valueY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valueHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valueWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResize
        '
        Me.btnResize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResize.Location = New System.Drawing.Point(13, 144)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(382, 52)
        Me.btnResize.TabIndex = 0
        Me.btnResize.Text = "Resize"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'cbProcessList
        '
        Me.cbProcessList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProcessList.FormattingEnabled = True
        Me.cbProcessList.Location = New System.Drawing.Point(13, 13)
        Me.cbProcessList.Name = "cbProcessList"
        Me.cbProcessList.Size = New System.Drawing.Size(323, 21)
        Me.cbProcessList.TabIndex = 1
        Me.cbProcessList.Text = "- Select Process -"
        '
        'valueX
        '
        Me.valueX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valueX.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.valueX.Location = New System.Drawing.Point(56, 40)
        Me.valueX.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.valueX.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.valueX.Name = "valueX"
        Me.valueX.Size = New System.Drawing.Size(339, 20)
        Me.valueX.TabIndex = 2
        '
        'valueY
        '
        Me.valueY.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valueY.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.valueY.Location = New System.Drawing.Point(56, 66)
        Me.valueY.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.valueY.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.valueY.Name = "valueY"
        Me.valueY.Size = New System.Drawing.Size(339, 20)
        Me.valueY.TabIndex = 3
        '
        'valueHeight
        '
        Me.valueHeight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valueHeight.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.valueHeight.Location = New System.Drawing.Point(56, 118)
        Me.valueHeight.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.valueHeight.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.valueHeight.Name = "valueHeight"
        Me.valueHeight.Size = New System.Drawing.Size(339, 20)
        Me.valueHeight.TabIndex = 5
        Me.valueHeight.Value = New Decimal(New Integer() {600, 0, 0, 0})
        '
        'valueWidth
        '
        Me.valueWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valueWidth.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.valueWidth.Location = New System.Drawing.Point(56, 92)
        Me.valueWidth.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.valueWidth.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.valueWidth.Name = "valueWidth"
        Me.valueWidth.Size = New System.Drawing.Size(339, 20)
        Me.valueWidth.TabIndex = 4
        Me.valueWidth.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'labelX
        '
        Me.labelX.AutoSize = True
        Me.labelX.Location = New System.Drawing.Point(12, 42)
        Me.labelX.Name = "labelX"
        Me.labelX.Size = New System.Drawing.Size(14, 13)
        Me.labelX.TabIndex = 6
        Me.labelX.Text = "X"
        '
        'labelY
        '
        Me.labelY.AutoSize = True
        Me.labelY.Location = New System.Drawing.Point(12, 68)
        Me.labelY.Name = "labelY"
        Me.labelY.Size = New System.Drawing.Size(14, 13)
        Me.labelY.TabIndex = 7
        Me.labelY.Text = "Y"
        '
        'labelWidth
        '
        Me.labelWidth.AutoSize = True
        Me.labelWidth.Location = New System.Drawing.Point(12, 94)
        Me.labelWidth.Name = "labelWidth"
        Me.labelWidth.Size = New System.Drawing.Size(35, 13)
        Me.labelWidth.TabIndex = 6
        Me.labelWidth.Text = "Width"
        '
        'labelHeight
        '
        Me.labelHeight.AutoSize = True
        Me.labelHeight.Location = New System.Drawing.Point(12, 120)
        Me.labelHeight.Name = "labelHeight"
        Me.labelHeight.Size = New System.Drawing.Size(38, 13)
        Me.labelHeight.TabIndex = 7
        Me.labelHeight.Text = "Height"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(342, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(53, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 208)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.labelHeight)
        Me.Controls.Add(Me.labelWidth)
        Me.Controls.Add(Me.labelY)
        Me.Controls.Add(Me.labelX)
        Me.Controls.Add(Me.valueHeight)
        Me.Controls.Add(Me.valueWidth)
        Me.Controls.Add(Me.valueY)
        Me.Controls.Add(Me.valueX)
        Me.Controls.Add(Me.cbProcessList)
        Me.Controls.Add(Me.btnResize)
        Me.Name = "form"
        Me.Text = "WindowResizer"
        CType(Me.valueX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valueY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valueHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valueWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnResize As Button
    Friend WithEvents cbProcessList As ComboBox
    Friend WithEvents valueX As NumericUpDown
    Friend WithEvents valueY As NumericUpDown
    Friend WithEvents valueHeight As NumericUpDown
    Friend WithEvents valueWidth As NumericUpDown
    Friend WithEvents labelX As Label
    Friend WithEvents labelY As Label
    Friend WithEvents labelWidth As Label
    Friend WithEvents labelHeight As Label
    Friend WithEvents btnRefresh As Button
End Class