Public Class game
    Const TICK_RATE As Decimal = 0.1

    Dim remainingTime As Decimal = 10
    Dim playTime As Decimal = 0
    Dim timeFromLastMatch As Decimal = 0
    Dim inCombo As Boolean = False
    Dim currentComboMultiplier As Integer = 0
    Dim score = 0

    Private Sub init() Handles Me.Activated
        clock.Enabled = True
        combo.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        remainingTime -= TICK_RATE
        playTime += TICK_RATE
        timeFromLastMatch += TICK_RATE
    End Sub
End Class
