'Student Name: Dakota Parrish
'Student Number: 100764512
'Program Name: Lab 5 - Text Editor
'Date: July 30, 2020
'Description: The purpose of this windows form application is to simply act as a text editor similar to
'             the likes of the 'Notepad' application. It allows the user to write some text in a textbox and 
'             save the file as a .txt file. The user also has the options to create a new file, open a pre-existing file
'             and the user is also given the option to close the current file they are working on as well as exiting the 
'             form. Any time the user tries to open a new file, or create a new file or even close the current file, the
'             user will be confronted with a message box asking the user if they want to confirm the closing action.
'             This text editor also includes basic functions such as copy, cut, and paste. Finally, the user is given
'             the option of seeing an about tab which basically just tells the user who made the program.
Option Strict On
Imports System.IO
Public Class frmLab5TextEditor
#Region "Variables Declaration and Constants"
    'Declares a currentFileEditState variable as a Boolean.
    Dim currentFileEditState As Boolean
    'Declares destinationOfFile variable as a String.
    Dim destinationOfFile As String
#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' TextEditorTextChangedState Event Handler - Used to keep track of whether the text field has been edited or not.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextEditorTextChangedState(sender As Object, e As EventArgs) Handles txtTextEditor.TextChanged
        'Sets the currentFileEditState variable to true. 
        currentFileEditState = True
    End Sub
    ''' <summary>
    ''' MenuItemFileNewClick Event Handler - Used whenever the user clicks on the new option under the file menu. If
    ''' there is text in the text field, it will ask the user if they are sure if they want to create a new file.
    ''' When a new file is opened, the text field is cleared. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileNewClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        'Calls the ConfirmClose() sub procedure.
        ConfirmClose()

        'If the currentFileEditState is false then
        If currentFileEditState = False Then
            'The destinationOfFile variable is cleared.
            destinationOfFile = String.Empty
            'The txtTextEditor text property is cleared.
            txtTextEditor.Text = String.Empty
            'The form's text is set to 'Text Editor ".
            Me.Text = "Text Editor "
            'The txtTextEditor enabled property is set to true.
            txtTextEditor.Enabled = True
            'The currentFileEditState is set to false.
            currentFileEditState = False
        End If
    End Sub
    ''' <summary>
    ''' MenuItemFileOpenClick Event Handler - Handles whenever the user clicks on the open option under the file menu.
    ''' Whenever the user wants to open a file, it will first prompt the user if they are sure they want to close the
    ''' current file they are working on. It will then check to see if the file is being edited, if not, it will open
    ''' a window that shows all of the files the user can wish to open. If there is no path for the current file,
    ''' it will open the file that the user wants to open and set the form's text to the path of the file. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileOpenClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        'Calls the ConfirmClose() sub procedure.
        ConfirmClose()
        'If the currentFileState is set to true then
        If currentFileEditState = False Then
            'Initializes an instance of the OpenFileDialog class named openCurrentFile.
            Dim openCurrentFile As New OpenFileDialog
            'Opens a dialog box to show a list of files the user to can select to open.
            openCurrentFile.ShowDialog()
            'The variable destinationOfFile is assigned the OpenFileDialog's classes' FileName property.
            destinationOfFile = openCurrentFile.FileName
            'If the destinationOfFile is NOT empty Then
            If Not destinationOfFile = String.Empty Then
                'Initializes a new FileStream instance called fileOpen with the path being destinationOfFile,
                'creation mode of Open, and read/write permission of Read.
                Dim fileOpen As New FileStream(destinationOfFile, FileMode.Open, FileAccess.Read)
                'Initializes a new StreamReader instance called fileReader that uses the fileOpen FileStream. 
                Dim fileReader As New StreamReader(fileOpen)
                'The txtTextEditor text property is assigned to the StreamReader's ReadToEnd() function.
                txtTextEditor.Text = fileReader.ReadToEnd()
                'Closes the fileReader's object.
                fileReader.Close()
                'Sets the form's text property to "Text Editor " and the destinatonOfFile name.
                Me.Text = "Text Editor - " & destinationOfFile
                'Sets the currentFileEditState value to False.
                currentFileEditState = False
            End If
        End If
    End Sub
    ''' <summary>
    ''' MenuItemFileSaveClick Event Handler - Handles whenever the user clicks on the save option under the file menu.
    ''' Calls the Save sub procedure defined below.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileSaveClick(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'Calls the Save() sub procedure with the parameter being the destinationOfFile variable.
        Save(destinationOfFile)
    End Sub
    ''' <summary>
    ''' MenuItemFileSaveClick Event Handler - Handles whenever the user clicks on the save as option under the file menu.
    ''' Similar to the MenuItemFileSaveClick's event handler, it will call the save sub procedure defined below except
    ''' except this time it checks to see if the file name is empty or not.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileSaveAsClick(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        'Declares a variable called emptyFileName and assigns the value to a blank string.
        Dim emptyFileName As String = String.Empty
        'Calls the Save() sub procedure with the parameter being the destinationOfFile variable.
        Save(emptyFileName)
    End Sub
    ''' <summary>
    ''' MenuItemFileCloseClick Event Handler - Handles whenever the user clicks on the close option under the file menu.
    ''' It will first ask if the user wants to close the current window. Then it will check to see if the file is
    ''' edited. If it is not being edited, then all of the fields are cleared and the form's text is set to the default
    ''' 'Text Editor'. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileCloseClick(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        'Calls the ConfirmClose() sub procedure.
        ConfirmClose()

        'Checks if the currentFileEditState is set to False Then
        If currentFileEditState = False Then
            'Clears the destinationOfFile string.
            destinationOfFile = String.Empty
            'Clears the text field.
            txtTextEditor.Text = String.Empty
            'Sets the form's text to 'Text Editor'.
            Me.Text = "Text Editor"
            'Sets the currentFileEditState to false.
            currentFileEditState = False
        End If
    End Sub
    ''' <summary>
    ''' MenuItemFileExitClick Event Handler - Handles whenever the user clicks on the exit option under the file menu.
    ''' Essentially asks the user if they want to exit the application. Then it will gracefully exit the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemFileExitClick(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Calls the ConfirmClose() sub procedure.
        ConfirmClose()

        'If the currentFileEditState is false then
        If currentFileEditState = False Then
            'Gracefully closes the application.
            Application.Exit()
        End If
    End Sub
    ''' <summary>
    ''' MenuItemEditCopyClick Event Handler - Handles whenever the user clicks on the copy option under the edit menu.
    ''' Copies whatever the user has highlighted in the text field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemEditCopyClick(sender As Object, e As EventArgs) Handles nmuEditCopy.Click
        'Clears the clipboard.
        Clipboard.Clear()

        'If there is no highlighted text in the text editor Then
        If Not txtTextEditor.SelectedText = String.Empty Then
            'Sets the clipboard's text to the highlighted text.
            My.Computer.Clipboard.SetText(txtTextEditor.SelectedText)
        End If
    End Sub
    ''' <summary>
    ''' MenuItemEditCutClick Event Handler - Handles whenever the user clicks on the cut option under the edit menu.
    ''' Cuts whatever the user has highlighted in the text field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuEditCutClick(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        'Clears the clipboard.
        Clipboard.Clear()

        'If there is no highlighted text in the text editor Then
        If Not txtTextEditor.SelectedText = String.Empty Then
            'Set's the clipboard's text to the highlighted text.
            My.Computer.Clipboard.SetText(txtTextEditor.SelectedText)
            'Clears the selected text.
            txtTextEditor.SelectedText = String.Empty
        End If
    End Sub
    ''' <summary>
    ''' MenuItemEditPasteClick Event Handler - Handles whenever the user clicks on the paste option under the edit menu.
    ''' Pastes whatever is in the user's clipboard.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuEditPasteClick(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        'Grabs the text from the user's clipboard and pastes the text in the text field.
        txtTextEditor.SelectedText = My.Computer.Clipboard.GetText()
    End Sub
    ''' <summary>
    ''' MenuItemHelpAboutClick Event Handler - Handles whenever the user clicks on the about option under the help menu.
    ''' Shows information about the program such as the course the student is in, the name of the lab, and the studen't name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuHelpAboutClick(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "Lab #5 - Text Editor" & vbCrLf & vbCrLf & "Dakota Parrish", "About")
    End Sub
#End Region

#Region "Sub Procedures and Methods"
    ''' <summary>
    ''' ConfirmClose() sub procedure - Confirms with the user if they want to close the current file or if they want to
    ''' keep the file opened.
    ''' </summary>
    Sub ConfirmClose()
        'If the currentFileEditState is True Then
        If currentFileEditState = True Then
            'Message box with the options of yes and no appears asking the user if they want to close the file or not.
            'if the user responds with yes.
            If MsgBox("You have unsaved changes. Are you sure want to close this file?", MsgBoxStyle.YesNo, "Text Editor") = MsgBoxResult.Yes Then
                'The currentFileEditState is set to False.
                currentFileEditState = False
            Else
                'Otherwise, the currentFileEditState is set to True.
                currentFileEditState = True
            End If
        Else
            'Otherwise, the currentFileEditState is set to False.
            currentFileEditState = False
        End If
    End Sub
    ''' <summary>
    ''' Save Sub Procedure - Saves or does not save the current file the user is working on in the text editor.
    ''' </summary>
    ''' <param name="destinationOfFile"></param>
    Sub Save(destinationOfFile As String)
        'If the destinationOfFile is NOT empty Then
        If Not destinationOfFile = String.Empty Then
            'Initializes a new FileStream class called fileSave with the specified path being the destinationOfFile string,
            'a creation mode being create, and a read/write permission being write.
            Dim fileSave As New FileStream(destinationOfFile, FileMode.Create, FileAccess.Write)
            'While using the fileSave FileStream.
            Using (fileSave)
                'Initializes a new StreamWriter class called saveFileWriter using a parameter of the fileSave FileStream.
                Dim saveFileWriter As New StreamWriter(fileSave)
                'Using the StreamWriter, it uses the Write method and uses the txtTextEditor.Text property as the parameter.
                saveFileWriter.Write(txtTextEditor.Text)
                'Closes the StreamWriter class.
                saveFileWriter.Close()
                'Sets the currentFileEditState to False.
                currentFileEditState = False
                'Sets the form's text to 'Text Editor . ' and the name of the destinationOfFile string.
                Me.Text = "Text Editor . " & destinationOfFile
                'Sets the currentFileEditState to False once again.
                currentFileEditState = False
            End Using
        Else
            'Otherwise, initializes a new instance of the SaveFileDialog class called saveFile.
            Dim saveFile As New SaveFileDialog
            'Sets the saveFile filter to the .txt filter for all text files.
            saveFile.Filter = "Text Files (*.txt)|*.txt"
            'Sets the default extension of the SaveFileDialog class to .txt.
            saveFile.DefaultExt = "txt"
            'Opens up a file explorer window that allows the user to save the file.
            saveFile.ShowDialog()
            'Sets the destinationOfFile value to the SaveFileDialog's FileName property.
            destinationOfFile = saveFile.FileName

            'If the destinationOfFile is NOT empty Then.
            If Not destinationOfFile = String.Empty Then
                'Initializes a new FileStream class called fileSave with the specified path being the destinationOfFile string,
                'a creation mode being create, and a read/write permission being write.
                Dim fileSave As New FileStream(destinationOfFile, FileMode.Create, FileAccess.Write)
                'While using the fileSave FileStream.
                Using (fileSave)
                    'Initializes a new StreamWriter class called saveFileWriter using a parameter of the fileSave FileStream.
                    Dim saveFileWriter As New StreamWriter(fileSave)
                    'Using the StreamWriter, it uses the Write method and uses the txtTextEditor.Text property as the parameter.
                    saveFileWriter.Write(txtTextEditor.Text)
                    'Closes the StreamWriter class.
                    saveFileWriter.Close()
                    'Sets the currentFileEditState to False.
                    currentFileEditState = False
                    'Sets the form's text to 'Text Editor . ' and the name of the destinationOfFile string.
                    Me.Text = "Text Editor . " & destinationOfFile
                    'Sets the currentFileEditState to False.
                    currentFileEditState = False
                End Using
            End If
        End If
    End Sub
#End Region
End Class
