using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class FormForApps : Form
    {
        public FormForApps()
        {
            InitializeComponent();
            InitializeApplicationList();
        }

        private void InitializeApplicationList()
        {
            comboBoxApp.Items.Add("Perplexity");
            comboBoxApp.Items.Add("Obsidian");
            comboBoxApp.Items.Add("YouGile");
            comboBoxApp.Items.Add("Excel");
            comboBoxApp.Items.Add("Word");
            comboBoxApp.Items.Add("CATIA");
            comboBoxApp.Items.Add("FEMAP");
            comboBoxApp.Items.Add("КОМПАС-3D");
            comboBoxApp.Items.Add("COMSOL");
            comboBoxApp.Items.Add("Anisogrid");
            comboBoxApp.Items.Add("ForAnisogrid");
            comboBoxApp.Items.Add("MathCAD");
            comboBoxApp.Items.Add("SolidWorks");
            comboBoxApp.Items.Add("Digimat");
            comboBoxApp.Items.Add("Aura");
            comboBoxApp.Items.Add("HyperMesh");
            comboBoxApp.Items.Add("Maple");
            comboBoxApp.Items.Add("pgAdmin");
            comboBoxApp.Items.Add("Blender");
            comboBoxApp.Items.Add("1C");
            comboBoxApp.Items.Add("OBS");
            comboBoxApp.Items.Add("Movavi");

            comboBoxApp.SelectedIndex = 0;
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {

        }

        private void LaunchKompas()
        {
            string kompasPath = @"C:\Program Files\ASCON\KOMPAS-3D v22 Study\Bin\kStudy.exe";

            Process.Start(kompasPath);
        }

        private void LaunchFemap()
        {
            string femapPath = @"C:\Program Files\Siemens\Femap 2412\femap.exe";

            Process.Start(femapPath);
        }

        private void LaunchComsol()
        {
            string comsolPath = @"C:\Program Files\COMSOL\COMSOL62\Multiphysics\bin\win64\comsol.exe";

            Process.Start(comsolPath);
        }

        private void LaunchSolid()
        {
            string solidPath = @"C:\Program Files\SOLIDWORKS Corp\SOLIDWORKS\SLDWORKS.exe";

            Process.Start(solidPath);
        }

        private void LaunchCatia()
        {
            string catiaPath = @"C:\Program Files\Dassault Systemes\B32\win_b64\code\bin\CATSTART.exe";

            Process.Start(catiaPath);
        }

        private void LaunchBlender()
        {
            string blenderPath = @"C:\Program Files\Blender Foundation\Blender 4.5\blender-launcher.exe";

            Process.Start(blenderPath);
        }
        private void LaunchDigimat()
        {
            string digimatPath = @"C:\MSC.Software\Digimat\shortcuts\Digimat20170.bat";

            Process.Start(digimatPath);
        }
        private void LaunchHyperMesh()
        {
            string hmPath = @"C:\Program Files\Altair\13.0\hw\bin\win64\hw.exe";

            Process.Start(hmPath);
        }
        private void LaunchMaple()
        {
            string maplePath = @"C:\Program Files\Maple 2025\bin.X86_64_WINDOWS\maplew.exe";

            Process.Start(maplePath);
        }
        private void LaunchObsidian()
        {
            string obsidianPath = @"C:\Users\Admin\AppData\Local\Programs\Obsidian\Obsidian.exe";

            Process.Start(obsidianPath);
        }
        private void LaunchMathCAD()
        {
            string mcPath = @"C:\Users\Admin\PrimeMath\Mathcad Prime 10.0.0.0\MathcadPrime.exe";

            Process.Start(mcPath);
        }
        private void LaunchpgAdmin()
        {
            string sqlPath = @"C:\Program Files\PostgreSQL\17\pgAdmin 4\runtime\pgAdmin4.exe";

            Process.Start(sqlPath);
        }
        private void LaunchAnisogrid()
        {
            string anisPath = @"C:\Users\Admin\AppData\Local\Anisogrid\Anisogrid.exe";

            Process.Start(anisPath);
        }
        private void LaunchForAnisogrid()
        {
            string fanisPath = @"C:\Users\Admin\source\repos\Test1\Test1\Test1\bin\Debug\ForAnisogrid.exe";

            Process.Start(fanisPath);
        }
        private void LaunchPerplexity()
        {
            string perpPath = @"C:\Users\Admin\AppData\Local\Programs\Perplexity\Perplexity.exe";

            Process.Start(perpPath);
        }
        private void Launch1C()
        {
            string cPath = @"C:\Program Files (x86)\1cv8t\common\1cestartt.exe";

            Process.Start(cPath);
        }
        private void LaunchOBS()
        {
            string obsPath = @"C:\Users\Admin\OneDrive\Desktop\Soft\OBS Studio.lnk";

            Process.Start(obsPath);
        }
        private void LaunchMovavi()
        {
            string movPath = @"C:\Users\Admin\AppData\Roaming\Movavi Suite\MovaviSuite.exe";

            Process.Start(movPath);
        }
        private void LaunchYouGile()
        {
            string youPath = @"C:\Users\Admin\AppData\Local\Programs\YouGile\YouGile.exe";

            Process.Start(youPath);
        }
        private void LaunchAura()
        {
            string aurPath = @"C:\Program Files\Anisoprint\Aura 2\Aura.exe";

            Process.Start(aurPath);
        }
        private void LaunchExcel()
        {
            string excPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Excel 2013.lnk";

            Process.Start(excPath);
        }
        private void LaunchWord()
        {
            string wrdPath = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Word 2013.lnk";

            Process.Start(wrdPath);
        }


        private void buttonLauncher_Click_1(object sender, EventArgs e)
        {
            if (comboBoxApp.SelectedItem == null)
            {
                MessageBox.Show("Выберите приложение для запуска", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedApp = comboBoxApp.SelectedItem.ToString();

            try
            {
                switch (selectedApp)
                {
                    case "КОМПАС-3D":
                        LaunchKompas();
                        break;
                    case "FEMAP":
                        LaunchFemap();
                        break;
                    case "COMSOL":
                        LaunchComsol();
                        break;
                    case "SolidWorks":
                        LaunchSolid();
                        break;
                    case "CATIA":
                        LaunchCatia();
                        break;
                    case "Blender":
                        LaunchBlender();
                        break;
                    case "Digimat":
                        LaunchDigimat();
                        break;
                    case "HyperMesh":
                        LaunchHyperMesh();
                        break;
                    case "Maple":
                        LaunchMaple();
                        break;
                    case "Obsidian":
                        LaunchObsidian();
                        break;
                    case "MathCAD":
                        LaunchMathCAD();
                        break;
                    case "pgAdmin":
                        LaunchpgAdmin();
                        break;
                    case "Anisogrid":
                        LaunchAnisogrid();
                        break;
                    case "ForAnisogrid":
                        LaunchForAnisogrid();
                        break;
                    case "Perplexity":
                        LaunchPerplexity();
                        break;
                    case "1C":
                        Launch1C();
                        break;
                    case "OBS":
                        LaunchOBS();
                        break;
                    case "Movavi":
                        LaunchMovavi();
                        break;
                    case "YouGile":
                        LaunchYouGile();
                        break;
                    case "Aura":
                        LaunchAura();
                        break;
                    case "Excel":
                        LaunchExcel();
                        break;
                    case "Word":
                        LaunchWord();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска приложения: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         Close();
        }
    }
}

