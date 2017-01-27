using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace assetmanagement
{
    public partial class Form1 : Form
    {

     //   public String get_place_api = "http://readyknowhow.com/yo/fang/api/getplace.php";
     //   public String get_asset_api = "http://readyknowhow.com/yo/fang/api/getasset.php";
        public String get_place_api = "http://readyknowhow.com/yo/fang/api/getplace.php";
        public String get_asset_api = "http://readyknowhow.com/yo/fang/api/getasset.php";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    DataSet1TableAdapters.tb_trackingTableAdapter tb_tracking = new DataSet1TableAdapters.tb_trackingTableAdapter();
                    DataTable dt = tb_tracking.GetData();
                    Console.WriteLine(dt.Rows.Count);
                    StreamWriter writer = new StreamWriter(myStream);
                    foreach (DataRow dr in dt.Rows)
                    {
                        String str = dr["asset_id"] + "," + dr["place_id"] + "," + dr["status"];
                        writer.WriteLine(str);
                    }
                    

                   

                    writer.Dispose();

                    writer.Close();
                    myStream.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlace();
            LoadAsset();
        }
        
protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
    if (keyData == Keys.F1)
    {
       // MessageBox.Show("You pressed the F1 key");
        return true;    // indicate that you handled this keystroke
    }

    // Call the base class
    return base.ProcessCmdKey(ref msg, keyData);
}

        public void LoadPlace()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString(this.get_place_api);

                    Dictionary<string, string>[] p = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(json);
                    Dictionary<string, string> item = new Dictionary<string, string>();
                    DataSet1TableAdapters.tb_placeTableAdapter tb_place = new DataSet1TableAdapters.tb_placeTableAdapter();
                    tb_place.TruncateData();
                    foreach (Dictionary<string, string> pp in p)
                    {
                        System.Console.WriteLine(Convert.ToInt32(pp["id"]));
                        item.Add(pp["id"], pp["place_name"]);
                        try
                        {
                            int insert_id = (int)tb_place.InsertQuery(Convert.ToInt32(pp["id"]), pp["place_name"]);
                            Console.WriteLine("ID:" + insert_id);
                        }
                        catch (InvalidDataException de)
                        {
                            Console.WriteLine(de.Message);
                        }

                    }

                    dlPlace.DataSource = new BindingSource(item, null);
                    dlPlace.DisplayMember = "Value";
                    dlPlace.ValueMember = "Key";
                    DataTable dt = tb_place.GetData();

                    Console.WriteLine("Data Count:" + tb_place.CountAll());


                    // Now parse with JSON.Net
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LoadAsset()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString(this.get_asset_api);

                    Dictionary<string, string>[] p = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(json);
                    Dictionary<string, string> item = new Dictionary<string, string>();
                    DataSet1TableAdapters.tb_assetTableAdapter tb_asset = new DataSet1TableAdapters.tb_assetTableAdapter();
                   
                    tb_asset.TruncateData();
                    foreach (Dictionary<string, string> pp in p)
                    {
                     //   System.Console.WriteLine("ID:" + Convert.ToInt32(pp["id"]));
                    //   Console.WriteLine("PLACE ID:" + pp["place_id"]);
                   //     Console.WriteLine("CODE:" + pp["code"]);
                   //    Console.WriteLine("RFID:" + pp["rfid_code"]);
                      //item.Add(pp["id"], pp["place_name"]);
                        try
                        {

                            int insert_id = (int)tb_asset.InsertQuery(Convert.ToInt32(pp["id"]),pp["rfid_code"],pp["code"],pp["asset_name"],Convert.ToInt32(pp["place_id"]),0,0,0);
                          //  Console.WriteLine("ID:" + insert_id);
                          
                        }
                        catch (InvalidDataException de)
                        {
                            Console.WriteLine(de.Message);
                        }

                    }
                   // Console.WriteLine("Asset Count : " + tb_asset.CountAll());
                    string value = ((KeyValuePair<string, string>)dlPlace.SelectedItem).Key;
                    //  txtCode.Text = value;
                    LoadDataToGrid(value);

                    // Now parse with JSON.Net
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dlPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)dlPlace.SelectedItem).Key;
          //  txtCode.Text = value;
            LoadDataToGrid(value);
        }

        public void LoadDataToGrid(String place_id)
        {
            txtCode.Focus();
            try
            {
                DataSet1TableAdapters.tb_assetTableAdapter tb_asset = new DataSet1TableAdapters.tb_assetTableAdapter();
                DataTable dt = tb_asset.GetDataByPlaceId(Convert.ToInt32(place_id));
                dgAsset.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    String status = dr["status"].ToString();
                    String str_status = "";
                    if (status == "0")
                    {
                        str_status = "ไม่พบ";
                    }
                    if (status == "1")
                    {
                        str_status = "พบ";
                    }
                    if (status == "2")
                    {
                        DataSet1TableAdapters.tb_placeTableAdapter tb_place = new DataSet1TableAdapters.tb_placeTableAdapter();
                        DataTable dt_place = tb_place.GetDataById(Int32.Parse(dr["place_id"].ToString()));
                        DataRow dr_place = dt_place.Rows[0];
                        str_status = "พบที่ [ ห้อง : "  + dr_place["place_name"] + " ]";
                    }
                    DataGridViewRow dvr = new DataGridViewRow();

                    dgAsset.Rows.Add( dr["rfid_code"].ToString(), dr["asset_code"].ToString(), dr["asset_name"].ToString(), str_status);
                   
                }
                foreach (DataGridViewRow row in dgAsset.Rows)
                    if (row.Cells[4].Value.ToString() != "พบ" && row.Cells[4].Value.ToString() != "ไม่พบ")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("You pressed the F1 key");
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ScanData();
            }
        }

        public void ScanData()
        {
            int result;
            if (Int32.TryParse(txtCode.Text,out result))
            {
                Int32 code = Int32.Parse(txtCode.Text);
                DataSet1TableAdapters.tb_assetTableAdapter tb_asset = new DataSet1TableAdapters.tb_assetTableAdapter();
                DataTable dt = tb_asset.GetDataByRfidCode(code.ToString());

              //  MessageBox.Show(dt.Rows.Count.ToString());


                DataSet1TableAdapters.tb_trackingTableAdapter tb_tracking = new DataSet1TableAdapters.tb_trackingTableAdapter();
                Int32 place_id = Int32.Parse(dlPlace.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    Int32 asset_id = Int32.Parse(dr["id"].ToString());
                    
                    String check_date = DateTime.Now.ToString("yyyy-MM-dd"); ;
                    
                    if (dr["place_id"].ToString() != dlPlace.SelectedValue.ToString())
                    {
                       // Console.WriteLine("Wrong Place");
                        tb_tracking.InsertQuery(asset_id, place_id, check_date, 2);
                        tb_asset.UpdatePlace(2, 1, place_id, Convert.ToInt32(dr["id"].ToString()), Convert.ToInt32(dr["id"].ToString()));

                        DataSet1TableAdapters.tb_placeTableAdapter tb_place = new DataSet1TableAdapters.tb_placeTableAdapter();
                        DataTable dt_place = tb_place.GetDataById(Int32.Parse(dr["place_id"].ToString()));
                        DataRow dr_place = dt_place.Rows[0];

                        lbStatus.Text = "ผิดที่ [ในระบบ : " + dr_place["place_name"] + " ]";
                        lbStatus.BackColor = Color.Red;
                    }
                    else
                    {
                        tb_tracking.InsertQuery(asset_id, place_id, check_date, 1);
                        tb_asset.UpdatePlace(1, 1, place_id, Convert.ToInt32(dr["id"].ToString()), Convert.ToInt32(dr["id"].ToString()));
                        lbStatus.Text = "พบ";
                        lbStatus.BackColor = this.BackColor;
                    }
                }
                else
                {
                    lbStatus.Text = "ไม่พบ";
                    lbStatus.BackColor = Color.Red;
                }
                txtCode.Text = "";
                txtCode.Focus();
                LoadDataToGrid(place_id.ToString());
                ShowHighlight(code.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScanData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Focus();
            dgAsset.ClearSelection();
        }

        private void dgAsset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Focus();
            dgAsset.ClearSelection();
        }

        private void dgAsset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Focus();
            dgAsset.ClearSelection();
        }

        public void ShowHighlight(String strSearch)
        {
            string searchingFor = strSearch;
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgAsset.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == searchingFor)
                        rowIndex = row.Index;
                }
            }

            if (rowIndex >= 0){
                dgAsset.Rows[rowIndex].Selected = true;

            } else
                MessageBox.Show("Row not found. Searching value does not exist.");
        }
    }
}
