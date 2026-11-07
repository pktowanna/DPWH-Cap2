Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class AddStock



    Dim con As New MySqlConnection(GlobalConnectionString)

    Private Sub ClearFields()
        addstockstocknolbl.Text = ""
        addstockquantitytxt.Clear()
        addstockreorderpointtxt.Clear()
        addstockdatedtp.Value = DateTime.Now
    End Sub

    Private Sub addstockfinishbtn_Click(sender As Object, e As EventArgs) Handles addstockfinishbtn.Click
        If String.IsNullOrWhiteSpace(addstockstocknolbl.Text) OrElse
   String.IsNullOrWhiteSpace(addstockquantitytxt.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Dim nextStockId As Integer = 1
            Using cmdCheck As New MySqlCommand("SELECT IFNULL(MAX(stockid), 0) + 1 FROM supplystock WHERE stockno = @stockno", con)
                cmdCheck.Parameters.AddWithValue("@stockno", addstockstocknolbl.Text)
                nextStockId = Convert.ToInt32(cmdCheck.ExecuteScalar())
            End Using

            Dim insertQuery As String = "
        INSERT INTO supplystock (stockid, stockno, qtybalance, receiptqty, supplystockdate, reorderpoint, office)
        VALUES (@stockid, @stockno, @qtybalance, @receiptqty, @date, @reorderpoint, @office);
    "

            Using cmd As New MySqlCommand(insertQuery, con)
                cmd.Parameters.AddWithValue("@stockid", nextStockId)
                cmd.Parameters.AddWithValue("@stockno", addstockstocknolbl.Text)
                cmd.Parameters.AddWithValue("@qtybalance", addstockquantitytxt.Text)
                cmd.Parameters.AddWithValue("@receiptqty", addstockquantitytxt.Text)
                cmd.Parameters.AddWithValue("@date", addstockdatedtp.Value)
                cmd.Parameters.AddWithValue("@reorderpoint", addstockreorderpointtxt.Text)
                cmd.Parameters.AddWithValue("@office", "Supply Unit")
                cmd.ExecuteNonQuery()
            End Using

            Dim totalBalance As Decimal = 0
            Using cmdSum As New MySqlCommand("SELECT IFNULL(SUM(qtybalance), 0) FROM supplystock WHERE stockno = @stockno", con)
                cmdSum.Parameters.AddWithValue("@stockno", addstockstocknolbl.Text)
                totalBalance = Convert.ToDecimal(cmdSum.ExecuteScalar())
            End Using

            Using cmdUpdate As New MySqlCommand("UPDATE supply SET supplybalance = @balance WHERE stockno = @stockno", con)
                cmdUpdate.Parameters.AddWithValue("@balance", totalBalance)
                cmdUpdate.Parameters.AddWithValue("@stockno", addstockstocknolbl.Text)
                cmdUpdate.ExecuteNonQuery()
            End Using

            MessageBox.Show("Stock added and total balance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearFields()
            RefreshLowStock(Dashboard)
            RefreshZeroStock(Dashboard)
            RefreshInsufficientRequestedSupply(Dashboard)
            LoadSupplyAndMaterials(Dashboard)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub



    Private Sub addstockcancelbtn_Click(sender As Object, e As EventArgs) Handles addstockcancelbtn.Click
        If String.IsNullOrWhiteSpace(addstockquantitytxt.Text) AndAlso
           String.IsNullOrWhiteSpace(addstockreorderpointtxt.Text) Then
            Me.Close()
        Else
            Dim result = MessageBox.Show("Are you sure you want to exit? Fields will be cleared.", "Confirm Exit",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ClearFields()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub AddStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class