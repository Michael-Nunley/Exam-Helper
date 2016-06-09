<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.msFile = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdToggleRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutoRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlRDO_level3 = New System.Windows.Forms.Panel()
        Me.rdoUsedNone_program3 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedThree_program3 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedTwo_program3 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedOne_program3 = New System.Windows.Forms.RadioButton()
        Me.lstStudents_program3 = New System.Windows.Forms.ListBox()
        Me.TABS_Control = New System.Windows.Forms.TabControl()
        Me.tbPage_Students = New System.Windows.Forms.TabPage()
        Me.gbPrograms = New System.Windows.Forms.GroupBox()
        Me.gbProgram3 = New System.Windows.Forms.GroupBox()
        Me.gbProgram2 = New System.Windows.Forms.GroupBox()
        Me.pnlRDO_level2 = New System.Windows.Forms.Panel()
        Me.rdoUsedNone_program2 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedThree_program2 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedTwo_program2 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedOne_program2 = New System.Windows.Forms.RadioButton()
        Me.lstStudents_program2 = New System.Windows.Forms.ListBox()
        Me.gbProgram1 = New System.Windows.Forms.GroupBox()
        Me.pnlRDO_level1 = New System.Windows.Forms.Panel()
        Me.rdoUsedNone_program1 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedThree_program1 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedTwo_program1 = New System.Windows.Forms.RadioButton()
        Me.rdoUsedOne_program1 = New System.Windows.Forms.RadioButton()
        Me.lstStudents_program1 = New System.Windows.Forms.ListBox()
        Me.gbSTinformation = New System.Windows.Forms.GroupBox()
        Me.cmdResetHelps = New System.Windows.Forms.Button()
        Me.lblProgrammingLevel = New System.Windows.Forms.Label()
        Me.lblstProgram3 = New System.Windows.Forms.Label()
        Me.lblstProgram2 = New System.Windows.Forms.Label()
        Me.lblstProgram1 = New System.Windows.Forms.Label()
        Me.txtResetPass = New System.Windows.Forms.MaskedTextBox()
        Me.cmdResetPass = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHelpsUsed = New System.Windows.Forms.Label()
        Me.gbDelete = New System.Windows.Forms.GroupBox()
        Me.cmdConfirmDeletion = New System.Windows.Forms.Button()
        Me.cmdHideDelete = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdShowStudentAdd = New System.Windows.Forms.Button()
        Me.gbAddStudent = New System.Windows.Forms.GroupBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cbProgramlevel = New System.Windows.Forms.ComboBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.cmdRefreshIt = New System.Windows.Forms.Button()
        Me.lstBoxStudents = New System.Windows.Forms.ListBox()
        Me.tbPage_Code = New System.Windows.Forms.TabPage()
        Me.gbProgramLevel3 = New System.Windows.Forms.GroupBox()
        Me.rdHint3 = New System.Windows.Forms.RadioButton()
        Me.rdHint2 = New System.Windows.Forms.RadioButton()
        Me.rdHint1 = New System.Windows.Forms.RadioButton()
        Me.rtxtCode = New System.Windows.Forms.RichTextBox()
        Me.cmsRightClickText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdClearText = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPasteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbProgramLevel2 = New System.Windows.Forms.GroupBox()
        Me.rdProgram3 = New System.Windows.Forms.RadioButton()
        Me.rdProgram2 = New System.Windows.Forms.RadioButton()
        Me.rdProgram1 = New System.Windows.Forms.RadioButton()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.gbProgramLevel1 = New System.Windows.Forms.GroupBox()
        Me.rdProgramLevel_2 = New System.Windows.Forms.RadioButton()
        Me.rdProgramLevel_1 = New System.Windows.Forms.RadioButton()
        Me._2016_MRN_HintsDataSet = New FinalProgram._2016_MRN_HintsDataSet()
        Me.MRNHintsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCodeTableAdapter = New FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblCodeTableAdapter()
        Me.TblUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserTableAdapter = New FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter()
        Me.msFile.SuspendLayout()
        Me.pnlRDO_level3.SuspendLayout()
        Me.TABS_Control.SuspendLayout()
        Me.tbPage_Students.SuspendLayout()
        Me.gbPrograms.SuspendLayout()
        Me.gbProgram3.SuspendLayout()
        Me.gbProgram2.SuspendLayout()
        Me.pnlRDO_level2.SuspendLayout()
        Me.gbProgram1.SuspendLayout()
        Me.pnlRDO_level1.SuspendLayout()
        Me.gbSTinformation.SuspendLayout()
        Me.gbDelete.SuspendLayout()
        Me.gbAddStudent.SuspendLayout()
        Me.tbPage_Code.SuspendLayout()
        Me.gbProgramLevel3.SuspendLayout()
        Me.cmsRightClickText.SuspendLayout()
        Me.gbProgramLevel2.SuspendLayout()
        Me.gbProgramLevel1.SuspendLayout()
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msFile
        '
        Me.msFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdEdit})
        Me.msFile.Location = New System.Drawing.Point(0, 0)
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(765, 24)
        Me.msFile.TabIndex = 1
        Me.msFile.Text = "MenuStrip1"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLogOut, Me.cmdExit})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdLogOut
        '
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.Size = New System.Drawing.Size(152, 22)
        Me.cmdLogOut.Text = "Log Out"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(152, 22)
        Me.cmdExit.Text = "Exit"
        '
        'cmdEdit
        '
        Me.cmdEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRefresh})
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(39, 20)
        Me.cmdEdit.Text = "Edit"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdToggleRefresh})
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(130, 22)
        Me.cmdRefresh.Text = "Refresh All"
        '
        'cmdToggleRefresh
        '
        Me.cmdToggleRefresh.Name = "cmdToggleRefresh"
        Me.cmdToggleRefresh.Size = New System.Drawing.Size(217, 22)
        Me.cmdToggleRefresh.Text = "Toggle Auto Refresh [false]"
        '
        'tmrAutoRefresh
        '
        Me.tmrAutoRefresh.Interval = 1000
        '
        'pnlRDO_level3
        '
        Me.pnlRDO_level3.Controls.Add(Me.rdoUsedNone_program3)
        Me.pnlRDO_level3.Controls.Add(Me.rdoUsedThree_program3)
        Me.pnlRDO_level3.Controls.Add(Me.rdoUsedTwo_program3)
        Me.pnlRDO_level3.Controls.Add(Me.rdoUsedOne_program3)
        Me.pnlRDO_level3.Location = New System.Drawing.Point(5, 15)
        Me.pnlRDO_level3.Name = "pnlRDO_level3"
        Me.pnlRDO_level3.Size = New System.Drawing.Size(120, 95)
        Me.pnlRDO_level3.TabIndex = 4
        '
        'rdoUsedNone_program3
        '
        Me.rdoUsedNone_program3.AutoSize = True
        Me.rdoUsedNone_program3.Location = New System.Drawing.Point(3, 3)
        Me.rdoUsedNone_program3.Name = "rdoUsedNone_program3"
        Me.rdoUsedNone_program3.Size = New System.Drawing.Size(93, 17)
        Me.rdoUsedNone_program3.TabIndex = 4
        Me.rdoUsedNone_program3.TabStop = True
        Me.rdoUsedNone_program3.Text = "Used no helps"
        Me.rdoUsedNone_program3.UseVisualStyleBackColor = True
        '
        'rdoUsedThree_program3
        '
        Me.rdoUsedThree_program3.AutoSize = True
        Me.rdoUsedThree_program3.Location = New System.Drawing.Point(3, 72)
        Me.rdoUsedThree_program3.Name = "rdoUsedThree_program3"
        Me.rdoUsedThree_program3.Size = New System.Drawing.Size(105, 17)
        Me.rdoUsedThree_program3.TabIndex = 2
        Me.rdoUsedThree_program3.TabStop = True
        Me.rdoUsedThree_program3.Text = "Used three helps"
        Me.rdoUsedThree_program3.UseVisualStyleBackColor = True
        '
        'rdoUsedTwo_program3
        '
        Me.rdoUsedTwo_program3.AutoSize = True
        Me.rdoUsedTwo_program3.Location = New System.Drawing.Point(3, 49)
        Me.rdoUsedTwo_program3.Name = "rdoUsedTwo_program3"
        Me.rdoUsedTwo_program3.Size = New System.Drawing.Size(98, 17)
        Me.rdoUsedTwo_program3.TabIndex = 1
        Me.rdoUsedTwo_program3.TabStop = True
        Me.rdoUsedTwo_program3.Text = "Used two helps"
        Me.rdoUsedTwo_program3.UseVisualStyleBackColor = True
        '
        'rdoUsedOne_program3
        '
        Me.rdoUsedOne_program3.AutoSize = True
        Me.rdoUsedOne_program3.Location = New System.Drawing.Point(3, 26)
        Me.rdoUsedOne_program3.Name = "rdoUsedOne_program3"
        Me.rdoUsedOne_program3.Size = New System.Drawing.Size(94, 17)
        Me.rdoUsedOne_program3.TabIndex = 0
        Me.rdoUsedOne_program3.TabStop = True
        Me.rdoUsedOne_program3.Text = "Used one help"
        Me.rdoUsedOne_program3.UseVisualStyleBackColor = True
        '
        'lstStudents_program3
        '
        Me.lstStudents_program3.FormattingEnabled = True
        Me.lstStudents_program3.Items.AddRange(New Object() {"Student1", "Student2"})
        Me.lstStudents_program3.Location = New System.Drawing.Point(5, 116)
        Me.lstStudents_program3.Name = "lstStudents_program3"
        Me.lstStudents_program3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstStudents_program3.Size = New System.Drawing.Size(120, 329)
        Me.lstStudents_program3.TabIndex = 0
        '
        'TABS_Control
        '
        Me.TABS_Control.Controls.Add(Me.tbPage_Students)
        Me.TABS_Control.Controls.Add(Me.tbPage_Code)
        Me.TABS_Control.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TABS_Control.Location = New System.Drawing.Point(0, 22)
        Me.TABS_Control.Name = "TABS_Control"
        Me.TABS_Control.SelectedIndex = 0
        Me.TABS_Control.Size = New System.Drawing.Size(765, 514)
        Me.TABS_Control.TabIndex = 0
        '
        'tbPage_Students
        '
        Me.tbPage_Students.Controls.Add(Me.gbPrograms)
        Me.tbPage_Students.Controls.Add(Me.gbSTinformation)
        Me.tbPage_Students.Controls.Add(Me.gbDelete)
        Me.tbPage_Students.Controls.Add(Me.cmdDelete)
        Me.tbPage_Students.Controls.Add(Me.cmdShowStudentAdd)
        Me.tbPage_Students.Controls.Add(Me.gbAddStudent)
        Me.tbPage_Students.Controls.Add(Me.cmdRefreshIt)
        Me.tbPage_Students.Controls.Add(Me.lstBoxStudents)
        Me.tbPage_Students.Location = New System.Drawing.Point(4, 22)
        Me.tbPage_Students.Name = "tbPage_Students"
        Me.tbPage_Students.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPage_Students.Size = New System.Drawing.Size(757, 488)
        Me.tbPage_Students.TabIndex = 0
        Me.tbPage_Students.Text = "Students"
        Me.tbPage_Students.UseVisualStyleBackColor = True
        '
        'gbPrograms
        '
        Me.gbPrograms.Controls.Add(Me.gbProgram3)
        Me.gbPrograms.Controls.Add(Me.gbProgram2)
        Me.gbPrograms.Controls.Add(Me.gbProgram1)
        Me.gbPrograms.Location = New System.Drawing.Point(344, 7)
        Me.gbPrograms.Name = "gbPrograms"
        Me.gbPrograms.Size = New System.Drawing.Size(410, 472)
        Me.gbPrograms.TabIndex = 17
        Me.gbPrograms.TabStop = False
        Me.gbPrograms.Text = "Programs"
        '
        'gbProgram3
        '
        Me.gbProgram3.Controls.Add(Me.pnlRDO_level3)
        Me.gbProgram3.Controls.Add(Me.lstStudents_program3)
        Me.gbProgram3.Location = New System.Drawing.Point(276, 20)
        Me.gbProgram3.Name = "gbProgram3"
        Me.gbProgram3.Size = New System.Drawing.Size(130, 450)
        Me.gbProgram3.TabIndex = 18
        Me.gbProgram3.TabStop = False
        Me.gbProgram3.Text = "Program 3"
        '
        'gbProgram2
        '
        Me.gbProgram2.Controls.Add(Me.pnlRDO_level2)
        Me.gbProgram2.Controls.Add(Me.lstStudents_program2)
        Me.gbProgram2.Location = New System.Drawing.Point(140, 20)
        Me.gbProgram2.Name = "gbProgram2"
        Me.gbProgram2.Size = New System.Drawing.Size(130, 450)
        Me.gbProgram2.TabIndex = 17
        Me.gbProgram2.TabStop = False
        Me.gbProgram2.Text = "Program 2"
        '
        'pnlRDO_level2
        '
        Me.pnlRDO_level2.Controls.Add(Me.rdoUsedNone_program2)
        Me.pnlRDO_level2.Controls.Add(Me.rdoUsedThree_program2)
        Me.pnlRDO_level2.Controls.Add(Me.rdoUsedTwo_program2)
        Me.pnlRDO_level2.Controls.Add(Me.rdoUsedOne_program2)
        Me.pnlRDO_level2.Location = New System.Drawing.Point(5, 15)
        Me.pnlRDO_level2.Name = "pnlRDO_level2"
        Me.pnlRDO_level2.Size = New System.Drawing.Size(120, 95)
        Me.pnlRDO_level2.TabIndex = 4
        '
        'rdoUsedNone_program2
        '
        Me.rdoUsedNone_program2.AutoSize = True
        Me.rdoUsedNone_program2.Location = New System.Drawing.Point(3, 3)
        Me.rdoUsedNone_program2.Name = "rdoUsedNone_program2"
        Me.rdoUsedNone_program2.Size = New System.Drawing.Size(93, 17)
        Me.rdoUsedNone_program2.TabIndex = 4
        Me.rdoUsedNone_program2.TabStop = True
        Me.rdoUsedNone_program2.Text = "Used no helps"
        Me.rdoUsedNone_program2.UseVisualStyleBackColor = True
        '
        'rdoUsedThree_program2
        '
        Me.rdoUsedThree_program2.AutoSize = True
        Me.rdoUsedThree_program2.Location = New System.Drawing.Point(3, 72)
        Me.rdoUsedThree_program2.Name = "rdoUsedThree_program2"
        Me.rdoUsedThree_program2.Size = New System.Drawing.Size(105, 17)
        Me.rdoUsedThree_program2.TabIndex = 2
        Me.rdoUsedThree_program2.TabStop = True
        Me.rdoUsedThree_program2.Text = "Used three helps"
        Me.rdoUsedThree_program2.UseVisualStyleBackColor = True
        '
        'rdoUsedTwo_program2
        '
        Me.rdoUsedTwo_program2.AutoSize = True
        Me.rdoUsedTwo_program2.Location = New System.Drawing.Point(3, 49)
        Me.rdoUsedTwo_program2.Name = "rdoUsedTwo_program2"
        Me.rdoUsedTwo_program2.Size = New System.Drawing.Size(98, 17)
        Me.rdoUsedTwo_program2.TabIndex = 1
        Me.rdoUsedTwo_program2.TabStop = True
        Me.rdoUsedTwo_program2.Text = "Used two helps"
        Me.rdoUsedTwo_program2.UseVisualStyleBackColor = True
        '
        'rdoUsedOne_program2
        '
        Me.rdoUsedOne_program2.AutoSize = True
        Me.rdoUsedOne_program2.Location = New System.Drawing.Point(3, 26)
        Me.rdoUsedOne_program2.Name = "rdoUsedOne_program2"
        Me.rdoUsedOne_program2.Size = New System.Drawing.Size(94, 17)
        Me.rdoUsedOne_program2.TabIndex = 0
        Me.rdoUsedOne_program2.TabStop = True
        Me.rdoUsedOne_program2.Text = "Used one help"
        Me.rdoUsedOne_program2.UseVisualStyleBackColor = True
        '
        'lstStudents_program2
        '
        Me.lstStudents_program2.FormattingEnabled = True
        Me.lstStudents_program2.Items.AddRange(New Object() {"Student1", "Student2"})
        Me.lstStudents_program2.Location = New System.Drawing.Point(5, 116)
        Me.lstStudents_program2.Name = "lstStudents_program2"
        Me.lstStudents_program2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstStudents_program2.Size = New System.Drawing.Size(120, 329)
        Me.lstStudents_program2.TabIndex = 0
        '
        'gbProgram1
        '
        Me.gbProgram1.Controls.Add(Me.pnlRDO_level1)
        Me.gbProgram1.Controls.Add(Me.lstStudents_program1)
        Me.gbProgram1.Location = New System.Drawing.Point(5, 20)
        Me.gbProgram1.Name = "gbProgram1"
        Me.gbProgram1.Size = New System.Drawing.Size(130, 450)
        Me.gbProgram1.TabIndex = 16
        Me.gbProgram1.TabStop = False
        Me.gbProgram1.Text = "Program 1"
        '
        'pnlRDO_level1
        '
        Me.pnlRDO_level1.Controls.Add(Me.rdoUsedNone_program1)
        Me.pnlRDO_level1.Controls.Add(Me.rdoUsedThree_program1)
        Me.pnlRDO_level1.Controls.Add(Me.rdoUsedTwo_program1)
        Me.pnlRDO_level1.Controls.Add(Me.rdoUsedOne_program1)
        Me.pnlRDO_level1.Location = New System.Drawing.Point(5, 15)
        Me.pnlRDO_level1.Name = "pnlRDO_level1"
        Me.pnlRDO_level1.Size = New System.Drawing.Size(120, 95)
        Me.pnlRDO_level1.TabIndex = 4
        '
        'rdoUsedNone_program1
        '
        Me.rdoUsedNone_program1.AutoSize = True
        Me.rdoUsedNone_program1.Location = New System.Drawing.Point(3, 3)
        Me.rdoUsedNone_program1.Name = "rdoUsedNone_program1"
        Me.rdoUsedNone_program1.Size = New System.Drawing.Size(93, 17)
        Me.rdoUsedNone_program1.TabIndex = 3
        Me.rdoUsedNone_program1.TabStop = True
        Me.rdoUsedNone_program1.Text = "Used no helps"
        Me.rdoUsedNone_program1.UseVisualStyleBackColor = True
        '
        'rdoUsedThree_program1
        '
        Me.rdoUsedThree_program1.AutoSize = True
        Me.rdoUsedThree_program1.Location = New System.Drawing.Point(3, 72)
        Me.rdoUsedThree_program1.Name = "rdoUsedThree_program1"
        Me.rdoUsedThree_program1.Size = New System.Drawing.Size(105, 17)
        Me.rdoUsedThree_program1.TabIndex = 2
        Me.rdoUsedThree_program1.TabStop = True
        Me.rdoUsedThree_program1.Text = "Used three helps"
        Me.rdoUsedThree_program1.UseVisualStyleBackColor = True
        '
        'rdoUsedTwo_program1
        '
        Me.rdoUsedTwo_program1.AutoSize = True
        Me.rdoUsedTwo_program1.Location = New System.Drawing.Point(3, 49)
        Me.rdoUsedTwo_program1.Name = "rdoUsedTwo_program1"
        Me.rdoUsedTwo_program1.Size = New System.Drawing.Size(98, 17)
        Me.rdoUsedTwo_program1.TabIndex = 1
        Me.rdoUsedTwo_program1.TabStop = True
        Me.rdoUsedTwo_program1.Text = "Used two helps"
        Me.rdoUsedTwo_program1.UseVisualStyleBackColor = True
        '
        'rdoUsedOne_program1
        '
        Me.rdoUsedOne_program1.AutoSize = True
        Me.rdoUsedOne_program1.Location = New System.Drawing.Point(3, 26)
        Me.rdoUsedOne_program1.Name = "rdoUsedOne_program1"
        Me.rdoUsedOne_program1.Size = New System.Drawing.Size(94, 17)
        Me.rdoUsedOne_program1.TabIndex = 0
        Me.rdoUsedOne_program1.TabStop = True
        Me.rdoUsedOne_program1.Text = "Used one help"
        Me.rdoUsedOne_program1.UseVisualStyleBackColor = True
        '
        'lstStudents_program1
        '
        Me.lstStudents_program1.FormattingEnabled = True
        Me.lstStudents_program1.Items.AddRange(New Object() {"Student1", "Student2"})
        Me.lstStudents_program1.Location = New System.Drawing.Point(5, 116)
        Me.lstStudents_program1.Name = "lstStudents_program1"
        Me.lstStudents_program1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstStudents_program1.Size = New System.Drawing.Size(120, 329)
        Me.lstStudents_program1.TabIndex = 0
        '
        'gbSTinformation
        '
        Me.gbSTinformation.Controls.Add(Me.cmdResetHelps)
        Me.gbSTinformation.Controls.Add(Me.lblProgrammingLevel)
        Me.gbSTinformation.Controls.Add(Me.lblstProgram3)
        Me.gbSTinformation.Controls.Add(Me.lblstProgram2)
        Me.gbSTinformation.Controls.Add(Me.lblstProgram1)
        Me.gbSTinformation.Controls.Add(Me.txtResetPass)
        Me.gbSTinformation.Controls.Add(Me.cmdResetPass)
        Me.gbSTinformation.Controls.Add(Me.lblScore)
        Me.gbSTinformation.Controls.Add(Me.lblHelpsUsed)
        Me.gbSTinformation.Location = New System.Drawing.Point(130, 6)
        Me.gbSTinformation.Name = "gbSTinformation"
        Me.gbSTinformation.Size = New System.Drawing.Size(208, 131)
        Me.gbSTinformation.TabIndex = 15
        Me.gbSTinformation.TabStop = False
        Me.gbSTinformation.Text = "Student Information"
        '
        'cmdResetHelps
        '
        Me.cmdResetHelps.Location = New System.Drawing.Point(8, 102)
        Me.cmdResetHelps.Name = "cmdResetHelps"
        Me.cmdResetHelps.Size = New System.Drawing.Size(186, 23)
        Me.cmdResetHelps.TabIndex = 22
        Me.cmdResetHelps.Text = "Reset Helps"
        Me.cmdResetHelps.UseVisualStyleBackColor = True
        '
        'lblProgrammingLevel
        '
        Me.lblProgrammingLevel.AutoSize = True
        Me.lblProgrammingLevel.Location = New System.Drawing.Point(5, 55)
        Me.lblProgrammingLevel.Name = "lblProgrammingLevel"
        Me.lblProgrammingLevel.Size = New System.Drawing.Size(112, 13)
        Me.lblProgrammingLevel.TabIndex = 21
        Me.lblProgrammingLevel.Text = "Programming Level: [ ]"
        '
        'lblstProgram3
        '
        Me.lblstProgram3.AutoSize = True
        Me.lblstProgram3.Location = New System.Drawing.Point(130, 55)
        Me.lblstProgram3.Name = "lblstProgram3"
        Me.lblstProgram3.Size = New System.Drawing.Size(58, 13)
        Me.lblstProgram3.TabIndex = 20
        Me.lblstProgram3.Text = "Program 3:"
        '
        'lblstProgram2
        '
        Me.lblstProgram2.AutoSize = True
        Me.lblstProgram2.Location = New System.Drawing.Point(130, 35)
        Me.lblstProgram2.Name = "lblstProgram2"
        Me.lblstProgram2.Size = New System.Drawing.Size(58, 13)
        Me.lblstProgram2.TabIndex = 19
        Me.lblstProgram2.Text = "Program 2:"
        '
        'lblstProgram1
        '
        Me.lblstProgram1.AutoSize = True
        Me.lblstProgram1.Location = New System.Drawing.Point(130, 15)
        Me.lblstProgram1.Name = "lblstProgram1"
        Me.lblstProgram1.Size = New System.Drawing.Size(58, 13)
        Me.lblstProgram1.TabIndex = 18
        Me.lblstProgram1.Text = "Program 1:"
        '
        'txtResetPass
        '
        Me.txtResetPass.Location = New System.Drawing.Point(6, 75)
        Me.txtResetPass.Name = "txtResetPass"
        Me.txtResetPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtResetPass.Size = New System.Drawing.Size(81, 20)
        Me.txtResetPass.TabIndex = 17
        '
        'cmdResetPass
        '
        Me.cmdResetPass.Location = New System.Drawing.Point(93, 75)
        Me.cmdResetPass.Name = "cmdResetPass"
        Me.cmdResetPass.Size = New System.Drawing.Size(101, 23)
        Me.cmdResetPass.TabIndex = 16
        Me.cmdResetPass.Text = "Reset Password"
        Me.cmdResetPass.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(5, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(41, 13)
        Me.lblScore.TabIndex = 15
        Me.lblScore.Text = "Score: "
        '
        'lblHelpsUsed
        '
        Me.lblHelpsUsed.AutoSize = True
        Me.lblHelpsUsed.Location = New System.Drawing.Point(5, 15)
        Me.lblHelpsUsed.Name = "lblHelpsUsed"
        Me.lblHelpsUsed.Size = New System.Drawing.Size(104, 13)
        Me.lblHelpsUsed.TabIndex = 14
        Me.lblHelpsUsed.Text = "Total Helps Used: [ ]"
        '
        'gbDelete
        '
        Me.gbDelete.Controls.Add(Me.cmdConfirmDeletion)
        Me.gbDelete.Controls.Add(Me.cmdHideDelete)
        Me.gbDelete.Location = New System.Drawing.Point(132, 273)
        Me.gbDelete.Name = "gbDelete"
        Me.gbDelete.Size = New System.Drawing.Size(116, 83)
        Me.gbDelete.TabIndex = 13
        Me.gbDelete.TabStop = False
        Me.gbDelete.Text = "Are you sure?"
        Me.gbDelete.Visible = False
        '
        'cmdConfirmDeletion
        '
        Me.cmdConfirmDeletion.Location = New System.Drawing.Point(17, 48)
        Me.cmdConfirmDeletion.Name = "cmdConfirmDeletion"
        Me.cmdConfirmDeletion.Size = New System.Drawing.Size(73, 23)
        Me.cmdConfirmDeletion.TabIndex = 10
        Me.cmdConfirmDeletion.Text = "Yes"
        Me.cmdConfirmDeletion.UseVisualStyleBackColor = True
        '
        'cmdHideDelete
        '
        Me.cmdHideDelete.Location = New System.Drawing.Point(17, 19)
        Me.cmdHideDelete.Name = "cmdHideDelete"
        Me.cmdHideDelete.Size = New System.Drawing.Size(73, 23)
        Me.cmdHideDelete.TabIndex = 9
        Me.cmdHideDelete.Text = "No"
        Me.cmdHideDelete.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(6, 305)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(118, 23)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete Student"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdShowStudentAdd
        '
        Me.cmdShowStudentAdd.Location = New System.Drawing.Point(8, 334)
        Me.cmdShowStudentAdd.Name = "cmdShowStudentAdd"
        Me.cmdShowStudentAdd.Size = New System.Drawing.Size(118, 23)
        Me.cmdShowStudentAdd.TabIndex = 11
        Me.cmdShowStudentAdd.Text = "Add New Student"
        Me.cmdShowStudentAdd.UseVisualStyleBackColor = True
        '
        'gbAddStudent
        '
        Me.gbAddStudent.Controls.Add(Me.cmdAdd)
        Me.gbAddStudent.Controls.Add(Me.txtUsername)
        Me.gbAddStudent.Controls.Add(Me.cbProgramlevel)
        Me.gbAddStudent.Controls.Add(Me.lblUsername)
        Me.gbAddStudent.Controls.Add(Me.txtPassword)
        Me.gbAddStudent.Controls.Add(Me.lblPassword)
        Me.gbAddStudent.Location = New System.Drawing.Point(8, 362)
        Me.gbAddStudent.Name = "gbAddStudent"
        Me.gbAddStudent.Size = New System.Drawing.Size(183, 120)
        Me.gbAddStudent.TabIndex = 10
        Me.gbAddStudent.TabStop = False
        Me.gbAddStudent.Text = "Add a new student"
        Me.gbAddStudent.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(5, 93)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(172, 23)
        Me.cmdAdd.TabIndex = 9
        Me.cmdAdd.Text = "Add student"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(61, 13)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(116, 20)
        Me.txtUsername.TabIndex = 3
        '
        'cbProgramlevel
        '
        Me.cbProgramlevel.FormattingEnabled = True
        Me.cbProgramlevel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbProgramlevel.Location = New System.Drawing.Point(61, 66)
        Me.cbProgramlevel.Name = "cbProgramlevel"
        Me.cbProgramlevel.Size = New System.Drawing.Size(116, 21)
        Me.cbProgramlevel.TabIndex = 8
        Me.cbProgramlevel.Text = "Programming Level"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(0, 16)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(61, 39)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(116, 20)
        Me.txtPassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(2, 42)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'cmdRefreshIt
        '
        Me.cmdRefreshIt.Location = New System.Drawing.Point(6, 276)
        Me.cmdRefreshIt.Name = "cmdRefreshIt"
        Me.cmdRefreshIt.Size = New System.Drawing.Size(118, 23)
        Me.cmdRefreshIt.TabIndex = 2
        Me.cmdRefreshIt.Text = "Refresh students"
        Me.cmdRefreshIt.UseVisualStyleBackColor = True
        '
        'lstBoxStudents
        '
        Me.lstBoxStudents.FormattingEnabled = True
        Me.lstBoxStudents.Items.AddRange(New Object() {"Student1", "Student2"})
        Me.lstBoxStudents.Location = New System.Drawing.Point(6, 6)
        Me.lstBoxStudents.Name = "lstBoxStudents"
        Me.lstBoxStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstBoxStudents.Size = New System.Drawing.Size(118, 264)
        Me.lstBoxStudents.TabIndex = 1
        '
        'tbPage_Code
        '
        Me.tbPage_Code.Controls.Add(Me.gbProgramLevel3)
        Me.tbPage_Code.Controls.Add(Me.rtxtCode)
        Me.tbPage_Code.Controls.Add(Me.gbProgramLevel2)
        Me.tbPage_Code.Controls.Add(Me.cmdUpdate)
        Me.tbPage_Code.Controls.Add(Me.gbProgramLevel1)
        Me.tbPage_Code.Location = New System.Drawing.Point(4, 22)
        Me.tbPage_Code.Name = "tbPage_Code"
        Me.tbPage_Code.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPage_Code.Size = New System.Drawing.Size(757, 488)
        Me.tbPage_Code.TabIndex = 1
        Me.tbPage_Code.Text = "Code"
        Me.tbPage_Code.UseVisualStyleBackColor = True
        '
        'gbProgramLevel3
        '
        Me.gbProgramLevel3.Controls.Add(Me.rdHint3)
        Me.gbProgramLevel3.Controls.Add(Me.rdHint2)
        Me.gbProgramLevel3.Controls.Add(Me.rdHint1)
        Me.gbProgramLevel3.Location = New System.Drawing.Point(652, 189)
        Me.gbProgramLevel3.Name = "gbProgramLevel3"
        Me.gbProgramLevel3.Size = New System.Drawing.Size(102, 91)
        Me.gbProgramLevel3.TabIndex = 4
        Me.gbProgramLevel3.TabStop = False
        Me.gbProgramLevel3.Text = "Hint"
        '
        'rdHint3
        '
        Me.rdHint3.AutoSize = True
        Me.rdHint3.Location = New System.Drawing.Point(6, 66)
        Me.rdHint3.Name = "rdHint3"
        Me.rdHint3.Size = New System.Drawing.Size(53, 17)
        Me.rdHint3.TabIndex = 7
        Me.rdHint3.TabStop = True
        Me.rdHint3.Text = "Hint 3"
        Me.rdHint3.UseVisualStyleBackColor = True
        '
        'rdHint2
        '
        Me.rdHint2.AutoSize = True
        Me.rdHint2.Location = New System.Drawing.Point(6, 43)
        Me.rdHint2.Name = "rdHint2"
        Me.rdHint2.Size = New System.Drawing.Size(53, 17)
        Me.rdHint2.TabIndex = 6
        Me.rdHint2.TabStop = True
        Me.rdHint2.Text = "Hint 2"
        Me.rdHint2.UseVisualStyleBackColor = True
        '
        'rdHint1
        '
        Me.rdHint1.AutoSize = True
        Me.rdHint1.Location = New System.Drawing.Point(6, 19)
        Me.rdHint1.Name = "rdHint1"
        Me.rdHint1.Size = New System.Drawing.Size(53, 17)
        Me.rdHint1.TabIndex = 5
        Me.rdHint1.TabStop = True
        Me.rdHint1.Text = "Hint 1"
        Me.rdHint1.UseVisualStyleBackColor = True
        '
        'rtxtCode
        '
        Me.rtxtCode.AcceptsTab = True
        Me.rtxtCode.ContextMenuStrip = Me.cmsRightClickText
        Me.rtxtCode.EnableAutoDragDrop = True
        Me.rtxtCode.Location = New System.Drawing.Point(0, 0)
        Me.rtxtCode.Name = "rtxtCode"
        Me.rtxtCode.ShowSelectionMargin = True
        Me.rtxtCode.Size = New System.Drawing.Size(644, 488)
        Me.rtxtCode.TabIndex = 0
        Me.rtxtCode.Text = ""
        '
        'cmsRightClickText
        '
        Me.cmsRightClickText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClearText, Me.cmdPaste, Me.cmdCopy, Me.cmdSelectAll})
        Me.cmsRightClickText.Name = "cmsRightClickText"
        Me.cmsRightClickText.Size = New System.Drawing.Size(123, 92)
        '
        'cmdClearText
        '
        Me.cmdClearText.Name = "cmdClearText"
        Me.cmdClearText.Size = New System.Drawing.Size(122, 22)
        Me.cmdClearText.Text = "Clear"
        '
        'cmdPaste
        '
        Me.cmdPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPasteAll})
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(122, 22)
        Me.cmdPaste.Text = "Paste"
        '
        'cmdPasteAll
        '
        Me.cmdPasteAll.Name = "cmdPasteAll"
        Me.cmdPasteAll.Size = New System.Drawing.Size(119, 22)
        Me.cmdPasteAll.Text = "Paste All"
        '
        'cmdCopy
        '
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(122, 22)
        Me.cmdCopy.Text = "Copy"
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(122, 22)
        Me.cmdSelectAll.Text = "Select All"
        '
        'gbProgramLevel2
        '
        Me.gbProgramLevel2.Controls.Add(Me.rdProgram3)
        Me.gbProgramLevel2.Controls.Add(Me.rdProgram2)
        Me.gbProgramLevel2.Controls.Add(Me.rdProgram1)
        Me.gbProgramLevel2.Location = New System.Drawing.Point(650, 83)
        Me.gbProgramLevel2.Name = "gbProgramLevel2"
        Me.gbProgramLevel2.Size = New System.Drawing.Size(102, 100)
        Me.gbProgramLevel2.TabIndex = 3
        Me.gbProgramLevel2.TabStop = False
        Me.gbProgramLevel2.Text = "Program"
        '
        'rdProgram3
        '
        Me.rdProgram3.AutoSize = True
        Me.rdProgram3.Location = New System.Drawing.Point(6, 66)
        Me.rdProgram3.Name = "rdProgram3"
        Me.rdProgram3.Size = New System.Drawing.Size(73, 17)
        Me.rdProgram3.TabIndex = 4
        Me.rdProgram3.TabStop = True
        Me.rdProgram3.Text = "Program 3"
        Me.rdProgram3.UseVisualStyleBackColor = True
        '
        'rdProgram2
        '
        Me.rdProgram2.AutoSize = True
        Me.rdProgram2.Location = New System.Drawing.Point(6, 43)
        Me.rdProgram2.Name = "rdProgram2"
        Me.rdProgram2.Size = New System.Drawing.Size(73, 17)
        Me.rdProgram2.TabIndex = 3
        Me.rdProgram2.TabStop = True
        Me.rdProgram2.Text = "Program 2"
        Me.rdProgram2.UseVisualStyleBackColor = True
        '
        'rdProgram1
        '
        Me.rdProgram1.AutoSize = True
        Me.rdProgram1.Location = New System.Drawing.Point(6, 19)
        Me.rdProgram1.Name = "rdProgram1"
        Me.rdProgram1.Size = New System.Drawing.Size(73, 17)
        Me.rdProgram1.TabIndex = 2
        Me.rdProgram1.TabStop = True
        Me.rdProgram1.Text = "Program 1"
        Me.rdProgram1.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(650, 286)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(102, 193)
        Me.cmdUpdate.TabIndex = 1
        Me.cmdUpdate.Text = "Update Code"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'gbProgramLevel1
        '
        Me.gbProgramLevel1.Controls.Add(Me.rdProgramLevel_2)
        Me.gbProgramLevel1.Controls.Add(Me.rdProgramLevel_1)
        Me.gbProgramLevel1.Location = New System.Drawing.Point(650, 6)
        Me.gbProgramLevel1.Name = "gbProgramLevel1"
        Me.gbProgramLevel1.Size = New System.Drawing.Size(102, 71)
        Me.gbProgramLevel1.TabIndex = 2
        Me.gbProgramLevel1.TabStop = False
        Me.gbProgramLevel1.Text = "Programming"
        '
        'rdProgramLevel_2
        '
        Me.rdProgramLevel_2.AutoSize = True
        Me.rdProgramLevel_2.Location = New System.Drawing.Point(6, 44)
        Me.rdProgramLevel_2.Name = "rdProgramLevel_2"
        Me.rdProgramLevel_2.Size = New System.Drawing.Size(95, 17)
        Me.rdProgramLevel_2.TabIndex = 1
        Me.rdProgramLevel_2.TabStop = True
        Me.rdProgramLevel_2.Text = "Programming 2"
        Me.rdProgramLevel_2.UseVisualStyleBackColor = True
        '
        'rdProgramLevel_1
        '
        Me.rdProgramLevel_1.AutoSize = True
        Me.rdProgramLevel_1.Location = New System.Drawing.Point(6, 21)
        Me.rdProgramLevel_1.Name = "rdProgramLevel_1"
        Me.rdProgramLevel_1.Size = New System.Drawing.Size(95, 17)
        Me.rdProgramLevel_1.TabIndex = 0
        Me.rdProgramLevel_1.TabStop = True
        Me.rdProgramLevel_1.Text = "Programming 1"
        Me.rdProgramLevel_1.UseVisualStyleBackColor = True
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
        'TblCodeBindingSource
        '
        Me.TblCodeBindingSource.DataMember = "tblCode"
        Me.TblCodeBindingSource.DataSource = Me.MRNHintsDataSetBindingSource
        '
        'TblCodeTableAdapter
        '
        Me.TblCodeTableAdapter.ClearBeforeFill = True
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
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 535)
        Me.Controls.Add(Me.TABS_Control)
        Me.Controls.Add(Me.msFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msFile
        Me.Name = "frmAdmin"
        Me.Text = "Administrator Panel"
        Me.msFile.ResumeLayout(False)
        Me.msFile.PerformLayout()
        Me.pnlRDO_level3.ResumeLayout(False)
        Me.pnlRDO_level3.PerformLayout()
        Me.TABS_Control.ResumeLayout(False)
        Me.tbPage_Students.ResumeLayout(False)
        Me.gbPrograms.ResumeLayout(False)
        Me.gbProgram3.ResumeLayout(False)
        Me.gbProgram2.ResumeLayout(False)
        Me.pnlRDO_level2.ResumeLayout(False)
        Me.pnlRDO_level2.PerformLayout()
        Me.gbProgram1.ResumeLayout(False)
        Me.pnlRDO_level1.ResumeLayout(False)
        Me.pnlRDO_level1.PerformLayout()
        Me.gbSTinformation.ResumeLayout(False)
        Me.gbSTinformation.PerformLayout()
        Me.gbDelete.ResumeLayout(False)
        Me.gbAddStudent.ResumeLayout(False)
        Me.gbAddStudent.PerformLayout()
        Me.tbPage_Code.ResumeLayout(False)
        Me.gbProgramLevel3.ResumeLayout(False)
        Me.gbProgramLevel3.PerformLayout()
        Me.cmsRightClickText.ResumeLayout(False)
        Me.gbProgramLevel2.ResumeLayout(False)
        Me.gbProgramLevel2.PerformLayout()
        Me.gbProgramLevel1.ResumeLayout(False)
        Me.gbProgramLevel1.PerformLayout()
        CType(Me._2016_MRN_HintsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRNHintsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msFile As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrAutoRefresh As System.Windows.Forms.Timer
    Friend WithEvents cmdToggleRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlRDO_level3 As System.Windows.Forms.Panel
    Friend WithEvents rdoUsedThree_program3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedTwo_program3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedOne_program3 As System.Windows.Forms.RadioButton
    Friend WithEvents lstStudents_program3 As System.Windows.Forms.ListBox
    Friend WithEvents TABS_Control As System.Windows.Forms.TabControl
    Friend WithEvents tbPage_Students As System.Windows.Forms.TabPage
    Friend WithEvents gbPrograms As System.Windows.Forms.GroupBox
    Friend WithEvents gbProgram3 As System.Windows.Forms.GroupBox
    Friend WithEvents gbProgram2 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlRDO_level2 As System.Windows.Forms.Panel
    Friend WithEvents rdoUsedThree_program2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedTwo_program2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedOne_program2 As System.Windows.Forms.RadioButton
    Friend WithEvents lstStudents_program2 As System.Windows.Forms.ListBox
    Friend WithEvents gbProgram1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlRDO_level1 As System.Windows.Forms.Panel
    Friend WithEvents rdoUsedThree_program1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedTwo_program1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedOne_program1 As System.Windows.Forms.RadioButton
    Friend WithEvents lstStudents_program1 As System.Windows.Forms.ListBox
    Friend WithEvents gbSTinformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblProgrammingLevel As System.Windows.Forms.Label
    Friend WithEvents lblstProgram3 As System.Windows.Forms.Label
    Friend WithEvents lblstProgram2 As System.Windows.Forms.Label
    Friend WithEvents lblstProgram1 As System.Windows.Forms.Label
    Friend WithEvents txtResetPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdResetPass As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblHelpsUsed As System.Windows.Forms.Label
    Friend WithEvents gbDelete As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConfirmDeletion As System.Windows.Forms.Button
    Friend WithEvents cmdHideDelete As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdShowStudentAdd As System.Windows.Forms.Button
    Friend WithEvents gbAddStudent As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cbProgramlevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents cmdRefreshIt As System.Windows.Forms.Button
    Friend WithEvents lstBoxStudents As System.Windows.Forms.ListBox
    Friend WithEvents tbPage_Code As System.Windows.Forms.TabPage
    Friend WithEvents rdoUsedNone_program1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedNone_program3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUsedNone_program2 As System.Windows.Forms.RadioButton
    Friend WithEvents rtxtCode As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents gbProgramLevel1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdProgramLevel_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdProgramLevel_1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbProgramLevel2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdProgram3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdProgram2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdProgram1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbProgramLevel3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdHint3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdHint2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdHint1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdResetHelps As System.Windows.Forms.Button
    Friend WithEvents cmsRightClickText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdClearText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPasteAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _2016_MRN_HintsDataSet As FinalProgram._2016_MRN_HintsDataSet
    Friend WithEvents MRNHintsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCodeTableAdapter As FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblCodeTableAdapter
    Friend WithEvents TblUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserTableAdapter As FinalProgram._2016_MRN_HintsDataSetTableAdapters.tblUserTableAdapter
End Class
