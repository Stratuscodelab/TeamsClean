Imports System.IO
Public Class Form1
    Private wscript As Object

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

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        If Process.GetProcessesByName("Teams").Count > 0 Then

            MsgBox("Microsoft Teams is running")
        Else
            MsgBox("Microsoft Teams is NOT running")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.Parent = Me
        Label1.BackColor = Color.Transparent
        If Process.GetProcessesByName("Teams").Count > 0 Then
            Label1.ForeColor = Color.Red
            Label1.Text = "Microsoft Teams is running"
        Else
            Label1.ForeColor = Color.Green
            Label1.Text = "Microsoft Teams is NOT running"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim myProcesses() As Process
        Dim myProcess As Process

        myProcesses = Process.GetProcessesByName("Teams")

        Try

            If myProcesses.Length > 0 Then
                For Each myProcess In myProcesses
                    If myProcess IsNot Nothing Then
                        myProcess.Kill()
                    End If

                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
