using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Inventory
{
    public partial class PrintVoucher : Form
    {
        public PrintVoucher()
        {
            InitializeComponent();
        }
        GetDataBase obj = new GetDataBase();
        private void PrintVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtrepeatreceipt.Text == "")
                {

                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");

                    System.Data.DataTable dtgetsales = new System.Data.DataTable();
                    if (txtForm.Text == "update")
                    {
                        dtgetsales = obj.getdatabase("Select * from preupdate order by productid");
                        if (dtgetsales.Rows.Count > 0)
                        {
                            dtgetsales.WriteXmlSchema("update.xlm");
                            MessageBox.Show("An update.xlm schema is created");

                        }
                       
                    }
                    else
                    {
                        dtgetsales = obj.getdatabase("Select * from preentry order by productid");
                        if (dtgetsales.Rows.Count > 0)
                        {
                           
                        }
                        // insert Copyright symbol
                       
                    }
                }
                else
                {
                    DataTable dtidentity = new DataTable();
                    dtidentity = obj.getdatabase("Select * from identity");
                    double temp = 0;
                    System.Data.DataTable dtgetsaleslog = new System.Data.DataTable();
                    dtgetsaleslog = obj.getdatabase("select * from product where srv= '" + txtrepeatreceipt.Text + "' order by productname");
                    if (dtgetsaleslog.Rows.Count > 0)
                    {
                    }
                      
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
