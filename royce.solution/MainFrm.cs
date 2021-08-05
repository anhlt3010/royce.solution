using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace royce.solution // by royce#1607
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        #region "DLLImport"
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandleA(string lpModuleName);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);
        #endregion

        private void loadbypass_btn_Click(object sender, EventArgs e)
        {
            IntPtr Ragexe_ProcessHandle = Process.GetProcessesByName("Ragexe")[0].Handle;
            IntPtr Ragexe_BaseAddress = Process.GetProcessesByName("Ragexe")[0].MainModule.BaseAddress;
            int[] pointer = { 0x921C94, 0x921CA0, 0x921CAC, 0x921CC4, 0xBDC96D };
            byte[] toWrite = { 0x72, 0x6F, 0x79, 0x63, 0x65 };
            byte[] read = new byte[4];
            IntPtr KERNEL32_READPROCESSMEMORY = GetProcAddress(GetModuleHandleA("kernel32.dll"), "ReadProcessMemory");

            for (int i = 0; i < pointer.Length; i++)
            {
                WriteProcessMemory(Ragexe_ProcessHandle, Ragexe_BaseAddress + pointer[i], toWrite, toWrite.Length, 0);
            }

            WriteProcessMemory(Ragexe_ProcessHandle, KERNEL32_READPROCESSMEMORY, new byte[] { 0xEB, 0xFE }, 2, 0);
            ReadProcessMemory(Ragexe_ProcessHandle, KERNEL32_READPROCESSMEMORY, read, read.Length, 0);

            if ((BitConverter.ToInt32(read, 0)) == -1957298453) // Check bypass status from KERNEL32_READPROCESSMEMORY
            {
                loadbypass_btn.Text = "Bypass Successfully!";
            }
            else
            {
                loadbypass_btn.Text = "Bypass Failed!";
            }

            // INJECT DLL (Manual inject dll or code it by yourself or whatever)
        }
    }
}
