Imports System.Data
Imports System.Data.SqlClient

Public Class Mantencion

    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=EIMLC;Integrated Security=True")
    Dim borrar As New SqlCommand
    Dim reiniciar As New SqlCommand




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim res As String
            res = MsgBox("Esto eliminara todos los registros de la base de datos, esta seguro???", MsgBoxStyle.YesNo, "Eliminar registro")
            If res = vbYes Then
                borrar.Parameters.Clear()
                borrar.CommandType = CommandType.StoredProcedure
                borrar.CommandText = "borrado_total"
                borrar.Connection = (conexion)
                conexion.Open()
                borrar.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Registros eliminados correctamente, proceda a reiniciar el campo ID", MsgBoxStyle.OkOnly, "Eliminado con exito!!!")
                Button1.Enabled = False
                Button2.Enabled = True
            End If
        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Mantencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button2.Enabled = False


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim res As String
            res = MsgBox("Esto reiniciara el campo ID el cual es autonumerico, esta seguro???", MsgBoxStyle.YesNo, "Reiniciar ID")
            If res = vbYes Then
                reiniciar.Parameters.Clear()
                reiniciar.CommandType = CommandType.StoredProcedure
                reiniciar.CommandText = "reiniciarreg"
                reiniciar.Connection = (conexion)
                conexion.Open()
                reiniciar.ExecuteNonQuery()
                conexion.Close()
                Button1.Enabled = False
                Button2.Enabled = True
            End If
            MsgBox("El campo ID fue reiniciado correctamente", MsgBoxStyle.OkOnly, "Reinicio!!!")
            conexion.Close()
            Button2.Enabled = False

        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message)

        End Try



    End Sub
End Class