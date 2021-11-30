
namespace UP
{
    partial class Add3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add3));
            this.ServiceTitleTB = new System.Windows.Forms.TextBox();
            this.ServiceCostTB = new System.Windows.Forms.TextBox();
            this.ServiceDurationTB = new System.Windows.Forms.TextBox();
            this.ServiceDescriptionTB = new System.Windows.Forms.TextBox();
            this.ServiceDiscountTB = new System.Windows.Forms.TextBox();
            this.PathCB = new System.Windows.Forms.ComboBox();
            this.Add2 = new System.Windows.Forms.Button();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.serviceTableAdapter = new UP.ABD_18UPDataSetTableAdapters.ServiceTableAdapter();
            this.b1DataSet1 = new UP.b1DataSet();
            this.serviceTableAdapter1 = new UP.b1DataSetTableAdapters.ServiceTableAdapter();
            this.b1 = new UP.b1();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTitleTB
            // 
            this.ServiceTitleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceTitleTB.Location = new System.Drawing.Point(67, 12);
            this.ServiceTitleTB.Name = "ServiceTitleTB";
            this.ServiceTitleTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceTitleTB.TabIndex = 0;
            this.ServiceTitleTB.TextChanged += new System.EventHandler(this.ServiceTitleTB_TextChanged);
            // 
            // ServiceCostTB
            // 
            this.ServiceCostTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceCostTB.Location = new System.Drawing.Point(67, 38);
            this.ServiceCostTB.Name = "ServiceCostTB";
            this.ServiceCostTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceCostTB.TabIndex = 1;
            this.ServiceCostTB.TextChanged += new System.EventHandler(this.ServiceCostTB_TextChanged);
            // 
            // ServiceDurationTB
            // 
            this.ServiceDurationTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDurationTB.Location = new System.Drawing.Point(67, 64);
            this.ServiceDurationTB.Name = "ServiceDurationTB";
            this.ServiceDurationTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDurationTB.TabIndex = 2;
            this.ServiceDurationTB.TextChanged += new System.EventHandler(this.ServiceDurationTB_TextChanged);
            // 
            // ServiceDescriptionTB
            // 
            this.ServiceDescriptionTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDescriptionTB.Location = new System.Drawing.Point(67, 90);
            this.ServiceDescriptionTB.Name = "ServiceDescriptionTB";
            this.ServiceDescriptionTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDescriptionTB.TabIndex = 3;
            this.ServiceDescriptionTB.TextChanged += new System.EventHandler(this.ServiceDescriptionTB_TextChanged);
            // 
            // ServiceDiscountTB
            // 
            this.ServiceDiscountTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ServiceDiscountTB.Location = new System.Drawing.Point(67, 116);
            this.ServiceDiscountTB.Name = "ServiceDiscountTB";
            this.ServiceDiscountTB.Size = new System.Drawing.Size(121, 20);
            this.ServiceDiscountTB.TabIndex = 4;
            this.ServiceDiscountTB.TextChanged += new System.EventHandler(this.ServiceDiscountTB_TextChanged);
            // 
            // PathCB
            // 
            this.PathCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PathCB.DataSource = this.serviceBindingSource;
            this.PathCB.DisplayMember = "MainImagePath";
            this.PathCB.FormattingEnabled = true;
            this.PathCB.Location = new System.Drawing.Point(67, 142);
            this.PathCB.Name = "PathCB";
            this.PathCB.Size = new System.Drawing.Size(121, 21);
            this.PathCB.TabIndex = 5;
            this.PathCB.ValueMember = "ID";
            this.PathCB.SelectedIndexChanged += new System.EventHandler(this.PathCB_SelectedIndexChanged);
            // 
            // Add2
            // 
            this.Add2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Add2.Location = new System.Drawing.Point(12, 169);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(75, 23);
            this.Add2.TabIndex = 6;
            this.Add2.Text = "Add";
            this.Add2.UseVisualStyleBackColor = false;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // Cancel2
            // 
            this.Cancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Cancel2.Location = new System.Drawing.Point(167, 169);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 7;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = false;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // b1DataSet1
            // 
            this.b1DataSet1.DataSetName = "b1DataSet";
            this.b1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
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
            // Add3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 204);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.PathCB);
            this.Controls.Add(this.ServiceDiscountTB);
            this.Controls.Add(this.ServiceDescriptionTB);
            this.Controls.Add(this.ServiceDurationTB);
            this.Controls.Add(this.ServiceCostTB);
            this.Controls.Add(this.ServiceTitleTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ServiceTitleTB;
        public System.Windows.Forms.TextBox ServiceCostTB;
        public System.Windows.Forms.TextBox ServiceDurationTB;
        public System.Windows.Forms.TextBox ServiceDescriptionTB;
        public System.Windows.Forms.TextBox ServiceDiscountTB;
        public System.Windows.Forms.ComboBox PathCB;
        private System.Windows.Forms.Button Add2;
        private System.Windows.Forms.Button Cancel2;
        private b1DataSet b1DataSet1;
        private ABD_18UPDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private b1DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private b1 b1;
    }
}