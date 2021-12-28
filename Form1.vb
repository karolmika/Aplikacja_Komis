Imports System.Data.SqlClient
Public Class FormLogowanie
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelLogin.Click

    End Sub

    Private Sub ButtonRejestracja_Click(sender As Object, e As EventArgs) Handles ButtonRejestracja.Click
        GroupBoxRejestracja.Visible = True
        GuiSwitchLogowanie(False)
    End Sub

    Private Sub FormLogowanie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuiSwitchLogowanie(True)
    End Sub

    Private Sub ButtonUtworzKonto_Click(sender As Object, e As EventArgs) Handles ButtonUtworzKonto.Click
        Dim UsersDatabaseConStr As String
        Dim AddUserQuery As String
        Dim CountQuery As String
        Dim id As Integer

        id = 3
        AddUserQuery = "INSERT INTO dbo.UsersTable (Id, Login, Haslo, Typ)" &
            "VALUES ('{0}', '{1}', '{2}', 'Klient');"
        CountQuery = "SELECT COUNT(*) FROM dbo.UsersTable"
        String.Format(AddUserQuery, id.ToString(), TextBoxLogin.Text, TextBoxHaslo.Text)

        GuiSwitchLogowanie(True)
        CreateCommand(CountQuery, GlobalVariables.UsersDatabaseConStr)
        'CreateCommand(AddUserQuery, GlobalVariables.UsersDatabaseConStr)

    End Sub

    Public Sub CreateCommand(ByVal queryString As String, ByVal connectionString As String)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ButtonZaloguj_Click(sender As Object, e As EventArgs) Handles ButtonZaloguj.Click
        Dim Num As Integer

        Num = GetNumberOfElements(GlobalVariables.UsersDatabaseConStr)
        TextBox1.Text = Num.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim queryString As String = "SELECT * FROM dbo.UsersTable"
        Dim queryCount As String = "SELECT COUNT(*) FROM dbo.UsersTable"
        Dim reader As System.Data.SqlClient.SqlDataReader

        Using connection As New SqlConnection(GlobalVariables.UsersDatabaseConStr)
            Dim id As Integer
            Dim command As New SqlCommand(queryCount, connection)
            command.Connection.Open()
            reader = command.ExecuteReader()

            id = 0

            While reader.Read()
                'TextBox1.AppendText(reader.FieldCount.ToString())
                'Console.WriteLine(String.Format("ID = {0}, Item(id)= {1}", id.ToString(), reader.GetString(1)))
                'Console.WriteLine(String.Format("ID = {0}", reader.GetString(0)))
                Console.WriteLine(reader(0))
                id += 1
            End While
        End Using
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
