<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarClientes
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
        dgvMostrarClientes = New DataGridView()
        Label1 = New Label()
        btnCancelar = New Button()
        CType(dgvMostrarClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMostrarClientes
        ' 
        dgvMostrarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMostrarClientes.Enabled = False
        dgvMostrarClientes.Location = New Point(22, 76)
        dgvMostrarClientes.Name = "dgvMostrarClientes"
        dgvMostrarClientes.RowHeadersWidth = 51
        dgvMostrarClientes.Size = New Size(916, 249)
        dgvMostrarClientes.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 38)
        Label1.TabIndex = 19
        Label1.Text = "Listado de clientes"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(836, 331)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 20
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmMostrarClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(954, 388)
        Controls.Add(btnCancelar)
        Controls.Add(Label1)
        Controls.Add(dgvMostrarClientes)
        Name = "frmMostrarClientes"
        Text = "Mostrar Clientes"
        CType(dgvMostrarClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMostrarClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
End Class
