Public NotInheritable Class info

    Private Sub info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = " Esta aplicacion es un aporte gratuito a operacion intermodal "
        Me.LabelCompanyName.Text = "METRO S.A."
        Me.TextBoxDescription.Text = "Software desarrollado por Rodrigo Vilchez Fernandez  E-Mail: rvilchezfernandez@gmail.com"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelProductName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelProductName.Click

    End Sub

    Private Sub LabelCompanyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub LabelCopyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelCopyright.Click

    End Sub

    Private Sub TextBoxDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxDescription.TextChanged

    End Sub
End Class
