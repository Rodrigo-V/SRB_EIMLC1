

Imports System.Data
Imports System.Data.SqlClient

Public Class Ingreso_manual
    Dim guardar As New SqlCommand
    Dim comando2 As New SqlCommand
    Dim empresa As New SqlCommand
    Dim serv As New SqlCommand
    Dim variable As SqlDataReader
    Dim variable1 As SqlDataReader
    Dim registrodt As New DataTable
    Dim da As New SqlDataAdapter
    Dim dtb As New DataTable
    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=EIMLC;Integrated Security=True")

    Private Sub Ingreso_manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'arma datatable


        registrodt.Columns.Add("FECHA")
        registrodt.Columns.Add("HORA")
        registrodt.Columns.Add("EMPRESA")
        registrodt.Columns.Add("SERVICIO")
        registrodt.Columns.Add("INTERVALO")


        llenargrilla()


        'seleccion de toda la fila en el datagrid
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        da = New SqlDataAdapter("select * from EMPRESAS", conexion)
        dtb = New DataTable
        da.fill(dtb)
        ComboBox1.DataSource = dtb
        ComboBox1.DisplayMember = "NOMBRE_EMPRESA"
        ComboBox1.ValueMember = "ID_EMPRESA"
       






    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (DateTimePicker1.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (DateTimePicker2.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = (ComboBox1.Text)
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = (ComboBox2.Text)
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox2.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()

        llenargrilla()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As String

        res = MsgBox("seguro que desea eliminar este registro de la base de datos", MsgBoxStyle.YesNo, "Eliminar registro")
        If res = vbYes And DataGridView1.RowCount > 1 Then
            Dim sqlquery As String = "delete from REGISTRO1 where ID= '" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString & "'"
            comando2.CommandText = sqlquery
            comando2.Connection = (conexion)
            conexion.Open()
            comando2.ExecuteNonQuery()
            conexion.Close()
            MsgBox("registro eliminado con exito!!!", MsgBoxStyle.ApplicationModal)

            llenargrilla()

        Else
            MsgBox("Ningun registro fue eliminado, la grilla esta vacia o se perdio la conexion a la base de datos ", MsgBoxStyle.Critical, "Error 300")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

  
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try
            da = New SqlDataAdapter("select * from SERVICIO WHERE ID_EMPRESA='" & ComboBox1.SelectedValue.ToString & "'", conexion)
            dtb = New DataTable
            da.Fill(dtb)
            ComboBox2.DataSource = dtb
            ComboBox2.DisplayMember = "NUM_SERVICIO"
            ComboBox2.ValueMember = "ID_SERVICIO"
        Catch ex As Exception
        End Try
    End Sub



  
End Class