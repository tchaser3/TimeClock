'Title:         Time Clock Application
'Date:          5-11-15
'Author:        Terry Holmes

'Description:   This is a time clock application

Option Strict On

Public Class Form1

    'setting up global variables
    Friend mstrErrorMessage As String
    Friend mintCreatedID As Integer
    Dim mstrTimeInOrOut As String

    'Setting up the data variables
    Private TheEmployeesDataSet As EmployeeDataSet
    Private TheEmployeesDataTier As EmployeeDataTier
    Private WithEvents TheEmployeesBindingSource As BindingSource

    Private TheTimeEntryDataSet As TimeEntryDataSet
    Private TheTimeEntryDataTier As TimeClockDataTier
    Private WithEvents TheTimeEntryBindingSource As BindingSource

    'Setting up the classes
    Dim TheInputDataValidation As New InputDataValidation

    'Setting up global variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub SetComboBoxBinding()
        With cboTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will call the close program form
        CloseProgram.ShowDialog()

    End Sub

    Private Sub rbtTimeOut_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTimeOut.CheckedChanged

        'This will set the global variable
        mstrTimeInOrOut = "OUT"

    End Sub

    Private Sub rbtTimeIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTimeIn.CheckedChanged

        'This will set the global variable
        mstrTimeInOrOut = "IN"

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            TheEmployeesDataTier = New EmployeeDataTier
            TheEmployeesDataSet = TheEmployeesDataTier.GetEmployeeInformation
            TheEmployeesBindingSource = New BindingSource

            TheTimeEntryDataTier = New TimeClockDataTier
            TheTimeEntryDataSet = TheTimeEntryDataTier.GetTimeEntryInformation
            TheTimeEntryBindingSource = New BindingSource

            With TheEmployeesBindingSource
                .DataSource = TheEmployeesDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            With TheTimeEntryBindingSource
                .DataSource = TheTimeEntryDataSet
                .DataMember = "timeentry"
                .MoveFirst()
                .MoveLast()
            End With

            With cboEmployeeID
                .DataSource = TheEmployeesBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("text", TheEmployeesBindingSource, "EmployeeID", False, DataSourceUpdateMode.Never)
            End With

            With cboTransactionID
                .DataSource = TheTimeEntryBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheTimeEntryBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtFirstName.DataBindings.Add("text", TheEmployeesBindingSource, "FirstName")
            txtLastName.DataBindings.Add("text", TheEmployeesBindingSource, "LastName")
            txtActive.DataBindings.Add("text", TheEmployeesBindingSource, "Active")
            lblTestValue.DataBindings.Add("text", TheEmployeesBindingSource, "EmployeeID")
            txtType.DataBindings.Add("text", TheEmployeesBindingSource, "Type")

            txtTransactionEmployeeID.DataBindings.Add("text", TheTimeEntryBindingSource, "EmployeeID")
            txtTransactionInOrOut.DataBindings.Add("text", TheTimeEntryBindingSource, "InOrOut")
            txtTransactionTime.DataBindings.Add("text", TheTimeEntryBindingSource, "Time")

            SetControlsVisible(False)
            rbtTimeIn.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtEmployeeID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeID.KeyDown

        'This will run if the Enter Key is press
        If e.KeyCode = Keys.Enter Then
            txtLogonLastName.Focus()
        End If

    End Sub

    Private Sub txtLogonLastName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogonLastName.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogTime.PerformClick()
        End If

    End Sub
    Private Sub SetControlsVisible(ByVal valueBoolean As Boolean)

        'This will set the controls visible
        lblTestValue.Visible = valueBoolean
        cboEmployeeID.Visible = valueBoolean
        cboTransactionID.Visible = valueBoolean
        txtActive.Visible = valueBoolean
        txtFirstName.Visible = valueBoolean
        txtLastName.Visible = valueBoolean
        txtTransactionEmployeeID.Visible = valueBoolean
        txtTransactionInOrOut.Visible = valueBoolean
        txtTransactionTime.Visible = valueBoolean

    End Sub

    Private Sub btnLogTime_Click(sender As Object, e As EventArgs) Handles btnLogTime.Click

        'setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim intSelectedIndex As Integer
        Dim intEmployeeIDForSearch As Integer
        Dim intEmployeeIDFromTable As Integer
        Dim strLastNameForSearch As String = ""
        Dim strLastNameFromTable As String
        Dim blnFatalError As Boolean = False
        Dim blnEmployeeNotFound As Boolean = True
        Dim strValueForValidation As String
        Dim strMessageHeader As String
        Dim strTimeLogged As String
        Dim logDate As Date = Date.Now

        'Beginning Data Validation
        strValueForValidation = txtEmployeeID.Text
        strMessageHeader = "Employee ID"
        blnFatalError = TheInputDataValidation.VerifyTextData(strValueForValidation)
        If blnFatalError = False Then
            strLastNameForSearch = txtLogonLastName.Text
            strMessageHeader = "Last Name"
            blnFatalError = TheInputDataValidation.VerifyTextData(strLastNameForSearch)
        End If

        'Output to user
        If blnFatalError = True Then
            MessageBox.Show(mstrErrorMessage, strMessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Getting ready for loop
        SetControlsVisible(True)
        intNumberOfRecords = cboEmployeeID.Items.Count - 1
        intEmployeeIDForSearch = CInt(txtEmployeeID.Text)


        'Beginning Loop
        For intCounter = 0 To intNumberOfRecords

            'Incrementing the combo box
            cboEmployeeID.SelectedIndex = intCounter

            'Getting variables
            intEmployeeIDFromTable = CInt(cboEmployeeID.Text)
            strLastNameFromTable = txtLastName.Text

            'if statements
            If intEmployeeIDForSearch = intEmployeeIDFromTable Then
                If strLastNameForSearch = strLastNameFromTable Then

                    'Setting variables
                    intSelectedIndex = intCounter
                    blnEmployeeNotFound = False
                End If
            End If
        Next

        'Output to user
        If blnEmployeeNotFound = True Then
            txtEmployeeID.Text = ""
            txtLogonLastName.Text = ""
            MessageBox.Show("Employee Information Entered Was Not Found", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Setting up for saving the record
        strTimeLogged = CStr(logDate)
        With TheTimeEntryBindingSource
            .EndEdit()
            .AddNew()
        End With

        'Setting up the controls
        addingBoolean = True
        SetComboBoxBinding()
        CreateID.Show()
        cboTransactionID.Text = CStr(mintCreatedID)
        txtTransactionEmployeeID.Text = CStr(intEmployeeIDForSearch)
        txtTransactionTime.Text = strTimeLogged
        txtTransactionInOrOut.Text = mstrTimeInOrOut

        'saving the transaction
        Try
            TheTimeEntryBindingSource.EndEdit()
            TheTimeEntryDataTier.UpdateTimeEntryDB(TheTimeEntryDataSet)
            addingBoolean = False
            editingBoolean = False
            SetComboBoxBinding()
            strMessageHeader = "You Have Logged " + mstrTimeInOrOut
            SetControlsVisible(False)
            txtLogonLastName.Text = ""
            txtEmployeeID.Text = ""
            MessageBox.Show(strMessageHeader, "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
