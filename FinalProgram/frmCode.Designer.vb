<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCode))
        Me.cmdMoreCode_1 = New System.Windows.Forms.Button()
        Me.mnFile = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssSatus = New System.Windows.Forms.StatusStrip()
        Me.lblUsedHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspHelpsUsed = New System.Windows.Forms.ToolStripProgressBar()
        Me.ProgrammingLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCode_1 = New System.Windows.Forms.RichTextBox()
        Me.ProgramSwitch = New System.Windows.Forms.TabControl()
        Me.pgProgram1 = New System.Windows.Forms.TabPage()
        Me.gbConfirm_1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel_1 = New System.Windows.Forms.Button()
        Me.cmdConfirm_1 = New System.Windows.Forms.Button()
        Me.pgProgram2 = New System.Windows.Forms.TabPage()
        Me.txtCode_2 = New System.Windows.Forms.RichTextBox()
        Me.gbConfirm_2 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel_2 = New System.Windows.Forms.Button()
        Me.cmdConfirm_2 = New System.Windows.Forms.Button()
        Me.cmdMoreCode_2 = New System.Windows.Forms.Button()
        Me.pgProgram3 = New System.Windows.Forms.TabPage()
        Me.cmdMoreCode_3 = New System.Windows.Forms.Button()
        Me.gbConfirm_3 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel_3 = New System.Windows.Forms.Button()
        Me.cmdConfirm_3 = New System.Windows.Forms.Button()
        Me.txtCode_3 = New System.Windows.Forms.RichTextBox()
        Me._2016_MRN_HintsDataSet = New FinalProgram._2016_MRN_HintsDataSet()
        Me.MRNHintsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserTableAdapter = New FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter()
        Me.TblCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCodeTableAdapter = New FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblCodeTableAdapter()
        Me.mnFile.SuspendLayout()
        Me.ssSatus.SuspendLayout()
        Me.ProgramSwitch.SuspendLayout()
        Me.pgProgram1.SuspendLayout()
        Me.gbConfirm_1.SuspendLayout()
        Me.pgProgram2.SuspendLayout()
        Me.gbConfirm_2.SuspendLayout()
        Me.pgProgram3.SuspendLayout()
        Me.gbConfirm_3.SuspendLayout()
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdMoreCode_1
        '
        Me.cmdMoreCode_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoreCode_1.Location = New System.Drawing.Point(630, 0)
        Me.cmdMoreCode_1.Name = "cmdMoreCode_1"
        Me.cmdMoreCode_1.Size = New System.Drawing.Size(150, 150)
        Me.cmdMoreCode_1.TabIndex = 1
        Me.cmdMoreCode_1.Text = "Request More Code"
        Me.cmdMoreCode_1.UseVisualStyleBackColor = True
        '
        'mnFile
        '
        Me.mnFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdUser, Me.cmdHelp})
        Me.mnFile.Location = New System.Drawing.Point(0, 0)
        Me.mnFile.Name = "mnFile"
        Me.mnFile.Size = New System.Drawing.Size(804, 24)
        Me.mnFile.TabIndex = 3
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
        'cmdUser
        '
        Me.cmdUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLogOut, Me.cmdChangePassword})
        Me.cmdUser.Name = "cmdUser"
        Me.cmdUser.Size = New System.Drawing.Size(42, 20)
        Me.cmdUser.Text = "User"
        '
        'cmdLogOut
        '
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(168, 22)
        Me.cmdLogOut.Text = "Log Out"
        '
        'cmdChangePassword
        '
        Me.cmdChangePassword.Name = "cmdChangePassword"
        Me.cmdChangePassword.Size = New System.Drawing.Size(168, 22)
        Me.cmdChangePassword.Text = "Change Password"
        '
        'cmdHelp
        '
        Me.cmdHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAbout})
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(44, 20)
        Me.cmdHelp.Text = "Help"
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(107, 22)
        Me.cmdAbout.Text = "About"
        '
        'ssSatus
        '
        Me.ssSatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsedHelp, Me.tspHelpsUsed})
        Me.ssSatus.Location = New System.Drawing.Point(0, 397)
        Me.ssSatus.Name = "ssSatus"
        Me.ssSatus.Size = New System.Drawing.Size(804, 42)
        Me.ssSatus.TabIndex = 5
        '
        'lblUsedHelp
        '
        Me.lblUsedHelp.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedHelp.Name = "lblUsedHelp"
        Me.lblUsedHelp.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.lblUsedHelp.Size = New System.Drawing.Size(195, 37)
        Me.lblUsedHelp.Text = "Used Helps: [0]"
        '
        'tspHelpsUsed
        '
        Me.tspHelpsUsed.MarqueeAnimationSpeed = 500
        Me.tspHelpsUsed.Maximum = 3
        Me.tspHelpsUsed.Name = "tspHelpsUsed"
        Me.tspHelpsUsed.Size = New System.Drawing.Size(300, 36)
        Me.tspHelpsUsed.Step = 1
        '
        'ProgrammingLevelDataGridViewTextBoxColumn
        '
        Me.ProgrammingLevelDataGridViewTextBoxColumn.DataPropertyName = "ProgrammingLevel"
        Me.ProgrammingLevelDataGridViewTextBoxColumn.HeaderText = "ProgrammingLevel"
        Me.ProgrammingLevelDataGridViewTextBoxColumn.Name = "ProgrammingLevelDataGridViewTextBoxColumn"
        '
        'ProgramNumberDataGridViewTextBoxColumn
        '
        Me.ProgramNumberDataGridViewTextBoxColumn.DataPropertyName = "ProgramNumber"
        Me.ProgramNumberDataGridViewTextBoxColumn.HeaderText = "ProgramNumber"
        Me.ProgramNumberDataGridViewTextBoxColumn.Name = "ProgramNumberDataGridViewTextBoxColumn"
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'txtCode_1
        '
        Me.txtCode_1.Location = New System.Drawing.Point(0, 0)
        Me.txtCode_1.Name = "txtCode_1"
        Me.txtCode_1.Size = New System.Drawing.Size(624, 338)
        Me.txtCode_1.TabIndex = 6
        Me.txtCode_1.Text = "Option Strict On" & Global.Microsoft.VisualBasic.ChrW(10) & "Option Explicit On" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Namespace My" & Global.Microsoft.VisualBasic.ChrW(10) & "    " & Global.Microsoft.VisualBasic.ChrW(10) & "End Namespace" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ProgramSwitch
        '
        Me.ProgramSwitch.Controls.Add(Me.pgProgram1)
        Me.ProgramSwitch.Controls.Add(Me.pgProgram2)
        Me.ProgramSwitch.Controls.Add(Me.pgProgram3)
        Me.ProgramSwitch.Location = New System.Drawing.Point(12, 27)
        Me.ProgramSwitch.Name = "ProgramSwitch"
        Me.ProgramSwitch.SelectedIndex = 0
        Me.ProgramSwitch.Size = New System.Drawing.Size(792, 367)
        Me.ProgramSwitch.TabIndex = 7
        '
        'pgProgram1
        '
        Me.pgProgram1.Controls.Add(Me.gbConfirm_1)
        Me.pgProgram1.Controls.Add(Me.cmdMoreCode_1)
        Me.pgProgram1.Controls.Add(Me.txtCode_1)
        Me.pgProgram1.Location = New System.Drawing.Point(4, 22)
        Me.pgProgram1.Name = "pgProgram1"
        Me.pgProgram1.Padding = New System.Windows.Forms.Padding(3)
        Me.pgProgram1.Size = New System.Drawing.Size(784, 341)
        Me.pgProgram1.TabIndex = 0
        Me.pgProgram1.Text = "Program 1"
        Me.pgProgram1.UseVisualStyleBackColor = True
        '
        'gbConfirm_1
        '
        Me.gbConfirm_1.Controls.Add(Me.cmdCancel_1)
        Me.gbConfirm_1.Controls.Add(Me.cmdConfirm_1)
        Me.gbConfirm_1.Location = New System.Drawing.Point(630, 156)
        Me.gbConfirm_1.Name = "gbConfirm_1"
        Me.gbConfirm_1.Size = New System.Drawing.Size(145, 178)
        Me.gbConfirm_1.TabIndex = 7
        Me.gbConfirm_1.TabStop = False
        Me.gbConfirm_1.Text = "Are you sure?"
        Me.gbConfirm_1.Visible = False
        '
        'cmdCancel_1
        '
        Me.cmdCancel_1.Location = New System.Drawing.Point(7, 50)
        Me.cmdCancel_1.Name = "cmdCancel_1"
        Me.cmdCancel_1.Size = New System.Drawing.Size(132, 23)
        Me.cmdCancel_1.TabIndex = 1
        Me.cmdCancel_1.Text = "Cancel Request"
        Me.cmdCancel_1.UseVisualStyleBackColor = True
        '
        'cmdConfirm_1
        '
        Me.cmdConfirm_1.Location = New System.Drawing.Point(7, 20)
        Me.cmdConfirm_1.Name = "cmdConfirm_1"
        Me.cmdConfirm_1.Size = New System.Drawing.Size(132, 23)
        Me.cmdConfirm_1.TabIndex = 0
        Me.cmdConfirm_1.Text = "Confirm Request"
        Me.cmdConfirm_1.UseVisualStyleBackColor = True
        '
        'pgProgram2
        '
        Me.pgProgram2.Controls.Add(Me.txtCode_2)
        Me.pgProgram2.Controls.Add(Me.gbConfirm_2)
        Me.pgProgram2.Controls.Add(Me.cmdMoreCode_2)
        Me.pgProgram2.Location = New System.Drawing.Point(4, 22)
        Me.pgProgram2.Name = "pgProgram2"
        Me.pgProgram2.Padding = New System.Windows.Forms.Padding(3)
        Me.pgProgram2.Size = New System.Drawing.Size(784, 341)
        Me.pgProgram2.TabIndex = 1
        Me.pgProgram2.Text = "Program 2"
        Me.pgProgram2.UseVisualStyleBackColor = True
        '
        'txtCode_2
        '
        Me.txtCode_2.Location = New System.Drawing.Point(0, 0)
        Me.txtCode_2.Name = "txtCode_2"
        Me.txtCode_2.Size = New System.Drawing.Size(624, 338)
        Me.txtCode_2.TabIndex = 9
        Me.txtCode_2.Text = "Option Strict On" & Global.Microsoft.VisualBasic.ChrW(10) & "Option Explicit On" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Namespace My" & Global.Microsoft.VisualBasic.ChrW(10) & "    " & Global.Microsoft.VisualBasic.ChrW(10) & "End Namespace" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gbConfirm_2
        '
        Me.gbConfirm_2.Controls.Add(Me.cmdCancel_2)
        Me.gbConfirm_2.Controls.Add(Me.cmdConfirm_2)
        Me.gbConfirm_2.Location = New System.Drawing.Point(630, 156)
        Me.gbConfirm_2.Name = "gbConfirm_2"
        Me.gbConfirm_2.Size = New System.Drawing.Size(145, 178)
        Me.gbConfirm_2.TabIndex = 10
        Me.gbConfirm_2.TabStop = False
        Me.gbConfirm_2.Text = "Are you sure?"
        Me.gbConfirm_2.Visible = False
        '
        'cmdCancel_2
        '
        Me.cmdCancel_2.Location = New System.Drawing.Point(7, 50)
        Me.cmdCancel_2.Name = "cmdCancel_2"
        Me.cmdCancel_2.Size = New System.Drawing.Size(132, 23)
        Me.cmdCancel_2.TabIndex = 1
        Me.cmdCancel_2.Text = "Cancel Request"
        Me.cmdCancel_2.UseVisualStyleBackColor = True
        '
        'cmdConfirm_2
        '
        Me.cmdConfirm_2.Location = New System.Drawing.Point(7, 20)
        Me.cmdConfirm_2.Name = "cmdConfirm_2"
        Me.cmdConfirm_2.Size = New System.Drawing.Size(132, 23)
        Me.cmdConfirm_2.TabIndex = 0
        Me.cmdConfirm_2.Text = "Confirm Request"
        Me.cmdConfirm_2.UseVisualStyleBackColor = True
        '
        'cmdMoreCode_2
        '
        Me.cmdMoreCode_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoreCode_2.Location = New System.Drawing.Point(630, 0)
        Me.cmdMoreCode_2.Name = "cmdMoreCode_2"
        Me.cmdMoreCode_2.Size = New System.Drawing.Size(150, 150)
        Me.cmdMoreCode_2.TabIndex = 8
        Me.cmdMoreCode_2.Text = "Request More Code"
        Me.cmdMoreCode_2.UseVisualStyleBackColor = True
        '
        'pgProgram3
        '
        Me.pgProgram3.Controls.Add(Me.cmdMoreCode_3)
        Me.pgProgram3.Controls.Add(Me.gbConfirm_3)
        Me.pgProgram3.Controls.Add(Me.txtCode_3)
        Me.pgProgram3.Location = New System.Drawing.Point(4, 22)
        Me.pgProgram3.Name = "pgProgram3"
        Me.pgProgram3.Padding = New System.Windows.Forms.Padding(3)
        Me.pgProgram3.Size = New System.Drawing.Size(784, 341)
        Me.pgProgram3.TabIndex = 2
        Me.pgProgram3.Text = "Program 3"
        Me.pgProgram3.UseVisualStyleBackColor = True
        '
        'cmdMoreCode_3
        '
        Me.cmdMoreCode_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoreCode_3.Location = New System.Drawing.Point(630, 0)
        Me.cmdMoreCode_3.Name = "cmdMoreCode_3"
        Me.cmdMoreCode_3.Size = New System.Drawing.Size(150, 150)
        Me.cmdMoreCode_3.TabIndex = 8
        Me.cmdMoreCode_3.Text = "Request More Code"
        Me.cmdMoreCode_3.UseVisualStyleBackColor = True
        '
        'gbConfirm_3
        '
        Me.gbConfirm_3.Controls.Add(Me.cmdCancel_3)
        Me.gbConfirm_3.Controls.Add(Me.cmdConfirm_3)
        Me.gbConfirm_3.Location = New System.Drawing.Point(630, 156)
        Me.gbConfirm_3.Name = "gbConfirm_3"
        Me.gbConfirm_3.Size = New System.Drawing.Size(145, 178)
        Me.gbConfirm_3.TabIndex = 10
        Me.gbConfirm_3.TabStop = False
        Me.gbConfirm_3.Text = "Are you sure?"
        Me.gbConfirm_3.Visible = False
        '
        'cmdCancel_3
        '
        Me.cmdCancel_3.Location = New System.Drawing.Point(7, 50)
        Me.cmdCancel_3.Name = "cmdCancel_3"
        Me.cmdCancel_3.Size = New System.Drawing.Size(132, 23)
        Me.cmdCancel_3.TabIndex = 1
        Me.cmdCancel_3.Text = "Cancel Request"
        Me.cmdCancel_3.UseVisualStyleBackColor = True
        '
        'cmdConfirm_3
        '
        Me.cmdConfirm_3.Location = New System.Drawing.Point(7, 20)
        Me.cmdConfirm_3.Name = "cmdConfirm_3"
        Me.cmdConfirm_3.Size = New System.Drawing.Size(132, 23)
        Me.cmdConfirm_3.TabIndex = 0
        Me.cmdConfirm_3.Text = "Confirm Request"
        Me.cmdConfirm_3.UseVisualStyleBackColor = True
        '
        'txtCode_3
        '
        Me.txtCode_3.Location = New System.Drawing.Point(0, 0)
        Me.txtCode_3.Name = "txtCode_3"
        Me.txtCode_3.Size = New System.Drawing.Size(624, 338)
        Me.txtCode_3.TabIndex = 9
        Me.txtCode_3.Text = "Option Strict On" & Global.Microsoft.VisualBasic.ChrW(10) & "Option Explicit On" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Namespace My" & Global.Microsoft.VisualBasic.ChrW(10) & "    " & Global.Microsoft.VisualBasic.ChrW(10) & "End Namespace" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'TblCodeBindingSource
        '
        Me.TblCodeBindingSource.DataMember = "tblCode"
        Me.TblCodeBindingSource.DataSource = Me.MRNHintsDataSetBindingSource
        '
        'TblCodeTableAdapter
        '
        Me.TblCodeTableAdapter.ClearBeforeFill = True
        '
        'frmCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 439)
        Me.Controls.Add(Me.ProgramSwitch)
        Me.Controls.Add(Me.ssSatus)
        Me.Controls.Add(Me.mnFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnFile
        Me.Name = "frmCode"
        Me.Text = "Student"
        Me.mnFile.ResumeLayout(False)
        Me.mnFile.PerformLayout()
        Me.ssSatus.ResumeLayout(False)
        Me.ssSatus.PerformLayout()
        Me.ProgramSwitch.ResumeLayout(False)
        Me.pgProgram1.ResumeLayout(False)
        Me.gbConfirm_1.ResumeLayout(False)
        Me.pgProgram2.ResumeLayout(False)
        Me.gbConfirm_2.ResumeLayout(False)
        Me.pgProgram3.ResumeLayout(False)
        Me.gbConfirm_3.ResumeLayout(False)
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdMoreCode_1 As System.Windows.Forms.Button
    Friend WithEvents mnFile As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssSatus As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsedHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tspHelpsUsed As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TblStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProgrammingLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgramNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCode_1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgramSwitch As System.Windows.Forms.TabControl
    Friend WithEvents pgProgram1 As System.Windows.Forms.TabPage
    Friend WithEvents pgProgram2 As System.Windows.Forms.TabPage
    Friend WithEvents pgProgram3 As System.Windows.Forms.TabPage
    Friend WithEvents cmdUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbConfirm_1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel_1 As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm_1 As System.Windows.Forms.Button
    Friend WithEvents txtCode_2 As System.Windows.Forms.RichTextBox
    Friend WithEvents gbConfirm_2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel_2 As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm_2 As System.Windows.Forms.Button
    Friend WithEvents cmdMoreCode_2 As System.Windows.Forms.Button
    Friend WithEvents cmdMoreCode_3 As System.Windows.Forms.Button
    Friend WithEvents gbConfirm_3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancel_3 As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm_3 As System.Windows.Forms.Button
    Friend WithEvents txtCode_3 As System.Windows.Forms.RichTextBox
    Friend WithEvents MRNHintsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _2016_MRN_HintsDataSet As FinalProgram._2016_MRN_HintsDataSet
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserTableAdapter As FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter
    Friend WithEvents TblCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCodeTableAdapter As FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblCodeTableAdapter

End Class
