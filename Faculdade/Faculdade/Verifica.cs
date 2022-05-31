using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade
{
    class Verifica
    {
         public void VerificaNullorEmpty(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new NullReferenceException();
            }
        }
        public void VerificaMaskFull(MaskedTextBox valor)
        {
            if (!valor.MaskCompleted)
            {
                throw new NullReferenceException();
            }
        }

        public void VerificaCbxVazio(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
