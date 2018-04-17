using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using QuantConnect.Python;

namespace QuantConnect.ToolBox.Visualizer
{
    public class Visualizer :LeanDataReader
    {
        PandasConverter _converter = new PandasConverter();

        public Visualizer(string filepath) : base(filepath)
        {

        }

        public PyObject ParseDataFrame()
        {
            return _converter.GetDataFrame(base.Parse().ToArray());
        }
    }
}
