Public Class Form1

    Public Enum Direction As Integer
        Up
        Down
        Left
        Right
    End Enum

    Public Shared Player1 As New PlayerGreen
    Public Shared Player2 As New PlayerWhite

    Private BulletsGreenUp(-1) As BulletGreen
    Private BulletsGreenDown(-1) As BulletGreen
    Private BulletsGreenLeft(-1) As BulletGreen
    Private BulletsGreenRight(-1) As BulletGreen
    Private BulletsWhiteUp(-1) As BulletWhite
    Private BulletsWhiteDown(-1) As BulletWhite
    Private BulletsWhiteLeft(-1) As BulletWhite
    Private BulletsWhiteRight(-1) As BulletWhite

    Private KeyCode1 As Integer
    Private KeyCode2 As Integer

    Private IntGreenUpCount As Integer
    Private IntGreenDownCount As Integer
    Private IntGreenLeftCount As Integer
    Private IntGreenRightCount As Integer

    Private IntWhiteUpCount As Integer
    Private IntWhiteDownCount As Integer
    Private IntWhiteLeftCount As Integer
    Private IntWhiteRightCount As Integer


    Public Shared CanShootGreen As Boolean = True
    Public Shared CanShootWhite As Boolean = True

    Dim wB As Boolean
    Dim sB As Boolean
    Dim aB As Boolean
    Dim dB As Boolean

    Dim upB As Boolean
    Dim downB As Boolean
    Dim leftB As Boolean
    Dim rightB As Boolean

    Public Shared Function Boom(Model As PictureBox, ColideWith As PictureBox)

        If Model.Bounds.IntersectsWith(ColideWith.Bounds) Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function Colision(Model As PictureBox)
        For Each PictureBox In Form1.Controls
            If PictureBox IsNot Model AndAlso Model.Bounds.IntersectsWith(PictureBox.Bounds) Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(Player1)
        Controls.Add(Player2)
    End Sub

    Private Sub KeyDown1(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Up
                upB = True
            Case Keys.Down
                downB = True
            Case Keys.Left
                leftB = True
            Case Keys.Right
                rightB = True
            Case Keys.W
                wB = True
            Case Keys.S
                sB = True
            Case Keys.A
                aB = True
            Case Keys.D
                dB = True
            Case Keys.Enter
                If Player1.Visible = True Then

                    Select Case PlayerGreen.GreenDirection
                        Case Direction.Up
                            If CanShootGreen = True Then
                                ReDim Preserve BulletsGreenUp(IntGreenUpCount)
                                Dim Bullet1 As New BulletGreen
                                Controls.Add(Bullet1)
                                BulletsGreenUp(IntGreenUpCount) = Bullet1
                                IntGreenUpCount += 1
                                Player1Shoot.Enabled = True
                                CanShootGreen = False
                            End If

                        Case Direction.Down
                            If CanShootGreen = True Then
                                ReDim Preserve BulletsGreenDown(IntGreenDownCount)
                                Dim Bullet1 As New BulletGreen
                                Controls.Add(Bullet1)
                                BulletsGreenDown(IntGreenDownCount) = Bullet1
                                IntGreenDownCount += 1
                                Player1Shoot.Enabled = True
                                CanShootGreen = False
                            End If

                        Case Direction.Left
                            If CanShootGreen = True Then
                                ReDim Preserve BulletsGreenLeft(IntGreenLeftCount)
                                Dim Bullet1 As New BulletGreen
                                Controls.Add(Bullet1)
                                BulletsGreenLeft(IntGreenLeftCount) = Bullet1
                                IntGreenLeftCount += 1
                                Player1Shoot.Enabled = True
                                CanShootGreen = False
                            End If

                        Case Direction.Right
                            If CanShootGreen = True Then
                                ReDim Preserve BulletsGreenRight(IntGreenRightCount)
                                Dim Bullet1 As New BulletGreen
                                Controls.Add(Bullet1)
                                BulletsGreenRight(IntGreenRightCount) = Bullet1
                                IntGreenRightCount += 1
                                Player1Shoot.Enabled = True
                                CanShootGreen = False
                            End If

                    End Select

                End If
            Case Keys.Space
                If Player2.Visible = True Then

                    Select Case PlayerWhite.WhiteDirection
                        Case Direction.Up
                            If CanShootWhite = True Then
                                ReDim Preserve BulletsWhiteUp(IntWhiteUpCount)
                                Dim Bullet2 As New BulletWhite
                                Controls.Add(Bullet2)
                                BulletsWhiteUp(IntWhiteUpCount) = Bullet2
                                IntWhiteUpCount += 1
                                Player2Shoot.Enabled = True
                                CanShootWhite = False
                            End If

                        Case Direction.Down
                            If CanShootWhite = True Then
                                ReDim Preserve BulletsWhiteDown(IntWhiteDownCount)
                                Dim Bullet2 As New BulletWhite
                                Controls.Add(Bullet2)
                                BulletsWhiteDown(IntWhiteDownCount) = Bullet2
                                IntWhiteDownCount += 1
                                Player2Shoot.Enabled = True
                                CanShootWhite = False
                            End If


                        Case Direction.Left
                            If CanShootWhite = True Then
                                ReDim Preserve BulletsWhiteLeft(IntWhiteLeftCount)
                                Dim Bullet2 As New BulletWhite
                                Controls.Add(Bullet2)
                                BulletsWhiteLeft(IntWhiteLeftCount) = Bullet2
                                IntWhiteLeftCount += 1
                                Player2Shoot.Enabled = True
                                CanShootWhite = False
                            End If


                        Case Direction.Right
                            If CanShootWhite = True Then
                                ReDim Preserve BulletsWhiteRight(IntWhiteRightCount)
                                Dim Bullet2 As New BulletWhite
                                Controls.Add(Bullet2)
                                BulletsWhiteRight(IntWhiteRightCount) = Bullet2
                                IntWhiteRightCount += 1
                                Player2Shoot.Enabled = True
                                CanShootWhite = False
                            End If

                    End Select
                End If
            Case Keys.Escape
                Application.Restart()
        End Select
    End Sub

    Private Sub KeyUp1(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Up
                upB = False
            Case Keys.Down
                downB = False
            Case Keys.Left
                leftB = False
            Case Keys.Right
                rightB = False
            Case Keys.W
                wB = False
            Case Keys.S
                sB = False
            Case Keys.A
                aB = False
            Case Keys.D
                dB = False
            Case Keys.Enter
                CanShootGreen = True
            Case Keys.Space
                CanShootWhite = True
        End Select
    End Sub

    Private Sub Player1Move_Tick(sender As Object, e As EventArgs) Handles Player1Move.Tick

        If upB = True Then
            Player1.MoveUp()
            Exit Sub
        End If

        If downB = True Then
            Player1.MoveDown()
            Exit Sub
        End If

        If leftB = True Then
            Player1.MoveLeft()
            Exit Sub
        End If

        If rightB = True Then
            Player1.MoveRight()
            Exit Sub
        End If

    End Sub

    Private Sub Player2Move_Tick(sender As Object, e As EventArgs) Handles Player2Move.Tick

        If wB = True Then
            Player2.MoveUp()
            Exit Sub
        End If

        If sB = True Then
            Player2.MoveDown()
            Exit Sub
        End If

        If aB = True Then
            Player2.MoveLeft()
            Exit Sub
        End If

        If dB = True Then
            Player2.MoveRight()
            Exit Sub
        End If

    End Sub

    Private Sub Player1Shoot_Tick(sender As Object, e As EventArgs) Handles Player1Shoot.Tick
        For x = 0 To BulletsGreenUp.Length - 1
            BulletsGreenUp(x).ShootUp()
        Next

        For x = 0 To BulletsGreenDown.Length - 1
            BulletsGreenDown(x).ShootDown()

        Next

        For x = 0 To BulletsGreenLeft.Length - 1
            BulletsGreenLeft(x).ShootLeft()

        Next

        For x = 0 To BulletsGreenRight.Length - 1
            BulletsGreenRight(x).ShootRight()

        Next
    End Sub

    Private Sub Player2Shoot_Tick(sender As Object, e As EventArgs) Handles Player2Shoot.Tick
        For x = 0 To BulletsWhiteUp.Length - 1
            BulletsWhiteUp(x).ShootUp()
        Next

        For x = 0 To BulletsWhiteDown.Length - 1
            BulletsWhiteDown(x).ShootDown()

        Next

        For x = 0 To BulletsWhiteLeft.Length - 1
            BulletsWhiteLeft(x).ShootLeft()

        Next

        For x = 0 To BulletsWhiteRight.Length - 1
            BulletsWhiteRight(x).ShootRight()

        Next
    End Sub
End Class
