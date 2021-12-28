Imports System.Data.SqlClient
Public Class FormLogowanie


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
        UsersDatabaseConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Karol\source\repos\Aplikacja_Komis\KomisDB.mdf;Integrated Security=True"
        AddUserQuery = "INSERT INTO dbo.UsersTable (Id, Login, Haslo, Typ)" &
            "VALUES ('2', 'Mika', 'Pwd', 'Klient');"

        GuiSwitchLogowanie(True)
        CreateCommand(AddUserQuery, UsersDatabaseConStr)

    End Sub

    Public Sub CreateCommand(ByVal queryString As String, ByVal connectionString As String)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class
