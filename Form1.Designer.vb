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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.combo_group = New System.Windows.Forms.ComboBox()
        Me.status_checkbox = New System.Windows.Forms.CheckBox()
        Me.date_expired = New System.Windows.Forms.DateTimePicker()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.grid_data = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.lbl_pricw = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grid_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
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
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MistyRose
        Me.Label1.Location = New System.Drawing.Point(167, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CRUD Operation into MySQL Databse "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.combo_group)
        Me.Panel2.Controls.Add(Me.status_checkbox)
        Me.Panel2.Controls.Add(Me.date_expired)
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Controls.Add(Me.grid_data)
        Me.Panel2.Controls.Add(Me.lbl_search)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Controls.Add(Me.btn_update)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_clear)
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.txt_price)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.txt_no)
        Me.Panel2.Controls.Add(Me.lbl_pricw)
        Me.Panel2.Controls.Add(Me.lbl_price)
        Me.Panel2.Controls.Add(Me.lbl_name)
        Me.Panel2.Controls.Add(Me.lbl_no)
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 371)
        Me.Panel2.TabIndex = 1
        '
        'combo_group
        '
        Me.combo_group.FormattingEnabled = True
        Me.combo_group.Items.AddRange(New Object() {"Food", "Cosmetic", "Electronics", "Clothes", "Drinks"})
        Me.combo_group.Location = New System.Drawing.Point(148, 142)
        Me.combo_group.Name = "combo_group"
        Me.combo_group.Size = New System.Drawing.Size(133, 21)
        Me.combo_group.TabIndex = 20
        '
        'status_checkbox
        '
        Me.status_checkbox.AutoSize = True
        Me.status_checkbox.Location = New System.Drawing.Point(24, 223)
        Me.status_checkbox.Name = "status_checkbox"
        Me.status_checkbox.Size = New System.Drawing.Size(72, 17)
        Me.status_checkbox.TabIndex = 19
        Me.status_checkbox.Text = "Available"
        Me.status_checkbox.UseVisualStyleBackColor = True
        '
        'date_expired
        '
        Me.date_expired.Location = New System.Drawing.Point(148, 184)
        Me.date_expired.Name = "date_expired"
        Me.date_expired.Size = New System.Drawing.Size(133, 21)
        Me.date_expired.TabIndex = 18
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(21, 189)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(79, 16)
        Me.lbl_date.TabIndex = 17
        Me.lbl_date.Text = "Expire date :"
        '
        'grid_data
        '
        Me.grid_data.BackgroundColor = System.Drawing.Color.Azure
        Me.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.grid_data.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.grid_data.Location = New System.Drawing.Point(332, 49)
        Me.grid_data.Name = "grid_data"
        Me.grid_data.ReadOnly = True
        Me.grid_data.RowTemplate.Height = 28
        Me.grid_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_data.Size = New System.Drawing.Size(447, 308)
        Me.grid_data.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Product Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Product Group"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 96
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Expire Date"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 84
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 65
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.Location = New System.Drawing.Point(329, 11)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(54, 16)
        Me.lbl_search.TabIndex = 15
        Me.lbl_search.Text = "Search :"
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Location = New System.Drawing.Point(404, 11)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(209, 21)
        Me.txt_search.TabIndex = 14
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightCoral
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.Location = New System.Drawing.Point(36, 314)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 37)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save.Location = New System.Drawing.Point(36, 263)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 37)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Black
        Me.btn_clear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_clear.Location = New System.Drawing.Point(136, 263)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(81, 37)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(136, 314)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 37)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(148, 100)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(133, 21)
        Me.txt_price.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(148, 63)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(133, 21)
        Me.txt_name.TabIndex = 8
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(148, 26)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(133, 21)
        Me.txt_no.TabIndex = 5
        '
        'lbl_pricw
        '
        Me.lbl_pricw.AutoSize = True
        Me.lbl_pricw.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pricw.Location = New System.Drawing.Point(21, 142)
        Me.lbl_pricw.Name = "lbl_pricw"
        Me.lbl_pricw.Size = New System.Drawing.Size(96, 16)
        Me.lbl_pricw.TabIndex = 4
        Me.lbl_pricw.Text = "Product Group :"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(21, 105)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(43, 16)
        Me.lbl_price.TabIndex = 3
        Me.lbl_price.Text = "Price :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(21, 64)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(95, 16)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Product Name :"
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(21, 27)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(77, 16)
        Me.lbl_no.TabIndex = 0
        Me.lbl_no.Text = "Product No :"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        CType(Me.grid_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_no As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_pricw As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_no As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_search As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents grid_data As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents date_expired As DateTimePicker
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents combo_group As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
End Class
