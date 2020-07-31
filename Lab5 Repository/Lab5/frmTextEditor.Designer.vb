<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5TextEditor
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
        Me.mnuToolbar = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.nmuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTextEditor = New System.Windows.Forms.TextBox()
        Me.TextEditorToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuToolbar
        '
        Me.mnuToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuToolbar.Location = New System.Drawing.Point(0, 0)
        Me.mnuToolbar.Name = "mnuToolbar"
        Me.mnuToolbar.Size = New System.Drawing.Size(740, 24)
        Me.mnuToolbar.TabIndex = 0
        Me.mnuToolbar.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click to view file options"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Creates new file"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Opens exisiting file"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Saves the current file"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSaveAs.Text = "Save &As"
        Me.mnuFileSaveAs.ToolTipText = "Saves the current file as a specific file type"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileClose.Text = "C&lose"
        Me.mnuFileClose.ToolTipText = "Closes the file"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Exits the application"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nmuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Click to view edit options"
        '
        'nmuEditCopy
        '
        Me.nmuEditCopy.Name = "nmuEditCopy"
        Me.nmuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.nmuEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.nmuEditCopy.Text = "&Copy"
        Me.nmuEditCopy.ToolTipText = "Copies text highlighted"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "Cuts highlighted text"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Pastes copied/cut text."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Click to view help options"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpAbout.Text = "A&bout"
        Me.mnuHelpAbout.ToolTipText = "Shows information about the text editor"
        '
        'txtTextEditor
        '
        Me.txtTextEditor.AcceptsReturn = True
        Me.txtTextEditor.AcceptsTab = True
        Me.txtTextEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextEditor.Location = New System.Drawing.Point(12, 27)
        Me.txtTextEditor.MaxLength = 3276700
        Me.txtTextEditor.Multiline = True
        Me.txtTextEditor.Name = "txtTextEditor"
        Me.txtTextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTextEditor.Size = New System.Drawing.Size(722, 366)
        Me.txtTextEditor.TabIndex = 1
        '
        'frmLab5TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 405)
        Me.Controls.Add(Me.txtTextEditor)
        Me.Controls.Add(Me.mnuToolbar)
        Me.MainMenuStrip = Me.mnuToolbar
        Me.Name = "frmLab5TextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuToolbar.ResumeLayout(False)
        Me.mnuToolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuToolbar As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents nmuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents txtTextEditor As TextBox
    Friend WithEvents TextEditorToolTips As ToolTip
End Class
