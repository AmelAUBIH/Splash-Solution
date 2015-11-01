Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrExit.Start()
    End Sub

    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        Me.Close()
    End Sub
End Class
