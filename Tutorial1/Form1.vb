Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        ' ファイルを開くダイアログを表示、
        ' ユーザがOKをクリックすると、ユーザが選んだ画像を読み込みます。
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' 画像表示を削除します。
        PictureBox1.Image = Nothing
    End Sub

    Private Sub backgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        ' カラーダイアログボックスを表示します。
        ' ユーザーがOKをクリックしたら、PictureBoxの背景をユーザーが選択した色に変更する。
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        ' フォームを閉じます。
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' ユーザがStretchチェックボックスをオンにした場合、
        ' PictureBoxのSizeModeプロパティを「StretchImage」に変更します。
        ' ユーザーがStretchチェックボックスをオフにした場合、
        ' PictureBoxのSizeModeプロパティを「Normal」に変更します。
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub
End Class
