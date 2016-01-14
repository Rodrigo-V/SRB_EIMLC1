
Imports System.Data
Imports System.Data.SqlClient

Module Module1


    Dim G4dt As New DataTable
    Dim fechahora As String = DateTime.Now.ToString()
    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=EIMLC;Integrated Security=True")
    Dim guardar As New SqlCommand
    Dim param As New SqlCommand
    Dim leer As SqlDataReader
    Dim variable As SqlDataReader
    Dim registrodt As New DataTable
    Dim comando As New SqlCommand
    Dim comando1 As New SqlCommand
    Dim comando2 As New SqlCommand
    Dim empleado As New SqlCommand
    Dim fecha As Char

    Public Sub armardatatable()

        'arma datatable
        registrodt.Columns.Add("ID")
        registrodt.Columns.Add("FECHA")
        registrodt.Columns.Add("HORA")
        registrodt.Columns.Add("EMPRESA")
        registrodt.Columns.Add("SERVICIO")
        registrodt.Columns.Add("INTERVALO")

    End Sub




    Public Sub llenargrilla()
       

        registrodt.Rows.Clear()
        comando.CommandText = "select * from REGISTRO1  where FECHA= '" & Registro.TextBox26.Text & "'ORDER BY HORA DESC"
        comando.Connection = (conexion)
        conexion.Open()
        leer = comando.ExecuteReader
        While leer.Read
            registrodt.Rows.Add(leer.Item("ID"), leer.Item("FECHA").ToString.Remove(10, 8), leer.Item("HORA"), leer.Item("EMPRESA"), leer.Item("SERVICIO"), leer.Item("INTERVALO"))
        End While
        leer.Close()
        conexion.Close()

        Registro.DataGridView1.DataSource = registrodt
        Ingreso_manual.DataGridView1.DataSource = registrodt

    End Sub
   
End Module
