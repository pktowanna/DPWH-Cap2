Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports QRCoder
Imports System.Text
Imports modulecodes
Imports System.IO
Imports System.Configuration
Imports System.Diagnostics

Public Class supplystockcard

    Public Sub LoadStockCardData()
        Dim connString As String = (GlobalConnectionString)

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim stockNo As String = stocknumberlbl.Text.Trim()

                Dim supplyQuery As String = "
                SELECT item, description, unit 
                FROM supply 
                WHERE stockno = @stockno
            "

                Using cmd As New MySqlCommand(supplyQuery, conn)
                    cmd.Parameters.AddWithValue("@stockno", stockNo)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            itemlbl.Text = reader("item").ToString()
                            descriptionlbl.Text = reader("description").ToString()
                            unitlbl.Text = reader("unit").ToString()
                        Else
                            itemlbl.Text = ""
                            descriptionlbl.Text = ""
                            unitlbl.Text = ""
                        End If
                    End Using
                End Using

                stockcardsdgv.Rows.Clear()

                Dim stockQuery As String = "
                SELECT 
                    ss.stockid AS supplyid,
                    COALESCE(
                        (
                            SELECT qtybalance 
                            FROM supplystock s2 
                            WHERE s2.stockid = ss.stockid
                              AND s2.stockno = ss.stockno
                            ORDER BY s2.supplystockid DESC 
                            LIMIT 1
                        ), 0
                    ) AS currentbalance, 
                    (
                        SELECT supplystockdate 
                        FROM supplystock s3 
                        WHERE s3.stockid = ss.stockid
                          AND s3.stockno = ss.stockno
                        ORDER BY s3.supplystockid ASC 
                        LIMIT 1
                    ) AS dateadded
                FROM supplystock ss
                WHERE ss.stockno = @stockno
                GROUP BY ss.stockid, ss.stockno
                ORDER BY ss.stockid ASC
            "

                Using cmd As New MySqlCommand(stockQuery, conn)
                    cmd.Parameters.AddWithValue("@stockno", stockNo)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim supplyid As String = reader("supplyid").ToString()

                            Dim currentbalance As Integer = 0
                            If Not IsDBNull(reader("currentbalance")) Then
                                Integer.TryParse(reader("currentbalance").ToString(), currentbalance)
                            End If

                            Dim dateaddedValue As String = ""
                            If Not IsDBNull(reader("dateadded")) Then
                                Dim dateValue As DateTime
                                If DateTime.TryParse(reader("dateadded").ToString(), dateValue) Then
                                    dateaddedValue = dateValue.ToString("yyyy-MM-dd")
                                End If
                            End If

                            stockcardsdgv.Rows.Add(supplyid, currentbalance.ToString(), dateaddedValue, "View")
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading stock card data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub supplystockcardbackbtn_Click(sender As Object, e As EventArgs) Handles supplystockcardbackbtn.Click
        Me.Close()
    End Sub

    Private Sub stockcardsdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockcardsdgv.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim columnName As String = stockcardsdgv.Columns(e.ColumnIndex).Name

        If columnName = "viewstockcard" Then
            Try
                Dim ds As New DataSet()
                ds.STOCKCARDdatatable.Clear()
                ds.STOCKCARDgrid.Clear()

                Dim headerRow As DataSet.STOCKCARDdatatableRow = ds.STOCKCARDdatatable.NewSTOCKCARDdatatableRow()
                headerRow.stockcarditem = itemlbl.Text.Trim()
                headerRow.stockcarddescription = descriptionlbl.Text.Trim()
                headerRow.stockcardunitofmeasure = unitlbl.Text.Trim()
                headerRow.stockcardstocknumber = stocknumberlbl.Text.Trim()

                Dim selectedStockId As String = stockcardsdgv.Rows(e.RowIndex).Cells("supplyid").Value.ToString()
                headerRow.stockcardstockid = selectedStockId

                Dim reorderPoint As String = ""
                Dim connString As String = (GlobalConnectionString)
                Using con As New MySqlConnection(connString)
                    con.Open()
                    Dim query As String = "SELECT reorderpoint FROM supplystock WHERE stockid = @stockid ORDER BY supplystockid ASC LIMIT 1"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@stockid", selectedStockId)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing Then reorderPoint = result.ToString()
                    End Using
                End Using
                headerRow.stockcardreorderpoint = reorderPoint
                ds.STOCKCARDdatatable.Rows.Add(headerRow)

                Using con As New MySqlConnection(connString)
                    con.Open()
                    Dim query As String = "
                    SELECT supplystockdate, risnumber, qtyrequest, qtybalance, office, noofdaystoconsume, receiptqty
                    FROM supplystock
                    WHERE stockid = @stockid
                      AND stockno = @stockno
                    ORDER BY supplystockid ASC"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@stockid", selectedStockId)
                        cmd.Parameters.AddWithValue("@stockno", stocknumberlbl.Text.Trim())

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            Dim firstRow As Boolean = True
                            While reader.Read()
                                Dim gridRow As DataSet.STOCKCARDgridRow = ds.STOCKCARDgrid.NewSTOCKCARDgridRow()

                                Dim rawDate As Object = reader("supplystockdate")
                                gridRow.scdate = If(IsDBNull(rawDate), "", Convert.ToDateTime(rawDate).ToString("yyyy-MM-dd"))

                                gridRow.screference = reader("risnumber").ToString()

                                If firstRow Then
                                    gridRow.screceiptqty = reader("receiptqty").ToString()
                                    firstRow = False
                                Else
                                    gridRow.screceiptqty = ""
                                End If

                                gridRow.screquestedqty = reader("qtyrequest").ToString()
                                gridRow.scoffice = reader("office").ToString()
                                gridRow.scbalanceqty = reader("qtybalance").ToString()
                                gridRow.scnoofdaystoconsume = reader("noofdaystoconsume").ToString()

                                ds.STOCKCARDgrid.Rows.Add(gridRow)
                            End While
                        End Using
                    End Using
                End Using

                Dim report As New StockCard()
                report.SetDataSource(ds)

                Dim viewer As New CRViewer()
                viewer.CrystalReportViewer1.ReportSource = report
                viewer.CrystalReportViewer1.Refresh()
                viewer.ShowDialog()

            Catch ex As Exception
                MessageBox.Show("Error generating Stock Card report: " & ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class