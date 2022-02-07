<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBoxMarka = New System.Windows.Forms.ComboBox()
        Me.GroupBoxWybierzPojazd = New System.Windows.Forms.GroupBox()
        Me.ButtonWyczyscOcena = New System.Windows.Forms.Button()
        Me.ButtonWyczyscKolor = New System.Windows.Forms.Button()
        Me.ButtonWyczyscModel = New System.Windows.Forms.Button()
        Me.ButtonWyczyscMarke = New System.Windows.Forms.Button()
        Me.ComboBoxOcenaPowyzej = New System.Windows.Forms.ComboBox()
        Me.LabelKolor = New System.Windows.Forms.Label()
        Me.LabelOcenaPowyzej = New System.Windows.Forms.Label()
        Me.ComboBoxKolor = New System.Windows.Forms.ComboBox()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.LabelMarka = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.GroupBoxWynikWyszukiwania = New System.Windows.Forms.GroupBox()
        Me.LabelAktualnyRekord = New System.Windows.Forms.Label()
        Me.LabelUkosnik = New System.Windows.Forms.Label()
        Me.LabelWszystkieRekordy = New System.Windows.Forms.Label()
        Me.ButtonKoniec = New System.Windows.Forms.Button()
        Me.ButtonNastepny = New System.Windows.Forms.Button()
        Me.ButtonPoprzedni = New System.Windows.Forms.Button()
        Me.ButtonPoczatek = New System.Windows.Forms.Button()
        Me.DataGridViewPojazdy = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenerationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OcenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iloscocen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetalicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeylessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarsDatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KomisDBDataSet = New Aplikacja_Komis.KomisDBDataSet()
        Me.ButtonSzukaj = New System.Windows.Forms.Button()
        Me.CheckBoxLakierMetalik = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCzujniki = New System.Windows.Forms.CheckBox()
        Me.CheckBoxESP = New System.Windows.Forms.CheckBox()
        Me.CheckBoxABS = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKlimatyzacja = New System.Windows.Forms.CheckBox()
        Me.CheckBoxKeyless = New System.Windows.Forms.CheckBox()
        Me.GroupBoxWyposażenie = New System.Windows.Forms.GroupBox()
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.ButtonUsun = New System.Windows.Forms.Button()
        Me.ButtonEdytuj = New System.Windows.Forms.Button()
        Me.ButtonZapis = New System.Windows.Forms.Button()
        Me.ButtonAnuluj = New System.Windows.Forms.Button()
        Me.CarsDatabaseTableAdapter = New Aplikacja_Komis.KomisDBDataSetTableAdapters.CarsDatabaseTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UżytkownikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WylogujToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxCar = New System.Windows.Forms.PictureBox()
        Me.CarRateControlKomis = New Aplikacja_Komis.CarRateControl()
        Me.ZamknijToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxWybierzPojazd.SuspendLayout()
        Me.GroupBoxWynikWyszukiwania.SuspendLayout()
        CType(Me.DataGridViewPojazdy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsDatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KomisDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxWyposażenie.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxMarka
        '
        Me.ComboBoxMarka.FormattingEnabled = True
        Me.ComboBoxMarka.Location = New System.Drawing.Point(20, 53)
        Me.ComboBoxMarka.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxMarka.Name = "ComboBoxMarka"
        Me.ComboBoxMarka.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxMarka.TabIndex = 1
        '
        'GroupBoxWybierzPojazd
        '
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ButtonWyczyscOcena)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ButtonWyczyscKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ButtonWyczyscModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ButtonWyczyscMarke)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxOcenaPowyzej)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelOcenaPowyzej)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxKolor)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxModel)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.LabelMarka)
        Me.GroupBoxWybierzPojazd.Controls.Add(Me.ComboBoxMarka)
        Me.GroupBoxWybierzPojazd.Location = New System.Drawing.Point(28, 49)
        Me.GroupBoxWybierzPojazd.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWybierzPojazd.Name = "GroupBoxWybierzPojazd"
        Me.GroupBoxWybierzPojazd.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWybierzPojazd.Size = New System.Drawing.Size(348, 247)
        Me.GroupBoxWybierzPojazd.TabIndex = 2
        Me.GroupBoxWybierzPojazd.TabStop = False
        Me.GroupBoxWybierzPojazd.Text = "Wybierz pojazd, który Cię interesuje"
        '
        'ButtonWyczyscOcena
        '
        Me.ButtonWyczyscOcena.Location = New System.Drawing.Point(256, 190)
        Me.ButtonWyczyscOcena.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonWyczyscOcena.Name = "ButtonWyczyscOcena"
        Me.ButtonWyczyscOcena.Size = New System.Drawing.Size(64, 25)
        Me.ButtonWyczyscOcena.TabIndex = 13
        Me.ButtonWyczyscOcena.Text = "Wyczyść"
        Me.ButtonWyczyscOcena.UseVisualStyleBackColor = True
        '
        'ButtonWyczyscKolor
        '
        Me.ButtonWyczyscKolor.Location = New System.Drawing.Point(256, 147)
        Me.ButtonWyczyscKolor.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonWyczyscKolor.Name = "ButtonWyczyscKolor"
        Me.ButtonWyczyscKolor.Size = New System.Drawing.Size(64, 24)
        Me.ButtonWyczyscKolor.TabIndex = 12
        Me.ButtonWyczyscKolor.Text = "Wyczyść"
        Me.ButtonWyczyscKolor.UseVisualStyleBackColor = True
        '
        'ButtonWyczyscModel
        '
        Me.ButtonWyczyscModel.Location = New System.Drawing.Point(256, 98)
        Me.ButtonWyczyscModel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonWyczyscModel.Name = "ButtonWyczyscModel"
        Me.ButtonWyczyscModel.Size = New System.Drawing.Size(64, 23)
        Me.ButtonWyczyscModel.TabIndex = 11
        Me.ButtonWyczyscModel.Text = "Wyczyść"
        Me.ButtonWyczyscModel.UseVisualStyleBackColor = True
        '
        'ButtonWyczyscMarke
        '
        Me.ButtonWyczyscMarke.Location = New System.Drawing.Point(256, 53)
        Me.ButtonWyczyscMarke.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonWyczyscMarke.Name = "ButtonWyczyscMarke"
        Me.ButtonWyczyscMarke.Size = New System.Drawing.Size(64, 24)
        Me.ButtonWyczyscMarke.TabIndex = 10
        Me.ButtonWyczyscMarke.Text = "Wyczyść"
        Me.ButtonWyczyscMarke.UseVisualStyleBackColor = True
        '
        'ComboBoxOcenaPowyzej
        '
        Me.ComboBoxOcenaPowyzej.Enabled = False
        Me.ComboBoxOcenaPowyzej.FormattingEnabled = True
        Me.ComboBoxOcenaPowyzej.Items.AddRange(New Object() {"5", "4", "3", "2", "1", "0"})
        Me.ComboBoxOcenaPowyzej.Location = New System.Drawing.Point(20, 197)
        Me.ComboBoxOcenaPowyzej.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxOcenaPowyzej.Name = "ComboBoxOcenaPowyzej"
        Me.ComboBoxOcenaPowyzej.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxOcenaPowyzej.TabIndex = 9
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
        Me.LabelOcenaPowyzej.Size = New System.Drawing.Size(39, 13)
        Me.LabelOcenaPowyzej.TabIndex = 9
        Me.LabelOcenaPowyzej.Text = "Ocena"
        '
        'ComboBoxKolor
        '
        Me.ComboBoxKolor.Enabled = False
        Me.ComboBoxKolor.FormattingEnabled = True
        Me.ComboBoxKolor.Items.AddRange(New Object() {"biały", "brązowy", "czarny", "czerwony", "fioletowy", "niebieski", "pomarańczowy", "różowy", "srebrny", "szary", "zielony", "złoty", "żółty"})
        Me.ComboBoxKolor.Location = New System.Drawing.Point(20, 147)
        Me.ComboBoxKolor.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxKolor.Name = "ComboBoxKolor"
        Me.ComboBoxKolor.Size = New System.Drawing.Size(221, 21)
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
        Me.ComboBoxModel.Enabled = False
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(20, 98)
        Me.ComboBoxModel.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(221, 21)
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
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Location = New System.Drawing.Point(27, 25)
        Me.LabelWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(31, 13)
        Me.LabelWelcome.TabIndex = 3
        Me.LabelWelcome.Text = "Witaj"
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBoxWynikWyszukiwania.Location = New System.Drawing.Point(28, 448)
        Me.GroupBoxWynikWyszukiwania.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWynikWyszukiwania.Name = "GroupBoxWynikWyszukiwania"
        Me.GroupBoxWynikWyszukiwania.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWynikWyszukiwania.Size = New System.Drawing.Size(923, 464)
        Me.GroupBoxWynikWyszukiwania.TabIndex = 5
        Me.GroupBoxWynikWyszukiwania.TabStop = False
        Me.GroupBoxWynikWyszukiwania.Text = "Lista pojazdów"
        '
        'LabelAktualnyRekord
        '
        Me.LabelAktualnyRekord.AutoSize = True
        Me.LabelAktualnyRekord.Location = New System.Drawing.Point(823, 381)
        Me.LabelAktualnyRekord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAktualnyRekord.Name = "LabelAktualnyRekord"
        Me.LabelAktualnyRekord.Size = New System.Drawing.Size(13, 13)
        Me.LabelAktualnyRekord.TabIndex = 14
        Me.LabelAktualnyRekord.Text = "1"
        Me.LabelAktualnyRekord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelUkosnik
        '
        Me.LabelUkosnik.AutoSize = True
        Me.LabelUkosnik.Location = New System.Drawing.Point(838, 381)
        Me.LabelUkosnik.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUkosnik.Name = "LabelUkosnik"
        Me.LabelUkosnik.Size = New System.Drawing.Size(12, 13)
        Me.LabelUkosnik.TabIndex = 13
        Me.LabelUkosnik.Text = "/"
        '
        'LabelWszystkieRekordy
        '
        Me.LabelWszystkieRekordy.AutoSize = True
        Me.LabelWszystkieRekordy.Location = New System.Drawing.Point(852, 381)
        Me.LabelWszystkieRekordy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWszystkieRekordy.Name = "LabelWszystkieRekordy"
        Me.LabelWszystkieRekordy.Size = New System.Drawing.Size(0, 13)
        Me.LabelWszystkieRekordy.TabIndex = 12
        '
        'ButtonKoniec
        '
        Me.ButtonKoniec.Location = New System.Drawing.Point(506, 390)
        Me.ButtonKoniec.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonKoniec.Name = "ButtonKoniec"
        Me.ButtonKoniec.Size = New System.Drawing.Size(56, 36)
        Me.ButtonKoniec.TabIndex = 12
        Me.ButtonKoniec.Text = ">>"
        Me.ButtonKoniec.UseVisualStyleBackColor = True
        '
        'ButtonNastepny
        '
        Me.ButtonNastepny.Location = New System.Drawing.Point(446, 390)
        Me.ButtonNastepny.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonNastepny.Name = "ButtonNastepny"
        Me.ButtonNastepny.Size = New System.Drawing.Size(56, 36)
        Me.ButtonNastepny.TabIndex = 3
        Me.ButtonNastepny.Text = ">"
        Me.ButtonNastepny.UseVisualStyleBackColor = True
        '
        'ButtonPoprzedni
        '
        Me.ButtonPoprzedni.Location = New System.Drawing.Point(385, 390)
        Me.ButtonPoprzedni.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPoprzedni.Name = "ButtonPoprzedni"
        Me.ButtonPoprzedni.Size = New System.Drawing.Size(56, 36)
        Me.ButtonPoprzedni.TabIndex = 2
        Me.ButtonPoprzedni.Text = "<"
        Me.ButtonPoprzedni.UseVisualStyleBackColor = True
        '
        'ButtonPoczatek
        '
        Me.ButtonPoczatek.Location = New System.Drawing.Point(324, 390)
        Me.ButtonPoczatek.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPoczatek.Name = "ButtonPoczatek"
        Me.ButtonPoczatek.Size = New System.Drawing.Size(56, 36)
        Me.ButtonPoczatek.TabIndex = 1
        Me.ButtonPoczatek.Text = "<<"
        Me.ButtonPoczatek.UseVisualStyleBackColor = True
        '
        'DataGridViewPojazdy
        '
        Me.DataGridViewPojazdy.AutoGenerateColumns = False
        Me.DataGridViewPojazdy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewPojazdy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPojazdy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.GenerationDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.OcenaDataGridViewTextBoxColumn, Me.iloscocen, Me.MetalicDataGridViewTextBoxColumn, Me.AcDataGridViewTextBoxColumn, Me.AbsDataGridViewTextBoxColumn, Me.EspDataGridViewTextBoxColumn, Me.ParkDataGridViewTextBoxColumn, Me.KeylessDataGridViewTextBoxColumn})
        Me.DataGridViewPojazdy.DataSource = Me.CarsDatabaseBindingSource
        Me.DataGridViewPojazdy.Location = New System.Drawing.Point(20, 27)
        Me.DataGridViewPojazdy.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewPojazdy.Name = "DataGridViewPojazdy"
        Me.DataGridViewPojazdy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewPojazdy.RowTemplate.Height = 24
        Me.DataGridViewPojazdy.Size = New System.Drawing.Size(879, 344)
        Me.DataGridViewPojazdy.TabIndex = 15
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 41
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Producent"
        Me.BrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.Width = 81
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.Width = 61
        '
        'GenerationDataGridViewTextBoxColumn
        '
        Me.GenerationDataGridViewTextBoxColumn.DataPropertyName = "generation"
        Me.GenerationDataGridViewTextBoxColumn.HeaderText = "Rok prod."
        Me.GenerationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenerationDataGridViewTextBoxColumn.Name = "GenerationDataGridViewTextBoxColumn"
        Me.GenerationDataGridViewTextBoxColumn.Width = 79
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Kolor"
        Me.ColorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.Width = 56
        '
        'OcenaDataGridViewTextBoxColumn
        '
        Me.OcenaDataGridViewTextBoxColumn.DataPropertyName = "ocena"
        Me.OcenaDataGridViewTextBoxColumn.HeaderText = "Ocena"
        Me.OcenaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OcenaDataGridViewTextBoxColumn.Name = "OcenaDataGridViewTextBoxColumn"
        Me.OcenaDataGridViewTextBoxColumn.Width = 64
        '
        'iloscocen
        '
        Me.iloscocen.DataPropertyName = "ilosc_ocen"
        Me.iloscocen.HeaderText = "Ilość ocen"
        Me.iloscocen.Name = "iloscocen"
        Me.iloscocen.Width = 81
        '
        'MetalicDataGridViewTextBoxColumn
        '
        Me.MetalicDataGridViewTextBoxColumn.DataPropertyName = "metalic"
        Me.MetalicDataGridViewTextBoxColumn.HeaderText = "Kolor met."
        Me.MetalicDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MetalicDataGridViewTextBoxColumn.Name = "MetalicDataGridViewTextBoxColumn"
        Me.MetalicDataGridViewTextBoxColumn.Width = 79
        '
        'AcDataGridViewTextBoxColumn
        '
        Me.AcDataGridViewTextBoxColumn.DataPropertyName = "ac"
        Me.AcDataGridViewTextBoxColumn.HeaderText = "AC"
        Me.AcDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AcDataGridViewTextBoxColumn.Name = "AcDataGridViewTextBoxColumn"
        Me.AcDataGridViewTextBoxColumn.Width = 46
        '
        'AbsDataGridViewTextBoxColumn
        '
        Me.AbsDataGridViewTextBoxColumn.DataPropertyName = "abs"
        Me.AbsDataGridViewTextBoxColumn.HeaderText = "ABS"
        Me.AbsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AbsDataGridViewTextBoxColumn.Name = "AbsDataGridViewTextBoxColumn"
        Me.AbsDataGridViewTextBoxColumn.Width = 53
        '
        'EspDataGridViewTextBoxColumn
        '
        Me.EspDataGridViewTextBoxColumn.DataPropertyName = "esp"
        Me.EspDataGridViewTextBoxColumn.HeaderText = "ESP"
        Me.EspDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EspDataGridViewTextBoxColumn.Name = "EspDataGridViewTextBoxColumn"
        Me.EspDataGridViewTextBoxColumn.Width = 53
        '
        'ParkDataGridViewTextBoxColumn
        '
        Me.ParkDataGridViewTextBoxColumn.DataPropertyName = "park"
        Me.ParkDataGridViewTextBoxColumn.HeaderText = "Czujniki"
        Me.ParkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ParkDataGridViewTextBoxColumn.Name = "ParkDataGridViewTextBoxColumn"
        Me.ParkDataGridViewTextBoxColumn.Width = 68
        '
        'KeylessDataGridViewTextBoxColumn
        '
        Me.KeylessDataGridViewTextBoxColumn.DataPropertyName = "keyless"
        Me.KeylessDataGridViewTextBoxColumn.HeaderText = "System bezkl."
        Me.KeylessDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KeylessDataGridViewTextBoxColumn.Name = "KeylessDataGridViewTextBoxColumn"
        Me.KeylessDataGridViewTextBoxColumn.Width = 97
        '
        'CarsDatabaseBindingSource
        '
        Me.CarsDatabaseBindingSource.DataMember = "CarsDatabase"
        Me.CarsDatabaseBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.KomisDBDataSet
        Me.BindingSource1.Position = 0
        '
        'KomisDBDataSet
        '
        Me.KomisDBDataSet.DataSetName = "KomisDBDataSet"
        Me.KomisDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSzukaj
        '
        Me.ButtonSzukaj.Location = New System.Drawing.Point(850, 131)
        Me.ButtonSzukaj.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSzukaj.Name = "ButtonSzukaj"
        Me.ButtonSzukaj.Size = New System.Drawing.Size(101, 35)
        Me.ButtonSzukaj.TabIndex = 6
        Me.ButtonSzukaj.Text = "Szukaj"
        Me.ButtonSzukaj.UseVisualStyleBackColor = True
        '
        'CheckBoxLakierMetalik
        '
        Me.CheckBoxLakierMetalik.AutoSize = True
        Me.CheckBoxLakierMetalik.Enabled = False
        Me.CheckBoxLakierMetalik.Location = New System.Drawing.Point(28, 56)
        Me.CheckBoxLakierMetalik.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxLakierMetalik.Name = "CheckBoxLakierMetalik"
        Me.CheckBoxLakierMetalik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxLakierMetalik.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxLakierMetalik.TabIndex = 0
        Me.CheckBoxLakierMetalik.Text = "Lakier metaliczny"
        Me.CheckBoxLakierMetalik.UseVisualStyleBackColor = True
        '
        'CheckBoxCzujniki
        '
        Me.CheckBoxCzujniki.AutoSize = True
        Me.CheckBoxCzujniki.Enabled = False
        Me.CheckBoxCzujniki.Location = New System.Drawing.Point(15, 82)
        Me.CheckBoxCzujniki.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxCzujniki.Name = "CheckBoxCzujniki"
        Me.CheckBoxCzujniki.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxCzujniki.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxCzujniki.TabIndex = 0
        Me.CheckBoxCzujniki.Text = "Czujniki parkowania"
        Me.CheckBoxCzujniki.UseVisualStyleBackColor = True
        '
        'CheckBoxESP
        '
        Me.CheckBoxESP.AutoSize = True
        Me.CheckBoxESP.Enabled = False
        Me.CheckBoxESP.Location = New System.Drawing.Point(222, 56)
        Me.CheckBoxESP.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxESP.Name = "CheckBoxESP"
        Me.CheckBoxESP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxESP.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxESP.TabIndex = 1
        Me.CheckBoxESP.Text = "ESP"
        Me.CheckBoxESP.UseVisualStyleBackColor = True
        '
        'CheckBoxABS
        '
        Me.CheckBoxABS.AutoSize = True
        Me.CheckBoxABS.Enabled = False
        Me.CheckBoxABS.Location = New System.Drawing.Point(222, 31)
        Me.CheckBoxABS.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxABS.Name = "CheckBoxABS"
        Me.CheckBoxABS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxABS.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxABS.TabIndex = 2
        Me.CheckBoxABS.Text = "ABS"
        Me.CheckBoxABS.UseVisualStyleBackColor = True
        '
        'CheckBoxKlimatyzacja
        '
        Me.CheckBoxKlimatyzacja.AutoSize = True
        Me.CheckBoxKlimatyzacja.Enabled = False
        Me.CheckBoxKlimatyzacja.Location = New System.Drawing.Point(51, 31)
        Me.CheckBoxKlimatyzacja.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxKlimatyzacja.Name = "CheckBoxKlimatyzacja"
        Me.CheckBoxKlimatyzacja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKlimatyzacja.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxKlimatyzacja.TabIndex = 3
        Me.CheckBoxKlimatyzacja.Text = "Klimatyzacja"
        Me.CheckBoxKlimatyzacja.UseVisualStyleBackColor = True
        '
        'CheckBoxKeyless
        '
        Me.CheckBoxKeyless.AutoSize = True
        Me.CheckBoxKeyless.Enabled = False
        Me.CheckBoxKeyless.Location = New System.Drawing.Point(195, 82)
        Me.CheckBoxKeyless.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxKeyless.Name = "CheckBoxKeyless"
        Me.CheckBoxKeyless.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxKeyless.Size = New System.Drawing.Size(74, 17)
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
        Me.GroupBoxWyposażenie.Location = New System.Drawing.Point(28, 311)
        Me.GroupBoxWyposażenie.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWyposażenie.Name = "GroupBoxWyposażenie"
        Me.GroupBoxWyposażenie.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxWyposażenie.Size = New System.Drawing.Size(348, 132)
        Me.GroupBoxWyposażenie.TabIndex = 7
        Me.GroupBoxWyposażenie.TabStop = False
        Me.GroupBoxWyposażenie.Text = "Wyposażenie"
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Enabled = False
        Me.ButtonDodaj.Location = New System.Drawing.Point(850, 172)
        Me.ButtonDodaj.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(101, 35)
        Me.ButtonDodaj.TabIndex = 9
        Me.ButtonDodaj.Text = "Dodaj"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'ButtonUsun
        '
        Me.ButtonUsun.Enabled = False
        Me.ButtonUsun.Location = New System.Drawing.Point(850, 212)
        Me.ButtonUsun.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUsun.Name = "ButtonUsun"
        Me.ButtonUsun.Size = New System.Drawing.Size(101, 35)
        Me.ButtonUsun.TabIndex = 10
        Me.ButtonUsun.Text = "Usuń"
        Me.ButtonUsun.UseVisualStyleBackColor = True
        '
        'ButtonEdytuj
        '
        Me.ButtonEdytuj.Enabled = False
        Me.ButtonEdytuj.Location = New System.Drawing.Point(850, 251)
        Me.ButtonEdytuj.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdytuj.Name = "ButtonEdytuj"
        Me.ButtonEdytuj.Size = New System.Drawing.Size(101, 35)
        Me.ButtonEdytuj.TabIndex = 11
        Me.ButtonEdytuj.Text = "Edytuj"
        Me.ButtonEdytuj.UseVisualStyleBackColor = True
        '
        'ButtonZapis
        '
        Me.ButtonZapis.Enabled = False
        Me.ButtonZapis.Location = New System.Drawing.Point(850, 328)
        Me.ButtonZapis.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonZapis.Name = "ButtonZapis"
        Me.ButtonZapis.Size = New System.Drawing.Size(101, 35)
        Me.ButtonZapis.TabIndex = 12
        Me.ButtonZapis.Text = "Zapisz"
        Me.ButtonZapis.UseVisualStyleBackColor = True
        '
        'ButtonAnuluj
        '
        Me.ButtonAnuluj.Enabled = False
        Me.ButtonAnuluj.Location = New System.Drawing.Point(850, 290)
        Me.ButtonAnuluj.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAnuluj.Name = "ButtonAnuluj"
        Me.ButtonAnuluj.Size = New System.Drawing.Size(101, 35)
        Me.ButtonAnuluj.TabIndex = 13
        Me.ButtonAnuluj.Text = "Anuluj"
        Me.ButtonAnuluj.UseVisualStyleBackColor = True
        '
        'CarsDatabaseTableAdapter
        '
        Me.CarsDatabaseTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.UżytkownikToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZamknijToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'UżytkownikToolStripMenuItem
        '
        Me.UżytkownikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdytujToolStripMenuItem, Me.WylogujToolStripMenuItem1})
        Me.UżytkownikToolStripMenuItem.Name = "UżytkownikToolStripMenuItem"
        Me.UżytkownikToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.UżytkownikToolStripMenuItem.Text = "Użytkownik"
        '
        'EdytujToolStripMenuItem
        '
        Me.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem"
        Me.EdytujToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EdytujToolStripMenuItem.Text = "Edytuj"
        '
        'WylogujToolStripMenuItem1
        '
        Me.WylogujToolStripMenuItem1.Name = "WylogujToolStripMenuItem1"
        Me.WylogujToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.WylogujToolStripMenuItem1.Text = "Wyloguj"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelWelcome)
        Me.GroupBox1.Location = New System.Drawing.Point(850, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(101, 45)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Witaj"
        '
        'PictureBoxCar
        '
        Me.PictureBoxCar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxCar.Location = New System.Drawing.Point(417, 230)
        Me.PictureBoxCar.Name = "PictureBoxCar"
        Me.PictureBoxCar.Size = New System.Drawing.Size(400, 200)
        Me.PictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxCar.TabIndex = 18
        Me.PictureBoxCar.TabStop = False
        '
        'CarRateControlKomis
        '
        Me.CarRateControlKomis.CarName = ""
        Me.CarRateControlKomis.HistoryType = Aplikacja_Komis.CarRateControl.HistoryTypeOptions.Wartosc
        Me.CarRateControlKomis.Location = New System.Drawing.Point(395, 55)
        Me.CarRateControlKomis.Margin = New System.Windows.Forms.Padding(2)
        Me.CarRateControlKomis.Name = "CarRateControlKomis"
        Me.CarRateControlKomis.Ocena = 0
        Me.CarRateControlKomis.RateHistory1 = ""
        Me.CarRateControlKomis.RateHistory2 = ""
        Me.CarRateControlKomis.RateHistory3 = ""
        Me.CarRateControlKomis.Size = New System.Drawing.Size(436, 160)
        Me.CarRateControlKomis.TabIndex = 16
        '
        'ZamknijToolStripMenuItem
        '
        Me.ZamknijToolStripMenuItem.Name = "ZamknijToolStripMenuItem"
        Me.ZamknijToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ZamknijToolStripMenuItem.Text = "Zamknij"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1009, 933)
        Me.Controls.Add(Me.PictureBoxCar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CarRateControlKomis)
        Me.Controls.Add(Me.ButtonAnuluj)
        Me.Controls.Add(Me.ButtonZapis)
        Me.Controls.Add(Me.ButtonEdytuj)
        Me.Controls.Add(Me.ButtonUsun)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Controls.Add(Me.GroupBoxWyposażenie)
        Me.Controls.Add(Me.GroupBoxWynikWyszukiwania)
        Me.Controls.Add(Me.GroupBoxWybierzPojazd)
        Me.Controls.Add(Me.ButtonSzukaj)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikacja Komis"
        Me.GroupBoxWybierzPojazd.ResumeLayout(False)
        Me.GroupBoxWybierzPojazd.PerformLayout()
        Me.GroupBoxWynikWyszukiwania.ResumeLayout(False)
        Me.GroupBoxWynikWyszukiwania.PerformLayout()
        CType(Me.DataGridViewPojazdy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsDatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KomisDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxWyposażenie.ResumeLayout(False)
        Me.GroupBoxWyposażenie.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxMarka As ComboBox
    Friend WithEvents GroupBoxWybierzPojazd As GroupBox
    Friend WithEvents LabelWelcome As Label
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
    Friend WithEvents ButtonDodaj As Button
    Friend WithEvents ButtonUsun As Button
    Friend WithEvents ButtonEdytuj As Button
    Friend WithEvents CarsDatabaseTableAdapter As KomisDBDataSetTableAdapters.CarsDatabaseTableAdapter
    Friend WithEvents ButtonWyczyscMarke As Button
    Friend WithEvents ButtonWyczyscOcena As Button
    Friend WithEvents ButtonWyczyscKolor As Button
    Friend WithEvents ButtonWyczyscModel As Button
    Friend WithEvents ButtonZapis As Button
    Friend WithEvents ButtonAnuluj As Button
    Friend WithEvents RocznikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPojazdy As DataGridView
    Friend WithEvents CarsDatabaseBindingSource As BindingSource
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents KomisDBDataSet As KomisDBDataSet
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UżytkownikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WylogujToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IloscocenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarRateControlKomis As CarRateControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenerationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OcenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents iloscocen As DataGridViewTextBoxColumn
    Friend WithEvents MetalicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeylessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBoxCar As PictureBox
    Friend WithEvents ZamknijToolStripMenuItem As ToolStripMenuItem
End Class
