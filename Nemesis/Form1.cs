using System;
using System.Windows.Forms;

using WeAreDevs_API;

namespace Nemesis

{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            api.SendLuaScript(script);
        }
        private void execute2Button_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            api.SendLuaCScript(script);
        }

        

   

       
        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                label2.Text = "Injected";
                injectButton.Enabled = false;
            }
            else
            {
                label2.Text = "Not Injected";
                injectButton.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //Check if the exploit is injected every 3 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }
        private void sendCommand_Click(object sender, EventArgs e)
        {
            int selectionIndex = listBox1.SelectedIndex;
            if (selectionIndex == -1)
            {
                MessageBox.Show("Error", "No Command Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (selectionIndex == 0)
                {
                    api.SendLuaScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Fly.txt\"))");
                }
                else if (selectionIndex == 1)
                {
                    api.SendLuaScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/yvrTCave\"))");
                }
                else if (selectionIndex == 2)
                {
                    api.SendCommand("boxesp");
                }
                else if (selectionIndex == 3)
                {
                    api.SendCommand("btools me");
                }
                else if (selectionIndex == 4)
                {
                    api.ToggleClickTeleport();
                   
                }
                else if (selectionIndex == 5)
                {
                    api.SendLuaScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/cHKVsTg8\", true))");

                }
                else if (selectionIndex == 6)
                {
                    api.SendLuaScript("loadstring(game:GetObjects(\"rbxassetid://3473939051\")[1].Source)()");

                }
            }

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (walkSpeed.Value < 1 || jumpPower.Value < 1)
            {
                MessageBox.Show("Error", "Invalid Jump Power/Walk Speed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + walkSpeed.Value.ToString());
                api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + jumpPower.Value.ToString());
            }
        }

        private void tpButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            api.SendCommand("teleport " + username);
        }

    }
}
