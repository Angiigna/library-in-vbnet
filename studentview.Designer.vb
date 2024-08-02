<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentview
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet2 = New librarymanagement.Database1DataSet2()
        Me.IsuuedbooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsuuedbooksTableAdapter = New librarymanagement.Database1DataSet2TableAdapters.IsuuedbooksTableAdapter()
        Me.BookidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibraryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsuuedbooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "calculate due"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter bookid"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(159, 220)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookidDataGridViewTextBoxColumn, Me.LibraryidDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IsuuedbooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(52, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(367, 210)
        Me.DataGridView1.TabIndex = 4
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsuuedbooksBindingSource
        '
        Me.IsuuedbooksBindingSource.DataMember = "Isuuedbooks"
        Me.IsuuedbooksBindingSource.DataSource = Me.Database1DataSet2
        '
        'IsuuedbooksTableAdapter
        '
        Me.IsuuedbooksTableAdapter.ClearBeforeFill = True
        '
        'BookidDataGridViewTextBoxColumn
        '
        Me.BookidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BookidDataGridViewTextBoxColumn.DataPropertyName = "bookid"
        Me.BookidDataGridViewTextBoxColumn.HeaderText = "bookid"
        Me.BookidDataGridViewTextBoxColumn.Name = "BookidDataGridViewTextBoxColumn"
        '
        'LibraryidDataGridViewTextBoxColumn
        '
        Me.LibraryidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibraryidDataGridViewTextBoxColumn.DataPropertyName = "libraryid"
        Me.LibraryidDataGridViewTextBoxColumn.HeaderText = "libraryid"
        Me.LibraryidDataGridViewTextBoxColumn.Name = "LibraryidDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'studentview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 501)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "studentview"
        Me.Text = "studentview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsuuedbooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet2 As librarymanagement.Database1DataSet2
    Friend WithEvents IsuuedbooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IsuuedbooksTableAdapter As librarymanagement.Database1DataSet2TableAdapters.IsuuedbooksTableAdapter
    Friend WithEvents BookidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibraryidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
