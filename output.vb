Public Class output
    Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
        lblStrAd.Text = address.strStAdd
        lblCitDis.Text = address.strCity + "," + address.strDistrict
        lblTotal.Text = "$" + pizza.total.ToString()
        txtItemName.Text = String.Join(vbCrLf, pizza.combinedArray)
    End Sub
    'make textboxs accept numbers only
    Private Sub txtCvv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCvv.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCardNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNum.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    'card number
    Private Sub txtCardNum2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNum2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCardNum3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNum3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCardNum4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardNum4.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    'enable card details if user chooses to pay with card
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbCard.CheckedChanged
        panCard.Enabled = True
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        panCard.Enabled = False
    End Sub

    Private Sub btnPlaceOrd_Click(sender As Object, e As EventArgs) Handles btnPlaceOrd.Click
        If String.IsNullOrEmpty(txtFirstName.Text.Trim) Then
            errFName.SetError(txtFirstName, "This field is required")
        Else
            errFName.SetError(txtFirstName, String.Empty)
        End If

        If String.IsNullOrEmpty(txtPhNum.Text.Trim) Then
            errPhNum.SetError(txtPhNum, "This field is required")
        Else
            errPhNum.SetError(txtPhNum, String.Empty)
        End If

        If panCard.Enabled = True Then
            If String.IsNullOrEmpty(txtCardName.Text.Trim) Then
                errFName.SetError(txtCardName, "This field is required")
            Else
                errFName.SetError(txtCardName, String.Empty)
            End If

            If String.IsNullOrEmpty(txtCardNum2.Text.Trim) Then
                errCardNum.SetError(txtCardNum4, "This field is required")
            Else
                errCardNum.SetError(txtCardNum4, String.Empty)
            End If
            If String.IsNullOrEmpty(txtCardNum3.Text.Trim) Then
                errCardNum.SetError(txtCardNum4, "This field is required")
            Else
                errCardNum.SetError(txtCardNum4, String.Empty)
            End If
            If String.IsNullOrEmpty(txtCardNum4.Text.Trim) Then
                errCardNum.SetError(txtCardNum4, "This field is required")
            Else
                errCardNum.SetError(txtCardNum4, String.Empty)
            End If
            If String.IsNullOrEmpty(txtExp.Text.Trim) Then
                errExp.SetError(txtExp, "This field is required")
            Else
                errExp.SetError(txtExp, String.Empty)
            End If
            If String.IsNullOrEmpty(txtCvv.Text.Trim) Then
                errCvv.SetError(txtCvv, "This field is required")
            Else
                errCvv.SetError(txtExp, String.Empty)
            End If
        End If

        If txtFirstName.Text <> "" And txtPhNum.Text <> "" Then
            thank.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class