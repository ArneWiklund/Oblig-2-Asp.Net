using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using System.Web;
using MySql.Data;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordreDataSet2.ordre' table. You can move, or remove it, as needed.
            this.ordreTableAdapter.Fill(this.ordreDataSet2.ordre);

          // Gjør slik at rommene blir generert i TabControll 

            TabPage tab;
                int x;
                for (x = 0; x < 3; x++)
                {
                    // Legger rommene inn i hver sin etasje
                    tab = tabControl1.TabPages[x];
                    tabControl1.TabPages[x].Text = "Etasje" + x;
                    // Her genereres 3x4 rom
                    int i, j;
                    for (i = 1; i <= 3; i++)
                    {
                        for (j = 1; j <= 4; j++)
                        {
                            var a = new Panel();
                            a.Location = new Point(i * 125, j * 75);
                            a.Width = 100;
                            a.Height = 50;
                            a.Name = "Rom " + (((i * 4) - 3) + (j - 1));
                            a.BackColor = Color.Yellow;
                            a.AllowDrop = true;
                            // Setter opp hendelseshåndterere for DragOver og DragDrop
                            a.DragDrop += new DragEventHandler(this.panel1_DragDrop);
                            a.DragOver += new DragEventHandler(this.panel1_DragOver);
                            a.Visible = true;
                            // Legger til en label inne i panelet
                            var l = new Label();
                            l.Location = new Point(5, 5);
                            l.Width = 100;
                            l.Text = a.Name;
                            a.Controls.Add(l);
                            // Legger panelet til form
                            tab.Controls.Add(a);
                        }
                   }
             }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.DoDragDrop(dataGridView1.DataSource, DragDropEffects.All);
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                dataGridView1.DoDragDrop(dataGridView1.DataSource, DragDropEffects.Move);
        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            // item vil inneholde navnet som dras fra nedtrekkslisten
            var item = e.Data.GetData(typeof(string));
            //Typekonverter for å få tak i egenskapene til Control
            var c = (Control)sender;
            if (c != null)
            {
                c.Controls[0].Text = item.ToString();
                c.BackColor = Color.Red;
                
            }
        }

        private void panel1_DragOver(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;
    }
}


      