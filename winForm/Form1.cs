using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm
{
    public partial class Form1 : Form
    {
        public bool button1WasClickedMenu = false;
        public bool button2WasClickedMenu = false;
        public bool button3WasClickedMenu = false;
        public bool button4WasClickedMenu = false;

        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;

            
            
            // Draws the field thru panel1_paint method
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(220, 86, 800, 300));
            Pen myPen = new Pen(System.Drawing.Color.White);
            formGraphics.DrawLine(myPen,  220,  86, 220, 385);
            formGraphics.DrawLine(myPen, 220, 86, 1018, 86);
            formGraphics.DrawLine(myPen, 1018, 86, 1018, 385);
            formGraphics.DrawLine(myPen, 1018, 385, 220, 385);
            // System.Drawing.Graphics formGraphics;

            myBrush.Dispose();
            formGraphics.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonInv.Height;
            panelLeft.Top = buttonInv.Top;
            button4WasClickedMenu = false;
            button1WasClickedMenu = false;
            button2WasClickedMenu = true;
            button3WasClickedMenu = false;
            txtTwo.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
            button4WasClickedMenu = false;
            button1WasClickedMenu = true;
            button2WasClickedMenu = false;
            button3WasClickedMenu = false;
            txtOne.BringToFront();
            
        }

        private void buttonSpellBook_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSpellBook.Height;
            panelLeft.Top = buttonSpellBook.Top;
            button4WasClickedMenu = false;
            button1WasClickedMenu = false;
            button2WasClickedMenu = false;
            button3WasClickedMenu = true;
            txtThree.BringToFront();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHelp.Height;
            panelLeft.Top = buttonHelp.Top;
            button4WasClickedMenu = true;
            button1WasClickedMenu = false;
            button2WasClickedMenu = false;
            button3WasClickedMenu = false;
            txtFour.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnCommand_Click(object sender, EventArgs e)
        {
            //Player player = new Player("");
            string CurrentCommand = txtCommand.Text.ToUpper();

            ////Sets characther information
            lblPlayerName.Text = CurrentCommand;
            //lblPlayerHP.Text = "HP: "+ player.playerCurrentHP+"/"+ player.playerFullHP;
            //lblPlayerXP.Text = player.playerCurrentEXP + "/" + player.playerFullEXP;
            //lblPlayerLVL.Text = player.playerCurrentLevel.ToString();

            btnCommand.Visible = false;
            txtCommand.Dispose();
            txtOne.Text = "Please select a class from the options below";

            btnCommand.Text = "OUTLAW";
            btnCommand.Visible = true;
            button2.Text = "PALADIN";
            button2.Visible = true;
            button3.Text = "MAGE";
            button3.Visible = true;
            button4.Text = "WARRIOR";
            button4.Visible = true;
            button5.Text = "ROGUE";
            button5.Visible = true;
            button6.Text = "PRIEST";
            button6.Visible = true;


            btnCommand.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text.ToUpper();
            setUpSelectClass(buttonText);
            btnCommand.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

        }

        public void setUpSelectClass(string theClass)
        {
            Player player = new Player(lblPlayerName.ToString());
            ////Sets characther information
            lblPlayerHP.Text = "HP: "+ player.playerCurrentHP+"/"+ player.playerFullHP;
            lblPlayerXP.Text = player.playerCurrentEXP + "/" + player.playerFullEXP;
            lblPlayerLVL.Text = player.playerCurrentLevel.ToString();

            switch (theClass)
            {
                case "OUTLAW":
                    {
                        player.attackBonus += 3;
                        player.speechBonus += 7;
                        player.sneakBonus += 10;
                        player.armourBonus += 2;
                        player.castingBonus += 1;
                        player.spellBook[0, 0] = "Lesser healing";
                        player.spellBook[1, 0] = "15";
                        player.spellBook[2, 0] = "HEALING";
                    }
                    break;
                case "PALADIN":
                    {
                        player.attackBonus += 7;
                        player.speechBonus += 3;
                        player.sneakBonus += 2;
                        player.armourBonus += 10;
                        player.castingBonus += 2;
                        player.spellBook[0, 0] = "Lesser healing";
                        player.spellBook[1, 0] = "15";
                        player.spellBook[2, 0] = "HEALING";
                    }
                    break;
                case "MAGE":
                    {
                        player.attackBonus += 5;
                        player.speechBonus += 5;
                        player.sneakBonus += 5;
                        player.armourBonus += 1;
                        player.castingBonus += 10;
                        player.spellBook[0, 0] = "Flames";
                        player.spellBook[1, 0] = "5";
                        player.spellBook[2, 0] = "DAMAGE";
                        player.spellBook[0, 1] = "Frostbite";
                        player.spellBook[1, 1] = "6";
                        player.spellBook[2, 1] = "DAMAGE";

                    }
                    break;
                case "WARRIOR":
                    {
                        player.attackBonus += 10;
                        player.speechBonus += 3;
                        player.sneakBonus += 3;
                        player.armourBonus += 6;
                        player.castingBonus += 2;
                        player.spellBook[0, 0] = "Lesser healing";
                        player.spellBook[1, 0] = "12";
                        player.spellBook[2, 0] = "HEALING";
                    }
                    break;
                case "ROGUE":
                    {
                        player.attackBonus += 5;
                        player.speechBonus += 5;
                        player.sneakBonus += 5;
                        player.armourBonus += 5;
                        player.castingBonus += 5;
                        player.spellBook[0, 0] = "Lesser healing";
                        player.spellBook[1, 0] = "12";
                        player.spellBook[2, 0] = "HEALING";
                    }
                    break;
                case "PRIEST":
                    {
                        player.attackBonus += 3;
                        player.speechBonus += 10;
                        player.sneakBonus += 6;
                        player.armourBonus += 5;
                        player.castingBonus += 8;
                        player.spellBook[0, 0] = "Lesser healing";
                        player.spellBook[1, 0] = "15";
                        player.spellBook[2, 0] = "HEALING";
                    }
                    break;
                default:
                    Console.Write("something went wrong please try again");
                    Console.ReadLine();
                    break;
            }

            txtFour.Text = "PLAYER STATS - Health: " + player.playerCurrentHP + "/" + player.playerFullHP + ". Experience: " + player.playerCurrentEXP + "/" + player.playerFullEXP + "." 
                + "Level: " + player.playerCurrentLevel;
            losehp(player);
        
    }

        public void losehp(Player player)
        {
            player.playerCurrentHP -= 10;
        }

        //public void displayStats(Player player)
        //{
        //    txtOne.Text = "PLAYER STATS - Health: "+player.playerCurrentHP+"/"+player.playerFullHP + ". Experience: "+ player.playerCurrentEXP+"/"+player.playerFullEXP+".";
        //}
        public class Player
        {

            public int playerCurrentHP = 50;
            public int playerFullHP = 100;
            public double playerCurrentEXP = 0;
            public double playerFullEXP = 100;
            public int playerCurrentLevel = 1;
            public int playerAttack = 10;

            public string PlayerName;
            public string playerWeapon = "Fists";

            public int attackBonus = 0;
            public int speechBonus = 0;
            public int sneakBonus = 0;
            public int armourBonus = 0;
            public int castingBonus = 0;
            public int teamMates = 0;
            public int steps = 0;

            public int gameOver = 0;
            public string playerName = "";
            public string currentCommand;
            public int restingTime;
            public string playerStatus = "neutral";
            public string playerClass = "";
            public int errorCode = 0;

            public string[,] spellBook = new string[10, 50];

            public Player(string name)
            {
                name = PlayerName;
            }



            public void setPlayerClass(string theClass)
            {
                switch (theClass)
                {
                    case "OUTLAW":
                        {
                            attackBonus += 3;
                            speechBonus += 7;
                            sneakBonus += 10;
                            armourBonus += 2;
                            castingBonus += 1;
                            spellBook[0, 0] = "Lesser healing";
                            spellBook[1, 0] = "15";
                            spellBook[2, 0] = "HEALING";
                        }
                        break;
                    case "PALADIN":
                        {
                            attackBonus += 7;
                            speechBonus += 3;
                            sneakBonus += 2;
                            armourBonus += 10;
                            castingBonus += 2;
                            spellBook[0, 0] = "Lesser healing";
                            spellBook[1, 0] = "15";
                            spellBook[2, 0] = "HEALING";
                        }
                        break;
                    case "MAGE":
                        {
                            attackBonus += 5;
                            speechBonus += 5;
                            sneakBonus += 5;
                            armourBonus += 1;
                            castingBonus += 10;
                            spellBook[0, 0] = "Flames";
                            spellBook[1, 0] = "5";
                            spellBook[2, 0] = "DAMAGE";
                            spellBook[0, 1] = "Frostbite";
                            spellBook[1, 1] = "6";
                            spellBook[2, 1] = "DAMAGE";

                        }
                        break;
                    case "WARRIOR":
                        {
                            attackBonus += 10;
                            speechBonus += 3;
                            sneakBonus += 3;
                            armourBonus += 6;
                            castingBonus += 2;
                            spellBook[0, 0] = "Lesser healing";
                            spellBook[1, 0] = "12";
                            spellBook[2, 0] = "HEALING";
                        }
                        break;
                    case "ROGUE":
                        {
                            attackBonus += 5;
                            speechBonus += 5;
                            sneakBonus += 5;
                            armourBonus += 5;
                            castingBonus += 5;
                            spellBook[0, 0] = "Lesser healing";
                            spellBook[1, 0] = "12";
                            spellBook[2, 0] = "HEALING";
                        }
                        break;
                    case "PRIEST":
                        {
                            attackBonus += 3;
                            speechBonus += 10;
                            sneakBonus += 6;
                            armourBonus += 5;
                            castingBonus += 8;
                            spellBook[0, 0] = "Lesser healing";
                            spellBook[1, 0] = "15";
                            spellBook[2, 0] = "HEALING";
                        }
                        break;
                    default:
                        break;
                }
            }
        }

    }

}
