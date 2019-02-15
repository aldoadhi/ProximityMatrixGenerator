using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxMatrixGUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        char separator = ' ';
        public Form()
        {
            InitializeComponent();

            comboBoxMethod.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(txtPath.Text == "" || txtNumerik.Text == "")
            {
                string msg = "";
                if(txtPath.Text == "")
                {
                    msg = "Please choose data file first." + Environment.NewLine;
                }
                if(txtNumerik.Text == "")
                {
                    msg = "Please fill numeric attribute indexes.";
                }
                MessageBox.Show(msg, "Error");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save As";
                saveFileDialog.FileName = "Proximity_Matrix.txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                    if (radioButtonKoma.Checked)
                    {
                        separator = ',';
                    }


                    StreamReader readerX = new StreamReader(txtPath.Text);
                    string[] numeriks = txtNumerik.Text.Split(',');
                    while (!readerX.EndOfStream)
                    {
                        string lineData1 = readerX.ReadLine();
                        string[] dataX = lineData1.Split(separator);

                        StreamReader readerY = new StreamReader(txtPath.Text);
                        string line = "";
                        while (!readerY.EndOfStream)
                        {
                            string lineData2 = readerY.ReadLine();
                            string[] dataY = lineData2.Split(separator);
                            double value = 0.0;
                            double lengthXPow2 = 0.0;
                            double lengthYPow2 = 0.0;
                            foreach (string numerik in numeriks)
                            {
                                double x = double.Parse(dataX[int.Parse(numerik)]);
                                double y = double.Parse(dataY[int.Parse(numerik)]);
                                switch (comboBoxMethod.SelectedIndex)
                                {                                   
                                    case 0: // euclidean
                                        value += Math.Pow(x - y, 2);
                                        break;
                                    case 1: // minkowski r = 1
                                        value += Math.Abs(x - y);
                                        break;
                                    case 2: // minkowski r = supremum
                                        double dist = Math.Abs(x - y);
                                        if(dist > value)
                                        {
                                            value = dist;
                                        }
                                        break;
                                    default: // cosine / extended jaccard                                       
                                        value += x * y;
                                        lengthXPow2 += Math.Pow(x, 2);
                                        lengthYPow2 += Math.Pow(y, 2);
                                        break;
                                }
                            }

                            
                            
                            switch(comboBoxMethod.SelectedIndex)
                            {
                                case 0: // euclidean
                                    value = Math.Sqrt(value);
                                    break;
                                case 3: // cosine
                                    value /= (Math.Sqrt(lengthXPow2) * Math.Sqrt(lengthYPow2));
                                    break;
                                case 4: // extended jaccard
                                    value /= (lengthXPow2 + lengthYPow2 - value);
                                    break;
                            }

                            value = Math.Round(value, 4);

                            int countSpace = 15 - value.ToString().Count();
                            string spaces = "";
                            for (int z = 0; z < countSpace; z++)
                            {
                                spaces += " ";
                            }

                            line += value + spaces;
                        }

                        Console.WriteLine(line);
                        writer.WriteLine(line);
                        writer.Flush();
                    }


                    MessageBox.Show("Proximity Matrix generated successfully!", "Horray");
                }
            }
            

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.csv),(*.txt)|*.txt;*.csv";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
                string ext = Path.GetExtension(fileDialog.FileName);
            }
        }       
    }
}
