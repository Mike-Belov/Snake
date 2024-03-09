using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeC_
{
    public partial class Form1 : Form
    {
        private int dirX, dirY;

        private int AppleNumber = 0;

        Random rnd = new Random();
        PictureBox[] snake = new PictureBox[400];

        private int snakeX = 20;
        private int snakeY = 20;

        private Point startPosition = new Point(240, 240);

        public int width = 1000;
        public int height = 800;
        int MapSize = 20;

        int speed = 10;

        private int score = 0;
        private PictureBox fruit;
        private int rX, rY;

        private Color colorsnake = new Color(); 

        private int length = 1;

        public Form1()
        {
            InitializeComponent();

            // Timer
            Timer.Enabled = false;
            Timer.Tick += new EventHandler(update);

            //Меню
            PlayButton.Visible = true;
            ExitButton.Visible = true;
            lose.Visible = false;

            Width = width;
            Height = height;
            KeyDown += new KeyEventHandler(OKP);

            // блокируем расширения окна
            FormBorderStyle = FormBorderStyle.FixedSingle;

            KeyPreview = true;

            LimeColor.Visible = false;
            BlueColor.Visible = false;
            YellowColor.Visible = false;
            ColorLabel.Visible = false;
            Play.Visible = false;
            VioletColor.Visible = false;
        }

        private void generateFruint()
        {
            rX = rnd.Next(0, Width - 200);
            int tempX = rX % MapSize;
            rX -= tempX;

            rY = rnd.Next(0, Height - 100);
            int tempY = rY % MapSize;
            rY -= tempY;

            fruit.Location = new Point(rX, rY);
            this.Controls.Add(fruit);
        }

        private void eatFuint()
        {
            if (snake[0].Location == fruit.Location)
            {
                length += 1;

                AppleNumber += 1;
                score++;

                Apple.Text = "Яблочек: " + AppleNumber; 
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + snakeX * dirX, snake[score - 1].Location.Y + snakeY * dirY);
                snake[score].Size = new Size(snakeX, snakeY);
                snake[score].BackColor = colorsnake;
                this.Controls.Add(snake[score]);
                generateFruint();
            }
        }

        void _eatItseif()
        {
            int massa = 0;

            for (int i = 1; i <= score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    for(int j = i; j <= score; j++)
                    {
                        massa += 1;
                        this.Controls.Remove(snake[j]);
                    }
                    score = score - massa;
                    length = score;
                }
            }
        }

        private void moveSnake()
        { 
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * speed, snake[0].Location.Y + dirY * speed);

            _eatItseif();
        }

        void PlayButton_Click(object sender, EventArgs e)
        {      
            PlayButton.Visible = false;
            ExitButton.Visible = false;
            lose.Visible = false;

            Play.Visible = true;

            LimeColor.Visible = true;
            BlueColor.Visible = true;
            YellowColor.Visible = true;
            ColorLabel.Visible = true;
            VioletColor.Visible = true;
        }

        void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        { 
            if (YellowColor.Checked == true)
            {
                colorsnake = Color.Yellow;
            }

            else if (LimeColor.Checked == true)
            {
                colorsnake = Color.Lime;
            }

            else if (BlueColor.Checked == true)
            {
                colorsnake = Color.Blue;
            }

            else if (VioletColor.Checked == true)
            {
                colorsnake = Color.Purple;
            }

            else
            {
                MessageBox.Show("Выберите цвет змейки");
                return;
            }

            snake[0] = new PictureBox();
            snake[0].Size = new Size(snakeX, snakeY);
            this.Controls.Add(snake[0]);
            snake[0].Location = startPosition;
            snake[0].BackColor = colorsnake;

            LimeColor.Visible = true;
            BlueColor.Visible = true;
            YellowColor.Visible = true;
            ColorLabel.Visible = true;

            score = 0;
            Apple.Text = "Яблочек: 0";

            Play.Visible = false;

            Timer.Enabled = true;

            LimeColor.Visible = false;
            BlueColor.Visible = false;
            YellowColor.Visible = false;
            ColorLabel.Visible = false;
            VioletColor.Visible = false;

            fruit = new PictureBox();
            fruit.BackColor = Color.Red;
            fruit.Size = new Size(snakeX, snakeY);

            LengthLabel.Text = "Длина: " + length;

            generateFruint();
        }


        void update(Object myObject, EventArgs eventargs)
        {
            LengthLabel.Text = "Длина: " + length;

            moveSnake();
            eatFuint();

            //условия проигрыша
            if (snake[0].Location.X > Width || snake[0].Location.X < -1)
            {
                LoseGame();
            }

            if (snake[0].Location.Y > Height || snake[0].Location.Y < -1)
            {
                LoseGame();
            }
        }

        void LoseGame()
        {
            Timer.Enabled = false;
            PlayButton.Visible = true;
            ExitButton.Visible = true;
            lose.Visible = true;

            Apple.Text = " ";
            LengthLabel.Text = " ";

            this.Controls.Remove(fruit);

            for (int i = 0; i <= score; i++)
            {
                this.Controls.Remove(snake[i]);
            }
        }

        // обработка нажати (управление)
        void OKP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Left) 
            {
                dirX = 1;
                dirY = 0;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Right)
            {
                dirX = -1;
                dirY = 0;
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                dirY = -1;
                dirX = 0;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                dirY = 1;
                dirX = 0;
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
