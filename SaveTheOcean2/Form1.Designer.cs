namespace SaveTheOcean2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            Options = new Label();
            BPlay = new Button();
            BSortir = new Button();
            lblResult = new Label();
            lblAct = new Label();
            BRescue = new Button();
            lblOcupation = new Label();
            lblPlayer = new Label();
            TBName = new TextBox();
            CBOccupation = new ComboBox();
            DGRescueAnimal = new DataGridView();
            DGRescue = new DataGridView();
            BSearch = new Button();
            Button1 = new Button();
            Button2 = new Button();
            errorName = new ErrorProvider(components);
            errorOccupation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)DGRescueAnimal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGRescue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorOccupation).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.CornflowerBlue;
            Title.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(321, 142);
            Title.Name = "Title";
            Title.Size = new Size(645, 86);
            Title.TabIndex = 0;
            Title.Text = "SAVE THE OCEAN 2";
            Title.Click += label1_Click;
            // 
            // Options
            // 
            Options.AutoSize = true;
            Options.BackColor = Color.RoyalBlue;
            Options.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Options.Location = new Point(515, 245);
            Options.Name = "Options";
            Options.Size = new Size(285, 32);
            Options.TabIndex = 1;
            Options.Text = "What do you want to do?";
            // 
            // BPlay
            // 
            BPlay.BackColor = Color.Green;
            BPlay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BPlay.Location = new Point(515, 280);
            BPlay.Name = "BPlay";
            BPlay.Size = new Size(84, 35);
            BPlay.TabIndex = 2;
            BPlay.Text = "PLAY";
            BPlay.UseVisualStyleBackColor = false;
            BPlay.Click += BJugar_Click;
            // 
            // BSortir
            // 
            BSortir.BackColor = Color.FromArgb(255, 128, 128);
            BSortir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BSortir.Location = new Point(716, 280);
            BSortir.Name = "BSortir";
            BSortir.Size = new Size(84, 33);
            BSortir.TabIndex = 3;
            BSortir.Text = "EXIT";
            BSortir.UseVisualStyleBackColor = false;
            BSortir.Click += BSortir_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.FromArgb(255, 128, 255);
            lblResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(476, 790);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(96, 37);
            lblResult.TabIndex = 20;
            lblResult.Text = "Result";
            lblResult.Click += LabelResult_Click;
            // 
            // lblAct
            // 
            lblAct.AutoSize = true;
            lblAct.BackColor = Color.FromArgb(255, 128, 0);
            lblAct.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAct.Location = new Point(576, 575);
            lblAct.Name = "lblAct";
            lblAct.Size = new Size(242, 47);
            lblAct.TabIndex = 18;
            lblAct.Text = "ACT FAST ! ! !";
            // 
            // BRescue
            // 
            BRescue.BackColor = SystemColors.ActiveCaption;
            BRescue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRescue.Location = new Point(566, 367);
            BRescue.Name = "BRescue";
            BRescue.Size = new Size(165, 33);
            BRescue.TabIndex = 17;
            BRescue.Text = "TO THE RESCUE ! ! !";
            BRescue.UseVisualStyleBackColor = false;
            BRescue.Click += BRescue_Click;
            // 
            // lblOcupation
            // 
            lblOcupation.AutoSize = true;
            lblOcupation.BackColor = SystemColors.InactiveCaption;
            lblOcupation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOcupation.Location = new Point(397, 379);
            lblOcupation.Name = "lblOcupation";
            lblOcupation.Size = new Size(116, 21);
            lblOcupation.TabIndex = 16;
            lblOcupation.Text = "OCCUPATION:";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = SystemColors.InactiveCaption;
            lblPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(397, 318);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(123, 21);
            lblPlayer.TabIndex = 15;
            lblPlayer.Text = "PLAYER NAME:";
            lblPlayer.Click += label1_Click_1;
            // 
            // TBName
            // 
            TBName.Location = new Point(397, 342);
            TBName.Name = "TBName";
            TBName.Size = new Size(116, 23);
            TBName.TabIndex = 14;
            // 
            // CBOccupation
            // 
            CBOccupation.FormattingEnabled = true;
            CBOccupation.Location = new Point(397, 403);
            CBOccupation.Name = "CBOccupation";
            CBOccupation.Size = new Size(116, 23);
            CBOccupation.TabIndex = 13;
            CBOccupation.SelectedIndexChanged += cbOfici_SelectedIndexChanged;
            // 
            // DGRescueAnimal
            // 
            DGRescueAnimal.BackgroundColor = Color.Green;
            DGRescueAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGRescueAnimal.Location = new Point(452, 516);
            DGRescueAnimal.Name = "DGRescueAnimal";
            DGRescueAnimal.Size = new Size(443, 45);
            DGRescueAnimal.TabIndex = 12;
            // 
            // DGRescue
            // 
            DGRescue.BackgroundColor = Color.White;
            DGRescue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGRescue.Location = new Point(397, 452);
            DGRescue.Name = "DGRescue";
            DGRescue.Size = new Size(542, 48);
            DGRescue.TabIndex = 11;
            // 
            // BSearch
            // 
            BSearch.BackColor = Color.FromArgb(255, 255, 192);
            BSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSearch.Location = new Point(773, 354);
            BSearch.Name = "BSearch";
            BSearch.Size = new Size(208, 59);
            BSearch.TabIndex = 22;
            BSearch.Text = "SEARCH REGISTERED RESCUES";
            BSearch.UseVisualStyleBackColor = false;
            BSearch.Click += BSearch_Click;
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(0, 0, 64);
            Button1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(390, 638);
            Button1.Name = "Button1";
            Button1.Size = new Size(242, 117);
            Button1.TabIndex = 23;
            Button1.Text = "RESCUE THERE";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click_1;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(0, 0, 64);
            Button2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(773, 638);
            Button2.Name = "Button2";
            Button2.Size = new Size(242, 117);
            Button2.TabIndex = 24;
            Button2.Text = "BRING THE ANIMAL TO THE CENTER";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click;
            // 
            // errorName
            // 
            errorName.ContainerControl = this;
            // 
            // errorOccupation
            // 
            errorOccupation.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1291, 941);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(BSearch);
            Controls.Add(lblResult);
            Controls.Add(lblAct);
            Controls.Add(BRescue);
            Controls.Add(lblOcupation);
            Controls.Add(lblPlayer);
            Controls.Add(TBName);
            Controls.Add(CBOccupation);
            Controls.Add(DGRescueAnimal);
            Controls.Add(DGRescue);
            Controls.Add(BSortir);
            Controls.Add(BPlay);
            Controls.Add(Options);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGRescueAnimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGRescue).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorOccupation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Options;
        private Button BPlay;
        private Button BSortir;
        private Label lblResult;
        private Label lblAct;
        private Button BRescue;
        private Label lblOcupation;
        private Label lblPlayer;
        private TextBox TBName;
        private ComboBox CBOccupation;
        private DataGridView DGRescueAnimal;
        private DataGridView DGRescue;
        private Button BSearch;
        private Button Button1;
        private Button Button2;
        private ErrorProvider errorName;
        private ErrorProvider errorOccupation;
    }
}
