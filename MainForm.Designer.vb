<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ComboBoxMarka = New System.Windows.Forms.ComboBox()
        Me.GroupBoxWybierzPojazd = New System.Windows.Forms.GroupBox()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.GroupBoxWynikWyszukiwania = New System.Windows.Forms.GroupBox()
        Me.ButtonSzukaj = New System.Windows.Forms.Button()
        Me.CheckBoxLakierMetalik = New System.Windows.Forms.CheckBox()
        Me.ComboBoxKolor = New System.Windows.Forms.ComboBox()
        Me.LabelKolor = New System.Windows.Forms.Label()
        Me.CheckBoxCzujniki = New System.Windows.Forms.CheckBox()
        Me.CheckBoxESP = New System.Windows.Forms.CheckBox()
        Me.CheckBoxABS = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKlimatyzacja = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKeyless = New System.Windows.Forms.CheckBox()
        Me.GroupBoxWyposażenie = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelOcenaPowyzej = New System.Windows.Forms.Label()
        Me.ComboBoxOcenaPowyzej = New System.Windows.Forms.ComboBox()
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.ButtonUsun = New System.Windows.Forms.Button()
        Me.ButtonEdytuj = New System.Windows.Forms.Button()
        Me.DataGridViewPojazdy = New System.Windows.Forms.DataGridView()
        Me.ButtonPoczatek = New System.Windows.Forms.Button()
        Me.ButtonPoprzedni = New System.Windows.Forms.Button()
        Me.ButtonNastepny = New System.Windows.Forms.Button()
        Me.ButtonKoniec = New System.Windows.Forms.Button()
        Me.LabelWszystkieRekordy = New System.Windows.Forms.Label()
        Me.LabelUkosnik = New System.Windows.Forms.Label()
        Me.LabelAktualnyRekord = New System.Windows.Forms.Label()
        Me.GroupBoxWybierzPojazd.SuspendLayout()
        Me.GroupBoxWynikWyszukiwania.SuspendLayout()
        Me.GroupBoxWyposażenie.SuspendLayout()
        CType(Me.DataGridViewPojazdy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxMarka
        '
        Me.ComboBoxMarka.FormattingEnabled = True
        Me.ComboBoxMarka.Location = New System.Drawing.Point(26, 65)
        Me.ComboBoxMarka.Name = "ComboBoxMarka"
        Me.ComboBoxMarka.Size = New System.Drawing.Size(205, 24)
        Me.ComboBoxMarka.TabIndex = 1
        '
        'GroupBoxWybierzPojazd
        '
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxOcenaPowyzej)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelOcenaPowyzej)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelMarka)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxMarka)
        Me.GroupBoxWybierzPojazd.Location = New System.Drawing.Point(59, 93)
        Me.GroupBoxWybierzPojazd.Name = "GroupBoxWybierzPojazd"
        Me.GroupBoxWybierzPojazd.Size = New System.Drawing.Size(344, 295)
        Me.GroupBoxWybierzPojazd.TabIndex = 2
        Me.GroupBoxWybierzPojazd.TabStop = False
        Me.GroupBoxWybierzPojazd.Text = "Wybierz pojazd, który Cię interesuje"
        '
        'LabelMarka
        '
        Me.LabelMarka.AutoSize = True
        Me.LabelMarka.Location = New System.Drawing.Point(23, 42)
        Me.LabelMarka.Name = "LabelMarka"
        Me.LabelMarka.Size = New System.Drawing.Size(45, 16)
        Me.LabelMarka.TabIndex = 5
        Me.LabelMarka.Text = "Marka"
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Location = New System.Drawing.Point(34, 38)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(37, 16)
        Me.LabelWelcome.TabIndex = 3
        Me.LabelWelcome.Text = "Witaj"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(989, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.Enabled = False
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(26, 120)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(205, 24)
        Me.ComboBoxModel.TabIndex = 5
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.Location = New System.Drawing.Point(23, 101)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.Size = New System.Drawing.Size(45, 16)
        Me.LabelModel.TabIndex = 5
        Me.LabelModel.Text = "Model"
        '
        'GroupBoxWynikWyszukiwania
        '
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.LabelAktualnyRekord)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.LabelUkosnik)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.LabelWszystkieRekordy)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.ButtonKoniec)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.ButtonNastepny)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.ButtonPoprzedni)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.ButtonPoczatek)
        Me.GroupBoxWynikWyszukiwania.Controls.Add(Me.DataGridViewPojazdy)
        Me.GroupBoxWynikWyszukiwania.Enabled = False
        Me.GroupBoxWynikWyszukiwania.Location = New System.Drawing.Point(59, 429)
        Me.GroupBoxWynikWyszukiwania.Name = "GroupBoxWynikWyszukiwania"
        Me.GroupBoxWynikWyszukiwania.Size = New System.Drawing.Size(1016, 547)
        Me.GroupBoxWynikWyszukiwania.TabIndex = 5
        Me.GroupBoxWynikWyszukiwania.TabStop = False
        Me.GroupBoxWynikWyszukiwania.Text = "Lista poasujących pojazdów"
        '
        'ButtonSzukaj
        '
        Me.ButtonSzukaj.Location = New System.Drawing.Point(928, 93)
        Me.ButtonSzukaj.Name = "ButtonSzukaj"
        Me.ButtonSzukaj.Size = New System.Drawing.Size(147, 35)
        Me.ButtonSzukaj.TabIndex = 6
        Me.ButtonSzukaj.Text = "Szukaj"
        Me.ButtonSzukaj.UseVisualStyleBackColor = True
        '
        'CheckBoxLakierMetalik
        '
        Me.CheckBoxLakierMetalik.AutoSize = True
        Me.CheckBoxLakierMetalik.Location = New System.Drawing.Point(34, 69)
        Me.CheckBoxLakierMetalik.Name = "CheckBoxLakierMetalik"
        Me.CheckBoxLakierMetalik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxLakierMetalik.Size = New System.Drawing.Size(132, 20)
        Me.CheckBoxLakierMetalik.TabIndex = 0
        Me.CheckBoxLakierMetalik.Text = "Lakier metaliczny"
        Me.CheckBoxLakierMetalik.UseVisualStyleBackColor = True
        '
        'ComboBoxKolor
        '
        Me.ComboBoxKolor.FormattingEnabled = True
        Me.ComboBoxKolor.Items.AddRange(New Object() {"-", "biały", "czarny", "czerwony", "niebieski", "pomarańczowy", "srebrny", "zielony", "żółty"})
        Me.ComboBoxKolor.Location = New System.Drawing.Point(26, 181)
        Me.ComboBoxKolor.Name = "ComboBoxKolor"
        Me.ComboBoxKolor.Size = New System.Drawing.Size(205, 24)
        Me.ComboBoxKolor.TabIndex = 1
        '
        'LabelKolor
        '
        Me.LabelKolor.AutoSize = True
        Me.LabelKolor.Location = New System.Drawing.Point(23, 158)
        Me.LabelKolor.Name = "LabelKolor"
        Me.LabelKolor.Size = New System.Drawing.Size(38, 16)
        Me.LabelKolor.TabIndex = 1
        Me.LabelKolor.Text = "Kolor"
        '
        'CheckBoxCzujniki
        '
        Me.CheckBoxCzujniki.AutoSize = True
        Me.CheckBoxCzujniki.Location = New System.Drawing.Point(19, 101)
        Me.CheckBoxCzujniki.Name = "CheckBoxCzujniki"
        Me.CheckBoxCzujniki.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxCzujniki.Size = New System.Drawing.Size(147, 20)
        Me.CheckBoxCzujniki.TabIndex = 0
        Me.CheckBoxCzujniki.Text = "Czujniki parkowania"
        Me.CheckBoxCzujniki.UseVisualStyleBackColor = True
        '
        'CheckBoxESP
        '
        Me.CheckBoxESP.AutoSize = True
        Me.CheckBoxESP.Location = New System.Drawing.Point(293, 69)
        Me.CheckBoxESP.Name = "CheckBoxESP"
        Me.CheckBoxESP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxESP.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxESP.TabIndex = 1
        Me.CheckBoxESP.Text = "ESP"
        Me.CheckBoxESP.UseVisualStyleBackColor = True
        '
        'CheckBoxABS
        '
        Me.CheckBoxABS.AutoSize = True
        Me.CheckBoxABS.Location = New System.Drawing.Point(293, 38)
        Me.CheckBoxABS.Name = "CheckBoxABS"
        Me.CheckBoxABS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxABS.Size = New System.Drawing.Size(56, 20)
        Me.CheckBoxABS.TabIndex = 2
        Me.CheckBoxABS.Text = "ABS"
        Me.CheckBoxABS.UseVisualStyleBackColor = True
        '
        'CheckBoxKlimatyzacja
        '
        Me.CheckBoxKlimatyzacja.AutoSize = True
        Me.CheckBoxKlimatyzacja.Location = New System.Drawing.Point(62, 38)
        Me.CheckBoxKlimatyzacja.Name = "CheckBoxKlimatyzacja"
        Me.CheckBoxKlimatyzacja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKlimatyzacja.Size = New System.Drawing.Size(104, 20)
        Me.CheckBoxKlimatyzacja.TabIndex = 3
        Me.CheckBoxKlimatyzacja.Text = "Klimatyzacja"
        Me.CheckBoxKlimatyzacja.UseVisualStyleBackColor = True
        '
        'CheckBoxKeyless
        '
        Me.CheckBoxKeyless.AutoSize = True
        Me.CheckBoxKeyless.Location = New System.Drawing.Point(260, 101)
        Me.CheckBoxKeyless.Name = "CheckBoxKeyless"
        Me.CheckBoxKeyless.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKeyless.Size = New System.Drawing.Size(89, 20)
        Me.CheckBoxKeyless.TabIndex = 4
        Me.CheckBoxKeyless.Text = "KEYLESS"
        Me.CheckBoxKeyless.UseVisualStyleBackColor = True
        '
        'GroupBoxWyposażenie
        '
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxLakierMetalik)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxKeyless)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxESP)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxKlimatyzacja)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxCzujniki)
        Me.GroupBoxWyposażenie.Controls.Add(Me.CheckBoxABS)
        Me.GroupBoxWyposażenie.Location = New System.Drawing.Point(460, 93)
        Me.GroupBoxWyposażenie.Name = "GroupBoxWyposażenie"
        Me.GroupBoxWyposażenie.Size = New System.Drawing.Size(416, 149)
        Me.GroupBoxWyposażenie.TabIndex = 7
        Me.GroupBoxWyposażenie.TabStop = False
        Me.GroupBoxWyposażenie.Text = "Wyposażenie"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(460, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 137)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ocena"
        '
        'LabelOcenaPowyzej
        '
        Me.LabelOcenaPowyzej.AutoSize = True
        Me.LabelOcenaPowyzej.Location = New System.Drawing.Point(23, 223)
        Me.LabelOcenaPowyzej.Name = "LabelOcenaPowyzej"
        Me.LabelOcenaPowyzej.Size = New System.Drawing.Size(99, 16)
        Me.LabelOcenaPowyzej.TabIndex = 9
        Me.LabelOcenaPowyzej.Text = "Ocena powyżej"
        '
        'ComboBoxOcenaPowyzej
        '
        Me.ComboBoxOcenaPowyzej.FormattingEnabled = True
        Me.ComboBoxOcenaPowyzej.Location = New System.Drawing.Point(26, 242)
        Me.ComboBoxOcenaPowyzej.Name = "ComboBoxOcenaPowyzej"
        Me.ComboBoxOcenaPowyzej.Size = New System.Drawing.Size(205, 24)
        Me.ComboBoxOcenaPowyzej.TabIndex = 9
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Location = New System.Drawing.Point(928, 147)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(147, 35)
        Me.ButtonDodaj.TabIndex = 9
        Me.ButtonDodaj.Text = "Dodaj"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'ButtonUsun
        '
        Me.ButtonUsun.Location = New System.Drawing.Point(928, 263)
        Me.ButtonUsun.Name = "ButtonUsun"
        Me.ButtonUsun.Size = New System.Drawing.Size(147, 35)
        Me.ButtonUsun.TabIndex = 10
        Me.ButtonUsun.Text = "Usuń"
        Me.ButtonUsun.UseVisualStyleBackColor = True
        '
        'ButtonEdytuj
        '
        Me.ButtonEdytuj.Location = New System.Drawing.Point(928, 202)
        Me.ButtonEdytuj.Name = "ButtonEdytuj"
        Me.ButtonEdytuj.Size = New System.Drawing.Size(147, 35)
        Me.ButtonEdytuj.TabIndex = 11
        Me.ButtonEdytuj.Text = "Edytuj"
        Me.ButtonEdytuj.UseVisualStyleBackColor = True
        '
        'DataGridViewPojazdy
        '
        Me.DataGridViewPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPojazdy.Location = New System.Drawing.Point(26, 41)
        Me.DataGridViewPojazdy.Name = "DataGridViewPojazdy"
        Me.DataGridViewPojazdy.RowHeadersWidth = 51
        Me.DataGridViewPojazdy.RowTemplate.Height = 24
        Me.DataGridViewPojazdy.Size = New System.Drawing.Size(948, 414)
        Me.DataGridViewPojazdy.TabIndex = 0
        '
        'ButtonPoczatek
        '
        Me.ButtonPoczatek.Location = New System.Drawing.Point(297, 475)
        Me.ButtonPoczatek.Name = "ButtonPoczatek"
        Me.ButtonPoczatek.Size = New System.Drawing.Size(75, 44)
        Me.ButtonPoczatek.TabIndex = 1
        Me.ButtonPoczatek.Text = "<<"
        Me.ButtonPoczatek.UseVisualStyleBackColor = True
        '
        'ButtonPoprzedni
        '
        Me.ButtonPoprzedni.Location = New System.Drawing.Point(378, 475)
        Me.ButtonPoprzedni.Name = "ButtonPoprzedni"
        Me.ButtonPoprzedni.Size = New System.Drawing.Size(75, 44)
        Me.ButtonPoprzedni.TabIndex = 2
        Me.ButtonPoprzedni.Text = "<"
        Me.ButtonPoprzedni.UseVisualStyleBackColor = True
        '
        'ButtonNastepny
        '
        Me.ButtonNastepny.Location = New System.Drawing.Point(459, 475)
        Me.ButtonNastepny.Name = "ButtonNastepny"
        Me.ButtonNastepny.Size = New System.Drawing.Size(75, 44)
        Me.ButtonNastepny.TabIndex = 3
        Me.ButtonNastepny.Text = ">"
        Me.ButtonNastepny.UseVisualStyleBackColor = True
        '
        'ButtonKoniec
        '
        Me.ButtonKoniec.Location = New System.Drawing.Point(540, 475)
        Me.ButtonKoniec.Name = "ButtonKoniec"
        Me.ButtonKoniec.Size = New System.Drawing.Size(75, 44)
        Me.ButtonKoniec.TabIndex = 12
        Me.ButtonKoniec.Text = ">>"
        Me.ButtonKoniec.UseVisualStyleBackColor = True
        '
        'LabelWszystkieRekordy
        '
        Me.LabelWszystkieRekordy.AutoSize = True
        Me.LabelWszystkieRekordy.Location = New System.Drawing.Point(925, 475)
        Me.LabelWszystkieRekordy.Name = "LabelWszystkieRekordy"
        Me.LabelWszystkieRekordy.Size = New System.Drawing.Size(48, 16)
        Me.LabelWszystkieRekordy.TabIndex = 12
        Me.LabelWszystkieRekordy.Text = "Label2"
        '
        'LabelUkosnik
        '
        Me.LabelUkosnik.AutoSize = True
        Me.LabelUkosnik.Location = New System.Drawing.Point(910, 474)
        Me.LabelUkosnik.Name = "LabelUkosnik"
        Me.LabelUkosnik.Size = New System.Drawing.Size(11, 16)
        Me.LabelUkosnik.TabIndex = 13
        Me.LabelUkosnik.Text = "/"
        '
        'LabelAktualnyRekord
        '
        Me.LabelAktualnyRekord.AutoSize = True
        Me.LabelAktualnyRekord.Location = New System.Drawing.Point(852, 475)
        Me.LabelAktualnyRekord.Name = "LabelAktualnyRekord"
        Me.LabelAktualnyRekord.Size = New System.Drawing.Size(48, 16)
        Me.LabelAktualnyRekord.TabIndex = 14
        Me.LabelAktualnyRekord.Text = "Label4"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 1012)
        Me.Controls.Add(Me.ButtonEdytuj)
        Me.Controls.Add(Me.ButtonUsun)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxWyposażenie)
        Me.Controls.Add(Me.GroupBoxWynikWyszukiwania)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.GroupBoxWybierzPojazd)
        Me.Controls.Add(Me.ButtonSzukaj)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.GroupBoxWybierzPojazd.ResumeLayout(False)
        Me.GroupBoxWybierzPojazd.PerformLayout()
        Me.GroupBoxWynikWyszukiwania.ResumeLayout(False)
        Me.GroupBoxWynikWyszukiwania.PerformLayout()
        Me.GroupBoxWyposażenie.ResumeLayout(False)
        Me.GroupBoxWyposażenie.PerformLayout()
        CType(Me.DataGridViewPojazdy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxMarka As ComboBox
    Friend WithEvents GroupBoxWybierzPojazd As GroupBox
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelMarka As Label
    Friend WithEvents LabelModel As Label
    Friend WithEvents ComboBoxModel As ComboBox
    Friend WithEvents ButtonSzukaj As Button
    Friend WithEvents GroupBoxWynikWyszukiwania As GroupBox
    Friend WithEvents LabelKolor As Label
    Friend WithEvents ComboBoxKolor As ComboBox
    Friend WithEvents CheckBoxLakierMetalik As CheckBox
    Friend WithEvents CheckBoxCzujniki As CheckBox
    Friend WithEvents CheckBoxESP As CheckBox
    Friend WithEvents CheckBoxABS As CheckBox
    Friend WithEvents CheckBoxKlimatyzacja As CheckBox
    Friend WithEvents CheckBoxKeyless As CheckBox
    Friend WithEvents GroupBoxWyposażenie As GroupBox
    Friend WithEvents ComboBoxOcenaPowyzej As ComboBox
    Friend WithEvents LabelOcenaPowyzej As Label
    Friend WithEvents LabelAktualnyRekord As Label
    Friend WithEvents LabelUkosnik As Label
    Friend WithEvents LabelWszystkieRekordy As Label
    Friend WithEvents ButtonKoniec As Button
    Friend WithEvents ButtonNastepny As Button
    Friend WithEvents ButtonPoprzedni As Button
    Friend WithEvents ButtonPoczatek As Button
    Friend WithEvents DataGridViewPojazdy As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonDodaj As Button
    Friend WithEvents ButtonUsun As Button
    Friend WithEvents ButtonEdytuj As Button
End Class
