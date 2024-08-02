<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewdetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentlibrarydataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Studentlibrarydata = New librarymanagement.Studentlibrarydata()
        Me.Database1DataSet = New librarymanagement.Database1DataSet()
        Me.IsuuedbooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsuuedbooksTableAdapter = New librarymanagement.Database1DataSetTableAdapters.IsuuedbooksTableAdapter()
        Me.BookidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibraryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentlibrarydataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Studentlibrarydata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsuuedbooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookidDataGridViewTextBoxColumn, Me.LibraryidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IsuuedbooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(490, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentlibrarydataBindingSource
        '
        Me.StudentlibrarydataBindingSource.DataSource = Me.Studentlibrarydata
        Me.StudentlibrarydataBindingSource.Position = 0
        '
        'Studentlibrarydata
        '
        Me.Studentlibrarydata.DataSetName = "Studentlibrarydata"
        Me.Studentlibrarydata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsuuedbooksBindingSource
        '
        Me.IsuuedbooksBindingSource.DataMember = "Isuuedbooks"
        Me.IsuuedbooksBindingSource.DataSource = Me.Database1DataSet
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
        'viewdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "viewdetails"
        Me.Text = "view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentlibrarydataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Studentlibrarydata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsuuedbooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudentlibrarydataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Studentlibrarydata As librarymanagement.Studentlibrarydata
    Friend WithEvents Database1DataSet As librarymanagement.Database1DataSet
    Friend WithEvents IsuuedbooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IsuuedbooksTableAdapter As librarymanagement.Database1DataSetTableAdapters.IsuuedbooksTableAdapter
    Friend WithEvents BookidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibraryidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
