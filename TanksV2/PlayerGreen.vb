Public Class PlayerGreen
    Inherits PictureBox

    Public Shared GreenDirection As Integer = Form1.Direction.Up

    Private Texture As Boolean = True

    Public Sub New()
        With Me
            .Size = New Size(32, 32)
            .Location = New Point(290, 400)
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.PlayerTankUp1
            .BackColor = Color.Transparent
            .Visible = True
        End With
    End Sub

    Public Sub MoveUp()
        Me.Top -= 3
        If Form1.Colision(Me) Then
            Me.Top += 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.PlayerTankUp2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.PlayerTankUp1
            Texture = True
        End If

        GreenDirection = Form1.Direction.Up
    End Sub

    Public Sub MoveDown()
        Me.Top += 3

        If Form1.Colision(Me) Then
            Me.Top -= 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.PlayerTankDown2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.PlayerTankDown1
            Texture = True
        End If

        GreenDirection = Form1.Direction.Down
    End Sub

    Public Sub MoveLeft()
        Me.Left -= 3

        If Form1.Colision(Me) Then
            Me.Left += 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.PlayerTankLeft2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.PlayerTankLeft1
            Texture = True
        End If

        GreenDirection = Form1.Direction.Left
    End Sub

    Public Sub MoveRight()
        Me.Left += 3

        If Form1.Colision(Me) Then
            Me.Left -= 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.PlayerTankRight2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.PlayerTankRight1
            Texture = True
        End If

        GreenDirection = Form1.Direction.Right
    End Sub
End Class

