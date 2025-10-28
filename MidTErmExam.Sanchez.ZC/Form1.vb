Public Class Form1

    Dim artworks As New List(Of Artwork)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddWork.Click
        Try
            If txtArtworkTitle.Text = "" Or txtArtistName.Text = "" Or cmbArtworkCategory.SelectedIndex = -1 Or nudArtworkPrice.Text = "" Then
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim art As New Artwork With {
            .Title = txtArtistName.Text,
            .Artist = txtArtistName.Text,
            .Price = Decimal.Parse(nudArtworkPrice.Text),
            .Category = cmbArtworkCategory.Text
        }

            artworks.Add(art)

            lstArtworks.Items.Add($"{art.Title} - {art.Artist} - {art.Category} - ₱{art.Price}")

            txtTitle.Clear()
            txtArtist.Clear()
            txtPrice.Clear()
            cboCategory.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Invalid input.")
        End Try
    End Sub

    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        If artworks.Count = 0 Then
            MessageBox.Show("No artworks to analyze.")
            Exit Sub
        End If

        Dim total = artworks.Count
        Dim avg = artworks.Average(Function(a) a.Price)
        Dim high = artworks.OrderByDescending(Function(a) a.Price).First()
        Dim low = artworks.OrderBy(Function(a) a.Price).First()
        Dim groupData = artworks.GroupBy(Function(a) a.Category).Select(Function(g) $"{g.Key}: {g.Count()}")

        txtResult.Text =
        $"Total Artworks: {total}" & vbCrLf &
        $"Average Price: ₱{avg:N2}" & vbCrLf &
        $"Highest: {high.Title} by {high.Artist} (₱{high.Price})" & vbCrLf &
        $"Lowest: {low.Title} by {low.Artist} (₱{low.Price})" & vbCrLf &
        $"Category Breakdown: {String.Join(", ", groupData)}"
    End Sub



    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click
        artworks.Clear()
        lstArtworks.Items.Clear()
        txtResult.Clear()
    End Sub
End Class

Public Class Artwork
    Public Property Title As String
    Public Property Artist As String
    Public Property Price As Decimal
    Public Property Category As String
End Class
