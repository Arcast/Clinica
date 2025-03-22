<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnIngresar = New Button()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(98, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 31)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese los datos del usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 28)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(60, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 28)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña"
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(302, 242)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(102, 45)
        btnIngresar.TabIndex = 3
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(212, 113)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 34)
        txtUsuario.TabIndex = 4
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContraseña.Location = New Point(212, 170)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(192, 34)
        txtContraseña.TabIndex = 5
        ' 
        ' frmInicioSesion
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(457, 317)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(btnIngresar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmInicioSesion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inico de Sesión"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox

End Class
