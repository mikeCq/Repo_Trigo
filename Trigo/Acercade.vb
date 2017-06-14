Imports System.Reflection
Public Class Acercade
    Private Sub Acercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the version of the executing assembly (that is, this assembly).
        Dim assem As Assembly = Assembly.GetEntryAssembly()
        Dim assemName As AssemblyName = assem.GetName()
        Dim ver As Version = assemName.Version

    End Sub
End Class