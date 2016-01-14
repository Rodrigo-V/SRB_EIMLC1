
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop



Public Class Reportes

    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=EIMLC;Integrated Security=True")
    Dim leer As SqlDataReader
    Dim registrodt1 As New DataTable
    Dim comando As New SqlCommand
    Dim dts As DataSet
    Dim adpt As SqlDataAdapter
   


    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Label4.Visible = False
        ProgressBar1.Visible = False
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        'muestra fecha en el form
        TextBox1.Text = DateValue(Now)
        TextBox1.Enabled = False

        'arma datatable
        registrodt1.Columns.Add("FECHA")
        registrodt1.Columns.Add("HORA")
        registrodt1.Columns.Add("EMPRESA")
        registrodt1.Columns.Add("SERVICIO")
        registrodt1.Columns.Add("INTERVALO")


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Registro.Show()
        Me.Close()
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.DataGridView1.Enabled = False
        Me.DataGridView1.DataSource = Nothing
        registrodt1.Rows.Clear()
        Me.DataGridView1.Enabled = True


       

        comando.CommandType = CommandType.Text
        comando.CommandText = "select * from REGISTRO1  where FECHA = '" & Me.DateTimePicker1.Value.ToShortDateString & "'"
        comando.Connection = (conexion)

        conexion.Open()
        leer = comando.ExecuteReader
        While leer.Read
            registrodt1.Rows.Add(leer.Item("FECHA").ToString.Remove(10, 8), leer.Item("HORA"), leer.Item("EMPRESA"), leer.Item("SERVICIO"), leer.Item("INTERVALO"))
        End While
        leer.Close()
        DataGridView1.DataSource = registrodt1
        conexion.Close()




    End Sub

    Private Sub ExportarExcel()
       

            Try




            ProgressBar1.Value += 10


            'Variables del programa
            Dim rutaPlantilla As String = "C:\plantillaxls\plantilla1.xls"
            Dim rutaGuardado As String = "C:\Reportes\Reporte_SRB EIMLC  " + Me.DateTimePicker1.Value.ToShortDateString & ".xls"
            Dim xlApp As Excel.Application = New Excel.Application()
            Dim _libroExcel As Excel.Workbook = Nothing
            Dim _HojaExcel As Excel.Worksheet = Nothing
            Dim _Rango As Excel.Range = Nothing
            Dim misValue As Object = System.Reflection.Missing.Value

            ProgressBar1.Value += 10
            _libroExcel = xlApp.Workbooks.Open(rutaPlantilla, misValue, misValue, misValue _
                    , misValue, misValue, misValue, misValue _
                   , misValue, misValue, misValue, misValue _
                  , misValue, misValue, misValue)

            ProgressBar1.Value += 10
            _libroExcel = xlApp.ActiveWorkbook

            _HojaExcel = CType(_libroExcel.Worksheets.Item(1), Excel.Worksheet)
            _HojaExcel = _libroExcel.Worksheets(1)
            _HojaExcel.Columns("A").NumberFormat = "@"
            Try
                ProgressBar1.Value += 10
                ' columnas y filas
                Dim ncol As Integer = DataGridView1.ColumnCount
                Dim nrow As Integer = DataGridView1.RowCount
                ProgressBar1.Value += 10
                For i As Integer = 1 To ncol
                    _HojaExcel.Cells.Item(8, i) = DataGridView1.Columns(i - 1).Name.Trim
                    _HojaExcel.Cells.Item(1, i).horizontalalignment = 6


                Next
                ProgressBar1.Value += 10
                For fila As Integer = 0 To nrow - 1
                    For col As Integer = 0 To ncol - 1
                        _HojaExcel.Cells.Item(fila + 9, col + 1) = DataGridView1.Rows(fila).Cells(col).Value
                    Next
                Next

                ProgressBar1.Value += 10
                'Guardamos el libro 
                _libroExcel.SaveAs(rutaGuardado, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                ProgressBar1.Value += 10
                _libroExcel.Close(True, misValue, misValue)
                ProgressBar1.Value += 10
                xlApp.Quit()

                ProgressBar1.Value += 10

                MessageBox.Show("Datos Exportados" & rutaGuardado)

            Catch ex As System.Exception

                MessageBox.Show(ex.Message & "\n\n=======  Error al escribir el excel:  ======\n\n" & _
                   ex.StackTrace)

            Finally
            End Try
        Catch exl As System.Exception

            MessageBox.Show(exl.Message & _
             "\n\n=======   Error al abrir el archivo  ======\n\n" & _
             exl.StackTrace)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Label4.Visible = True
        ProgressBar1.Visible = True
        ExportarExcel()
        ProgressBar1.Value = 0

        Me.Hide()

    End Sub




    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
