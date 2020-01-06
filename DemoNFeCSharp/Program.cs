using NFeDataSetX;
using NFeX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoNFeCSharp
{
    static class Program
    {
        public static spdNFeX spdNFe = new spdNFeX();
        public static spdNFeDataSetX spdNFeDataSet = new spdNFeDataSetX();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
