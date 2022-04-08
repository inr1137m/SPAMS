<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CinchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivitiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AchievementsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpamstableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsdbDataSet = New spams_new.msdbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpamstableTableAdapter = New spams_new.msdbDataSetTableAdapters.spamstableTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpamstableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(897, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.SemDataGridViewTextBoxColumn, Me.CinchDataGridViewTextBoxColumn, Me.AttendanceDataGridViewTextBoxColumn, Me.MarksDataGridViewTextBoxColumn, Me.ActivitiesDataGridViewTextBoxColumn, Me.AchievementsDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.CommunityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpamstableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(992, 296)
        Me.DataGridView1.TabIndex = 4
        '
        'RegnoDataGridViewTextBoxColumn
        '
        Me.RegnoDataGridViewTextBoxColumn.DataPropertyName = "regno"
        Me.RegnoDataGridViewTextBoxColumn.HeaderText = "regno"
        Me.RegnoDataGridViewTextBoxColumn.Name = "RegnoDataGridViewTextBoxColumn"
        Me.RegnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        Me.DeptDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SemDataGridViewTextBoxColumn
        '
        Me.SemDataGridViewTextBoxColumn.DataPropertyName = "sem"
        Me.SemDataGridViewTextBoxColumn.HeaderText = "sem"
        Me.SemDataGridViewTextBoxColumn.Name = "SemDataGridViewTextBoxColumn"
        Me.SemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CinchDataGridViewTextBoxColumn
        '
        Me.CinchDataGridViewTextBoxColumn.DataPropertyName = "cinch"
        Me.CinchDataGridViewTextBoxColumn.HeaderText = "cinch"
        Me.CinchDataGridViewTextBoxColumn.Name = "CinchDataGridViewTextBoxColumn"
        Me.CinchDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendanceDataGridViewTextBoxColumn
        '
        Me.AttendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance"
        Me.AttendanceDataGridViewTextBoxColumn.HeaderText = "attendance"
        Me.AttendanceDataGridViewTextBoxColumn.Name = "AttendanceDataGridViewTextBoxColumn"
        Me.AttendanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarksDataGridViewTextBoxColumn
        '
        Me.MarksDataGridViewTextBoxColumn.DataPropertyName = "marks"
        Me.MarksDataGridViewTextBoxColumn.HeaderText = "marks"
        Me.MarksDataGridViewTextBoxColumn.Name = "MarksDataGridViewTextBoxColumn"
        Me.MarksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivitiesDataGridViewTextBoxColumn
        '
        Me.ActivitiesDataGridViewTextBoxColumn.DataPropertyName = "activities"
        Me.ActivitiesDataGridViewTextBoxColumn.HeaderText = "activities"
        Me.ActivitiesDataGridViewTextBoxColumn.Name = "ActivitiesDataGridViewTextBoxColumn"
        Me.ActivitiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AchievementsDataGridViewTextBoxColumn
        '
        Me.AchievementsDataGridViewTextBoxColumn.DataPropertyName = "achievements"
        Me.AchievementsDataGridViewTextBoxColumn.HeaderText = "achievements"
        Me.AchievementsDataGridViewTextBoxColumn.Name = "AchievementsDataGridViewTextBoxColumn"
        Me.AchievementsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        Me.DobDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        Me.ReligionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommunityDataGridViewTextBoxColumn
        '
        Me.CommunityDataGridViewTextBoxColumn.DataPropertyName = "community"
        Me.CommunityDataGridViewTextBoxColumn.HeaderText = "community"
        Me.CommunityDataGridViewTextBoxColumn.Name = "CommunityDataGridViewTextBoxColumn"
        Me.CommunityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "pincode"
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        Me.PincodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        Me.MobileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpamstableBindingSource
        '
        Me.SpamstableBindingSource.DataMember = "spamstable"
        Me.SpamstableBindingSource.DataSource = Me.MsdbDataSet
        '
        'MsdbDataSet
        '
        Me.MsdbDataSet.DataSetName = "msdbDataSet"
        Me.MsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "THE DETAILS IN THE DATABASE ARE THE FOLLOWING :"
        '
        'SpamstableTableAdapter
        '
        Me.SpamstableTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "REFRESH DATABASE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1016, 376)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpamstableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MsdbDataSet As spams_new.msdbDataSet
    Friend WithEvents SpamstableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpamstableTableAdapter As spams_new.msdbDataSetTableAdapters.spamstableTableAdapter
    Friend WithEvents RegnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CinchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttendanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivitiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AchievementsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommunityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
