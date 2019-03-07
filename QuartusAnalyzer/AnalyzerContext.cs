﻿using VerilogObjectModel;

namespace QuartusAnalyzer
{
    public class AnalyzerContext
    {
        public AnalyzerState AnalyzerState { get; set; }

        public ModuleDescription ModuleDescription { get; set; }

        public ModuleInstantiation ModuleInstantiation { get; set; }

        public AnalyzerContext()
        {
            AnalyzerState = AnalyzerState.Default;
            ModuleDescription = null;
            ModuleInstantiation = null;
        }
    }
}