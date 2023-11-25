using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weight
{
    public class HiLowForm
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Notify1 { get; set; }
        public string Notify2 { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
    }

    public class Japanese
    {
        public MainForm MainForm { get; set; }
        public SetupForm SetupForm { get; set; }
        public HiLowForm HiLowForm { get; set; }
        public NormalForm NormalForm { get; set; }
    }

    public class MainForm
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Mode1 { get; set; }
        public string Mode2 { get; set; }
        public string Language { get; set; }
    }

    public class NormalForm
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Notify1 { get; set; }
        public string Notify2 { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
    }

    public class Config
    {
        public string Version { get; set; }
        public VietNamese VietNamese { get; set; }
        public Japanese Japanese { get; set; }
    }

    public class SetupForm
    {
        public string NoneCe { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public string HaveCe { get; set; }
        public string TitleNotify { get; set; }
        public string NotifySucces { get; set; }
        public string Notify1 { get; set; }
        public string Notify2 { get; set; }
        public string Notify3 { get; set; }
        public string Notify4 { get; set; }
        public string Notify5 { get; set; }
        public string Notify6 { get; set; }
        public string Notify7 { get; set; }
        public string Notify8 { get; set; }
    }

    public class VietNamese
    {
        public MainForm MainForm { get; set; }
        public SetupForm SetupForm { get; set; }
        public HiLowForm HiLowForm { get; set; }
        public NormalForm NormalForm { get; set; }
    }
}
