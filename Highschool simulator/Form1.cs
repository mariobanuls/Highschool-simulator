using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highschool_simulator
{
    public partial class Form1 : Form
    {
        int page = 1;
        int engipoint = 0;
        string team = " ";
        string uni = "A";
        bool inTeam = false;
        string waterloo = "Waterloo";
        string queens = "Queens";
        string western = "Western";
        string community = "Community College";
        string art = "Liberal Arts";



        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            DisplayPage();
            pointsLabel.Visible = false;
            tittleLabel.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            uniButton.Visible = false;
            nextButton.Visible = false;
            promptLabel.Visible = false;
            questionLabel.Visible = false;
            collegeLabel.Visible = false;
            playButton.Visible = true;

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            pointsLabel.Visible = true;
            promptLabel.Visible = true;
            tittleLabel.Visible = false;
            playButton.Visible = false;
            page = 2;
            button1.Visible = true;
            button2.Visible = true;
            questionLabel.Visible = true;
            pictureBox1.Image = Properties.Resources.sdsslogo;

        }

        #region buttton 1 click
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (page == 2)
            {
            
                page = 3;
                engipoint += 2;

            }
            

            
            else if (page == 4)
            {
                page = 7;
                engipoint -= 1;
            }
            else if (page == 7)
            {
                engipoint -= 3;
                page = 8;
               
            }

            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 13;
            }

            else if (page == 3)
            {
                engipoint += 1;
                page = 15;
            }

            else if (page == 15)
            {
                engipoint += 1;
                page = 16;
            }

            else if (page == 18)
            {
                engipoint += 2;
                page = 16;
            }

            else if (page == 16)
            {
                engipoint += 2;
                page = 19;
            }

            else if (page == 17)
            {
                engipoint += 2;
                page = 19;
            }

            else if (page == 18)
            {
                engipoint += 2;
                page = 19;
            }
            else if (page == 21)
            {
               
                page = 22;
            }
            else if (page == 20)
            {
                
                page = 22;
            }
            else if (page == 5)
            {
                page = 22;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 23)
            {
                page = 24;
            }

            else if (page == 25)
            {
                page = 26;
            }

            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 22;
            }




            DisplayPage();
        }
        #endregion
        #region buttton 2 click
        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 4;
                engipoint -= 3;
            }
      
            else if (page == 3)
            {
                page = 18;
            }

            else if (page == 4)
            {
                page = 5;
                engipoint += 1;
            }

            else if (page == 6)
            {

                page = 9;
            }
            else if (page == 7)
            {
                
                page = 9;
            }

            else if (page == 8)
            {
                engipoint -= 3;
                page = 10;
            }
            else if (page == 9)
            {
                engipoint -= 3;
                page = 10;
            }

            else if (page == 10)
            {
                engipoint -= 3;
                page = 11;
            }
            else if (page == 15)
            {
                engipoint -= 1;
                page = 17;
            }
            else if (page == 16)
            {
                engipoint -= 1;
                page = 17;
            }
            else if (page == 17)
            {
                engipoint -= 1;
                page = 0 ;
            }
            else if (page == 21)
            {

                page = 23;
            }
            else if (page == 20)
            {

                page = 23;
            }
            else if (page == 5)
            { 
                page = 23;
            }
            else if (page == 19)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 22)
            {
                page = 25;
            }


            DisplayPage();
        }
        #endregion
        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    promptLabel.Text = $"You just finished middle school and enter sdss as a freshman.\nYou want to focus into the technology world and try to become an engineer. To enter the university of your dreams, make te right choices to win engipoints and have more chances of entering.";
                    questionLabel.Text = $"Take all the necesary credits?";
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    button1.Text = $"Yes, I don't want to be behind";
                    button2.Text = $"No, I'll get them later";
                
                    break;

                case 2: // take credits
                    promptLabel.Text = $"You just finished middle school and enter sdss as a freshman.\nYou want to focus into the technology world and try to become an engineer. To enter the university of your dreams, make te right choices to win engipoints and have more chances of entering.";
                    questionLabel.Text = $"Take all the necesary credits?";
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    button1.Text = $"Yes, I don't want to be behind";
                    button2.Text = $"No, I'll get them later";

                    break;

                case 3: //do u join the robotics team 
                    inTeam = false;
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You are a nice student! Mr Bradshaw wants you  in the robotics team!";
                    questionLabel.Text = $"Do you join the robotics team?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";

                    break;

                case 4: // skip with cole
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You dont get any credits in grade 9... Your parents spank you.\n\nYou start grade 10 with no credits gotten from grade 9. You get a bad rep and Cole offers you to skip class with him.";
                    questionLabel.Text = $"Do you skip with Cole?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";

                    break;

                case 5:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"He gets really aggresive and he hits you. You end grade 10 with enough credits.\nYou start grade 11 and you realize that you are in the prime of your life. You decide to get a girlfriend.";
                    questionLabel.Text = $"Do you go to the gym and get strong?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";

                    break;

                case 7: //drop out
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You get caught and get suspended. You gain a really bad rep.  Due to this reason, you have the choice to drop out.";
                    questionLabel.Text = $"Do you want to drop out?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";

                    break;

              

                case 8: //join gang
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You drop out of highschool. You are a complete failure. Nobody wants to be with you.\n\nYou have an awful reputation. Your friends don't want to be with you and you are alone. A gang want to recruit you ";
                    questionLabel.Text = $"Do you join the gang?";
                    button1.Text = $"No";
                    button2.Text = $"Yes";

                    break;

                case 9: //join gang
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You have an awful rep. Your friends don't want to be with you and you are alone. A gang want to recruit you.";
                    questionLabel.Text = $"Do you join the gang?";
                    button1.Text = $"No";
                    button2.Text = $"Yes";
                    break;

                case 10: //kill opp
                    pointsLabel.Text = $"You have {engipoint} engipoints."; 
                    promptLabel.Text = $"You join the gang, your parents find out and you are kicked out of your house. You are living in the streets at the age of 15.\n\nThe gang wants you to kill an opp.";
                    questionLabel.Text = $"Do you kill the opp?";
                    button1.Text = $"No";
                    button2.Text = $"Yes";
                    break;

                case 11: // lost
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You kill your opp. The police finds out and you rot in prison forever. You lost";
                    questionLabel.Text = $" ";
                    button1.Visible = false;
                    button2.Visible = false;
                    nextButton.Visible = true;

                    break;

                case 12:  // lost
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You don't take your chance but he does. You get killed at the age of 15.\nNobody cries your death, no one goes to you funeral. Your entire life wasn't worth anything for a bunch of bad decisions.  You lost.";
                    questionLabel.Text = $" ";
                    button1.Visible = false;
                    button2.Visible = false;
                    nextButton.Visible = true;
                    break;

                case 13:  // lost
                    pointsLabel.Text = $"You have {engipoint} engipoints."; 
                    promptLabel.Text = $"After multiple nights sleeping outside, winter arrives and on the 10th of december, you die of hypothermia. You lost";
                    questionLabel.Text = $" ";
                    button1.Visible = false;
                    button2.Visible = false;
                    nextButton.Visible = true;

                    break;

                

                case 15: //robotics team 
                    inTeam = true;
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"Nice! You are now in the robotics team!";
                    questionLabel.Text = $" ";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    Random randGen = new Random();
                    int randNum = randGen.Next(1, 5);
                     switch (randNum)
                    {
                        case 1:
                            team = "A";
                            promptLabel.Text = $"You got asigned the  group A, your leaders are Matthew, and Marek \nThe VEX season started!";
                            questionLabel.Text = $"What do you do?";
                            button1.Text = $"Work hard in the robot";
                            button2.Text = $"Play videogames";

                            break;

                        case 2:
                            team = "B";
                            promptLabel.Text = $"You got asigned the  group B, your leaders are Browen, and Gruveer \nThe VEX season started!";
                            questionLabel.Text = $"What do you do?";
                            button1.Text = $"Work hard in the robot";
                            button2.Text = $"Play videogames";

                            break;
                        case 3:
                            team = "C";
                            promptLabel.Text = $"You got asigned the  group C, your leaders are Aaron, and Alister \nThe VEX season started!";
                            questionLabel.Text = $"What do you do?";
                            button1.Text = $"Work hard in the robot";
                            button2.Text = $"Play videogames";

                            break;
                        case 4:
                            team = "D";
                            promptLabel.Text = $"You got asigned the  group D, your leaders are Ewan, and Nathan \nThe VEX season started!";
                            questionLabel.Text = $"What do you do?";
                            button1.Text = $"Work hard in the robot";
                            button2.Text = $"Play videogames";

                            break;
                    }
                    break;

                case 16: //Work hard??
                    
                    if (team == "A")
                    {
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        engipoint += 5;
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        promptLabel.Text = $"After lots of effort, team  A makes it to the VEX world championship in Dallas, congratulations!\nYou start grade 10. Your marks are amazing. Follow this path to get to the college of your dreams \nYou make it to the robotics team once again!\nThe season is over. Your team performs good but sadly you don't go to worlds because of Ayush's code sucks";
                        engipoint += 1;
                        button1.Text = $"Yes";
                        button2.Text = $"No";
                        questionLabel.Text = $"Do you want to work hard?";
                      
                    }
                    else //Work hard??
                    {
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        engipoint += 1;
                        button1.Text = $"Yes";
                        button2.Text = $"No";
                        questionLabel.Text = $"Do you want to work hard?";
                        promptLabel.Text = $"After lots of effort, team A makes it to the VEX world championship in Dallas! Sadly, you rot in team {team} \nThe day for the competition arrives and your robot is not even half way through. Your team is a disappointment for the robotics team\nYou start grade 10. Your marks are amazing. Follow this path to get to the college of your dreams \nYou make it to the robotics team once again!\nThe season is over. Your team performs good but sadly you don't go to worlds because of Ayush's code sucks";

                    }

                    break;

                case 17: //start grade 10 (no to work in the robot ) 

                    if (inTeam == true)
                    {
                        engipoint += 2;
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        button1.Text = $"Yes";
                        button2.Text = $"No";
                        questionLabel.Text = $"Do you want to work hard?";
                        promptLabel.Text = $"The day for the competition arrives and your robot is not even half way through. Your team is a disappointment for the robotics team\nYou start grade 10. Your marks are amazing. Follow this path to get to the college of your dreams \nYou make it to the robotics team once again!\nThe season is over. Your team performs good but sadly you don't go to worlds because of Ayush's code sucks";
                    }

                    else
                    {
                        page = 18;

                    }
                    break;

                    case 18:
                    inTeam = true;
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    questionLabel.Text = $"Join the robotics team?";
                    promptLabel.Text = $"This is your last chance to go enter the robotics team. Mr bradshaw sees potential in you. ";


                    break;

                case 19:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"After lots of coding and programing you become a master at python, java script and c sharp but c++ is too much to handle\nYou finish grade 10 as an amazing student and programer. You start grade 11 and you realize that you are in the prime of your life. You decide to get a girlfriend. ";
                    questionLabel.Text = $"Do you go to the gym and get strong?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    break;

                case 20:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"Nice! Here you will make friends and learn a lot about robotics ";
                    questionLabel.Text = $"Do you go to the gym and get strong?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    break;

                case 21:
                    engipoint += 2;
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"Nice! Here you will make friends and learn a lot about robotics ";
                    questionLabel.Text = $"Do you go to the gym and get strong?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    break;

                case 22:
                    engipoint += 2;
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    questionLabel.Text = $" ";
                    button1.Text = $" ";
                    button2.Text = $" ";
                    Random randGeen = new Random();
                    int randNuum = randGeen.Next(1, 101);
                    if (randNuum >= 25)
                    {
                        engipoint += 2;
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        promptLabel.Text = $"You get stronger and stronger. You have high chances of pulling a girl\nYou pull a 10. but make sure she doesn't distract you with the studies.\nShe asks you to spend time with her instead of studying so much";
                        questionLabel.Text = $"Do you study or go with her?";
                        button1.Text = $"Study";
                        button2.Text = $"Spend time with her";
                    }
                    else if (randNuum < 25)
                    {
                        engipoint += 1;
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        engipoint += 2;
                        promptLabel.Text = $"You get stronger and stronger. You have high chances of pulling a girl\nMaybe this is not for you...\nYou don't find a girl but still get 100s in every final exam. ";
                        
                    }
                    break;

                case 23:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    questionLabel.Text = $" ";
                    button1.Text = $" ";
                    button2.Text = $" ";
                    Random randGenn = new Random();
                    int randNumm = randGenn.Next(1, 101);
                    if (randNumm >= 15)
                    {
                        engipoint += 2;
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        promptLabel.Text = $"You pull a 10. but make sure she doesn't distract you with the studies.\nShe asks you to spend time with her instead of studying so much";
                        questionLabel.Text = $"Do you study or go with her?";
                        button1.Text = $"Study";
                        button2.Text = $"Spend time with her";
                    }
                    else if (randNumm < 15)
                    {
                        pointsLabel.Text = $"You have {engipoint} engipoints.";
                        engipoint += 2;
                        promptLabel.Text = $"Maybe this is not for you...\nYou don't find a girl but still get 100s in every final exam. ";

                    }
                    break;

                case 24:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"She breaks up with you.  But you get 100 in all the final exams. You know? maybe she wasn't the right one.\n And just like this you are a senior already. Time runs fast.\n With a 3.9 GPA, you are  the best at SDSS. Time to apply for college. ";
                    engipoint += 2;
                    questionLabel.Text = $"Do you want to apply to college?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    break;

                case 25:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You fail the final exams and you get broke because of her.\n And just like this you are a senior already. Time runs fast.\n You get your chance to apply to college even though your marks are horrible ";
                    engipoint -= 2;
                    questionLabel.Text = $"Do you want to apply to college?";
                    button1.Text = $"Yes";
                    button2.Text = $"No";
                    break;

                case 26:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"Just have to wait to get the results\nAfter waiting a lot, you get your applications back. ";
                    engipoint -= 2;
                    questionLabel.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                   
                    if (engipoint >= 14)
                    {
                        uni = "Waterloo";
                        uniButton.Visible = true;

                    }
                    else if (engipoint == 13 || engipoint == 12 || engipoint == 11)
                    {

                        uni = "Queens";
                        uniButton.Visible = true;
                    }
                    else if (engipoint == 10 || engipoint == 9)
                    {

                        uni = "Community college";
                        uniButton.Visible = true;
                    }
                    else if (engipoint == 8 || engipoint == 7 || engipoint == 6)
                    {

                       uni = "Western";
                        uniButton.Visible = true;
                    }
                    else if (engipoint <= 5)
                    {
                       
                       uni = "Liberal arts";
                        uniButton.Visible = true;
                    }
                    break;


                    






                case 27:
                    pointsLabel.Text = $"You have {engipoint} engipoints.";
                    promptLabel.Text = $"You don't apply to college... You end up working in mc donalds. All your life working hard to not apply. You lost";
                    questionLabel.Text = $" ";
                    button1.Visible = false;
                    button2.Visible = false;
                    nextButton.Visible = true;
                    break;





                case 99:
                    questionLabel.Text = $"Play again? ";
                    promptLabel.Text = $" ";
                    nextButton.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button2.Text = $"No";
                    button1.Text = $"Yes";
                    break;
                default:

                    break;
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
         
         this.Close();
         
        }

        private void uniButton_Click(object sender, EventArgs e)
        {
            if (uni == "Waterloo")

            {
                collegeLabel.Visible = true;

                collegeLabel.Text = $"Waterloo University";
                questionLabel.Text = $"  ";
                promptLabel.Text = $"All this hard work paid off! You made it to waterloo university. Congratulations, you win";
                uniButton.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                nextButton.Visible = true;
                pictureBox1.Image = Properties.Resources.waterloo;
            }

            else if (uni == "Queens")
            {
                collegeLabel.Visible = true;

                collegeLabel.Text = $"Queens University";
                questionLabel.Text = $"  ";
                promptLabel.Text = $"You enter queens college but it is not as good as waterloo university. Congrats anyways! You win";
                uniButton.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                nextButton.Visible = true;
                pictureBox1.Image = Properties.Resources.queens;
            }

            else if (uni == "Community college")
            {
                collegeLabel.Visible = true;

                collegeLabel.Text = $"Community College";
                questionLabel.Text = $"  ";
                promptLabel.Text = $"Congrats for making it to Community college.  You lost Yes, you lost. Next time aim higher, you can make it to waterloo ";
                uniButton.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                nextButton.Visible = true;
                pictureBox1.Image = Properties.Resources.community;
            }

            else if (uni == "Western")
            {
                collegeLabel.Visible = true;
                questionLabel.Text = $"  ";
                collegeLabel.Text = $"Western University";
                promptLabel.Text = $"You lost. You should be ashamed of entering Western";
                uniButton.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                nextButton.Visible = true;
                pictureBox1.Image = Properties.Resources.western;
            }

            else if (uni == "Liberal arts")
            {
                collegeLabel.Visible = true;
                collegeLabel.Text = $"Liberal Arts";
                questionLabel.Text = $"  ";
                promptLabel.Text = $"Just quit. Nobody deserves to go to liberal arts college. Obviously, you lost.";
                uniButton.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                nextButton.Visible = true;
                pictureBox1.Image = Properties.Resources.liberal;
            }
            else
            {
                promptLabel.Text = $"Nog eorking";
            }
           
        }      
    }
}
