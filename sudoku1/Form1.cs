using System;

namespace sudoku1
{
    public partial class Form1 : Form
    {

        private int[][] puzzle =
        {
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0}
        };
        private static int[][] grid = new int[9][];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lock_all();
            clear_all();
            button2.Enabled = false;
            button1.Enabled = false;
        }
        private void lock_all()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox51.Enabled = false;
            textBox52.Enabled = false;
            textBox53.Enabled = false;
            textBox54.Enabled = false;
            textBox55.Enabled = false;
            textBox56.Enabled = false;
            textBox57.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox61.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox65.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;
            textBox69.Enabled = false;
            textBox70.Enabled = false;
            textBox71.Enabled = false;
            textBox72.Enabled = false;
            textBox73.Enabled = false;
            textBox74.Enabled = false;
            textBox75.Enabled = false;
            textBox76.Enabled = false;
            textBox77.Enabled = false;
            textBox78.Enabled = false;
            textBox79.Enabled = false;
            textBox80.Enabled = false;
            textBox81.Enabled = false;

        }
        private void clear_all()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {           
                    puzzle[i][j] = 0;
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
            textBox55.Text = "";
            textBox56.Text = "";
            textBox57.Text = "";
            textBox58.Text = "";
            textBox59.Text = "";
            textBox60.Text = "";
            textBox61.Text = "";
            textBox62.Text = "";
            textBox63.Text = "";
            textBox64.Text = "";
            textBox65.Text = "";
            textBox66.Text = "";
            textBox67.Text = "";
            textBox68.Text = "";
            textBox69.Text = "";
            textBox70.Text = "";
            textBox71.Text = "";
            textBox72.Text = "";
            textBox73.Text = "";
            textBox74.Text = "";
            textBox75.Text = "";
            textBox76.Text = "";
            textBox77.Text = "";
            textBox78.Text = "";
            textBox79.Text = "";
            textBox80.Text = "";
            textBox81.Text = "";
        }


        public void update(int index, int value)
        {
            if (index >= 0 && index < 9) { puzzle[0][index] = value; }
            if (index >= 9 && index < 18) { puzzle[1][index - 9] = value; }
            if (index >= 18 && index < 27) { puzzle[2][index - 18] = value; }
            if (index >= 27 && index < 36) { puzzle[3][index - 27] = value; }
            if (index >= 36 && index < 45) { puzzle[4][index - 36] = value; }
            if (index >= 45 && index < 54) { puzzle[5][index - 45] = value; }
            if (index >= 54 && index < 63) { puzzle[6][index - 54] = value; }
            if (index >= 63 && index < 72) { puzzle[7][index - 63] = value; }
            if (index >= 72 && index < 81) { puzzle[8][index - 72] = value; }

        }

        public void sudoku_game()
        {

            if (SolveSudoku())
            {
                PrintSudoku();
            }
            else
            {
                clear_all();
                textBox1.Text = "N";
                textBox2.Text = "o";
                textBox10.Text = "S";
                textBox11.Text = "o";
                textBox12.Text = "l";
                textBox13.Text = "u";
                textBox14.Text = "t";
                textBox15.Text = "i";
                textBox16.Text = "o";
                textBox17.Text = "n";
                textBox19.Text = "E";
                textBox20.Text = "x";
                textBox21.Text = "i";
                textBox22.Text = "s";
                textBox23.Text = "t";
            }

        }

        static bool SolveSudoku()
        {
            int row, col;

            if (!FindUnassignedCell(out row, out col))
            {
                return true; // All cells are assigned
            }

            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(row, col, num))
                {
                    grid[row][col] = num;

                    if (SolveSudoku())
                    {
                        return true; // If it leads to a solution, return true
                    }

                    grid[row][col] = 0; // Otherwise, backtrack and try the next number
                }
            }

            return false; // No solution exists in this branch
        }

        static bool FindUnassignedCell(out int row, out int col)
        {
            for (row = 0; row < 9; row++)
            {
                for (col = 0; col < 9; col++)
                {
                    if (grid[row][col] == 0)
                    {
                        return true; // Unassigned cell found
                    }
                }
            }

            row = col = -1; // No unassigned cell found
            return false;
        }

        static bool IsSafe(int row, int col, int num)
        {
            // Check if 'num' is not in current row, current column, and current 3x3 box
            return !UsedInRow(row, num) && !UsedInCol(col, num) && !UsedInBox(row - row % 3, col - col % 3, num);
        }

        static bool UsedInRow(int row, int num)
        {
            for (int col = 0; col < 9; col++)
            {
                if (grid[row][col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        static bool UsedInCol(int col, int num)
        {
            for (int row = 0; row < 9; row++)
            {
                if (grid[row][col] == num)
                {
                    return true;
                }
            }
            return false;
        }

        static bool UsedInBox(int boxStartRow, int boxStartCol, int num)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (grid[row + boxStartRow][col + boxStartCol] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void PrintSudoku()
        {
            textBox1.Text = Convert.ToString(grid[0][0]);
            textBox2.Text = Convert.ToString(grid[0][1]);
            textBox3.Text = Convert.ToString(grid[0][2]);
            textBox4.Text = Convert.ToString(grid[0][3]);
            textBox5.Text = Convert.ToString(grid[0][4]);
            textBox6.Text = Convert.ToString(grid[0][5]);
            textBox7.Text = Convert.ToString(grid[0][6]);
            textBox8.Text = Convert.ToString(grid[0][7]);
            textBox9.Text = Convert.ToString(grid[0][8]);
            textBox10.Text = Convert.ToString(grid[1][0]);
            textBox11.Text = Convert.ToString(grid[1][1]);
            textBox12.Text = Convert.ToString(grid[1][2]);
            textBox13.Text = Convert.ToString(grid[1][3]);
            textBox14.Text = Convert.ToString(grid[1][4]);
            textBox15.Text = Convert.ToString(grid[1][5]);
            textBox16.Text = Convert.ToString(grid[1][6]);
            textBox17.Text = Convert.ToString(grid[1][7]);
            textBox18.Text = Convert.ToString(grid[1][8]);
            textBox19.Text = Convert.ToString(grid[2][0]);
            textBox20.Text = Convert.ToString(grid[2][1]);
            textBox21.Text = Convert.ToString(grid[2][2]);
            textBox22.Text = Convert.ToString(grid[2][3]);
            textBox23.Text = Convert.ToString(grid[2][4]);
            textBox24.Text = Convert.ToString(grid[2][5]);
            textBox25.Text = Convert.ToString(grid[2][6]);
            textBox26.Text = Convert.ToString(grid[2][7]);
            textBox27.Text = Convert.ToString(grid[2][8]);
            textBox28.Text = Convert.ToString(grid[3][0]);
            textBox29.Text = Convert.ToString(grid[3][1]);
            textBox30.Text = Convert.ToString(grid[3][2]);
            textBox31.Text = Convert.ToString(grid[3][3]);
            textBox32.Text = Convert.ToString(grid[3][4]);
            textBox33.Text = Convert.ToString(grid[3][5]);
            textBox34.Text = Convert.ToString(grid[3][6]);
            textBox35.Text = Convert.ToString(grid[3][7]);
            textBox36.Text = Convert.ToString(grid[3][8]);
            textBox37.Text = Convert.ToString(grid[4][0]);
            textBox38.Text = Convert.ToString(grid[4][1]);
            textBox39.Text = Convert.ToString(grid[4][2]);
            textBox40.Text = Convert.ToString(grid[4][3]);
            textBox41.Text = Convert.ToString(grid[4][4]);
            textBox42.Text = Convert.ToString(grid[4][5]);
            textBox43.Text = Convert.ToString(grid[4][6]);
            textBox44.Text = Convert.ToString(grid[4][7]);
            textBox45.Text = Convert.ToString(grid[4][8]);
            textBox46.Text = Convert.ToString(grid[5][0]);
            textBox47.Text = Convert.ToString(grid[5][1]);
            textBox48.Text = Convert.ToString(grid[5][2]);
            textBox49.Text = Convert.ToString(grid[5][3]);
            textBox50.Text = Convert.ToString(grid[5][4]);
            textBox51.Text = Convert.ToString(grid[5][5]);
            textBox52.Text = Convert.ToString(grid[5][6]);
            textBox53.Text = Convert.ToString(grid[5][7]);
            textBox54.Text = Convert.ToString(grid[5][8]);
            textBox55.Text = Convert.ToString(grid[6][0]);
            textBox56.Text = Convert.ToString(grid[6][1]);
            textBox57.Text = Convert.ToString(grid[6][2]);
            textBox58.Text = Convert.ToString(grid[6][3]);
            textBox59.Text = Convert.ToString(grid[6][4]);
            textBox60.Text = Convert.ToString(grid[6][5]);
            textBox61.Text = Convert.ToString(grid[6][6]);
            textBox62.Text = Convert.ToString(grid[6][7]);
            textBox63.Text = Convert.ToString(grid[6][8]);
            textBox64.Text = Convert.ToString(grid[7][0]);
            textBox65.Text = Convert.ToString(grid[7][1]);
            textBox66.Text = Convert.ToString(grid[7][2]);
            textBox67.Text = Convert.ToString(grid[7][3]);
            textBox68.Text = Convert.ToString(grid[7][4]);
            textBox69.Text = Convert.ToString(grid[7][5]);
            textBox70.Text = Convert.ToString(grid[7][6]);
            textBox71.Text = Convert.ToString(grid[7][7]);
            textBox72.Text = Convert.ToString(grid[7][8]);
            textBox73.Text = Convert.ToString(grid[8][0]);
            textBox74.Text = Convert.ToString(grid[8][1]);
            textBox75.Text = Convert.ToString(grid[8][2]);
            textBox76.Text = Convert.ToString(grid[8][3]);
            textBox77.Text = Convert.ToString(grid[8][4]);
            textBox78.Text = Convert.ToString(grid[8][5]);
            textBox79.Text = Convert.ToString(grid[8][6]);
            textBox80.Text = Convert.ToString(grid[8][7]);
            textBox81.Text = Convert.ToString(grid[8][8]);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox1.Text == "" && ch > 48 && ch < 58)
            {
                update(0, ch - 48);
            }
            if (ch == 8)
            {
                update(0, 0);
            }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox2.Text == "" && ch > 48 && ch < 58)
            {
                update(1, ch - 48);
            }
            if (ch == 8)
            {
                update(1, 0);
            }

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox3.Text == "" && ch > 48 && ch < 58)
            {
                update(2, ch - 48);
            }
            if (ch == 8)
            {
                update(2, 0);
            }

        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox4.Text == "" && ch > 48 && ch < 58)
            {
                update(3, ch - 48);
            }
            if (ch == 8)
            {
                update(3, 0);
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox5.Text == "" && ch > 48 && ch < 58)
            {
                update(4, ch - 48);
            }
            if (ch == 8)
            {
                update(4, 0);
            }

        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox6.Text == "" && ch > 48 && ch < 58)
            {
                update(5, ch - 48);
            }
            if (ch == 8)
            {
                update(5, 0);
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox7.Text == "" && ch > 48 && ch < 58)
            {
                update(6, ch - 48);
            }
            if (ch == 8)
            {
                update(6, 0);
            }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox8.Text == "" && ch > 48 && ch < 58)
            {
                update(7, ch - 48);
            }
            if (ch == 8)
            {
                update(7, 0);
            }

        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox9.Text == "" && ch > 48 && ch < 58)
            {
                update(8, ch - 48);
            }
            if (ch == 8)
            {
                update(8, 0);
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox10.Text == "" && ch > 48 && ch < 58)
            {
                update(9, ch - 48);
            }
            if (ch == 8)
            {
                update(9, 0);
            }

        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox11.Text == "" && ch > 48 && ch < 58)
            {
                update(10, ch - 48);
            }
            if (ch == 8)
            {
                update(10, 0);
            }

        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox12.Text == "" && ch > 48 && ch < 58)
            {
                update(11, ch - 48);
            }
            if (ch == 8)
            {
                update(11, 0);
            }
        }
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox13.Text == "" && ch > 48 && ch < 58)
            {
                update(12, ch - 48);
            }
            if (ch == 8)
            {
                update(12, 0);
            }
        }
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox14.Text == "" && ch > 48 && ch < 58)
            {
                update(13, ch - 48);
            }
            if (ch == 8)
            {
                update(13, 0);
            }
        }
        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox15.Text == "" && ch > 48 && ch < 58)
            {
                update(14, ch - 48);
            }
            if (ch == 8)
            {
                update(14, 0);
            }
        }
        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox16.Text == "" && ch > 48 && ch < 58)
            {
                update(15, ch - 48);
            }
            if (ch == 8)
            {
                update(15, 0);
            }
        }
        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox17.Text == "" && ch > 48 && ch < 58)
            {
                update(16, ch - 48);
            }
            if (ch == 8)
            {
                update(16, 0);
            }
        }
        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox18.Text == "" && ch > 48 && ch < 58)
            {
                update(17, ch - 48);
            }
            if (ch == 8)
            {
                update(17, 0);
            }
        }
        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox19.Text == "" && ch > 48 && ch < 58)
            {
                update(18, ch - 48);
            }
            if (ch == 8)
            {
                update(18, 0);
            }
        }
        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox20.Text == "" && ch > 48 && ch < 58)
            {
                update(19, ch - 48);
            }
            if (ch == 8)
            {
                update(19, 0);
            }
        }
        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox21.Text == "" && ch > 48 && ch < 58)
            {
                update(20, ch - 48);
            }
            if (ch == 8)
            {
                update(20, 0);
            }
        }
        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox22.Text == "" && ch > 48 && ch < 58)
            {
                update(21, ch - 48);
            }
            if (ch == 8)
            {
                update(21, 0);
            }
        }
        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox23.Text == "" && ch > 48 && ch < 58)
            {
                update(22, ch - 48);
            }
            if (ch == 8)
            {
                update(22, 0);
            }
        }
        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox24.Text == "" && ch > 48 && ch < 58)
            {
                update(23, ch - 48);
            }
            if (ch == 8)
            {
                update(23, 0);
            }
        }
        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox25.Text == "" && ch > 48 && ch < 58)
            {
                update(24, ch - 48);
            }
            if (ch == 8)
            {
                update(24, 0);
            }
        }
        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox26.Text == "" && ch > 48 && ch < 58)
            {
                update(25, ch - 48);
            }
            if (ch == 8)
            {
                update(25, 0);
            }
        }
        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox27.Text == "" && ch > 48 && ch < 58)
            {
                update(26, ch - 48);
            }
            if (ch == 8)
            {
                update(26, 0);
            }
        }
        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox28.Text == "" && ch > 48 && ch < 58)
            {
                update(27, ch - 48);
            }
            if (ch == 8)
            {
                update(27, 0);
            }
        }
        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox29.Text == "" && ch > 48 && ch < 58)
            {
                update(28, ch - 48);
            }
            if (ch == 8)
            {
                update(28, 0);
            }
        }
        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox30.Text == "" && ch > 48 && ch < 58)
            {
                update(29, ch - 48);
            }
            if (ch == 8)
            {
                update(29, 0);
            }
        }
        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox31.Text == "" && ch > 48 && ch < 58)
            {
                update(30, ch - 48);
            }
            if (ch == 8)
            {
                update(30, 0);
            }
        }
        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox32.Text == "" && ch > 48 && ch < 58)
            {
                update(31, ch - 48);
            }
            if (ch == 8)
            {
                update(31, 0);
            }
        }
        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox33.Text == "" && ch > 48 && ch < 58)
            {
                update(32, ch - 48);
            }
            if (ch == 8)
            {
                update(32, 0);
            }
        }
        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox34.Text == "" && ch > 48 && ch < 58)
            {
                update(33, ch - 48);
            }
            if (ch == 8)
            {
                update(33, 0);
            }
        }
        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox35.Text == "" && ch > 48 && ch < 58)
            {
                update(34, ch - 48);
            }
            if (ch == 8)
            {
                update(34, 0);
            }
        }
        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox36.Text == "" && ch > 48 && ch < 58)
            {
                update(35, ch - 48);
            }
            if (ch == 8)
            {
                update(35, 0);
            }
        }
        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox37.Text == "" && ch > 48 && ch < 58)
            {
                update(36, ch - 48);
            }
            if (ch == 8)
            {
                update(36, 0);
            }
        }
        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox38.Text == "" && ch > 48 && ch < 58)
            {
                update(37, ch - 48);
            }
            if (ch == 8)
            {
                update(37, 0);
            }
        }
        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox39.Text == "" && ch > 48 && ch < 58)
            {
                update(38, ch - 48);
            }
            if (ch == 8)
            {
                update(38, 0);
            }
        }
        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox40.Text == "" && ch > 48 && ch < 58)
            {
                update(39, ch - 48);
            }
            if (ch == 8)
            {
                update(39, 0);
            }
        }
        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox41.Text == "" && ch > 48 && ch < 58)
            {
                update(40, ch - 48);
            }
            if (ch == 8)
            {
                update(40, 0);
            }
        }
        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox42.Text == "" && ch > 48 && ch < 58)
            {
                update(41, ch - 48);
            }
            if (ch == 8)
            {
                update(41, 0);
            }
        }
        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox43.Text == "" && ch > 48 && ch < 58)
            {
                update(42, ch - 48);
            }
            if (ch == 8)
            {
                update(42, 0);
            }
        }
        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox44.Text == "" && ch > 48 && ch < 58)
            {
                update(43, ch - 48);
            }
            if (ch == 8)
            {
                update(43, 0);
            }
        }
        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox45.Text == "" && ch > 48 && ch < 58)
            {
                update(44, ch - 48);
            }
            if (ch == 8)
            {
                update(44, 0);
            }
        }
        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox46.Text == "" && ch > 48 && ch < 58)
            {
                update(45, ch - 48);
            }
            if (ch == 8)
            {
                update(45, 0);
            }
        }
        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox47.Text == "" && ch > 48 && ch < 58)
            {
                update(46, ch - 48);
            }
            if (ch == 8)
            {
                update(46, 0);
            }
        }
        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox48.Text == "" && ch > 48 && ch < 58)
            {
                update(47, ch - 48);
            }
            if (ch == 8)
            {
                update(47, 0);
            }
        }
        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox49.Text == "" && ch > 48 && ch < 58)
            {
                update(48, ch - 48);
            }
            if (ch == 8)
            {
                update(48, 0);
            }
        }
        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox50.Text == "" && ch > 48 && ch < 58)
            {
                update(49, ch - 48);
            }
            if (ch == 8)
            {
                update(49, 0);
            }
        }
        private void textBox51_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox51.Text == "" && ch > 48 && ch < 58)
            {
                update(50, ch - 48);
            }
            if (ch == 8)
            {
                update(50, 0);
            }
        }
        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox52.Text == "" && ch > 48 && ch < 58)
            {
                update(51, ch - 48);
            }
            if (ch == 8)
            {
                update(51, 0);
            }
        }
        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox53.Text == "" && ch > 48 && ch < 58)
            {
                update(52, ch - 48);
            }
            if (ch == 8)
            {
                update(52, 0);
            }
        }
        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox54.Text == "" && ch > 48 && ch < 58)
            {
                update(53, ch - 48);
            }
            if (ch == 8)
            {
                update(53, 0);
            }
        }
        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox55.Text == "" && ch > 48 && ch < 58)
            {
                update(54, ch - 48);
            }
            if (ch == 8)
            {
                update(54, 0);
            }
        }
        private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox56.Text == "" && ch > 48 && ch < 58)
            {
                update(55, ch - 48);
            }
            if (ch == 8)
            {
                update(55, 0);
            }
        }
        private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox57.Text == "" && ch > 48 && ch < 58)
            {
                update(56, ch - 48);
            }
            if (ch == 8)
            {
                update(56, 0);
            }
        }
        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox58.Text == "" && ch > 48 && ch < 58)
            {
                update(57, ch - 48);
            }
            if (ch == 8)
            {
                update(57, 0);
            }
        }
        private void textBox59_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox59.Text == "" && ch > 48 && ch < 58)
            {
                update(58, ch - 48);
            }
            if (ch == 8)
            {
                update(58, 0);
            }
        }
        private void textBox60_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox60.Text == "" && ch > 48 && ch < 58)
            {
                update(59, ch - 48);
            }
            if (ch == 8)
            {
                update(59, 0);
            }
        }
        private void textBox61_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox61.Text == "" && ch > 48 && ch < 58)
            {
                update(60, ch - 48);
            }
            if (ch == 8)
            {
                update(60, 0);
            }
        }
        private void textBox62_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox62.Text == "" && ch > 48 && ch < 58)
            {
                update(61, ch - 48);
            }
            if (ch == 8)
            {
                update(61, 0);
            }
        }
        private void textBox63_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox63.Text == "" && ch > 48 && ch < 58)
            {
                update(62, ch - 48);
            }
            if (ch == 8)
            {
                update(62, 0);
            }
        }
        private void textBox64_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox64.Text == "" && ch > 48 && ch < 58)
            {
                update(63, ch - 48);
            }
            if (ch == 8)
            {
                update(63, 0);
            }
        }
        private void textBox65_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox65.Text == "" && ch > 48 && ch < 58)
            {
                update(64, ch - 48);
            }
            if (ch == 8)
            {
                update(64, 0);
            }
        }
        private void textBox66_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox66.Text == "" && ch > 48 && ch < 58)
            {
                update(65, ch - 48);
            }
            if (ch == 8)
            {
                update(65, 0);
            }
        }
        private void textBox67_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox67.Text == "" && ch > 48 && ch < 58)
            {
                update(66, ch - 48);
            }
            if (ch == 8)
            {
                update(66, 0);
            }
        }
        private void textBox68_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox68.Text == "" && ch > 48 && ch < 58)
            {
                update(67, ch - 48);
            }
            if (ch == 8)
            {
                update(67, 0);
            }
        }
        private void textBox69_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox69.Text == "" && ch > 48 && ch < 58)
            {
                update(68, ch - 48);
            }
            if (ch == 8)
            {
                update(68, 0);
            }
        }
        private void textBox70_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox70.Text == "" && ch > 48 && ch < 58)
            {
                update(69, ch - 48);
            }
            if (ch == 8)
            {
                update(69, 0);
            }
        }
        private void textBox71_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox71.Text == "" && ch > 48 && ch < 58)
            {
                update(70, ch - 48);
            }
            if (ch == 8)
            {
                update(70, 0);
            }

        }
        private void textBox72_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox72.Text == "" && ch > 48 && ch < 58)
            {
                update(71, ch - 48);
            }
            if (ch == 8)
            {
                update(71, 0);
            }
        }
        private void textBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox73.Text == "" && ch > 48 && ch < 58)
            {
                update(72, ch - 48);
            }
            if (ch == 8)
            {
                update(72, 0);
            }
        }
        private void textBox74_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox74.Text == "" && ch > 48 && ch < 58)
            {
                update(73, ch - 48);
            }
            if (ch == 8)
            {
                update(73, 0);
            }
        }
        private void textBox75_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox75.Text == "" && ch > 48 && ch < 58)
            {
                update(74, ch - 48);
            }
            if (ch == 8)
            {
                update(74, 0);
            }
        }
        private void textBox76_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox76.Text == "" && ch > 48 && ch < 58)
            {
                update(75, ch - 48);
            }
            if (ch == 8)
            {
                update(75, 0);
            }
        }
        private void textBox77_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox77.Text == "" && ch > 48 && ch < 58)
            {
                update(76, ch - 48);
            }
            if (ch == 8)
            {
                update(76, 0);
            }
        }
        private void textBox78_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox78.Text == "" && ch > 48 && ch < 58)
            {
                update(77, ch - 48);
            }
            if (ch == 8)
            {
                update(77, 0);
            }
        }
        private void textBox79_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox79.Text == "" && ch > 48 && ch < 58)
            {
                update(78, ch - 48);
            }
            if (ch == 8)
            {
                update(78, 0);
            }
        }
        private void textBox80_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox80.Text == "" && ch > 48 && ch < 58)
            {
                update(79, ch - 48);
            }
            if (ch == 8)
            {
                update(79, 0);
            }
        }
        private void textBox81_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch > 48 && ch < 58) && ch != 8)
            {
                e.Handled = true;
            }
            if (textBox81.Text == "" && ch > 48 && ch < 58)
            {
                update(80, ch - 48);
            }
            if (ch == 8)
            {
                update(80, 0);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;
            textBox28.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox32.Enabled = true;
            textBox33.Enabled = true;
            textBox34.Enabled = true;
            textBox35.Enabled = true;
            textBox36.Enabled = true;
            textBox37.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox41.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox45.Enabled = true;
            textBox46.Enabled = true;
            textBox47.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox50.Enabled = true;
            textBox51.Enabled = true;
            textBox52.Enabled = true;
            textBox53.Enabled = true;
            textBox54.Enabled = true;
            textBox55.Enabled = true;
            textBox56.Enabled = true;
            textBox57.Enabled = true;
            textBox58.Enabled = true;
            textBox59.Enabled = true;
            textBox60.Enabled = true;
            textBox61.Enabled = true;
            textBox62.Enabled = true;
            textBox63.Enabled = true;
            textBox64.Enabled = true;
            textBox65.Enabled = true;
            textBox66.Enabled = true;
            textBox67.Enabled = true;
            textBox68.Enabled = true;
            textBox69.Enabled = true;
            textBox70.Enabled = true;
            textBox71.Enabled = true;
            textBox72.Enabled = true;
            textBox73.Enabled = true;
            textBox74.Enabled = true;
            textBox75.Enabled = true;
            textBox76.Enabled = true;
            textBox77.Enabled = true;
            textBox78.Enabled = true;
            textBox79.Enabled = true;
            textBox80.Enabled = true;
            textBox81.Enabled = true;

        }



        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 9; i++)
            {
                grid[i] = new int[9];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i][j] = puzzle[i][j];
                }
            }
            sudoku_game();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_all();
        }
    }
}