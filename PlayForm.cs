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
    public partial class PlayForm : Form
    {
        private List<Line> lines;
         
        public PlayForm()
        {
            InitializeComponent();
            box_answer.DisplayMember = "Text";
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void SetLine(Line line)
        {
            box_answer.SelectedItem = null;
            box_line.Text = line.Text;
            box_answer.Items.Clear();
            btn_answer.Enabled = false;
            if (line.Responses.Count > 0)
            {
                foreach (Response resp in line.Responses)
                {
                    box_answer.Items.Add(resp);
                }
            }
            else
            {
                btn_end.Enabled = true;
            }
        }

        private void box_answer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_answer.Items.Count > 0 && box_answer.SelectedItem != null)
            {
                btn_answer.Enabled = true;
            }
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            var response = box_answer.SelectedItem as Response;
            if (response != null) SetLine(response.Next);
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            btn_answer.Enabled = false;
            btn_end.Enabled = false;
            box_answer.SelectedItem = null;
            box_line.Text = "";
            this.Hide();
        }

        public void StartForm(List<Line> list)
        {
            lines = list;
            if (lines.Count > 0)
            {
                SetLine(lines.First());
                this.Show();
            }
            else
                CloseForm();
        }
    }
}
