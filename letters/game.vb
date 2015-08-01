Imports System.Collections
Imports System.Random
Public Class game
    Const TICK_RATE As Decimal = 0.1
    Dim POSSIBLE_WORDS() As String = Split(My.Resources.words, ",")
    Dim HASHED_WORDS As HashSet(Of String) = New HashSet(Of String)(POSSIBLE_WORDS)

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

    Private Function chooseWord() As String

    End Function

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        remainingTime -= TICK_RATE
        playTime += TICK_RATE
        timeFromLastMatch += TICK_RATE
    End Sub

    Private Sub flashRed()

    End Sub

    Private Sub press_Enter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If input.Text.Length = 4 Then

            Else
                flashRed()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class