using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Robot_Adventure_Final
{
    public partial class Robot : Form
    {
        // Tracks the page of the story the user is on
        int page = 1;
        SoundPlayer applause = new SoundPlayer(Properties.Resources.Applause);
        SoundPlayer press = new SoundPlayer(Properties.Resources.PressSound);

        //Random number generator
        Random randGen = new Random();
        public Robot()
        {
            InitializeComponent();

            optionButton1.Visible = false;
            optionButton2.Visible = false;
            optionButton3.Visible = false;
            outputLabel.Visible = false;
            pictureBox1.Image = (Properties.Resources.Apocolypse);
            applause = new SoundPlayer(Properties.Resources.Applause);
            SoundPlayer press = new SoundPlayer(Properties.Resources.PressSound);


        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4) //Fix robot with a 10% of chance. 
            {
                int randValue = randGen.Next(1, 101);

                if (randValue <= 10)
                {
                    page = 11;
                }
                else
                {
                    page = 12;
                }
            }
            else if (page == 5)

            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }

            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 19;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 1;
            }

            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }





            DisplayPage();
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            if (page == 11)
            {
                page = 13;

            }
            else if (page == 7)
            {
                page = 9;
            }

            DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 18;
            }
            else if (page == 5)
            {
                page = 1000;
            }
            else if (page == 6)
            {
                page = 1000;
            }
            else if (page == 7)
            {
                page = 17;
            }
            else if (page == 8)
            {
                page = 21;
            }
            else if (page == 9)
            {
                page = 16;
            }
            else if (page == 11)
            {
                page = 12;
            }

            else if (page == 12)
            {
                page = 1000;
            }

            else if (page == 13)
            {
                page = 1000;
            }
            else if (page == 14)
            {
                page = 1000;
            }
            else if (page == 16)
            {
                page = 1000;
            }
            else if (page == 17)
            {
                page = 1000;
            }
            else if (page == 18)
            {
                page = 1000;
            }
            else if (page == 19)
            {
                page = 1000;
            }
            else if (page == 21)
            {
                page = 1000;
            }

            DisplayPage();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            page = 1;
            outputLabel.Visible = true;

            DisplayPage();
        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 1: //case 1 == page 1 and same for other cases

                    optionButton1.Visible = true; //the button will be visible for player to select it
                    optionButton2.Visible = true;
                    outputLabel.Text = "You wakeup after the robot TAKEOVER. The world is left in ruins and you are the only form of human life left. Grab your weapons and explore the ruins...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    pictureBox1.Image = (Properties.Resources.Wake);
                    press.Play();

                    break;
                case 2:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You stay quiet in your hidden room and discover news articles and clues to help you. Do you chose to begin exploring...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false; 
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld2);

                    break;
                case 3:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You encounter a robot in the pile of ruins. He seems dead and broken. Do you chose to grab the robot for testing or leave it...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.Friend);

                    break;
                case 4:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text += "you collect the robot, you bring it back home to examine further.";
                    this.Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text += "You manage to fix the robot and have a chance to have a companion. Do you repair the robot hoping for a companion?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld3);

                    break;
                case 5:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You find a female in the distance shot by the arrow of the robot army you cry and decide to give up. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld);

                    break;
                case 6:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "A robot army searching for human remains find you and terminate you. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.Army);


                    break;
                case 7:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    optionButton3.Visible = true;
                    outputLabel.Text = "You leave the robot and get attacked by firing drones. What do you do to evade their strikes...";
                    optionButton1.Text = "Charge";
                    optionButton2.Text = "Weapon";
                    optionButton3.Text = "Hide";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.TurnBack);

                    break;
                case 8:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You kill one and enter its suit. You invade the palace they built for themselves";
                    this.Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "While exploring you come face to face with the robot leader and decide to strike. What do you go for...";
                    optionButton1.Text = "Head";
                    optionButton2.Text = "Face";
                    startButton.Visible = false;
                    optionButton3.Visible = false;
                    titleLabel.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.Army);

                    break;
                case 9:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You hide and your foot ends up being exposed and snapped off. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld2);


                    break;
                case 11:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    optionButton3.Visible = true;
                    outputLabel.Text = "You fixed the robot, meet your deadly companion";
                    this.Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You and your robot companion set out on a final mission to take back the world. How do you plan on killing the robots...";
                    optionButton1.Text = "Battlefield";
                    optionButton2.Text = "Base";
                    optionButton3.Text = "Leader";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld3);




                    break;
                case 12:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "Your attempt failed and the robot recovered life and killed you. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld2);


                    break;
                case 13:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You kill the leader and the army fails because your companion was a nuclear explosive";
                    this.Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You have completed the game friend. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    applause.Play();
                    pictureBox1.Image = (Properties.Resources.SightWorld3);
                    //Win sound


                    break;
                case 14:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You were immediately shot by a firing squad. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.Army);

                    break;
                case 16:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You hide and your foot ends up being exposed and snapped off. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.TurnBack);



                    break;
                case 17:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You find a sniper and begin shooting. You run out of ammo because you didnt check the mag. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.TurnBack);

                    break;
                case 18:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "The robot comes alive and detonates you after detecting human body radiation. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.GoOut);

                    break;
                case 19:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "You go for the head and unlike Thanos he falls down and mumbles This is not the end";
                    this.Refresh();
                    Thread.Sleep(4000);
                    outputLabel.Text = "You have completed the game friend. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    applause.Play();
                    pictureBox1.Image = (Properties.Resources.GoOut);
                    //Win sound


                    break;

                case 21:
                    optionButton2.Visible = true;
                    optionButton1.Visible = true;
                    outputLabel.Text = "He moves out of the way laughing at you, he picks you up and sends you into orbit. Play again...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.Army);


                    break;


                case 1000:
                    optionButton2.Visible = false;
                    optionButton1.Visible = false;
                    outputLabel.Text = " You're bad at this game go home and play Fortnite...";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    startButton.Visible = false;
                    titleLabel.Visible = false;
                    optionButton3.Visible = false;
                    press.Play();
                    pictureBox1.Image = (Properties.Resources.TurnBack);
                    Refresh();
                    Thread.Sleep(4000);
                    Application.Exit();


                    break;
            }








        }
    }
}


