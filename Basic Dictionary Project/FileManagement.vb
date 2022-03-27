Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FileManagement
    Private fileName As String = "data.dat"

    Public Sub createFile(value)
        Try
            Dim fs As New FileStream(Me.fileName, FileMode.Create)
            Dim formatter As New BinaryFormatter()

            formatter.Serialize(fs, value)
            fs.Close()
            MessageBox.Show("File Created: ", fileName)
        Catch ex As Exception
            MessageBox.Show("Error Message: ", ex.Message)
        End Try

    End Sub
    Public Function OpenFile()

        Try
            Dim fs As New FileStream(Me.fileName, FileMode.Open)
            Dim inventory As Inventory = New Inventory()
            Dim formatter As New BinaryFormatter()

            inventory = formatter.Deserialize(fs)
            MessageBox.Show("File Opened: ", fileName)

            Return inventory
        Catch ex As Exception
            MessageBox.Show("Error Message: ", ex.Message)
        End Try

        Return False

    End Function

End Class
