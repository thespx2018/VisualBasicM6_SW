<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Box1 = New System.Windows.Forms.TextBox()
        Me.BtnShow1 = New System.Windows.Forms.Button()
        Me.BthClose = New System.Windows.Forms.Button()
        Me.GradeShow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH Sarabun New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "กรุณาคะแนน"
        '
        'Box1
        '
        Me.Box1.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Box1.Location = New System.Drawing.Point(168, 31)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(180, 35)
        Me.Box1.TabIndex = 1
        '
        'BtnShow1
        '
        Me.BtnShow1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BtnShow1.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnShow1.Location = New System.Drawing.Point(34, 91)
        Me.BtnShow1.Name = "BtnShow1"
        Me.BtnShow1.Size = New System.Drawing.Size(102, 56)
        Me.BtnShow1.TabIndex = 2
        Me.BtnShow1.Text = "แสดงผล"
        Me.BtnShow1.UseVisualStyleBackColor = False
        '
        'BthClose
        '
        Me.BthClose.BackColor = System.Drawing.Color.LightCoral
        Me.BthClose.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BthClose.Location = New System.Drawing.Point(168, 91)
        Me.BthClose.Name = "BthClose"
        Me.BthClose.Size = New System.Drawing.Size(102, 56)
        Me.BthClose.TabIndex = 3
        Me.BthClose.Text = "ปิดโปรแกรม"
        Me.BthClose.UseVisualStyleBackColor = False
        '
        'GradeShow
        '
        Me.GradeShow.AutoSize = True
        Me.GradeShow.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GradeShow.Location = New System.Drawing.Point(388, 137)
        Me.GradeShow.Name = "GradeShow"
        Me.GradeShow.Size = New System.Drawing.Size(0, 28)
        Me.GradeShow.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 185)
        Me.Controls.Add(Me.GradeShow)
        Me.Controls.Add(Me.BthClose)
        Me.Controls.Add(Me.BtnShow1)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Box1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnShow1 As System.Windows.Forms.Button
    Friend WithEvents BthClose As System.Windows.Forms.Button
    Friend WithEvents GradeShow As System.Windows.Forms.Label

End Class
