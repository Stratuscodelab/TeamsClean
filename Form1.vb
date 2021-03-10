Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\Cache"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\Blob_Storage"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\Databases"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\GPUcache"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\IndexedDB"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\Local Storage"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Microsoft\Teams\tmp"
            For Each deletefile In Directory.GetFiles(appData, searchPattern:="*.*", SearchOption.AllDirectories)
                System.IO.File.Delete(deletefile)
            Next
            MsgBox("Files in the Folder Deleted")
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        About.Show()
    End Sub
End Class
