Imports System.Collections
Imports System.Random
Public Class game
    Const TICK_RATE As Decimal = 0.1
    Const COMBO_RATE As Decimal = 0.8
    Dim POSSIBLE_WORDS() As String = Split(My.Resources.words, ",")
    Dim HASHED_WORDS As HashSet(Of String) = New HashSet(Of String)(POSSIBLE_WORDS)

    Dim remainingTime As Decimal = 10
    Dim playTime As Decimal = 0
    Dim timeFromLastMatch As Decimal = 0
    Dim inCombo As Boolean = False
    Dim currentComboMultiplier As Integer = 0
    Dim currentWord As String
    Dim score As Integer

    Private Sub init() Handles Me.Activated
        clock.Interval = TICK_RATE * 1000
        combo.Interval = COMBO_RATE * 1000
        clock.Enabled = True
        combo.Enabled = False

        remainingTime = 10
        playTime = 0
        timeFromLastMatch = 0
        inCombo = False
        currentComboMultiplier = 0
        currentWord = chooseWord()
        score = 0
    End Sub

    Private Function rand(n As Integer)
        Randomize()
        Return CInt(Math.Ceiling(Rnd() * n)) + 1
    End Function

    Private Function chooseWord() As String
        Return POSSIBLE_WORDS(rand(POSSIBLE_WORDS.Length - 1))
    End Function

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        remainingTime -= TICK_RATE
        playTime += TICK_RATE
        timeFromLastMatch += TICK_RATE
    End Sub

    Private Sub flashRed()

    End Sub

    Private Sub checkEnteredWord(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then ' 13 is enter
            If HASHED_WORDS.Contains(input.Text.ToLower) Then
                score +=
            Else
                flashRed()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub combo_Tick(sender As Object, e As EventArgs) Handles combo.Tick
        If inCombo = True Then
            inCombo = False
            currentComboMultiplier = 0
        End If
    End Sub
End Class