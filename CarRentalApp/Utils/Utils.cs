using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp.Utils
{
    public static class Utils
    {
        public static bool FormOpen(string formName)
        {
            return Application.OpenForms
                              .Cast<Form>()
                              .Any(f => f.Name == formName);
        }
    }
}
