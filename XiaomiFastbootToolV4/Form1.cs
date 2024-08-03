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
using System.Drawing.Text;

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

                case "cmd":
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
                    break;

                case "miflash":
                    try
                    {
                        if (File.Exists(@"adb/miflash/XiaoMiFlash.exe"))
                        {
                            System.Diagnostics.Process process2 = new Process();
                            process2.StartInfo.WorkingDirectory = "adb/miflash";
                            process2.StartInfo.FileName = "XiaoMiFlash.exe";
                            process2.Start();
                            process2.WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("Arquivos do Mi Flash não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case "adb13":
                    try
                    {
                        if (File.Exists(@"adb/driver/adbsetup13.exe"))
                        {
                            System.Diagnostics.Process process2 = new Process();
                            process2.StartInfo.WorkingDirectory = "adb/driver";
                            process2.StartInfo.FileName = "adbsetup13.exe";
                            process2.Start();
                            process2.WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("Arquivos do ADB Driver Setup não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case "adb143":
                    try
                    {
                        if (File.Exists(@"adb/driver/adbsetup143.exe"))
                        {
                            System.Diagnostics.Process process2 = new Process();
                            process2.StartInfo.WorkingDirectory = "adb/driver";
                            process2.StartInfo.FileName = "adbsetup143.exe";
                            process2.Start();
                            process2.WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("Arquivos do ADB Driver Setup não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case "adbMinimal":
                    try
                    {
                        if (File.Exists(@"adb/driver/minimal_adb_fastboot_v1.4.3_setup.exe"))
                        {
                            System.Diagnostics.Process process2 = new Process();
                            process2.StartInfo.WorkingDirectory = "adb/driver";
                            process2.StartInfo.FileName = "minimal_adb_fastboot_v1.4.3_setup.exe";
                            process2.Start();
                            process2.WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("Arquivos do ADB Driver Setup não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case "platformTools":
                    void copiarPlatformTools()
                    {
                        try
                        {
                            string pastaOrigem = "adb/driver/platform-tools";
                            string pastaDestino = @"C:/adb/";
                            string[] files = Directory.GetFiles(pastaOrigem);
                            foreach (string arquivos in files)
                            {
                                File.Copy(arquivos, pastaDestino + Path.GetFileName(arquivos), true);
                            }
                            MessageBox.Show("Arquivos do Platform Tools copiados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    if (!Directory.Exists(@"C:/adb"))
                    {
                        if (MessageBox.Show("O diretório 'C:/adb' não existe, deseja criar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Directory.CreateDirectory(@"C:/adb");
                            MessageBox.Show("Pasta criada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            copiarPlatformTools();
                        }
                    }
                    else
                    {
                        copiarPlatformTools();
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
                    MessageBox.Show("Pasta criada, instale ADB Drivers", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            command("cmd");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            command("edl");
        }

        private void aDBDriver13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            command("adb13");
        }

        private void aDBDriver143ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            command("adb143");
        }

        private void aDBMinimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            command("adbMinimal");
        }

        private void miFlashToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            command("miflash");
        }

        private void platformToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            command("platformTools");
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
