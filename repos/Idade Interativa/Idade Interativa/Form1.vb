Public Class janela_interativa
    Function cambia(ByVal cambiatext As String) As String
        Dim a As String = StrConv(cambiatext, VbStrConv.ProperCase)
        Return a
    End Function

    Dim nome As String
    Dim idade As Integer

    Private Sub janela_interativa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Batman_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub txt_idade_TextChanged(sender As Object, e As EventArgs) Handles txt_idade.TextChanged

    End Sub

    Private Sub Radio_masc_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_masc.CheckedChanged

    End Sub

    Private Sub Radio_femin_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_femin.CheckedChanged

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Me.txt_nome.Text = cambia(Me.txt_nome.Text)

        nome = txt_nome.Text
        idade = txt_idade.Text

        If idade >= 0 And idade <= 3 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form2.Show()

        ElseIf idade >= 0 And idade <= 3 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form3.Show()

        ElseIf idade >= 4 And idade <= 13 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form4.Show()

        ElseIf idade >= 4 And idade <= 13 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form5.Show()

        ElseIf idade >= 14 And idade <= 18 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form6.Show()

        ElseIf idade >= 14 And idade <= 18 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form7.Show()

        ElseIf idade >= 19 And idade <= 30 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form8.Show()

        ElseIf idade >= 19 And idade <= 30 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form9.Show()

        ElseIf idade >= 31 And idade <= 45 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form10.Show()

        ElseIf idade >= 31 And idade <= 45 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form11.Show()

        ElseIf idade >= 46 And idade <= 59 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form12.Show()


        ElseIf idade >= 46 And idade <= 59 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form13.Show()


        ElseIf idade >= 60 And idade <= 75 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form14.Show()


        ElseIf idade >= 60 And idade <= 75 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form15.Show()


        ElseIf idade >= 76 And idade <= 90 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form16.Show()


        ElseIf idade >= 76 And idade <= 90 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form17.Show()


        ElseIf idade >= 91 And idade <= 120 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form18.Show()


        ElseIf idade >= 91 And idade <= 120 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form19.Show()


        ElseIf idade >= 121 And idade <= 249 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form20.Show()


        ElseIf idade >= 121 And idade <= 249 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form21.Show()

        ElseIf idade >= 250 And idade <= 499 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form22.Show()


        ElseIf idade >= 250 And idade <= 499 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form23.Show()


        ElseIf idade >= 500 And idade <= 699 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form24.Show()


        ElseIf idade >= 500 And idade <= 699 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form25.Show()


        ElseIf idade >= 700 And idade <= 1000 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form26.Show()


        ElseIf idade >= 700 And idade <= 1000 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form27.Show()



        ElseIf idade >= 1001 And idade <= 5000 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form28.Show()


        ElseIf idade >= 1001 And idade <= 5000 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form29.Show()



        ElseIf idade >= 5001 And idade <= 100000000 And Radio_masc.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form30.Show()


        ElseIf idade >= 5001 And idade <= 100000000 And Radio_femin.Checked = True Then
            MessageBox.Show(nome + "!  Clique aqui e veja o que você é!", "Mensagem!")
            Form31.Show()




        End If

    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click

        txt_nome.Text = " "
        txt_idade.Text = " "
        Radio_masc.Checked = False
        Radio_femin.Checked = False

    End Sub

    Private Sub txt_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nome.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_idade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idade.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
