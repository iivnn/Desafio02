using Desafio02Library.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02.Forms
{
    public partial class ExceptionLogForm : Form
    {
        public ExceptionLogForm()
        {
            InitializeComponent();
            exceptionLogBindingSource.DataSource = LogController.GetAllExceptionLogs();
        }
    }
}
