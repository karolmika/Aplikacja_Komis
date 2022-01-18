Imports System.Data.SqlClient
Public Class EditCarForm
    Private Sub EditCarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As Integer = MainForm.GlobalVariables.SelectedId
        Dim s As String = "karol"
        '
        's = GetDatbaseColumn(id, "brand")
        ' Console.WriteLine("brand = " + s)

        GetCarBrandList()
        ComboBoxMarka.SelectedItem = MainForm.GlobalVariables.RowBrand
        GetCarModelList(ComboBoxMarka.SelectedItem)
        ComboBoxModel.SelectedItem = MainForm.GlobalVariables.RowModel
        ComboBoxKolor.SelectedItem = MainForm.GlobalVariables.RowColor
        TextBoxRocznik.Text = MainForm.GlobalVariables.RowGeneration

        'GetSelectedCar(MainForm.GlobalVariables.SelectedId)
    End Sub

    Function GetCarBrandList() As Integer
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
                    'ComboBoxMarka.Items.Clear()
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
        Return 1
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


End Class