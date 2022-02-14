Imports System.Data.SqlClient
Public Class MainForm
    Public Class GlobalVariables
        'Public Shared DatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
        Public Shared ImgDir = "C:\Users\Karol\source\repos\Aplikacja_Komis\grafika\"
        Public Shared database_path As String = "C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf"
        'Public Shared database_path As String = Application.StartupPath + "\KomisDB.mdf"
        'Public Shared ImgDir = Application.StartupPath + "\grafika\"
        Public Shared DatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + database_path + ";Integrated Security=True"
        Public Shared SelectedModel As String
        Public Shared SelectedBrand As String
        Public Shared SelectedColor As String
        Public Shared SelectedOcena As Integer
        Public Shared SelectedId As Integer
        Public Shared RowBrand As String
        Public Shared RowModel As String
        Public Shared RowColor As String
        Public Shared RowGeneration As String
        Public Shared RowOcena As String
        Public Shared RowAbs As String
        Public Shared RowEsp As String
        Public Shared RowMetalik As String
        Public Shared RowKlima As String
        Public Shared RowPark As String
        Public Shared RowKeyless As String
    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SzukajPojazdow()
        LabelAktualnyRekord.Text = CarsDatabaseBindingSource.Position.ToString()
        LabelWszystkieRekordy.Text = CarsDatabaseBindingSource.Count()
        GroupBoxWynikWyszukiwania.Enabled = True
        LabelWelcome.Text = FormLogowanie.PassUserName
        FormLogowanie.Hide()
        GetCarBrandList()
        Console.WriteLine("User type: " + FormLogowanie.PassUserType)
        If FormLogowanie.PassUserType = "admin" Then
            ButtonEdytuj.Enabled = True
            ButtonUsun.Enabled = True
            ButtonDodaj.Enabled = True
        End If
        OdczytOcenianegoPojazdu(DataGridViewPojazdy, CarsDatabaseBindingSource, CarRateControlKomis)
        Console.WriteLine("Start up path: " + Application.StartupPath)
        LoadCarImage()
        AktualizujHistorieOcen()
    End Sub

    Function GetCarBrandList()
        'Dim queryString As String = "SELECT * FROM dbo.CarBrand;"
        Dim queryString As String = "SELECT * FROM dbo.CarsBrandList ORDER BY Id;"
        Dim reader As System.Data.SqlClient.SqlDataReader
        'queryString = String.Format(msg, TextBoxLogin.Text)


        Using connection As New SqlConnection(GlobalVariables.DatabaseConStr)
            Dim row_id As Integer
            Dim row_name As String
            Dim command As New SqlCommand(queryString, connection)
            Dim result As Boolean
            Dim error_cnt As Integer = 0

            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                MessageBox.Show("Nie można połączyć się z bazą danych w celu odczytania listy producentów")
                result = False
            End Try

            If result = True Then
                Try
                    reader = command.ExecuteReader()
                    ComboBoxMarka.Items.Clear()
                    While reader.Read()
                        'Console.WriteLine(reader.FieldCount.ToString())
                        row_id = reader(0)
                        row_name = reader(1)
                        If row_id > 0 And row_name IsNot String.Empty Then
                            ComboBoxMarka.Items.Insert(row_id - 1, row_name)
                            'Console.WriteLine(row_id.ToString() + "." + row_name.ToString)
                        Else
                            Console.WriteLine("Empty data !")
                            error_cnt += 1
                        End If
                    End While
                Catch ex As Exception
                    MessageBox.Show("Nie udało sie odczytac listy producentow")
                    error_cnt += 1
                End Try

                'If error_cnt = 0 Then
                'tutaj odswiez tabele
                'End If
            End If
            command.Connection.Close()
            command.Connection.Dispose()
        End Using
    End Function

    Function GetCarModelList(ByVal brand_name As String)
        'Dim msg As String = "SELECT * FROM dbo.CarModels WHERE brand_id = {0};"
        Dim msg As String = "SELECT * FROM dbo.CarsModelList WHERE BrandName = '{0}' ORDER BY Name;"
        'Dim msg As String = "SELECT Id, model FROM dbo.CarsNewTable WHERE brand = '{0}';"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim queryString As String

        queryString = String.Format(msg, brand_name)


        Using connection As New SqlConnection(GlobalVariables.DatabaseConStr)
            Dim row_id As Integer = 0
            Dim row_name As String
            Dim command As New SqlCommand(queryString, connection)
            'Dim command As New SqlCommand(msg, connection)
            Dim result As Boolean
            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                MessageBox.Show("Nie można połączyć się z bazą danych")
                result = False
            End Try

            If result = True Then
                Try
                    reader = command.ExecuteReader()
                    ComboBoxModel.Items.Clear()
                    While reader.Read()
                        'Console.WriteLine(reader.FieldCount.ToString())
                        row_name = reader(1)
                        If row_name IsNot String.Empty Then
                            ComboBoxModel.Items.Insert(row_id, row_name)
                            row_id += 1
                            Console.WriteLine(row_id.ToString() + "." + row_name.ToString)
                        Else
                            Console.WriteLine("Empty data !")
                        End If
                    End While
                Catch ex As Exception
                    MessageBox.Show("Nie udało sie odczytac listy modeli")
                End Try
            Else
                Console.WriteLine("Nie udane połączenie z bazą")
            End If
            command.Connection.Close()
            command.Connection.Dispose()
        End Using
    End Function

    Function GetCarColorList()
        Dim queryString As String = "SELECT * FROM dbo.CarsColorlList ORDER BY Name;"
        'Dim queryString As String = "SELECT * FROM dbo.CarsModelList WHERE BrandName = '' ORDER BY Name;"
        Dim reader As System.Data.SqlClient.SqlDataReader

        Using connection As New SqlConnection(GlobalVariables.DatabaseConStr)
            Dim row_id As Integer = 0
            Dim row_name As String
            Dim command As New SqlCommand(queryString, connection)
            Dim result As Boolean

            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                MessageBox.Show("Nie można połączyć się z bazą kolorow")
                result = False
            End Try

            If result = True Then
                Try
                    reader = command.ExecuteReader()
                    Console.WriteLine(reader(0) + "." + reader(1))
                    'While reader.Read()
                    'row_name = reader(1)
                    'If row_name IsNot String.Empty Then
                    'ComboBoxKolor.Items.Insert(row_id, row_name)
                    'row_id += 1
                    'Console.WriteLine(row_id.ToString() + "." + row_name.ToString)
                    'Else
                    Console.WriteLine("Empty data !")
                    '    End If
                    'End While
                Catch ex As Exception
                    MessageBox.Show("Nie udało sie odczytac listy kolorów")
                End Try
            Else
                Console.WriteLine("Nie udane połączenie z bazą kolorów")
            End If
        End Using
    End Function

    ''------------------------------------------------------------
    ''                       Combo Boxe's
    ''-------------------------------------------------------------

    Private Sub ComboBoxMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMarka.SelectedIndexChanged
        Console.WriteLine("Producent Samochodu wybrany !")
        Console.WriteLine(ComboBoxMarka.SelectedItem)
        ComboBoxModel.Enabled = True
        GlobalVariables.SelectedBrand = ComboBoxMarka.SelectedItem
        GetCarModelList(GlobalVariables.SelectedBrand)
        ComboBoxKolor.Enabled = True
        ComboBoxModel.Enabled = True
        CheckBoxABS.Enabled = True
        CheckBoxCzujniki.Enabled = True
        CheckBoxESP.Enabled = True
        CheckBoxKeyless.Enabled = True
        CheckBoxKlimatyzacja.Enabled = True
        CheckBoxLakierMetalik.Enabled = True
        'GetCarColorList()
    End Sub

    Private Sub ComboBoxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModel.SelectedIndexChanged
        ComboBoxKolor.Enabled = True
        GlobalVariables.SelectedModel = ComboBoxModel.SelectedItem
        'GetCarColorList()
    End Sub

    Private Sub ComboBoxKolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKolor.SelectedIndexChanged
        ComboBoxOcenaPowyzej.Enabled = True
        GlobalVariables.SelectedColor = ComboBoxKolor.SelectedItem
    End Sub

    Private Sub ComboBoxOcenaPowyzej_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOcenaPowyzej.SelectedIndexChanged
        GlobalVariables.SelectedOcena = ComboBoxOcenaPowyzej.SelectedItem
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLakierMetalik.CheckedChanged

    End Sub

    ''------------------------------------------------------------
    ''                       BUTTONS
    ''-------------------------------------------------------------
    Private Sub ButtonSzukaj_Click(sender As Object, e As EventArgs) Handles ButtonSzukaj.Click
        SzukajPojazdow()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ComboBoxKolor.SelectedItem = Nothing
        GetCarColorList()
    End Sub

    Private Sub ButtonWyczyscMarke_Click(sender As Object, e As EventArgs) Handles ButtonWyczyscMarke.Click
        ComboBoxMarka.SelectedItem = Nothing
        ComboBoxKolor.Enabled = False
        ComboBoxModel.Enabled = False
        CheckBoxABS.Enabled = False
        CheckBoxCzujniki.Enabled = False
        CheckBoxESP.Enabled = False
        CheckBoxKeyless.Enabled = False
        CheckBoxKlimatyzacja.Enabled = False
        CheckBoxLakierMetalik.Enabled = False
    End Sub

    Private Sub ButtonWyczyscModel_Click(sender As Object, e As EventArgs) Handles ButtonWyczyscModel.Click
        ComboBoxModel.SelectedItem = Nothing
    End Sub

    Private Sub ButtonWyczyscKolor_Click(sender As Object, e As EventArgs) Handles ButtonWyczyscKolor.Click
        ComboBoxKolor.SelectedItem = Nothing
    End Sub

    Private Sub ButtonWyczyscOcena_Click(sender As Object, e As EventArgs) Handles ButtonWyczyscOcena.Click
        ComboBoxOcenaPowyzej.SelectedItem = Nothing
    End Sub

    Private Sub CheckBoxKlimatyzacja_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxKlimatyzacja.CheckedChanged

    End Sub

    Private Sub ButtonNastepny_Click(sender As Object, e As EventArgs) Handles ButtonNastepny.Click
        CarsDatabaseBindingSource.Position += 1
        LabelAktualnyRekord.Text = CarsDatabaseBindingSource.Position.ToString()
        LoadCarImage()
    End Sub

    Private Sub ButtonPoprzedni_Click(sender As Object, e As EventArgs) Handles ButtonPoprzedni.Click
        CarsDatabaseBindingSource.Position -= 1
        LabelAktualnyRekord.Text = CarsDatabaseBindingSource.Position.ToString()
        LoadCarImage()
    End Sub

    Private Sub ButtonKoniec_Click(sender As Object, e As EventArgs) Handles ButtonKoniec.Click
        CarsDatabaseBindingSource.Position = CarsDatabaseBindingSource.Count - 1
        LoadCarImage()
    End Sub

    Private Sub ButtonPoczatek_Click(sender As Object, e As EventArgs) Handles ButtonPoczatek.Click
        CarsDatabaseBindingSource.Position = 0
        LoadCarImage()
    End Sub

    Private Sub ButtonEdytuj_Click(sender As Object, e As EventArgs) Handles ButtonEdytuj.Click
        Dim id As Integer = DataGridViewPojazdy.Rows(CarsDatabaseBindingSource.Position).Cells(0).Value
        GetRow(id)
        EditCarForm.Show()
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        AddNewCar.Show()
        'Me.Close()
    End Sub
    Private Sub ButtonUsun_Click(sender As Object, e As EventArgs) Handles ButtonUsun.Click
        Dim id As Integer = DataGridViewPojazdy.Rows(CarsDatabaseBindingSource.Position).Cells(0).Value
        DeleteCar(GlobalVariables.DatabaseConStr, id)
    End Sub

    ''------------------------------------------------------------
    ''                       FUNCTIONS
    ''-------------------------------------------------------------
    Function SzukajPojazdow()
        Dim queryBase As String = "SELECT * FROM dbo.CarsDatabase"
        Dim queryComplete As String
        Dim connection As SqlConnection = New SqlConnection()
        Dim ds As DataSet = New DataSet()

        If GlobalVariables.SelectedBrand IsNot Nothing Then
            queryComplete = queryBase + " WHERE brand = '{0}'"
            queryComplete = String.Format(queryComplete, GlobalVariables.SelectedBrand)

            If GlobalVariables.SelectedModel IsNot Nothing Then
                Dim model_filtr As String = " AND model = '{0}'"
                model_filtr = String.Format(model_filtr, GlobalVariables.SelectedModel)
                queryComplete = queryComplete + model_filtr
            End If

            If GlobalVariables.SelectedColor IsNot Nothing Then
                Dim color_filtr As String = " AND color = '{0}'"
                color_filtr = String.Format(color_filtr, GlobalVariables.SelectedColor)
                queryComplete = queryComplete + color_filtr
            End If

            If GlobalVariables.SelectedOcena > 0 Then
                Dim ocena_filtr As String = " AND ocena = {0}"
                ocena_filtr = String.Format(ocena_filtr, GlobalVariables.SelectedOcena)
                queryComplete = queryComplete + ocena_filtr
            End If

            If CheckBoxKlimatyzacja.Checked Then
                Dim klima_filtr As String = " AND ac = {0}"
                klima_filtr = String.Format(klima_filtr, "1")
                queryComplete = queryComplete + klima_filtr
            End If

            If CheckBoxLakierMetalik.Checked Then
                Dim metalik_filtr As String = " AND metalic = {0}"
                metalik_filtr = String.Format(metalik_filtr, "1")
                queryComplete = queryComplete + metalik_filtr
            End If

            If CheckBoxCzujniki.Checked Then
                Dim czujniki_filtr As String = " AND park = {0}"
                czujniki_filtr = String.Format(czujniki_filtr, "1")
                queryComplete = queryComplete + czujniki_filtr
            End If

            If CheckBoxABS.Checked Then
                Dim abs_filtr As String = " AND abs = {0}"
                abs_filtr = String.Format(abs_filtr, "1")
                queryComplete = queryComplete + abs_filtr
            End If

            If CheckBoxESP.Checked Then
                Dim esp_filtr As String = " AND esp = {0}"
                esp_filtr = String.Format(esp_filtr, "1")
                queryComplete = queryComplete + esp_filtr
            End If

            If CheckBoxKeyless.Checked Then
                Dim keyless_filtr As String = " AND keyless = {0}"
                keyless_filtr = String.Format(keyless_filtr, "1")
                queryComplete = queryComplete + keyless_filtr
            End If
        Else
            queryComplete = queryBase
        End If
        queryComplete = queryComplete + ";"

        Dim adp As SqlDataAdapter = New SqlDataAdapter(queryComplete, connection)
        Console.WriteLine("Query = " + queryComplete)
        connection.ConnectionString = GlobalVariables.DatabaseConStr
        connection.Open()
        adp.Fill(ds)
        'DataGridViewPojazdy.DataSource = ds.Tables(0)
        CarsDatabaseBindingSource.DataSource = ds.Tables(0)
    End Function

    Function DeleteCar(ByVal connectionString As String, ByVal car_id As Integer) As Integer
        Dim queryDelete As String = "DELETE FROM dbo.CarsDatabase WHERE Id={0}"
        Dim reader As System.Data.SqlClient.SqlDataReader

        queryDelete = String.Format(queryDelete, car_id)

        Try
            FormLogowanie.CreateCommand(queryDelete, connectionString)
            MessageBox.Show("Pojazd został usunięty z bazy.", "Potwierdzenie", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Wystąpił błąd podczas usuwania tego pojazdu.", "Blad", MessageBoxButtons.OK)
            Return 0
        End Try

        SzukajPojazdow()
        Return 1
    End Function

    Function GetRow(ByVal Id As Integer) As Integer
        'Dim queryString As String = "SELECT * FROM dbo.CarBrand;"
        Dim queryString As String = "SELECT * FROM dbo.CarsDatabase Where Id={0} ORDER BY Id;"
        Dim reader As System.Data.SqlClient.SqlDataReader
        queryString = String.Format(queryString, Id)


        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
            Dim row_id As Integer
            Dim row_name As String
            Dim command As New SqlCommand(queryString, connection)
            Dim result As Boolean
            Dim error_cnt As Integer = 0

            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                MessageBox.Show("Nie można połączyć się z bazą danych w celu odczytania listy producentów")
                result = False
            End Try

            If result = True Then
                Try
                    reader = command.ExecuteReader()
                    'ComboBoxMarka.Items.Clear()
                    While reader.Read()
                        Console.WriteLine(reader(0).ToString + "," + reader(1).ToString + "," + reader(2).ToString + "," + reader(3).ToString)
                        Console.WriteLine(reader(4).ToString + "," + reader(5).ToString + "," + reader(6).ToString + "," + reader(7).ToString)
                        GlobalVariables.RowBrand = reader(1).ToString()
                        GlobalVariables.RowModel = reader(2).ToString()
                        GlobalVariables.RowGeneration = reader(3).ToString()
                        GlobalVariables.RowColor = reader(4).ToString()
                        GlobalVariables.RowOcena = reader(5).ToString()
                        GlobalVariables.RowMetalik = reader(6)
                        GlobalVariables.RowKlima = reader(7)
                        GlobalVariables.RowAbs = reader(8)
                        GlobalVariables.RowEsp = reader(9)
                        GlobalVariables.RowPark = reader(10)
                        GlobalVariables.RowKeyless = reader(11).ToString()
                    End While
                Catch ex As Exception
                    MessageBox.Show("Nie udało sie odczytac listy producentow")
                    error_cnt += 1
                End Try

                'If error_cnt = 0 Then
                'tutaj odswiez tabele
                'End If
            End If
            command.Connection.Close()
            command.Connection.Dispose()
        End Using
        Return 1
    End Function



    Function OcenPojazd(ByVal connectionString As String, ByVal car_id As Integer, ByVal ocena As Decimal, ByVal ilosc_ocen As Integer) As Integer
        Dim AddRateQuery As String = "UPDATE dbo.CarsDatabase SET ocena=" + ocena.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + ", ilosc_ocen=" + ilosc_ocen.ToString() + " WHERE Id=" + car_id.ToString() + ";"

        Console.WriteLine(AddRateQuery)
        'AddRateQuery = String.Format(AddRateQuery, ocena, ilosc_ocen, car_id)



        Try
            Using connection As New SqlConnection(connectionString)
                Dim id As New Integer
                Dim command As New SqlCommand(AddRateQuery, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()
            End Using
            MessageBox.Show("Ocena zostala zaktualizowana.", "Potwierdzenie", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Wystąpił błąd podczas dodawania oceny dla tego pojazdu.", "Blad", MessageBoxButtons.OK)
            Return 0
        End Try

        Return 1
    End Function

    Private Sub CarsDatabaseBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles CarsDatabaseBindingSource.PositionChanged
        OdczytOcenianegoPojazdu(DataGridViewPojazdy, CarsDatabaseBindingSource, CarRateControlKomis)
        'LoadCarImage()
        'Console.WriteLine(DataGridViewPojazdy.Rows(CarsDatabaseBindingSource.Position).Cells(12).Value)
        'PictureBoxCar.Image = Image.FromFile("C:\Users\Karol\source\repos\Aplikacja_Komis\grafika\img1.jpg")
        'PictureBoxCar.Image = Image.FromFile(GlobalVariables.ImgDir + img)

    End Sub

    Function LoadCarImage()
        Dim id As Integer = DataGridViewPojazdy.Rows(CarsDatabaseBindingSource.Position).Cells(0).Value
        Dim img As String = GetImageName(id)
        Console.WriteLine("Id pojazdu: " + id.ToString())
        Console.WriteLine(GlobalVariables.ImgDir + img)
        Try
            PictureBoxCar.Image = Image.FromFile(GlobalVariables.ImgDir + img)
            'PictureBoxCar.ImageLocation = GlobalVariables.ImgDir + img
        Catch ex As Exception
            Console.WriteLine("Nie mozna zaladowac obrazu")
            PictureBoxCar.Image = Image.FromFile(GlobalVariables.ImgDir + "default.jpg")
        End Try
    End Function
    Function OdczytOcenianegoPojazdu(ByRef dgv As DataGridView, ByRef bs As BindingSource, ByRef crcontrol As CarRateControl) As Integer
        Dim spacja As String = " "
        Dim marka_poj As String = String.Empty
        Dim model_poj As String = String.Empty
        Dim rocznik_poj As String = String.Empty

        If dgv.Rows(bs.Position).Cells(1).Value IsNot DBNull.Value Then
            marka_poj = dgv.Rows(bs.Position).Cells(1).Value
        End If
        If dgv.Rows(bs.Position).Cells(2).Value IsNot DBNull.Value Then
            model_poj = dgv.Rows(bs.Position).Cells(2).Value
        End If
        If dgv.Rows(bs.Position).Cells(3).Value IsNot DBNull.Value Then
            rocznik_poj = dgv.Rows(bs.Position).Cells(3).Value
        End If

        crcontrol.CarName = marka_poj + spacja + model_poj + spacja + rocznik_poj
        Return 0
    End Function

    Private Sub CarRateControlKomis_RateChange(value As Integer) Handles CarRateControlKomis.RateChange
        Dim id As Integer = DataGridViewPojazdy.Rows(CarsDatabaseBindingSource.Position).Cells(0).Value
        'Dim ocena As Decimal = Decimal.Parse(TextBox1.Text)
        Dim ocena As Decimal = CDec(CarRateControlKomis.Ocena)
        Dim queryString As String = "SELECT ocena, ilosc_ocen FROM dbo.CarsDatabase Where Id={0};"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim srednia As Decimal
        Dim suma As Decimal
        Dim ilosc_ocen As Integer

        Console.WriteLine("Id ocenianego pojazdu: " + id.ToString())
        Console.WriteLine("Ocena po konwersji ze stringa: " + ocena.ToString())

        queryString = String.Format(queryString, id)

        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
            Dim result As Boolean
            Dim command As New SqlCommand(queryString, connection)
            Try
                command.Connection.Open()
                result = True
                MessageBox.Show("Aktualna ocena odczytana")
            Catch ex As Exception
                MessageBox.Show("Nie można połączyć się z bazą danych w celu odczytania ocen")
                result = False
            End Try

            If result = True Then
                'Try
                reader = command.ExecuteReader()
                While reader.Read()
                    If reader.IsDBNull(0) Then
                        srednia = 0.0
                        Console.WriteLine("sredja jest pusta")
                    Else
                        srednia = Convert.ToDecimal(reader(0))
                    End If
                    If reader.IsDBNull(1) Then
                        ilosc_ocen = 0
                        Console.WriteLine("ilosc ocen jest pusta")
                    Else
                        ilosc_ocen = reader(1)
                    End If
                    Console.WriteLine("Ocena: " + srednia.ToString() + " Ilość ocen: " + ilosc_ocen.ToString())
                End While
                'Catch ex As Exception
                'MessageBox.Show("Nie udało sie odczytac listy ocen")
                'End Try
            End If
        End Using

        suma = srednia * ilosc_ocen
        suma = suma + ocena
        ilosc_ocen += 1
        srednia = (suma / ilosc_ocen)
        Console.WriteLine("Srednia: " + srednia.ToString() + "  Suma: " + suma.ToString() + " ilosc: " + ilosc_ocen.ToString())

        OcenPojazd(GlobalVariables.DatabaseConStr, id, srednia, ilosc_ocen)
        SzukajPojazdow()

        'MessageBox.Show("Ocena pojazdu sie zmienila.", "Potwierdzenie", MessageBoxButtons.OK)
        AktualizujHistorieOcen()
    End Sub

    Private Sub AktualizujHistorieOcen()
        Dim car1_id, car2_id, car3_id As Integer
        Console.WriteLine("History type: " + CarRateControlKomis.HistoryType.ToString())
        Get3BestId(CarRateControlKomis.HistoryType.ToString(), car1_id, car2_id, car3_id)
        CarRateControlKomis.RateHistory1 = GetRateHistory(CarRateControlKomis.HistoryType.ToString(), car1_id)
        CarRateControlKomis.RateHistory2 = GetRateHistory(CarRateControlKomis.HistoryType.ToString(), car2_id)
        CarRateControlKomis.RateHistory3 = GetRateHistory(CarRateControlKomis.HistoryType.ToString(), car3_id)
    End Sub

    Function Get3BestId(ByVal name As String, ByRef id1 As Integer, ByRef id2 As Integer, ByRef id3 As Integer)
        Dim column As String
        Dim query As String = "SELECT TOP (3) WITH ties Id, {0} FROM dbo.CarsDatabase ORDER BY {0} DESC;"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim i As Integer = 0

        If name = "Ilosc" Then
            column = "ilosc_ocen"
        Else
            column = "ocena"
        End If
        query = String.Format(query, column)
        Console.WriteLine(query)

        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
            Dim result As Boolean
            Dim command As New SqlCommand(query, connection)
            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                result = False
            End Try


            If result = True Then
                reader = command.ExecuteReader()
                While reader.Read()
                    i += 1
                    'Console.WriteLine(reader(0).ToString() + ", " + reader(1).ToString())
                    If i = 1 Then
                        id1 = reader(0)
                    End If
                    If i = 2 Then
                        id2 = reader(0)
                    End If
                    If i = 3 Then
                        id3 = reader(0)
                    End If
                End While
            End If
        End Using
    End Function

    Function GetRateHistory(ByVal name As String, ByVal id As Integer) As String
        Dim row_str As String
        Dim column As String
        Dim brand As String = String.Empty
        Dim model As String = String.Empty
        Dim year As String = String.Empty
        Dim value As String = String.Empty
        Dim sp As String = " "
        Dim query As String = "SELECT brand, model, generation, {1} From dbo.CarsDatabase WHERE Id ={0} Order By {1} DESC;"
        'Dim query As String = "SELECT TOP (3) WITH ties brand, model, generation, ilosc_ocen FROM dbo.CarsDatabase ORDER BY ilosc_ocen DESC;"
        Dim reader As System.Data.SqlClient.SqlDataReader

        If name = "Ilosc" Then
            column = "ilosc_ocen"
        Else
            column = "ocena"
        End If
        query = String.Format(query, id, column)
        Console.WriteLine(query)

        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
            Dim result As Boolean
            Dim command As New SqlCommand(query, connection)
            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                result = False
            End Try


            If result = True Then
                reader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        brand = reader(0)
                    End If
                    If Not reader.IsDBNull(1) Then
                        model = reader(1)
                    End If
                    If Not reader.IsDBNull(2) Then
                        year = reader(2)
                    End If
                    If Not reader.IsDBNull(3) Then
                        value = reader(3).ToString
                    End If
                End While
            End If
        End Using

        row_str = brand + sp + model + sp + year + sp + "-" + sp + value

        Return row_str
    End Function

    Function GetImageName(ByVal id As Integer) As String
        Dim image_name As String = String.Empty
        Dim sp As String = " "
        Dim query As String = "SELECT Id, image From dbo.CarsDatabase WHERE Id ={0};"
        Dim reader As System.Data.SqlClient.SqlDataReader

        query = String.Format(query, id)
        Console.WriteLine(query)

        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
            Dim result As Boolean
            Dim command As New SqlCommand(query, connection)
            Try
                command.Connection.Open()
                result = True
            Catch ex As Exception
                result = False
            End Try


            If result = True Then
                reader = command.ExecuteReader()
                While reader.Read()
                    If Not reader.IsDBNull(0) Then
                        image_name = reader(1).ToString()
                    End If
                End While
            End If
        End Using

        Return image_name
    End Function
End Class