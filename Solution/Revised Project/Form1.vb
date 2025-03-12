Imports MySql.Data.MySqlClient
Public Class Form1

    Dim connection As New MySqlConnection ' variable for the connection to the sql server

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "server=localhost; username=root; password=database123; database=schema" ' provide information to the database to create connection
        connection.Open() ' starts connection
    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles LogButton.Click
        If LogTitleInput.Text <> "" Then ' checks that title input isn't empty
            Dim log As New Log(LogTitleInput.Text, DateInput.Value, RatingInput.Value, ReviewInput.Text) ' seen is set to 0 initailly before its value can be found from the database
            Call updateDatabaseLogs("logs", log)
        Else
            MsgBox("Title input must not be empty.") ' error message if title input is empty
        End If
    End Sub

    Private Sub updateDatabaseLogs(table As String, log As Log)
        Dim day As String = log.day.ToString() ' converted to string so that it can be concatenated
        day = Mid(day, 7, 4) & "-" & Mid(day, 4, 2) & "-" & Mid(day, 1, 2) ' changeed from vb format to sql format for integration to database

        Dim titleFound As String = ""
        Dim query As String = $"select title from logs where title = '{log.title}'" ' create SQL query to find the number of rows in the database table
        Dim SQLcommand As New MySqlCommand(query, connection)

        Dim reader As MySqlDataReader = SQLcommand.ExecuteReader()

        While reader.Read() ' reads from the database's answer to the query
            titleFound = reader("title") ' read if the title is outputed when askeed for
        End While

        reader.Close() ' close the reader so that another can be openned later

        If titleFound = log.title Then ' decides weather to update existing log or add new log
            Call SendSQLQuery($"UPDATE logs SET dat = '{day}', rating = '{log.rating.ToString()}', review = '{log.review}' WHERE title = '{log.title}';") ' send query to update row to database table
            MsgBox(log.title & " has been updated.") ' output that the log was updated
        Else
            Call SendSQLQuery($"INSERT INTO {table} (title, dat, rating, review) VALUES ('{log.title}', '{day}', '{log.rating.ToString()}', '{log.review}');") ' send query to add row to database table
            MsgBox(log.title & " has been added.") ' output that the log was added
        End If
    End Sub

    Function numberOfRows()
        Dim entries As Integer = 0
        Dim query As String = "SELECT COUNT(id) FROM logs" ' create SQL query to find the number of rows in the database table
        Dim SQLcommand As New MySqlCommand(query, connection) ' send query to database

        Dim reader As MySqlDataReader = SQLcommand.ExecuteReader()

        While reader.Read() ' reads the database's answer to the query
            entries = reader("COUNT(id)") ' finds the number of rows in the database
        End While

        reader.Close() ' close the reader so that another can be openned later

        Return entries
    End Function

    Private Sub SendSQLQuery(instruction)
        Dim SQLcommand As New MySqlCommand(instruction, connection) ' create a command from the instruction and the connection
        Call SQLcommand.ExecuteNonQuery() ' carry out the command
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Output.Items.Clear() ' clears listbox so that new values can be entered

        If SearchTitleInput.Text <> "" Then ' ensures that title input is not left blank
            Dim logs() As Log = readInLogs() ' reads in array of log objects
            Call bubbleSortArray(logs) ' sorts logs by title alphbetically
            Call binarySearchArray(SearchTitleInput.Text, logs) ' finds and outputs the log with the inputted title
        Else
            MsgBox("Title input must not be empty.") ' error message if input is blank
        End If

    End Sub

    Function readInLogs()
        Dim logs(numberOfRows()) As Log ' create array of log_class objects with a size based on the number of rowsa in the database table
        Dim query As String

        For i As Integer = 0 To logs.Length - 1 ' for each row in the database

            query = $"SELECT title, dat, rating, review FROM logs WHERE id={i + 1}" ' query to output the info on the log of the indexed row

            Dim SQLcommand As New MySqlCommand(query, connection) ' sends query to database
            Dim indevidualLog As New Log("", System.DateTime.Now, 0, "") ' initailised indevidual log with default values

            Dim reader As MySqlDataReader = SQLcommand.ExecuteReader() ' sets up reader 

            While reader.Read() 'reads the values outputted by the database

                indevidualLog.title = reader("title") ' reads in the value of each column for the row
                indevidualLog.rating = Int(reader("rating"))
                indevidualLog.review = reader("review")
                indevidualLog.day = Date.Parse(reader("dat")) ' data type has to be changed because of the different way that sql and vb store dates

            End While

            logs(i) = indevidualLog ' adds indevidual log to array before going on to the next
            reader.Close() ' closes reader so that another can be opened later

        Next

        Return logs
    End Function

    Function AlphabeticalAhead(word1, word2) As Boolean
        word1 = word1.ToLower() ' changes both to lower case so that they can be compared on a case-neutral basis
        word2 = word2.ToLower()

        Dim position As Integer = 0
        Dim num1, num2 As Integer

        Do While position < word1.length And position < word2.length

            position = position + 1 ' updates the letter being considered
            num1 = Asc(Mid(word1, position, 1)) ' takes the ascii value of the character in the current position
            num2 = Asc(Mid(word2, position, 1))

            If num1 < num2 Then ' if first word's ascii value is lower then...
                Return True     ' ...return true
            ElseIf num2 < num1 Then ' if first word's ascii value is lower then...
                Return False        ' ...return false
            End If
            ' no else statement so that the loop will keep checking values further into the word until it finds...
            'one that is alphabetically ahead or reaches the end of one of the words
        Loop
        'The code only reaches this point if the end of one of the words has been reached
        If word1.length < word2.length Then ' if the first is shorter
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub bubbleSortArray(logs)
        Dim max As Log
        Dim buffer As Log
        Dim pos As Integer

        For j As Integer = 0 To logs.length - 2
            max = logs(j)
            pos = j
            For i As Integer = j + 1 To logs.length - 1
                If AlphabeticalAhead(logs(i).title, max.title) Then ' if current is ahead of the max
                    max = logs(i) ' replace value of max
                    pos = i
                End If
            Next
            buffer = logs(j) ' swap max and the one that was previously at the front
            logs(j) = max
            logs(pos) = buffer
        Next
    End Sub

    Private Sub binarySearchArray(target, logs)
        Dim min As Integer, max As Integer, mid As Integer
        Dim found As Boolean = False

        min = 0 ' initailises the lower bound at 0 as arrays start at 0
        max = logs.length - 1 ' initailises the upper bound at the size of array -1 as arrays start at 0

        Do While min <= max And found = False

            mid = (min + max) / 2 ' sets the mid to directly in between the two current bounds

            If target = logs(mid).title Then ' if the target is found
                found = True
            ElseIf AlphabeticalAhead(target, logs(mid).title) Then ' if mid is too high
                max = mid
            Else
                min = mid
            End If

        Loop

        If Found = True Then
            logs(mid).output() ' outputs correct log
        Else
            MsgBox("The log was not found. Check that the title is spelt correctly.") ' error message if log isn't found
        End If
    End Sub
End Class
