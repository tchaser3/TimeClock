'Title:         CreateID
'Date:          5-12-15
'Author;        Terry Holmes

'Description:   This form will create all ids

Option Strict On

Public Class CreateID

    'Setting global variables
    Private TheCreateIDDataSet As CreateIDDataSet
    Private TheCreateIDDataTier As TimeClockDataTier
    Private WithEvents TheCreateIDBindingSource As BindingSource

    Private Sub CreateID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intNewID As Integer

        Try

            'Setting data variables
            TheCreateIDDataTier = New TimeClockDataTier
            TheCreateIDDataSet = TheCreateIDDataTier.GetCreateIDInformation
            TheCreateIDBindingSource = New BindingSource

            'setting up the binding source
            With TheCreateIDBindingSource
                .DataSource = TheCreateIDDataSet
                .DataMember = "createid"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheCreateIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheCreateIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtCreatedTransactionID.DataBindings.Add("text", TheCreateIDBindingSource, "CreatedTransactionID")

            'creating new id
            intNewID = CInt(txtCreatedTransactionID.Text)
            intNewID += 1
            Form1.mintCreatedID = intNewID
            txtCreatedTransactionID.Text = CStr(intNewID)

            'Saving the id
            TheCreateIDBindingSource.EndEdit()
            TheCreateIDDataTier.UpdateCreateIDDB(TheCreateIDDataSet)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class