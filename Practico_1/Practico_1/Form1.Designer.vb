<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        LApellido = New Label()
        LNombre = New Label()
        Label3 = New Label()
        TextBoxApellido = New TextBox()
        TextBoxNombre = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        TextBoxResult = New TextBox()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(43, 116)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(66, 20)
        LApellido.TabIndex = 0
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.BackColor = SystemColors.Control
        LNombre.Location = New Point(43, 203)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(64, 20)
        LNombre.TabIndex = 1
        LNombre.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(216, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 2
        ' 
        ' TextBoxApellido
        ' 
        TextBoxApellido.Location = New Point(154, 109)
        TextBoxApellido.Name = "TextBoxApellido"
        TextBoxApellido.Size = New Size(220, 27)
        TextBoxApellido.TabIndex = 3
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(154, 196)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(220, 27)
        TextBoxNombre.TabIndex = 4
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(108, 302)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(94, 29)
        BGuardar.TabIndex = 5
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(262, 302)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(94, 29)
        BEliminar.TabIndex = 6
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxResult
        ' 
        TextBoxResult.Location = New Point(474, 109)
        TextBoxResult.Multiline = True
        TextBoxResult.Name = "TextBoxResult"
        TextBoxResult.Size = New Size(274, 198)
        TextBoxResult.TabIndex = 7
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(608, 394)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(140, 44)
        BSalir.TabIndex = 8
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BSalir)
        Controls.Add(TextBoxResult)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TextBoxNombre)
        Controls.Add(TextBoxApellido)
        Controls.Add(Label3)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents BSalir As Button

End Class
