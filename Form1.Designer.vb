<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BestsellersManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstBestsellers = New ListBox()
        txtNewBestseller = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        SuspendLayout()
        ' 
        ' lstBestsellers
        ' 
        lstBestsellers.FormattingEnabled = True
        lstBestsellers.ItemHeight = 15
        lstBestsellers.Location = New Point(345, 77)
        lstBestsellers.Name = "lstBestsellers"
        lstBestsellers.Size = New Size(301, 139)
        lstBestsellers.TabIndex = 0
        ' 
        ' txtNewBestseller
        ' 
        txtNewBestseller.Location = New Point(345, 48)
        txtNewBestseller.Name = "txtNewBestseller"
        txtNewBestseller.Size = New Size(301, 23)
        txtNewBestseller.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(571, 222)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(490, 222)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(75, 23)
        btnRemove.TabIndex = 3
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' BestsellersManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtNewBestseller)
        Controls.Add(lstBestsellers)
        Name = "BestsellersManager"
        Text = "BestsellersManager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstBestsellers As ListBox
    Friend WithEvents txtNewBestseller As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
End Class
