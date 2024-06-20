using System.Text;
using System.Xml;
using System;

namespace Unit_3_CSharp
{
    public partial class Form1 : Form
    {
        private string filePathCSV;
        private string filePathJSON;
        private string filePathXML;
        private string filePathTXT;

        public Form1()
        {
            InitializeComponent();
        }

        #region OperationsCSV
        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            filePathCSV = openFileDialog.FileName;
            ShowCSV_InDGV();
        }

        public void ShowCSV_InDGV()
        {
            dgvTableCSV.Rows.Clear();
            dgvTableCSV.Columns.Clear();

            // Read lines from the CSV file
            string[] lines = File.ReadAllLines(filePathCSV);

            // If there are lines in the file
            if (lines.Length > 0)
            {
                // Get column names from the first record
                string[] columnNames = lines[0].Split(',');

                // Add columns to the DataGridView using the column names from the CSV
                foreach (string columnName in columnNames)
                {
                    dgvTableCSV.Columns.Add(columnName, columnName);
                }

                // Add rows to the DataGridView with the content from the CSV (excluding the first line)
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    dgvTableCSV.Rows.Add(fields);
                }
            }
        }

        private void btnSearchCSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePathCSV) || !File.Exists(filePathCSV))
            {
                MessageBox.Show("Select a file to work with.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtSearchCSV.Text == "")
            {
                MessageBox.Show("To search, you must use a NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                // Read the CSV file line by line
                using (StreamReader reader = new StreamReader(filePathCSV))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');

                        // Compare the search term with the first field (in this case, the name)
                        if (fields.Length > 0 && fields[0] == txtSearchCSV.Text)
                        {
                            MessageBox.Show("Found: " + string.Join(", ", fields), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching in the CSV file: " + ex.Message);
            }
            MessageBox.Show("No matching name found in the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            // Check if there is data in the DataGridView
            if (dgvTableCSV.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the path of the CSV file
            string filePath = filePathCSV;

            try
            {
                // Create a StringBuilder to build the content of the CSV file
                StringBuilder csvContent = new StringBuilder();

                // Add column headers to the CSV file
                for (int i = 0; i < dgvTableCSV.Columns.Count; i++)
                {
                    csvContent.Append(dgvTableCSV.Columns[i].HeaderText);
                    if (i < dgvTableCSV.Columns.Count - 1)
                    {
                        csvContent.Append(",");
                    }
                }
                csvContent.AppendLine(); // Add new line after headers

                // Add data from each row to the CSV file
                foreach (DataGridViewRow row in dgvTableCSV.Rows)
                {
                    bool hasData = false; // Flag to check if the row has any non-empty cells
                    StringBuilder rowData = new StringBuilder();

                    for (int i = 0; i < dgvTableCSV.Columns.Count; i++)
                    {
                        // Check if the cell value is not null or empty
                        if (row.Cells[i].Value != null && !string.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                        {
                            rowData.Append(row.Cells[i].Value.ToString());
                            hasData = true; // Set flag to true if the cell has non-empty value
                        }

                        if (i < dgvTableCSV.Columns.Count - 1)
                        {
                            rowData.Append(",");
                        }
                    }

                    // Add row data to the CSV content if the row has any non-empty cells
                    if (hasData)
                    {
                        csvContent.AppendLine(rowData.ToString());
                    }
                }

                // Write the content to the CSV file
                File.WriteAllText(filePath, csvContent.ToString());

                MessageBox.Show("Data saved successfully to the CSV file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data to the CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowCSV_InDGV();
        }

        private void btnDeleteCSV_Click(object sender, EventArgs e)
        {
            // Check if a file is selected
            if (string.IsNullOrWhiteSpace(filePathCSV) || !File.Exists(filePathCSV))
            {
                MessageBox.Show("Select a valid file to work with.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check if a name to search for is entered
            if (string.IsNullOrWhiteSpace(txtSearchCSV.Text))
            {
                MessageBox.Show("Please enter a name to search for.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Read the CSV file line by line and write the non-deleted lines to a new temporary file
                string tempFilePath = Path.GetTempFileName();
                using (StreamReader reader = new StreamReader(filePathCSV))
                using (StreamWriter writer = new StreamWriter(tempFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the current line contains the name to delete
                        if (!line.Contains(txtSearchCSV.Text))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                // Replace the original file with the temporary file
                File.Delete(filePathCSV);
                File.Move(tempFilePath, filePathCSV);
                ShowCSV_InDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting line from the CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ShowContentOf_JSON
        private void btnOpenJSON_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                openFileDialog.Title = "Select an JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                filePathJSON = openFileDialog.FileName;
                LoadJSONData();
            }
        }
        private void LoadJSONData()
        {
            try
            {
                string jsonContent = File.ReadAllText(filePathJSON);
                dynamic jsonData = JsonConvert.DeserializeObject(jsonContent);

                if (jsonData != null)
                {
                    // Limpiar nodos previos en el TreeView
                    tvJSON.Nodes.Clear();

                    // Agregar el JSON al TreeView
                    AddNode(jsonData, "Root");
                }
                else
                {
                    MessageBox.Show("Empty JSON content", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading JSON data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNode(dynamic data, string nodeName, TreeNode parentNode = null)
        {
            if (data is JObject)
            {
                // Si el nodo es un objeto JSON, agregar sus propiedades como subnodos
                var node = parentNode != null ? parentNode.Nodes.Add(nodeName) : tvJSON.Nodes.Add(nodeName);
                foreach (var property in data.Properties())
                {
                    AddNode(property.Value, property.Name, node);
                }
            }
            else if (data is JArray)
            {
                // Si el nodo es un arreglo JSON, agregar sus elementos como subnodos
                var node = parentNode != null ? parentNode.Nodes.Add(nodeName) : tvJSON.Nodes.Add(nodeName);
                int index = 0;
                foreach (var item in data)
                {
                    AddNode(item, $"Item {index++}", node);
                }
            }
            else
            {
                // Si el nodo es un valor simple, agregarlo como un subnodo
                var node = parentNode != null ? parentNode.Nodes.Add($"{nodeName}: {data}") : tvJSON.Nodes.Add($"{nodeName}: {data}");
            }
        }
        #endregion

        #region ShowContentOf_XML
        private void btnOpenXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
                openFileDialog.Title = "Select an XML file";

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                filePathXML = openFileDialog.FileName;
                LoadXMLData();
            }
        }

        private void LoadXMLData()
        {
            try
            {
                // Cargar el documento XML
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePathXML);

                // Limpiar nodos previos en el TreeView
                tvXML.Nodes.Clear();

                // Agregar el XML al TreeView
                AddXmlNode(xmlDoc.DocumentElement, "Root");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddXmlNode(XmlNode xmlNode, string nodeName, TreeNode parentNode = null)
        {
            if (xmlNode.NodeType == XmlNodeType.Element)
            {
                // Si el nodo es un elemento XML, agregarlo como un nodo en el TreeView
                var node = parentNode != null ? parentNode.Nodes.Add(nodeName) : tvXML.Nodes.Add(nodeName);

                // Agregar los atributos del elemento como subnodos
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    node.Nodes.Add($"@{attribute.Name}: {attribute.Value}");
                }

                // Agregar los nodos hijos del elemento como subnodos
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    AddXmlNode(childNode, childNode.Name, node);
                }
            }
            else if (xmlNode.NodeType == XmlNodeType.Text)
            {
                // Si el nodo es un nodo de texto, agregarlo como un subnodo al nodo padre
                parentNode.Nodes.Add(xmlNode.Value);
            }
        }
        #endregion

        #region UnstructuredFile
        private void btnOpenTXT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt Files|*.txt|All Files|*.*";
                openFileDialog.Title = "Select an TXT file";

                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                filePathTXT = openFileDialog.FileName;
            }

            using (StreamReader sr = new StreamReader(filePathTXT))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lstDocumentTXT.Items.Add(line);
                }
            }

        }

        private void btnSearchTXT_Click(object sender, EventArgs e)
        {
            try
            {
                string palabraABuscar = txtSearchTXT.Text.Trim();

                lstResultados.Items.Clear();

                // Leer el archivo línea por línea
                using (StreamReader sr = new StreamReader(filePathTXT))
                {
                    string line;
                    int lineNumber = 1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Verificar si la línea contiene la palabra buscada
                        if (line.Contains(palabraABuscar))
                        {
                            lstResultados.Items.Add($"Line {lineNumber}: {line}");
                        }
                        lineNumber++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }

}