using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    /*
     - listview
        - dock:bottom

     */

    public partial class frmTest : Form
    {
        List<Profile> aryProfile;

        public frmTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aryProfile = new List<Profile>();

            listView1.Clear();
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("#", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("성명", 300, HorizontalAlignment.Center);
            listView1.Columns.Add("키", -2, HorizontalAlignment.Center);

            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.FullRowSelect = true;

            this.AddListView(new Profile() { Name = "정우성", Height = 186 });
            this.AddListView(new Profile() { Name = "김태희", Height = 158 });
            this.AddListView(new Profile() { Name = "고현정", Height = 172 });
            this.AddListView(new Profile() { Name = "이문세", Height = 178 });
            this.AddListView(new Profile() { Name = "하하", Height = 171 });

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.AddListView(new Profile() { Name = textBox1.Text, Height = Convert.ToInt32(textBox2.Text ?? "0") });
        }

        private void AddListView(Profile _item)
        {
            aryProfile.Add(_item);

            int index = aryProfile.Count - 1;

            Profile profile = aryProfile[index];
            ListViewItem item = new ListViewItem(index.ToString()); // 첫번째 기본열
            item.SubItems.Add(profile.Name);
            item.SubItems.Add(profile.Height.ToString());
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listView1.FocusedItem;

            label4.Text = item.SubItems[0].Text;
            textBox1.Text = item.SubItems[1].Text;
            textBox2.Text = item.SubItems[2].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;

            if (indexes.Count > 0)
            {
                int idx = indexes[0];

                Profile item = aryProfile[idx];
                item.Name = textBox1.Text;
                item.Height = Convert.ToInt32(textBox2.Text ?? "0");

                aryProfile[idx] = item;

                listView1.Items[idx].SubItems[0].Text = label4.Text;
                listView1.Items[idx].SubItems[1].Text = item.Name;
                listView1.Items[idx].SubItems[2].Text = item.Height.ToString();

                label4.Text = "-";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("수정할 데이터를 선택하세요.", "경고");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;

            if (indexes.Count > 0)
            {
                int idx = indexes[0];

                aryProfile.RemoveAt(idx);
                listView1.Items.RemoveAt(idx);

                label4.Text = "-";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("삭제할 데이터를 선택하세요.", "경고");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }

    /* partial class의 경우 일반 class는 제일 아래에 선언한다. */
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
}
