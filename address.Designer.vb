<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class address
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(address))
        Me.txtDistrict = New System.Windows.Forms.ComboBox()
        Me.txtAddType = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApt = New System.Windows.Forms.TextBox()
        Me.txtStrAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.errStAdd = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errCity = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errDistrict = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errZip = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDistrict
        '
        Me.txtDistrict.AutoCompleteCustomSource.AddRange(New String() {"Corozal"})
        Me.txtDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDistrict.BackColor = System.Drawing.Color.White
        Me.txtDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDistrict.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDistrict.FormattingEnabled = True
        Me.txtDistrict.Items.AddRange(New Object() {"Belize", "Cayo", "Corozal", "Orange Walk", "Stann Creek", "Toledo"})
        Me.txtDistrict.Location = New System.Drawing.Point(459, 264)
        Me.txtDistrict.MaxLength = 11
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(172, 28)
        Me.txtDistrict.Sorted = True
        Me.txtDistrict.TabIndex = 3
        '
        'txtAddType
        '
        Me.txtAddType.BackColor = System.Drawing.Color.White
        Me.txtAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtAddType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddType.FormattingEnabled = True
        Me.txtAddType.Items.AddRange(New Object() {"House", "Apartment", "Business", "Campus/Base", "Hotel", "Other"})
        Me.txtAddType.Location = New System.Drawing.Point(94, 262)
        Me.txtAddType.Name = "txtAddType"
        Me.txtAddType.Size = New System.Drawing.Size(270, 28)
        Me.txtAddType.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(459, 387)
        Me.txtCity.MaxLength = 25
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(225, 19)
        Me.txtCity.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "*District:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(452, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 37)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "*City/Town/Village:"
        '
        'txtApt
        '
        Me.txtApt.BackColor = System.Drawing.Color.White
        Me.txtApt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApt.Location = New System.Drawing.Point(94, 425)
        Me.txtApt.MaxLength = 9
        Me.txtApt.Name = "txtApt"
        Me.txtApt.Size = New System.Drawing.Size(122, 19)
        Me.txtApt.TabIndex = 2
        '
        'txtStrAdd
        '
        Me.txtStrAdd.BackColor = System.Drawing.Color.White
        Me.txtStrAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStrAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStrAdd.Location = New System.Drawing.Point(94, 340)
        Me.txtStrAdd.MaxLength = 30
        Me.txtStrAdd.Name = "txtStrAdd"
        Me.txtStrAdd.Size = New System.Drawing.Size(270, 19)
        Me.txtStrAdd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Suit/Apt #:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*Street Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Address Type:"
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.BackColor = System.Drawing.Color.Black
        Me.txtUser.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(58, 22)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(63, 40)
        Me.txtUser.TabIndex = 0
        Me.txtUser.Text = "User"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 72)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.App.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Black
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.App.My.Resources.Resources.twitter
        Me.PictureBox7.Location = New System.Drawing.Point(760, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.App.My.Resources.Resources.instagram
        Me.PictureBox3.Location = New System.Drawing.Point(696, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.App.My.Resources.Resources.facebook
        Me.PictureBox2.Location = New System.Drawing.Point(622, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(94, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 1)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(94, 365)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 1)
        Me.Panel3.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(94, 450)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(122, 1)
        Me.Panel4.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(459, 291)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(172, 1)
        Me.Panel6.TabIndex = 12
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(459, 412)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(225, 1)
        Me.Panel7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 37)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "*City/Town/Village:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 37)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Suit/Apt #:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(452, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 37)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "*District:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(87, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 37)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "*Street Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(87, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 37)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Address Type:"
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(668, 547)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 57)
        Me.btnNext.TabIndex = 6
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(46, 547)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 57)
        Me.btnBack.TabIndex = 19
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'errStAdd
        '
        Me.errStAdd.ContainerControl = Me
        '
        'errCity
        '
        Me.errCity.ContainerControl = Me
        '
        'errDistrict
        '
        Me.errDistrict.ContainerControl = Me
        '
        'errZip
        '
        Me.errZip.ContainerControl = Me
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.App.My.Resources.Resources.address
        Me.PictureBox4.Location = New System.Drawing.Point(234, 44)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(330, 133)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Dubai", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(340, 547)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 57)
        Me.btnClear.TabIndex = 19
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 616)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDistrict)
        Me.Controls.Add(Me.txtAddType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStrAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApt)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "address"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Address"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDistrict As ComboBox
    Friend WithEvents txtAddType As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApt As TextBox
    Friend WithEvents txtStrAdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtUser As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents errStAdd As ErrorProvider
    Friend WithEvents errCity As ErrorProvider
    Friend WithEvents errDistrict As ErrorProvider
    Friend WithEvents errZip As ErrorProvider
    Friend WithEvents btnClear As Button
End Class
