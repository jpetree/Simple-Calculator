Imports System.Net.Security

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim iFirst As Integer
        Dim iSecond As Integer
        Dim iResult As Integer

        iFirst = CInt(txtFirst.Text)
        iSecond = CInt(txtSecond.Text)

        If listOp.SelectedItem = "+" Then
            iResult = iFirst + iSecond
        ElseIf listOp.SelectedItem = "-" Then
            iResult = iFirst - iSecond
        ElseIf listOp.SelectedItem = "*" Then
            iResult = iFirst * iSecond
        ElseIf listOp.SelectedItem = "/" Then
            iResult = iFirst / iSecond
        End If

        MsgBox(iFirst & listOp.SelectedItem & iSecond & " is equal to: " & iResult)

    End Sub
End Class