namespace _2048WinFormsApp
{
    partial class MainForm
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
            label1 = new Label();
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            restartMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            rulesMenuItem = new ToolStripMenuItem();
            historyGameMenuItem = new ToolStripMenuItem();
            userNameLabel = new Label();
            textBoxUserName = new TextBox();
            buttonStartGame = new Button();
            bestScoreTitleLabel = new Label();
            bestScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Ваш счёт:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(79, 24);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(322, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartMenuItem, exitMenuItem, rulesMenuItem, historyGameMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // restartMenuItem
            // 
            restartMenuItem.Name = "restartMenuItem";
            restartMenuItem.Size = new Size(153, 22);
            restartMenuItem.Text = "Перезапуск";
            restartMenuItem.Click += restartMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(153, 22);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // rulesMenuItem
            // 
            rulesMenuItem.Name = "rulesMenuItem";
            rulesMenuItem.Size = new Size(153, 22);
            rulesMenuItem.Text = "Правила игры";
            rulesMenuItem.Click += rulesMenuItem_Click;
            // 
            // historyGameMenuItem
            // 
            historyGameMenuItem.Name = "historyGameMenuItem";
            historyGameMenuItem.Size = new Size(153, 22);
            historyGameMenuItem.Text = "История игры";
            historyGameMenuItem.Click += historyGameMenuItem_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 39);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(232, 15);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Введите ваше ФИО и нажмите на кнопку";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(12, 57);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(298, 23);
            textBoxUserName.TabIndex = 4;
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackColor = Color.Lime;
            buttonStartGame.Location = new Point(112, 86);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(98, 23);
            buttonStartGame.TabIndex = 5;
            buttonStartGame.Text = "Начать игру";
            buttonStartGame.UseVisualStyleBackColor = false;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // bestScoreTitleLabel
            // 
            bestScoreTitleLabel.AutoSize = true;
            bestScoreTitleLabel.Location = new Point(132, 24);
            bestScoreTitleLabel.Name = "bestScoreTitleLabel";
            bestScoreTitleLabel.Size = new Size(112, 15);
            bestScoreTitleLabel.TabIndex = 6;
            bestScoreTitleLabel.Text = "Лучший результат:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(250, 24);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(13, 15);
            bestScoreLabel.TabIndex = 7;
            bestScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 417);
            Controls.Add(bestScoreLabel);
            Controls.Add(bestScoreTitleLabel);
            Controls.Add(buttonStartGame);
            Controls.Add(textBoxUserName);
            Controls.Add(userNameLabel);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem restartMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem rulesMenuItem;
        private Label userNameLabel;
        private TextBox textBoxUserName;
        private Button buttonStartGame;
        private ToolStripMenuItem historyGameMenuItem;
        private Label bestScoreTitleLabel;
        private Label bestScoreLabel;
    }
}
