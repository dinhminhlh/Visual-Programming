using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;
using Excel= Microsoft.Office.Interop.Excel;
namespace excelDemo
{
    public partial class Form1 : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                pd.ReadTable("select * from tblChatLieu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook =
            exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = 
                (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
            tenvung.Font.Name = "Arial";       tenvung.Font.Size = 16;
            tenvung.Font.Color = Color.Blue;
            tenvung.Value = "Danh sách chất liệu";
            exSheet.get_Range("A1: C1").Merge(true);
            exSheet.get_Range("A2:C2").Font.Size = 14;
            exSheet.get_Range("A2:C2").Font.Bold = true;
            exSheet.get_Range("A2").Value = "STT";
            exSheet.get_Range("B2").Value = "Mã chất liệu";
            exSheet.get_Range("C2").Value = "Tên chất liệu";
            int k = dataGridView1.Rows.Count - 1;
            exSheet.get_Range("A2:C"+(k+2).ToString()).
                Borders.LineStyle
                =Excel.XlLineStyle.xlDouble ;//.Borders( true);
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                exSheet.get_Range("A"+(3+i).ToString()).Value = 
                    (i + 1).ToString();
                exSheet.get_Range("B"+(3+i).ToString()).Value =
                    dataGridView1.Rows[i].Cells[0].Value.ToString();
                exSheet.get_Range("C"+(3+i).ToString()).Value = 
                    dataGridView1.Rows[i].Cells[1].Value.ToString();
            } exBook.Activate();
            SaveFileDialog svf = new SaveFileDialog();
            svf.Title = "chọn đg dẫn và đặt tên tệp lưu dl ";
            svf.ShowDialog();
            string filename = svf.FileName;
            if(filename=="")
            {
                MessageBox.Show("banj chua dat ten file");
            }
            exBook.SaveAs(filename);
            exApp.Quit();
        }
    }
}
