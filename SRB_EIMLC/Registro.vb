
Imports System.Data
Imports System.Data.SqlClient

Public Class Registro
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
    Dim hora1 As Integer = 0
    Dim minuto1 As Integer = 0
    Dim segundo1 As Integer = 0
    Dim hora2 As Integer = 0
    Dim minuto2 As Integer = 0
    Dim segundo2 As Integer = 0
    Dim hora3 As Integer = 0
    Dim minuto3 As Integer = 0
    Dim segundo3 As Integer = 0
    Dim hora4 As Integer = 0
    Dim minuto4 As Integer = 0
    Dim segundo4 As Integer = 0
    Dim hora5 As Integer = 0
    Dim minuto5 As Integer = 0
    Dim segundo5 As Integer = 0
    Dim hora6 As Integer = 0
    Dim minuto6 As Integer = 0
    Dim segundo6 As Integer = 0
    Dim hora7 As Integer = 0
    Dim minuto7 As Integer = 0
    Dim segundo7 As Integer = 0
    Dim hora8 As Integer = 0
    Dim minuto8 As Integer = 0
    Dim segundo8 As Integer = 0
    Dim hora9 As Integer = 0
    Dim minuto9 As Integer = 0
    Dim segundo9 As Integer = 0
    Dim hora10 As Integer = 0
    Dim minuto10 As Integer = 0
    Dim segundo10 As Integer = 0
    Dim hora11 As Integer = 0
    Dim minuto11 As Integer = 0
    Dim segundo11 As Integer = 0
    Dim hora12 As Integer = 0
    Dim minuto12 As Integer = 0
    Dim segundo12 As Integer = 0
    Dim hora13 As Integer = 0
    Dim minuto13 As Integer = 0
    Dim segundo13 As Integer = 0
    Dim hora14 As Integer = 0
    Dim minuto14 As Integer = 0
    Dim segundo14 As Integer = 0
    Dim hora15 As Integer = 0
    Dim minuto15 As Integer = 0
    Dim segundo15 As Integer = 0
    Dim hora16 As Integer = 0
    Dim minuto16 As Integer = 0
    Dim segundo16 As Integer = 0
    Dim hora17 As Integer = 0
    Dim minuto17 As Integer = 0
    Dim segundo17 As Integer = 0
    Dim hora18 As Integer = 0
    Dim minuto18 As Integer = 0
    Dim segundo18 As Integer = 0
    Dim hora19 As Integer = 0
    Dim minuto19 As Integer = 0
    Dim segundo19 As Integer = 0
    Dim hora20 As Integer = 0
    Dim minuto20 As Integer = 0
    Dim segundo20 As Integer = 0
    Dim hora21 As Integer = 0
    Dim minuto21 As Integer = 0
    Dim segundo21 As Integer = 0
    Dim hora22 As Integer = 0
    Dim minuto22 As Integer = 0
    Dim segundo22 As Integer = 0
    Dim hora23 As Integer = 0
    Dim minuto23 As Integer = 0
    Dim segundo23 As Integer = 0
    Dim hora24 As Integer = 0
    Dim minuto24 As Integer = 0
    Dim segundo24 As Integer = 0
    Dim hora25 As Integer = 0
    Dim minuto25 As Integer = 0
    Dim segundo25 As Integer = 0
    Dim a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z As Integer
    


    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 0
        b = 0
        c = 0
        d = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        k = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        x = 0
        y = 0
        z = 0


        Button30.BackColor = Color.Red
        Button31.BackColor = Color.Red
        Button32.BackColor = Color.Red
        Button33.BackColor = Color.LightGreen
        Button34.BackColor = Color.Red
        Button35.BackColor = Color.Red
        Button36.BackColor = Color.Red
        Button37.BackColor = Color.Red
        Button38.BackColor = Color.LightGreen
        Button39.BackColor = Color.LightGreen
        Button40.BackColor = Color.LightGreen
        Button41.BackColor = Color.LightGreen
        Button42.BackColor = Color.LightGreen
        Button43.BackColor = Color.LightGreen
        Button44.BackColor = Color.LightGreen
        Button45.BackColor = Color.LightGreen
        Button46.BackColor = Color.LightGreen
        Button47.BackColor = Color.LightGreen
        Button48.BackColor = Color.LightGreen
        Button49.BackColor = Color.LightGreen
        Button50.BackColor = Color.Red
        Button51.BackColor = Color.LightGreen
        Button52.BackColor = Color.LightGreen
        Button53.BackColor = Color.Red
        Button54.BackColor = Color.Red

        'seleccion de toda la fila en el datagrid
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'deshabilita botones
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        MsgBox("Debe elegir su nombre de la lista para habilitar el registro de buses", MsgBoxStyle.Information)

        'muestra fecha en el form
        TextBox26.Text = DateValue(Now)
        TextBox26.Enabled = False




        'llenar combo con nombres de empleados
        empleado.CommandType = CommandType.Text
        empleado.CommandText = ("select LOGIN from EMPLEADO")
        empleado.Connection = (conexion)
        conexion.Open()
        variable = empleado.ExecuteReader()

        'ciclo que llena el combobox 
        While variable.Read = True
            ToolStripComboBox1.Items.Add(variable(0))
        End While
        conexion.Close()

        armardatatable()
        llenargrilla()

    End Sub

    Private Sub ToolStripComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.TextChanged

        If ToolStripComboBox1.Text = "" Then
            MsgBox("Debe seleccionar su nombre de la lista para registrar eventos!!!", MsgBoxStyle.Critical)

        Else
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            GroupBox5.Enabled = True
            Timer2.Enabled = True
            mostrarTiempo1()

            Timer3.Enabled = True
            mostrarTiempo2()

            Timer4.Enabled = True
            mostrarTiempo3()

            Timer5.Enabled = True
            mostrarTiempo4()

            Timer6.Enabled = True
            mostrarTiempo5()

            Timer7.Enabled = True
            mostrarTiempo6()

            Timer8.Enabled = True
            mostrarTiempo7()

            Timer9.Enabled = True
            mostrarTiempo8()

            Timer10.Enabled = False
            mostrarTiempo9()

            Timer11.Enabled = True
            mostrarTiempo10()

            Timer12.Enabled = True
            mostrarTiempo11()

            Timer13.Enabled = True
            mostrarTiempo12()

            Timer14.Enabled = False
            mostrarTiempo13()

            Timer15.Enabled = False
            mostrarTiempo14()

            Timer16.Enabled = False
            mostrarTiempo15()

            Timer17.Enabled = False
            mostrarTiempo16()

            Timer18.Enabled = True
            mostrarTiempo17()

            Timer19.Enabled = False
            mostrarTiempo18()

            Timer20.Enabled = True
            mostrarTiempo19()

            Timer21.Enabled = True
            mostrarTiempo20()

            Timer22.Enabled = False
            mostrarTiempo21()

            Timer23.Enabled = False
            mostrarTiempo22()

            Timer24.Enabled = True
            mostrarTiempo23()

            Timer25.Enabled = False
            mostrarTiempo24()

            Timer26.Enabled = False
            mostrarTiempo25()

            Me.Button9.Enabled = False
            Me.Button13.Enabled = False
            Me.Button14.Enabled = False
            Me.Button15.Enabled = False
            Me.Button16.Enabled = False
            Me.Button18.Enabled = False
            Me.Button21.Enabled = False
            Me.Button22.Enabled = False
            Me.Button24.Enabled = False
            Me.Button25.Enabled = False


            PictureBox1.Image = Image.FromFile("C:\plantillaxls\verde.jpg")
            Label28.Visible = True


        End If
    End Sub
   

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label26.Text = Date.Now.ToLongTimeString

    End Sub



    Sub mostrarTiempo1()

        TextBox1.Text = hora1.ToString.PadLeft(2, "0") & ":"
        TextBox1.Text &= minuto1.ToString.PadLeft(2, "0") & ":"
        TextBox1.Text &= segundo1.ToString.PadLeft(2, "0")
        TextBox1.Refresh()
    End Sub
    Sub mostrarTiempo2()

        TextBox2.Text = hora2.ToString.PadLeft(2, "0") & ":"
        TextBox2.Text &= minuto2.ToString.PadLeft(2, "0") & ":"
        TextBox2.Text &= segundo2.ToString.PadLeft(2, "0")
        TextBox2.Refresh()
    End Sub
    Sub mostrarTiempo3()

        TextBox3.Text = hora3.ToString.PadLeft(2, "0") & ":"
        TextBox3.Text &= minuto3.ToString.PadLeft(2, "0") & ":"
        TextBox3.Text &= segundo3.ToString.PadLeft(2, "0")
        TextBox3.Refresh()
    End Sub
    Sub mostrarTiempo4()

        TextBox4.Text = hora4.ToString.PadLeft(2, "0") & ":"
        TextBox4.Text &= minuto4.ToString.PadLeft(2, "0") & ":"
        TextBox4.Text &= segundo4.ToString.PadLeft(2, "0")
        TextBox4.Refresh()
    End Sub
    Sub mostrarTiempo5()

        TextBox5.Text = hora5.ToString.PadLeft(2, "0") & ":"
        TextBox5.Text &= minuto5.ToString.PadLeft(2, "0") & ":"
        TextBox5.Text &= segundo5.ToString.PadLeft(2, "0")
        TextBox5.Refresh()
    End Sub
    Sub mostrarTiempo6()

        TextBox6.Text = hora6.ToString.PadLeft(2, "0") & ":"
        TextBox6.Text &= minuto6.ToString.PadLeft(2, "0") & ":"
        TextBox6.Text &= segundo6.ToString.PadLeft(2, "0")
        TextBox6.Refresh()

    End Sub
    Sub mostrarTiempo7()

        TextBox7.Text = hora7.ToString.PadLeft(2, "0") & ":"
        TextBox7.Text &= minuto7.ToString.PadLeft(2, "0") & ":"
        TextBox7.Text &= segundo7.ToString.PadLeft(2, "0")
        TextBox7.Refresh()
    End Sub
    Sub mostrarTiempo8()

        TextBox8.Text = hora8.ToString.PadLeft(2, "0") & ":"
        TextBox8.Text &= minuto8.ToString.PadLeft(2, "0") & ":"
        TextBox8.Text &= segundo8.ToString.PadLeft(2, "0")
        TextBox8.Refresh()
    End Sub
    Sub mostrarTiempo9()

        TextBox9.Text = hora9.ToString.PadLeft(2, "0") & ":"
        TextBox9.Text &= minuto9.ToString.PadLeft(2, "0") & ":"
        TextBox9.Text &= segundo9.ToString.PadLeft(2, "0")
        TextBox9.Refresh()
    End Sub
    Sub mostrarTiempo10()

        TextBox10.Text = hora10.ToString.PadLeft(2, "0") & ":"
        TextBox10.Text &= minuto10.ToString.PadLeft(2, "0") & ":"
        TextBox10.Text &= segundo10.ToString.PadLeft(2, "0")
        TextBox10.Refresh()
    End Sub
    Sub mostrarTiempo11()

        TextBox11.Text = hora11.ToString.PadLeft(2, "0") & ":"
        TextBox11.Text &= minuto11.ToString.PadLeft(2, "0") & ":"
        TextBox11.Text &= segundo11.ToString.PadLeft(2, "0")
        TextBox11.Refresh()
    End Sub
    Sub mostrarTiempo12()

        TextBox12.Text = hora12.ToString.PadLeft(2, "0") & ":"
        TextBox12.Text &= minuto12.ToString.PadLeft(2, "0") & ":"
        TextBox12.Text &= segundo12.ToString.PadLeft(2, "0")
        TextBox12.Refresh()
    End Sub
    Sub mostrarTiempo13()

        TextBox13.Text = hora13.ToString.PadLeft(2, "0") & ":"
        TextBox13.Text &= minuto13.ToString.PadLeft(2, "0") & ":"
        TextBox13.Text &= segundo13.ToString.PadLeft(2, "0")
        TextBox13.Refresh()
    End Sub
    Sub mostrarTiempo14()

        TextBox14.Text = hora14.ToString.PadLeft(2, "0") & ":"
        TextBox14.Text &= minuto14.ToString.PadLeft(2, "0") & ":"
        TextBox14.Text &= segundo14.ToString.PadLeft(2, "0")
        TextBox14.Refresh()
    End Sub
    Sub mostrarTiempo15()

        TextBox15.Text = hora15.ToString.PadLeft(2, "0") & ":"
        TextBox15.Text &= minuto15.ToString.PadLeft(2, "0") & ":"
        TextBox15.Text &= segundo15.ToString.PadLeft(2, "0")
        TextBox15.Refresh()
    End Sub
    Sub mostrarTiempo16()

        TextBox16.Text = hora16.ToString.PadLeft(2, "0") & ":"
        TextBox16.Text &= minuto16.ToString.PadLeft(2, "0") & ":"
        TextBox16.Text &= segundo16.ToString.PadLeft(2, "0")
        TextBox16.Refresh()
    End Sub
    Sub mostrarTiempo17()

        TextBox17.Text = hora17.ToString.PadLeft(2, "0") & ":"
        TextBox17.Text &= minuto17.ToString.PadLeft(2, "0") & ":"
        TextBox17.Text &= segundo17.ToString.PadLeft(2, "0")
        TextBox17.Refresh()
    End Sub
    Sub mostrarTiempo18()

        TextBox18.Text = hora18.ToString.PadLeft(2, "0") & ":"
        TextBox18.Text &= minuto18.ToString.PadLeft(2, "0") & ":"
        TextBox18.Text &= segundo18.ToString.PadLeft(2, "0")
        TextBox18.Refresh()
    End Sub
    Sub mostrarTiempo19()

        TextBox19.Text = hora19.ToString.PadLeft(2, "0") & ":"
        TextBox19.Text &= minuto19.ToString.PadLeft(2, "0") & ":"
        TextBox19.Text &= segundo19.ToString.PadLeft(2, "0")
        TextBox19.Refresh()
    End Sub
    Sub mostrarTiempo20()

        TextBox20.Text = hora20.ToString.PadLeft(2, "0") & ":"
        TextBox20.Text &= minuto20.ToString.PadLeft(2, "0") & ":"
        TextBox20.Text &= segundo20.ToString.PadLeft(2, "0")
        TextBox20.Refresh()
    End Sub
    Sub mostrarTiempo21()

        TextBox21.Text = hora21.ToString.PadLeft(2, "0") & ":"
        TextBox21.Text &= minuto21.ToString.PadLeft(2, "0") & ":"
        TextBox21.Text &= segundo21.ToString.PadLeft(2, "0")
        TextBox21.Refresh()
    End Sub
    Sub mostrarTiempo22()

        TextBox22.Text = hora22.ToString.PadLeft(2, "0") & ":"
        TextBox22.Text &= minuto22.ToString.PadLeft(2, "0") & ":"
        TextBox22.Text &= segundo22.ToString.PadLeft(2, "0")
        TextBox22.Refresh()
    End Sub
    Sub mostrarTiempo23()

        TextBox23.Text = hora23.ToString.PadLeft(2, "0") & ":"
        TextBox23.Text &= minuto23.ToString.PadLeft(2, "0") & ":"
        TextBox23.Text &= segundo23.ToString.PadLeft(2, "0")
        TextBox23.Refresh()
    End Sub
    Sub mostrarTiempo24()

        TextBox24.Text = hora24.ToString.PadLeft(2, "0") & ":"
        TextBox24.Text &= minuto24.ToString.PadLeft(2, "0") & ":"
        TextBox24.Text &= segundo24.ToString.PadLeft(2, "0")
        TextBox24.Refresh()
    End Sub
    Sub mostrarTiempo25()

        TextBox25.Text = hora25.ToString.PadLeft(2, "0") & ":"
        TextBox25.Text &= minuto25.ToString.PadLeft(2, "0") & ":"
        TextBox25.Text &= segundo25.ToString.PadLeft(2, "0")
        TextBox25.Refresh()
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        segundo1 += 1
        If segundo1 = 59 Then
            segundo1 = 0
            minuto1 += 1

            If minuto1 = 59 Then
                minuto1 = 0
                hora1 += 1

            End If
        End If
        If TextBox1.Text > "00:15:00" Then
            TextBox1.BackColor = Color.Red
        End If
        mostrarTiempo1()
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        segundo2 += 1
        If segundo2 = 59 Then
            segundo2 = 0
            minuto2 += 1

            If minuto2 = 59 Then
                minuto2 = 0
                hora2 += 1

            End If
        End If
        If TextBox2.Text > "00:15:00" Then
            TextBox2.BackColor = Color.Red
        End If
        mostrarTiempo2()
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        segundo3 += 1
        If segundo3 = 59 Then
            segundo3 = 0
            minuto3 += 1

            If minuto3 = 59 Then
                minuto3 = 0
                hora3 += 1

            End If
        End If
        If TextBox3.Text > "00:15:00" Then
            TextBox3.BackColor = Color.Red
        End If
        mostrarTiempo3()
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        segundo4 += 1
        If segundo4 = 59 Then
            segundo4 = 0
            minuto4 += 1

            If minuto4 = 59 Then
                minuto4 = 0
                hora4 += 1

            End If
        End If
        If TextBox4.Text > "00:15:00" Then
            TextBox4.BackColor = Color.Red
        End If
        mostrarTiempo4()
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        segundo5 += 1
        If segundo5 = 59 Then
            segundo5 = 0
            minuto5 += 1

            If minuto5 = 59 Then
                minuto5 = 0
                hora5 += 1

            End If
        End If
        If TextBox5.Text > "00:15:00" Then
            TextBox5.BackColor = Color.Red
        End If
        mostrarTiempo5()
    End Sub
    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        segundo6 += 1
        If segundo6 = 59 Then
            segundo6 = 0
            minuto6 += 1

            If minuto6 = 59 Then
                minuto6 = 0
                hora6 += 1
            End If
        End If
        If TextBox6.Text > "00:15:00" Then
            TextBox6.BackColor = Color.Red
        End If
        mostrarTiempo6()
    End Sub
    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        segundo7 += 1
        If segundo7 = 59 Then
            segundo7 = 0
            minuto7 += 1
            If minuto7 = 59 Then
                minuto7 = 0
                hora7 += 1
            End If
        End If
        If TextBox7.Text > "00:15:00" Then
            TextBox7.BackColor = Color.Red
        End If
        mostrarTiempo7()
    End Sub
    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        segundo8 += 1
        If segundo8 = 59 Then
            segundo8 = 0
            minuto8 += 1

            If minuto8 = 59 Then
                minuto8 = 0
                hora8 += 1

            End If
        End If
        If TextBox8.Text > "00:15:00" Then
            TextBox8.BackColor = Color.Red
        End If
        mostrarTiempo8()
    End Sub
    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        segundo9 += 1
        If segundo9 = 59 Then
            segundo9 = 0
            minuto9 += 1

            If minuto9 = 59 Then
                minuto9 = 0
                hora9 += 1

            End If
        End If
        If TextBox9.Text > "00:15:00" Then
            TextBox9.BackColor = Color.Red
        End If
        mostrarTiempo9()
    End Sub
    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        segundo10 += 1
        If segundo10 = 59 Then
            segundo10 = 0
            minuto10 += 1

            If minuto10 = 59 Then
                minuto10 = 0
                hora10 += 1

            End If
        End If
        If TextBox10.Text > "00:15:00" Then
            TextBox10.BackColor = Color.Red
        End If
        mostrarTiempo10()
    End Sub
    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        segundo11 += 1
        If segundo11 = 59 Then
            segundo11 = 0
            minuto11 += 1

            If minuto11 = 59 Then
                minuto11 = 0
                hora11 += 1

            End If
        End If
        If TextBox11.Text > "00:15:00" Then
            TextBox11.BackColor = Color.Red
        End If
        mostrarTiempo11()
    End Sub
    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        segundo12 += 1
        If segundo12 = 59 Then
            segundo12 = 0
            minuto12 += 1

            If minuto12 = 59 Then
                minuto12 = 0
                hora12 += 1

            End If
        End If
        If TextBox12.Text > "00:15:00" Then
            TextBox12.BackColor = Color.Red
        End If
        mostrarTiempo12()
    End Sub
    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        segundo13 += 1
        If segundo13 = 59 Then
            segundo13 = 0
            minuto13 += 1

            If minuto13 = 59 Then
                minuto13 = 0
                hora13 += 1

            End If
        End If
        If TextBox13.Text > "00:15:00" Then
            TextBox13.BackColor = Color.Red
        End If
        mostrarTiempo13()
    End Sub
    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        segundo14 += 1
        If segundo14 = 59 Then
            segundo14 = 0
            minuto14 += 1

            If minuto14 = 59 Then
                minuto14 = 0
                hora14 += 1

            End If
        End If
        If TextBox14.Text > "00:15:00" Then
            TextBox14.BackColor = Color.Red
        End If
        mostrarTiempo14()
    End Sub
    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        segundo15 += 1
        If segundo15 = 59 Then
            segundo15 = 0
            minuto15 += 1

            If minuto15 = 59 Then
                minuto15 = 0
                hora15 += 1

            End If
        End If
        If TextBox15.Text > "00:15:00" Then
            TextBox15.BackColor = Color.Red
        End If
        mostrarTiempo15()
    End Sub
    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        segundo16 += 1
        If segundo16 = 59 Then
            segundo16 = 0
            minuto16 += 1

            If minuto16 = 59 Then
                minuto16 = 0
                hora16 += 1

            End If
        End If
        If TextBox16.Text > "00:15:00" Then
            TextBox16.BackColor = Color.Red
        End If
        mostrarTiempo16()
    End Sub
    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        segundo17 += 1
        If segundo17 = 59 Then
            segundo17 = 0
            minuto17 += 1

            If minuto17 = 59 Then
                minuto17 = 0
                hora17 += 1

            End If
        End If
        If TextBox17.Text > "00:15:00" Then
            TextBox17.BackColor = Color.Red
        End If
        mostrarTiempo17()
    End Sub
    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        segundo18 += 1
        If segundo18 = 59 Then
            segundo18 = 0
            minuto18 += 1

            If minuto18 = 59 Then
                minuto18 = 0
                hora18 += 1

            End If
        End If
        If TextBox18.Text > "00:15:00" Then
            TextBox18.BackColor = Color.Red
        End If
        mostrarTiempo18()
    End Sub
    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        segundo19 += 1
        If segundo19 = 59 Then
            segundo19 = 0
            minuto19 += 1

            If minuto19 = 59 Then
                minuto19 = 0
                hora19 += 1

            End If
        End If
        If TextBox19.Text > "00:15:00" Then
            TextBox19.BackColor = Color.Red
        End If
        mostrarTiempo19()
    End Sub
    Private Sub Timer21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer21.Tick
        segundo20 += 1
        If segundo20 = 59 Then
            segundo20 = 0
            minuto20 += 1

            If minuto20 = 59 Then
                minuto20 = 0
                hora20 += 1

            End If
        End If
        If TextBox20.Text > "00:15:00" Then
            TextBox20.BackColor = Color.Red
        End If
        mostrarTiempo20()
    End Sub
    Private Sub Timer22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer22.Tick
        segundo21 += 1
        If segundo21 = 59 Then
            segundo21 = 0
            minuto21 += 1

            If minuto21 = 59 Then
                minuto21 = 0
                hora21 += 1

            End If
        End If
        If TextBox21.Text > "00:15:00" Then
            TextBox21.BackColor = Color.Red
        End If
        mostrarTiempo21()
    End Sub
    Private Sub Timer23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer23.Tick
        segundo22 += 1
        If segundo22 = 59 Then
            segundo22 = 0
            minuto22 += 1

            If minuto22 = 59 Then
                minuto22 = 0
                hora22 += 1

            End If
        End If
        If TextBox22.Text > "00:15:00" Then
            TextBox22.BackColor = Color.Red
        End If
        mostrarTiempo22()
    End Sub
    Private Sub Timer24_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer24.Tick

        segundo23 += 1
        If segundo23 = 59 Then
            segundo23 = 0
            minuto23 += 1

            If minuto23 = 59 Then
                minuto23 = 0
                hora23 += 1

            End If
        End If
        If TextBox23.Text > "00:15:00" Then
            TextBox23.BackColor = Color.Red
        End If
        mostrarTiempo23()
    End Sub
    Private Sub Timer25_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer25.Tick
        segundo24 += 1
        If segundo24 = 59 Then
            segundo24 = 0
            minuto24 += 1

            If minuto24 = 59 Then
                minuto24 = 0
                hora24 += 1

            End If
        End If
        If TextBox24.Text > "00:15:00" Then
            TextBox24.BackColor = Color.Red
        End If
        mostrarTiempo24()
    End Sub
    Private Sub Timer26_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer26.Tick
        segundo25 += 1
        If segundo25 = 59 Then
            segundo25 = 0
            minuto25 += 1

            If minuto25 = 59 Then
                minuto25 = 0
                hora25 += 1

            End If
        End If
        If TextBox25.Text > "00:15:00" Then
            TextBox25.BackColor = Color.Red
        End If
        mostrarTiempo25()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G04"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox1.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora1 = 0
        minuto1 = 0
        segundo1 = 0
        Timer2.Enabled = True
        TextBox1.BackColor = Color.White
        Me.Label29.Text = "G04"
        llenargrilla()
        mostrarTiempo1()




    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G05"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox2.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora2 = 0
        minuto2 = 0
        segundo2 = 0
        Timer3.Enabled = True
        TextBox2.BackColor = Color.White
        Me.Label29.Text = "G05"
        llenargrilla()
        mostrarTiempo2()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G08"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox3.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora3 = 0
        minuto3 = 0
        segundo3 = 0
        Timer4.Enabled = True
        TextBox3.BackColor = Color.White
        Me.Label29.Text = "G08"
        llenargrilla()
        mostrarTiempo3()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G08v"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox4.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora4 = 0
        minuto4 = 0
        segundo4 = 0
        Timer5.Enabled = True
        TextBox4.BackColor = Color.White
        Me.Label29.Text = "G08v"
        llenargrilla()
        mostrarTiempo4()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G13"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox5.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora5 = 0
        minuto5 = 0
        segundo5 = 0
        Timer6.Enabled = True
        TextBox5.BackColor = Color.White
        Me.Label29.Text = "G13"
        llenargrilla()
        mostrarTiempo5()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G15"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox6.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora6 = 0
        minuto6 = 0
        segundo6 = 0
        Timer7.Enabled = True
        TextBox6.BackColor = Color.White
        Me.Label29.Text = "G15"
        llenargrilla()
        mostrarTiempo6()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G16"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox7.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora7 = 0
        minuto7 = 0
        segundo7 = 0
        Timer8.Enabled = True
        TextBox7.BackColor = Color.White
        Me.Label29.Text = "G16"
        llenargrilla()
        mostrarTiempo7()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "G22"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox8.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora8 = 0
        minuto8 = 0
        segundo8 = 0
        Timer9.Enabled = True
        TextBox8.BackColor = Color.White
        Me.Label29.Text = "G22"
        llenargrilla()
        mostrarTiempo8()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "Sin Servicio"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox9.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora9 = 0
        minuto9 = 0
        segundo9 = 0
        Timer10.Enabled = True
        TextBox9.BackColor = Color.White
        Me.Label29.Text = "S.S."
        llenargrilla()
        mostrarTiempo9()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "STP"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "F05"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox10.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora10 = 0
        minuto10 = 0
        segundo10 = 0
        Timer11.Enabled = True
        TextBox10.BackColor = Color.White
        Me.Label29.Text = "F05"
        llenargrilla()
        mostrarTiempo10()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "STP"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "F06"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox11.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora11 = 0
        minuto11 = 0
        segundo11 = 0
        Timer12.Enabled = True
        TextBox11.BackColor = Color.White
        Me.Label29.Text = "F06"
        llenargrilla()
        mostrarTiempo11()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "STP"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "F20"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox12.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora12 = 0
        minuto12 = 0
        segundo12 = 0
        Timer13.Enabled = True
        TextBox12.BackColor = Color.White
        Me.Label29.Text = "F20"
        llenargrilla()
        mostrarTiempo12()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "STP"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "Sin servicio"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox13.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora13 = 0
        minuto13 = 0
        segundo13 = 0
        Timer14.Enabled = True
        TextBox13.BackColor = Color.White
        Me.Label29.Text = "S.S."
        llenargrilla()
        mostrarTiempo13()
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "201c"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox14.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora14 = 0
        minuto14 = 0
        segundo14 = 0
        Timer15.Enabled = True
        TextBox14.BackColor = Color.White
        Me.Label29.Text = "201c"
        llenargrilla()
        mostrarTiempo14()
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "211c"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox15.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora15 = 0
        minuto15 = 0
        segundo15 = 0
        Timer16.Enabled = True
        TextBox15.BackColor = Color.White
        Me.Label29.Text = "211c"
        llenargrilla()
        mostrarTiempo15()
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "219e"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox16.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora16 = 0
        minuto16 = 0
        segundo16 = 0
        Timer17.Enabled = True
        TextBox16.BackColor = Color.White
        Me.Label29.Text = "219"
        llenargrilla()
        mostrarTiempo15()
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "228"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox17.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora17 = 0
        minuto17 = 0
        segundo17 = 0
        Timer18.Enabled = True
        TextBox17.BackColor = Color.White
        Me.Label29.Text = "228"
        llenargrilla()
        mostrarTiempo17()
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "SUBUS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "Sin servicio"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox18.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora18 = 0
        minuto18 = 0
        segundo18 = 0
        Timer19.Enabled = True
        TextBox18.BackColor = Color.White
        Me.Label29.Text = "S.S."
        llenargrilla()
        mostrarTiempo18()
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "EXPRESS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "428"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox19.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora19 = 0
        minuto19 = 0
        segundo19 = 0
        Timer20.Enabled = True
        TextBox19.BackColor = Color.White
        Me.Label29.Text = "428"
        llenargrilla()
        mostrarTiempo19()
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "EXPRESS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "428c"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox15.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora20 = 0
        minuto20 = 0
        segundo20 = 0
        Timer21.Enabled = True
        TextBox20.BackColor = Color.White
        Me.Label29.Text = "428c"
        llenargrilla()
        mostrarTiempo20()
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "EXPRESS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "428e"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox21.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora21 = 0
        minuto21 = 0
        segundo21 = 0
        Timer22.Enabled = True
        TextBox21.BackColor = Color.White
        Me.Label29.Text = "428e"
        llenargrilla()
        mostrarTiempo21()
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "EXPRESS"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "Sin Servicio"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox22.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora22 = 0
        minuto22 = 0
        segundo22 = 0
        Timer23.Enabled = True
        TextBox22.BackColor = Color.White
        Me.Label29.Text = "S.S."
        llenargrilla()
        mostrarTiempo22()
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "VULE"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "301c"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox23.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora23 = 0
        minuto23 = 0
        segundo23 = 0
        Timer24.Enabled = True
        TextBox23.BackColor = Color.White
        Me.Label29.Text = "301c"
        llenargrilla()
        mostrarTiempo23()
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "VULE"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "301c2"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox24.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora24 = 0
        minuto24 = 0
        segundo24 = 0
        Timer25.Enabled = True
        TextBox24.BackColor = Color.White
        Me.Label29.Text = "301c2"
        llenargrilla()
        mostrarTiempo24()
    End Sub
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        guardar.Parameters.Clear()
        guardar.CommandType = CommandType.StoredProcedure
        guardar.CommandText = "agregareg3"
        guardar.Parameters.Add("@fecha", SqlDbType.Date).Value = (TextBox26.Text)
        guardar.Parameters.Add("@hora", SqlDbType.Time).Value = (Label26.Text)
        guardar.Parameters.Add("@empresa", SqlDbType.Char).Value = "VULE"
        guardar.Parameters.Add("@servicio", SqlDbType.Char).Value = "Sin Servicio"
        guardar.Parameters.Add("@intervalo", SqlDbType.Time).Value = (TextBox25.Text)
        guardar.Connection = (conexion)
        conexion.Open()
        guardar.ExecuteNonQuery()
        conexion.Close()
        hora25 = 0
        minuto25 = 0
        segundo25 = 0
        Timer26.Enabled = True
        TextBox25.BackColor = Color.White
        Me.Label29.Text = "S.S."
        llenargrilla()
        mostrarTiempo25()
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
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
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        End
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Loginmantencion.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        info.Show()
    End Sub
    Private Sub ReporteDetalladoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDetalladoToolStripMenuItem.Click
        Reportes.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form1.Show()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If a = 0 Then
            Button30.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button16.Enabled = True
            TextBox16.BackColor = Color.White
            TextBox16.Enabled = True
            Timer17.Enabled = True
            Timer17.Start()

        ElseIf a = 1 Then
            Button30.BackColor = Color.Red
            Button16.Enabled = False
            TextBox16.BackColor = Color.White
            TextBox16.Enabled = False
            Timer17.Enabled = False
            Timer17.Stop()
            hora16 = 0
            minuto16 = 0
            segundo16 = 0
        End If
        a = a + 1
        If a = 2 Then
            a = 0
        End If
    End Sub
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If b = 0 Then
            Button31.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button14.Enabled = True
            TextBox14.BackColor = Color.White
            TextBox14.Enabled = True
            Timer15.Enabled = True
            Timer15.Start()

        ElseIf b = 1 Then
            Button31.BackColor = Color.Red
            Button14.Enabled = False
            TextBox14.BackColor = Color.White
            TextBox14.Enabled = False
            Timer15.Enabled = False
            Timer15.Stop()
            hora14 = 0
            minuto14 = 0
            segundo14 = 0
        End If
        b = b + 1
        If b = 2 Then
            b = 0
        End If
    End Sub
    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If c = 0 Then
            Button32.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button15.Enabled = True
            TextBox15.BackColor = Color.White
            TextBox15.Enabled = True
            Timer16.Enabled = True
            Timer16.Start()
           
        ElseIf c = 1 Then
            Button32.BackColor = Color.Red
            Button15.Enabled = False
            TextBox15.BackColor = Color.White
            TextBox15.Enabled = False
            Timer16.Enabled = False
            Timer16.Stop()
            hora15 = 0
            minuto15 = 0
            segundo15 = 0
        End If
        c = c + 1
        If c = 2 Then
            c = 0
        End If
    End Sub
    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If d = 0 Then
            Button33.BackColor = Color.Red
            'codigo de funcion iniciar aca 
            Button23.Enabled = False
            TextBox23.BackColor = Color.White
            TextBox23.Enabled = False
            Timer24.Enabled = False
            Timer24.Stop()
            hora23 = 0
            minuto23 = 0
            segundo23 = 0
        ElseIf d = 1 Then
            Button33.BackColor = Color.LightGreen
            Button23.Enabled = True
            TextBox23.BackColor = Color.White
            TextBox23.Enabled = True
            Timer24.Enabled = True
            Timer24.Start()

        End If
        d = d + 1
        If d = 2 Then
            d = 0
        End If
    End Sub
    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        '       If f = 0 Then
        'Button34.BackColor = Color.LightGreen
        'codigo de funcion iniciar aca 
        'Button25.Enabled = True
        'TextBox25.BackColor = Color.White
        'TextBox25.Enabled = True
        'Timer26.Enabled = True
        'Timer26.Start()

        'ElseIf f = 1 Then
        'Button34.BackColor = Color.Red
        'Button25.Enabled = False
        'TextBox25.BackColor = Color.White
        'TextBox25.Enabled = False
        'Timer26.Enabled = False
        'Timer26.Stop()
        'hora25 = 0
        'minuto25 = 0
        'segundo25 = 0
        'End If
        'f = f + 1
        'If f = 2 Then
        'f = 0
        'End If
    End Sub
    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        'If g = 0 Then
        'Button35.BackColor = Color.LightGreen
        'codigo de funcion iniciar aca 
        'Button13.Enabled = True
        'TextBox13.BackColor = Color.White
        'TextBox13.Enabled = True
        'Timer14.Enabled = True
        'Timer14.Start()

        '        ElseIf g = 1 Then
        '       Button35.BackColor = Color.Red
        '      Button13.Enabled = False
        '     TextBox13.BackColor = Color.White
        '    TextBox13.Enabled = False
        '   Timer14.Enabled = False
        '  Timer14.Stop()
        ' hora13 = 0
        'minuto13 = 0
        'segundo13 = 0
        'End If
        'g = g + 1
        'If g = 2 Then
        'g = 0
        'End If
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click

        If h = 0 Then
            Button49.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button17.Enabled = True
            TextBox17.BackColor = Color.White
            TextBox17.Enabled = True
            Timer18.Enabled = True
            Timer18.Start()

        ElseIf h = 1 Then
            Button49.BackColor = Color.Red
            Button17.Enabled = False
            TextBox17.BackColor = Color.White
            TextBox17.Enabled = False
            Timer18.Enabled = False
            Timer18.Stop()
            hora17 = 0
            minuto17 = 0
            segundo17 = 0
        End If
        h = h + 1
        If h = 2 Then
            h = 0
        End If
    End Sub
    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        If i = 0 Then
            Button53.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button21.Enabled = True
            TextBox21.BackColor = Color.White
            TextBox21.Enabled = True
            Timer22.Enabled = True
            Timer22.Start()

        ElseIf i = 1 Then
            Button53.BackColor = Color.Red
            Button21.Enabled = False
            TextBox21.BackColor = Color.White
            TextBox21.Enabled = False
            Timer22.Enabled = False
            Timer22.Stop()
            hora21 = 0
            minuto21 = 0
            segundo21 = 0
        End If
        i = i + 1
        If i = 2 Then
            i = 0
        End If
    End Sub
    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        If j = 0 Then
            Button54.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button24.Enabled = True
            TextBox24.BackColor = Color.White
            TextBox24.Enabled = True
            Timer25.Enabled = True
            Timer25.Start()

        ElseIf j = 1 Then
            Button54.BackColor = Color.Red
            Button24.Enabled = False
            TextBox24.BackColor = Color.White
            TextBox24.Enabled = False
            Timer25.Enabled = False
            Timer25.Stop()
            hora24 = 0
            minuto24 = 0
            segundo24 = 0
        End If
        j = j + 1
        If j = 2 Then
            j = 0
        End If
    End Sub
   
    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        If k = 0 Then
            Button51.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button19.Enabled = True
            TextBox19.BackColor = Color.White
            TextBox19.Enabled = True
            Timer20.Enabled = True
            Timer20.Start()

        ElseIf k = 1 Then
            Button51.BackColor = Color.Red
            Button19.Enabled = False
            TextBox19.BackColor = Color.White
            TextBox19.Enabled = False
            Timer20.Enabled = False
            Timer20.Stop()
            hora19 = 0
            minuto19 = 0
            segundo19 = 0
        End If
        k = k + 1
        If k = 2 Then
            k = 0
        End If
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        If l = 0 Then
            Button52.BackColor = Color.LightGreen
            'codigo de funcion iniciar aca 
            Button20.Enabled = True
            TextBox20.BackColor = Color.White
            TextBox20.Enabled = True
            Timer21.Enabled = True
            Timer21.Start()

        ElseIf l = 1 Then
            Button52.BackColor = Color.Red
            Button20.Enabled = False
            TextBox20.BackColor = Color.White
            TextBox20.Enabled = False
            Timer21.Enabled = False
            Timer21.Stop()
            hora20 = 0
            minuto20 = 0
            segundo20 = 0
        End If
        l = l + 1
        If l = 2 Then
            l = 0
        End If
    End Sub


   
    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Ingreso_manual.Show()

    End Sub
End Class
