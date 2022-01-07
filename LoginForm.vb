Imports System.Data.SqlClient
Public Class FormLogowanie
    Public PassUserName As String
    Public Class GlobalVariables
        Public Shared UsersDatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
    End Class

    Function GuiSwitchLogowanie(ByVal State As Boolean)

        If State = True Then
            TextBoxLogin.Enabled = True
            TextBoxHaslo.Enabled = True
            ButtonZaloguj.Enabled = True
        Else
            TextBoxLogin.Enabled = False
            TextBoxHaslo.Enabled = False
            ButtonZaloguj.Enabled = False
        End If
    End Function

    Function GuiSwitchRejestracja(ByVal State As Boolean)
        If State = True Then
            GroupBoxRejestracja.Visible = True
        Else
            GroupBoxRejestracja.Visible = False
            TextBoxNowyLogin.Clear()
            TextBoxNoweHaslo1.Clear()
            TextBoxNoweHaslo2.Clear()
        End If
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelLogin.Click

    End Sub

    Private Sub ButtonRejestracja_Click(sender As Object, e As EventArgs) Handles ButtonRejestracja.Click
        GuiSwitchLogowanie(False)
        GuiSwitchRejestracja(True)
    End Sub

    Private Sub FormLogowanie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuiSwitchLogowanie(True)
    End Sub

    Private Sub ButtonUtworzKonto_Click(sender As Object, e As EventArgs) Handles ButtonUtworzKonto.Click
        Dim msg As String
        Dim AddUserQuery As String
        Dim Num As Integer
        Dim Login As String
        Dim Haslo As String
        msg = "INSERT INTO dbo.UsersTable (Id, Login, Haslo, Typ)" &
            " VALUES ('{0}', '{1}', '{2}', 'Klient');"
        ' CountQuery = "SELECT COUNT(*) FROM dbo.UsersTable"

        Num = GetNumberOfElements(GlobalVariables.UsersDatabaseConStr)
        'TextBox1.Text = Num.ToString()

        If TextBoxNoweHaslo1.Text = TextBoxNoweHaslo2.Text Then
            Haslo = TextBoxNoweHaslo1.Text
            Login = TextBoxNowyLogin.Text

            AddUserQuery = String.Format(msg, Num + 1, Login, Haslo)
            TextBox1.Text = AddUserQuery
            Try
                CreateCommand(AddUserQuery, GlobalVariables.UsersDatabaseConStr)
                MessageBox.Show("Konto zostało utworzone, możesz się teraz zalogować.", "Potwierdzenie", MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Wystąpił błąd", "Blad", MessageBoxButtons.OK)
            End Try
        Else
            MessageBox.Show("Wprowadzone hasła nie są zgodne", "Blad", MessageBoxButtons.OK)
        End If
        'CreateCommand(AddUserQuery, GlobalVariables.UsersDatabaseConStr)
        GuiSwitchLogowanie(True)
        GuiSwitchRejestracja(False)
    End Sub

    Public Sub CreateCommand(ByVal queryString As String, ByVal connectionString As String)
        Using connection As New SqlConnection(connectionString)
            Dim id As New Integer
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ButtonZaloguj_Click(sender As Object, e As EventArgs) Handles ButtonZaloguj.Click
        Dim msg As String = "SELECT Login, Haslo FROM dbo.UsersTable WHERE Login='{0}';"
        Dim queryString As String
        Dim reader As System.Data.SqlClient.SqlDataReader
        queryString = String.Format(msg, TextBoxLogin.Text)

        PassUserName = "default_login"

        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
            Dim id As New Integer
            Dim command As New SqlCommand(queryString, connection)
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
                    reader.Read()
                    Console.WriteLine(reader.FieldCount.ToString())
                    Console.WriteLine(reader(1))
                    If reader(1) = TextBoxHaslo.Text Then
                        MessageBox.Show("Udalo sie zalogowac")
                        PassUserName = TextBoxLogin.Text
                        MainForm.Show()
                    Else
                        MessageBox.Show("Nie prawidłowe hasło")
                        TextBoxHaslo.Clear()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Nie prawidłowy login")
                    TextBoxLogin.Clear()
                    TextBoxHaslo.Clear()
                End Try
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.Show()
    End Sub

    Function GetNumberOfElements(ByVal connectionString As String) As Integer
        Dim queryCount As String = "SELECT COUNT(*) FROM dbo.UsersTable"
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

End Class
