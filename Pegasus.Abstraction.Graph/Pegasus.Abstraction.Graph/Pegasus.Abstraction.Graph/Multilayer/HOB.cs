
using QuickGraph;
using System;
using System.Collections.Generic;

namespace Pegasus.Abstraction.Graph.Multilayer
{
    public class HOB<TVertex, TEdge> : IEdgeListAndIncidenceGraph<TVertex, TEdge>, IMutableVertexAndEdgeListGraph<TVertex, TEdge>, IMutableVertexListGraph<TVertex, TEdge>, IMutableIncidenceGraph<TVertex, TEdge>, IMutableVertexAndEdgeSet<TVertex, TEdge>, IMutableVertexSet<TVertex>, IMutableEdgeListGraph<TVertex, TEdge>, IMutableGraph<TVertex, TEdge>, IVertexAndEdgeListGraph<TVertex, TEdge>, IVertexListGraph<TVertex, TEdge>, IIncidenceGraph<TVertex, TEdge>, IImplicitGraph<TVertex, TEdge>, IEdgeListGraph<TVertex, TEdge>, IGraph<TVertex, TEdge>, IEdgeSet<TVertex, TEdge>, IVertexSet<TVertex>, IImplicitVertexSet<TVertex> where TEdge : IEdge<TVertex>
    {
        public bool IsDirected => throw new NotImplementedException();

        public bool AllowParallelEdges => throw new NotImplementedException();

        public event EventHandler Cleared;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void ClearOutEdges(TVertex v)
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdge(TVertex source, TVertex target)
        {
            throw new NotImplementedException();
        }

        public bool ContainsVertex(TVertex vertex)
        {
            throw new NotImplementedException();
        }

        public bool IsOutEdgesEmpty(TVertex v)
        {
            throw new NotImplementedException();
        }

        public int OutDegree(TVertex v)
        {
            throw new NotImplementedException();
        }

        public TEdge OutEdge(TVertex v, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEdge> OutEdges(TVertex v)
        {
            throw new NotImplementedException();
        }

        public int RemoveOutEdgeIf(TVertex v, EdgePredicate<TVertex, TEdge> predicate)
        {
            throw new NotImplementedException();
        }

        public void TrimEdgeExcess()
        {
            throw new NotImplementedException();
        }

        public bool TryGetEdge(TVertex source, TVertex target, out TEdge edge)
        {
            throw new NotImplementedException();
        }

        public bool TryGetEdges(TVertex source, TVertex target, out IEnumerable<TEdge> edges)
        {
            throw new NotImplementedException();
        }

        public bool TryGetOutEdges(TVertex v, out IEnumerable<TEdge> edges)
        {
            throw new NotImplementedException();
        }
    }
}
