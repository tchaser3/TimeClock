'Title:         Time Clock Data Tier
'Date:          5-12-15
'Author:        Terry Holmes

'Description:   This class is the data tier

Option Strict On

Public Class TimeClockDataTier

    'Setting up the variables
    Private aTimeEntryDataSetTableAdpaters As TimeEntryDataSetTableAdapters.timeentryTableAdapter
    Private aTimeEntryDataSet As TimeEntryDataSet

    Private aTimeEntryAdjustmentDataSetTableAdapters As TimeEntryAdjustmentDataSetTableAdapters.timeentryadjustmentTableAdapter
    Private aTimeEntryAdjustmentDataSet As TimeEntryAdjustmentDataSet

    Private aCreateIDDataSetTableAdpaters As CreateIDDataSetTableAdapters.createidTableAdapter
    Private aCreateIDDataSet As CreateIDDataSet

    Public Function GetTimeEntryInformation() As TimeEntryDataSet

        'Setting up the Datatier
        Try
            aTimeEntryDataSet = New TimeEntryDataSet
            aTimeEntryDataSetTableAdpaters = New TimeEntryDataSetTableAdapters.timeentryTableAdapter
            aTimeEntryDataSetTableAdpaters.Fill(aTimeEntryDataSet.timeentry)
            Return aTimeEntryDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aTimeEntryDataSet
        End Try
    End Function

    Public Sub UpdateTimeEntryDB(ByVal aTimeEntryDataSet As TimeEntryDataSet)

        'This will update the database
        Try
            aTimeEntryDataSetTableAdpaters.Update(aTimeEntryDataSet.timeentry)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetTimeEntryAdjustmentInformation() As TimeEntryAdjustmentDataSet

        'Setting up the Datatier
        Try
            aTimeEntryAdjustmentDataSet = New TimeEntryAdjustmentDataSet
            aTimeEntryAdjustmentDataSetTableAdapters = New TimeEntryAdjustmentDataSetTableAdapters.timeentryadjustmentTableAdapter
            aTimeEntryAdjustmentDataSetTableAdapters.Fill(aTimeEntryAdjustmentDataSet.timeentryadjustment)
            Return aTimeEntryAdjustmentDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aTimeEntryAdjustmentDataSet
        End Try
    End Function

    Public Sub UpdateTimeEntryAdjustmentDB(ByVal aTimeEntryAdjustmentDataSet As TimeEntryAdjustmentDataSet)

        'This will update the database
        Try
            aTimeEntryAdjustmentDataSetTableAdapters.Update(aTimeEntryAdjustmentDataSet.timeentryadjustment)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetCreateIDInformation() As CreateIDDataSet

        'Setting up the Datatier
        Try
            aCreateIDDataSet = New CreateIDDataSet
            aCreateIDDataSetTableAdpaters = New CreateIDDataSetTableAdapters.createidTableAdapter
            aCreateIDDataSetTableAdpaters.Fill(aCreateIDDataSet.createid)
            Return aCreateIDDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCreateIDDataSet
        End Try
    End Function

    Public Sub UpdateCreateIDDB(ByVal aCreateIDDataSet As CreateIDDataSet)

        'This will update the database
        Try
            aCreateIDDataSetTableAdpaters.Update(aCreateIDDataSet.createid)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
