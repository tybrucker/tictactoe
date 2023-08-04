using tic_tac_toe.utils;

namespace tic_tac_toe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            bindingSource1 = new BindingSource(components);
            GameGrid = new TableLayoutPanel();
            square_tl = new Square();
            square_tm = new Square();
            square_tr = new Square();
            square_ml = new Square();
            square_mm = new Square();
            square_mr = new Square();
            square_bl = new Square();
            square_bm = new Square();
            square_br = new Square();
            rdo_pvp = new RadioButton();
            rdo_pve = new RadioButton();
            newgame = new Button();
            winbox = new Label();
            check_hardmode = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            GameGrid.SuspendLayout();
            SuspendLayout();
            // 
            // GameGrid
            // 
            GameGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            GameGrid.ColumnCount = 3;
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Controls.Add(square_tl, 0, 0);
            GameGrid.Controls.Add(square_tm, 1, 0);
            GameGrid.Controls.Add(square_tr, 2, 0);
            GameGrid.Controls.Add(square_ml, 0, 1);
            GameGrid.Controls.Add(square_mm, 1, 1);
            GameGrid.Controls.Add(square_mr, 2, 1);
            GameGrid.Controls.Add(square_bl, 0, 2);
            GameGrid.Controls.Add(square_bm, 1, 2);
            GameGrid.Controls.Add(square_br, 2, 2);
            GameGrid.Location = new Point(0, 0);
            GameGrid.Name = "GameGrid";
            GameGrid.RowCount = 3;
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameGrid.Size = new Size(384, 361);
            GameGrid.TabIndex = 0;
            // 
            // square_tl
            // 
            square_tl.Dock = DockStyle.Fill;
            square_tl.FlatAppearance.BorderSize = 0;
            square_tl.FlatStyle = FlatStyle.Flat;
            square_tl.Location = new Point(4, 4);
            square_tl.Name = "square_tl";
            square_tl.Size = new Size(120, 113);
            square_tl.TabIndex = 0;
            square_tl.UseVisualStyleBackColor = true;
            square_tl.Click += Square_Click;
            // 
            // square_tm
            // 
            square_tm.Dock = DockStyle.Fill;
            square_tm.FlatAppearance.BorderSize = 0;
            square_tm.FlatStyle = FlatStyle.Flat;
            square_tm.Location = new Point(131, 4);
            square_tm.Name = "square_tm";
            square_tm.Size = new Size(120, 113);
            square_tm.TabIndex = 1;
            square_tm.UseVisualStyleBackColor = true;
            square_tm.Click += Square_Click;
            // 
            // square_tr
            // 
            square_tr.Dock = DockStyle.Fill;
            square_tr.FlatAppearance.BorderSize = 0;
            square_tr.FlatStyle = FlatStyle.Flat;
            square_tr.Location = new Point(258, 4);
            square_tr.Name = "square_tr";
            square_tr.Size = new Size(122, 113);
            square_tr.TabIndex = 2;
            square_tr.UseVisualStyleBackColor = true;
            square_tr.Click += Square_Click;
            // 
            // square_ml
            // 
            square_ml.Dock = DockStyle.Fill;
            square_ml.FlatAppearance.BorderSize = 0;
            square_ml.FlatStyle = FlatStyle.Flat;
            square_ml.Location = new Point(4, 124);
            square_ml.Name = "square_ml";
            square_ml.Size = new Size(120, 113);
            square_ml.TabIndex = 3;
            square_ml.UseVisualStyleBackColor = true;
            square_ml.Click += Square_Click;
            // 
            // square_mm
            // 
            square_mm.Dock = DockStyle.Fill;
            square_mm.FlatAppearance.BorderSize = 0;
            square_mm.FlatStyle = FlatStyle.Flat;
            square_mm.Location = new Point(131, 124);
            square_mm.Name = "square_mm";
            square_mm.Size = new Size(120, 113);
            square_mm.TabIndex = 4;
            square_mm.UseVisualStyleBackColor = true;
            square_mm.Click += Square_Click;
            // 
            // square_mr
            // 
            square_mr.Dock = DockStyle.Fill;
            square_mr.FlatAppearance.BorderSize = 0;
            square_mr.FlatStyle = FlatStyle.Flat;
            square_mr.Location = new Point(258, 124);
            square_mr.Name = "square_mr";
            square_mr.Size = new Size(122, 113);
            square_mr.TabIndex = 5;
            square_mr.UseVisualStyleBackColor = true;
            square_mr.Click += Square_Click;
            // 
            // square_bl
            // 
            square_bl.Dock = DockStyle.Fill;
            square_bl.FlatAppearance.BorderSize = 0;
            square_bl.FlatStyle = FlatStyle.Flat;
            square_bl.Location = new Point(4, 244);
            square_bl.Name = "square_bl";
            square_bl.Size = new Size(120, 113);
            square_bl.TabIndex = 6;
            square_bl.UseVisualStyleBackColor = true;
            square_bl.Click += Square_Click;
            // 
            // square_bm
            // 
            square_bm.Dock = DockStyle.Fill;
            square_bm.FlatAppearance.BorderSize = 0;
            square_bm.FlatStyle = FlatStyle.Flat;
            square_bm.Location = new Point(131, 244);
            square_bm.Name = "square_bm";
            square_bm.Size = new Size(120, 113);
            square_bm.TabIndex = 7;
            square_bm.UseVisualStyleBackColor = true;
            square_bm.Click += Square_Click;
            // 
            // square_br
            // 
            square_br.Dock = DockStyle.Fill;
            square_br.FlatAppearance.BorderSize = 0;
            square_br.FlatStyle = FlatStyle.Flat;
            square_br.Location = new Point(258, 244);
            square_br.Name = "square_br";
            square_br.Size = new Size(122, 113);
            square_br.TabIndex = 8;
            square_br.UseVisualStyleBackColor = true;
            square_br.Click += Square_Click;
            // 
            // rdo_pvp
            // 
            rdo_pvp.AutoSize = true;
            rdo_pvp.Checked = true;
            rdo_pvp.Location = new Point(439, 36);
            rdo_pvp.Name = "rdo_pvp";
            rdo_pvp.Size = new Size(45, 19);
            rdo_pvp.TabIndex = 1;
            rdo_pvp.TabStop = true;
            rdo_pvp.Text = "PvP";
            rdo_pvp.UseVisualStyleBackColor = true;
            rdo_pvp.CheckedChanged += Rdo_pvp_CheckedChanged;
            // 
            // rdo_pve
            // 
            rdo_pve.AutoSize = true;
            rdo_pve.Location = new Point(439, 61);
            rdo_pve.Name = "rdo_pve";
            rdo_pve.Size = new Size(44, 19);
            rdo_pve.TabIndex = 2;
            rdo_pve.Text = "PvE";
            rdo_pve.UseVisualStyleBackColor = true;
            rdo_pve.CheckedChanged += Rdo_pve_CheckedChanged;
            // 
            // newgame
            // 
            newgame.Location = new Point(428, 86);
            newgame.Name = "newgame";
            newgame.Size = new Size(75, 23);
            newgame.TabIndex = 3;
            newgame.Text = "New Game";
            newgame.UseVisualStyleBackColor = true;
            newgame.Click += Newgame_Click;
            // 
            // winbox
            // 
            winbox.AutoSize = true;
            winbox.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            winbox.Location = new Point(410, 157);
            winbox.Name = "winbox";
            winbox.Size = new Size(192, 34);
            winbox.TabIndex = 4;
            winbox.Text = "Winner: Player 1";
            winbox.TextAlign = ContentAlignment.MiddleCenter;
            winbox.Visible = false;
            // 
            // check_hardmode
            // 
            check_hardmode.AutoSize = true;
            check_hardmode.Location = new Point(428, 115);
            check_hardmode.Name = "check_hardmode";
            check_hardmode.Size = new Size(83, 19);
            check_hardmode.TabIndex = 5;
            check_hardmode.Text = "Hardmode";
            check_hardmode.UseVisualStyleBackColor = true;
            check_hardmode.CheckedChanged += Check_hardmode_CheckedChanged;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 361);
            Controls.Add(check_hardmode);
            Controls.Add(winbox);
            Controls.Add(newgame);
            Controls.Add(rdo_pve);
            Controls.Add(rdo_pvp);
            Controls.Add(GameGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            GameGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel GameGrid;
        private Square square_tl;
        private Square square_tm;
        private Square square_tr;
        private Square square_ml;
        private Square square_mm;
        private Square square_mr;
        private Square square_bl;
        private Square square_bm;
        private Square square_br;
        private RadioButton rdo_pvp;
        private RadioButton rdo_pve;
        private Button newgame;
        private Label winbox;
        private CheckBox check_hardmode;
    }
}