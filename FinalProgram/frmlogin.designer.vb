<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.mnFile = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.chkMemory = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmdLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._2016_MRN_HintsDataSet = New FinalProgram._2016_MRN_HintsDataSet()
        Me.MRNHintsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserTableAdapter = New FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter()
        Me.HelperHinter = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.IcoStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdExit2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogout2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFile.SuspendLayout()
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IcoStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnFile
        '
        Me.mnFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile})
        Me.mnFile.Location = New System.Drawing.Point(0, 0)
        Me.mnFile.Name = "mnFile"
        Me.mnFile.Size = New System.Drawing.Size(322, 24)
        Me.mnFile.TabIndex = 0
        Me.mnFile.Text = "mnFile"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(226, 30)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(80, 88)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'chkMemory
        '
        Me.chkMemory.AutoSize = True
        Me.chkMemory.Location = New System.Drawing.Point(20, 124)
        Me.chkMemory.Name = "chkMemory"
        Me.chkMemory.Size = New System.Drawing.Size(95, 17)
        Me.chkMemory.TabIndex = 3
        Me.chkMemory.Text = "Remember Me"
        Me.chkMemory.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(20, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 38)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(20, 30)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 38)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Username"
        '
        'cmdLogout
        '
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(112, 22)
        Me.cmdLogout.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        '_2016_MRN_HintsDataSet
        '
        Me._2016_MRN_HintsDataSet.DataSetName = "_2016_MRN_HintsDataSet"
        Me._2016_MRN_HintsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MRNHintsDataSetBindingSource
        '
        Me.MRNHintsDataSetBindingSource.DataSource = Me._2016_MRN_HintsDataSet
        Me.MRNHintsDataSetBindingSource.Position = 0
        '
        'TblUserBindingSource
        '
        Me.TblUserBindingSource.DataMember = "tblUser"
        Me.TblUserBindingSource.DataSource = Me.MRNHintsDataSetBindingSource
        '
        'TblUserTableAdapter
        '
        Me.TblUserTableAdapter.ClearBeforeFill = True
        '
        'HelperHinter
        '
        Me.HelperHinter.Text = "Helper For Hints"
        Me.HelperHinter.Visible = True
        '
        'IcoStrip
        '
        Me.IcoStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExit2, Me.cmdLogout2})
        Me.IcoStrip.Name = "ContextMenuStrip1"
        Me.IcoStrip.Size = New System.Drawing.Size(116, 48)
        '
        'cmdExit2
        '
        Me.cmdExit2.Name = "cmdExit2"
        Me.cmdExit2.Size = New System.Drawing.Size(115, 22)
        Me.cmdExit2.Text = "Exit"
        '
        'cmdLogout2
        '
        Me.cmdLogout2.Name = "cmdLogout2"
        Me.cmdLogout2.Size = New System.Drawing.Size(115, 22)
        Me.cmdLogout2.Text = "Log out"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 154)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.chkMemory)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.mnFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnFile
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.mnFile.ResumeLayout(False)
        Me.mnFile.PerformLayout()
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IcoStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnFile As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents chkMemory As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents HintHelper As System.Windows.Forms.NotifyIcon
    Friend WithEvents hintHelpContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MRNHintsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _2016_MRN_HintsDataSet As FinalProgram._2016_MRN_HintsDataSet
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserTableAdapter As FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents HelperHinter As System.Windows.Forms.NotifyIcon
    Friend WithEvents IcoStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdExit2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogout2 As System.Windows.Forms.ToolStripMenuItem
End Class
