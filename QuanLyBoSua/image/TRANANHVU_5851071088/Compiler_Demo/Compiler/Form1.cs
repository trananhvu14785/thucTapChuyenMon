using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txStatus.Clear();
            CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion","v4.0" } });
            CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, "test.exe",true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, txSource.Text);
            if (results.Errors.HasErrors)
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => txStatus.Text += error.ErrorText + "\r\n");
            else
            {
                txStatus.Text = "Build Success!";
                Process.Start(Application.StartupPath + "/" + "test.exe");
            }
        }
    }
}
