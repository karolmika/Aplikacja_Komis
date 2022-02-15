<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarRateControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TrackBarRate = New System.Windows.Forms.TrackBar()
        Me.LabelRateName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCarToRate = New System.Windows.Forms.Label()
        Me.GroupBoxHistoriaOcen = New System.Windows.Forms.GroupBox()
        Me.LabelBest3 = New System.Windows.Forms.Label()
        Me.LabelBest2 = New System.Windows.Forms.Label()
        Me.LabelBest1 = New System.Windows.Forms.Label()
        Me.ButtonRate = New System.Windows.Forms.Button()
        Me.LabelRateValue = New System.Windows.Forms.Label()
        CType(Me.TrackBarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxHistoriaOcen.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBarRate
        '
        Me.TrackBarRate.Location = New System.Drawing.Point(23, 2)
        Me.TrackBarRate.Margin = New System.Windows.Forms.Padding(2)
        Me.TrackBarRate.Minimum = 1
        Me.TrackBarRate.Name = "TrackBarRate"
        Me.TrackBarRate.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarRate.Size = New System.Drawing.Size(45, 143)
        Me.TrackBarRate.TabIndex = 0
        Me.TrackBarRate.Tag = ""
        Me.TrackBarRate.Value = 1
        '
        'LabelRateName
        '
        Me.LabelRateName.AutoSize = True
        Me.LabelRateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelRateName.Location = New System.Drawing.Point(82, 89)
        Me.LabelRateName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRateName.Name = "LabelRateName"
        Me.LabelRateName.Size = New System.Drawing.Size(66, 20)
        Me.LabelRateName.TabIndex = 1
        Me.LabelRateName.Text = "Ocena:"
        Me.LabelRateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelCarToRate)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(153, 63)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oceniany pojazd"
        '
        'LabelCarToRate
        '
        Me.LabelCarToRate.AutoSize = True
        Me.LabelCarToRate.Location = New System.Drawing.Point(22, 32)
        Me.LabelCarToRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCarToRate.Name = "LabelCarToRate"
        Me.LabelCarToRate.Size = New System.Drawing.Size(0, 13)
        Me.LabelCarToRate.TabIndex = 5
        '
        'GroupBoxHistoriaOcen
        '
        Me.GroupBoxHistoriaOcen.Controls.Add(Me.LabelBest3)
        Me.GroupBoxHistoriaOcen.Controls.Add(Me.LabelBest2)
        Me.GroupBoxHistoriaOcen.Controls.Add(Me.LabelBest1)
        Me.GroupBoxHistoriaOcen.Location = New System.Drawing.Point(253, 18)
        Me.GroupBoxHistoriaOcen.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxHistoriaOcen.Name = "GroupBoxHistoriaOcen"
        Me.GroupBoxHistoriaOcen.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxHistoriaOcen.Size = New System.Drawing.Size(153, 127)
        Me.GroupBoxHistoriaOcen.TabIndex = 4
        Me.GroupBoxHistoriaOcen.TabStop = False
        Me.GroupBoxHistoriaOcen.Text = "Najlepiej oceniane"
        '
        'LabelBest3
        '
        Me.LabelBest3.AutoSize = True
        Me.LabelBest3.Location = New System.Drawing.Point(20, 89)
        Me.LabelBest3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBest3.Name = "LabelBest3"
        Me.LabelBest3.Size = New System.Drawing.Size(0, 13)
        Me.LabelBest3.TabIndex = 5
        '
        'LabelBest2
        '
        Me.LabelBest2.AutoSize = True
        Me.LabelBest2.Location = New System.Drawing.Point(20, 62)
        Me.LabelBest2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBest2.Name = "LabelBest2"
        Me.LabelBest2.Size = New System.Drawing.Size(0, 13)
        Me.LabelBest2.TabIndex = 5
        '
        'LabelBest1
        '
        Me.LabelBest1.AutoSize = True
        Me.LabelBest1.Location = New System.Drawing.Point(20, 32)
        Me.LabelBest1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBest1.Name = "LabelBest1"
        Me.LabelBest1.Size = New System.Drawing.Size(0, 13)
        Me.LabelBest1.TabIndex = 5
        '
        'ButtonRate
        '
        Me.ButtonRate.Location = New System.Drawing.Point(81, 119)
        Me.ButtonRate.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRate.Name = "ButtonRate"
        Me.ButtonRate.Size = New System.Drawing.Size(153, 25)
        Me.ButtonRate.TabIndex = 5
        Me.ButtonRate.Text = "Zapis ocenę"
        Me.ButtonRate.UseVisualStyleBackColor = True
        '
        'LabelRateValue
        '
        Me.LabelRateValue.AutoSize = True
        Me.LabelRateValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelRateValue.Location = New System.Drawing.Point(145, 89)
        Me.LabelRateValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRateValue.Name = "LabelRateValue"
        Me.LabelRateValue.Size = New System.Drawing.Size(19, 20)
        Me.LabelRateValue.TabIndex = 6
        Me.LabelRateValue.Text = "0"
        Me.LabelRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CarRateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelRateValue)
        Me.Controls.Add(Me.ButtonRate)
        Me.Controls.Add(Me.GroupBoxHistoriaOcen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelRateName)
        Me.Controls.Add(Me.TrackBarRate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CarRateControl"
        Me.Size = New System.Drawing.Size(438, 166)
        CType(Me.TrackBarRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxHistoriaOcen.ResumeLayout(False)
        Me.GroupBoxHistoriaOcen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBarRate As TrackBar
    Friend WithEvents LabelRateName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBoxHistoriaOcen As GroupBox
    Friend WithEvents LabelCarToRate As Label
    Friend WithEvents LabelBest3 As Label
    Friend WithEvents LabelBest2 As Label
    Friend WithEvents LabelBest1 As Label
    Friend WithEvents ButtonRate As Button
    Friend WithEvents LabelRateValue As Label
End Class
