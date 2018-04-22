Public Class PlayerWhite
    Inherits PictureBox

    Public Shared WhiteDirection As Integer = Form1.Direction.Down

    Private Texture As Boolean = True

    Public Sub New()
        With Me
            .Size = New Size(32, 32)
            .Location = New Point(290, 20)
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.EnemyTankDown1
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
            Me.BackgroundImage = My.Resources.EnemyTankUp2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.EnemyTankUp1
            Texture = True
        End If

        WhiteDirection = Form1.Direction.Up
    End Sub

    Public Sub MoveDown()
        Me.Top += 3

        If Form1.Colision(Me) Then
            Me.Top -= 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.EnemyTankDown2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.EnemyTankDown1
            Texture = True
        End If

        WhiteDirection = Form1.Direction.Down
    End Sub

    Public Sub MoveLeft()
        Me.Left -= 3

        If Form1.Colision(Me) Then
            Me.Left += 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.EnemyTankLeft2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.EnemyTankLeft1
            Texture = True
        End If

        WhiteDirection = Form1.Direction.Left
    End Sub

    Public Sub MoveRight()
        Me.Left += 3

        If Form1.Colision(Me) Then
            Me.Left -= 3
        End If

        If Texture = True Then
            Me.BackgroundImage = My.Resources.EnemyTankRight2
            Texture = False
        Else
            Me.BackgroundImage = My.Resources.EnemyTankRight1
            Texture = True
        End If

        WhiteDirection = Form1.Direction.Right
    End Sub
End Class
