Imports System.Data.SqlClient
Public Class MainForm
    Public Class GlobalVariables
        Public Shared UsersDatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
        Public Shared SelectedModel As String
        Public Shared SelectedBrand As String
        Public Shared SelectedColor As String
        Public Shared SelectedOcena As Integer
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
        End Using
    End Function

    Function GetCarModelList(ByVal brand_name As String)
        'Dim msg As String = "SELECT * FROM dbo.CarModels WHERE brand_id = {0};"
        Dim msg As String = "SELECT * FROM dbo.CarsModelList WHERE BrandName = '{0}' ORDER BY Name;"
        'Dim msg As String = "SELECT Id, model FROM dbo.CarsNewTable WHERE brand = '{0}';"
        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim queryString As String

        queryString = String.Format(msg, brand_name)


        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
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
        End Using
    End Function

    Function GetCarColorList()
        ' Dim queryString As String = "SELECT * FROM dbo.CarsColorlList ORDER BY Id;"
        Dim queryString As String = "SELECT * FROM dbo.CarsColorlList;"
        Dim reader As System.Data.SqlClient.SqlDataReader

        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
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
                'ComboBoxKolor.Items.Clear()
                Try
                    reader = command.ExecuteReader()
                    Console.WriteLine(reader(0) + "." + reader(1))
                    While reader.Read()
                        row_name = reader(1)
                        If row_name IsNot String.Empty Then
                            ComboBoxKolor.Items.Insert(row_id, row_name)
                            row_id += 1
                            'Console.WriteLine(row_id.ToString() + "." + row_name.ToString)
                        Else
                            Console.WriteLine("Empty data !")
                        End If
                    End While
                Catch ex As Exception
                    MessageBox.Show("Nie udało sie odczytac listy kolorów")
                End Try
            Else
                Console.WriteLine("Nie udane połączenie z bazą kolorów")
            End If
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.CarsDatabaseTableAdapter.FiltrMarka(Me.KomisDBDataSet.CarsDatabase, TextBox1.Text)
        'GetCarModelList(GlobalVariables.SelectedModel)
        'Dim sql As String = "SELECT * FROM dbo.CarsBrandList ORDER BY Id;"
        'Dim myDataSet As DataSet = New DataSet()

        'Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
        'Dim dataadapter As SqlDataAdapter = New SqlDataAdapter(sql, connection)
        'connection.Open()
        'dataadapter.Fill(myDataSet)
        'connection.Close()
        'DataGridViewPojazdy.Rows.Add("Id", "Brand", "Model")
        'End Using
        Dim queryString As String = "SELECT * FROM dbo.CarsDatabase WHERE brand = 'Skoda' AND model = 'Fabia' ORDER BY Id;"
        Dim connection As SqlConnection = New SqlConnection()
        Dim ds As DataSet = New DataSet()
        Dim adp As SqlDataAdapter = New SqlDataAdapter(queryString, connection)

        connection.ConnectionString = GlobalVariables.UsersDatabaseConStr
        connection.Open()
        adp.Fill(ds)
        DataGridViewPojazdy.DataSource = ds.Tables(0)
    End Sub

    Private Sub ComboBoxMarka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMarka.SelectedIndexChanged
        Console.WriteLine("Producent Samochodu wybrany !")
        Console.WriteLine(ComboBoxMarka.SelectedItem)
        ComboBoxModel.Enabled = True
        GlobalVariables.SelectedBrand = ComboBoxMarka.SelectedItem
        GetCarModelList(GlobalVariables.SelectedBrand)
        'GetCarColorList()
    End Sub

    Private Sub ComboBoxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModel.SelectedIndexChanged
        ComboBoxKolor.Enabled = True
        GlobalVariables.SelectedModel = ComboBoxModel.SelectedIndex
        GetCarColorList()
    End Sub

    Private Sub ComboBoxKolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKolor.SelectedIndexChanged
        ComboBoxOcenaPowyzej.Enabled = True
        GlobalVariables.SelectedColor = ComboBoxKolor.SelectedIndex
    End Sub

    Private Sub ComboBoxOcenaPowyzej_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOcenaPowyzej.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLakierMetalik.CheckedChanged

    End Sub

    Private Sub ButtonSzukaj_Click(sender As Object, e As EventArgs) Handles ButtonSzukaj.Click
        Dim queryBase As String = "SELECT * FROM dbo.CarsDatabase"
        Dim queryComplete As String
        'Dim queryString As String = "SELECT * FROM dbo.CarsDatabase WHERE brand = 'Skoda' AND model = 'Fabia' ORDER BY Id;"
        Dim connection As SqlConnection = New SqlConnection()
        Dim ds As DataSet = New DataSet()

        If GlobalVariables.SelectedBrand IsNot Nothing Then
            queryComplete = queryBase + " WHERE brand = '{0}'"
            queryComplete = String.Format(queryComplete, GlobalVariables.SelectedBrand)

            If GlobalVariables.SelectedModel IsNot Nothing Then
                Dim model_filtr As String = " model = '{0}'"
                model_filtr = String.Format(model_filtr, GlobalVariables.SelectedModel)
                queryComplete = queryComplete + model_filtr
            End If

            If GlobalVariables.SelectedColor IsNot Nothing Then
                Dim color_filtr As String = " color = '{0}'"
                color_filtr = String.Format(color_filtr, GlobalVariables.SelectedColor)
                queryComplete = queryComplete + color_filtr
            End If

            If GlobalVariables.SelectedOcena > 0 Then
                Dim ocena_filtr As String = " ocena = {}"
                ocena_filtr = String.Format(ocena_filtr, GlobalVariables.SelectedOcena)
                queryComplete = queryComplete + ocena_filtr
            End If

        Else
            queryComplete = queryBase
        End If
        queryComplete = queryComplete + ";"

        Dim adp As SqlDataAdapter = New SqlDataAdapter(queryComplete, connection)
        Console.WriteLine("Query = " + queryComplete)
        connection.ConnectionString = GlobalVariables.UsersDatabaseConStr
        connection.Open()
        adp.Fill(ds)
        DataGridViewPojazdy.DataSource = ds.Tables(0)
    End Sub




End Class