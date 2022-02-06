Public Class CarRateControl
    Public Enum HistoryTypeOptions
        Ilosc
        Wartosc
    End Enum

    Dim his As HistoryTypeOptions
    Private CarRate As String
    Private HistoryTypeValue As Integer

    Public Event RateChange(value As Integer)

    Public Property HistoryType() As HistoryTypeOptions
        Get
            Return his
        End Get
        Set(ByVal value As HistoryTypeOptions)
            his = value
        End Set
    End Property


    Public Property CarName() As String
        Get
            Return LabelCarToRate.Text
        End Get
        Set(ByVal value As String)
            LabelCarToRate.Text = value
        End Set
    End Property

    Public Property Ocena() As Integer
        Get
            Return Convert.ToInt32(LabelRateValue.Text)
        End Get
        Set(value As Integer)
            LabelRateValue.Text = value.ToString()
        End Set
    End Property

    Private Sub CarRateControl_RateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonRate.Click
        RaiseEvent RateChange(Convert.ToInt32(LabelRateValue.Text))
    End Sub


    Private Sub TrackBarRate_Scroll(sender As Object, e As EventArgs) Handles TrackBarRate.Scroll
        LabelRateValue.Text = TrackBarRate.Value.ToString()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelCarToRate.Click

    End Sub

    Private Sub CarRateControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If his = HistoryTypeOptions.Ilosc Then
            GroupBoxHistoriaOcen.Text = "Najczęściej oceniane"
        Else
            GroupBoxHistoriaOcen.Text = "Najwyżej oceniane"
        End If
    End Sub

    Private Sub ButtonRate_Click(sender As Object, e As EventArgs) Handles ButtonRate.Click
        'LabelRateValue.Text = TrackBarRate.Value.ToString()
    End Sub

End Class
