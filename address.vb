'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class address
    'varibles (Address)
    Public strType As String
    Public strStAdd As String
    Public strAptNum As String
    Public strCity As String
    Public strDistrict As String
    Public strZip As String

    Private Sub address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub

    'open form depending on user choice
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'check if *required fields are empty
        If String.IsNullOrEmpty(txtStrAdd.Text.Trim) Then
            errStAdd.SetError(txtStrAdd, "This field is required")
        Else 'if empty prompt error message
            errStAdd.SetError(txtStrAdd, String.Empty)
            strStAdd = txtStrAdd.Text
        End If
        If String.IsNullOrEmpty(txtCity.Text.Trim) Then
            errCity.SetError(txtCity, "This field is required")
        Else
            errCity.SetError(txtCity, String.Empty)
            strCity = txtCity.Text
        End If
        If String.IsNullOrEmpty(txtDistrict.Text.Trim) Then
            errDistrict.SetError(txtDistrict, "This field is required")
        Else
            errDistrict.SetError(txtDistrict, String.Empty)
            strDistrict = txtDistrict.Text
        End If
        If txtStrAdd.Text <> "" And txtCity.Text <> "" And txtDistrict.Text <> "" Then
            Me.Hide()
            pizza.Show()
        End If
        strType = txtAddType.Text
        strAptNum = txtApt.Text
        strDistrict = txtDistrict.Text
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        main.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddType.Text = ""
        txtApt.Text = ""
        txtCity.Text = ""
        txtDistrict.Text = ""
        txtStrAdd.Text = ""
    End Sub
End Class