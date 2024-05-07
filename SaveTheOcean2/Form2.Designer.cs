namespace SaveTheOcean2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dataGridSelectAll = new DataGridView();
            lblAllRescues = new Label();
            lblSelectById = new Label();
            TBId = new TextBox();
            dataGridSelectId = new DataGridView();
            BSearchById = new Button();
            errorId = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridSelectAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSelectId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorId).BeginInit();
            SuspendLayout();
            // 
            // dataGridSelectAll
            // 
            dataGridSelectAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSelectAll.Location = new Point(154, 108);
            dataGridSelectAll.Name = "dataGridSelectAll";
            dataGridSelectAll.Size = new Size(563, 150);
            dataGridSelectAll.TabIndex = 0;
            dataGridSelectAll.CellContentClick += dataGridSelectAll_CellContentClick;
            // 
            // lblAllRescues
            // 
            lblAllRescues.AutoSize = true;
            lblAllRescues.BackColor = Color.Navy;
            lblAllRescues.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllRescues.ForeColor = SystemColors.ButtonHighlight;
            lblAllRescues.Location = new Point(154, 76);
            lblAllRescues.Name = "lblAllRescues";
            lblAllRescues.Size = new Size(111, 30);
            lblAllRescues.TabIndex = 1;
            lblAllRescues.Text = "RESCUES:";
            lblAllRescues.Click += lblAllRescues_Click;
            // 
            // lblSelectById
            // 
            lblSelectById.AutoSize = true;
            lblSelectById.BackColor = Color.Navy;
            lblSelectById.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectById.ForeColor = SystemColors.ButtonHighlight;
            lblSelectById.Location = new Point(154, 294);
            lblSelectById.Name = "lblSelectById";
            lblSelectById.Size = new Size(274, 32);
            lblSelectById.TabIndex = 2;
            lblSelectById.Text = "SELECT RESCUE BY ID:";
            // 
            // TBId
            // 
            TBId.Location = new Point(434, 302);
            TBId.Name = "TBId";
            TBId.Size = new Size(109, 23);
            TBId.TabIndex = 3;
            // 
            // dataGridSelectId
            // 
            dataGridSelectId.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSelectId.Location = new Point(154, 335);
            dataGridSelectId.Name = "dataGridSelectId";
            dataGridSelectId.Size = new Size(546, 63);
            dataGridSelectId.TabIndex = 4;
            // 
            // BSearchById
            // 
            BSearchById.BackColor = Color.FromArgb(128, 255, 128);
            BSearchById.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSearchById.Location = new Point(549, 296);
            BSearchById.Name = "BSearchById";
            BSearchById.Size = new Size(119, 33);
            BSearchById.TabIndex = 5;
            BSearchById.Text = "SEARCH";
            BSearchById.UseVisualStyleBackColor = false;
            BSearchById.Click += buttonSearchId_Click;
            // 
            // errorId
            // 
            errorId.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(864, 554);
            Controls.Add(BSearchById);
            Controls.Add(dataGridSelectId);
            Controls.Add(TBId);
            Controls.Add(lblSelectById);
            Controls.Add(lblAllRescues);
            Controls.Add(dataGridSelectAll);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridSelectAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSelectId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridSelectAll;
        private Label lblAllRescues;
        private Label lblSelectById;
        private TextBox TBId;
        private DataGridView dataGridSelectId;
        private Button BSearchById;
        private ErrorProvider errorId;
    }
}