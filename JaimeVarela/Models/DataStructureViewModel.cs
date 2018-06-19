using System.Collections.Generic;
using JaimeVarela.Models;

namespace JaimeVarela.Models
{
    public class DataStructureViewModel
    {
        public List<DataStructureData> pocoObject;

        public DataStructureViewModel(List<DataStructureData> pocoObject)
        {
            this.pocoObject = pocoObject;
        }
    }
}