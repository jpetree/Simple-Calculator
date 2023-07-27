Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dFirst As Decimal
        Dim dSecond As Decimal
        Dim dResult As Decimal
        'Gives dimensions for variables


        If Decimal.TryParse(txtFirst.Text, dFirst) AndAlso Decimal.TryParse(txtSecond.Text, dSecond) Then
            'If statement forces user to enter numbers for the program to work
            'TryParse converts string to decimal

            If cmb1.SelectedItem IsNot Nothing Then
                'forces user to enter operator


                If cmb1.SelectedItem.ToString() = "+" Then
                    dResult = dFirst + dSecond
                ElseIf cmb1.SelectedItem.ToString() = "-" Then
                    dResult = dFirst - dSecond
                ElseIf cmb1.SelectedItem.ToString() = "*" Then
                    dResult = dFirst * dSecond
                ElseIf cmb1.SelectedItem.ToString() = "/" Then
                    'Computes the appropriate formula



                    If dSecond <> 0 Then
                        dResult = dFirst / dSecond
                    Else
                        MsgBox("Cannot divide by zero.")
                        Return
                    End If
                    'Verifies that the user does not try to divide by 0


                Else
                    MsgBox("An error has occured. Please try again.")
                    Return
                End If


                lblResult.Text = dResult.ToString("F2")
                'Prints the result to the application



            Else
                MsgBox("Please select an operator.")
            End If
        Else
            MsgBox("Please enter valid number values for the equation.")
        End If
    End Sub
End Class
