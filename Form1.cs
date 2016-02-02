using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCreator
{
    public partial class Form1 : Form
    {
        private List<Line> lines;

        private Line selectedLine;
        private Response selectedResp;
        private Line selectedLink;
         
        public Form1()
        {
            InitializeComponent();
            lines = new List<Line>();
            box_NPC.DisplayMember = "Name";
            box_Resp.DisplayMember = "Name";
            box_Links.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void box_Response_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddNPC_Click(object sender, EventArgs e)
        {
            lines.Add(new Line());
            box_NPC.SelectedItem = null;
            text_NPC.Text = "";
            RefreshNPCList();
            RefreshRespList();
        }

        private void btn_SaveNPC_Click(object sender, EventArgs e)
        {
            selectedLine.SetText(text_NPC.Text);
            text_NPC.Text = "";
            SelectLine(false);
            RefreshNPCList();
            RefreshRespList();
        }

        private void box_NPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_NPC.SelectedItem != null)
            { 
                SelectLine(true);
                text_NPC.Text = selectedLine.Text;
            }
            else
            {
                SelectLine(false);
                text_NPC.Text = "";
            }
            RefreshRespList();
        }

        private void SelectLine(bool on)
        {
            if (on)
            {
                selectedLine = box_NPC.SelectedItem as Line;
            }
            else
            {
                selectedLine = null;
            }
            SelectResp(false);
            text_NPC.Enabled = on;
            btn_SaveNPC.Enabled = on;
            btn_RemNPC.Enabled = on;
            box_Resp.Enabled = on;
            btn_AddResp.Enabled = on;
        }

        private void SelectResp(bool on)
        {
            if (on)
            {
                selectedResp = box_Resp.SelectedItem as Response;      
            }
            else
            {
                selectedResp = null;
            }
            SelectLink(false);
            RefreshLinksList();
            btn_SaveResp.Enabled = on;
            btn_RemResp.Enabled = on;
            text_Resp.Enabled = on;
            box_Links.Enabled = on;
        }

        private void SelectLink(bool on)
        {
            if (on)
            {
                selectedLink = box_Links.SelectedItem as Line;
            }
            else
            {
                selectedLink = null;
            }
            btn_LinkResp.Enabled = on;
        }

        public void RefreshNPCList()
        {
            box_NPC.Items.Clear();
            foreach (Line line in lines)
            {
                line.IsComplete();
                box_NPC.Items.Add(line);
            }
        }

        public void RefreshRespList()
        {
            if (selectedLine != null)
            {
                box_Resp.Items.Clear();
                foreach (Response resp in selectedLine.Responses)
                {
                    resp.isLinked();
                    box_Resp.Items.Add(resp);
                }
            }
            else
            {
                box_Resp.Items.Clear();
            }
        }

        public void RefreshLinksList()
        {
            if (selectedResp != null)
            {
                box_Links.Items.Clear();
                foreach (Line line in lines)
                {
                    if (!line.Equals(selectedLine))
                    {
                        box_Links.Items.Add(line);
                    }
                }
            }
            else
            {
                box_Links.Items.Clear();
            }
        }

        private void btn_RemNPC_Click(object sender, EventArgs e)
        {
            selectedLine.ToDelete = true;
            lines.Remove(selectedLine);
            SelectResp(false);
            selectedLine = null;
            box_NPC.SelectedItem = null;
            RefreshNPCList();
        }

        private void btn_AddResp_Click(object sender, EventArgs e)
        {
            selectedLine.Responses.Add(new Response(selectedLine));
            SelectResp(false);
            RefreshRespList();
        }

        private void box_Resp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_Resp.SelectedItem != null)
            {
                SelectResp(true);
                text_Resp.Text = selectedResp.Text;
            }
            else
            {
                SelectResp(false);
                text_Resp.Text = "";
            }
        }

        private void btn_SaveResp_Click(object sender, EventArgs e)
        {
            selectedResp.SetText(text_Resp.Text);
            text_Resp.Text = "";
            SelectResp(false);
            RefreshRespList();
        }

        private void btn_RemResp_Click(object sender, EventArgs e)
        {
            selectedResp.ToDelete = true;
            selectedLine.Responses.Remove(selectedResp);
            SelectResp(false);
            RefreshRespList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_LinkResp_Click(object sender, EventArgs e)
        {

        }
    }
}
