namespace DialogueCreator
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
            this.box_Resp = new System.Windows.Forms.ListBox();
            this.btn_AddResp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Resp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_NPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddNPC = new System.Windows.Forms.Button();
            this.box_NPC = new System.Windows.Forms.ListBox();
            this.btn_SaveNPC = new System.Windows.Forms.Button();
            this.btn_SaveResp = new System.Windows.Forms.Button();
            this.box_Links = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_LinkResp = new System.Windows.Forms.Button();
            this.btn_RemNPC = new System.Windows.Forms.Button();
            this.btn_RemResp = new System.Windows.Forms.Button();
            this.box_Linked = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_Resp
            // 
            this.box_Resp.FormattingEnabled = true;
            this.box_Resp.Location = new System.Drawing.Point(12, 286);
            this.box_Resp.Name = "box_Resp";
            this.box_Resp.Size = new System.Drawing.Size(120, 173);
            this.box_Resp.TabIndex = 2;
            this.box_Resp.SelectedIndexChanged += new System.EventHandler(this.box_Resp_SelectedIndexChanged);
            // 
            // btn_AddResp
            // 
            this.btn_AddResp.Enabled = false;
            this.btn_AddResp.Location = new System.Drawing.Point(148, 404);
            this.btn_AddResp.Name = "btn_AddResp";
            this.btn_AddResp.Size = new System.Drawing.Size(107, 27);
            this.btn_AddResp.TabIndex = 3;
            this.btn_AddResp.Text = "New Response";
            this.btn_AddResp.UseVisualStyleBackColor = true;
            this.btn_AddResp.Click += new System.EventHandler(this.btn_AddResp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Responses:";
            // 
            // text_Resp
            // 
            this.text_Resp.Enabled = false;
            this.text_Resp.Location = new System.Drawing.Point(148, 286);
            this.text_Resp.Multiline = true;
            this.text_Resp.Name = "text_Resp";
            this.text_Resp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Resp.Size = new System.Drawing.Size(487, 102);
            this.text_Resp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Response:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NPC line:";
            // 
            // text_NPC
            // 
            this.text_NPC.Enabled = false;
            this.text_NPC.Location = new System.Drawing.Point(148, 40);
            this.text_NPC.Multiline = true;
            this.text_NPC.Name = "text_NPC";
            this.text_NPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_NPC.Size = new System.Drawing.Size(487, 102);
            this.text_NPC.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NPC lines:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_AddNPC
            // 
            this.btn_AddNPC.Location = new System.Drawing.Point(148, 158);
            this.btn_AddNPC.Name = "btn_AddNPC";
            this.btn_AddNPC.Size = new System.Drawing.Size(107, 27);
            this.btn_AddNPC.TabIndex = 8;
            this.btn_AddNPC.Text = "New Line";
            this.btn_AddNPC.UseVisualStyleBackColor = true;
            this.btn_AddNPC.Click += new System.EventHandler(this.btn_AddNPC_Click);
            // 
            // box_NPC
            // 
            this.box_NPC.FormattingEnabled = true;
            this.box_NPC.Location = new System.Drawing.Point(12, 40);
            this.box_NPC.Name = "box_NPC";
            this.box_NPC.Size = new System.Drawing.Size(120, 173);
            this.box_NPC.TabIndex = 7;
            this.box_NPC.SelectedIndexChanged += new System.EventHandler(this.box_NPC_SelectedIndexChanged);
            // 
            // btn_SaveNPC
            // 
            this.btn_SaveNPC.Enabled = false;
            this.btn_SaveNPC.Location = new System.Drawing.Point(261, 158);
            this.btn_SaveNPC.Name = "btn_SaveNPC";
            this.btn_SaveNPC.Size = new System.Drawing.Size(107, 27);
            this.btn_SaveNPC.TabIndex = 12;
            this.btn_SaveNPC.Text = "Save Line";
            this.btn_SaveNPC.UseVisualStyleBackColor = true;
            this.btn_SaveNPC.Click += new System.EventHandler(this.btn_SaveNPC_Click);
            // 
            // btn_SaveResp
            // 
            this.btn_SaveResp.Enabled = false;
            this.btn_SaveResp.Location = new System.Drawing.Point(261, 404);
            this.btn_SaveResp.Name = "btn_SaveResp";
            this.btn_SaveResp.Size = new System.Drawing.Size(107, 27);
            this.btn_SaveResp.TabIndex = 13;
            this.btn_SaveResp.Text = "Save Response";
            this.btn_SaveResp.UseVisualStyleBackColor = true;
            this.btn_SaveResp.Click += new System.EventHandler(this.btn_SaveResp_Click);
            // 
            // box_Links
            // 
            this.box_Links.Enabled = false;
            this.box_Links.FormattingEnabled = true;
            this.box_Links.Location = new System.Drawing.Point(652, 286);
            this.box_Links.Name = "box_Links";
            this.box_Links.Size = new System.Drawing.Size(120, 173);
            this.box_Links.TabIndex = 14;
            this.box_Links.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lines to link:";
            // 
            // btn_LinkResp
            // 
            this.btn_LinkResp.Location = new System.Drawing.Point(528, 404);
            this.btn_LinkResp.Name = "btn_LinkResp";
            this.btn_LinkResp.Size = new System.Drawing.Size(107, 27);
            this.btn_LinkResp.TabIndex = 16;
            this.btn_LinkResp.Text = "Link Response";
            this.btn_LinkResp.UseVisualStyleBackColor = true;
            this.btn_LinkResp.Click += new System.EventHandler(this.btn_LinkResp_Click);
            // 
            // btn_RemNPC
            // 
            this.btn_RemNPC.Enabled = false;
            this.btn_RemNPC.Location = new System.Drawing.Point(374, 158);
            this.btn_RemNPC.Name = "btn_RemNPC";
            this.btn_RemNPC.Size = new System.Drawing.Size(107, 27);
            this.btn_RemNPC.TabIndex = 17;
            this.btn_RemNPC.Text = "Remove Line";
            this.btn_RemNPC.UseVisualStyleBackColor = true;
            this.btn_RemNPC.Click += new System.EventHandler(this.btn_RemNPC_Click);
            // 
            // btn_RemResp
            // 
            this.btn_RemResp.Enabled = false;
            this.btn_RemResp.Location = new System.Drawing.Point(374, 404);
            this.btn_RemResp.Name = "btn_RemResp";
            this.btn_RemResp.Size = new System.Drawing.Size(107, 27);
            this.btn_RemResp.TabIndex = 18;
            this.btn_RemResp.Text = "Remove Response";
            this.btn_RemResp.UseVisualStyleBackColor = true;
            this.btn_RemResp.Click += new System.EventHandler(this.btn_RemResp_Click);
            // 
            // box_Linked
            // 
            this.box_Linked.Enabled = false;
            this.box_Linked.Location = new System.Drawing.Point(652, 494);
            this.box_Linked.Name = "box_Linked";
            this.box_Linked.Size = new System.Drawing.Size(120, 20);
            this.box_Linked.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Linked to:";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(12, 540);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(302, 15);
            this.lbl_Error.TabIndex = 21;
            this.lbl_Error.Text = "Warning! There are some unlinked responses!";
            this.lbl_Error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_Linked);
            this.Controls.Add(this.btn_RemResp);
            this.Controls.Add(this.btn_RemNPC);
            this.Controls.Add(this.btn_LinkResp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_Links);
            this.Controls.Add(this.btn_SaveResp);
            this.Controls.Add(this.btn_SaveNPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_NPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddNPC);
            this.Controls.Add(this.box_NPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Resp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddResp);
            this.Controls.Add(this.box_Resp);
            this.Name = "Form1";
            this.Text = "Dialogue Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox box_Resp;
        private System.Windows.Forms.Button btn_AddResp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Resp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_NPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddNPC;
        private System.Windows.Forms.ListBox box_NPC;
        private System.Windows.Forms.Button btn_SaveNPC;
        private System.Windows.Forms.Button btn_SaveResp;
        private System.Windows.Forms.ListBox box_Links;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_LinkResp;
        private System.Windows.Forms.Button btn_RemNPC;
        private System.Windows.Forms.Button btn_RemResp;
        private System.Windows.Forms.TextBox box_Linked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Error;
    }
}

