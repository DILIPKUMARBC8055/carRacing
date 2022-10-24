namespace car_racing
{
    public partial class Form1 : Form
    {
        int speed = 6;
        int score = 0;
        
        public Form1()
        {
          
            InitializeComponent();
            button.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void roadMove(int speed)
        {
            Random r = new Random();
            if(ecar1.Top>400)
            {
                score++;
                Scorel.Text = "Score: " + score;
                
                ecar1.Left = r.Next(20, 150);

            }
            if (ecar2.Top > 400)
            {
                score++;
                Scorel.Text = "Score: " + score;

                ecar2.Left = r.Next(100, 230);

            }
            if (ecar3.Top > 400)
            {
                score++;
                Scorel.Text = "Score: " + score;

                ecar3.Left = r.Next(200, 350);

            }



            road1.Top %= 400;
            road2.Top %= 400;
            road3.Top %= 400;
            ecar1.Top %= 400;
            ecar2.Top %= 400;
            ecar3.Top %= 400;


            road1.Top += speed;
            road2.Top += speed;
            road3.Top += speed;
            ecar1.Top  += speed;
            ecar2.Top += speed;
            ecar3.Top += speed;


        }
       
        void gameover()
        {
            timer1.Stop();
            button.Visible = true;
            
            
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            roadMove(speed);

            if (car.Bounds.IntersectsWith(ecar1.Bounds) || car.Bounds.IntersectsWith(ecar2.Bounds) ||
                    car.Bounds.IntersectsWith(ecar3.Bounds) )
            {
                gameover();
            }


        }

        private void keyup(object sender, KeyEventArgs e)
        {
            

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up && speed <20)
            {
                speed+=2;
            }
            if(e.KeyCode == Keys.Down && speed>4)
            {
                speed-=2;
            }
            if(e.KeyCode == Keys.Left && car.Left>10)
            {
                car.Left-=10;

            }
            if(e.KeyCode== Keys.Right && car.Right<380)
            {
                car.Left+=10;
            }
        }

        private void gamestatus_Click(object sender, EventArgs e)
        {

        }
    }
}