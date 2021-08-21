using System.IO;
using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;

namespace Pegasus.Abstraction.Graph.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);

            graph.AddVerticesAndEdge(new Edge<string>("test", "test"));
            graph.AddVerticesAndEdge(new Edge<string>("test1", "test"));

            graph.AddVerticesAndEdge(new Edge<string>("test2", "test1"));
            graph.AddVerticesAndEdge(new Edge<string>("test2", "test1"));
            graph.AddVerticesAndEdge(new Edge<string>("test2", "test1"));


            var graphviz = new GraphvizAlgorithm<string, Edge<string>>(graph);
            graphviz.FormatEdge += OnFormatEdge;

            string output = graphviz.Generate(new FileDotEngine(), "graph");
        }

        public static void OnFormatEdge(object obj, FormatEdgeEventArgs<string, Edge<string>> e)
        {
            e.EdgeFormatter.Label.Value = e.Edge.ToString();
            e.EdgeFormatter.StrokeGraphvizColor = GraphvizColor.Black;
        }

        public sealed class FileDotEngine : IDotEngine
        {
            public string Run(GraphvizImageType imageType, string dot, string outputFileName)
            {
                string output = outputFileName;
                File.WriteAllText(output, dot);

                var args = string.Format(@"{0} -Tjpg -O", output);
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Graphviz\bin\dot.exe", args);
                return output;
            }
        }
    }
}
