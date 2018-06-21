using System;
using System.Collections.Generic;

namespace JaimeVarela.Models
{
    public class DataStructureData
    {
        public string Language {get; set;}

        public List<string> header {get; set;}

        public string Description {get; set;}
        public List<DataStructureInfo> DataStructures {get; set;}
    }    
}
