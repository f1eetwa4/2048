using System.Net.NetworkInformation;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int fieldSize = 4;
        private Label[,] labelsField;
        private static Random random = new Random();
        private int score;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeField();
            GenerateRandomNumber();
            ShowCurrentScore();
        }

        private void ShowCurrentScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private void InitializeField()
        {
            labelsField = new Label[fieldSize, fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    Label newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsField[i, j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            Label label = new Label();

            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        private void GenerateRandomNumber()
        {
            List<int> freeLabels = new List<int>();
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsField[i, j].Text == "")
                    {
                        int numberLabel = i * fieldSize + j;
                        freeLabels.Add(numberLabel);
                    }
                }
            }

            int randomIndexLabel = random.Next(freeLabels.Count);
            int randomNumberLabel = freeLabels[randomIndexLabel];

            int indexRow = randomNumberLabel / fieldSize;
            int indexColum = randomNumberLabel % fieldSize;

            List<int> possibleNumbers = new List<int> { 2, 4 };
            int randomIndex = random.Next(possibleNumbers.Count);
            int randomNumber = possibleNumbers[randomIndex];

            labelsField[indexRow, indexColum].Text = randomNumber.ToString();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            List<Keys> arrowKeys = new List<Keys>() 
            { Keys.Right, 
              Keys.Left, 
              Keys.Up, 
              Keys.Down
            };

            if (arrowKeys.Contains(e.KeyCode))
            {
                if (e.KeyCode == Keys.Right)
                {
                    for (int i = 0; i < fieldSize; i++)
                    {
                        for (int j = fieldSize - 1; j >= 0; j--)
                        {
                            if (labelsField[i, j].Text != string.Empty)
                            {
                                for (int k = j - 1; k >= 0; k--)
                                {
                                    if (labelsField[i, k].Text != string.Empty)
                                    {
                                        if (labelsField[i, j].Text == labelsField[i, k].Text)
                                        {
                                            int number = int.Parse(labelsField[i, j].Text);
                                            score += number * 2;
                                            labelsField[i, j].Text = (number * 2).ToString();
                                            labelsField[i, k].Text = string.Empty;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int i = 0; i < fieldSize; i++)
                    {
                        for (int j = fieldSize - 1; j >= 0; j--)
                        {
                            if (labelsField[i, j].Text == string.Empty)
                            {
                                for (int k = j - 1; k >= 0; k--)
                                {
                                    if (labelsField[i, k].Text != string.Empty)
                                    {
                                        int number = int.Parse(labelsField[i, k].Text);
                                        labelsField[i, j].Text = number.ToString();
                                        labelsField[i, k].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.Left)
                {
                    for (int i = 0; i < fieldSize; i++)
                    {
                        for (int j = 0; j < fieldSize; j++)
                        {
                            if (labelsField[i, j].Text != string.Empty)
                            {
                                for (int k = j + 1; k < fieldSize; k++)
                                {
                                    if (labelsField[i, k].Text != string.Empty)
                                    {
                                        if (labelsField[i, j].Text == labelsField[i, k].Text)
                                        {
                                            int number = int.Parse(labelsField[i, j].Text);
                                            score += number * 2;
                                            labelsField[i, j].Text = (number * 2).ToString();
                                            labelsField[i, k].Text = string.Empty;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int i = 0; i < fieldSize; i++)
                    {
                        for (int j = 0; j < fieldSize; j++)
                        {
                            if (labelsField[i, j].Text == string.Empty)
                            {
                                for (int k = j + 1; k < fieldSize; k++)
                                {
                                    if (labelsField[i, k].Text != string.Empty)
                                    {
                                        int number = int.Parse(labelsField[i, k].Text);
                                        labelsField[i, j].Text = number.ToString();
                                        labelsField[i, k].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.Up)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        for (int i = 0; i < fieldSize; i++)
                        {
                            if (labelsField[i, j].Text != string.Empty)
                            {
                                for (int k = i + 1; k < fieldSize; k++)
                                {
                                    if (labelsField[k, j].Text != string.Empty)
                                    {
                                        if (labelsField[i, j].Text == labelsField[k, j].Text)
                                        {
                                            int number = int.Parse(labelsField[i, j].Text);
                                            score += number * 2;
                                            labelsField[i, j].Text = (number * 2).ToString();
                                            labelsField[k, j].Text = string.Empty;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int j = 0; j < fieldSize; j++)
                    {
                        for (int i = 0; i < fieldSize; i++)
                        {
                            if (labelsField[i, j].Text == string.Empty)
                            {
                                for (int k = i + 1; k < fieldSize; k++)
                                {
                                    if (labelsField[k, j].Text != string.Empty)
                                    {
                                        int number = int.Parse(labelsField[k, j].Text);
                                        labelsField[i, j].Text = number.ToString();
                                        labelsField[k, j].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.Down)
                {
                    for (int j = 0; j < fieldSize; j++)
                    {
                        for (int i = fieldSize - 1; i >= 0; i--)
                        {
                            if (labelsField[i, j].Text != string.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsField[k, j].Text != string.Empty)
                                    {
                                        if (labelsField[i, j].Text == labelsField[k, j].Text)
                                        {
                                            int number = int.Parse(labelsField[i, j].Text);
                                            score += number * 2;
                                            labelsField[i, j].Text = (number * 2).ToString();
                                            labelsField[k, j].Text = string.Empty;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (int j = 0; j < fieldSize; j++)
                    {
                        for (int i = fieldSize - 1; i >= 0; i--)
                        {
                            if (labelsField[i, j].Text == string.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsField[k, j].Text != string.Empty)
                                    {
                                        int number = int.Parse(labelsField[k, j].Text);
                                        labelsField[i, j].Text = number.ToString();
                                        labelsField[k, j].Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                GenerateRandomNumber();
                ShowCurrentScore();
            }
        }

        private void restartMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesMenuItem_Click(object sender, EventArgs e)
        {
            string rules = "Правила игры 2048\r\n\r\n" +
                "1) Используйте стрелки на клавиатуре, чтобы сдвигать все плитки в выбранную сторону.\r\n" +
                "2) Если две плитки с одинаковым числом сталкиваются, они сливаются в одну с удвоенным значением (2 + 2 = 4, 4 + 4 = 8 и т. д.).\r\n" +
                "3) За один ход каждая плитка может слиться только один раз.\r\n" +
                "4) После каждого хода на свободной клетке появляется новая плитка: 2 или 4.\r\n" +
                "5) За каждое слияние к счёту прибавляется значение новой плитки.\r\n" +
                "6) Цель — собрать плитку 2048.\r\n" +
                "7) Игра заканчивается, когда на поле нет свободных клеток и ни одного возможного слияния.";
            MessageBox.Show(rules, "Правила игры 2048");
        }
    }
}
