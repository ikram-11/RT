Imports System.IO

Public Class Single_file
    Public Property Class1BindingSource As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "lif file|*.lif"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Class1) = New List(Of Class1)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                    list.Add(New Class1() With {
                        .Classement = data(0),
                        .NomEtPrenom = data(1),
                        .Licence = data(2),
                        .Club = data(3),
                        .Dossard = data(4),
                        .Couloir = data(5),
                        .Resultat = data(6),
                        .DeltaTime = data(7)
                                   })
                Next
                Class1BindingSource.DataSource = list

            End If
        End Using

    End Sub
End Class