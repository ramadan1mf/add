using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Tvonlin
{
    public partial class Form1 : Form
    {
        static string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Tvonlin.accdb";
        OleDbConnection con = new OleDbConnection(constr);
        DataSet dt1 = new DataSet();
        string olstr = "select * from Tvlinks";
        OleDbDataAdapter dtr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            dtr = new OleDbDataAdapter(olstr, con);
            dtr.Fill(dt1, "Tvlinks");
            txtline.DataBindings.Add("text",dt1, "Tvlinks.Linktv"); 
            lsbline.DataBindings.Add("text", dt1, "Tvlinks.nametv");
            txtsearch.DataBindings.Add("text", dt1, "Tvlinks.search");
            lblno.DataBindings.Add("text", dt1, "Tvlinks.id");
            this.BindingContext[dt1, "Tvlinks"].Position = 0;
 
            
            ChangePosition();


        }
        private void ChangePosition()
        {
            int i1 = this.BindingContext[dt1, "Tvlinks"].Position + 1;
            int i2 = this.BindingContext[dt1, "Tvlinks"].Count;
            lblno.Text = "   رقم القناة   " + i1.ToString();

        }

        private void btnfrt_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt1, "Tvlinks"].Position = 0;
            ChangePosition();
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add(txtline.Text);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt1, "Tvlinks"].Position  +=1;
            ChangePosition();
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add(txtline.Text);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void btnaft_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt1, "Tvlinks"].Position -= 1;
            ChangePosition();
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add(txtline.Text);
            axVLCPlugin21.playlist.playItem(0);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt1, "Tvlinks"].Position = 
            this.BindingContext[dt1, "Tvlinks"].Count - 1;
            ChangePosition();
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.items.clear();
            axVLCPlugin21.playlist.add(txtline.Text);
            axVLCPlugin21.playlist.playItem(0);
        }
    }
}
