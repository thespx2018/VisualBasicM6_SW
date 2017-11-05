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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fristname = New System.Windows.Forms.Label()
        Me.BoxFName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lastname = New System.Windows.Forms.Label()
        Me.BoxLName = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.School = New System.Windows.Forms.Label()
        Me.Phonenum = New System.Windows.Forms.Label()
        Me.SClass = New System.Windows.Forms.Label()
        Me.BoxAddress = New System.Windows.Forms.RichTextBox()
        Me.BoxSchool = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.BoxSclass = New System.Windows.Forms.TextBox()
        Me.BoxPhonenum = New System.Windows.Forms.TextBox()
        Me.Boxemail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH Sarabun New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(191, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ประวัติส่วนตัว"
        '
        'Fristname
        '
        Me.Fristname.AutoSize = True
        Me.Fristname.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Fristname.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Fristname.Location = New System.Drawing.Point(77, 74)
        Me.Fristname.Name = "Fristname"
        Me.Fristname.Size = New System.Drawing.Size(31, 28)
        Me.Fristname.TabIndex = 1
        Me.Fristname.Text = "ชื่อ"
        '
        'BoxFName
        '
        Me.BoxFName.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxFName.Location = New System.Drawing.Point(229, 71)
        Me.BoxFName.Name = "BoxFName"
        Me.BoxFName.Size = New System.Drawing.Size(251, 35)
        Me.BoxFName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "แสดงผล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lastname
        '
        Me.Lastname.AutoSize = True
        Me.Lastname.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lastname.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Lastname.Location = New System.Drawing.Point(77, 120)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(65, 28)
        Me.Lastname.TabIndex = 5
        Me.Lastname.Text = "นามสกุล"
        '
        'BoxLName
        '
        Me.BoxLName.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxLName.Location = New System.Drawing.Point(229, 120)
        Me.BoxLName.Name = "BoxLName"
        Me.BoxLName.Size = New System.Drawing.Size(251, 35)
        Me.BoxLName.TabIndex = 6
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Address.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Address.Location = New System.Drawing.Point(77, 171)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(40, 28)
        Me.Address.TabIndex = 7
        Me.Address.Text = "ที่อยู่"
        '
        'School
        '
        Me.School.AutoSize = True
        Me.School.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.School.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.School.Location = New System.Drawing.Point(77, 284)
        Me.School.Name = "School"
        Me.School.Size = New System.Drawing.Size(68, 28)
        Me.School.TabIndex = 8
        Me.School.Text = "โรงเรียน"
        '
        'Phonenum
        '
        Me.Phonenum.AutoSize = True
        Me.Phonenum.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Phonenum.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Phonenum.Location = New System.Drawing.Point(77, 371)
        Me.Phonenum.Name = "Phonenum"
        Me.Phonenum.Size = New System.Drawing.Size(71, 28)
        Me.Phonenum.TabIndex = 9
        Me.Phonenum.Text = "เบอร์โทร"
        '
        'SClass
        '
        Me.SClass.AutoSize = True
        Me.SClass.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SClass.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.SClass.Location = New System.Drawing.Point(76, 329)
        Me.SClass.Name = "SClass"
        Me.SClass.Size = New System.Drawing.Size(65, 28)
        Me.SClass.TabIndex = 10
        Me.SClass.Text = "ชั้นเรียน"
        '
        'BoxAddress
        '
        Me.BoxAddress.Location = New System.Drawing.Point(229, 171)
        Me.BoxAddress.Name = "BoxAddress"
        Me.BoxAddress.Size = New System.Drawing.Size(251, 73)
        Me.BoxAddress.TabIndex = 11
        Me.BoxAddress.Text = ""
        '
        'BoxSchool
        '
        Me.BoxSchool.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSchool.Location = New System.Drawing.Point(229, 281)
        Me.BoxSchool.Name = "BoxSchool"
        Me.BoxSchool.Size = New System.Drawing.Size(251, 35)
        Me.BoxSchool.TabIndex = 12
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Email.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Email.Location = New System.Drawing.Point(77, 412)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(54, 28)
        Me.Email.TabIndex = 13
        Me.Email.Text = "E-Mail"
        '
        'BoxSclass
        '
        Me.BoxSclass.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxSclass.Location = New System.Drawing.Point(229, 322)
        Me.BoxSclass.Name = "BoxSclass"
        Me.BoxSclass.Size = New System.Drawing.Size(251, 35)
        Me.BoxSclass.TabIndex = 14
        '
        'BoxPhonenum
        '
        Me.BoxPhonenum.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxPhonenum.Location = New System.Drawing.Point(229, 363)
        Me.BoxPhonenum.Name = "BoxPhonenum"
        Me.BoxPhonenum.Size = New System.Drawing.Size(251, 35)
        Me.BoxPhonenum.TabIndex = 15
        '
        'Boxemail
        '
        Me.Boxemail.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boxemail.Location = New System.Drawing.Point(229, 409)
        Me.Boxemail.Name = "Boxemail"
        Me.Boxemail.Size = New System.Drawing.Size(251, 35)
        Me.Boxemail.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 623)
        Me.Controls.Add(Me.Boxemail)
        Me.Controls.Add(Me.BoxPhonenum)
        Me.Controls.Add(Me.BoxSclass)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.BoxSchool)
        Me.Controls.Add(Me.BoxAddress)
        Me.Controls.Add(Me.SClass)
        Me.Controls.Add(Me.Phonenum)
        Me.Controls.Add(Me.School)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.BoxLName)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BoxFName)
        Me.Controls.Add(Me.Fristname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("TH Sarabun New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BoxFName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents Fristname As System.Windows.Forms.Label
    Public WithEvents Lastname As System.Windows.Forms.Label
    Friend WithEvents BoxLName As System.Windows.Forms.TextBox
    Public WithEvents Address As System.Windows.Forms.Label
    Public WithEvents School As System.Windows.Forms.Label
    Public WithEvents Phonenum As System.Windows.Forms.Label
    Public WithEvents SClass As System.Windows.Forms.Label
    Friend WithEvents BoxAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents BoxSchool As System.Windows.Forms.TextBox
    Public WithEvents Email As System.Windows.Forms.Label
    Friend WithEvents BoxSclass As System.Windows.Forms.TextBox
    Friend WithEvents BoxPhonenum As System.Windows.Forms.TextBox
    Friend WithEvents Boxemail As System.Windows.Forms.TextBox

End Class
