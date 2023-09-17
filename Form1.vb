Imports System.Collections.Generic



Public Class BestsellersManager



    ' Use a List collection to store the bestsellers

    Private bestsellers As New List(Of String)



    Private Sub BestsellersManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initial set of bestsellers

        bestsellers.AddRange(New String() {"The Alchemist", "The Great Gatsby", "To Kill a Mockingbird"})

        UpdateBestsellersDisplay()

    End Sub



    Private Sub UpdateBestsellersDisplay()

        lstBestsellers.Items.Clear()

        For Each title In bestsellers

            lstBestsellers.Items.Add(title)

        Next

    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' TODO: Add the new bestseller from txtNewBestseller to the bestsellers List

        '       and update the display.

    End Sub



    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        ' TODO: Remove the selected bestseller from the bestsellers List

        '       and update the display.

    End Sub



End Class
