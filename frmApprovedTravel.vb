' Program Name: Intuition Approved Travel Windows Application
' Author:       Trevor Anthony Bowling
' Date:         March 26, 2014
' Purpose:      The Approved Travel Requests Windows Application opens an
'               Access database with the approved company travel requests in
'               a Windows form. The datbase can be viewed, updated, and
'               deleted. The application also computes the total of the
'               travel costs that have been entered into the database.

Option Strict On

Public Class frmApprovedTravel

    Private Sub ApprovedTravelRequestsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovedTravelRequestsBindingNavigatorSaveItem.Click
        ' This click event is created by the database wizard

        Me.Validate()
        Me.ApprovedTravelRequestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TravelDataSet)

    End Sub

    Private Sub frmApprovedTravel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The database wizard creates this method
        ' The Try Catch block catches an exception caused by a missing database file

        Try
            'TODO: This line of code loads data into the 'TravelDataSet.ApprovedTravelRequests' table. You can move, or remove it, as needed.
            Me.ApprovedTravelRequestsTableAdapter.Fill(Me.TravelDataSet.ApprovedTravelRequests)
        Catch ex As Exception
            MsgBox("The Database File is Unavailable.", , "Error")
            Close()
        End Try

    End Sub

    Private Sub btnTotalTravelCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalTravelCost.Click
        ' strSql is a SQL statement that select all the fields from the
        ' ApprovedTavelRequests table

        Dim strSql As String = "SELECT * FROM ApprovedTravelRequests"

        ' strPath provides the database type and path of the Travel database 
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" _
            & "Data Source = G:\Travel.accdb"
        Dim odaTravel As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datCost As New DataTable
        Dim intCount As Integer
        Dim decTotalCost As Decimal = 0D

        ' The Datatable name datCost is filled with the table data
        odaTravel.Fill(datCost)
        ' The connection to the database is disconnected 
        odaTravel.Dispose()
        For intCount = 0 To datCost.Rows.Count - 1
            decTotalCost += Convert.ToDecimal(datCost.Rows(intCount)("Travel Cost"))
        Next
        lblTotalTravelCost.Visible = True
        lblTotalTravelCost.Text = "The Total Approved Travel Cost is " _
            & decTotalCost.ToString("C")
    End Sub

End Class
