
namespace UP
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.Cancel2 = new System.Windows.Forms.Button();
            this.Add2 = new System.Windows.Forms.Button();
            this.PathCB = new System.Windows.Forms.ComboBox();
            this.ServiceDiscountTB = new System.Windows.Forms.TextBox();
            this.ServiceDescriptionTB = new System.Windows.Forms.TextBox();
            this.ServiceDurationTB = new System.Windows.Forms.TextBox();
            this.ServiceCostTB = new System.Windows.Forms.TextBox();
            this.ServiceTitleTB = new System.Windows.Forms.TextBox();
            this.b1 = new UP.b1();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b1DataSet = new UP.b1DataSet();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new UP.b1DataSetTableAdapters.ServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel2
            // 
            this.Cancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Cancel2.Location = new System.Drawing.Point(242, 218);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 15;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = false;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // Add2
            // 
            this.Add2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Add2.Location = new System.Drawing.Point(87, 218);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(75, 23);
            this.Add2.TabIndex = 14;
            this.Add2.Text = "edit";
            this.Add2.UseVisualStyleBackColor = false;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // PathCB
            // 
            this.PathCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PathCB.DataSource = this.serviceBindingSource1;
            this.PathCB.DisplayMember = "MainImagePath";
            this.PathCB.FormattingEnabled = true;
            this.PathCB.Location = new System.Drawing.Point(142, 191);
            this.PathCB.Name = "PathCB";
            this.PathCB.Size = new System.Drawing.Size(121, 21);
            this.PathCB.TabIndex = 13;
            this.PathCB.ValueMember = "ID";
            // 
            // ServiceDiscountTB
            // 
            this.ServiceDiscountTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDiscountTB.Location = new System.Drawing.Point(142, 165);
            this.ServiceDiscountTB.Name = "ServiceDiscountTB";
            this.ServiceDiscountTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDiscountTB.TabIndex = 12;
            // 
            // ServiceDescriptionTB
            // 
            this.ServiceDescriptionTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDescriptionTB.Location = new System.Drawing.Point(142, 139);
            this.ServiceDescriptionTB.Name = "ServiceDescriptionTB";
            this.ServiceDescriptionTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDescriptionTB.TabIndex = 11;
            // 
            // ServiceDurationTB
            // 
            this.ServiceDurationTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDurationTB.Location = new System.Drawing.Point(142, 113);
            this.ServiceDurationTB.Name = "ServiceDurationTB";
            this.ServiceDurationTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDurationTB.TabIndex = 10;
            // 
            // ServiceCostTB
            // 
            this.ServiceCostTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceCostTB.Location = new System.Drawing.Point(142, 87);
            this.ServiceCostTB.Name = "ServiceCostTB";
            this.ServiceCostTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceCostTB.TabIndex = 9;
            // 
            // ServiceTitleTB
            // 
            this.ServiceTitleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceTitleTB.Location = new System.Drawing.Point(142, 61);
            this.ServiceTitleTB.Name = "ServiceTitleTB";
            this.ServiceTitleTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceTitleTB.TabIndex = 8;
            // 
            // b1
            // 
            this.b1.DataSetName = "ABD_18UPDataSet";
            this.b1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.b1;
            // 
            // b1DataSet
            // 
            this.b1DataSet.DataSetName = "b1DataSet";
            this.b1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            this.serviceBindingSource1.DataSource = this.b1DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 341);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.PathCB);
            this.Controls.Add(this.ServiceDiscountTB);
            this.Controls.Add(this.ServiceDescriptionTB);
            this.Controls.Add(this.ServiceDurationTB);
            this.Controls.Add(this.ServiceCostTB);
            this.Controls.Add(this.ServiceTitleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.edit_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Button Add2;
        public System.Windows.Forms.ComboBox PathCB;
        public System.Windows.Forms.TextBox ServiceDiscountTB;
        public System.Windows.Forms.TextBox ServiceDescriptionTB;
        public System.Windows.Forms.TextBox ServiceDurationTB;
        public System.Windows.Forms.TextBox ServiceCostTB;
        public System.Windows.Forms.TextBox ServiceTitleTB;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private b1 b1;
        private b1DataSet b1DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private b1DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
    }
}