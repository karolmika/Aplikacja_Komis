Imports System.Data.SqlClient
Public Class AddNewCar
    Public Class NewCar
        Public Shared Model As String
        Public Shared Brand As String
        Public Shared Color As String
        'Public Shared Rocznik As String
    End Class
    Private Sub ButtonDodajNowyPojazd_Click(sender As Object, e As EventArgs) Handles ButtonDodajNowyPojazd.Click
        Dim msg As String
        Dim AddCarQuery As String
        Dim Num As Integer
        Dim metalic As Integer
        Dim ac As Integer
        Dim abs As Integer
        Dim esp As Integer
        Dim park As Integer
        Dim keyless As Integer

        AddCarQuery = "INSERT INTO dbo.CarsDatabase(Id, brand, model, generation, color, metalic, ac, abs, esp, park, keyless)" &
            " VALUES({0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9}, {10});"
        ' CountQuery = "SELECT COUNT(*) FROM dbo.UsersTable"

        Num = GetNumberOfElements(MainForm.GlobalVariables.DatabaseConStr)
        'TextBox1.Text = Num.ToString()

        If CheckBoxLakierMetalik.Checked Then
            metalic = 1
        Else
            metalic = 0
        End If

        If CheckBoxKlimatyzacja.Checked Then
            ac = 1
        Else
            ac = 0
        End If

        If CheckBoxABS.Checked Then
            abs = 1
        Else
            abs = 0
        End If

        If CheckBoxESP.Checked Then
            esp = 1
        Else
            esp = 0
        End If

        If CheckBoxCzujniki.Checked Then
            park = 1
        Else
            park = 0
        End If

        If CheckBoxKeyless.Checked Then
            keyless = 1
        Else
            keyless = 0
        End If

        AddCarQuery = String.Format(AddCarQuery, Num + 1, NewCar.Brand, NewCar.Model, TextBoxRocznik.Text, ComboBoxKolor.SelectedItem, metalic, ac, abs, esp, park, keyless)
        'AddCarQuery = String.Format(AddCarQuery, Num + 1, NewCar.Brand, NewCar.Model, TextBoxRocznik.Text, ComboBoxKolor.SelectedItem, 0, metalic, ac, abs, esp, park, keyless)
        Console.WriteLine("Zapytanie: " + AddCarQuery)
        Try
            CreateCommand(AddCarQuery, MainForm.GlobalVariables.DatabaseConStr)
            MessageBox.Show("Pojazd został dodany", "Potwierdzenie", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Wystąpił błąd podczas dodawania pojazdu. Sprawdź wprowadzone dane", "Blad", MessageBoxButtons.OK)
        End Try
        Me.Close()
        'MainForm.Show()
        MainForm.SzukajPojazdow()
        'MainForm.CarsDatabaseTableAdapter.Fill(MainForm.KomisDBDataSet.CarsDatabase)
    End Sub
    Public Sub CreateCommand(ByVal queryString As String, ByVal connectionString As String)
        Using connection As New SqlConnection(connectionString)
            Dim id As New Integer
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub AddNewCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCarBrandList()
    End Sub

    Function GetCarBrandList()
        'Dim queryString As String = "SELECT * FROM dbo.CarBrand;"
        Dim queryString As String = "SELECT * FROM dbo.CarsBrandList ORDER BY Id;"
        Dim reader As System.Data.SqlClient.SqlDataReader
        'queryString = String.Format(msg, TextBoxLogin.Text)


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


        Using connection As New SqlConnection(MainForm.GlobalVariables.DatabaseConStr)
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

    Private Sub ComboBoxMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMarka.SelectedIndexChanged
        NewCar.Brand = ComboBoxMarka.SelectedItem
        GetCarModelList(NewCar.Brand)
    End Sub
    Function GetNumberOfElements(ByVal connectionString As String) As Integer
        Dim queryCount As String = "SELECT COUNT(*) FROM dbo.CarsDatabase"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim val As Integer

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryCount, connection)
            command.Connection.Open()
            reader = command.ExecuteReader()
            reader.Read()
            val = reader(0)
        End Using
        Return val
    End Function

    Private Sub ComboBoxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModel.SelectedIndexChanged
        NewCar.Model = ComboBoxModel.SelectedItem
    End Sub
End Class