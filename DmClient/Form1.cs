using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DmClient
{
    public partial class Form1 : Form
    {
        private dynamic oDmApp = null;
        private string projectFolder = null;
        private localhost.Collar[] listCollars;
        private localhost.Assay[] listAssays;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                labConnectStatus.Text = "Нет соединения с Datamine";
                labConnectStatus.ForeColor = Color.DarkRed;
                labDhGettingStatus.Text = "Данные не получены";
                labDhGettingStatus.ForeColor = Color.DarkRed;
                labVisualStatus.Text = "Данные не визуализированы";
                labVisualStatus.ForeColor = Color.DarkRed;

                oDmApp = Activator.CreateInstance(Type.GetTypeFromProgID("DatamineStudio.Application"));


                if (oDmApp == null || oDmApp.ActiveProject == null)    //Attempt to Use the Active Datamine Session
                {
                    MessageBox.Show("There are no active Studio3 projects open.\n Please open a Studio 3 project before continuing.");
                }
                labConnectStatus.Text = "Есть соединение с Datamine";
                labConnectStatus.ForeColor = Color.Green;
                projectFolder = oDmApp.ActiveProject.Folder;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed\nReason: " + ex.Message);
                if (oDmApp) oDmApp.Quit(); // release the session to close it down
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labConnectStatus.Text = "Нет соединения с Datamine";
            labConnectStatus.ForeColor = Color.DarkRed;
            labDhGettingStatus.Text = "Данные не получены";
            labDhGettingStatus.ForeColor = Color.DarkRed;
            labVisualStatus.Text = "Данные не визуализированы";
            labVisualStatus.ForeColor = Color.DarkRed;
        }

        private void butDhGetting_Click(object sender, EventArgs e)
        {
            localhost.GetDH Service = new localhost.GetDH();
            
            listCollars = Service.GetCollars();
            listAssays = Service.GetAssays();

            labDhGettingStatus.Text = "Данные  получены";
            labDhGettingStatus.ForeColor = Color.Green;

        }

        private void butVisual_Click(object sender, EventArgs e)
        {
            string collarPath = projectFolder + "\\db_collars.dm";
            string assayPath = projectFolder + "\\db_assays.dm";

            FileInfo fiCollar = new FileInfo(collarPath);
            FileInfo fiAssay = new FileInfo(assayPath);

            try
            {
                if (fiCollar.Exists) fiCollar.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удаётся удалить файл "+ collarPath +". Программа не может закончить действие.");
                return;
            }

            try {
                if (fiAssay.Exists) fiAssay.Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удаётся удалить файл " + assayPath + ". Программа не может закончить действие.");
                return;
            }
            oDmApp.ParseCommand("inputd &OUT=db_collars" +
                " 'db_collars'" +
                " 'BHID'" +
                " 'A'" +
                " '20'" +
                " 'y'" +
                " '-'" +
                " 'BENCH_NA'" +
                " 'N'" +
                " 'y'" +
                " ''" +
                " 'HOLE_NAM'" +
                " 'n'" +
                " 'Y'" +
                " ''" +
                " 'EXPL_LIN'" +
                " 'A'" +
                " '4'" +
                " 'y'" +
                " '-'" +
                " 'XCOLLAR'" +
                " 'n'" +
                " 'y'" +
                " '-'" +
                " 'YCOLLAR'" +
                " 'n'" +
                " 'Y'" +
                " '-'" +
                " 'ZCOLLAR'" +
                " 'n'" +
                " 'Y'" +
                " '-'" +
                " 'ENDDEPTH'" +
                " 'N'" +
                " 'Y'" +
                " '-'" +
                " '!'" +
                " 'y'");




            oDmApp.ParseCommand("inputd &OUT=db_assays" +
                 " 'db_assays'" +
                 " 'BHID'" +
                 " 'a'" +
                 " '20'" +
                 " 'Y'" +
                 " '-'" +
                 " 'SAMPLE'" +
                 " 'a'" +
                 " '10'" +
                 " 'Y'" +
                 " '-'" +
                 " 'FROM'" +
                 " 'N'" +
                 " 'y'" +
                 " '-'" +
                 " 'TO'" +
                 " 'N'" +
                 " 'y'" +
                 " '-'" +
                 " 'LENGTH'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'VES_SAMP'" +
                 " 'N'" +
                 " 'Y'" +
                 " '-'" +
                 " 'Au_cut'" +
                 " 'N'" +
                 " 'Y'" +
                 " '-'" +
                 " 'ROCK'" +
                 " 'a'" +
                 " '70'" +
                 " 'y'" +
                 " '-'" +
                 " 'TYPE_RAN'" +
                 " 'a'" +
                 " '8'" +
                 " 'Y'" +
                 " '-'" +
                 " 'CATEGORY'" +
                 " 'a'" +
                 " '15'" +
                 " 'Y'" +
                 " '-'" +
                 " 'Au'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'As'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'C'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'Sb'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'S'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'Ca'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'Fe'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " 'Ag'" +
                 " 'n'" +
                 " 'y'" +
                 " '-'" +
                 " '!'" +
                 " 'y'");

            try {
                copyCollarsToFile(fiCollar, listCollars);
                copyAssaysToFile(fiAssay, listAssays);
            }
            catch(NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                oDmApp.ParseCommand("holes3d &COLLAR=db_collars &SAMPLE1=db_assays &OUT=db_dholes &ERRORS=db_dholes_err *BHID=BHID *XCOLLAR=XCOLLAR *YCOLLAR=YCOLLAR *ZCOLLAR=ZCOLLAR *FROM=FROM *TO=TO @SURVSMTH=1 @ENDPOINT=0 @DIPMETH=1 @PRINT=0");
                oDmApp.ActiveProject.Data.LoadFile(projectFolder + "\\db_dholes.dm");
                dynamic ovDHLS = oDmApp.ActiveProject.Design.GetCurrentDrillHolesObject(false);
                string path_template = "\\\\OGK-S-APPMINE01\\MDB\\tpl\\";
                string parDhBlTpl = "DhBl01";
                oDmApp.ActiveProject.LoadOverlayTemplatesEx(path_template + parDhBlTpl + ".tpl", true, true);
                if (!oDmApp.ActiveProject.Design.ApplyOverlayTemplate(ovDHLS.Name, parDhBlTpl))
                {
                    MessageBox.Show("Не удалось применить шаблон вида. Возможно не доступен файл: " + path_template + parDhBlTpl + ".tpl");
                }

                oDmApp.ParseCommand("zoom-all-graphics");
                rScale_onclick(ovDHLS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При визуализации в Datamine произошла ошибка "+ex.Message);
                return;
            }
            labVisualStatus.Text = "Данные визуализированы";
            labVisualStatus.ForeColor = Color.Green;
        }

        private void copyCollarsToFile(FileInfo fiCollar, localhost.Collar[] parListCollars)
        {
            if ( parListCollars == null || parListCollars.Count() == 0 )
            {
                throw new NotImplementedException ("Список координат скважин пуст. Выполнение невозможно.");
            }
            if( !fiCollar.Exists )
            {
                throw new NotImplementedException("Файл " + fiCollar.FullName + " не существует. Выполнение невозможно"); 
            }

            dynamic oDmFile = (dynamic)Activator.CreateInstance(Type.GetTypeFromProgID("DmFile.DmTableADO"));
            oDmFile.Open(fiCollar.FullName, false);

            foreach (var i in parListCollars)
            {
                oDmFile.AddRow();
                oDmFile.SetNamedColumn("BHID", i.BHID ?? "");
                oDmFile.SetNamedColumn("BENCH_NA", i.Bench );
                oDmFile.SetNamedColumn("HOLE_NAM", i.Hole);
                oDmFile.SetNamedColumn("EXPL_LIN", i.Blast ?? "");
                oDmFile.SetNamedColumn("XCOLLAR", i.XCollar);
                oDmFile.SetNamedColumn("YCOLLAR", i.YCollar);
                oDmFile.SetNamedColumn("ZCOLLAR", i.ZCollar);
                oDmFile.SetNamedColumn("ENDDEPTH", i.Depth);
            }
            oDmFile.Close();
        }
        private void copyAssaysToFile(FileInfo fiAssasy, localhost.Assay[] parListAssasys)
        {
            if (listCollars == null || listCollars.Count() == 0)
            {
                throw new NotImplementedException("Список координат скважин пуст. Выполнение невозможно.");
            }
            if (!fiAssasy.Exists)
            {
                throw new NotImplementedException("Файл " + fiAssasy.FullName + " не существует. Выполнение невозможно");
            }

            dynamic oDmFile = Activator.CreateInstance(Type.GetTypeFromProgID("DmFile.DmTableADO"));
            oDmFile.Open(fiAssasy.FullName, false);

            foreach (var i in parListAssasys)
            {
                oDmFile.AddRow();
                oDmFile.SetNamedColumn("BHID", i.BHID ?? "");
                oDmFile.SetNamedColumn("SAMPLE", i.Sample ?? "");
                oDmFile.SetNamedColumn("FROM", i.From);
                oDmFile.SetNamedColumn("TO", i.To);
                oDmFile.SetNamedColumn("LENGTH", i.Length);
                oDmFile.SetNamedColumn("VES_SAMP", i.Ves);
                oDmFile.SetNamedColumn("Au_cut", i.GC_Au);
                oDmFile.SetNamedColumn("Au", i.GC_Au);
            }
            oDmFile.Close();
        }

        private void  rScale_onclick(dynamic ovDHLS)
        {

            int pSc_PointsSize = 90;
            int pSc_RowHeight = 125;
            int pSc_FH1 = 200;
            int pSc_FH2 = 230;
            int pSc_FH3 = 230;


				ovDHLS.PointsSize = pSc_PointsSize* 2; 										// Устанавливаем размер точки

				ovDHLS.FormatLabels.RowHeight = pSc_RowHeight* 4;
				ovDHLS.FormatLabels.SetTextFontHeight(1, pSc_FH1* 4); 				// размер шрифта
				ovDHLS.FormatLabels.SetTextFontHeight(3, pSc_FH2* 4); 				// размер шрифта
                ovDHLS.FormatLabels.SetTextFontHeight(4, pSc_FH3 * 4);

            oDmApp.ParseCommand("redraw-display"); 	//перерисовываем экран
		}


    }
}
