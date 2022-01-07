namespace AirLine_System
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.airLineDataSet = new AirLine_System.AirLineDataSet();
            this.aIRPLINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPLINETableAdapter = new AirLine_System.AirLineDataSetTableAdapters.AIRPLINETableAdapter();
            this.tableAdapterManager = new AirLine_System.AirLineDataSetTableAdapters.TableAdapterManager();
            this.aIRPLINEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aIRPLINEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aIRPLINEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airLineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEBindingNavigator)).BeginInit();
            this.aIRPLINEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airLineDataSet
            // 
            this.airLineDataSet.DataSetName = "AirLineDataSet";
            this.airLineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRPLINEBindingSource
            // 
            this.aIRPLINEBindingSource.DataMember = "AIRPLINE";
            this.aIRPLINEBindingSource.DataSource = this.airLineDataSet;
            // 
            // aIRPLINETableAdapter
            // 
            this.aIRPLINETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.AIRPLANETableAdapter = null;
            this.tableAdapterManager.AIRPLINETableAdapter = this.aIRPLINETableAdapter;
            this.tableAdapterManager.AIRPORTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirLine_System.AirLineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aIRPLINEBindingNavigator
            // 
            this.aIRPLINEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aIRPLINEBindingNavigator.BindingSource = this.aIRPLINEBindingSource;
            this.aIRPLINEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aIRPLINEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aIRPLINEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aIRPLINEBindingNavigatorSaveItem});
            this.aIRPLINEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aIRPLINEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aIRPLINEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aIRPLINEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aIRPLINEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aIRPLINEBindingNavigator.Name = "aIRPLINEBindingNavigator";
            this.aIRPLINEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aIRPLINEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.aIRPLINEBindingNavigator.TabIndex = 0;
            this.aIRPLINEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aIRPLINEBindingNavigatorSaveItem
            // 
            this.aIRPLINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aIRPLINEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aIRPLINEBindingNavigatorSaveItem.Image")));
            this.aIRPLINEBindingNavigatorSaveItem.Name = "aIRPLINEBindingNavigatorSaveItem";
            this.aIRPLINEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aIRPLINEBindingNavigatorSaveItem.Text = "Save Data";
            this.aIRPLINEBindingNavigatorSaveItem.Click += new System.EventHandler(this.aIRPLINEBindingNavigatorSaveItem_Click);
            // 
            // aIRPLINEDataGridView
            // 
            this.aIRPLINEDataGridView.AutoGenerateColumns = false;
            this.aIRPLINEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aIRPLINEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.aIRPLINEDataGridView.DataSource = this.aIRPLINEBindingSource;
            this.aIRPLINEDataGridView.Location = new System.Drawing.Point(279, 137);
            this.aIRPLINEDataGridView.Name = "aIRPLINEDataGridView";
            this.aIRPLINEDataGridView.Size = new System.Drawing.Size(300, 220);
            this.aIRPLINEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Airline_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Airline_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Airline_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Airline_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Airplanes";
            this.dataGridViewTextBoxColumn3.HeaderText = "Airplanes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aIRPLINEDataGridView);
            this.Controls.Add(this.aIRPLINEBindingNavigator);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airLineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEBindingNavigator)).EndInit();
            this.aIRPLINEBindingNavigator.ResumeLayout(false);
            this.aIRPLINEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPLINEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AirLineDataSet airLineDataSet;
        private System.Windows.Forms.BindingSource aIRPLINEBindingSource;
        private AirLineDataSetTableAdapters.AIRPLINETableAdapter aIRPLINETableAdapter;
        private AirLineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aIRPLINEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aIRPLINEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aIRPLINEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}