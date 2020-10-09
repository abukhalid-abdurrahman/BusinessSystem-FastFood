using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace BusinessSystem.FastFood.Managment
{
    class Utility
    {
        public enum ExistsType
        {
            XML,
            FILE,
            DIRECTORY
        };

        public static void ShowErrorBox(string Error)
        {
            MessageBox.Show(Error, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformaionBox(string Message)
        {
            MessageBox.Show(Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WriteDataToFile(string name, bool app, string data)
        {
            Utility.isExists(name, Utility.ExistsType.FILE);
            StreamWriter SWriter = new StreamWriter(name, app, Encoding.UTF8);
            SWriter.Write(data);
            SWriter.WriteLine();
            SWriter.Flush();
            SWriter.Close();
        }

        public static void isExists(string Path, ExistsType eType)
        {
            switch (eType)
            {
                case ExistsType.XML:
                    {
                        if (!File.Exists(Path))
                        {
                            StreamWriter SWriter = new StreamWriter(Path, false, Encoding.UTF8);
                            SWriter.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<settings>\n</settings>");
                            SWriter.Flush();
                            SWriter.Close();
                        }
                    }
                    break;
                case ExistsType.FILE:
                    {
                        FileStream FStream = new FileStream(Path, FileMode.OpenOrCreate);
                        FStream.Flush();
                        FStream.Close();
                    }
                    break;
                case ExistsType.DIRECTORY:
                    if (!Directory.Exists(Path))
                        Directory.CreateDirectory(Path);
                    break;
            }
        }

        public static void SearchFromDataGridViewControl(DataGridView DataControl, string SearchValueSource, int CellIndex)
        {
            DataControl.ClearSelection();
            String SearchValue = SearchValueSource;
            int RowIndex = -1;
            foreach (DataGridViewRow RowToSearch in DataControl.Rows)
            {
                if (RowToSearch.Cells[CellIndex].Value != null)
                {
                    if (RowToSearch.Cells[CellIndex].Value.ToString().ToLower().Equals(SearchValue.ToLower()))
                    {
                        RowIndex = RowToSearch.Index;
                        DataControl.Rows[RowIndex].Selected = true;
                        DataControl.FirstDisplayedScrollingRowIndex = RowIndex;
                        break;
                    }
                }
            }
        }

        public static void SaveData(string Path, DataGridView DataControl)
        {
            DataSet DataS = new DataSet();
            DataTable DataT = new DataTable();
            foreach (DataGridViewColumn item in DataControl.Columns)
            {
                DataT.Columns.Add(item.Name);
            }
            foreach (DataGridViewRow item in DataControl.Rows)
            {
                DataRow DataR = DataT.NewRow();
                foreach (DataGridViewCell cell in item.Cells)
                {
                    DataR[cell.ColumnIndex] = cell.Value;
                }
                DataT.Rows.Add(DataR);
            }
            DataS.Tables.Add(DataT);
            DataS.Tables[0].TableName = DataControl.Name;
            DataS.WriteXml(Path);
        }

        public static void LoadData(string Path, DataGridView DataControl)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Path, new XmlReaderSettings());
            DataSet DataS = new DataSet();
            DataS.ReadXml(xmlFile);
            DataControl.DataSource = DataS.Tables[0];
        }

        public static void CreateTable(DataGridView DControl, params string[] Names)
        {
            if (Names != null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    DControl.Columns.Add(Names[i], Names[i]);
                }
            }
            else
                return;
        }

        public static void InsertRowToXMLData(string Path, string DataName, params string[] Data)
        {
            string[] Content = null;
            if (!File.Exists(Path))
            {
                StreamWriter SWriter = new StreamWriter(Path, false, Encoding.UTF8);
                SWriter.Write("<?xml version=\"1.0\" standalone=\"yes\"?>\n<NewDataSet>\n</NewDataSet>");
                SWriter.Flush();
                SWriter.Close();
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement xRowRoot = xDoc.CreateElement(DataName);
            for(int i = 0; i < Data.Length; i++)
            {
                Content = Data[i].Split('=');
                XmlElement cellName = xDoc.CreateElement(Content[0]);
                cellName.InnerText = Content[1];
                xRowRoot.AppendChild(cellName);
            }
            xRoot.AppendChild(xRowRoot);
            xDoc.Save(Path);
        }

        public static void SetRowIndex(DataGridView DataControl)
        {
            foreach (DataGridViewRow Row in DataControl.Rows)
            {
                Row.HeaderCell.Value = String.Format("{0}", Row.Index + 1);
            }
        }
    }

    class DataBase
    {
        public static float SumColumnsData(string Path, string ColumnName)
        {
            float Sum = 0.0f;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path);
            XmlElement xElemRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xElemRoot.SelectNodes(ColumnName);
            foreach(XmlNode xNode in childnodes)
            {
               Sum += float.Parse(xNode.InnerText.Replace(".", ","));
            }
            return Sum;
        }
    }
}
