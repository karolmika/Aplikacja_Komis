Imports System.Data.SqlClient
Public Class MainForm
    Public Class GlobalVariables
        Public Shared UsersDatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
        Public Shared SelectedModel As String
    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KomisDBDataSet.CarsDatabase' table. You can move, or remove it, as needed.
        Me.CarsDatabaseTableAdapter.Fill(Me.KomisDBDataSet.CarsDatabase)

        LabelWelcome.Text = "Witaj " + FormLogowanie.PassUserName
        FormLogowanie.Hide()
        GetCarBrandList()
    End Sub

    Function GetCarBrandList()
        'Dim queryString As String = "SELECT * FROM dbo.CarBrand;"
        Dim queryString As String = "SELECT * FROM dbo.CarsBrandList ORDER BY Id;"
        Dim reader As System.Data.SqlClient.SqlDataReader
        'queryString = String.Format(msg, TextBoxLogin.Text)


        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
            Dim row_id As Integer
            Dim row_name As String
            Dim command As New SqlCommand(queryString, connection)
            Dim result As Boolean
            Dim error_cnt As Integer = 0

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
        End Using
    End Function

    Function GetCarModelList(ByVal brand_name As String)
        'Dim msg As String = "SELECT * FROM dbo.CarModels WHERE brand_id = {0};"
        Dim msg As String = "SELECT * FROM dbo.CarsModelList WHERE BrandName = '{0}';"
        'Dim msg As String = "SELECT Id, model FROM dbo.CarsNewTable WHERE brand = '{0}';"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim queryString As String

        queryString = String.Format(msg, brand_name)


        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
            Dim row_id As Integer
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
                    While reader.Read()
                        'Console.WriteLine(reader.FieldCount.ToString())
                        row_id = reader(0)
                        row_name = reader(1)
                        If row_id > 0 And row_name IsNot String.Empty Then
                            ComboBoxModel.Items.Insert(row_id - 1, row_name)
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
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetCarModelList(GlobalVariables.SelectedModel)
    End Sub

    Private Sub ComboBoxMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMarka.SelectedIndexChanged
        Console.WriteLine("Producent Samochodu wybrany !")
        Console.WriteLine(ComboBoxMarka.SelectedItem)
        ComboBoxModel.Enabled = True
        GlobalVariables.SelectedModel = ComboBoxMarka.SelectedItem
        GetCarModelList(GlobalVariables.SelectedModel)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLakierMetalik.CheckedChanged

    End Sub

End Class