using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class inhouse: Part
    {
        private int MachineID;

        public void setMachineID(int a) { MachineID = a; }
        public int getMachineID() { return MachineID; }

        BindingList<Part> inpart = new BindingList<Part>();






    }
}
