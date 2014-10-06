using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAPICodePack.Shell;

namespace TestRig
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf";

            var document = ShellObject.FromParsingName(fileName);

        }
    }
}
