Public Class Log
    Public title As String
    Public day As Date
    Public rating As Integer
    Public review As String
    Public Sub New(Title, Day, Rating, Review)
        Me.title = Title ' capitalised inputs map to lower case class variables
        Me.day = Day
        Me.rating = Rating
        Me.review = Review
    End Sub
    Public Sub output()
        Form1.Output.Items.Add("You last saw " & title) ' output title
        Form1.Output.Items.Add("on " & day & ".") ' output date
        Form1.Output.Items.Add("You gave it " & rating & " out of 10.") ' output rating

        If review = "" Then ' outputs review or message if there is no review.
            Form1.Output.Items.Add("You did not review this film.")
        Else
            Form1.Output.Items.Add("Your review was:")
            Form1.Output.Items.Add(review)
        End If
    End Sub
End Class
