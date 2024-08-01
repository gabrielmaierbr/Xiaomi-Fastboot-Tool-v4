using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class romfastboot : Form
    {
        public romfastboot()
        {
            InitializeComponent();
        }

        private void comboBoxSelect(string var)
        {
            switch (var)
            {
                case "stock":
                    button1.Text = "Selecionar pasta da ROM";
                    button1.Visible = true;
                    button1.Enabled = true;
                    break;

                case "eu":
                    button1.Text = "Selecionar pasta da ROM";
                    button1.Visible = true;
                    button1.Enabled = true;
                    break;

                case "elite":
                    button1.Text = "Selecionar pasta da ROM";
                    button1.Visible = true;
                    button1.Enabled = true;
                    break;

                case "aospa":
                    button1.Text = "Selecionar ZIP da ROM";
                    button1.Visible = true;
                    button1.Enabled = true;
                    break;
            }
        }

        private void romfastboot_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBoxSelect("stock");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                comboBoxSelect("eu");
            }

            if (comboBox1.SelectedIndex == 2)
            {
                comboBoxSelect("elite");
            }

            if (comboBox1.SelectedIndex == 3)
            {
                comboBoxSelect("aospa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.SelectedPath;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button4.Enabled = true;
                    button4.Visible = true;
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.SelectedPath;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = true;
                    button3.Visible = true;
                    button4.Enabled = true;
                    button4.Visible = true;
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.SelectedPath;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = false;
                    button3.Visible = false;
                    button4.Enabled = true;
                    button4.Visible = true;
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Selecione o ZIP da ROM Paranoid Android";
                dialog.Filter = "Zip (*.zip)|*.zip";
                dialog.FilterIndex = 1;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                    File.Delete(@"C:/adb/aospa.zip");
                    File.Copy(@" " + textBox1.Text, @"C:/adb;aospa.zip");
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = false;
                    button3.Visible = false;
                    button4.Enabled = true;
                    button4.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (File.Exists(textBox1.Text + "/flash_all.bat"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "flash_all.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Caminho incorreto, o arquivo flash_all.bat não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 1) //trocar nome arquivos
            {
                if (File.Exists(textBox1.Text + "/flash_all.bat"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "flash_all.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Caminho incorreto, o arquivo flash_all.bat não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 2) //trocar nome arquivos
            {
                if (File.Exists(textBox1.Text + "/flash_all.bat"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "flash_all.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Caminho incorreto, o arquivo flash_all.bat não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 3) //trocar nome arquivos
            {
                if (File.Exists(textBox1.Text + "/flash_all.bat"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "flash_all.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Caminho incorreto, o arquivo flash_all.bat não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) //colocar função
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Process.Start("https://xmfirmwareupdater.com/");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                Process.Start("https://sourceforge.net/projects/xiaomi-eu-multilang-miui-roms/");
            }

            if (comboBox1.SelectedIndex == 2)
            {
                Process.Start("https://sourceforge.net/projects/eliteroms/");
            }

            if (comboBox1.SelectedIndex == 3)
            {
                Process.Start("https://paranoidandroid.co/");
            }
        }
    }
}
