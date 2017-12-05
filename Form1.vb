Public Class Form1

    Dim randomNum As New Random
    Public bombSpots(9) As Integer
    Dim boxes(9, 9) As Integer
    Dim spot1 As Integer
    Dim spot2 As Integer
    Dim zeros(9, 9) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newGame(bombSpots)
    End Sub

    Public Sub newGame(ByRef bombSpots As Integer())

        Dim s As Integer = 0
        Dim t As Integer = 0
        While s < 10
            t = 0
            While t < 10
                changeT(s, t)
                renum(s, t)
                t += 1
            End While
            s += 1
        End While

        lblGameOver.Visible = False

        bombSpots(0) = randomNum.Next(0, 100)
        bombSpots(1) = randomNum.Next(0, 100)
        While bombSpots(1) = bombSpots(0)
            bombSpots(1) = randomNum.Next(0, 100)
        End While
        bombSpots(2) = randomNum.Next(0, 100)
        While bombSpots(2) = bombSpots(0) Or bombSpots(2) = bombSpots(1)
            bombSpots(2) = randomNum.Next(0, 100)
        End While
        bombSpots(3) = randomNum.Next(0, 100)
        While bombSpots(3) = bombSpots(0) Or bombSpots(3) = bombSpots(1) Or bombSpots(3) = bombSpots(2)
            bombSpots(3) = randomNum.Next(0, 100)
        End While
        bombSpots(4) = randomNum.Next(0, 100)
        While bombSpots(4) = bombSpots(0) Or bombSpots(4) = bombSpots(1) Or bombSpots(4) = bombSpots(2) Or bombSpots(4) = bombSpots(3)
            bombSpots(4) = randomNum.Next(0, 100)
        End While
        bombSpots(5) = randomNum.Next(0, 100)
        While bombSpots(5) = bombSpots(0) Or bombSpots(5) = bombSpots(1) Or bombSpots(5) = bombSpots(2) Or bombSpots(5) = bombSpots(3) Or bombSpots(5) = bombSpots(4)
            bombSpots(5) = randomNum.Next(0, 100)
        End While
        bombSpots(6) = randomNum.Next(0, 100)
        While bombSpots(6) = bombSpots(0) Or bombSpots(6) = bombSpots(1) Or bombSpots(6) = bombSpots(2) Or bombSpots(6) = bombSpots(3) Or bombSpots(6) = bombSpots(4) Or bombSpots(6) = bombSpots(5)
            bombSpots(6) = randomNum.Next(0, 100)
        End While
        bombSpots(7) = randomNum.Next(0, 100)
        While bombSpots(7) = bombSpots(0) Or bombSpots(7) = bombSpots(1) Or bombSpots(7) = bombSpots(2) Or bombSpots(7) = bombSpots(3) Or bombSpots(7) = bombSpots(4) Or bombSpots(7) = bombSpots(5) Or bombSpots(7) = bombSpots(6)
            bombSpots(6) = randomNum.Next(0, 100)
        End While
        bombSpots(8) = randomNum.Next(0, 100)
        While bombSpots(8) = bombSpots(0) Or bombSpots(8) = bombSpots(1) Or bombSpots(8) = bombSpots(2) Or bombSpots(8) = bombSpots(3) Or bombSpots(8) = bombSpots(4) Or bombSpots(8) = bombSpots(5) Or bombSpots(8) = bombSpots(6) Or bombSpots(8) = bombSpots(7)
            bombSpots(8) = randomNum.Next(0, 100)
        End While
        bombSpots(9) = randomNum.Next(0, 100)
        While bombSpots(9) = bombSpots(0) Or bombSpots(9) = bombSpots(1) Or bombSpots(9) = bombSpots(2) Or bombSpots(9) = bombSpots(3) Or bombSpots(9) = bombSpots(4) Or bombSpots(9) = bombSpots(5) Or bombSpots(9) = bombSpots(6) Or bombSpots(9) = bombSpots(7) Or bombSpots(9) = bombSpots(8)
            bombSpots(2) = randomNum.Next(0, 100)
        End While

        Dim i As Integer = 0
        Dim num As Integer
        Dim row As Integer
        Dim colm As Integer

        While i < 10
            num = bombSpots(i)
            If num = 100 Then
                colm = 10
                row = 9
            Else
                colm = num Mod 10
                If colm = 0 Then
                    colm = 10
                End If
                row = num \ 10
                colm -= 1
                boxes(row, colm) = -10

            End If
            i += 1
            If row = 0 And colm = 0 Then
                boxes(row, colm + 1) += 1
                boxes(row + 1, colm) += 1
                boxes(row + 1, colm + 1) += 1
            ElseIf row = 0 And colm = 9 Then
                boxes(row, colm - 1) += 1
                boxes(row + 1, colm - 1) += 1
                boxes(row + 1, colm) += 1
            ElseIf row = 9 And colm = 0 Then
                boxes(row - 1, colm) += 1
                boxes(row - 1, colm + 1) += 1
                boxes(row, colm + 1) += 1
            ElseIf row = 9 And colm = 9 Then
                boxes(row - 1, colm - 1) += 1
                boxes(row - 1, colm) += 1
                boxes(row, colm - 1) += 1
            ElseIf row = 0 Then
                boxes(row, colm - 1) += 1
                boxes(row, colm + 1) += 1
                boxes(row + 1, colm - 1) += 1
                boxes(row + 1, colm) += 1
                boxes(row + 1, colm + 1) += 1
            ElseIf row = 9 Then
                boxes(row, colm - 1) += 1
                boxes(row, colm + 1) += 1
                boxes(row - 1, colm - 1) += 1
                boxes(row - 1, colm) += 1
                boxes(row - 1, colm + 1) += 1
            ElseIf colm = 0 Then
                boxes(row - 1, colm) += 1
                boxes(row - 1, colm + 1) += 1
                boxes(row, colm + 1) += 1
                boxes(row + 1, colm + 1) += 1
                boxes(row + 1, colm) += 1
            ElseIf colm = 9 Then
                boxes(row - 1, colm) += 1
                boxes(row - 1, colm - 1) += 1
                boxes(row, colm - 1) += 1
                boxes(row + 1, colm - 1) += 1
                boxes(row + 1, colm) += 1
            ElseIf row <> 0 And colm <> 0 And row <> 9 And colm <> 9 Then
                boxes(row - 1, colm - 1) += 1
                boxes(row - 1, colm) += 1
                boxes(row - 1, colm + 1) += 1
                boxes(row, colm - 1) += 1
                boxes(row, colm + 1) += 1
                boxes(row + 1, colm - 1) += 1
                boxes(row + 1, colm) += 1
                boxes(row + 1, colm + 1) += 1
            End If
        End While

        Dim m As Integer = 0
        Dim n As Integer = 0
        While m < 10
            n = 0
            While n < 10
                zeros(m, n) = 0
                n += 1
            End While
            m += 1
        End While


    End Sub

    

    Function check(a, b) As Integer
        If boxes(a, b) < 0 Then
            Return -1
        ElseIf boxes(a, b) = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Public Sub blank(x, y)
        If x = 0 And y = 0 Then
            change(x, y + 1)
            change(x + 1, y)
            change(x + 1, y + 1)
            change(x, y)
            number(x, y + 1)
            number(x + 1, y)
            number(x + 1, y + 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y + 1) = 0 And zeros(x, y + 1) = 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
            If boxes(x + 1, y + 1) = 0 And zeros(x + 1, y + 1) = 0 Then
                blank(x + 1, y + 1)
                zeros(x + 1, y + 1) = 1
            End If

        ElseIf x = 0 And y = 9 Then
            change(x, y - 1)
            change(x + 1, y - 1)
            change(x + 1, y)
            change(x, y)
            number(x, y - 1)
            number(x + 1, y - 1)
            number(x + 1, y)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
            If boxes(x + 1, y - 1) = 0 And zeros(x + 1, y - 1) = 0 Then
                blank(x + 1, y - 1)
                zeros(x + 1, y - 1) = 1
            End If
        ElseIf x = 9 And y = 0 Then
            change(x - 1, y)
            change(x - 1, y + 1)
            change(x, y + 1)
            change(x, y)
            number(x - 1, y)
            number(x - 1, y + 1)
            number(x, y + 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y + 1) = 0 And zeros(x, y + 1) = 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x - 1, y + 1) = 0 And zeros(x - 1, y + 1) = 0 Then
                blank(x - 1, y + 1)
                zeros(x - 1, y + 1) = 1
            End If
        ElseIf x = 9 And y = 9 Then
            change(x - 1, y - 1)
            change(x - 1, y)
            change(x, y - 1)
            change(x, y)
            number(x - 1, y - 1)
            number(x - 1, y)
            number(x, y - 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x - 1, y - 1) = 0 And zeros(x - 1, y - 1) = 0 Then
                blank(x - 1, y - 1)
                zeros(x - 1, y - 1) = 1
            End If
        ElseIf x = 0 Then
            change(x, y - 1)
            change(x, y + 1)
            change(x + 1, y - 1)
            change(x + 1, y)
            change(x + 1, y + 1)
            change(x, y)
            number(x, y - 1)
            number(x, y + 1)
            number(x + 1, y - 1)
            number(x + 1, y)
            number(x + 1, y + 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x, y + 1) = 0 And zeros(x, y + 1) = 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x + 1, y - 1) = 0 And zeros(x + 1, y - 1) = 0 Then
                blank(x + 1, y - 1)
                zeros(x + 1, y - 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
            If boxes(x + 1, y + 1) = 0 And zeros(x + 1, y + 1) = 0 Then
                blank(x + 1, y + 1)
                zeros(x + 1, y + 1) = 1
            End If
        ElseIf x = 9 Then
            change(x, y - 1)
            change(x, y + 1)
            change(x - 1, y - 1)
            change(x - 1, y)
            change(x - 1, y + 1)
            change(x, y)
            number(x, y - 1)
            number(x, y + 1)
            number(x - 1, y - 1)
            number(x - 1, y)
            number(x - 1, y + 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x, y + 1) = 0 And zeros(x, y + 1) = 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x - 1, y - 1) = 0 And zeros(x - 1, y - 1) = 0 Then
                blank(x - 1, y - 1)
                zeros(x - 1, y - 1) = 1
            End If
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x - 1, y + 1) = 0 And zeros(x - 1, y + 1) = 0 Then
                blank(x - 1, y + 1)
                zeros(x - 1, y + 1) = 1
            End If
        ElseIf y = 0 Then
            change(x - 1, y)
            change(x - 1, y + 1)
            change(x, y + 1)
            change(x + 1, y + 1)
            change(x + 1, y)
            change(x, y)
            number(x - 1, y)
            number(x - 1, y + 1)
            number(x, y + 1)
            number(x + 1, y + 1)
            number(x + 1, y)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x, y + 1) = 0 And zeros(x, y + 1)= 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x + 1, y + 1) = 0 And zeros(x + 1, y + 1) = 0 Then
                blank(x + 1, y + 1)
                zeros(x + 1, y + 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
            If boxes(x - 1, y + 1) = 0 And zeros(x - 1, y + 1) = 0 Then
                blank(x - 1, y + 1)
                zeros(x - 1, y + 1) = 1
            End If
        ElseIf y = 9 Then
            change(x - 1, y)
            change(x - 1, y - 1)
            change(x, y - 1)
            change(x + 1, y - 1)
            change(x + 1, y)
            change(x, y)
            number(x - 1, y)
            number(x - 1, y - 1)
            number(x, y - 1)
            number(x + 1, y - 1)
            number(x + 1, y)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x - 1, y - 1) = 0 And zeros(x - 1, y - 1) = 0 Then
                blank(x - 1, y - 1)
                zeros(x - 1, y - 1) = 1
            End If
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x + 1, y - 1) = 0 And zeros(x + 1, y - 1) = 0 Then
                blank(x + 1, y - 1)
                zeros(x + 1, y - 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
        ElseIf x <> 0 And y <> 0 And x <> 9 And y <> 9 Then
            change(x - 1, y - 1)
            change(x - 1, y)
            change(x - 1, y + 1)
            change(x, y - 1)
            change(x, y + 1)
            change(x + 1, y - 1)
            change(x + 1, y)
            change(x + 1, y + 1)
            change(x, y)
            number(x - 1, y - 1)
            number(x - 1, y)
            number(x - 1, y + 1)
            number(x, y - 1)
            number(x, y + 1)
            number(x + 1, y - 1)
            number(x + 1, y)
            number(x + 1, y + 1)
            number(x, y)
            zeros(x, y) = 1
            If boxes(x - 1, y - 1) = 0 And zeros(x - 1, y - 1) = 0 Then
                blank(x - 1, y - 1)
                zeros(x - 1, y - 1) = 1
            End If
            If boxes(x - 1, y) = 0 And zeros(x - 1, y) = 0 Then
                blank(x - 1, y)
                zeros(x - 1, y) = 1
            End If
            If boxes(x - 1, y + 1) = 0 And zeros(x - 1, y + 1) = 0 Then
                blank(x - 1, y + 1)
                zeros(x - 1, y + 1) = 1
            End If
            If boxes(x, y - 1) = 0 And zeros(x, y - 1) = 0 Then
                blank(x, y - 1)
                zeros(x, y - 1) = 1
            End If
            If boxes(x, y + 1) = 0 And zeros(x, y + 1) = 0 Then
                blank(x, y + 1)
                zeros(x, y + 1) = 1
            End If
            If boxes(x + 1, y - 1) = 0 And zeros(x + 1, y - 1) = 0 Then
                blank(x + 1, y - 1)
                zeros(x + 1, y - 1) = 1
            End If
            If boxes(x + 1, y) = 0 And zeros(x + 1, y) = 0 Then
                blank(x + 1, y)
                zeros(x + 1, y) = 1
            End If
            If boxes(x + 1, y + 1) = 0 And zeros(x + 1, y + 1) = 0 Then
                blank(x + 1, y + 1)
                zeros(x + 1, y + 1) = 1
            End If
        End If
    End Sub

    Function change(x, y) As Integer
        If x = 0 And y = 0 Then
            Button1.Enabled = False
            Return 100
        ElseIf x = 0 And y = 1 Then
            Button2.Enabled = False
            Return 100
        ElseIf x = 0 And y = 2 Then
            Button3.Enabled = False
            Return 100
        ElseIf x = 0 And y = 3 Then
            Button4.Enabled = False
            Return 100
        ElseIf x = 0 And y = 4 Then
            Button5.Enabled = False
            Return 100
        ElseIf x = 0 And y = 5 Then
            Button6.Enabled = False
            Return 100
        ElseIf x = 0 And y = 6 Then
            Button7.Enabled = False
            Return 100
        ElseIf x = 0 And y = 7 Then
            Button8.Enabled = False
            Return 100
        ElseIf x = 0 And y = 8 Then
            Button9.Enabled = False
            Return 100
        ElseIf x = 0 And y = 9 Then
            Button10.Enabled = False
            Return 100
        ElseIf x = 1 And y = 0 Then
            Button11.Enabled = False
            Return 100
        ElseIf x = 1 And y = 1 Then
            Button12.Enabled = False
            Return 100
        ElseIf x = 1 And y = 2 Then
            Button13.Enabled = False
            Return 100
        ElseIf x = 1 And y = 3 Then
            Button14.Enabled = False
            Return 100
        ElseIf x = 1 And y = 4 Then
            Button15.Enabled = False
            Return 100
        ElseIf x = 1 And y = 5 Then
            Button16.Enabled = False
            Return 100
        ElseIf x = 1 And y = 6 Then
            Button17.Enabled = False
            Return 100
        ElseIf x = 1 And y = 7 Then
            Button18.Enabled = False
            Return 100
        ElseIf x = 1 And y = 8 Then
            Button19.Enabled = False
            Return 100
        ElseIf x = 1 And y = 9 Then
            Button20.Enabled = False
            Return 100
        ElseIf x = 2 And y = 0 Then
            Button21.Enabled = False
            Return 100
        ElseIf x = 2 And y = 1 Then
            Button22.Enabled = False
            Return 100
        ElseIf x = 2 And y = 2 Then
            Button23.Enabled = False
            Return 100
        ElseIf x = 2 And y = 3 Then
            Button24.Enabled = False
            Return 100
        ElseIf x = 2 And y = 4 Then
            Button25.Enabled = False
            Return 100
        ElseIf x = 2 And y = 5 Then
            Button26.Enabled = False
            Return 100
        ElseIf x = 2 And y = 6 Then
            Button27.Enabled = False
            Return 100
        ElseIf x = 2 And y = 7 Then
            Button28.Enabled = False
            Return 100
        ElseIf x = 2 And y = 8 Then
            Button29.Enabled = False
            Return 100
        ElseIf x = 2 And y = 9 Then
            Button30.Enabled = False
            Return 100
        ElseIf x = 3 And y = 0 Then
            Button31.Enabled = False
            Return 100
        ElseIf x = 3 And y = 1 Then
            Button32.Enabled = False
            Return 100
        ElseIf x = 3 And y = 2 Then
            Button33.Enabled = False
            Return 100
        ElseIf x = 3 And y = 3 Then
            Button34.Enabled = False
            Return 100
        ElseIf x = 3 And y = 4 Then
            Button35.Enabled = False
            Return 100
        ElseIf x = 3 And y = 5 Then
            Button36.Enabled = False
            Return 100
        ElseIf x = 3 And y = 6 Then
            Button37.Enabled = False
            Return 100
        ElseIf x = 3 And y = 7 Then
            Button38.Enabled = False
            Return 100
        ElseIf x = 3 And y = 8 Then
            Button39.Enabled = False
            Return 100
        ElseIf x = 3 And y = 9 Then
            Button40.Enabled = False
            Return 100
        ElseIf x = 4 And y = 0 Then
            Button41.Enabled = False
            Return 100
        ElseIf x = 4 And y = 1 Then
            Button42.Enabled = False
            Return 100
        ElseIf x = 4 And y = 2 Then
            Button43.Enabled = False
            Return 100
        ElseIf x = 4 And y = 3 Then
            Button44.Enabled = False
            Return 100
        ElseIf x = 4 And y = 4 Then
            Button45.Enabled = False
            Return 100
        ElseIf x = 4 And y = 5 Then
            Button46.Enabled = False
            Return 100
        ElseIf x = 4 And y = 6 Then
            Button47.Enabled = False
            Return 100
        ElseIf x = 4 And y = 7 Then
            Button48.Enabled = False
            Return 100
        ElseIf x = 4 And y = 8 Then
            Button49.Enabled = False
            Return 100
        ElseIf x = 4 And y = 9 Then
            Button50.Enabled = False
            Return 100
        ElseIf x = 5 And y = 0 Then
            Button51.Enabled = False
            Return 100
        ElseIf x = 5 And y = 1 Then
            Button52.Enabled = False
            Return 100
        ElseIf x = 5 And y = 2 Then
            Button53.Enabled = False
            Return 100
        ElseIf x = 5 And y = 3 Then
            Button54.Enabled = False
            Return 100
        ElseIf x = 5 And y = 4 Then
            Button55.Enabled = False
            Return 100
        ElseIf x = 5 And y = 5 Then
            Button56.Enabled = False
            Return 100
        ElseIf x = 5 And y = 6 Then
            Button57.Enabled = False
            Return 100
        ElseIf x = 5 And y = 7 Then
            Button58.Enabled = False
            Return 100
        ElseIf x = 5 And y = 8 Then
            Button59.Enabled = False
            Return 100
        ElseIf x = 5 And y = 9 Then
            Button60.Enabled = False
            Return 100
        ElseIf x = 6 And y = 0 Then
            Button61.Enabled = False
            Return 100
        ElseIf x = 6 And y = 1 Then
            Button62.Enabled = False
            Return 100
        ElseIf x = 6 And y = 2 Then
            Button63.Enabled = False
            Return 100
        ElseIf x = 6 And y = 3 Then
            Button64.Enabled = False
            Return 100
        ElseIf x = 6 And y = 4 Then
            Button65.Enabled = False
            Return 100
        ElseIf x = 6 And y = 5 Then
            Button66.Enabled = False
            Return 100
        ElseIf x = 6 And y = 6 Then
            Button67.Enabled = False
            Return 100
        ElseIf x = 6 And y = 7 Then
            Button68.Enabled = False
            Return 100
        ElseIf x = 6 And y = 8 Then
            Button69.Enabled = False
            Return 100
        ElseIf x = 6 And y = 9 Then
            Button70.Enabled = False
            Return 100
        ElseIf x = 7 And y = 0 Then
            Button71.Enabled = False
            Return 100
        ElseIf x = 7 And y = 1 Then
            Button72.Enabled = False
            Return 100
        ElseIf x = 7 And y = 2 Then
            Button73.Enabled = False
            Return 100
        ElseIf x = 7 And y = 3 Then
            Button74.Enabled = False
            Return 100
        ElseIf x = 7 And y = 4 Then
            Button75.Enabled = False
            Return 100
        ElseIf x = 7 And y = 5 Then
            Button76.Enabled = False
            Return 100
        ElseIf x = 7 And y = 6 Then
            Button77.Enabled = False
            Return 100
        ElseIf x = 7 And y = 7 Then
            Button78.Enabled = False
            Return 100
        ElseIf x = 7 And y = 8 Then
            Button79.Enabled = False
            Return 100
        ElseIf x = 7 And y = 9 Then
            Button80.Enabled = False
            Return 100
        ElseIf x = 8 And y = 0 Then
            Button81.Enabled = False
            Return 100
        ElseIf x = 8 And y = 1 Then
            Button82.Enabled = False
            Return 100
        ElseIf x = 8 And y = 2 Then
            Button83.Enabled = False
            Return 100
        ElseIf x = 8 And y = 3 Then
            Button84.Enabled = False
            Return 100
        ElseIf x = 8 And y = 4 Then
            Button85.Enabled = False
            Return 100
        ElseIf x = 8 And y = 5 Then
            Button86.Enabled = False
            Return 100
        ElseIf x = 8 And y = 6 Then
            Button87.Enabled = False
            Return 100
        ElseIf x = 8 And y = 7 Then
            Button88.Enabled = False
            Return 100
        ElseIf x = 8 And y = 8 Then
            Button89.Enabled = False
            Return 100
        ElseIf x = 8 And y = 9 Then
            Button90.Enabled = False
            Return 100
        ElseIf x = 9 And y = 0 Then
            Button91.Enabled = False
            Return 100
        ElseIf x = 9 And y = 1 Then
            Button92.Enabled = False
            Return 100
        ElseIf x = 9 And y = 2 Then
            Button93.Enabled = False
            Return 100
        ElseIf x = 9 And y = 3 Then
            Button94.Enabled = False
            Return 100
        ElseIf x = 9 And y = 4 Then
            Button95.Enabled = False
            Return 100
        ElseIf x = 9 And y = 5 Then
            Button96.Enabled = False
            Return 100
        ElseIf x = 9 And y = 6 Then
            Button97.Enabled = False
            Return 100
        ElseIf x = 9 And y = 7 Then
            Button98.Enabled = False
            Return 100
        ElseIf x = 9 And y = 8 Then
            Button99.Enabled = False
            Return 100
        ElseIf x = 9 And y = 9 Then
            Button100.Enabled = False
            Return 100
        Else
            Return 100

        End If

    End Function

    Function changeT(x, y) As Integer
        If x = 0 And y = 0 Then
            Button1.Enabled = True
            Return 100
        ElseIf x = 0 And y = 1 Then
            Button2.Enabled = True
            Return 100
        ElseIf x = 0 And y = 2 Then
            Button3.Enabled = True
            Return 100
        ElseIf x = 0 And y = 3 Then
            Button4.Enabled = True
            Return 100
        ElseIf x = 0 And y = 4 Then
            Button5.Enabled = True
            Return 100
        ElseIf x = 0 And y = 5 Then
            Button6.Enabled = True
            Return 100
        ElseIf x = 0 And y = 6 Then
            Button7.Enabled = True
            Return 100
        ElseIf x = 0 And y = 7 Then
            Button8.Enabled = True
            Return 100
        ElseIf x = 0 And y = 8 Then
            Button9.Enabled = True
            Return 100
        ElseIf x = 0 And y = 9 Then
            Button10.Enabled = True
            Return 100
        ElseIf x = 1 And y = 0 Then
            Button11.Enabled = True
            Return 100
        ElseIf x = 1 And y = 1 Then
            Button12.Enabled = True
            Return 100
        ElseIf x = 1 And y = 2 Then
            Button13.Enabled = True
            Return 100
        ElseIf x = 1 And y = 3 Then
            Button14.Enabled = True
            Return 100
        ElseIf x = 1 And y = 4 Then
            Button15.Enabled = True
            Return 100
        ElseIf x = 1 And y = 5 Then
            Button16.Enabled = True
            Return 100
        ElseIf x = 1 And y = 6 Then
            Button17.Enabled = True
            Return 100
        ElseIf x = 1 And y = 7 Then
            Button18.Enabled = True
            Return 100
        ElseIf x = 1 And y = 8 Then
            Button19.Enabled = True
            Return 100
        ElseIf x = 1 And y = 9 Then
            Button20.Enabled = True
            Return 100
        ElseIf x = 2 And y = 0 Then
            Button21.Enabled = True
            Return 100
        ElseIf x = 2 And y = 1 Then
            Button22.Enabled = True
            Return 100
        ElseIf x = 2 And y = 2 Then
            Button23.Enabled = True
            Return 100
        ElseIf x = 2 And y = 3 Then
            Button24.Enabled = True
            Return 100
        ElseIf x = 2 And y = 4 Then
            Button25.Enabled = True
            Return 100
        ElseIf x = 2 And y = 5 Then
            Button26.Enabled = True
            Return 100
        ElseIf x = 2 And y = 6 Then
            Button27.Enabled = True
            Return 100
        ElseIf x = 2 And y = 7 Then
            Button28.Enabled = True
            Return 100
        ElseIf x = 2 And y = 8 Then
            Button29.Enabled = True
            Return 100
        ElseIf x = 2 And y = 9 Then
            Button30.Enabled = True
            Return 100
        ElseIf x = 3 And y = 0 Then
            Button31.Enabled = True
            Return 100
        ElseIf x = 3 And y = 1 Then
            Button32.Enabled = True
            Return 100
        ElseIf x = 3 And y = 2 Then
            Button33.Enabled = True
            Return 100
        ElseIf x = 3 And y = 3 Then
            Button34.Enabled = True
            Return 100
        ElseIf x = 3 And y = 4 Then
            Button35.Enabled = True
            Return 100
        ElseIf x = 3 And y = 5 Then
            Button36.Enabled = True
            Return 100
        ElseIf x = 3 And y = 6 Then
            Button37.Enabled = True
            Return 100
        ElseIf x = 3 And y = 7 Then
            Button38.Enabled = True
            Return 100
        ElseIf x = 3 And y = 8 Then
            Button39.Enabled = True
            Return 100
        ElseIf x = 3 And y = 9 Then
            Button40.Enabled = True
            Return 100
        ElseIf x = 4 And y = 0 Then
            Button41.Enabled = True
            Return 100
        ElseIf x = 4 And y = 1 Then
            Button42.Enabled = True
            Return 100
        ElseIf x = 4 And y = 2 Then
            Button43.Enabled = True
            Return 100
        ElseIf x = 4 And y = 3 Then
            Button44.Enabled = True
            Return 100
        ElseIf x = 4 And y = 4 Then
            Button45.Enabled = True
            Return 100
        ElseIf x = 4 And y = 5 Then
            Button46.Enabled = True
            Return 100
        ElseIf x = 4 And y = 6 Then
            Button47.Enabled = True
            Return 100
        ElseIf x = 4 And y = 7 Then
            Button48.Enabled = True
            Return 100
        ElseIf x = 4 And y = 8 Then
            Button49.Enabled = True
            Return 100
        ElseIf x = 4 And y = 9 Then
            Button50.Enabled = True
            Return 100
        ElseIf x = 5 And y = 0 Then
            Button51.Enabled = True
            Return 100
        ElseIf x = 5 And y = 1 Then
            Button52.Enabled = True
            Return 100
        ElseIf x = 5 And y = 2 Then
            Button53.Enabled = True
            Return 100
        ElseIf x = 5 And y = 3 Then
            Button54.Enabled = True
            Return 100
        ElseIf x = 5 And y = 4 Then
            Button55.Enabled = True
            Return 100
        ElseIf x = 5 And y = 5 Then
            Button56.Enabled = True
            Return 100
        ElseIf x = 5 And y = 6 Then
            Button57.Enabled = True
            Return 100
        ElseIf x = 5 And y = 7 Then
            Button58.Enabled = True
            Return 100
        ElseIf x = 5 And y = 8 Then
            Button59.Enabled = True
            Return 100
        ElseIf x = 5 And y = 9 Then
            Button60.Enabled = True
            Return 100
        ElseIf x = 6 And y = 0 Then
            Button61.Enabled = True
            Return 100
        ElseIf x = 6 And y = 1 Then
            Button62.Enabled = True
            Return 100
        ElseIf x = 6 And y = 2 Then
            Button63.Enabled = True
            Return 100
        ElseIf x = 6 And y = 3 Then
            Button64.Enabled = True
            Return 100
        ElseIf x = 6 And y = 4 Then
            Button65.Enabled = True
            Return 100
        ElseIf x = 6 And y = 5 Then
            Button66.Enabled = True
            Return 100
        ElseIf x = 6 And y = 6 Then
            Button67.Enabled = True
            Return 100
        ElseIf x = 6 And y = 7 Then
            Button68.Enabled = True
            Return 100
        ElseIf x = 6 And y = 8 Then
            Button69.Enabled = True
            Return 100
        ElseIf x = 6 And y = 9 Then
            Button70.Enabled = True
            Return 100
        ElseIf x = 7 And y = 0 Then
            Button71.Enabled = True
            Return 100
        ElseIf x = 7 And y = 1 Then
            Button72.Enabled = True
            Return 100
        ElseIf x = 7 And y = 2 Then
            Button73.Enabled = True
            Return 100
        ElseIf x = 7 And y = 3 Then
            Button74.Enabled = True
            Return 100
        ElseIf x = 7 And y = 4 Then
            Button75.Enabled = True
            Return 100
        ElseIf x = 7 And y = 5 Then
            Button76.Enabled = True
            Return 100
        ElseIf x = 7 And y = 6 Then
            Button77.Enabled = True
            Return 100
        ElseIf x = 7 And y = 7 Then
            Button78.Enabled = True
            Return 100
        ElseIf x = 7 And y = 8 Then
            Button79.Enabled = True
            Return 100
        ElseIf x = 7 And y = 9 Then
            Button80.Enabled = True
            Return 100
        ElseIf x = 8 And y = 0 Then
            Button81.Enabled = True
            Return 100
        ElseIf x = 8 And y = 1 Then
            Button82.Enabled = True
            Return 100
        ElseIf x = 8 And y = 2 Then
            Button83.Enabled = True
            Return 100
        ElseIf x = 8 And y = 3 Then
            Button84.Enabled = True
            Return 100
        ElseIf x = 8 And y = 4 Then
            Button85.Enabled = True
            Return 100
        ElseIf x = 8 And y = 5 Then
            Button86.Enabled = True
            Return 100
        ElseIf x = 8 And y = 6 Then
            Button87.Enabled = True
            Return 100
        ElseIf x = 8 And y = 7 Then
            Button88.Enabled = True
            Return 100
        ElseIf x = 8 And y = 8 Then
            Button89.Enabled = True
            Return 100
        ElseIf x = 8 And y = 9 Then
            Button90.Enabled = True
            Return 100
        ElseIf x = 9 And y = 0 Then
            Button91.Enabled = True
            Return 100
        ElseIf x = 9 And y = 1 Then
            Button92.Enabled = True
            Return 100
        ElseIf x = 9 And y = 2 Then
            Button93.Enabled = True
            Return 100
        ElseIf x = 9 And y = 3 Then
            Button94.Enabled = True
            Return 100
        ElseIf x = 9 And y = 4 Then
            Button95.Enabled = True
            Return 100
        ElseIf x = 9 And y = 5 Then
            Button96.Enabled = True
            Return 100
        ElseIf x = 9 And y = 6 Then
            Button97.Enabled = True
            Return 100
        ElseIf x = 9 And y = 7 Then
            Button98.Enabled = True
            Return 100
        ElseIf x = 9 And y = 8 Then
            Button99.Enabled = True
            Return 100
        ElseIf x = 9 And y = 9 Then
            Button100.Enabled = True
            Return 100
        Else
            Return 100

        End If

    End Function

    Function number(x, y) As Integer
        If x = 0 And y = 0 Then
            Button1.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 1 Then
            Button2.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 2 Then
            Button3.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 3 Then
            Button4.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 4 Then
            Button5.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 5 Then
            Button6.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 6 Then
            Button7.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 7 Then
            Button8.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 8 Then
            Button9.Text = boxes(x, y)
            Return 100
        ElseIf x = 0 And y = 9 Then
            Button10.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 0 Then
            Button11.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 1 Then
            Button12.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 2 Then
            Button13.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 3 Then
            Button14.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 4 Then
            Button15.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 5 Then
            Button16.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 6 Then
            Button17.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 7 Then
            Button18.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 8 Then
            Button19.Text = boxes(x, y)
            Return 100
        ElseIf x = 1 And y = 9 Then
            Button20.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 0 Then
            Button21.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 1 Then
            Button22.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 2 Then
            Button23.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 3 Then
            Button24.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 4 Then
            Button25.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 5 Then
            Button26.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 6 Then
            Button27.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 7 Then
            Button28.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 8 Then
            Button29.Text = boxes(x, y)
            Return 100
        ElseIf x = 2 And y = 9 Then
            Button30.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 0 Then
            Button31.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 1 Then
            Button32.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 2 Then
            Button33.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 3 Then
            Button34.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 4 Then
            Button35.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 5 Then
            Button36.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 6 Then
            Button37.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 7 Then
            Button38.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 8 Then
            Button39.Text = boxes(x, y)
            Return 100
        ElseIf x = 3 And y = 9 Then
            Button40.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 0 Then
            Button41.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 1 Then
            Button42.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 2 Then
            Button43.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 3 Then
            Button44.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 4 Then
            Button45.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 5 Then
            Button46.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 6 Then
            Button47.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 7 Then
            Button48.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 8 Then
            Button49.Text = boxes(x, y)
            Return 100
        ElseIf x = 4 And y = 9 Then
            Button50.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 0 Then
            Button51.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 1 Then
            Button52.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 2 Then
            Button53.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 3 Then
            Button54.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 4 Then
            Button55.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 5 Then
            Button56.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 6 Then
            Button57.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 7 Then
            Button58.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 8 Then
            Button59.Text = boxes(x, y)
            Return 100
        ElseIf x = 5 And y = 9 Then
            Button60.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 0 Then
            Button61.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 1 Then
            Button62.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 2 Then
            Button63.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 3 Then
            Button64.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 4 Then
            Button65.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 5 Then
            Button66.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 6 Then
            Button67.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 7 Then
            Button68.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 8 Then
            Button69.Text = boxes(x, y)
            Return 100
        ElseIf x = 6 And y = 9 Then
            Button70.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 0 Then
            Button71.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 1 Then
            Button72.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 2 Then
            Button73.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 3 Then
            Button74.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 4 Then
            Button75.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 5 Then
            Button76.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 6 Then
            Button77.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 7 Then
            Button78.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 8 Then
            Button79.Text = boxes(x, y)
            Return 100
        ElseIf x = 7 And y = 9 Then
            Button80.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 0 Then
            Button81.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 1 Then
            Button82.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 2 Then
            Button83.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 3 Then
            Button84.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 4 Then
            Button85.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 5 Then
            Button86.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 6 Then
            Button87.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 7 Then
            Button88.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 8 Then
            Button89.Text = boxes(x, y)
            Return 100
        ElseIf x = 8 And y = 9 Then
            Button90.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 0 Then
            Button91.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 1 Then
            Button92.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 2 Then
            Button93.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 3 Then
            Button94.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 4 Then
            Button95.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 5 Then
            Button96.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 6 Then
            Button97.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 7 Then
            Button98.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 8 Then
            Button99.Text = boxes(x, y)
            Return 100
        ElseIf x = 9 And y = 9 Then
            Button100.Text = boxes(x, y)
            Return 100
        Else
            Return 100

        End If

    End Function

    Function renum(x, y) As Integer
        If x = 0 And y = 0 Then
            Button1.Text = " "
            Return 100
        ElseIf x = 0 And y = 1 Then
            Button2.Text = " "
            Return 100
        ElseIf x = 0 And y = 2 Then
            Button3.Text = " "
            Return 100
        ElseIf x = 0 And y = 3 Then
            Button4.Text = " "
            Return 100
        ElseIf x = 0 And y = 4 Then
            Button5.Text = " "
            Return 100
        ElseIf x = 0 And y = 5 Then
            Button6.Text = " "
            Return 100
        ElseIf x = 0 And y = 6 Then
            Button7.Text = " "
            Return 100
        ElseIf x = 0 And y = 7 Then
            Button8.Text = " "
            Return 100
        ElseIf x = 0 And y = 8 Then
            Button9.Text = " "
            Return 100
        ElseIf x = 0 And y = 9 Then
            Button10.Text = " "
            Return 100
        ElseIf x = 1 And y = 0 Then
            Button11.Text = " "
            Return 100
        ElseIf x = 1 And y = 1 Then
            Button12.Text = " "
            Return 100
        ElseIf x = 1 And y = 2 Then
            Button13.Text = " "
            Return 100
        ElseIf x = 1 And y = 3 Then
            Button14.Text = " "
            Return 100
        ElseIf x = 1 And y = 4 Then
            Button15.Text = " "
            Return 100
        ElseIf x = 1 And y = 5 Then
            Button16.Text = " "
            Return 100
        ElseIf x = 1 And y = 6 Then
            Button17.Text = " "
            Return 100
        ElseIf x = 1 And y = 7 Then
            Button18.Text = " "
            Return 100
        ElseIf x = 1 And y = 8 Then
            Button19.Text = " "
            Return 100
        ElseIf x = 1 And y = 9 Then
            Button20.Text = " "
            Return 100
        ElseIf x = 2 And y = 0 Then
            Button21.Text = " "
            Return 100
        ElseIf x = 2 And y = 1 Then
            Button22.Text = " "
            Return 100
        ElseIf x = 2 And y = 2 Then
            Button23.Text = " "
            Return 100
        ElseIf x = 2 And y = 3 Then
            Button24.Text = " "
            Return 100
        ElseIf x = 2 And y = 4 Then
            Button25.Text = " "
            Return 100
        ElseIf x = 2 And y = 5 Then
            Button26.Text = " "
            Return 100
        ElseIf x = 2 And y = 6 Then
            Button27.Text = " "
            Return 100
        ElseIf x = 2 And y = 7 Then
            Button28.Text = " "
            Return 100
        ElseIf x = 2 And y = 8 Then
            Button29.Text = " "
            Return 100
        ElseIf x = 2 And y = 9 Then
            Button30.Text = " "
            Return 100
        ElseIf x = 3 And y = 0 Then
            Button31.Text = " "
            Return 100
        ElseIf x = 3 And y = 1 Then
            Button32.Text = " "
            Return 100
        ElseIf x = 3 And y = 2 Then
            Button33.Text = " "
            Return 100
        ElseIf x = 3 And y = 3 Then
            Button34.Text = " "
            Return 100
        ElseIf x = 3 And y = 4 Then
            Button35.Text = " "
            Return 100
        ElseIf x = 3 And y = 5 Then
            Button36.Text = " "
            Return 100
        ElseIf x = 3 And y = 6 Then
            Button37.Text = " "
            Return 100
        ElseIf x = 3 And y = 7 Then
            Button38.Text = " "
            Return 100
        ElseIf x = 3 And y = 8 Then
            Button39.Text = " "
            Return 100
        ElseIf x = 3 And y = 9 Then
            Button40.Text = " "
            Return 100
        ElseIf x = 4 And y = 0 Then
            Button41.Text = " "
            Return 100
        ElseIf x = 4 And y = 1 Then
            Button42.Text = " "
            Return 100
        ElseIf x = 4 And y = 2 Then
            Button43.Text = " "
            Return 100
        ElseIf x = 4 And y = 3 Then
            Button44.Text = " "
            Return 100
        ElseIf x = 4 And y = 4 Then
            Button45.Text = " "
            Return 100
        ElseIf x = 4 And y = 5 Then
            Button46.Text = " "
            Return 100
        ElseIf x = 4 And y = 6 Then
            Button47.Text = " "
            Return 100
        ElseIf x = 4 And y = 7 Then
            Button48.Text = " "
            Return 100
        ElseIf x = 4 And y = 8 Then
            Button49.Text = " "
            Return 100
        ElseIf x = 4 And y = 9 Then
            Button50.Text = " "
            Return 100
        ElseIf x = 5 And y = 0 Then
            Button51.Text = " "
            Return 100
        ElseIf x = 5 And y = 1 Then
            Button52.Text = " "
            Return 100
        ElseIf x = 5 And y = 2 Then
            Button53.Text = " "
            Return 100
        ElseIf x = 5 And y = 3 Then
            Button54.Text = " "
            Return 100
        ElseIf x = 5 And y = 4 Then
            Button55.Text = " "
            Return 100
        ElseIf x = 5 And y = 5 Then
            Button56.Text = " "
            Return 100
        ElseIf x = 5 And y = 6 Then
            Button57.Text = " "
            Return 100
        ElseIf x = 5 And y = 7 Then
            Button58.Text = " "
            Return 100
        ElseIf x = 5 And y = 8 Then
            Button59.Text = " "
            Return 100
        ElseIf x = 5 And y = 9 Then
            Button60.Text = " "
            Return 100
        ElseIf x = 6 And y = 0 Then
            Button61.Text = " "
            Return 100
        ElseIf x = 6 And y = 1 Then
            Button62.Text = " "
            Return 100
        ElseIf x = 6 And y = 2 Then
            Button63.Text = " "
            Return 100
        ElseIf x = 6 And y = 3 Then
            Button64.Text = " "
            Return 100
        ElseIf x = 6 And y = 4 Then
            Button65.Text = " "
            Return 100
        ElseIf x = 6 And y = 5 Then
            Button66.Text = " "
            Return 100
        ElseIf x = 6 And y = 6 Then
            Button67.Text = " "
            Return 100
        ElseIf x = 6 And y = 7 Then
            Button68.Text = " "
            Return 100
        ElseIf x = 6 And y = 8 Then
            Button69.Text = " "
            Return 100
        ElseIf x = 6 And y = 9 Then
            Button70.Text = " "
            Return 100
        ElseIf x = 7 And y = 0 Then
            Button71.Text = " "
            Return 100
        ElseIf x = 7 And y = 1 Then
            Button72.Text = " "
            Return 100
        ElseIf x = 7 And y = 2 Then
            Button73.Text = " "
            Return 100
        ElseIf x = 7 And y = 3 Then
            Button74.Text = " "
            Return 100
        ElseIf x = 7 And y = 4 Then
            Button75.Text = " "
            Return 100
        ElseIf x = 7 And y = 5 Then
            Button76.Text = " "
            Return 100
        ElseIf x = 7 And y = 6 Then
            Button77.Text = " "
            Return 100
        ElseIf x = 7 And y = 7 Then
            Button78.Text = " "
            Return 100
        ElseIf x = 7 And y = 8 Then
            Button79.Text = " "
            Return 100
        ElseIf x = 7 And y = 9 Then
            Button80.Text = " "
            Return 100
        ElseIf x = 8 And y = 0 Then
            Button81.Text = " "
            Return 100
        ElseIf x = 8 And y = 1 Then
            Button82.Text = " "
            Return 100
        ElseIf x = 8 And y = 2 Then
            Button83.Text = " "
            Return 100
        ElseIf x = 8 And y = 3 Then
            Button84.Text = " "
            Return 100
        ElseIf x = 8 And y = 4 Then
            Button85.Text = " "
            Return 100
        ElseIf x = 8 And y = 5 Then
            Button86.Text = " "
            Return 100
        ElseIf x = 8 And y = 6 Then
            Button87.Text = " "
            Return 100
        ElseIf x = 8 And y = 7 Then
            Button88.Text = " "
            Return 100
        ElseIf x = 8 And y = 8 Then
            Button89.Text = " "
            Return 100
        ElseIf x = 8 And y = 9 Then
            Button90.Text = " "
            Return 100
        ElseIf x = 9 And y = 0 Then
            Button91.Text = " "
            Return 100
        ElseIf x = 9 And y = 1 Then
            Button92.Text = " "
            Return 100
        ElseIf x = 9 And y = 2 Then
            Button93.Text = " "
            Return 100
        ElseIf x = 9 And y = 3 Then
            Button94.Text = " "
            Return 100
        ElseIf x = 9 And y = 4 Then
            Button95.Text = " "
            Return 100
        ElseIf x = 9 And y = 5 Then
            Button96.Text = " "
            Return 100
        ElseIf x = 9 And y = 6 Then
            Button97.Text = " "
            Return 100
        ElseIf x = 9 And y = 7 Then
            Button98.Text = " "
            Return 100
        ElseIf x = 9 And y = 8 Then
            Button99.Text = " "
            Return 100
        ElseIf x = 9 And y = 9 Then
            Button100.Text = " "
            Return 100
        Else
            Return 100

        End If

    End Function

    Function bomb(x, y) As Integer
        If x = 0 And y = 0 Then
            Button1.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 1 Then
            Button2.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 2 Then
            Button3.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 3 Then
            Button4.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 4 Then
            Button5.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 5 Then
            Button6.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 6 Then
            Button7.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 7 Then
            Button8.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 8 Then
            Button9.BackColor = Color.Red
            Return 100
        ElseIf x = 0 And y = 9 Then
            Button10.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 0 Then
            Button11.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 1 Then
            Button12.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 2 Then
            Button13.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 3 Then
            Button14.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 4 Then
            Button15.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 5 Then
            Button16.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 6 Then
            Button17.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 7 Then
            Button18.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 8 Then
            Button19.BackColor = Color.Red
            Return 100
        ElseIf x = 1 And y = 9 Then
            Button20.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 0 Then
            Button21.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 1 Then
            Button22.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 2 Then
            Button23.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 3 Then
            Button24.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 4 Then
            Button25.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 5 Then
            Button26.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 6 Then
            Button27.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 7 Then
            Button28.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 8 Then
            Button28.BackColor = Color.Red
            Return 100
        ElseIf x = 2 And y = 9 Then
            Button30.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 0 Then
            Button31.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 1 Then
            Button32.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 2 Then
            Button33.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 3 Then
            Button34.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 4 Then
            Button35.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 5 Then
            Button36.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 6 Then
            Button37.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 7 Then
            Button38.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 8 Then
            Button39.BackColor = Color.Red
            Return 100
        ElseIf x = 3 And y = 9 Then
            Button40.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 0 Then
            Button41.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 1 Then
            Button42.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 2 Then
            Button43.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 3 Then
            Button44.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 4 Then
            Button45.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 5 Then
            Button46.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 6 Then
            Button47.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 7 Then
            Button48.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 8 Then
            Button49.BackColor = Color.Red
            Return 100
        ElseIf x = 4 And y = 9 Then
            Button50.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 0 Then
            Button51.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 1 Then
            Button52.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 2 Then
            Button53.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 3 Then
            Button54.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 4 Then
            Button55.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 5 Then
            Button56.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 6 Then
            Button57.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 7 Then
            Button58.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 8 Then
            Button59.BackColor = Color.Red
            Return 100
        ElseIf x = 5 And y = 9 Then
            Button60.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 0 Then
            Button61.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 1 Then
            Button62.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 2 Then
            Button63.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 3 Then
            Button64.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 4 Then
            Button65.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 5 Then
            Button66.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 6 Then
            Button67.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 7 Then
            Button68.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 8 Then
            Button69.BackColor = Color.Red
            Return 100
        ElseIf x = 6 And y = 9 Then
            Button70.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 0 Then
            Button71.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 1 Then
            Button72.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 2 Then
            Button73.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 3 Then
            Button74.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 4 Then
            Button75.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 5 Then
            Button76.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 6 Then
            Button77.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 7 Then
            Button78.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 8 Then
            Button79.BackColor = Color.Red
            Return 100
        ElseIf x = 7 And y = 9 Then
            Button80.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 0 Then
            Button81.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 1 Then
            Button82.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 2 Then
            Button83.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 3 Then
            Button84.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 4 Then
            Button85.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 5 Then
            Button86.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 6 Then
            Button87.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 7 Then
            Button88.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 8 Then
            Button89.BackColor = Color.Red
            Return 100
        ElseIf x = 8 And y = 9 Then
            Button90.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 0 Then
            Button91.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 1 Then
            Button92.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 2 Then
            Button93.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 3 Then
            Button94.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 4 Then
            Button95.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 5 Then
            Button96.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 6 Then
            Button97.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 7 Then
            Button98.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 8 Then
            Button99.BackColor = Color.Red
            Return 100
        ElseIf x = 9 And y = 9 Then
            Button100.BackColor = Color.Red
            Return 100
        Else
            Return 100

        End If

    End Function

    Public Sub gameOver()
        Dim m As Integer = 0
        Dim n As Integer = 0
        While m < 10
            n = 0
            While n < 10
                change(m, n)
                If boxes(m, n) < 0 Then
                    bomb(m, n)
                End If
                n += 1
            End While
            m += 1
        End While
        lblGameOver.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        spot1 = 0
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button1.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        spot1 = 0
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button2.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        spot1 = 0
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button3.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        spot1 = 0
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button4.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        spot1 = 0
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button5.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        spot1 = 0
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button6.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        spot1 = 0
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button7.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        spot1 = 0
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button8.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        spot1 = 0
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button9.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        spot1 = 0
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button10.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        spot1 = 1
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button11.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        spot1 = 1
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button12.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        spot1 = 1
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button13.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        spot1 = 1
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button14.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        spot1 = 1
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button15.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        spot1 = 1
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button16.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        spot1 = 1
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button17.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        spot1 = 1
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button18.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        spot1 = 1
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button19.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        spot1 = 1
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button20.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        spot1 = 2
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button21.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        spot1 = 2
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button22.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        spot1 = 2
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button23.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        spot1 = 2
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button24.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        spot1 = 2
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button25.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        spot1 = 2
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button26.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        spot1 = 2
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button27.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        spot1 = 2
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button28.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        spot1 = 2
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button29.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        spot1 = 2
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button30.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        spot1 = 3
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button31.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        spot1 = 3
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button32.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        spot1 = 3
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button33.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        spot1 = 3
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button34.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        spot1 = 3
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button35.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        spot1 = 3
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button36.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        spot1 = 3
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button37.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        spot1 = 3
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button38.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        spot1 = 3
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button39.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        spot1 = 3
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button40.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        spot1 = 4
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button41.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        spot1 = 4
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button42.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        spot1 = 4
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button43.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        spot1 = 4
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button44.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        spot1 = 4
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button45.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        spot1 = 4
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button46.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        spot1 = 4
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button47.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        spot1 = 4
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button48.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        spot1 = 4
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button49.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        spot1 = 4
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button50.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        spot1 = 5
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button51.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        spot1 = 5
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button52.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        spot1 = 5
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button53.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        spot1 = 5
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button54.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        spot1 = 5
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button55.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        spot1 = 5
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button56.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        spot1 = 5
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button57.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        spot1 = 5
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button58.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        spot1 = 5
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button59.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        spot1 = 5
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button60.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        spot1 = 6
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button61.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        spot1 = 6
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button62.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        spot1 = 6
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button63.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        spot1 = 6
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button64.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        spot1 = 6
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button65.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        spot1 = 6
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button66.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        spot1 = 6
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button67.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        spot1 = 6
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button68.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        spot1 = 6
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button69.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        spot1 = 6
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button70.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        spot1 = 7
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button71.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        spot1 = 7
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button72.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        spot1 = 7
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button73.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        spot1 = 7
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button74.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        spot1 = 7
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button75.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        spot1 = 7
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button76.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        spot1 = 7
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button77.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        spot1 = 7
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button78.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        spot1 = 7
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button79.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        spot1 = 7
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button80.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        spot1 = 8
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button81.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        spot1 = 8
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button82.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        spot1 = 8
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button83.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        spot1 = 8
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button84.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        spot1 = 8
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button85.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        spot1 = 8
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button86.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        spot1 = 8
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button87.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        spot1 = 8
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button88.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        spot1 = 8
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button89.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        spot1 = 8
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button90.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        spot1 = 9
        spot2 = 0
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button91.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        spot1 = 9
        spot2 = 1
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button92.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        spot1 = 9
        spot2 = 2
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button93.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        spot1 = 9
        spot2 = 3
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button94.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        spot1 = 9
        spot2 = 4
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button95.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Button96.Click
        spot1 = 9
        spot2 = 5
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button96.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        spot1 = 9
        spot2 = 6
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button97.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        spot1 = 9
        spot2 = 7
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button98.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        spot1 = 9
        spot2 = 8
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button99.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        spot1 = 9
        spot2 = 9
        If check(spot1, spot2) = -1 Then
            gameOver()
        ElseIf check(spot1, spot2) = 0 Then
            blank(spot1, spot2)
        ElseIf check(spot1, spot2) = 1 Then
            Button100.Text = boxes(spot1, spot2)
            change(spot1, spot2)
        End If
    End Sub

    Private Sub lblNew_Click(sender As Object, e As EventArgs) Handles lblNew.Click
        newGame(bombSpots)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
