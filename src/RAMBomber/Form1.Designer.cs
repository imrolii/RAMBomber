
namespace RAMBomber
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
            this.label1 = new System.Windows.Forms.Label();
            this.WebButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NotepadButton = new System.Windows.Forms.Button();
            this.CMDButton = new System.Windows.Forms.Button();
            this.GUIButton = new System.Windows.Forms.Button();
            this.StopNotepad = new System.Windows.Forms.Button();
            this.StopCMD = new System.Windows.Forms.Button();
            this.StopGui = new System.Windows.Forms.Button();
            this.WaitTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StopAllButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAM Bomber GUI";
            // 
            // WebButton
            // 
            this.WebButton.Location = new System.Drawing.Point(374, 9);
            this.WebButton.Name = "WebButton";
            this.WebButton.Size = new System.Drawing.Size(75, 23);
            this.WebButton.TabIndex = 1;
            this.WebButton.Text = "Website";
            this.WebButton.UseVisualStyleBackColor = true;
            this.WebButton.Click += new System.EventHandler(this.WebButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RAM Bomber allows you to test how your computer handles multiple programs being o" +
    "pened.";
            // 
            // NotepadButton
            // 
            this.NotepadButton.Location = new System.Drawing.Point(30, 109);
            this.NotepadButton.Name = "NotepadButton";
            this.NotepadButton.Size = new System.Drawing.Size(114, 29);
            this.NotepadButton.TabIndex = 3;
            this.NotepadButton.Text = "Notepad Bomb";
            this.toolTip.SetToolTip(this.NotepadButton, "Starts infinite windows of Notepad.");
            this.NotepadButton.UseVisualStyleBackColor = true;
            this.NotepadButton.Click += new System.EventHandler(this.NotepadButton_Click);
            // 
            // CMDButton
            // 
            this.CMDButton.Location = new System.Drawing.Point(175, 109);
            this.CMDButton.Name = "CMDButton";
            this.CMDButton.Size = new System.Drawing.Size(114, 29);
            this.CMDButton.TabIndex = 4;
            this.CMDButton.Text = "CMD Bomb";
            this.toolTip.SetToolTip(this.CMDButton, "Starts infinite windows of Command Prompt");
            this.CMDButton.UseVisualStyleBackColor = true;
            this.CMDButton.Click += new System.EventHandler(this.CMDButton_Click);
            // 
            // GUIButton
            // 
            this.GUIButton.Location = new System.Drawing.Point(314, 109);
            this.GUIButton.Name = "GUIButton";
            this.GUIButton.Size = new System.Drawing.Size(114, 29);
            this.GUIButton.TabIndex = 5;
            this.GUIButton.Text = "GUI Bomb";
            this.toolTip.SetToolTip(this.GUIButton, "Continuously starts instances of the RAM Bomber GUI.");
            this.GUIButton.UseVisualStyleBackColor = true;
            this.GUIButton.Click += new System.EventHandler(this.GUIButton_Click);
            // 
            // StopNotepad
            // 
            this.StopNotepad.Location = new System.Drawing.Point(30, 164);
            this.StopNotepad.Name = "StopNotepad";
            this.StopNotepad.Size = new System.Drawing.Size(114, 29);
            this.StopNotepad.TabIndex = 6;
            this.StopNotepad.Text = "Stop Notepad Bomb";
            this.toolTip.SetToolTip(this.StopNotepad, "Stops the notepad bomb from running and closes all notepad windows.");
            this.StopNotepad.UseVisualStyleBackColor = true;
            this.StopNotepad.Click += new System.EventHandler(this.StopNotepad_Click);
            // 
            // StopCMD
            // 
            this.StopCMD.Location = new System.Drawing.Point(175, 164);
            this.StopCMD.Name = "StopCMD";
            this.StopCMD.Size = new System.Drawing.Size(114, 29);
            this.StopCMD.TabIndex = 7;
            this.StopCMD.Text = "Stop CMD Bomb";
            this.toolTip.SetToolTip(this.StopCMD, "Stops command prompt bomb from running and closes all command prompt windows.");
            this.StopCMD.UseVisualStyleBackColor = true;
            this.StopCMD.Click += new System.EventHandler(this.StopCMD_Click);
            // 
            // StopGui
            // 
            this.StopGui.Location = new System.Drawing.Point(314, 164);
            this.StopGui.Name = "StopGui";
            this.StopGui.Size = new System.Drawing.Size(114, 29);
            this.StopGui.TabIndex = 8;
            this.StopGui.Text = "Stop GUI Bomb";
            this.toolTip.SetToolTip(this.StopGui, "Stops GUI Bomb from running and closes all GUI windows. You may need to relaunch " +
        "the program afterwards.");
            this.StopGui.UseVisualStyleBackColor = true;
            this.StopGui.Click += new System.EventHandler(this.StopGui_Click);
            // 
            // WaitTime
            // 
            this.WaitTime.Location = new System.Drawing.Point(10, 283);
            this.WaitTime.MaxLength = 1000;
            this.WaitTime.Name = "WaitTime";
            this.WaitTime.Size = new System.Drawing.Size(65, 20);
            this.WaitTime.TabIndex = 9;
            this.WaitTime.Text = "10";
            this.WaitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.WaitTime, "How long the program waits before starting another window.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time to wait before next window (ms):";
            // 
            // StopAllButton
            // 
            this.StopAllButton.Location = new System.Drawing.Point(353, 279);
            this.StopAllButton.Name = "StopAllButton";
            this.StopAllButton.Size = new System.Drawing.Size(96, 26);
            this.StopAllButton.TabIndex = 11;
            this.StopAllButton.Text = "Stop ALL Bombs";
            this.toolTip.SetToolTip(this.StopAllButton, "Stops all bombs from executing and closes associated windows.");
            this.StopAllButton.UseVisualStyleBackColor = true;
            this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note: This tool may render your computer unusable during the time you execute the" +
    " bomb. If \r\nthis occurs and you are unable to click the stop button, hard reset " +
    "your computer with the power \r\nbutton.";
            // 
            // WaitTimer
            // 
            this.WaitTimer.Tick += new System.EventHandler(this.WaitTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopAllButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WaitTime);
            this.Controls.Add(this.StopGui);
            this.Controls.Add(this.StopCMD);
            this.Controls.Add(this.StopNotepad);
            this.Controls.Add(this.GUIButton);
            this.Controls.Add(this.CMDButton);
            this.Controls.Add(this.NotepadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RAM Bomber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WebButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NotepadButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button CMDButton;
        private System.Windows.Forms.Button GUIButton;
        private System.Windows.Forms.Button StopNotepad;
        private System.Windows.Forms.Button StopCMD;
        private System.Windows.Forms.Button StopGui;
        private System.Windows.Forms.TextBox WaitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopAllButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer WaitTimer;
    }
}

