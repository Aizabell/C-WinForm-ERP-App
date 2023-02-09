
namespace HRDatabaseTEST
{
    partial class EmployeeCourseList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.oFDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFDBDataSet2 = new HRDatabaseTEST.HRDBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCourseIDLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RDeleteButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCourseIDLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDeleteButtonEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.oFDBDataSet2BindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RDeleteButtonEdit,
            this.RCourseIDLookUpEdit});
            this.gridControl2.Size = new System.Drawing.Size(937, 487);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // oFDBDataSet2BindingSource
            // 
            this.oFDBDataSet2BindingSource.DataSource = this.oFDBDataSet2;
            this.oFDBDataSet2BindingSource.Position = 0;
            // 
            // oFDBDataSet2
            // 
            this.oFDBDataSet2.DataSetName = "OFDBDataSet2";
            this.oFDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colCourseID,
            this.colFirstName,
            this.colLastName,
            this.colCourseName,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colCourseID
            // 
            this.colCourseID.ColumnEdit = this.RCourseIDLookUpEdit;
            this.colCourseID.FieldName = "CourseID";
            this.colCourseID.Name = "colCourseID";
            this.colCourseID.Visible = true;
            this.colCourseID.VisibleIndex = 0;
            this.colCourseID.Width = 159;
            // 
            // RCourseIDLookUpEdit
            // 
            this.RCourseIDLookUpEdit.AutoHeight = false;
            this.RCourseIDLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RCourseIDLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Period", "Period", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseDifficulty", "CourseDifficulty", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.RCourseIDLookUpEdit.DisplayMember = "CourseName";
            this.RCourseIDLookUpEdit.ImmediatePopup = true;
            this.RCourseIDLookUpEdit.Name = "RCourseIDLookUpEdit";
            this.RCourseIDLookUpEdit.NullText = "?";
            this.RCourseIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.RCourseIDLookUpEdit.ValueMember = "CourseID";
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 157;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 167;
            // 
            // colCourseName
            // 
            this.colCourseName.FieldName = "CourseName";
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.Width = 168;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Delete";
            this.gridColumn1.ColumnEdit = this.RDeleteButtonEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 92;
            // 
            // RDeleteButtonEdit
            // 
            this.RDeleteButtonEdit.AutoHeight = false;
            editorButtonImageOptions5.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            editorButtonImageOptions5.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions5.SvgImage = global::HRDatabaseTEST.Properties.Resources.actions_deletecircled;
            editorButtonImageOptions5.SvgImageSize = new System.Drawing.Size(15, 15);
            editorButtonImageOptions6.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            editorButtonImageOptions6.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions6.SvgImage = global::HRDatabaseTEST.Properties.Resources.actions_reload;
            editorButtonImageOptions6.SvgImageSize = new System.Drawing.Size(15, 15);
            this.RDeleteButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, true, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", "delete", null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Refresh", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", "refresh", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.RDeleteButtonEdit.Name = "RDeleteButtonEdit";
            this.RDeleteButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // EmployeeCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 487);
            this.Controls.Add(this.gridControl2);
            this.Name = "EmployeeCourseList";
            this.Text = "EmployeeCourseList";
            this.Load += new System.EventHandler(this.EmployeeCourseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RCourseIDLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDeleteButtonEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCourseName;
        private System.Windows.Forms.BindingSource oFDBDataSet2BindingSource;
        private HRDBDataSet oFDBDataSet2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RDeleteButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RCourseIDLookUpEdit;
    }
}