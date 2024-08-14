<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.update = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Insert = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_roll = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Managememt"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.update)
        Me.Panel2.Controls.Add(Me.save)
        Me.Panel2.Controls.Add(Me.Insert)
        Me.Panel2.Controls.Add(Me.delete)
        Me.Panel2.Controls.Add(Me.txt_status)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.txt_roll)
        Me.Panel2.Controls.Add(Me.txt_id)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 225)
        Me.Panel2.TabIndex = 1
        '
        'update
        '
        Me.update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.update.Location = New System.Drawing.Point(422, 163)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(81, 37)
        Me.update.TabIndex = 13
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.save.Location = New System.Drawing.Point(201, 163)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(81, 37)
        Me.save.TabIndex = 12
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Insert.Location = New System.Drawing.Point(309, 163)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(81, 37)
        Me.Insert.TabIndex = 11
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.delete.Location = New System.Drawing.Point(545, 163)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(81, 37)
        Me.delete.TabIndex = 10
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(602, 104)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(133, 21)
        Me.txt_status.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(170, 99)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(133, 21)
        Me.txt_name.TabIndex = 8
        '
        'txt_roll
        '
        Me.txt_roll.Location = New System.Drawing.Point(602, 45)
        Me.txt_roll.Name = "txt_roll"
        Me.txt_roll.Size = New System.Drawing.Size(133, 21)
        Me.txt_roll.TabIndex = 7
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(170, 30)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(133, 21)
        Me.txt_id.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(402, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(402, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Roll No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Student Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(800, 149)
        Me.DataGridView1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_roll As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents save As Button
    Friend WithEvents Insert As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
