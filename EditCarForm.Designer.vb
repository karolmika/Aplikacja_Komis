<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditCarForm
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
        Me.ButtonZapisz = New System.Windows.Forms.Button()
        Me.GroupBoxWyposażenie = New System.Windows.Forms.GroupBox()
        Me.CheckBoxLakierMetalik = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKeyless = New System.Windows.Forms.CheckBox()
        Me.CheckBoxESP = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKlimatyzacja = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCzujniki = New System.Windows.Forms.CheckBox()
        Me.CheckBoxABS = New System.Windows.Forms.CheckBox()
        Me.GroupBoxWybierzPojazd = New System.Windows.Forms.GroupBox()
        Me.LabelZdjecie = New System.Windows.Forms.Label()
        Me.TextBoxZdjecie = New System.Windows.Forms.TextBox()
        Me.TextBoxRocznik = New System.Windows.Forms.TextBox()
        Me.LabelKolor = New System.Windows.Forms.Label()
        Me.LabelOcenaPowyzej = New System.Windows.Forms.Label()
        Me.ComboBoxKolor = New System.Windows.Forms.ComboBox()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.ComboBoxMarka = New System.Windows.Forms.ComboBox()
        Me.ButtonAnuluj = New System.Windows.Forms.Button()
        Me.GroupBoxWyposażenie.SuspendLayout()
        Me.GroupBoxWybierzPojazd.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonZapisz
        '
        Me.ButtonZapisz.Location = New System.Drawing.Point(34, 486)
        Me.ButtonZapisz.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonZapisz.Name = "ButtonZapisz"
        Me.ButtonZapisz.Size = New System.Drawing.Size(138, 30)
        Me.ButtonZapisz.TabIndex = 13
        Me.ButtonZapisz.Text = "Zapisz"
        Me.ButtonZapisz.UseVisualStyleBackColor = True
        '
        'GroupBoxWyposażenie
        '
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxLakierMetalik)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxKeyless)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxESP)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxKlimatyzacja)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxCzujniki)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxABS)
        Me.GroupBoxWyposażenie.Location = New System.Drawing.Point(34, 336)
        Me.GroupBoxWyposażenie.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWyposażenie.Name = "GroupBoxWyposażenie"
        Me.GroupBoxWyposażenie.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWyposażenie.Size = New System.Drawing.Size(332, 137)
        Me.GroupBoxWyposażenie.TabIndex = 12
        Me.GroupBoxWyposażenie.TabStop = False
        Me.GroupBoxWyposażenie.Text = "Edytuj wyposażenie pojazdu"
        '
        'CheckBoxLakierMetalik
        '
        Me.CheckBoxLakierMetalik.AutoSize = True
        Me.CheckBoxLakierMetalik.Location = New System.Drawing.Point(26, 56)
        Me.CheckBoxLakierMetalik.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxLakierMetalik.Name = "CheckBoxLakierMetalik"
        Me.CheckBoxLakierMetalik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxLakierMetalik.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxLakierMetalik.TabIndex = 0
        Me.CheckBoxLakierMetalik.Text = "Lakier metaliczny"
        Me.CheckBoxLakierMetalik.UseVisualStyleBackColor = True
        '
        'CheckBoxKeyless
        '
        Me.CheckBoxKeyless.AutoSize = True
        Me.CheckBoxKeyless.Location = New System.Drawing.Point(220, 82)
        Me.CheckBoxKeyless.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxKeyless.Name = "CheckBoxKeyless"
        Me.CheckBoxKeyless.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKeyless.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxKeyless.TabIndex = 4
        Me.CheckBoxKeyless.Text = "KEYLESS"
        Me.CheckBoxKeyless.UseVisualStyleBackColor = True
        '
        'CheckBoxESP
        '
        Me.CheckBoxESP.AutoSize = True
        Me.CheckBoxESP.Location = New System.Drawing.Point(245, 56)
        Me.CheckBoxESP.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxESP.Name = "CheckBoxESP"
        Me.CheckBoxESP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxESP.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxESP.TabIndex = 1
        Me.CheckBoxESP.Text = "ESP"
        Me.CheckBoxESP.UseVisualStyleBackColor = True
        '
        'CheckBoxKlimatyzacja
        '
        Me.CheckBoxKlimatyzacja.AutoSize = True
        Me.CheckBoxKlimatyzacja.Location = New System.Drawing.Point(47, 31)
        Me.CheckBoxKlimatyzacja.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxKlimatyzacja.Name = "CheckBoxKlimatyzacja"
        Me.CheckBoxKlimatyzacja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKlimatyzacja.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxKlimatyzacja.TabIndex = 3
        Me.CheckBoxKlimatyzacja.Text = "Klimatyzacja"
        Me.CheckBoxKlimatyzacja.UseVisualStyleBackColor = True
        '
        'CheckBoxCzujniki
        '
        Me.CheckBoxCzujniki.AutoSize = True
        Me.CheckBoxCzujniki.Location = New System.Drawing.Point(15, 82)
        Me.CheckBoxCzujniki.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCzujniki.Name = "CheckBoxCzujniki"
        Me.CheckBoxCzujniki.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxCzujniki.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxCzujniki.TabIndex = 0
        Me.CheckBoxCzujniki.Text = "Czujniki parkowania"
        Me.CheckBoxCzujniki.UseVisualStyleBackColor = True
        '
        'CheckBoxABS
        '
        Me.CheckBoxABS.AutoSize = True
        Me.CheckBoxABS.Location = New System.Drawing.Point(245, 31)
        Me.CheckBoxABS.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxABS.Name = "CheckBoxABS"
        Me.CheckBoxABS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxABS.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxABS.TabIndex = 2
        Me.CheckBoxABS.Text = "ABS"
        Me.CheckBoxABS.UseVisualStyleBackColor = True
        '
        'GroupBoxWybierzPojazd
        '
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelZdjecie)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.TextBoxZdjecie)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.TextBoxRocznik)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelOcenaPowyzej)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelMarka)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxMarka)
        Me.GroupBoxWybierzPojazd.Location = New System.Drawing.Point(34, 25)
        Me.GroupBoxWybierzPojazd.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWybierzPojazd.Name = "GroupBoxWybierzPojazd"
        Me.GroupBoxWybierzPojazd.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWybierzPojazd.Size = New System.Drawing.Size(332, 307)
        Me.GroupBoxWybierzPojazd.TabIndex = 11
        Me.GroupBoxWybierzPojazd.TabStop = False
        Me.GroupBoxWybierzPojazd.Text = "Edytuj parametry pojazdu"
        '
        'LabelZdjecie
        '
        Me.LabelZdjecie.AutoSize = True
        Me.LabelZdjecie.Location = New System.Drawing.Point(17, 236)
        Me.LabelZdjecie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelZdjecie.Name = "LabelZdjecie"
        Me.LabelZdjecie.Size = New System.Drawing.Size(42, 13)
        Me.LabelZdjecie.TabIndex = 12
        Me.LabelZdjecie.Text = "Zdjecie"
        '
        'TextBoxZdjecie
        '
        Me.TextBoxZdjecie.Location = New System.Drawing.Point(20, 255)
        Me.TextBoxZdjecie.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxZdjecie.Name = "TextBoxZdjecie"
        Me.TextBoxZdjecie.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxZdjecie.TabIndex = 11
        '
        'TextBoxRocznik
        '
        Me.TextBoxRocznik.Location = New System.Drawing.Point(20, 201)
        Me.TextBoxRocznik.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxRocznik.Name = "TextBoxRocznik"
        Me.TextBoxRocznik.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxRocznik.TabIndex = 10
        '
        'LabelKolor
        '
        Me.LabelKolor.AutoSize = True
        Me.LabelKolor.Location = New System.Drawing.Point(17, 128)
        Me.LabelKolor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelKolor.Name = "LabelKolor"
        Me.LabelKolor.Size = New System.Drawing.Size(31, 13)
        Me.LabelKolor.TabIndex = 1
        Me.LabelKolor.Text = "Kolor"
        '
        'LabelOcenaPowyzej
        '
        Me.LabelOcenaPowyzej.AutoSize = True
        Me.LabelOcenaPowyzej.Location = New System.Drawing.Point(17, 181)
        Me.LabelOcenaPowyzej.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOcenaPowyzej.Name = "LabelOcenaPowyzej"
        Me.LabelOcenaPowyzej.Size = New System.Drawing.Size(46, 13)
        Me.LabelOcenaPowyzej.TabIndex = 9
        Me.LabelOcenaPowyzej.Text = "Rocznik"
        '
        'ComboBoxKolor
        '
        Me.ComboBoxKolor.FormattingEnabled = True
        Me.ComboBoxKolor.Items.AddRange(New Object() {"biały", "brązowy", "czarny", "czerwony", "fioletowy", "niebieski", "pomarańczowy", "różowy", "srebrny", "szary", "zielony", "złoty", "żółty"})
        Me.ComboBoxKolor.Location = New System.Drawing.Point(20, 147)
        Me.ComboBoxKolor.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxKolor.Name = "ComboBoxKolor"
        Me.ComboBoxKolor.Size = New System.Drawing.Size(290, 21)
        Me.ComboBoxKolor.TabIndex = 1
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.Location = New System.Drawing.Point(17, 82)
        Me.LabelModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(36, 13)
        Me.LabelModel.TabIndex = 5
        Me.LabelModel.Text = "Model"
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(20, 98)
        Me.ComboBoxModel.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(290, 21)
        Me.ComboBoxModel.TabIndex = 5
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Location = New System.Drawing.Point(17, 34)
        Me.LabelMarka.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(37, 13)
        Me.LabelMarka.TabIndex = 5
        Me.LabelMarka.Text = "Marka"
        '
        'ComboBoxMarka
        '
        Me.ComboBoxMarka.FormattingEnabled = True
        Me.ComboBoxMarka.Location = New System.Drawing.Point(20, 53)
        Me.ComboBoxMarka.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxMarka.Name = "ComboBoxMarka"
        Me.ComboBoxMarka.Size = New System.Drawing.Size(290, 21)
        Me.ComboBoxMarka.TabIndex = 1
        '
        'ButtonAnuluj
        '
        Me.ButtonAnuluj.Location = New System.Drawing.Point(228, 486)
        Me.ButtonAnuluj.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAnuluj.Name = "ButtonAnuluj"
        Me.ButtonAnuluj.Size = New System.Drawing.Size(138, 30)
        Me.ButtonAnuluj.TabIndex = 14
        Me.ButtonAnuluj.Text = "Anuluj"
        Me.ButtonAnuluj.UseVisualStyleBackColor = True
        '
        'EditCarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 556)
        Me.Controls.Add(Me.ButtonAnuluj)
        Me.Controls.Add(Me.ButtonZapisz)
        Me.Controls.Add(Me.GroupBoxWyposażenie)
        Me.Controls.Add(Me.GroupBoxWybierzPojazd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditCarForm"
        Me.Text = "EditCarForm"
        Me.GroupBoxWyposażenie.ResumeLayout(False)
        Me.GroupBoxWyposażenie.PerformLayout()
        Me.GroupBoxWybierzPojazd.ResumeLayout(False)
        Me.GroupBoxWybierzPojazd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonZapisz As Button
    Friend WithEvents GroupBoxWyposażenie As GroupBox
    Friend WithEvents CheckBoxLakierMetalik As CheckBox
    Friend WithEvents CheckBoxKeyless As CheckBox
    Friend WithEvents CheckBoxESP As CheckBox
    Friend WithEvents CheckBoxKlimatyzacja As CheckBox
    Friend WithEvents CheckBoxCzujniki As CheckBox
    Friend WithEvents CheckBoxABS As CheckBox
    Friend WithEvents GroupBoxWybierzPojazd As GroupBox
    Friend WithEvents TextBoxRocznik As TextBox
    Friend WithEvents LabelKolor As Label
    Friend WithEvents LabelOcenaPowyzej As Label
    Friend WithEvents LabelModel As Label
    Friend WithEvents LabelMarka As Label
    Friend WithEvents ComboBoxKolor As ComboBox
    Friend WithEvents ComboBoxModel As ComboBox
    Friend WithEvents ComboBoxMarka As ComboBox
    Friend WithEvents ButtonAnuluj As Button
    Friend WithEvents LabelZdjecie As Label
    Friend WithEvents TextBoxZdjecie As TextBox
End Class
