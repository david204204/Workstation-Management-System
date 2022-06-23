using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//Yaniv Avikzer
//David Tzur
// this class is a global helper, most things here will be used 
// all over the project
namespace FinalProjectForm.InterfaceClases
{

    public static class GeneralCodeHelper
    {

        public static Users curentUser = new Users(); // this is the user who logged in        
        public static string Database = "iaf"; // Database Name this is used all over DO NOT CHANGE!
        private static void ExportExel_Tasks_obj(List<SingleTaskView> obj)
        {
            // Function will get an Tasks object array and will export it to exel file
            
            // Exel declaraions
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            
            //Setting up exel sheet
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "דוח מטלות";

            //adding all columes titels to exel
            worksheet.Cells[1, 1] = "מספר מטלה";
            worksheet.Cells[1, 2] = "תיאור";
            worksheet.Cells[1, 3] = "תאריך יעד";
            worksheet.Cells[1, 4] = "פרטים";
            worksheet.Cells[1, 5] = "חייל מבצע";
            worksheet.Cells[1, 6] = "הסתיים";
            worksheet.Cells[1, 7] = "תאריך הזנה";
            worksheet.Cells[1, 8] = "מ.א מזין";
            worksheet.Cells[1, 9] = "סוג";
            // setting columes styels and fonts
            for (int i = 1; i <= 9; i++)
            {
                worksheet.Cells[1, i].Font.Bold = true;
                worksheet.Cells[1, i].WrapText = true;
                worksheet.Cells[1, i].Font.Size = 12;
            }
            //adding all rows content to exel
            int taskcounter = 0;
            for (int i = 2; taskcounter < obj.Count; i++)
            {
                // i is the exel line starts at 1
                // taskcounter is the tasks array starts at 0
                worksheet.Cells[i, 1] = obj[taskcounter].MyTask.TaskId;
                worksheet.Cells[i, 2] = obj[taskcounter].MyTask.MyTitle;
                worksheet.Cells[i, 3] = obj[taskcounter].MyTask.FinalDate;
                worksheet.Cells[i, 4] = obj[taskcounter].MyTask.TaskDetails;
                worksheet.Cells[i, 5] = obj[taskcounter].MyTask.WorkingOn;
                worksheet.Cells[i, 6] = BoolToHebString(obj[taskcounter].MyTask.TaskDone);
                worksheet.Cells[i, 7] = obj[taskcounter].MyTask.AssignedDate;
                worksheet.Cells[i, 8] = obj[taskcounter].MyTask.AssignedBy;
                worksheet.Cells[i, 9] = obj[taskcounter].MyTask.TaskTypeToString;
                taskcounter++;
            }

            //File output
            workbook.SaveAs(SaveExelFileDialog(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }
        private static void ExportExel_Equipment(List<SingleEquipmentView> obj)
        {
            // Function will get an Tasks object array and will export it to exel file

            // Exel declaraions
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //Setting up exel sheet
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "דוח ציוד";

            //adding all columes titels to exel
            worksheet.Cells[1, 1] = "תיאור";
            worksheet.Cells[1, 2] = "מספר סידורי";
            worksheet.Cells[1, 3] = "מספר חיל אוויר";
            worksheet.Cells[1, 4] = "פג תוקף";
            worksheet.Cells[1, 5] = "מחלקה";

            // setting columes styels and fonts
            for (int i = 1; i <= 5; i++)
            {
                worksheet.Cells[1, i].Font.Bold = true;
                worksheet.Cells[1, i].WrapText = true;
                worksheet.Cells[1, i].Font.Size = 12;
            }
            //adding all rows content to exel
            int taskcounter = 0;
            for (int i = 2; taskcounter < obj.Count; i++)
            {
                // i is the exel line starts at 1
                // taskcounter is the tasks array starts at 0
                worksheet.Cells[i, 1] = obj[taskcounter].MeDescription;
                worksheet.Cells[i, 2] = obj[taskcounter].MeSerialnumber;
                worksheet.Cells[i, 3] = obj[taskcounter].MeIafnumber;
                worksheet.Cells[i, 4] = obj[taskcounter].MeExpirationdate;
                worksheet.Cells[i, 5] = obj[taskcounter].MeDepartment;
                taskcounter++;
            }

            //File output
            workbook.SaveAs(SaveExelFileDialog(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }
        private static void ExportExel_HRForm(List<SingleHrView> obj)
        {
            // Function will get an Tasks object array and will export it to exel file

            // Exel declaraions
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //Setting up exel sheet
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "דוח ציוד";

            //adding all columes titels to exel
            worksheet.Cells[1, 1] = "מספר מזהה";
            worksheet.Cells[1, 2] = "מספר אישי";
            worksheet.Cells[1, 3] = "תיאור";
            worksheet.Cells[1, 4] = "מתאריך";
            worksheet.Cells[1, 5] = "עד תאריך";
            worksheet.Cells[1, 6] = "סוג";

            // setting columes styels and fonts
            for (int i = 1; i <= 6; i++)
            {
                worksheet.Cells[1, i].Font.Bold = true;
                worksheet.Cells[1, i].WrapText = true;
                worksheet.Cells[1, i].Font.Size = 12;
            }
            //adding all rows content to exel
            int taskcounter = 0;
            for (int i = 2; taskcounter < obj.Count; i++)
            {
                // i is the exel line starts at 1
                // taskcounter is the tasks array starts at 0
                worksheet.Cells[i, 1] = obj[taskcounter].HRid;
                worksheet.Cells[i, 2] = obj[taskcounter].PersonalID;
                worksheet.Cells[i, 3] = obj[taskcounter].MeDescription;
                worksheet.Cells[i, 4] = obj[taskcounter].FromDate;
                worksheet.Cells[i, 5] = obj[taskcounter].ToDate;
                worksheet.Cells[i, 6] = obj[taskcounter].Type;
                taskcounter++;
            }

            //File output
            try
            {
                workbook.SaveAs(SaveExelFileDialog(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception)
            {

                ErrHandler.ErrShow(3000, "שמירה בוטלה");
            }
          app.Quit();
        }
        public static void ExportExel_SwitchFunction(Object obj)
        {
            // This Function will decide what method to use for correct export
            // uses the object type to know how
            if (obj.GetType() == typeof(List<SingleHrView>))
            {   ExportExel_HRForm(obj as List<SingleHrView>);}

            if (obj.GetType() == typeof(List<SingleTaskView>))
            {ExportExel_Tasks_obj(obj as List<SingleTaskView>);}

            if (obj.GetType() == typeof(List<SingleEquipmentView>))
            { ExportExel_Equipment(obj as List<SingleEquipmentView>);}
        }

        private static string SaveExelFileDialog()
        {
             // open explorer dialog for file saving
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "Report - " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return "";
        }
        private static string BoolToHebString(bool sent)
        {
            if (sent)
            {
                return "כן"; // if true
            }
            else
            {
                return "לא"; // if false
            }
            return "";
        }
        public static void ExportExel_DataTable(DataTable dt)
        {
            //Exel declaraions
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "דוח";


            //adding all columes titels to exel
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i+1] = dt.Columns[i].ToString();

            }
            //adding all rows content to exel
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if(dt.Rows[i][j].GetType() == typeof(DateTime))
                    {
                        DateTime tmp = Convert.ToDateTime(dt.Rows[i][j]);
                        worksheet.Cells[i + 2, j + 1] = tmp.ToShortDateString();
                    } else
                    {
                        worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }

                }
            }
            //File output
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            app.Quit();
        }
        private static DataTable DataTableTranslator(DataTable dt)
        {

            // users
            dt.Columns["personalnumber"].ColumnName = "מספר אישי";
            dt.Columns["fname"].ColumnName = "שם";
            //e upkeep
            dt.Columns["UkID"].ColumnName = "מספר פעולה";
            dt.Columns["serialnumber"].ColumnName = "מספר סידורי";
            dt.Columns["upkeeptype"].ColumnName = "סוג";
            dt.Columns["upkeeptimespan"].ColumnName = "פרק זמן";
            dt.Columns["extrainfo"].ColumnName = "מידע נוסף";
            dt.Columns["expirationdate"].ColumnName = "פג תוקף";
            dt.Columns["upkeepdate"].ColumnName = "תאריך הוספה";
            dt.Columns["upkeekcreator"].ColumnName = "יוצר הפעולה";
            return dt;
        }

        // calling this will clear all the text boxes in the form send via parameters
        public static void RecurseClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox || control is ComboBox)
                    control.Text = String.Empty;
                else
                    RecurseClearAllTextBoxes(control);
            }
        }
        // this will convert the "TextBoxesNotEmpty" output to boolean one
        // anything over a 0 is false
        public static bool UserInputTest(Control parent)
        {
           int Result = TextBoxesNotEmpty(parent);
            if (Result > 0)
            {
               return false;
            }else
               return true;
        }
        //TextBoxesNotEmpty Vars
        static int TheTrueCounter = 0;
        //this will return how many fields are empty
        private static int TextBoxesNotEmpty(Control parent)
        {
            //int TheControlCounter = 0;
            
            foreach (Control control in parent.Controls)
            {
                //MessageBox.Show(parent.Controls.GetType() + "");
                if (control is TextBox || control is ComboBox)
                {
                    //TheControlCounter++;
                    if (control.Text == String.Empty) { TheTrueCounter++; }
                    //MessageBox.Show(TheTrueCounter +" | "+ TheControlCounter);
                }
                else
                    TextBoxesNotEmpty(control);
            }
            return TheTrueCounter;
        }

    }
}
