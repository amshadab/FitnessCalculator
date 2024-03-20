Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gender As String
        If RadioButton1.Checked Then
            gender = "M"
        ElseIf RadioButton2.Checked Then
            gender = "F"
        Else
            MessageBox.Show("Please enter your Gender!")
            Return
        End If

        Dim age As Integer
        If Not Integer.TryParse(TextBox1.Text, age) Then
            MessageBox.Show("Please enter a valid age!")
            Return
        End If

        Dim weight As Double
        If Not Double.TryParse(TextBox2.Text, weight) Then
            MessageBox.Show("Please enter a valid weight.")
            Return
        End If

        Dim height As Double
        If Not Double.TryParse(TextBox3.Text, height) Then
            MessageBox.Show("Please enter a valid height.")
            Return
        End If

        Dim bmr As Double
        If gender = "M" Then
            bmr = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age)
        ElseIf gender = "F" Then
            bmr = 447.593 + (9.247 * weight) + (3.098 * height) - (4.33 * age)
        End If

        TextBox7.Text = bmr

        Dim tdee As Double
        If ComboBox1.SelectedIndex = 0 Then
            tdee = bmr * 1.2
        ElseIf ComboBox1.SelectedIndex = 1 Then
            tdee = bmr * 1.55
        ElseIf ComboBox1.SelectedIndex = 2 Then
            tdee = bmr * 1.9
        Else
            MessageBox.Show("Please select Activity level!")
            Return
        End If

        TextBox4.Text = tdee ' Assign TDEE to TextBox4

        ' Correct the calculation for Calories Intake per Day
        Dim calorie As Double = tdee + 500
        TextBox6.Text = calorie ' Assign calories to TextBox6

        ' Correct the calculation for Protein Intake
        Dim protein As Double = weight * 2.2
        TextBox5.Text = protein
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ComboBox1.Items.Add("Sedentary")
        ComboBox1.Items.Add("Moderate")
        ComboBox1.Items.Add("Active")
    End Sub


End Class
