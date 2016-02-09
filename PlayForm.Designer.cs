namespace DialogueCreator
{
    partial class PlayForm
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
            this.box_line = new System.Windows.Forms.TextBox();
            this.box_answer = new System.Windows.Forms.ComboBox();
            this.btn_answer = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_line
            // 
            this.box_line.Enabled = false;
            this.box_line.Location = new System.Drawing.Point(13, 13);
            this.box_line.Multiline = true;
            this.box_line.Name = "box_line";
            this.box_line.Size = new System.Drawing.Size(575, 139);
            this.box_line.TabIndex = 0;
            // 
            // box_answer
            // 
            this.box_answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_answer.FormattingEnabled = true;
            this.box_answer.Location = new System.Drawing.Point(13, 159);
            this.box_answer.MaxDropDownItems = 20;
            this.box_answer.Name = "box_answer";
            this.box_answer.Size = new System.Drawing.Size(575, 21);
            this.box_answer.TabIndex = 1;
            this.box_answer.SelectedIndexChanged += new System.EventHandler(this.box_answer_SelectedIndexChanged);
            // 
            // btn_answer
            // 
            this.btn_answer.Enabled = false;
            this.btn_answer.Location = new System.Drawing.Point(13, 246);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(141, 37);
            this.btn_answer.TabIndex = 2;
            this.btn_answer.Text = "Respond";
            this.btn_answer.UseVisualStyleBackColor = true;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(447, 246);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(141, 37);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_end
            // 
            this.btn_end.Enabled = false;
            this.btn_end.Location = new System.Drawing.Point(233, 246);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(141, 37);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "End Dialogue";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 307);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_answer);
            this.Controls.Add(this.box_answer);
            this.Controls.Add(this.box_line);
            this.Name = "PlayForm";
            this.Text = "Dialogue";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_line;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.ComboBox box_answer;
    }
}