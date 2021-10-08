Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System

Class MyPictureBox
        Inherits PictureBox

        Private point As Point
        Private MouseIsInLeftEdge As Boolean
        Private MouseIsInRightEdge As Boolean
        Private MouseIsInTopEdge As Boolean
        Private MouseIsInBottomEdge As Boolean
        Private currentHeight As Integer
        Private currentWidth As Integer

        Public Sub New(ByVal container As IContainer)
            container.Add(Me)
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            point = e.Location
            MouseIsInLeftEdge = Math.Abs(point.X) <= 10
            MouseIsInRightEdge = Math.Abs(point.X - Me.Width) <= 10
            MouseIsInTopEdge = Math.Abs(point.Y) <= 10
            MouseIsInBottomEdge = Math.Abs(point.Y - Me.Height) <= 10
            currentHeight = Me.Height
            currentWidth = Me.Width
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then

                If MouseIsInLeftEdge Then

                    If MouseIsInTopEdge Then
                        Me.Width -= (e.X - point.X)
                        Me.Left += (e.X - point.X)
                        Me.Height -= (e.Y - point.Y)
                        Me.Top += (e.Y - point.Y)
                    ElseIf MouseIsInBottomEdge Then
                        Me.Width -= (e.X - point.X)
                        Me.Left += (e.X - point.X)
                        Me.Height = (e.Y - point.Y) + Me.currentHeight
                    Else
                        Me.Width -= (e.X - point.X)
                        Me.Left += (e.X - point.X)
                    End If
                ElseIf MouseIsInRightEdge Then

                    If MouseIsInTopEdge Then
                        Me.Width = (e.X - point.X) + Me.currentWidth
                        Me.Height -= (e.Y - point.Y)
                        Me.Top += (e.Y - point.Y)
                    ElseIf MouseIsInBottomEdge Then
                        Me.Width = (e.X - point.X) + Me.currentWidth
                        Me.Height = (e.Y - point.Y) + Me.currentHeight
                    Else
                        Me.Width = (e.X - point.X) + Me.currentWidth
                    End If
                ElseIf MouseIsInTopEdge Then
                    Me.Height -= (e.Y - point.Y)
                    Me.Top += (e.Y - point.Y)
                ElseIf MouseIsInBottomEdge Then
                    Me.Height = (e.Y - point.Y) + Me.currentHeight
                Else
                    Me.Left += e.X - point.X
                    Me.Top += e.Y - point.Y
                End If
            End If

            MyBase.OnMouseMove(e)
        End Sub
    End Class
