Imports System.Xml
Imports System.Xml.Linq
Imports System.Security.Cryptography
Public Class frmCode
    Dim UsedHelps1 As Integer = 0
    Dim UsedHelps2 As Integer = 0
    Dim UsedHelps3 As Integer = 0
    Public Password As String = ""

    Dim Program As Integer = 1
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub
    Public Sub frmCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_MRN_HintsDataSet.tblCode' table. You can move, or remove it, as needed.
        Me.TblCodeTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblCode)
        'TODO: This line of code loads data into the '_2016_MRN_HintsDataSet.tblCode' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        UsedHelps1 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(1, 2)
        UsedHelps2 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1)
        UsedHelps3 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 2)
        tspHelpsUsed.Maximum = 3
    End Sub
    Private Sub frmCode_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).IsLoggedIn = False

        Try
            Me.Validate()
            Me.TblUserBindingSource.EndEdit()
            Me.TblCodeBindingSource.EndEdit()
            Me.MRNHintsDataSetBindingSource.EndEdit()
            Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
            Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click
        _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).IsLoggedIn = False

        Try
            Me.Validate()
            Me.TblUserBindingSource.EndEdit()
            Me.TblCodeBindingSource.EndEdit()
            Me.MRNHintsDataSetBindingSource.EndEdit()
            Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
            Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try

        Me.Visible = False
        frmLogin.resetDeets()
        frmLogin.Visible = True
    End Sub
    Function UpdatePassword()
        'hash the password and stuff
        Dim wrapper As New SimpleAES(Password & _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).Username)
        Try
            Password = wrapper.EncryptData(Password & _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).Username)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        'Bin_SUPrADataSet_Student.tblStudent(0).Password = Password
        For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
            If _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).Username = _2016_MRN_HintsDataSet.tblUser(index).Username.Trim() Then
                _2016_MRN_HintsDataSet.tblUser(index).Password = Password
            End If
        Next
        Try
            Me.Validate()
            Me.TblUserBindingSource.EndEdit()
            Me.MRNHintsDataSetBindingSource.EndEdit()
            Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try
        Return 0
    End Function

    Private Sub cmdChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangePassword.Click
        ChangePassword.Show()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub cmdMoreCode_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoreCode_1.Click
        Me.TblCodeTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblCode)
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        UsedHelps1 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(1, 2)
        UsedHelps2 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1)
        UsedHelps3 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 2)

        tspHelpsUsed.Value = UsedHelps1
        lblUsedHelp.Text = "Used Helps: [" & UsedHelps1 & "]"
        If UsedHelps1 < 3 Then
            gbConfirm_1.Visible = True
        Else
            cmdMoreCode_1.Enabled = False
        End If
    End Sub
    Private Sub cmdConfirm_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm_1.Click
        If UsedHelps1 < 3 Then
            UsedHelps1 += 1
            tspHelpsUsed.Value = UsedHelps1
            lblUsedHelp.Text = "Used Helps: [" & UsedHelps1 & "]"
        End If

        Select Case UsedHelps1
            Case 1
                txtCode_1.Rtf = System.Text.Encoding.UTF8.GetString(_2016_MRN_HintsDataSet.tblCode(0).Code)
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (100 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 2
                txtCode_1.Rtf = _2016_MRN_HintsDataSet.tblCode(1).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (100 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 3
                txtCode_1.Rtf = _2016_MRN_HintsDataSet.tblCode(2).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (100 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
        End Select
        gbConfirm_1.Visible = False
    End Sub

    Private Sub cmdMoreCode_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoreCode_2.Click
        Me.TblCodeTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblCode)
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        UsedHelps1 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(1, 2)
        UsedHelps2 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1)
        UsedHelps3 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 2)

        tspHelpsUsed.Value = UsedHelps2
        lblUsedHelp.Text = "Used Helps: [" & UsedHelps2 & "]"
        If UsedHelps2 < 3 Then
            gbConfirm_2.Visible = True
        Else
            cmdMoreCode_2.Enabled = False
        End If
    End Sub
    Private Sub cmdConfirm_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm_2.Click
        If UsedHelps2 < 3 Then
            UsedHelps2 += 1
            tspHelpsUsed.Value = UsedHelps2
            lblUsedHelp.Text = "Used Helps: [" & UsedHelps2 & "]"
        End If

        Select Case UsedHelps2
            Case 1
                txtCode_2.Rtf = _2016_MRN_HintsDataSet.tblCode(3).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (10 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 2
                txtCode_2.Rtf = _2016_MRN_HintsDataSet.tblCode(4).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (10 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 3
                txtCode_2.Rtf = _2016_MRN_HintsDataSet.tblCode(5).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (10 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
        End Select
        gbConfirm_2.Visible = False
    End Sub
    Private Sub cmdCancel_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_2.Click
        gbConfirm_2.Visible = False
    End Sub

    Private Sub cmdMoreCode_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoreCode_3.Click
        Me.TblCodeTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblCode)
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        UsedHelps1 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(1, 2)
        UsedHelps2 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1)
        UsedHelps3 = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests.Trim.Remove(0, 2)

        tspHelpsUsed.Value = UsedHelps3
        lblUsedHelp.Text = "Used Helps: [" & UsedHelps3 & "]"
        If UsedHelps3 < 3 Then
            gbConfirm_3.Visible = True
        Else
            cmdMoreCode_3.Enabled = False
        End If
    End Sub
    Private Sub cmdConfirm_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm_3.Click
        If UsedHelps3 < 3 Then
            UsedHelps3 += 1
            tspHelpsUsed.Value = UsedHelps3
            lblUsedHelp.Text = "Used Helps: [" & UsedHelps3 & "]"
        End If

        Select Case UsedHelps3
            Case 1
                txtCode_3.Rtf = _2016_MRN_HintsDataSet.tblCode(6).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (1 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 2
                txtCode_3.Rtf = _2016_MRN_HintsDataSet.tblCode(7).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (1 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
            Case 3
                txtCode_3.Text = _2016_MRN_HintsDataSet.tblCode(8).Code.ToString
                _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests = (1 + Val(_2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).CodeRequests))
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.TblCodeBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                    Me.TblCodeTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblCode)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try
        End Select
        gbConfirm_3.Visible = False
    End Sub
    Private Sub cmdCancel_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_3.Click
        gbConfirm_3.Visible = False
    End Sub
End Class
