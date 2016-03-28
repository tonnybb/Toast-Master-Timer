using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToastTimer
{
    public partial class Form1 : Form
    {
        // Keeps track of the remaining time
        int currentTime = 0;

        string formattedTime, topicForListBox;

        // Used to set the row color of the listView (historic speaker)
        Color listViewBackColorRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void startTimerBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = default(Color);

            timer1.Start();
            startTimerBtn.Enabled = false;
            stopTimerBtn.Enabled = true;
            speakerListBox.Enabled = false;
            deleteSpeakerBtn.Enabled = false;
            groupBox1.Enabled = false;

            if (speechOpt.Checked)
            {
                topicForListBox = speechOpt.Text;
            }
            else if (tableTopicOpt.Checked)
            {
                topicForListBox = tableTopicOpt.Text;
            }
            else
            {
                topicForListBox = evaluationOpt.Text;
            }

            // Set the background color for the listview if the timer never reaches the green stage
            listViewBackColorRow = Color.Cyan;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime += 1;

            int minute, second;
            // format seconds into minutes/seconds
            minute = currentTime / 60;
            second = currentTime % 60;

            // Add a zero in front of single digit numbers
            if (second < 10)
            {
                formattedTime = "0" + minute.ToString() + ":0" + second.ToString();
                timerLabel.Text = formattedTime;
            }
            else
            {
                formattedTime = "0" + minute.ToString() + ":" + second.ToString();
                timerLabel.Text = formattedTime;
            }


            // If giving a speech and 5min have passed, make the background color green
            if (currentTime > 300 && currentTime < 361 && speechOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Green;
                listViewBackColorRow = System.Drawing.Color.LightGreen; // Change the color of the listView row depending on the time
            }
            else if (currentTime > 360 && currentTime < 421 && speechOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Yellow;
                listViewBackColorRow = System.Drawing.Color.Yellow;
            }
            else if (currentTime > 420 && speechOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Red;
                listViewBackColorRow = System.Drawing.Color.Red;
            }

            if (currentTime > 60 && currentTime < 91 && tableTopicOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Green;
                listViewBackColorRow = System.Drawing.Color.LightGreen;
            }
            else if (currentTime > 90 && currentTime < 121 && tableTopicOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Yellow;
                listViewBackColorRow = System.Drawing.Color.Yellow;
            } 
            else if (currentTime > 120 && tableTopicOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Red;
                listViewBackColorRow = System.Drawing.Color.Red;
            }

            if (currentTime > 150 && currentTime < 181 && evaluationOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Green;
                listViewBackColorRow = System.Drawing.Color.LightGreen;
            }
            else if (currentTime > 181 && currentTime < 241 && evaluationOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Yellow;
                listViewBackColorRow = System.Drawing.Color.Yellow;
            } 
            else if (currentTime > 240 && evaluationOpt.Checked)
            {
                this.BackColor = System.Drawing.Color.Red;
                listViewBackColorRow = System.Drawing.Color.Red;
            }
        }

        private void stopTimerBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerLabel.Text = "The time was stopped";
            this.BackColor = default(Color);
            stopTimerBtn.Enabled = false;
            currentTime = 0; // reset the timer
            groupBox1.Enabled = true;

            // Add the speaker's name + time to the listBox
            string[] time = { formattedTime.ToString(), topicForListBox };
            speakerListView.Items.Add(speakerListBox.SelectedItem.ToString()).SubItems.AddRange(time);

            speakerListBox.Enabled = true;
            deleteSpeakerBtn.Enabled = true;

            // Change the color of the listView row depending on the time
            speakerListView.Items[speakerListView.Items.Count - 1].BackColor = listViewBackColorRow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopTimerBtn.Enabled = false; // Enable when the timer has been started
            startTimerBtn.Enabled = false; // Enable when a speaker has been selected
        }

        private void addSpeakerBtn_Click(object sender, EventArgs e)
        {
            // Add the speaker name entered in the speaker textbox
            if (speakerTxt.Text.Equals(""))
            {
                // don't add blank lines to the speaker text box
                MessageBox.Show("Enter a name for the speaker.");
            }
            else
            {
                speakerListBox.Items.Add(speakerTxt.Text);
                speakerTxt.Text = "";
            }
        }

        private void deleteSpeakerBtn_Click(object sender, EventArgs e)
        {
            speakerListBox.Items.Remove(speakerListBox.SelectedItem);
        }

        private void speakerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startTimerBtn.Enabled = true; // When a speaker has been selected from the listbox, enable the start timer button
        }

        private void speechOpt_CheckedChanged(object sender, EventArgs e)
        {
            timerLabel.Text = "00:00";
        }

        private void speakerTxtEnter(object sender, EventArgs e)
        {
            // Select the text in the speaker add text box, when clicked/entered
            TextBox textbox = sender as TextBox;

            if (textbox != null)
            {
                int lengthOfText = textbox.Text.Length;
                textbox.Select(0, lengthOfText);
            }
        }
    }
}
