namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dodawaniedanych (string tytul, string rezyser, string data,string aktor )
        {
            ListViewItem item = new ListViewItem(new string[] { tytul, rezyser, data, aktor });
            listView1.Items.Add(item);
        }
        private void dodawaniedanych (string[] dane)
        {
            ListViewItem item = new ListViewItem(dane);
            listView1.Items.Add(item);

        }

        private void usuwaniedanych ()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);

            }
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for (int k = 0; k < item.SubItems.Count; k++)
                    linie[i] += item.SubItems[k].Text + "+";
                i++;

            }
            File.WriteAllLines("filmy.txt", linie);
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            dodawaniedanych(txt1.Text, txt2.Text, dt1.Text, txt4.Text);
        }

        private void usuñWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuwaniedanych();
        }
    }
}