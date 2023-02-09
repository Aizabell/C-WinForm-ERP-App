
namespace HRDatabaseTEST
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.oFDBDataSet3 = new HRDatabaseTEST.HRDBDataSet();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.attendanceTableAdapter = new HRDatabaseTEST.HRDBDataSetTableAdapters.AttendanceTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ReportButtonItem = new DevExpress.XtraEditors.SimpleButton();
            this.CheckOutButton = new DevExpress.XtraEditors.SimpleButton();
            this.CheckInButton = new DevExpress.XtraEditors.SimpleButton();
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAttendanceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClockIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClockOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AttRepItemButDeleteEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCourseLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCourseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CourseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CourseIDTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttRepItemButDeleteEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCourseLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseIDTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // oFDBDataSet3
            // 
            this.oFDBDataSet3.DataSetName = "OFDBDataSet3";
            this.oFDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.oFDBDataSet3;
            // 
            // attendanceTableAdapter
            // 
            //this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ReportButtonItem);
            this.layoutControl1.Controls.Add(this.CheckOutButton);
            this.layoutControl1.Controls.Add(this.CheckInButton);
            this.layoutControl1.Controls.Add(this.IDTextEdit);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.CourseLookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1118, 237, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(913, 535);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ReportButtonItem
            // 
            this.ReportButtonItem.Location = new System.Drawing.Point(819, 17);
            this.ReportButtonItem.MaximumSize = new System.Drawing.Size(100, 100);
            this.ReportButtonItem.Name = "ReportButtonItem";
            this.ReportButtonItem.Size = new System.Drawing.Size(79, 54);
            this.ReportButtonItem.StyleController = this.layoutControl1;
            this.ReportButtonItem.TabIndex = 8;
            this.ReportButtonItem.Text = "Report";
            this.ReportButtonItem.Click += new System.EventHandler(this.ReportButtonItem_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(727, 17);
            this.CheckOutButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(82, 54);
            this.CheckOutButton.StyleController = this.layoutControl1;
            this.CheckOutButton.TabIndex = 7;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(642, 17);
            this.CheckInButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(75, 54);
            this.CheckInButton.StyleController = this.layoutControl1;
            this.CheckInButton.TabIndex = 6;
            this.CheckInButton.Text = "Check In";
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.Location = new System.Drawing.Point(130, 17);
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Size = new System.Drawing.Size(502, 20);
            this.IDTextEdit.StyleController = this.layoutControl1;
            this.IDTextEdit.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.attendanceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AttRepItemButDeleteEdit,
            this.RCourseLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(889, 443);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttendanceID,
            this.colEmployeeID,
            this.colFirstName,
            this.colLastName,
            this.colDate,
            this.colClockIn,
            this.colClockOut,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colCourseName,
            this.colCourseID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colAttendanceID
            // 
            this.colAttendanceID.FieldName = "AttendanceID";
            this.colAttendanceID.Name = "colAttendanceID";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            // 
            // colClockIn
            // 
            this.colClockIn.DisplayFormat.FormatString = "h:mm tt - d MMM, yyyy";
            this.colClockIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colClockIn.FieldName = "ClockIn";
            this.colClockIn.Name = "colClockIn";
            this.colClockIn.Visible = true;
            this.colClockIn.VisibleIndex = 5;
            // 
            // colClockOut
            // 
            this.colClockOut.DisplayFormat.FormatString = "h:mm tt - d MMM, yyyy";
            this.colClockOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colClockOut.FieldName = "ClockOut";
            this.colClockOut.Name = "colClockOut";
            this.colClockOut.Visible = true;
            this.colClockOut.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Is Clocked In";
            this.gridColumn1.FieldName = "IsClockedIn";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Is Clocked Out";
            this.gridColumn2.FieldName = "IsClockedOut";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Delete";
            this.gridColumn3.ColumnEdit = this.AttRepItemButDeleteEdit;
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // AttRepItemButDeleteEdit
            // 
            this.AttRepItemButDeleteEdit.AutoHeight = false;
            editorButtonImageOptions1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(15, 15);
            this.AttRepItemButDeleteEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "delete", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.AttRepItemButDeleteEdit.Name = "AttRepItemButDeleteEdit";
            this.AttRepItemButDeleteEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colCourseName
            // 
            this.colCourseName.Caption = "Course Name";
            this.colCourseName.ColumnEdit = this.RCourseLookUpEdit;
            this.colCourseName.FieldName = "CourseID";
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.Visible = true;
            this.colCourseName.VisibleIndex = 0;
            // 
            // RCourseLookUpEdit
            // 
            this.RCourseLookUpEdit.AutoHeight = false;
            this.RCourseLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RCourseLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseID", "CourseID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.RCourseLookUpEdit.DisplayMember = "CourseName";
            this.RCourseLookUpEdit.Name = "RCourseLookUpEdit";
            this.RCourseLookUpEdit.NullText = "?";
            this.RCourseLookUpEdit.ValueMember = "CourseID";
            // 
            // colCourseID
            // 
            this.colCourseID.Caption = "Course ID";
            this.colCourseID.ColumnEdit = this.RCourseLookUpEdit;
            this.colCourseID.Name = "colCourseID";
            // 
            // CourseLookUpEdit
            // 
            this.CourseLookUpEdit.Location = new System.Drawing.Point(130, 51);
            this.CourseLookUpEdit.Name = "CourseLookUpEdit";
            this.CourseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CourseLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.CourseLookUpEdit.Properties.DisplayMember = "CourseName";
            this.CourseLookUpEdit.Properties.NullText = "";
            this.CourseLookUpEdit.Properties.ValueMember = "CourseID";
            this.CourseLookUpEdit.Size = new System.Drawing.Size(502, 20);
            this.CourseLookUpEdit.StyleController = this.layoutControl1;
            this.CourseLookUpEdit.TabIndex = 8;
            this.CourseLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.CourseLookUpEdit_Closed);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.CourseIDTextBox,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(913, 535);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(893, 447);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.IDTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 7);
            this.layoutControlItem2.Size = new System.Drawing.Size(627, 34);
            this.layoutControlItem2.Text = "Enter Employee Code";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 13);
            // 
            // CourseIDTextBox
            // 
            this.CourseIDTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.CourseIDTextBox.Control = this.CourseLookUpEdit;
            this.CourseIDTextBox.Location = new System.Drawing.Point(0, 34);
            this.CourseIDTextBox.Name = "CourseIDTextBox";
            this.CourseIDTextBox.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 7);
            this.CourseIDTextBox.Size = new System.Drawing.Size(627, 34);
            this.CourseIDTextBox.Text = "Enter Course ID";
            this.CourseIDTextBox.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CheckOutButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(712, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 7);
            this.layoutControlItem4.Size = new System.Drawing.Size(92, 68);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CheckInButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(627, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 7);
            this.layoutControlItem3.Size = new System.Drawing.Size(85, 68);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ReportButtonItem;
            this.layoutControlItem5.Location = new System.Drawing.Point(804, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 7);
            this.layoutControlItem5.Size = new System.Drawing.Size(89, 68);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 535);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttRepItemButDeleteEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCourseLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseIDTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HRDBDataSet oFDBDataSet3;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        //private HRDBDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton CheckOutButton;
        private DevExpress.XtraEditors.SimpleButton CheckInButton;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttendanceID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClockIn;
        private DevExpress.XtraGrid.Columns.GridColumn colClockOut;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem CourseIDTextBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AttRepItemButDeleteEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseName;
        protected DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RCourseLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit CourseLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton ReportButtonItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}