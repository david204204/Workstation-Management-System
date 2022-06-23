using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// This class will handle all errors and log them into a file
// for maneger use.
namespace FinalProjectForm.InterfaceClases
{
    public static class ErrHandler
    {
        private static string LogFile = AppContext.BaseDirectory + "/Err.txt"; // erorr log file name
        


        public static void ErrShow(int errnumber,string whathappend = "Oops there was an error", string title = "ERROR")
        {
            string newsubtext = whathappend + " | Erorr: " + errnumber; // adding err number
            SaveToFile(newsubtext );
            MessageBoxButtons buttons = MessageBoxButtons.OK; // setting the buttons
            MessageBox.Show(newsubtext, title, buttons, MessageBoxIcon.Error);// show mssage
        }


        public static void SaveToFile(String text)
        {// this will save the string to file
            // creats the file if nededd
            File.AppendAllText(LogFile, text + Environment.NewLine);
        }

    }
}
