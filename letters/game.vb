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

    Private Sub init() Handles Me.GotFocus
        clock.Interval = TICK_RATE * 1000
        clock.Enabled = True

        remainingTime = 10
        playTime = 0
        timeFromLastMatch = 0
        inCombo = False
        currentComboMultiplier = 0
        chooseWord()
        score = 0
    End Sub

    Private Function rand(n As Integer)
        Randomize()
        Return CInt(Math.Ceiling(Rnd() * n)) + 1
    End Function
    Private Function RandomizeArray(ByVal items() As Integer) As Integer()
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            ' Pick an item for position i.
            Dim j As Integer = rnd.Next(i, max_index + 1)

            ' Swap them.
            Dim temp As Integer = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
        Return items
    End Function

    Private Sub fillLabels()
        Dim order As Integer() = {0, 1, 2, 3}
        RandomizeArray(order)
        For i As Integer = 0 To order.Length - 1
            Select Case i
                Case 0
                    letter1.Text = currentWord(i)
                Case 1
                    letter2.Text = currentWord(i)
                Case 3
                    letter3.Text = currentWord(i)
                Case 4
                    letter4.Text = currentWord(i)
            End Select
        Next
    End Sub
    Private Sub chooseWord()
        currentWord = POSSIBLE_WORDS(rand(POSSIBLE_WORDS.Length - 1))
        fillLabels()
    End Sub

    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        remainingTime -= TICK_RATE
        playTime += TICK_RATE
        timeFromLastMatch += TICK_RATE
    End Sub

    Private Sub flashRed()
        Console.WriteLine("wrong word, correct word is" + currentWord)
    End Sub

    Private Sub checkEnteredWord(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then ' 13 is enter
            If HASHED_WORDS.Contains(input.Text.ToLower) Then
                If inCombo = True AndAlso timeFromLastMatch <= COMBO_RATE Then
                    currentComboMultiplier += 1
                Else
                    If timeFromLastMatch <= COMBO_RATE Then
                        inCombo = True
                        currentComboMultiplier += 1
                    Else
                        inCombo = False
                        currentComboMultiplier = 0
                    End If
                End If
                updateScore()
            Else
                flashRed()
            End If
        End If
    End Sub

    Private Sub updateScore()
        timeFromLastMatch = 0
        score += 1 + currentComboMultiplier
        scoreDisplay.Text = score
        chooseWord()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class