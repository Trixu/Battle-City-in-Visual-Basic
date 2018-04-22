Public Class BulletWhite
    Inherits PictureBox

    Private Function BeyondMap()
        If Me.Location.X > 600 AndAlso Me.Location.Y > 800 Then
            Me.Dispose()
        End If
    End Function

    Public Sub New()
        If PlayerWhite.WhiteDirection = Form1.Direction.Up Then
            With Me
                .Size = New Size(6, 8)
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.MissleUp
                .Location = New Point(Form1.Player2.Location.X + 13, Form1.Player2.Location.Y - 14)
                .BackColor = Color.Transparent
            End With
        End If

        If PlayerWhite.WhiteDirection = Form1.Direction.Down Then
            With Me
                .Size = New Size(6, 8)
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.MissleDown
                .Location = New Point(Form1.Player2.Location.X + 13, Form1.Player2.Location.Y + 35)
                .BackColor = Color.Transparent
            End With
        End If

        If PlayerWhite.WhiteDirection = Form1.Direction.Left Then
            With Me
                .Size = New Size(8, 6)
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.MissleLeft
                .Location = New Point(Form1.Player2.Location.X - 12, Form1.Player2.Location.Y + 13)
                .BackColor = Color.Transparent
            End With
        End If

        If PlayerWhite.WhiteDirection = Form1.Direction.Right Then
            With Me
                .Size = New Size(8, 6)
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.MissleRight
                .Location = New Point(Form1.Player2.Location.X + 36, Form1.Player2.Location.Y + 13)
                .BackColor = Color.Transparent
            End With
        End If

    End Sub

    Public Sub ShootUp()
        If Form1.Colision(Me) Then
            Me.Dispose()
            Exit Sub
        End If

        Me.Top -= 4

        If Form1.Boom(Me, Form1.Player1) Then
            Form1.Player1.Dispose()
            Controls.Remove(Form1.Player1)
            Me.Dispose()
        End If

        BeyondMap()

    End Sub

    Public Sub ShootDown()
        If Form1.Colision(Me) Then
            Me.Dispose()
            Exit Sub
        End If

        Me.Top += 4

        If Form1.Boom(Me, Form1.Player1) Then
            Form1.Player1.Dispose()
            Controls.Remove(Form1.Player1)
            Me.Dispose()
        End If

        BeyondMap()

    End Sub

    Public Sub ShootLeft()
        If Form1.Colision(Me) Then
            Me.Dispose()
            Exit Sub
        End If

        Me.Left -= 4

        If Form1.Boom(Me, Form1.Player1) Then
            Form1.Player1.Dispose()
            Controls.Remove(Form1.Player1)
            Me.Dispose()
        End If

        BeyondMap()

    End Sub

    Public Sub ShootRight()
        If Form1.Colision(Me) Then
            Me.Dispose()
            Exit Sub
        End If

        Me.Left += 4

        If Form1.Boom(Me, Form1.Player1) Then
            Form1.Player1.Dispose()
            Controls.Remove(Form1.Player1)
            Me.Dispose()
        End If

        BeyondMap()

    End Sub


End Class
