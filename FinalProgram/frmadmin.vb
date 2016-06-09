Imports System.Security.Cryptography
Imports System.Text

Public Class frmAdmin
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
    Dim AutoRefresh As Boolean = False

    Public rdo_count1_used As Integer = 0
    Public rdo_count2_used As Integer = 0
    Public rdo_count3_used As Integer = 0
    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Shown
        'TODO: This line of code loads data into the '_2016_MRN_HintsDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        'TODO: This line of code loads data into the '_2016_MRN_HintsDataSet.tblCode' table. You can move, or remove it, as needed.
        Me.TblCodeTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblCode)
        loadstuff()
    End Sub
    Function loadstuff()
        lstStudents_program1.Items.Clear()
        lstStudents_program2.Items.Clear()
        lstStudents_program3.Items.Clear()
        lstBoxStudents.Items.Clear()
        For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
            Try
                lstStudents_program1.Items.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                lstStudents_program2.Items.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                lstStudents_program3.Items.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                lstBoxStudents.Items.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
            Catch ex As Exception
                'throw error
                MsgBox("Error: " & ex.Message)
            End Try
        Next
        Return 0
    End Function
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
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
    Function showPRG3()
        lstStudents_program3.SelectedItems.Clear()
        Select Case rdo_count3_used
            Case 0
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 2) = 0) Then
                            lstStudents_program3.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 1
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 2) = 1) Then
                            lstStudents_program3.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 2
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 2) = 2) Then
                            lstStudents_program3.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 3
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 2) = 3) Then
                            lstStudents_program3.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case Else
        End Select
        Return 0
    End Function
    Function showPRG2()
        lstStudents_program2.SelectedItems.Clear()
        Select Case rdo_count2_used
            Case 0
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1) = 0) Then
                            lstStudents_program2.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 1
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1) = 1) Then
                            lstStudents_program2.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 2
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1) = 2) Then
                            lstStudents_program2.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 3
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(0, 1).Trim.Remove(1, 1) = 3) Then
                            lstStudents_program2.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case Else
        End Select
        Return 0
    End Function
    Function showPRG1()
        lstStudents_program1.SelectedItems.Clear()
        Select Case rdo_count1_used
            Case 0
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(1, 2) = 0) Then
                            lstStudents_program1.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 1
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(1, 2) = 1) Then
                            lstStudents_program1.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 2
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(1, 2) = 2) Then
                            lstStudents_program1.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case 3
                For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
                    Try
                        If (_2016_MRN_HintsDataSet.tblUser(index).CodeRequests.Trim.Remove(1, 2) = 3) Then
                            lstStudents_program1.SelectedItems.Add(_2016_MRN_HintsDataSet.tblUser(index).Username.ToString)
                        End If
                    Catch ex As Exception
                        'throw error
                        MsgBox("Error: " & ex.Message)
                    End Try
                Next
            Case Else
        End Select
        Return 0
    End Function
    Private Sub rdoUsedOne3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedOne_program3.CheckedChanged
        rdo_count3_used = 1
        showPRG3()
    End Sub
    Private Sub rdoUsedTwo3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedTwo_program3.CheckedChanged
        rdo_count3_used = 2
        showPRG3()
    End Sub
    Private Sub rdoUsedThree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedThree_program3.CheckedChanged
        rdo_count3_used = 3
        showPRG3()
    End Sub
    Private Sub rdoUsedOne2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedOne_program2.CheckedChanged
        rdo_count2_used = 1
        showPRG2()
    End Sub
    Private Sub rdoUsedTwo2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedTwo_program2.CheckedChanged
        rdo_count2_used = 2
        showPRG2()
    End Sub
    Private Sub rdoUsedThree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedThree_program2.CheckedChanged
        rdo_count2_used = 3
        showPRG2()
    End Sub
    Private Sub rdoUsedOne1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedOne_program1.CheckedChanged
        rdo_count1_used = 1
        showPRG1()
    End Sub
    Private Sub rdoUsedTwo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedTwo_program1.CheckedChanged
        rdo_count1_used = 2
        showPRG1()
    End Sub
    Private Sub rdoUsedThree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedThree_program1.CheckedChanged
        rdo_count1_used = 3
        showPRG1()
    End Sub
    Private Sub rdoUsedNone_program1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedNone_program1.CheckedChanged
        rdo_count1_used = 0
        showPRG1()
    End Sub
    Private Sub rdoUsedNone_program2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedNone_program2.CheckedChanged
        rdo_count2_used = 0
        showPRG2()
    End Sub
    Private Sub rdoUsedNone_program3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoUsedNone_program3.CheckedChanged
        rdo_count3_used = 0
        showPRG3()
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        loadstuff()
        showPRG1()
        showPRG2()
        showPRG3()
    End Sub
    Private Sub cmdRefreshIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefreshIt.Click
        loadstuff()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim wrapper As New SimpleAES(txtPassword.Text)
        Dim Password As String = (wrapper.EncryptData(txtPassword.Text))

        _2016_MRN_HintsDataSet.tblUser.AddtblUserRow(_2016_MRN_HintsDataSet.tblUser.Rows.Count, txtUsername.Text, Password, 1, Val(cbProgramlevel.SelectedItem), False, "000")

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

        loadstuff()
    End Sub
    Private Sub cmdShowStudentAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowStudentAdd.Click
        gbAddStudent.Visible = Not (gbAddStudent.Visible)
    End Sub
    Private Sub tmrAutoRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoRefresh.Tick
        loadstuff()
        showPRG1()
        showPRG2()
        showPRG3()
    End Sub
    Private Sub cmdToggleRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdToggleRefresh.Click
        cmdToggleRefresh.Text = "Toggle Auto Refresh [" & AutoRefresh.ToString & "]"
        tmrAutoRefresh.Enabled = AutoRefresh
        AutoRefresh = Not AutoRefresh
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If (Not lstBoxStudents.SelectedValue = vbNull) Then
            gbDelete.Visible = Not gbDelete.Visible
        End If
    End Sub
    Private Sub cmdHideDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHideDelete.Click
        gbDelete.Visible = Not gbDelete.Visible
    End Sub
    Private Sub cmdConfirmDeletion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirmDeletion.Click
        Try
            _2016_MRN_HintsDataSet.tblUser.RemovetblUserRow(_2016_MRN_HintsDataSet.tblUser(Val(lstBoxStudents.SelectedIndex)))
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try
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

        gbDelete.Visible = Not gbDelete.Visible
        loadstuff()
    End Sub

    Function UpdateSelectedPrimary()
        'honestly, this is so damn silly I'm not even going to bother

        Dim used As Integer = Val(_2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests().Trim.Remove(1, 2)) + Val(_2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests().Trim.Remove(0, 1).Trim.Remove(1, 1)) + Val(_2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests().Trim.Remove(0, 2))
        lblHelpsUsed.Text = "Total Helps Used:  [" & (used).ToString & "]"
        lblScore.Text = "Score: " & Math.Round(((1 - (used / 9)) * 100), 2) & "%"
        lblstProgram1.Text = "Program 1: " & _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests.Trim.Remove(0, 2)
        lblstProgram2.Text = "Program 2: " & _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests.Trim.Remove(2, 1).Trim.Remove(0, 1)
        lblstProgram3.Text = "Program 3: " & _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests.Trim.Remove(1, 2)
        lblProgrammingLevel.Text = "Programming Level: [" & _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).ProgrammingLevel & "]"
        Return 0
    End Function

    Private Sub lstBoxStudents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBoxStudents.SelectedIndexChanged
        UpdateSelectedPrimary()
    End Sub
    Private Sub cmdResetHelps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetHelps.Click
        _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).CodeRequests = "000"
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

        UpdateSelectedPrimary()
    End Sub
    Private Sub cmdResetPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetPass.Click
        MsgBox(lstBoxStudents.SelectedItem.ToString)
        Dim wrapper As New SimpleAES(txtResetPass.Text & lstBoxStudents.SelectedItem.ToString)
        Dim Password As String
        Try
            Password = wrapper.EncryptData(txtResetPass.Text & lstBoxStudents.SelectedItem.ToString)
            _2016_MRN_HintsDataSet.tblUser(lstBoxStudents.SelectedIndex).Password = Password
        Catch ex As Exception
        End Try

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

    Dim selectedProgramPart As Integer = 0
    Dim selectedProgram As Integer = 0
    Dim selectedPrograming As Integer = 0

    '==============================================================================================================
    '----!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!----
    'Todo: implement
    'https://www.simple-talk.com/sql/learn-sql-server/an-introduction-to-sql-server-filestream/
    '
    'Can't currently due to time constraints and the server requires a restart to implement
    '
    '
    '
    '==============================================================================================================
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Select Case selectedPrograming
            Case 1
                Select Case selectedProgram
                    Case 1
                        Select Case selectedProgramPart
                            Case 1
                                'change it to something that works
                                _2016_MRN_HintsDataSet.tblCode(0).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(1).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(2).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                    Case 2
                        Select Case selectedProgramPart
                            Case 1
                                _2016_MRN_HintsDataSet.tblCode(3).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(4).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(5).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                    Case 3
                        Select Case selectedProgramPart
                            Case 1
                                _2016_MRN_HintsDataSet.tblCode(6).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(7).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(8).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                End Select
            Case 2
                Select Case selectedProgram
                    Case 1
                        Select Case selectedProgramPart
                            Case 1
                                _2016_MRN_HintsDataSet.tblCode(9).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(10).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(11).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                    Case 2
                        Select Case selectedProgramPart
                            Case 1
                                _2016_MRN_HintsDataSet.tblCode(12).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(13).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(14).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                    Case 3
                        Select Case selectedProgramPart
                            Case 1
                                _2016_MRN_HintsDataSet.tblCode(15).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 2
                                _2016_MRN_HintsDataSet.tblCode(16).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                            Case 3
                                _2016_MRN_HintsDataSet.tblCode(17).Code = UnicodeStringToBytes(rtxtCode.Rtf)
                        End Select
                End Select
        End Select
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

    Function CheckValUpdate()
        Return 0
    End Function

    Private Sub rdProgramLevel_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdProgramLevel_1.CheckedChanged
        selectedPrograming = 1
        CheckValUpdate()
    End Sub
    Private Sub rdProgramLevel_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdProgramLevel_2.CheckedChanged
        selectedPrograming = 2
        CheckValUpdate()
    End Sub

    Private Sub rdProgram1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdProgram1.CheckedChanged
        selectedProgram = 1
        CheckValUpdate()
    End Sub
    Private Sub rdProgram2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdProgram2.CheckedChanged
        selectedProgram = 2
        CheckValUpdate()
    End Sub
    Private Sub rdProgram3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdProgram3.CheckedChanged
        selectedProgram = 3
        CheckValUpdate()
    End Sub

    Private Sub rdHint1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHint1.CheckedChanged
        selectedProgramPart = 1
        CheckValUpdate()
    End Sub
    Private Sub rdHint2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHint2.CheckedChanged
        selectedProgramPart = 2
        CheckValUpdate()
    End Sub
    Private Sub rdHint3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdHint3.CheckedChanged
        selectedProgramPart = 3
        CheckValUpdate()
    End Sub

    'Rich Text Format Crap
    Private Sub cmdClearText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearText.Click
        rtxtCode.Text = ""
    End Sub
    Private Sub cmdPasteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPasteAll.Click
        rtxtCode.Text = Clipboard.GetText
    End Sub
    Private Sub cmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectAll.Click
        rtxtCode.SelectAll()
    End Sub
    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        Clipboard.SetText(rtxtCode.SelectedText)
    End Sub
    Private Sub cmdPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaste.Click
        rtxtCode.Text = rtxtCode.Text & Clipboard.GetText
    End Sub
End Class
