Imports System.Security.Cryptography

Public Class frmLogin
    Private Username As String
    Private Password As String
    Public Hasclicked1 = False, Hasclicked2 As Boolean = False
    Public Function resetDeets()
        'reset all of them deets
        Hasclicked1 = False
        Hasclicked2 = False
        txtUsername.Text = "Username"
        txtPassword.Text = "Password"
        frmAbout.ntfyIcon.Visible = False
        gGlobalVars.dbPos = 0
        Return 0
    End Function

    Public Function checkLogin() As Byte
        Dim dbPos As Integer = 0
        Dim isLogin As Byte = 255
        Dim selectedUsername As String
        Dim selectedPassword As String
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
        'Defaults to 255, will end the checklogin once it is set to a value other than 255.
        While isLogin = 255
            selectedUsername = _2016_MRN_HintsDataSet.tblUser(dbPos).Username.Trim()
            selectedPassword = _2016_MRN_HintsDataSet.tblUser(dbPos).Password.Trim()

            'if the user user imputed is in the database
            If Username = selectedUsername Then
                'If the user inputed password is correct to the selected username
                If Password = selectedPassword Then
                    'if the user type is either an admin or a user
                    If _2016_MRN_HintsDataSet.tblUser(dbPos).Role = 0 Then
                        'set the function's value to 3, refer to the cmdLogin sub
                        isLogin = 3
                        _2016_MRN_HintsDataSet.tblUser(dbPos).IsLoggedIn = 1
                        gGlobalVars.dbPos = dbPos

                    Else
                        'set the function's value to 2, refer to the cmdLogin sub
                        isLogin = 2
                        _2016_MRN_HintsDataSet.tblUser(dbPos).IsLoggedIn = 1
                        gGlobalVars.dbPos = dbPos

                    End If
                    Else
                    isLogin = 1
                End If
            Else
                'If the first username didn't match, go on to the second one until row 99 is met.
                If dbPos >= _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1 Then
                    isLogin = 0
                Else
                    'Otherwise add one to the row position in the database
                    dbPos += 1
                End If
            End If
        End While
        Return isLogin
    End Function
    Function check()
        Try
            If checkLogin() = 0 Then
                MsgBox("No such username")
                Return 0

            ElseIf checkLogin() = 1 Then
                MsgBox("Password not correct.")
                Return 0

            ElseIf checkLogin() = 2 Then 'User
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try

                Me.Hide()
                frmAbout.ntfyIcon.Visible = True
                frmAbout.lblName.Text = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).Username
                frmCode.Show()

            ElseIf checkLogin() = 3 Then 'Admin
                Try
                    Me.Validate()
                    Me.TblUserBindingSource.EndEdit()
                    Me.MRNHintsDataSetBindingSource.EndEdit()
                    Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
                Catch ex As Exception
                    'throw error
                    MsgBox("Error: " & ex.Message)
                End Try

                Me.Hide()
                frmAdmin.Show()
                frmAbout.lblName.Text = _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).Username
                frmAbout.ntfyIcon.Visible = True
                frmAdmin.loadstuff()
                HintHelper.Visible = False
            End If
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try
        Return 0
    End Function
    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown, txtUsername.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Username = txtUsername.Text.Trim()
            Dim wrapper As New SimpleAES(txtPassword.Text & Username)
            Try
                Password = wrapper.EncryptData(txtPassword.Text & Username)
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
            check()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdExit2.Click
        End
    End Sub
    'when you enter the text fields it clears the text
    Private Sub pass_Update(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Click, txtPassword.Enter
        If (Hasclicked1 = False) Then
            txtPassword.Text = ""
            Hasclicked1 = True
        End If
    End Sub
    Private Sub user_Update(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Click, txtUsername.Enter
        If (Hasclicked2 = False) Then
            txtUsername.Text = ""
            Hasclicked2 = True
        End If
    End Sub

    'DEBUG: sets the login instead of checking.
    Private Sub chkMemory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMemory.CheckedChanged
        'TODO: Make it register to the memory or just do nothing... i dunno
        'having it do nothing seems like a better idea.

        Username = txtUsername.Text.Trim()
        Dim wrapper As New SimpleAES(txtPassword.Text & Username)
        Try
            Password = wrapper.EncryptData(txtPassword.Text & Username)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        For index = 0 To _2016_MRN_HintsDataSet.tblUser.Rows.Count - 1
            If Username = _2016_MRN_HintsDataSet.tblUser(index).Username.Trim() Then
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
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_2016_MRN_HintsDataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me._2016_MRN_HintsDataSet.tblUser)
    End Sub

    Private Sub frmLogin_Close(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        _2016_MRN_HintsDataSet.tblUser(gGlobalVars.dbPos).IsLoggedIn = False

        Try
            Me.Validate()
            Me.TblUserBindingSource.EndEdit()
            Me.MRNHintsDataSetBindingSource.EndEdit()
            Me.TblUserTableAdapter.Update(Me._2016_MRN_HintsDataSet.tblUser)
        Catch ex As Exception
            'throw error
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        'sets the string variables as the username and encrypted pass
        Username = txtUsername.Text.Trim()
        Dim wrapper As New SimpleAES(txtPassword.Text & Username)
        Try
            Password = wrapper.EncryptData(txtPassword.Text & Username)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        'checks login
        check()
    End Sub
    Private Sub cmdLogout_Click(sender As System.Object, e As System.EventArgs) Handles cmdLogout.Click
        'TODO: make it work
        MsgBox("no")
    End Sub
End Class


'From microsoft; google to learn more
Public NotInheritable Class SimpleAES
    Private AESProvider As New AesCryptoServiceProvider

    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha512 As New SHA512CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha512.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)
        ' Initialize the crypto provider
        AESProvider.Key = TruncateHash(key, AESProvider.KeySize \ 8)
        AESProvider.IV = TruncateHash("", AESProvider.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms, AESProvider.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function
End Class
