'Program name: Double A Delivery
'Members: Anthony Cob, Adimir Gongora
'Course: CS206 Programming II
Public Class pizza
    'variables
    Public rbPizzaType As String
    Public chbSides As String
    Public total As Double
    Public combinedArray As String()
    Private Sub pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = LogIn.strUsername
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        'code for pizza type
        If chClasPep.Checked Then
            total += upClas.Value * 14
        End If
        If chThiCru.Checked Then
            total += upThin.Value * 17
        End If
        If chStufCPep.Checked Then
            total += upStu.Value * 24
        End If
        If chHulaHa.Checked Then
            total += upHul.Value * 20
        End If
        If chVeggie.Checked Then
            total += upVeg.Value * 24
        End If
        If chMeat.Checked Then
            total += upMeat.Value * 22
        End If
        'code for sides check boxes
        If chBbq.Checked Then
            total += 10
        End If

        If chBuffalo.Checked Then
            total += 10
        End If

        If chRanch.Checked Then
            total += 3
        End If

        If chBuffRan.Checked Then
            total += 3
        End If
        If chBreSti.Checked Then
            total += 7
        End If

        If chBrow.Checked Then
            total += 5
        End If

        'add to array all values of checked check boxes
        Dim checkBoxes As CheckBox() = {chClasPep, chThiCru, chStufCPep, chHulaHa, chVeggie, chMeat} 'array of checkboxes
        Dim checkedBoxes As New List(Of CheckBox) 'list to store checked checkboxes

        For Each cb As CheckBox In checkBoxes
            If cb.Checked Then
                checkedBoxes.Add(cb) 'add the checked checkbox to the list

            End If
        Next

        Dim checkedValues As String() = checkedBoxes.Select(Function(x) x.Text).ToArray() 'convert the list of checked checkboxes to an array of strings


        Dim SidescheckBoxes As CheckBox() = {chBbq, chBuffalo, chRanch, chBuffRan, chBreSti, chBrow} 'array of checkboxes
        Dim SidescheckedBoxes As New List(Of CheckBox) 'list to store checked checkboxes
        For Each cb As CheckBox In SidescheckBoxes
            If cb.Checked Then
                SidescheckedBoxes.Add(cb) 'add the checked checkbox to the list
            End If
        Next

        Dim sidescheckedValues As String() = SidescheckedBoxes.Select(Function(x) x.Text).ToArray()

        combinedArray = checkedValues.Concat(sidescheckedValues).ToArray()

        Dim noCheckBoxesChecked As Boolean = True

        For Each checkBox As CheckBox In grpTypePizza.Controls.OfType(Of CheckBox)()
            If checkBox.Checked Then
                noCheckBoxesChecked = False
                Exit For
            End If
        Next

        If noCheckBoxesChecked Then
            MessageBox.Show("You need to choose something before proceeding!")
        Else
            output.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        address.Show()
    End Sub

    Private Sub chClasPep_CheckedChanged(sender As Object, e As EventArgs) Handles chClasPep.CheckedChanged
        If upClas.Value = 0 Then
            upClas.Value = 1
        Else
            upClas.Value = 0
        End If
    End Sub

    Private Sub chThiCru_CheckedChanged(sender As Object, e As EventArgs) Handles chThiCru.CheckedChanged
        If upThin.Value = 0 Then
            upThin.Value = 1
        Else
            upThin.Value = 0
        End If
    End Sub

    Private Sub chStufCPep_CheckedChanged(sender As Object, e As EventArgs) Handles chStufCPep.CheckedChanged
        If upStu.Value = 0 Then
            upStu.Value = 1
        Else
            upStu.Value = 0
        End If
    End Sub

    Private Sub chHulaHa_CheckedChanged(sender As Object, e As EventArgs) Handles chHulaHa.CheckedChanged
        If upHul.Value = 0 Then
            upHul.Value = 1
        Else
            upHul.Value = 0
        End If
    End Sub

    Private Sub chVeggie_CheckedChanged(sender As Object, e As EventArgs) Handles chVeggie.CheckedChanged
        If upVeg.Value = 0 Then
            upVeg.Value = 1
        Else
            upVeg.Value = 0
        End If
    End Sub

    Private Sub chMeat_CheckedChanged(sender As Object, e As EventArgs) Handles chMeat.CheckedChanged
        If upMeat.Value = 0 Then
            upMeat.Value = 1
        Else
            upMeat.Value = 0
        End If
    End Sub

    Private Sub chBbq_CheckedChanged(sender As Object, e As EventArgs) Handles chBbq.CheckedChanged
        If upBbq.Value = 0 Then
            upBbq.Value = 1
        Else
            upBbq.Value = 0
        End If
    End Sub

    Private Sub chBuffalo_CheckedChanged(sender As Object, e As EventArgs) Handles chBuffalo.CheckedChanged
        If upBuff.Value = 0 Then
            upBuff.Value = 1
        Else
            upBuff.Value = 0
        End If
    End Sub

    Private Sub chRanch_CheckedChanged(sender As Object, e As EventArgs) Handles chRanch.CheckedChanged
        If upRan.Value = 0 Then
            upRan.Value = 1
        Else
            upRan.Value = 0
        End If
    End Sub

    Private Sub chBuffRan_CheckedChanged(sender As Object, e As EventArgs) Handles chBuffRan.CheckedChanged
        If upBufRa.Value = 0 Then
            upBufRa.Value = 1
        Else
            upBufRa.Value = 0
        End If
    End Sub

    Private Sub chBreSti_CheckedChanged(sender As Object, e As EventArgs) Handles chBreSti.CheckedChanged
        If upBrea.Value = 0 Then
            upBrea.Value = 1
        Else
            upBrea.Value = 0
        End If
    End Sub

    Private Sub chBrow_CheckedChanged(sender As Object, e As EventArgs) Handles chBrow.CheckedChanged
        If upBrown.Value = 0 Then
            upBrown.Value = 1
        Else
            upBrown.Value = 0
        End If
    End Sub
End Class