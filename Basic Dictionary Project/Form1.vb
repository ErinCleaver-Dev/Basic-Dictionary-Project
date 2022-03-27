Public Class Form1
    Dim inventory As Inventory = New Inventory()
    Dim inventoryList As List(Of String)
    Dim id As Integer = 0
    Dim fileManagement As FileManagement = New FileManagement()



    Private Sub bntExit_Click(sender As Object, e As EventArgs) Handles bntExit.Click
        Me.Close()
    End Sub

    Private Sub bntAdd_Click(sender As Object, e As EventArgs) Handles bntAdd.Click

        If txtId.Text <> "" Or txtProductName.Text <> "" Then
            If Integer.TryParse(txtId.Text, id) Then
                inventory.AddItem(id, txtProductName.Text)
                inventoryList = inventory.GetList()
                updateListBox()
            Else
                MessageBox.Show("Please provided a Integer for the ID.")
            End If
        Else
            MessageBox.Show("Please provid a value in both the id field and the product name field")
        End If
    End Sub

    Private Sub updateListBox()
        inventoryList = inventory.GetList()
        lstInventory.Items.Clear()
        If (inventoryList.Count > 0) Then
            lstInventory.Items.AddRange(inventoryList.ToArray())
        End If
    End Sub


    Private Sub bntRemove_Click(sender As Object, e As EventArgs) Handles bntRemove.Click

        If txtId.Text <> "" Then
            If Integer.TryParse(txtId.Text, id) Then
                inventory.RemoveItem(id)
                updateListBox()
            Else
                MessageBox.Show("Please provided a Integer for the ID.")
            End If

        Else
            MessageBox.Show("Please provided a Integer for the ID.")

        End If
    End Sub

    Private Sub bntCheck_Click(sender As Object, e As EventArgs) Handles bntCheck.Click
        If txtId.Text <> "" Or Integer.TryParse(txtId.Text, id) Then
            inventory.SearchByID(id)
        Else
            MessageBox.Show("Please provided a Integer for the ID or a product name.")
        End If

    End Sub

    Private Sub bntCreateFile_Click(sender As Object, e As EventArgs) Handles bntCreateFile.Click
        fileManagement.createFile(inventory)
    End Sub

    Private Sub bntOpenFile_Click(sender As Object, e As EventArgs) Handles bntOpenFile.Click
        inventory = fileManagement.OpenFile()
        updateListBox()
    End Sub
End Class
