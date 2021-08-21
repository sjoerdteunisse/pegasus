using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Pegasus.Abstraction.Graph.Rendering
{
    public class DebugRenderer
    {
        public static void OnFormatVertex(object obj, FormatVertexEventArgs<string> e)
        {
            e.VertexFormatter.Comment = e.Vertex.ToString();
            e.VertexFormatter.FillColor = GraphvizColor.Black;
        }

        public static void OnFormatEdge(object obj, FormatEdgeEventArgs<string, Edge<string>> e)
        {
            e.EdgeFormatter.Label.Value = e.Edge.ToString();

            e.EdgeFormatter.StrokeGraphvizColor = GraphvizColor.LightYellow;
            e.EdgeFormatter.StrokeGraphvizColor = GraphvizColor.LightYellow;
        }

        public class FileDotEngine : IDotEngine
        {
            public string Run(GraphvizImageType imageType, string dot, string outputFileName)
            {
                string output = outputFileName;
                File.WriteAllText(output, dot);

                var args = string.Format(@"{0} -Tjpg -O", output);
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Graphviz\bin\dot.exe", args);

                string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string img = Path.Combine(executableLocation, "graph.jpg");


                ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
                info.Arguments = "/k " + img;
                Process.Start(info);

                return output;
            }
        }
    }
}
