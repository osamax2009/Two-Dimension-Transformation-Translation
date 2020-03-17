Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim blackPen As New Pen(Color.Black, 3)
        ' Create coordinates of points that define line.
        Dim x1 As Single = 100
        Dim y1 As Single = 200
        Dim x2 As Single = 100
        Dim y2 As Single = 100

        Dim x3 As Single = 200
        Dim y3 As Single = 100


        ' Draw line to screen.
        e.Graphics.DrawLine(blackPen, x1, y1, x2, y2)
        e.Graphics.DrawLine(blackPen, x2, y2, x3, y3)
        e.Graphics.DrawLine(blackPen, x3, y3, x1, y1)

        Dim Tx As Integer = 5
        Dim ty As Integer = 10

        Dim world(2, 2) As Integer
        For i As Integer = 0 To world.GetLength(0) - 1
            For j As Integer = 0 To world.GetLength(1) - 1
                If (i = 0) And (j = 2) Then

                    world(i, j) = Tx

                    Continue For



                ElseIf (i = 1) And (j = 2) Then
                    world(i, j) = ty

                    Continue For



                ElseIf (i = j) Then
                    world(i, j) = 1

                    Continue For

                Else
                    world(i, j) = 0
                End If


            Next

        Next






        For i As Integer = 0 To world.GetLength(0) - 1
            For j As Integer = 0 To world.GetLength(1) - 1
                Console.Write(world(i, j))
            Next
            Console.WriteLine()
        Next






        Dim vertex(2, 2) As Integer
        For i As Integer = 0 To vertex.GetLength(0) - 1
            For j As Integer = 0 To vertex.GetLength(1) - 1
                If (i = 0) And (j = 0) Then
                    vertex(i, j) = x1

                    Continue For
                ElseIf (i = 1) And (j = 0) Then
                    vertex(i, j) = y1

                    Continue For
                ElseIf (i = 0) And (j = 1) Then
                    vertex(i, j) = x2

                    Continue For
                ElseIf (i = 1) And (j = 1) Then
                    vertex(i, j) = y2
                    Continue For

                ElseIf (i = 0) And (j = 2) Then
                    vertex(i, j) = x3
                    Continue For

                ElseIf (i = 1) And (j = 2) Then
                    vertex(i, j) = y3
                    Continue For
                End If
                vertex(i, j) = 1


            Next

        Next



        Console.WriteLine("vertix")


        For i As Integer = 0 To vertex.GetLength(0) - 1
            For j As Integer = 0 To vertex.GetLength(1) - 1
                Console.Write(vertex(i, j))
            Next
            Console.WriteLine()
        Next




        Console.WriteLine("prime")



        Dim prime(2, 2) As Integer

        Dim temp As Integer
        For i As Integer = 0 To prime.GetLength(0) - 1
            For j As Integer = 0 To prime.GetLength(1) - 1
                For k As Integer = 0 To prime.GetLength(1) - 1
                    temp = temp + world(i, k) * vertex(k, j)

                Next
                prime(i, j) = temp

                temp = 0

            Next

        Next

        For i As Integer = 0 To prime.GetLength(0) - 1
            For j As Integer = 0 To prime.GetLength(1) - 1
                Console.Write(prime(i, j))
            Next
            Console.WriteLine()
        Next



        For i As Integer = 0 To prime.GetLength(0) - 1
            For j As Integer = 0 To prime.GetLength(1) - 1
                If (i = 0) And (j = 0) Then
                    x1 = prime(i, j)

                    Continue For
                ElseIf (i = 1) And (j = 0) Then
                    y1 = prime(i, j)

                    Continue For
                ElseIf (i = 0) And (j = 1) Then
                    x2 = prime(i, j)

                    Continue For
                ElseIf (i = 1) And (j = 1) Then
                    y2 = prime(i, j)
                    Continue For

                ElseIf (i = 0) And (j = 2) Then
                    x3 = prime(i, j)
                    Continue For

                ElseIf (i = 1) And (j = 2) Then
                    y3 = prime(i, j)
                    Continue For
                End If
            Next
        Next
        e.Graphics.DrawLine(Pens.Red, x1, y1, x2, y2)
        e.Graphics.DrawLine(Pens.Red, x2, y2, x3, y3)
        e.Graphics.DrawLine(Pens.Red, x3, y3, x1, y1)



    End Sub
End Class
