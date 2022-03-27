<Serializable>
Public Class Inventory
    Private inventory As New Dictionary(Of Integer, String)

    Public Sub AddItem(id As Integer, name As String)
        Try
            inventory.Add(id, name)
        Catch ex As Exception
            MessageBox.Show("Failed to add item. Error Message: " & ex.Message)
        End Try
    End Sub
    Public Sub RemoveItem(id As Integer)
        Try
            inventory.Remove(id)
        Catch ex As Exception
            MessageBox.Show("Failed to remove item.  Error Message: " & ex.Message)
        End Try
    End Sub
    Public Function SearchByID(id As Integer)
        Try
            If inventory.ContainsKey(id) Then
                Dim result As String = ""
                If inventory.TryGetValue(id, result) Then
                    MessageBox.Show("We have an id of " & id & " for the item of " & result)
                End If
                Return True
            Else
                MessageBox.Show("Failed to find item by id.")
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to find item by id. Error Message " & ex.Message)
        End Try
        Return False
    End Function

    Function GetList()
        Dim inventoryList As List(Of String) = New List(Of String)
        Dim value As String = ""
        Dim id As String = ""

        Try
            Dim temp As String = ""
            For Each key In inventory.Keys
                id = key.ToString()
                value = inventory(key).ToString()
                inventoryList.Add("ID: " & id & " Product: " & value)
            Next

        Catch ex As Exception
            MessageBox.Show("Failed to add to list. Error message: ", ex.Message)
        End Try
        Return inventoryList

    End Function

End Class
