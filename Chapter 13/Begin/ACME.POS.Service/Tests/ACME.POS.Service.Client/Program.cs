using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace ACME.POS.Service.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new
                UnhandledExceptionEventHandler(
                CurrentDomain_UnhandledException);

            try
            {
                Application.Run(new SearchForm());
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex,
                   "ACMEClientExceptionPolicy");

                DisplayExceptionMessage();
            }
            finally
            {
                Application.Exit();
            }

        }

        static void CurrentDomain_UnhandledException(object sender,
                UnhandledExceptionEventArgs e)
        {
            ExceptionPolicy.HandleException(
                (Exception)e.ExceptionObject,
                "ACMEClientExceptionPolicy");

            DisplayExceptionMessage();

            if (!e.IsTerminating)
                Application.Exit();
        }


        static void DisplayExceptionMessage()
        {
            MessageBox.Show("An unexpected problem has occurred "
               + "with the ACME POS application.\n"
               + "This application will now close down. "
               + "Any unsaved data may be lost."
               , "Unexpected Problem", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
        }
    }

}