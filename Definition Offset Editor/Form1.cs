using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Definition_Offset_Editor
{

    public partial class frmMain : Form
    {
        XmlDocument xDoc = new XmlDocument();
        string path = "";
        string cellOrgVal = "";

        public frmMain()
        {
            InitializeComponent();
            FormatTable();
        }

        public void btn_loadXML_Click(object sender, EventArgs e)
        {
            FormatTable();
            ImportXML();   
        }

        #region tableFormat
        private void FormatTable()
        {
            //Clear data grid of current data & formatting
            dataGridXml.Columns.Clear();
            dataGridMonitor.Columns.Clear();

            //Setup grid for address import
            dataGridXml.Columns.Add("Data Address", "Data Address");
            dataGridXml.Columns.Add("ID", "ID");
            dataGridXml.Columns.Add("Name", "Name");
            dataGridXml.Columns.Add("Group", "Group");
            dataGridXml.Columns.Add("Data Type", "Data Type");
            dataGridXml.Columns.Add("Type", "Type");
            dataGridXml.Columns.Add("Level", "Level");
            dataGridXml.Columns.Add("X Axis", "X Axis");
            dataGridXml.Columns.Add("Y Axis", "Y Axis");
            dataGridXml.Columns.Add("Length", "Length");
            dataGridXml.Columns.Add("Monitor", "Monitor");

            dataGridMonitor.Columns.Add("Ram Address", "Ram Address");
            dataGridMonitor.Columns.Add("ID", "ID");
            dataGridMonitor.Columns.Add("Type", "Type");
            dataGridMonitor.Columns.Add("Data Type", "Data Type");
            dataGridMonitor.Columns.Add("Stream - Group", "Stream - Group");
        }
        #endregion

        #region XMLImport
        public void ImportXML()
        {
            //Prompt for path where XML file exists
            OpenFileDialog openFD = new OpenFileDialog();

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                path = openFD.FileName;
            }
            else
            {
                return;
            }
            try
            {
                // Load the XML
                xDoc.Load(path);
            }
            catch (System.IO.FileNotFoundException fnfe)
            {
                // Handle file not found.
                MessageBox.Show("File not found.");
            }

            dataGridXml.Rows.Clear();

            // Parse XML
            foreach (XmlNode node in xDoc.DocumentElement)
            {

                //extract vehicle identifiers
                if (node.Name == "ecuid")
                {
                    // Display make, mfc, and model
                    lbl_make.Text = node.Attributes[0].InnerText;
                    lbl_mfc.Text = node.Attributes[1].InnerText;
                    lbl_model.Text = node.Attributes[2].InnerText;
                    this.Text = node.Attributes[2].InnerText;
                }
                else if (node.Name == "axis")
                {
                    dataGridXml.Rows.Add(
                    node.Attributes.GetNamedItem("dataaddr").InnerText,
                    node.Attributes.GetNamedItem("id").InnerText,
                    node.Attributes.GetNamedItem("name").InnerText,
                    "",
                    node.Attributes.GetNamedItem("datatype").InnerText,
                    "","","","",
                    node.Attributes.GetNamedItem("len").InnerText,
                    node.Attributes.GetNamedItem("monitor").InnerText
                    );
                }
                else if (node.Name == "monitor" && node.Attributes.GetNamedItem("type").InnerText != "composite") //also need to check if type = composite 
                {
                    dataGridMonitor.Rows.Add(
                    node.Attributes.GetNamedItem("ramaddr").InnerText,
                    node.Attributes.GetNamedItem("id").InnerText,
                    node.Attributes.GetNamedItem("type").InnerText,
                    node.Attributes.GetNamedItem("datatype").InnerText,
                    node.Attributes.GetNamedItem("stream-group").InnerText);
                }
                //extract table data
                else if (node.Name == "tabledef")
                {
                    //check if there are x/y axis attributes
                    string yaxis;
                    try
                    {
                        yaxis = node.Attributes.GetNamedItem("yaxis").InnerText;
                    }
                    catch
                    {
                        yaxis = "";
                    }
                    string xaxis;
                    try
                    {
                        xaxis = node.Attributes.GetNamedItem("xaxis").InnerText;
                    }
                    catch
                    {
                        xaxis = "";
                    }
                    //add row to table
                    dataGridXml.Rows.Add(
                    node.Attributes.GetNamedItem("dataaddr").InnerText,
                    node.Attributes.GetNamedItem("id").InnerText,
                    node.Attributes.GetNamedItem("name").InnerText,
                    node.Attributes.GetNamedItem("group").InnerText,
                    node.Attributes.GetNamedItem("datatype").InnerText,
                    node.Attributes.GetNamedItem("type").InnerText,
                    node.Attributes.GetNamedItem("level").InnerText,
                    xaxis, yaxis);
                }


                //add in defined axis
                foreach(XmlNode childNode in node.ChildNodes)
                {
                    if(childNode.Name == "axis" && childNode.Attributes["virtual"] == null)
                    {
                        //missing monitor exception
                        string monitor;
                    try
                    {
                            monitor = childNode.Attributes.GetNamedItem("monitor").InnerText;
                    }
                    catch
                        {
                            monitor = "";
                        }

                        dataGridXml.Rows.Add(
                    childNode.Attributes.GetNamedItem("dataaddr").InnerText,
                    node.Attributes.GetNamedItem("id").InnerText,
                    childNode.Attributes.GetNamedItem("name").InnerText,
                    "",
                    childNode.Attributes.GetNamedItem("datatype").InnerText,
                    childNode.Attributes.GetNamedItem("dir").InnerText,
                    "","","",
                    childNode.Attributes.GetNamedItem("len").InnerText,
                    monitor
                    );
                    }
                }
            }
            
            //DisplayRowCount();
        }
        #endregion

        #region HexCalculation
        public void hexCalc()
        {
            string firstVal = "";
            string userInput = txt_input.Text;
            DataGridViewCell startCell;
            DataGridView activeGrid;
            string activeNode;
            string addressType;

            //setup variables based on which datagrid tab is active
            if (tabControl1.SelectedTab.Name == "tabTable")
            {
                activeGrid = dataGridXml;
                activeNode = "tabledef";
                addressType = "dataaddr";
            }
            else
            {
                activeGrid = dataGridMonitor;
                activeNode = "monitor";
                addressType = "ramaddr";
            }

            //Find the first selected cell.
            foreach (DataGridViewRow gridRow in activeGrid.Rows)
            {
                if (gridRow.Cells[0].Selected == true)
                {
                    startCell = gridRow.Cells[0];
                    firstVal = startCell.Value.ToString();
                    break;
                }
            }

            //check if value is hexi
            if (isHexi(firstVal) == false)
            {
                MessageBox.Show("Please ensure the first cell in your selection contains a valid hexidecimal address.");
                return;
            }

            //check if user has input new address data
            if (userInput == "" || userInput == null)
            {
                txt_input.Select();
                MessageBox.Show("Please enter new address or offset amount in the input box.");
                return;
            }

            //firstVal = firstVal.Substring(2, firstVal.Length - 2);
            firstVal = cleanString(firstVal);
            var whatInt = Convert.ToUInt32(firstVal, 16);

            int offsetInt = 0;
            //check if input is hexi or a manual
            bool inputIsHex = rbHexAdd.Checked;
            bool isNegative = false;
            int inputHex =0;
                //if it is hexi, calculate an offset
                if (inputIsHex)
                {
                    userInput = cleanString(userInput);
                    int firstHex = Convert.ToInt32(firstVal, 16);

                try
                {
                    inputHex = Convert.ToInt32(userInput, 16);
                }
                catch (Exception ex)
                {
                    throw;
                }

                    offsetInt = calcOffset(firstHex, inputHex);
                }

                //manual offset calc
                else if (inputIsHex == false)
                {
                    if (userInput.IndexOf("-", 0) > -1)
                    {
                        userInput = userInput.Replace("-", "");
                        isNegative = true;
                    }

                    offsetInt = Convert.ToInt32(userInput, 16);


                    if(isNegative)
                    {
                        lblCalcOff.Text = "-" + offsetInt.ToString("X");
                    }
                    else
                    {
                        lblCalcOff.Text = offsetInt.ToString("X");
                    }                   
                }
                //Apply offset to each selected cell
                foreach (DataGridViewCell gridCell in activeGrid.SelectedCells)
                {
                    if (gridCell.Value != null && gridCell.ColumnIndex == 0 && isHexi(gridCell.Value.ToString()) && gridCell.Value.ToString() != "")
                    {
                        string cellOrgVal = gridCell.Value.ToString();
                        int cellInt = Convert.ToInt32(gridCell.Value.ToString(), 16);
                        if(isNegative)
                        {
                            cellInt -= offsetInt;
                        }
                        else
                        {
                            cellInt += offsetInt;
                        }
                        
                        UInt32 hexInt = Convert.ToUInt32(cellInt);
                        gridCell.Value = "0x" + hexInt.ToString("X");
                        gridCell.Style.BackColor = Color.LightCoral;

                        //apply same change to XML
                        foreach (XmlNode node in xDoc.DocumentElement)
                        {
                            //find old value in XMl
                            //activeNode here is set to "tabledef" because that's the selected tab
                            if ((node.Name == activeNode || node.Name == "axis") && node.Attributes.GetNamedItem(addressType).InnerText == cellOrgVal)

                            {
                            //change the value of the XML attribute 
                            //variable 'addressType' is "dataaddr" if front tab selected, or 'ramaaddr' if other tab
                            node.Attributes.GetNamedItem(addressType).InnerText = gridCell.Value.ToString();
                            }

                            foreach (XmlNode childNode in node.ChildNodes)
                            {
                                if(childNode.Name == "axis" && childNode.Attributes[addressType] == null && childNode.Attributes["virtual"] == null)
                                {
                                if (childNode.Attributes.GetNamedItem(addressType).InnerText == cellOrgVal)
                                {
                                    childNode.Attributes.GetNamedItem(addressType).InnerText = gridCell.Value.ToString();
                                }
                                }
                            }
                        }
                    }
                
        }

        }
        #endregion

        #region miniMethods
        private int calcOffset(int startNum, int inputNum)
        {
            var diffNum = (startNum - inputNum);
            int offsetNum = (-(diffNum));
            lblCalcOff.Text = offsetNum.ToString();
            return offsetNum;
        }
        public static string cleanString(string strToClean)
        {
            if (strToClean.IndexOf("x", 0) > -1)
            {
                strToClean = strToClean.Substring(2, strToClean.Length - 2);
            }
            return strToClean;
        }
        public static Boolean isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }

        public static Boolean isHexi(string strToCheck)
        {
            try
            {
                strToCheck = cleanString(strToCheck);
                Int32 hexunit = Convert.ToInt32(strToCheck, 16);
                return true;
            }
            catch
            {
                return false;
            }

        }

        private byte[] readBytes()
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string fileName = ofd.FileName;

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            return File.ReadAllBytes(fileName);
        }

        #endregion

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                hexCalc();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + Environment.NewLine + "Error occured " + exp.StackTrace);

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            xDoc.Save(path);
        }

        private void btn_binLoad_Click(object sender, EventArgs e)
        {
            var arr = readBytes();
            for(int i = 0; i<=arr.Length; i++)
            {
                //if i = selection, build table - get dimensions from loaded xml
            }
        }

        private void dataGridXml_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //create modules from above cell selection and datagridselection
        }
    }







    //DisplayRowCount();





}