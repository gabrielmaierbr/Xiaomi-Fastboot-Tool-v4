using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void command(string var)
        {
            switch (var)
            {
                case "reboot":
                    if (File.Exists(@"C:/adb/fastboot.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = @"C:/adb";
                        process.StartInfo.FileName = "fastboot.exe";
                        process.StartInfo.Arguments = "reboot";
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "chkBL":
                    if (File.Exists(@"C:/adb/fastboot.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = @"C:/adb";
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.Arguments = "/K fastboot oem device-info";
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "unlockBL":
                    if (File.Exists(@"adb/miunlock/miflash_unlock.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = "adb/miunlock";
                        process.StartInfo.FileName = "miflash_unlock.exe";
                        process.Start();
                        process.WaitForExit();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos do Mi Unlock não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "lockBL":
                    if (MessageBox.Show("O bloqueio de Bootloader deve ser feito apenas na ROM Stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (MessageBox.Show("Você está na ROM Stock?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (MessageBox.Show("Tem certeza?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {

                                if (File.Exists(@"C:/adb/fastboot.exe"))
                                {
                                    System.Diagnostics.Process process = new Process();
                                    process.StartInfo.WorkingDirectory = @"C:/adb";
                                    process.StartInfo.FileName = "fastboot.exe";
                                    process.StartInfo.Arguments = "oem lock";
                                    process.Start();
                                }
                                else
                                {
                                    MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    break;

                case "chkSlot":
                    if (File.Exists(@"C:/adb/fastboot.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = @"C:/adb";
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.Arguments = "/K fastboot getvar current-slot";
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "changeSlotA":
                    if (File.Exists(@"C:/adb/fastboot.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = @"C:/adb";
                        process.StartInfo.FileName = "fastboot.exe";
                        process.StartInfo.Arguments = "set_active a";
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "changeSlotB":
                    if (File.Exists(@"C:/adb/fastboot.exe"))
                    {
                        System.Diagnostics.Process process = new Process();
                        process.StartInfo.WorkingDirectory = @"C:/adb";
                        process.StartInfo.FileName = "fastboot.exe";
                        process.StartInfo.Arguments = "set_active b";
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "edl":
                    if (File.Exists(@"C:/adb/fastboot.exe") == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Tem certeza?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process process = new Process();
                            process.StartInfo.WorkingDirectory = @"C:/adb";
                            process.StartInfo.FileName = "fastboot.exe";
                            process.StartInfo.Arguments = "oem edl";
                            process.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:/adb"))
            {
                if (MessageBox.Show("O diretório 'C:/adb' não existe, deseja criar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.CreateDirectory(@"C:/adb");
                    MessageBox.Show("Instale os ADB Drivers", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command("reboot");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command("chkBL");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command("unlockBL");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command("lockBL");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command("chkSlot");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            command("changeSlotA");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            command("changeSlotB");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:/adb"))
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "cmd.exe";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            command("edl");
        }

        private void aDBDriver13ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDBDriver143ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDBMinimalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miFlashToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void platformToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rOMsFastbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            romfastboot fastbootrom = new romfastboot();
            fastbootrom.Show();
        }

        private void instalarCustomRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recovery rec = new recovery();
            rec.Show();
        }
    }
}
