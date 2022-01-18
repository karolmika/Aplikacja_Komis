﻿Imports System.Data.SqlClient
Public Class MainForm
    Public Class GlobalVariables
        Public Shared DatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
        Public Shared SelectedModel As String
        Public Shared SelectedBrand As String
        Public Shared SelectedColor As String
        Public Shared SelectedOcena As Integer
        Public Shared SelectedId As Integer
        Public Shared RowBrand As String
        Public Shared RowModel As String
        Public Shared RowColor As String
        Public Shared RowGeneration As String
        Public Shared RowAbs As Integer
        Public Shared RowEsp As Integer
        Public Shared RowMetalik As Integer
        Public Shared RowKlima As Integer
        Public Shared RowPark As Integer
        Public Shared RowKeyless As Integer
    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KomisDBDataSet.CarsDatabase' table. You can move, or remove it, as needed.
        Me.CarsDatabaseTableAdapter.Fill(Me.KomisDBDataSet.CarsDatabase)
        'TODO: This line of code loads data into the 'KomisDBDataSet.CarsDatabase' table. You can move, or remove it, as needed.
        ' Me.CarsDatabaseTableAdapter.Fill(Me.KomisDBDataSet.CarsDatabase)

        GroupBoxWynikWyszukiwania.Enabled = True
        LabelWelcome.Text = "Witaj " + FormLogowanie.PassUserName
        FormLogowanie.Hide()
        GetCarBrandList()
        Console.WriteLine("User type: " + FormLogowanie.PassUserType)
        If FormLogowanie.PassUserType = "admin" Then
            ButtonEdytuj.Enabled = True
            ButtonUsun.Enabled = True
            ButtonDodaj.Enabled = True
        End If
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    End Sub

    Private Sub ButtonPoprzedni_Click(sender As Object, e As EventArgs) Handles ButtonPoprzedni.Click
        CarsDatabaseBindingSource.Position -= 1
    End Sub

    Private Sub ButtonKoniec_Click(sender As Object, e As EventArgs) Handles ButtonKoniec.Click
        CarsDatabaseBindingSource.Position = CarsDatabaseBindingSource.Count - 1
    End Sub

    Private Sub ButtonPoczatek_Click(sender As Object, e As EventArgs) Handles ButtonPoczatek.Click
        CarsDatabaseBindingSource.Position = 0
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
        'Dim queryString As String = "SELECT * FROM dbo.CarsDatabase WHERE brand = 'Skoda' AND model = 'Fabia' ORDER BY Id;"
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
                        GlobalVariables.RowBrand = reader(1).ToString()
                        GlobalVariables.RowModel = reader(2).ToString()
                        GlobalVariables.RowGeneration = reader(3).ToString()
                        GlobalVariables.RowColor = reader(4).ToString()
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
End Class