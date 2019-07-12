using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace DefectItemsListCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseImagePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OFD = new FolderBrowserDialog();

            if(OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imagePath = OFD.SelectedPath;

                imagePathText.Text = imagePath;
            }
        }

        private void chooseDescription_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OFD = new FolderBrowserDialog();

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string imagePath = OFD.SelectedPath;

                destinationText.Text = imagePath;
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("照片");

                var worksheet = excel.Workbook.Worksheets["照片"];


                var headerData = new List<object[]>()
                {
                    new object[] {"合同号", "Contract No.合同号: " + headerText.Text },
                    new object[] { "车型", carModelText.Text },
                    new object[] { "索赔编号", codeText.Text },
                    new object[] {"时间", dateText.Text}
                };

                worksheet.Cells[1, 1].LoadFromArrays(headerData);
                worksheet.Cells["B1:J1"].Merge = true;
                worksheet.Cells["B2:J2"].Merge = true;
                worksheet.Cells["B3:J3"].Merge = true;
                worksheet.Cells["B4:J4"].Merge = true;

                var header2Data = new List<object[]>()
                {
                    new object[] {"序号","照片描述"}
                };
                worksheet.Cells[5, 1].LoadFromArrays(header2Data);
                worksheet.Cells["B5:I5"].Merge = true;
                worksheet.Cells["J5"].Value = "备注";
                worksheet.Cells["A1:J5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                int currentRowNum = 6;
                var directories = System.IO.Directory.GetDirectories(imagePathText.Text);

                worksheet.Column(2).Width = 25.71;
                worksheet.Column(4).Width = 25.71;
                worksheet.Column(6).Width = 25.71;
                worksheet.Column(8).Width = 25.71;

                worksheet.Column(3).Width = 11.42;
                worksheet.Column(5).Width = 11.42;
                worksheet.Column(7).Width = 11.42;
                worksheet.Column(9).Width = 11.42;
                for (int i = 0; i < directories.Length; i++)
                {
                    worksheet.Cells["A" + currentRowNum].Value = i+1;
                    worksheet.Cells["A" + currentRowNum].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A" + currentRowNum].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    string[] imagePaths = System.IO.Directory.GetFiles(@directories[i], "*.jfif");
                    string[] textPath = System.IO.Directory.GetFiles(directories[i], "*.txt");
                    int currentCol = 2;
                    for(int j = 0; j < imagePaths.Length; j++)
                    {
                        Image img = Image.FromFile(@imagePaths[j]);
                        ExcelPicture pic = worksheet.Drawings.AddPicture("pic" + i + j, img);
                        pic.SetPosition(currentRowNum - 1, 0, currentCol - 1, 0);
                        pic.SetSize(180,330);
                        currentCol += 2;
                        
                    }
                    currentCol = 3;
                    if(textPath.Length != 0)
                    {
                        String line;
                        System.IO.StreamReader sr = new System.IO.StreamReader(textPath[0]);
                        line = sr.ReadLine();
                        while(line != null)
                        {
                            worksheet.Cells[currentRowNum, currentCol].Value = line;
                            worksheet.Cells[currentRowNum, currentCol].Style.WrapText = true;
                            worksheet.Cells[currentRowNum, currentCol].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            worksheet.Cells[currentRowNum, currentCol].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            currentCol += 2;
                            line = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    worksheet.Row(currentRowNum).Height = 247.50;
                    currentRowNum++;
                }
                

                System.IO.FileInfo excelFile = new System.IO.FileInfo(destinationText.Text + "\\" + fileName.Text + ".xlsx");

                excel.SaveAs(excelFile);

                MessageBox.Show("File is created.");
            }
        }
    }
}
