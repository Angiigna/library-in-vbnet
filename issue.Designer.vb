<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issue
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BooklistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New librarymanagement.Database1DataSet1()
        Me.BooklistTableAdapter = New librarymanagement.Database1DataSet1TableAdapters.BooklistTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet3 = New librarymanagement.Database1DataSet3()
        Me.BooklistBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooklistTableAdapter1 = New librarymanagement.Database1DataSet3TableAdapters.BooklistTableAdapter()
        Me.BookidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BooklistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooklistBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter bookid"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Issue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 3
        '
        'BooklistBindingSource
        '
        Me.BooklistBindingSource.DataMember = "Booklist"
        Me.BooklistBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooklistTableAdapter
        '
        Me.BooklistTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookidDataGridViewTextBoxColumn, Me.BooknameDataGridViewTextBoxColumn, Me.AuthornameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooklistBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(28, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(404, 281)
        Me.DataGridView1.TabIndex = 4
        '
        'Database1DataSet3
        '
        Me.Database1DataSet3.DataSetName = "Database1DataSet3"
        Me.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooklistBindingSource1
        '
        Me.BooklistBindingSource1.DataMember = "Booklist"
        Me.BooklistBindingSource1.DataSource = Me.Database1DataSet3
        '
        'BooklistTableAdapter1
        '
        Me.BooklistTableAdapter1.ClearBeforeFill = True
        '
        'BookidDataGridViewTextBoxColumn
        '
        Me.BookidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookidDataGridViewTextBoxColumn.DataPropertyName = "bookid"
        Me.BookidDataGridViewTextBoxColumn.HeaderText = "bookid"
        Me.BookidDataGridViewTextBoxColumn.Name = "BookidDataGridViewTextBoxColumn"
        '
        'BooknameDataGridViewTextBoxColumn
        '
        Me.BooknameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BooknameDataGridViewTextBoxColumn.DataPropertyName = "bookname"
        Me.BooknameDataGridViewTextBoxColumn.HeaderText = "bookname"
        Me.BooknameDataGridViewTextBoxColumn.Name = "BooknameDataGridViewTextBoxColumn"
        '
        'AuthornameDataGridViewTextBoxColumn
        '
        Me.AuthornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AuthornameDataGridViewTextBoxColumn.DataPropertyName = "authorname"
        Me.AuthornameDataGridViewTextBoxColumn.HeaderText = "authorname"
        Me.AuthornameDataGridViewTextBoxColumn.Name = "AuthornameDataGridViewTextBoxColumn"
        '
        'issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "issue"
        Me.Text = "issue"
        CType(Me.BooklistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooklistBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet1 As librarymanagement.Database1DataSet1
    Friend WithEvents BooklistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooklistTableAdapter As librarymanagement.Database1DataSet1TableAdapters.BooklistTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet3 As librarymanagement.Database1DataSet3
    Friend WithEvents BooklistBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BooklistTableAdapter1 As librarymanagement.Database1DataSet3TableAdapters.BooklistTableAdapter
    Friend WithEvents BookidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthornameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
