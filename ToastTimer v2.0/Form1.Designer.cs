namespace ToastTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.evaluationOpt = new System.Windows.Forms.RadioButton();
            this.tableTopicOpt = new System.Windows.Forms.RadioButton();
            this.speechOpt = new System.Windows.Forms.RadioButton();
            this.timerLabel = new System.Windows.Forms.Label();
            this.startTimerBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopTimerBtn = new System.Windows.Forms.Button();
            this.speakerListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speakerTxt = new System.Windows.Forms.TextBox();
            this.addSpeakerBtn = new System.Windows.Forms.Button();
            this.deleteSpeakerBtn = new System.Windows.Forms.Button();
            this.speakerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.evaluationOpt);
            this.groupBox1.Controls.Add(this.tableTopicOpt);
            this.groupBox1.Controls.Add(this.speechOpt);
            this.groupBox1.Location = new System.Drawing.Point(335, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // evaluationOpt
            // 
            this.evaluationOpt.AutoSize = true;
            this.evaluationOpt.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationOpt.Location = new System.Drawing.Point(58, 177);
            this.evaluationOpt.Name = "evaluationOpt";
            this.evaluationOpt.Size = new System.Drawing.Size(158, 25);
            this.evaluationOpt.TabIndex = 3;
            this.evaluationOpt.TabStop = true;
            this.evaluationOpt.Text = "Evaluation";
            this.evaluationOpt.UseVisualStyleBackColor = true;
            this.evaluationOpt.CheckedChanged += new System.EventHandler(this.speechOpt_CheckedChanged);
            // 
            // tableTopicOpt
            // 
            this.tableTopicOpt.AutoSize = true;
            this.tableTopicOpt.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTopicOpt.Location = new System.Drawing.Point(58, 106);
            this.tableTopicOpt.Name = "tableTopicOpt";
            this.tableTopicOpt.Size = new System.Drawing.Size(171, 25);
            this.tableTopicOpt.TabIndex = 2;
            this.tableTopicOpt.TabStop = true;
            this.tableTopicOpt.Text = "Table Topic";
            this.tableTopicOpt.UseVisualStyleBackColor = true;
            this.tableTopicOpt.CheckedChanged += new System.EventHandler(this.speechOpt_CheckedChanged);
            // 
            // speechOpt
            // 
            this.speechOpt.AutoSize = true;
            this.speechOpt.Checked = true;
            this.speechOpt.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechOpt.Location = new System.Drawing.Point(58, 36);
            this.speechOpt.Name = "speechOpt";
            this.speechOpt.Size = new System.Drawing.Size(106, 25);
            this.speechOpt.TabIndex = 1;
            this.speechOpt.TabStop = true;
            this.speechOpt.Text = "Speech";
            this.speechOpt.UseVisualStyleBackColor = true;
            this.speechOpt.CheckedChanged += new System.EventHandler(this.speechOpt_CheckedChanged);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(190, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(559, 52);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimerBtn
            // 
            this.startTimerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimerBtn.Enabled = false;
            this.startTimerBtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerBtn.Location = new System.Drawing.Point(335, 331);
            this.startTimerBtn.Name = "startTimerBtn";
            this.startTimerBtn.Size = new System.Drawing.Size(101, 82);
            this.startTimerBtn.TabIndex = 0;
            this.startTimerBtn.Text = "Start";
            this.startTimerBtn.UseVisualStyleBackColor = true;
            this.startTimerBtn.Click += new System.EventHandler(this.startTimerBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopTimerBtn
            // 
            this.stopTimerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopTimerBtn.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTimerBtn.Location = new System.Drawing.Point(444, 331);
            this.stopTimerBtn.Name = "stopTimerBtn";
            this.stopTimerBtn.Size = new System.Drawing.Size(163, 82);
            this.stopTimerBtn.TabIndex = 4;
            this.stopTimerBtn.Text = "Stop/Reset";
            this.stopTimerBtn.UseVisualStyleBackColor = true;
            this.stopTimerBtn.Click += new System.EventHandler(this.stopTimerBtn_Click);
            // 
            // speakerListView
            // 
            this.speakerListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speakerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.timeHeader,
            this.topicHeader});
            this.speakerListView.FullRowSelect = true;
            this.speakerListView.GridLines = true;
            this.speakerListView.HideSelection = false;
            this.speakerListView.Location = new System.Drawing.Point(630, 93);
            this.speakerListView.MultiSelect = false;
            this.speakerListView.Name = "speakerListView";
            this.speakerListView.Size = new System.Drawing.Size(289, 218);
            this.speakerListView.TabIndex = 5;
            this.speakerListView.UseCompatibleStateImageBehavior = false;
            this.speakerListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 128;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 63;
            // 
            // topicHeader
            // 
            this.topicHeader.Text = "Topic";
            this.topicHeader.Width = 93;
            // 
            // speakerTxt
            // 
            this.speakerTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speakerTxt.Location = new System.Drawing.Point(47, 93);
            this.speakerTxt.Name = "speakerTxt";
            this.speakerTxt.Size = new System.Drawing.Size(109, 20);
            this.speakerTxt.TabIndex = 6;
            this.speakerTxt.Text = "Enter name";
            this.speakerTxt.Click += new System.EventHandler(this.speakerTxtEnter);
            this.speakerTxt.Enter += new System.EventHandler(this.speakerTxtEnter);
            // 
            // addSpeakerBtn
            // 
            this.addSpeakerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addSpeakerBtn.Location = new System.Drawing.Point(169, 93);
            this.addSpeakerBtn.Name = "addSpeakerBtn";
            this.addSpeakerBtn.Size = new System.Drawing.Size(109, 23);
            this.addSpeakerBtn.TabIndex = 7;
            this.addSpeakerBtn.Text = "Add Speaker";
            this.addSpeakerBtn.UseVisualStyleBackColor = true;
            this.addSpeakerBtn.Click += new System.EventHandler(this.addSpeakerBtn_Click);
            // 
            // deleteSpeakerBtn
            // 
            this.deleteSpeakerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteSpeakerBtn.Location = new System.Drawing.Point(169, 133);
            this.deleteSpeakerBtn.Name = "deleteSpeakerBtn";
            this.deleteSpeakerBtn.Size = new System.Drawing.Size(109, 23);
            this.deleteSpeakerBtn.TabIndex = 8;
            this.deleteSpeakerBtn.Text = "Delete Speaker";
            this.deleteSpeakerBtn.UseVisualStyleBackColor = true;
            this.deleteSpeakerBtn.Click += new System.EventHandler(this.deleteSpeakerBtn_Click);
            // 
            // speakerListBox
            // 
            this.speakerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speakerListBox.FormattingEnabled = true;
            this.speakerListBox.Location = new System.Drawing.Point(47, 214);
            this.speakerListBox.Name = "speakerListBox";
            this.speakerListBox.Size = new System.Drawing.Size(231, 199);
            this.speakerListBox.TabIndex = 9;
            this.speakerListBox.SelectedIndexChanged += new System.EventHandler(this.speakerListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Speaker:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speakerListBox);
            this.Controls.Add(this.deleteSpeakerBtn);
            this.Controls.Add(this.addSpeakerBtn);
            this.Controls.Add(this.speakerTxt);
            this.Controls.Add(this.speakerListView);
            this.Controls.Add(this.stopTimerBtn);
            this.Controls.Add(this.startTimerBtn);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Toast Timer v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton evaluationOpt;
        private System.Windows.Forms.RadioButton tableTopicOpt;
        private System.Windows.Forms.RadioButton speechOpt;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startTimerBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopTimerBtn;
        private System.Windows.Forms.ListView speakerListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.TextBox speakerTxt;
        private System.Windows.Forms.Button addSpeakerBtn;
        private System.Windows.Forms.Button deleteSpeakerBtn;
        private System.Windows.Forms.ListBox speakerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader topicHeader;
    }
}

