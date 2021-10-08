<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MyPictureBox1 = New Homework2._2_VB.NET.MyPictureBox(Me.components)
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyPictureBox1
        '
        Me.MyPictureBox1.Image = Global.Homework2._2_VB.NET.My.Resources.Resources.cat
        Me.MyPictureBox1.Location = New System.Drawing.Point(248, 68)
        Me.MyPictureBox1.Name = "MyPictureBox1"
        Me.MyPictureBox1.Size = New System.Drawing.Size(258, 262)
        Me.MyPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MyPictureBox1.TabIndex = 0
        Me.MyPictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyPictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MyPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyPictureBox1 As MyPictureBox
End Class
