﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//second_change
namespace car_rental
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          

            var main = new HomePage();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }

        //form_parent will be closed and form_son will be opened
        public static void OpenCenteredForm(Form form_Parent, Form form_son)
        {
            form_son.StartPosition = FormStartPosition.CenterScreen;
            form_son.Show();
            if (form_Parent != null)
                form_Parent.Close();
        }
        
        public static string userDetailsFile = Directory.GetCurrentDirectory() + "\\UserNameInput.txt";
        public static string userHistoryFile = Directory.GetCurrentDirectory() + "\\UsersPurchaes.txt";
       
    }
}

