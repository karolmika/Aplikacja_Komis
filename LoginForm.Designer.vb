<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogowanie
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
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.LabelHaslo = New System.Windows.Forms.Label()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.TextBoxHaslo = New System.Windows.Forms.TextBox()
        Me.ButtonZaloguj = New System.Windows.Forms.Button()
        Me.GroupBoxRejestracja = New System.Windows.Forms.GroupBox()
        Me.ButtonAnuluj = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUtworzKonto = New System.Windows.Forms.Button()
        Me.TextBoxNoweHaslo2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNoweHaslo1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNowyLogin = New System.Windows.Forms.TextBox()
        Me.ButtonRejestracja = New System.Windows.Forms.Button()
        Me.GroupBoxLogowanie = New System.Windows.Forms.GroupBox()
        Me.BindingSourceUsers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDataSet = New Aplikacja_Komis.UsersDataSet()
        Me.GroupBoxRejestracja.SuspendLayout()
        CType(Me.BindingSourceUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Location = New System.Drawing.Point(76, 67)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(40, 13)
        Me.LabelLogin.TabIndex = 0
        Me.LabelLogin.Text = "LOGIN"
        '
        'LabelHaslo
        '
        Me.LabelHaslo.AutoSize = True
        Me.LabelHaslo.Location = New System.Drawing.Point(76, 104)
        Me.LabelHaslo.Name = "LabelHaslo"
        Me.LabelHaslo.Size = New System.Drawing.Size(44, 13)
        Me.LabelHaslo.TabIndex = 1
        Me.LabelHaslo.Text = "HASŁO"
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Location = New System.Drawing.Point(131, 59)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxLogin.TabIndex = 2
        '
        'TextBoxHaslo
        '
        Me.TextBoxHaslo.Location = New System.Drawing.Point(131, 97)
        Me.TextBoxHaslo.Name = "TextBoxHaslo"
        Me.TextBoxHaslo.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxHaslo.TabIndex = 3
        '
        'ButtonZaloguj
        '
        Me.ButtonZaloguj.Location = New System.Drawing.Point(131, 136)
        Me.ButtonZaloguj.Name = "ButtonZaloguj"
        Me.ButtonZaloguj.Size = New System.Drawing.Size(150, 23)
        Me.ButtonZaloguj.TabIndex = 4
        Me.ButtonZaloguj.Text = "Zaloguj"
        Me.ButtonZaloguj.UseVisualStyleBackColor = True
        '
        'GroupBoxRejestracja
        '
        Me.GroupBoxRejestracja.Controls.Add(Me.ButtonAnuluj)
        Me.GroupBoxRejestracja.Controls.Add(Me.Label3)
        Me.GroupBoxRejestracja.Controls.Add(Me.Label2)
        Me.GroupBoxRejestracja.Controls.Add(Me.Label1)
        Me.GroupBoxRejestracja.Controls.Add(Me.ButtonUtworzKonto)
        Me.GroupBoxRejestracja.Controls.Add(Me.TextBoxNoweHaslo2)
        Me.GroupBoxRejestracja.Controls.Add(Me.TextBoxNoweHaslo1)
        Me.GroupBoxRejestracja.Controls.Add(Me.TextBoxNowyLogin)
        Me.GroupBoxRejestracja.Location = New System.Drawing.Point(52, 219)
        Me.GroupBoxRejestracja.Name = "GroupBoxRejestracja"
        Me.GroupBoxRejestracja.Size = New System.Drawing.Size(301, 245)
        Me.GroupBoxRejestracja.TabIndex = 5
        Me.GroupBoxRejestracja.TabStop = False
        Me.GroupBoxRejestracja.Text = "Rejestracja"
        Me.GroupBoxRejestracja.Visible = False
        '
        'ButtonAnuluj
        '
        Me.ButtonAnuluj.Location = New System.Drawing.Point(36, 210)
        Me.ButtonAnuluj.Name = "ButtonAnuluj"
        Me.ButtonAnuluj.Size = New System.Drawing.Size(239, 23)
        Me.ButtonAnuluj.TabIndex = 8
        Me.ButtonAnuluj.Text = "Anuluj"
        Me.ButtonAnuluj.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Powtórz hasło"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasło"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login"
        '
        'ButtonUtworzKonto
        '
        Me.ButtonUtworzKonto.Location = New System.Drawing.Point(36, 180)
        Me.ButtonUtworzKonto.Name = "ButtonUtworzKonto"
        Me.ButtonUtworzKonto.Size = New System.Drawing.Size(239, 23)
        Me.ButtonUtworzKonto.TabIndex = 7
        Me.ButtonUtworzKonto.Text = "Utwórz konto"
        Me.ButtonUtworzKonto.UseVisualStyleBackColor = True
        '
        'TextBoxNoweHaslo2
        '
        Me.TextBoxNoweHaslo2.Location = New System.Drawing.Point(125, 125)
        Me.TextBoxNoweHaslo2.Name = "TextBoxNoweHaslo2"
        Me.TextBoxNoweHaslo2.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNoweHaslo2.TabIndex = 7
        '
        'TextBoxNoweHaslo1
        '
        Me.TextBoxNoweHaslo1.Location = New System.Drawing.Point(125, 86)
        Me.TextBoxNoweHaslo1.Name = "TextBoxNoweHaslo1"
        Me.TextBoxNoweHaslo1.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNoweHaslo1.TabIndex = 7
        '
        'TextBoxNowyLogin
        '
        Me.TextBoxNowyLogin.Location = New System.Drawing.Point(125, 47)
        Me.TextBoxNowyLogin.Name = "TextBoxNowyLogin"
        Me.TextBoxNowyLogin.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNowyLogin.TabIndex = 7
        '
        'ButtonRejestracja
        '
        Me.ButtonRejestracja.Location = New System.Drawing.Point(131, 166)
        Me.ButtonRejestracja.Name = "ButtonRejestracja"
        Me.ButtonRejestracja.Size = New System.Drawing.Size(150, 23)
        Me.ButtonRejestracja.TabIndex = 6
        Me.ButtonRejestracja.Text = "Rejestracja"
        Me.ButtonRejestracja.UseVisualStyleBackColor = True
        '
        'GroupBoxLogowanie
        '
        Me.GroupBoxLogowanie.Location = New System.Drawing.Point(52, 31)
        Me.GroupBoxLogowanie.Name = "GroupBoxLogowanie"
        Me.GroupBoxLogowanie.Size = New System.Drawing.Size(301, 183)
        Me.GroupBoxLogowanie.TabIndex = 7
        Me.GroupBoxLogowanie.TabStop = False
        Me.GroupBoxLogowanie.Text = "Logowanie"
        '
        'BindingSourceUsers
        '
        Me.BindingSourceUsers.DataSource = Me.UsersDataSet
        Me.BindingSourceUsers.Position = 0
        '
        'UsersDataSet
        '
        Me.UsersDataSet.DataSetName = "UsersDataSet"
        Me.UsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormLogowanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 504)
        Me.Controls.Add(Me.ButtonRejestracja)
        Me.Controls.Add(Me.ButtonZaloguj)
        Me.Controls.Add(Me.TextBoxHaslo)
        Me.Controls.Add(Me.TextBoxLogin)
        Me.Controls.Add(Me.LabelHaslo)
        Me.Controls.Add(Me.LabelLogin)
        Me.Controls.Add(Me.GroupBoxRejestracja)
        Me.Controls.Add(Me.GroupBoxLogowanie)
        Me.Name = "FormLogowanie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logowanie"
        Me.GroupBoxRejestracja.ResumeLayout(False)
        Me.GroupBoxRejestracja.PerformLayout()
        CType(Me.BindingSourceUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLogin As Label
    Friend WithEvents LabelHaslo As Label
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents TextBoxHaslo As TextBox
    Friend WithEvents ButtonZaloguj As Button
    Friend WithEvents GroupBoxRejestracja As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonUtworzKonto As Button
    Friend WithEvents TextBoxNoweHaslo2 As TextBox
    Friend WithEvents TextBoxNoweHaslo1 As TextBox
    Friend WithEvents TextBoxNowyLogin As TextBox
    Friend WithEvents ButtonRejestracja As Button
    Friend WithEvents GroupBoxLogowanie As GroupBox
    Friend WithEvents BindingSourceUsers As BindingSource
    Friend WithEvents UsersDataSet As UsersDataSet
    Friend WithEvents ButtonAnuluj As Button
End Class
