<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarUsuarios
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
        btnCancelar = New Button()
        dgvMostrarUsuarior = New DataGridView()
        CType(dgvMostrarUsuarior, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(351, 222)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 16
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' dgvMostrarUsuarior
        ' 
        dgvMostrarUsuarior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMostrarUsuarior.Enabled = False
        dgvMostrarUsuarior.Location = New Point(12, 12)
        dgvMostrarUsuarior.Name = "dgvMostrarUsuarior"
        dgvMostrarUsuarior.RowHeadersWidth = 51
        dgvMostrarUsuarior.Size = New Size(441, 204)
        dgvMostrarUsuarior.TabIndex = 17
        ' 
        ' frmMostrarUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(465, 279)
        Controls.Add(dgvMostrarUsuarior)
        Controls.Add(btnCancelar)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMostrarUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mostrar Usuarios"
        CType(dgvMostrarUsuarior, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvMostrarUsuarior As DataGridView
End Class
