using System.Diagnostics;
using System.IO;
using System.Reflection;
using Pegasus.Abstraction.Graph.Rendering;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;
using static Pegasus.Abstraction.Graph.Rendering.DebugRenderer;

namespace Pegasus.Abstraction.Graph.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);

            graph.AddVerticesAndEdge(new Edge<string>("test4", "test1"));
            graph.AddVerticesAndEdge(new Edge<string>("test2", "test4"));
            graph.AddVerticesAndEdge(new Edge<string>("test3", "test1"));
            graph.AddVerticesAndEdge(new Edge<string>("test4", "test3"));

            var graphviz = new GraphvizAlgorithm<string, Edge<string>>(graph);
            
            graphviz.FormatEdge += DebugRenderer.OnFormatEdge;
            graphviz.FormatVertex += DebugRenderer.OnFormatVertex;

            string output = graphviz.Generate(new FileDotEngine(), "graph");
        }
    }
}
